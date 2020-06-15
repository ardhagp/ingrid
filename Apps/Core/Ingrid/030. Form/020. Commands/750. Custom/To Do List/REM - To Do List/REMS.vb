Public Class REMS

#Region "Variables"
    Private _SQL As New LibSQL.Commands.REMS.View
    Private _SelectedGroup As String = ""
    Private _IsClosing As Boolean = False
    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip
    Private WithEvents _REMS_Switch As REMS_Editor_Switch

    Private Sub REMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadMenu()
        TxtFind.ClearSearch()

        _SQL.DisplayGrid(DgnOnProgress, DgnDone, DgnVerified, SLFStatus)
    End Sub

    Private Sub LoadMenu()
        _MMSMenu.LoadIn(Me)
        _MMSMenu.ShowMenuDATA(CMCv.UI.View.MenuStrip.ShowItem.Yes)
        _MMSMenu.ShowMenuTOOLS(CMCv.UI.View.MenuStrip.ShowItem.Yes)
        _MMSMenu.Visible("EventToolsViewAttachment", True)
        _MMSMenu.Checked("EventToolsViewAttachment", True)
    End Sub

    Private Sub _MMSMenu_EventDataEdit() Handles _MMSMenu.EventDataEdit


        _REMS_Switch = New REMS_Editor_Switch
        Display(_REMS_Switch, IMAGEDB.Main.ImageLibrary.EDIT_002_512_icon, "Please Select",, True,)
    End Sub
#End Region

    ''' <summary>
    ''' Prosedur untuk mendapatkan Tabel ID
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetTableID()
        Select Case _SelectedGroup
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
        If _IsClosing = False Then
            _SelectedGroup = TbctlToDoList.SelectedTab.Name
            Call GetTableID()
        End If
    End Sub

    Private Sub REMS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _IsClosing = True
    End Sub
End Class
