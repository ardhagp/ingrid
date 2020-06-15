Public Class PLNT
    Private _SQL As New LibSQL.Commands.PLNT.View
    Private WithEvents _PLNT_Editor As New PLNT_Editor
    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip

#Region "Sub Collections"
    Private Sub GETDATA(Optional ByVal ForceRefresh As Boolean = False)
        DblBuffer(DgnPLNT)
        _SQL.DisplayData(DgnPLNT, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    Private Sub ClearFind()
        Call GETDATA(True)
    End Sub

    ''' <summary>
    ''' Get row ID on record clicked
    ''' </summary>
    Private Sub GETTableID()
        _FORMAttrib.RowID = "-1"

        If DgnPLNT.RowCount > 0 Then
            _FORMAttrib.RowID = DgnPLNT.CurrentRow.Cells("plant_id").Value
        End If
    End Sub

#End Region

#Region "Menu Strip Functions"
    ''' <summary>
    ''' Add new data
    ''' </summary>
    Private Sub _MMSMenu_EventDataAddNew() Handles _MMSMenu.EventDataAddNew
        If _USERAccess.User("PLNT", _USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Add) = False Then
            Decision("You are not authorized to : Add new record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        End If
        _FORMAttrib.IsNew = True
        _FORMAttrib.RowID = "-1"
        _PLNT_Editor = New PLNT_Editor
        Display(_PLNT_Editor, IMAGEDB.Main.ImageLibrary.EDIT_002_512_icon, "Add New Record", "Add new plant", True)
        mainframe.ts_status.Text = String.Empty
    End Sub

    Private Sub _MMSMenu_EventDataEdit() Handles _MMSMenu.EventDataEdit
        If _USERAccess.User("PLNT", _USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Edit) = False Then
            Decision("You are not authorized to : Modify existing record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        End If
        Call GETTableID()
        _FORMAttrib.IsNew = False
        If _FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            _PLNT_Editor = New PLNT_Editor
            Display(_PLNT_Editor, IMAGEDB.Main.ImageLibrary.EDIT_002_512_icon, "Update Record", "Update plant data", True)
        End If
        mainframe.ts_status.Text = String.Empty
    End Sub

    Private Sub _MMSMenu_EventDataDelete() Handles _MMSMenu.EventDataDelete
        If _USERAccess.User("PLNT", _USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Delete) = False Then
            Decision("You are not authorized to : Delete record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        End If
        Call GETTableID()
        If _FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            _FORMAttrib.IsNew = False
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If _SQL.DELETEData(_FORMAttrib.RowID) = True Then
                    Call GETDATA(True)
                    mainframe.ts_status.Text = "Success"
                Else
                    mainframe.ts_status.Text = "Delete failed"
                End If
            End If
        End If
    End Sub

    Private Sub _MMSMenu_EventDataRefresh() Handles _MMSMenu.EventDataRefresh
        TxtFind.Clear()
        Call GETDATA(True)
    End Sub

    Private Sub _MMSMenu_EventDataClose() Handles _MMSMenu.EventDataClose
        Me.Close()
    End Sub
#End Region

#Region "Upper Form Bar"

#End Region

#Region "Main Form Events"
    Private Sub PLNT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _MMSMenu.LoadIn(Me)
        DgnPLNT.SLF_GETNewColor()
        Call ClearFind()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Call ClearFind()
        TxtFind.ClearSearch()
    End Sub
#End Region

End Class
