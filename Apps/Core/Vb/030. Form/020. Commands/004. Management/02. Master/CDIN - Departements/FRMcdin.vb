Imports System.Runtime.Versioning
Imports System.Text

Namespace UI
    Public Class FRMcdin

#Region "Declaration"
        Private WithEvents Frm_cdin_Editor As FRMcdinEditor
        Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip

        Private Const pDepartmentId As String = "@DepartmentId"
#End Region

#Region "Subs Collections"
        <SupportedOSPlatform("windows")>
        Private Sub GetData(Optional forcerefresh As Boolean = False)
            DblBuffer(DgnCDIN)
            varDataProperties.DepartmentIsForceRefresh = forcerefresh
            LibSQL.CMDcdin.View.DisplayData(varDataProperties, DgnCDIN, SLFStatus, TxtFind)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub GetRowID()
            varDataProperties.AllParameters.Remove(pDepartmentId)
            If DgnCDIN.RowCount = 0 Then
                varDataProperties.DepartmentIsNew = True
            Else
                varDataProperties.DepartmentIsNew = False
                varDataProperties.AllParameters.Add(pDepartmentId, CLng(DgnCDIN.CurrentRow.Cells("department_id").Value))
            End If
        End Sub

#End Region

#Region "Menu Strip Function"
        <SupportedOSPlatform("windows")>
        Private Sub EventDataAddNew() Handles Com_mms_Menu.EventDataAddNew
            varDataProperties.DepartmentIsNew = True
            Frm_cdin_Editor = New FRMcdinEditor
            Display(Frm_cdin_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Add New Record", "Add new departement data", True)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub EventDataEdit() Handles Com_mms_Menu.EventDataEdit
            Call GetRowID()
            If varDataProperties.DepartmentIsNew Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Else
                Frm_cdin_Editor = New FRMcdinEditor
                Display(Frm_cdin_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Update Record", "Update your departement data", True)
            End If
            UI.FRMmainframe6.Ts_status.Text = String.Empty
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub EventDataDelete() Handles Com_mms_Menu.EventDataDelete
            Call GetRowID()
            If varDataProperties.DepartmentIsNew Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Else
                With DgnCDIN.CurrentRow
                    Dim varMessage As New StringBuilder()
                    varMessage.AppendLine("Do you want to delete this record?")

                    Dim varLine As String = New String("─"c, 80)
                    varMessage.AppendLine(varLine)

                    varMessage.AppendLine("Department ID : " & .Cells("department_id").Value.ToString & Environment.NewLine &
                        "Department Code : " & .Cells("department_code").Value.ToString & Environment.NewLine &
                        "Department Name : " & .Cells("department_name").Value.ToString & Environment.NewLine &
                        "Description : " & .Cells("department_description").Value.ToString)

                    varMessage.AppendLine(varLine)

                    If Decision(My.Application.Info.AssemblyName.ToUpper, Convert.ToString(varMessage), LibApp.Ingrid.Global.PopupType.Delete, "", CMCv.FRMdialogbox.MessageIcon.Question, CMCv.FRMdialogbox.MessageTypes.YesNo) = System.Windows.Forms.DialogResult.Yes AndAlso (LibSQL.CMDcdin.View.DeleteData(varDataProperties, varDatasetIngrid)) Then
                        Call GetData(True)
                        UI.FRMmainframe6.Ts_status.Text = "Success"
                    Else
                        UI.FRMmainframe6.Ts_status.Text = "Delete failed"
                    End If
                End With
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub EventDataRefresh() Handles Com_mms_Menu.EventDataRefresh
            TxtFind.Clear()
            Call GetData(True)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub EventDataClose() Handles Com_mms_Menu.EventDataClose
            Me.Close()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub EventToolsFind() Handles Com_mms_Menu.EventToolsFind
            TxtFind.Focus()
        End Sub
#End Region

#Region "Form Events"
        <SupportedOSPlatform("windows")>
        Private Sub FRMcdin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Com_mms_Menu.LoadIn(Me)
            Com_mms_Menu.ShowMenuData(CMCv.UI.View.MenuStrip.ShowItem.Yes)
            DgnCDIN.XOGETNewColor()
            Call GetData(True)
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
End Namespace