Imports System.Runtime.Versioning

Public Class REMS

#Region "Variables"
    Private V_SQL As New Commands.REMS.View
    Private V_SelectedGroup As String = ""
    Private V_IsClosing As Boolean = False
    Private WithEvents V_MMSMenu As New CMCv.UI.View.MenuStrip
    Private WithEvents V_REMS_Switch As REMS_Editor_Switch

    <SupportedOSPlatform("windows")>
    Private Sub REMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadMenu()
        TxtFind.ClearSearch()

        Commands.REMS.View.DisplayGrid(DgnOnProgress, DgnDone, DgnVerified, SLFStatus)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub LoadMenu()
        V_MMSMenu.LoadIn(Me)
        V_MMSMenu.ShowMenuDATA(CMCv.UI.View.MenuStrip.ShowItem.Yes)
        V_MMSMenu.ShowMenuTOOLS(CMCv.UI.View.MenuStrip.ShowItem.Yes)
        V_MMSMenu.Visible("EventToolsViewAttachment", CType(True, CMCv.UI.View.MenuStrip.ShowItem))
        V_MMSMenu.Checked("EventToolsViewAttachment", CType(True, CMCv.UI.View.MenuStrip.ShowItem))
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventDataEdit() Handles V_MMSMenu.EventDataEdit
        V_REMS_Switch = New REMS_Editor_Switch
        DISPLAY(V_REMS_Switch, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Please Select",, True,)
    End Sub
#End Region

    ''' <summary>
    ''' Prosedur untuk mendapatkan Tabel ID
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetTableID()
        Select Case V_SelectedGroup
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

    Private Sub TbctlToDoList_Selected(sender As Object, e As TabControlEventArgs) Handles TbctlToDoList.Selected
        If Not V_IsClosing Then
            V_SelectedGroup = TbctlToDoList.SelectedTab.Name
            Call GetTableID()
        End If
    End Sub

    Private Sub REMS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        V_IsClosing = True
    End Sub
End Class
