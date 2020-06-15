Imports CMCv
Imports LibSQL

Public Class CCIN
#Region "Variables"
    Private _SQL As New LibSQL.Commands.CCIN.View
    Private WithEvents _CCIN_Editor As CCIN_Editor
    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip
#End Region

#Region "Function Collections"

#End Region

#Region "Sub Collections"

    ''' <summary>
    ''' Untuk mengambil data dari database
    ''' </summary>
    ''' <param name="ForceRefresh">True/False</param>
    ''' <remarks></remarks>
    Private Sub GETDATA(Optional ForceRefresh As Boolean = False)
        _SQL.DisplayData(DgnCCIN, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    Private Sub GETTableID()
        If DgnCCIN.RowCount = 0 Then
            _FORMAttrib.RowID = "-1"
        Else
            _FORMAttrib.RowID = DgnCCIN.CurrentRow.Cells("company_id").Value
        End If
    End Sub
#End Region

#Region "Menu Strip Function"
    Private Sub EventDataAddNew() Handles _MMSMenu.EventDataAddNew
        _FORMAttrib.IsNew = True
        _FORMAttrib.RowID = "-1"
        _CCIN_Editor = New CCIN_Editor
        Display(_CCIN_Editor, IMAGEDB.Main.ImageLibrary.EDIT_002_512_icon, "Add New Record", "Add new company data", True)
    End Sub

    Private Sub EventDataEdit() Handles _MMSMenu.EventDataEdit
        Call GETTableID()
        If _FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            _FORMAttrib.IsNew = False
            _CCIN_Editor = New CCIN_Editor
            Display(_CCIN_Editor, IMAGEDB.Main.ImageLibrary.EDIT_002_512_icon, "Update Record", "Update your company data", True)
        End If
    End Sub

    Private Sub EventDataDelete() Handles _MMSMenu.EventDataDelete
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

    Private Sub EventDataRefresh() Handles _MMSMenu.EventDataRefresh
        TxtFind.Clear()
        Call GETDATA(True)
    End Sub

    Private Sub EventDataClose() Handles _MMSMenu.EventDataClose
        Me.Close()
    End Sub

    Private Sub EventToolsFind() Handles _MMSMenu.EventToolsFind
        TxtFind.Focus()
    End Sub
#End Region

#Region "Form Events"
    Private Sub frmCompany_Load(sender As Object, e As EventArgs) Handles Me.Load
        _MMSMenu.LoadIn(Me)
        _MMSMenu.ShowMenuDATA(UI.View.MenuStrip.ShowItem.Yes)
        Call GETDATA(True)
    End Sub
#End Region

#Region "Component Events"
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA()
        End If
    End Sub

    Private Sub TxtFind_TextChanged(sender As Object, e As EventArgs) Handles TxtFind.TextChanged

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub
#End Region


    Private Sub _CCIN_Editor_RecordSaved() Handles _CCIN_Editor.RecordSaved
        Call GETDATA(True)
    End Sub

End Class
