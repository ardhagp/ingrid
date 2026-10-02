Imports System.Runtime.Versioning

Namespace UI.Canvas
    Public Class FRMrems

#Region "Variables"
        Private WithEvents Frm_rems_Switch As FRMremsEditorSwitch
        Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip

        Private varSelectedGroup As String = ""
        Private varIsClosing As Boolean = False

        <SupportedOSPlatform("windows")>
        Private Sub FRMrems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Call LoadMenu()
            TxtFind.ClearSearch()

            CMDrems.View.DisplayGrid(varDataProperties, DgnOnProgress, DgnDone, DgnVerified, SLFStatus)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub LoadMenu()
            Com_mms_Menu.LoadIn(Me)
            Com_mms_Menu.ShowMenuData(CMCv.UI.View.MenuStrip.ShowItem.Yes)
            Com_mms_Menu.ShowMenuTools(CMCv.UI.View.MenuStrip.ShowItem.Yes)
            Com_mms_Menu.Visible("EventToolsViewAttachment", CType(True, CMCv.UI.View.MenuStrip.ShowItem))
            Com_mms_Menu.Checked("EventToolsViewAttachment", CType(True, CMCv.UI.View.MenuStrip.ShowItem))
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub CommmsMenu_EventDataEdit() Handles Com_mms_Menu.EventDataEdit
            With varDataProperties
                Frm_rems_Switch = New FRMremsEditorSwitch
                .IngridFormImage = ImageDb.Main.ImageLibrary.EDIT_ICON
                .IngridWindowName = My.Application.Info.AssemblyName.ToUpper
                .IngridFormTitle = "Please Select"
                .IngridFormSubtitle = "Select the type of data you want to edit"
                .IngridFormIsDialog = True
                Display(Frm_rems_Switch,, varDataProperties)
            End With
        End Sub
#End Region

        ''' <summary>
        ''' Prosedur untuk mendapatkan Tabel ID
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub GetRowID()
            Select Case varSelectedGroup
                Case "tpOnProgress"
                'GetAccountID(DgnACGRAssets)
                'SLFStatus.Items(0).Text = DgnACGRAssets.RowCount & " Row(s)"
                Case "tpFinished"
                'GetAccountID(DgnACGRLiabities)
                'SLFStatus.Items(0).Text = DgnACGRLiabities.RowCount & " Row(s)"
                Case "tpVerified"
                    'GetAccountID(DgnACGREquity)
                    'SLFStatus.Items(0).Text = DgnACGREquity.RowCount & " Row(s)"
            End Select
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub TbctlToDoList_Selected(sender As Object, e As TabControlEventArgs) Handles TbctlToDoList.Selected
            If Not varIsClosing Then
                varSelectedGroup = TbctlToDoList.SelectedTab.Name
                Call GetRowID()
            End If
        End Sub

        Private Sub FRMrems_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            varIsClosing = True
        End Sub
    End Class
End Namespace