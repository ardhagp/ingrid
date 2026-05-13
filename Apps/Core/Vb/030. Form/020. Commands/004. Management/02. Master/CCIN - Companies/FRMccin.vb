Imports System.Data.Common
Imports System.Runtime.Versioning
Imports System.Text

Namespace UI
    Public Class FRMccin
#Region "Declaration"
        Private WithEvents Frm_ccin_Editor As New FRMccinEditor
        Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip

        'Parameters
        Private Const pCompanyId As String = "@CompanyId"
        Private Const pCommand As String = "@Command"
#End Region

#Region "Sub Collections"

        ''' <summary>
        ''' Untuk mengambil data dari database
        ''' </summary>
        ''' <param name="ForceRefresh">True/False</param>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Private Sub GetData(Optional forcerefresh As Boolean = False)
            DblBuffer(DgnCCIN)
            varDataProperties.CompanyIsForceRefresh = forcerefresh
            CMDccin.View.DisplayData(varDataProperties, DgnCCIN, SLFStatus, TxtFind)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub GetRowID()
            varDataProperties.AllParameters.Remove(pCompanyId)
            If DgnCCIN.RowCount = 0 Then
                varDataProperties.CompanyIsNew = True
            Else
                varDataProperties.CompanyIsNew = False
                varDataProperties.AllParameters.Add(pCompanyId, CLng(DgnCCIN.CurrentRow.Cells("company_id").Value))
            End If
        End Sub
#End Region

#Region "Menu Strip Function"
        <SupportedOSPlatform("windows")>
        Private Sub EventDataAddNew() Handles Com_mms_Menu.EventDataAddNew
            varDataProperties.SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Add
            varDataProperties.AllParameters.Remove(pCommand)
            varDataProperties.AllParameters.Add(pCommand, "CCIN")
            If Not (varUserAccess.User(varDataProperties)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Add new record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            varDataProperties.CompanyIsNew = True
            Frm_ccin_Editor = New FRMccinEditor
            Display(Frm_ccin_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Add New Record", "Add new company data", True)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub EventDataEdit() Handles Com_mms_Menu.EventDataEdit
            varDataProperties.SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Edit
            varDataProperties.AllParameters.Remove(pCommand)
            varDataProperties.AllParameters.Add(pCommand, "CCIN")
            If Not (varUserAccess.User(varDataProperties)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Modify existing record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            Call GetRowID()

            If varDataProperties.CompanyIsNew Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Else
                Frm_ccin_Editor = New FRMccinEditor
                Display(Frm_ccin_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Update Record", "Update your company data", True)
            End If

            UI.FRMmainframe6.Ts_status.Text = String.Empty
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub EventDataDelete() Handles Com_mms_Menu.EventDataDelete
            varDataProperties.SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Delete
            varDataProperties.AllParameters.Remove(pCommand)
            varDataProperties.AllParameters.Add(pCommand, "CCIN")
            If Not (varUserAccess.User(varDataProperties)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Delete record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            Call GetRowID()

            If varDataProperties.CompanyIsNew Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
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

                    If Decision(My.Application.Info.AssemblyName.ToUpper, Convert.ToString(varMessage), LibApp.Ingrid.Global.PopupType.Delete, "", CMCv.FRMdialogbox.MessageIcon.Question, CMCv.FRMdialogbox.MessageTypes.YesNo) = System.Windows.Forms.DialogResult.Yes AndAlso LibSQL.CMDccin.View.DeleteData(varDataProperties, varDatasetIngrid) Then
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
        Private Sub frmCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Com_mms_Menu.LoadIn(Me)
            Com_mms_Menu.ShowMenuData(CMCv.UI.View.MenuStrip.ShowItem.Yes)
            DgnCCIN.XOGETNewColor()
            Call GetData(True)
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
        Private Sub FRMccinEditor_RecordSaved() Handles Frm_ccin_Editor.EventRecordSaved
            Call GetData(True)
        End Sub
    End Class
End Namespace