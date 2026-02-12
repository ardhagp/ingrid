Imports System.Runtime.Versioning

Public Class FRMcdin

#Region "Declaration"
    Private WithEvents Frm_cdin_Editor As FRMcdinEditor
    Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip
#End Region

#Region "Subs Collections"
    <SupportedOSPlatform("windows")>
    Private Sub GetData(Optional ByVal forcerefresh As Boolean = False)
        LibSQL.CMDcdin.View.DisplayData(varDatabaseName, varDatabaseEngine, DgnCDIN, SLFStatus, TxtFind, forcerefresh)
    End Sub

    Private Sub GetRowID()
        If DgnCDIN.RowCount = 0 Then
            varFormProperties.RowID = "-1"
        Else
            varFormProperties.RowID = DgnCDIN.CurrentRow.Cells("department_id").Value.ToString
        End If
    End Sub

#End Region

#Region "Menu Strip Function"
    <SupportedOSPlatform("windows")>
    Private Sub EventDataAddNew() Handles Com_mms_Menu.EventDataAddNew
        varFormProperties.IsNew = True
        varFormProperties.RowID = "-1"
        Frm_cdin_Editor = New FRMcdinEditor
        Display(Frm_cdin_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Add New Record", "Add new departement data", True)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataEdit() Handles Com_mms_Menu.EventDataEdit
        Call GetRowID()
        If Convert.ToString(varFormProperties.RowID) = "-1" Then
            Decision(My.Application.Info.AssemblyName, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        Else
            varFormProperties.IsNew = False
            Frm_cdin_Editor = New FRMcdinEditor
            Display(Frm_cdin_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Update Record", "Update your departement data", True)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles Com_mms_Menu.EventDataDelete
        Call GetRowID()
        If Convert.ToString(varFormProperties.RowID) = "-1" Then
            Decision(My.Application.Info.AssemblyName, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        Else
            If Decision(My.Application.Info.AssemblyName, "Do you want to delete this record?", LibApp.Ingrid.Global.PopupType.Delete, "", CMCv.FRMdialogbox.MessageIcon.Question, CMCv.FRMdialogbox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (LibSQL.CMDcdin.View.DeleteData(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))) Then
                    Call GetData(True)
                    FRMmainframe6.Ts_status.Text = "Success"
                Else
                    FRMmainframe6.Ts_status.Text = "Delete failed"
                End If
            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataRefresh() Handles Com_mms_Menu.EventDataRefresh
        TxtFind.Clear()
        Call GetData(True)
    End Sub

    Private Sub EventDataClose() Handles Com_mms_Menu.EventDataClose
        Me.Close()
    End Sub

    Private Sub EventToolsFind() Handles Com_mms_Menu.EventToolsFind
        TxtFind.Focus()
    End Sub
#End Region

#Region "Form Events"
    <SupportedOSPlatform("windows")>
    Private Sub FRMcdin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Com_mms_Menu.LoadIn(Me)
        Com_mms_Menu.ShowMenuData(CMCv.UI.View.MenuStrip.ShowItem.Yes)
        Call GetData()
        TxtFind.ClearSearch()
    End Sub
#End Region

#Region "Component Events"
    <SupportedOSPlatform("windows")>
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GetData()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GetData(True)
        TxtFind.ClearSearch()
    End Sub
#End Region

    <SupportedOSPlatform("windows")>
    Private Sub FRMcdinEditor_RecordSaved() Handles Frm_cdin_Editor.EventRecordSaved
        Call GetData()
    End Sub

End Class
