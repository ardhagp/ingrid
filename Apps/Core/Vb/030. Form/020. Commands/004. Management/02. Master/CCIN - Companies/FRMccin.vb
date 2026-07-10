'Imports System.Runtime.Versioning
Imports System.Text

Namespace UI.Canvas
    Public Class FRMccin
#Region "Declaration"
        Private WithEvents Frm_ccin_Editor As New FRMccinEditor
        Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip

        'Parameters
        Private varThisModuleId As Long = 0
        Private Const varThisModuleCode As String = "CCIN"
#End Region

#Region "Sub Collections"

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="forcerefresh"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GetData(Optional forcerefresh As Boolean = False)
            DblBuffer(DgnCCIN)
            varDataProperties.CompanyIsForceRefresh = forcerefresh
            CMDccin.View.DisplayData(varDataProperties, DgnCCIN, SLFStatus, TxtFind)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GetRowID()
            With varDataProperties
                If DgnCCIN.RowCount = 0 Then
                    .CompanyIsNew = True
                Else
                    .CompanyIsNew = False
                    SetValue(.AllParameters, tCompany.P_CompanyId, CLng(DgnCCIN.CurrentRow.Cells("company_id").Value))
                End If
            End With
        End Sub
#End Region

#Region "Menu Strip Function"
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataAddNew() Handles Com_mms_Menu.EventDataAddNew
            With varDataProperties
                .SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Add
                If Not (varUserAccess.User(varDataProperties)) Then
                    Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Add new record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                    Return
                End If

                .CompanyIsNew = True
                Frm_ccin_Editor = New FRMccinEditor
                Display(Frm_ccin_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Add New Record", "Add new company data", True)
            End With
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataEdit() Handles Com_mms_Menu.EventDataEdit
            varDataProperties.SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Edit
            If Not (varUserAccess.User(varDataProperties)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Modify existing record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            Call GetRowID()

            If varDataProperties.CompanyIsNew Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
            Else
                Frm_ccin_Editor = New FRMccinEditor
                Display(Frm_ccin_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Update Record", "Update your company data", True)
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

            If varDataProperties.CompanyIsNew Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
            Else
                With DgnCCIN.CurrentRow
                    Dim varMessage As New StringBuilder()
                    varMessage.AppendLine("Do you want to delete this record?")

                    Dim varLine As New String("─"c, 80)
                    varMessage.AppendLine(varLine)

                    varMessage.AppendLine("Company ID : " & .Cells("company_id").Value.ToString & Environment.NewLine &
                        "Company Code : " & .Cells("company_code").Value.ToString & Environment.NewLine &
                        "Company Name : " & .Cells("company_name").Value.ToString & Environment.NewLine &
                        "Search Term1 : " & .Cells("company_searchterm1").Value.ToString & Environment.NewLine &
                        "Search Term2 : " & .Cells("company_searchterm1").Value.ToString & Environment.NewLine &
                        "Description : " & .Cells("company_description").Value.ToString)

                    varMessage.AppendLine(varLine)

                    If Decision(My.Application.Info.AssemblyName.ToUpper, Convert.ToString(varMessage), LibApp.Ingrid.Global.PopupType.Delete, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Question, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.YesNo) = System.Windows.Forms.DialogResult.Yes AndAlso LibSQL.CMDccin.View.DeleteData(varDataProperties, varDatasetIngrid) Then
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
        Private Sub EventToolsFind() Handles Com_mms_Menu.EventToolsFind
            TxtFind.Focus()
        End Sub
#End Region

#Region "Form Events"
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub frmCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Set active module to UserParameters
            With varDataProperties
                SetValue(.UserParameters, tModule.P_ModuleCode, varThisModuleCode)
                varThisModuleId = CMDmods.View.GetModuleIdByCode(varDataProperties, varDataProperties.UserParameters)
                SetModuleIdentifier(varDataProperties.UserParameters, varThisModuleCode, varThisModuleId)
            End With

            ' Continue to Load anything for this module
            Com_mms_Menu.LoadIn(Me)
            Com_mms_Menu.ShowMenuData(CMCv.UI.View.MenuStrip.ShowItem.Yes)
            DgnCCIN.XOGetNewColor()
            Call GetData(True)
        End Sub
#End Region

#Region "Component Events"
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
#End Region

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMccinEditor_RecordSaved() Handles Frm_ccin_Editor.EventRecordSaved
            Call GetData(True)
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMccin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
            Com_mms_Menu.Dispose()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMccin_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
            Me.WindowState = FormWindowState.Maximized
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMccin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
            ' Set active module to UserParameters
            SetModuleIdentifier(varDataProperties.UserParameters, varThisModuleCode, varThisModuleId)
        End Sub
    End Class
End Namespace