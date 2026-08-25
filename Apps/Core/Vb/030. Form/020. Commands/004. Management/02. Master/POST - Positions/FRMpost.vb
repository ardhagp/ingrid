Imports System.Text

Namespace UI.Canvas
    Public Class FRMpost
#Region "Declaration"
        Private WithEvents Frm_post_Editor As New FRMpostEditor
        Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip

        ' This Module Identifier
        Private varThisModuleId As Long = 0
        Private Const varThisModuleCode As String = "POST"
#End Region

#Region "Subs Collections"
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GetData(Optional forcerefresh As Boolean = False)
            DblBuffer(DgnPOST)
            varDataProperties.EmployeePositionIsForceRefresh = forcerefresh
            CMDpost.View.DisplayData(varDataProperties, DgnPOST, SLFStatus, TxtFind)
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GetRowID()
            With varDataProperties
                If DgnPOST.RowCount = 0 Then
                    .EmployeePositionIsNew = True
                Else
                    .EmployeePositionIsNew = False
                    SetValue(.AllParameters, tPosition.P_PositionId, CLng(DgnPOST.CurrentRow.Cells(tPosition.C_PositionId).Value))
                End If
            End With
        End Sub
#End Region

#Region "Menu Strip Functions"
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataAddNew() Handles Com_mms_Menu.EventDataAddNew
            varDataProperties.SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Add
            If Not (varUserAccess.User(varDataProperties)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Add new record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            varDataProperties.EmployeePositionIsNew = True
            Frm_post_Editor = New FRMpostEditor
            Display(Frm_post_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Add New Record", "Add new job position data", True)
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataEdit() Handles Com_mms_Menu.EventDataEdit
            varDataProperties.SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Edit
            If Not (varUserAccess.User(varDataProperties)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Modify existing record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            Call GetRowID()

            If varDataProperties.EmployeePositionIsNew Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No Record Selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
            Else
                Frm_post_Editor = New FRMpostEditor
                Display(Frm_post_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Update Record", "Update your position data", True)
            End If
            UI.Canvas.FRMmainframe6.Ts_status.Text = String.Empty
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataDelete() Handles Com_mms_Menu.EventDataDelete
            varDataProperties.SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Delete
            If Not (varUserAccess.User(varDataProperties)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Delete record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            Call GetRowID()

            If varDataProperties.EmployeePositionIsNew Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No Record Selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
            Else
                With DgnPOST.CurrentRow
                    Dim varMessage As New StringBuilder()
                    varMessage.AppendLine("Do you want to delete this record?")

                    Dim varLine As String = New String("─"c, 80)
                    varMessage.AppendLine(varLine)

                    varMessage.AppendLine("Employee ID : " & .Cells("employee_number").Value.ToString & Environment.NewLine &
                            "Employee Name : " & .Cells("employee_fullname").Value.ToString & Environment.NewLine &
                            "Company : " & .Cells("company_name").Value.ToString & Environment.NewLine &
                            "Department : " & .Cells("department_name").Value.ToString & Environment.NewLine &
                            "Position : " & .Cells("positition_name").Value.ToString & Environment.NewLine &
                            "Grade : " & .Cells("grade_code").Value.ToString)

                    varMessage.AppendLine(varLine)
                    If Decision(My.Application.Info.AssemblyName.ToUpper, "Do you want to delete this record?", LibApp.Ingrid.Global.PopupType.Delete, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Question, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.YesNo) = System.Windows.Forms.DialogResult.Yes AndAlso (LibSQL.CMDpost.View.DeleteData(varDataProperties, varDatasetIngrid)) Then
                        Call GetData(True)
                        UI.Canvas.FRMmainframe6.Ts_status.Text = "Success"
                    Else
                        UI.Canvas.FRMmainframe6.Ts_status.Text = "Delete failed"
                    End If
                End With
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataRefresh() Handles Com_mms_Menu.EventDataRefresh
            TxtFind.Clear()
            Call GetData(True)
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataClose() Handles Com_mms_Menu.EventDataClose
            Me.Close()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataFind() Handles Com_mms_Menu.EventToolsFind
            TxtFind.Focus()
        End Sub

#End Region

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMpost_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Set active module to UserParameters
            With varDataProperties
                SetValue(.AllParameters, tModule.P_ModuleCode, varThisModuleCode)
                varThisModuleId = CMDmods.View.GetModuleIdByCode(varDataProperties, varDataProperties.AllParameters)
                SetModuleIdentifier(varDataProperties.AllParameters, varThisModuleCode, varThisModuleId)
            End With

            ' Continue to Load anything for this module
            Com_mms_Menu.LoadIn(Me)
            Com_mms_Menu.ShowMenuData(CMCv.UI.View.MenuStrip.ShowItem.Yes)
            DgnPOST.XOGetNewColor()
            Call GetData(True)
            TxtFind.ClearSearch()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
            If e.KeyCode = Keys.Enter Then
                Call GetData()
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            TxtFind.Clear()
            Call GetData(True)
            TxtFind.ClearSearch()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMpostEditor_RecordSaved() Handles Frm_post_Editor.EventRecordSaved
            Call GetData(True)
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMpost_Activated(sender As Object, e As EventArgs) Handles Me.Activated
            ' Set active module to UserParameters
            SetValue(varDataProperties.AllParameters, tIngrid.P_ModuleCode, varThisModuleCode)
        End Sub
    End Class
End Namespace