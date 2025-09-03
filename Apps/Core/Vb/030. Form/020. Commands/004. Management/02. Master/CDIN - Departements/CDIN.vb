Imports System.Runtime.Versioning

Public Class CDIN

#Region "Variables"
    Private _SQL As New LibSQL.Commands.CDIN.View
    Private WithEvents _CDIN_Editor As CDIN_Editor
    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip
#End Region

#Region "Subs Collections"
    <SupportedOSPlatform("windows")>
    Private Sub GETDATA(Optional ByVal ForceRefresh As Boolean = False)
        LibSQL.Commands.CDIN.View.DISPLAYDATA(V_DatabaseEngine, DgnCDIN, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    Private Sub GETTableID()
        If DgnCDIN.RowCount = 0 Then
            V_FORMAttrib.RowID = "-1"
        Else
            V_FORMAttrib.RowID = DgnCDIN.CurrentRow.Cells("department_id").Value.ToString
        End If
    End Sub

#End Region

#Region "Menu Strip Function"
    <SupportedOSPlatform("windows")>
    Private Sub EventDataAddNew() Handles _MMSMenu.EventDataAddNew
        V_FORMAttrib.IsNew = True
        V_FORMAttrib.RowID = "-1"
        _CDIN_Editor = New CDIN_Editor
        Display(_CDIN_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new departement data", True)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataEdit() Handles _MMSMenu.EventDataEdit
        Call GETTableID()
        If V_FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            V_FORMAttrib.IsNew = False
            _CDIN_Editor = New CDIN_Editor
            Display(_CDIN_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your departement data", True)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles _MMSMenu.EventDataDelete
        Call GETTableID()
        If V_FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (LibSQL.Commands.CDIN.View.DELETEDATA(V_DatabaseEngine, V_FORMAttrib.RowID)) Then
                    Call GETDATA(True)
                    Mainframe_n_6.Ts_status.Text = "Success"
                Else
                    Mainframe_n_6.Ts_status.Text = "Delete failed"
                End If
            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
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
    <SupportedOSPlatform("windows")>
    Private Sub CDIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _MMSMenu.LoadIn(Me)
        _MMSMenu.ShowMenuDATA(CMCv.UI.View.MenuStrip.ShowItem.Yes)
        Call GETDATA()
        TxtFind.ClearSearch()
    End Sub
#End Region

#Region "Component Events"
    <SupportedOSPlatform("windows")>
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub
#End Region

    <SupportedOSPlatform("windows")>
    Private Sub _CDIN_Editor_RecordSaved() Handles _CDIN_Editor.RecordSaved
        Call GETDATA()
    End Sub

End Class
