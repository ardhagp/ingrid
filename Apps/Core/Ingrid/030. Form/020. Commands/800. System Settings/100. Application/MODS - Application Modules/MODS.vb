Public Class MODS
#Region "Variables"
    Private _SQL As New LibSQL.Commands.MODS.View
    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip
    Private WithEvents _MODS_Editor As New MODS_Editor
    Public Event DATACHANGED()
#End Region

#Region "Subs Collection"
    Private Sub GETDATA(Optional ByVal ForceRefresh As Boolean = False)
        DblBuffer(DgnMODS)
        _SQL.DisplayData(DgnMODS, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    Private Sub GETTableID()
        _FORMAttrib.RowID = "-1"

        If DgnMODS.RowCount > 0 Then
            _FORMAttrib.RowID = DgnMODS.CurrentRow.Cells("module_id").Value
        End If
    End Sub
#End Region

#Region "Menu Strip Functions"
    Private Sub _MMSMenu_EventDataAddNew() Handles _MMSMenu.EventDataAddNew
        If _USERAccess.User("MODS", _USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Add) = False Then
            Decision("You are not authorized to : Add new record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        End If
        _FORMAttrib.IsNew = True
        _FORMAttrib.RowID = "-1"
        _FORMAttrib.Hash = _SECEncrypt.MD5
        _MODS_Editor = New MODS_Editor
        Display(_MODS_Editor, IMAGEDB.Main.ImageLibrary.EDIT_002_512_icon, "Add New Record", "Add new module", True)
    End Sub

    Private Sub EventDataEdit() Handles _MMSMenu.EventDataEdit
        If _USERAccess.User("UAC", _USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Edit) = False Then
            Decision("You are not authorized to : Modify existing record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        End If
        Call GETTableID()
        _FORMAttrib.IsNew = False
        If _FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            _FORMAttrib.IsNew = False
            _MODS_Editor = New MODS_Editor
            Display(_MODS_Editor, IMAGEDB.Main.ImageLibrary.EDIT_002_512_icon, "Update Record", "Update your employee data", True)
        End If
    End Sub

    Private Sub EventDataDelete() Handles _MMSMenu.EventDataDelete
        If _USERAccess.User("MODS", _USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Delete) = False Then
            Decision("You are not authorized to : Delete record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        End If
        Call GETTableID()
        If _FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If _SQL.DELETEData(_FORMAttrib.RowID) = True Then
                    Call GETDATA(True)
                    RaiseEvent DATACHANGED()
                    mainframe.ts_status.Text = "Success"
                Else
                    mainframe.ts_status.Text = "Delete failed"
                End If
            End If
        End If
    End Sub

    Private Sub EventDataRefresh() Handles _MMSMenu.EventDataRefresh
        TxtFind.Clear()
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub

    Private Sub EventDataClose() Handles _MMSMenu.EventDataClose
        Me.Close()
    End Sub

    Private Sub EventToolsFind() Handles _MMSMenu.EventToolsFind
        TxtFind.Focus()
    End Sub
#End Region

#Region "Form Events"
    Private Sub MODS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _MMSMenu.LoadIn(Me)
        _MMSMenu.ShowMenuDATA(CMCv.UI.View.MenuStrip.ShowItem.Yes)
        TxtFind.ClearSearch()
        DgnMODS.SLF_GETNewColor()
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub

    Private Sub TxtFind_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA()
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub

    Private Sub _MMSMenu_EventToolsFind() Handles _MMSMenu.EventToolsFind
        TxtFind.Focus()
    End Sub

    Private Sub _MODS_Editor_RecordSaved() Handles _MODS_Editor.RecordSaved
        Call GETDATA()
        RaiseEvent DATACHANGED()
    End Sub

#End Region
End Class
