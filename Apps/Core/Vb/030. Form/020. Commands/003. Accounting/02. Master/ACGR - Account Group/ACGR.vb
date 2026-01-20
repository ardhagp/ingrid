Imports System.Runtime.Versioning

Public Class ACGR

#Region "Variables"
    Private V_SQLview As New LibSQL.Commands.ACGR.View
    Private V_Selectedgroup As String = ""
    Private V_ISfirstload As Boolean = True
    Private V_ISclosing As Boolean = False
    Private WithEvents frmACGReditor As New ACGR_Editor
    Private WithEvents _MMSmenu As New CMCv.UI.View.MenuStrip
#End Region

#Region "Sub Collections"
    ''' <summary>
    ''' Isikan data buku akuntansi ke CBO
    ''' </summary>
    ''' <remarks></remarks>
    <SupportedOSPlatform("windows")>
    Private Sub GetData()
        LibSQL.Commands.ACGR.View.FillCompany(varDatabaseName, varDatabaseEngine, CboCompany)
        LibSQL.Commands.ACGR.View.FillAccountingBook(varDatabaseName, varDatabaseEngine, CboAccountingBook, CboCompany)
    End Sub

    ''' <summary>
    ''' Isikan data nama-nama akun ke dalam datagrid sesuai pilihan buku akuntasi pada CBO
    ''' </summary>
    ''' <param name="ForceRefresh">True / False</param>
    ''' <remarks>True akan memaksa data untuk direfresh tanpa filter apapun</remarks>
    <SupportedOSPlatform("windows")>
    Private Sub GetDataGrid(Optional forcerefresh As Boolean = False)
        LibSQL.Commands.ACGR.View.GetAccountList(varDatabaseName, varDatabaseEngine, DgnACGRAssets, DgnACGRLiabities, DgnACGREquity, DgnACGRRevenue, DgnACGRExpense, CboAccountingBook, TxtFind, forcerefresh)
    End Sub

    'Private _RowID As Integer

    ''' <summary>
    ''' Prosedur untuk mendapatkan Akun ID
    ''' </summary>
    ''' <param name="GridTable"></param>
    ''' <remarks></remarks>
    Private Function GetAccountID(gridtable As CMCv.dgn) As String
        With gridtable
            If .Rows.Count < 1 Then
                varFormProperties.RowID = "-1"
            Else
                varFormProperties.RowID = .CurrentRow.Cells(0).Value.ToString
            End If
            Return Convert.ToString(Convert.ToString(varFormProperties.RowID))
        End With
    End Function

    ''' <summary>
    ''' Prosedur untuk mendapatkan Tabel ID
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetRowID()
        Select Case V_Selectedgroup
            Case "tpAssets"
                GetAccountID(DgnACGRAssets)
                SLFStatus.Items(0).Text = DgnACGRAssets.RowCount & " Row(s)"
            Case "tpLiabilities"
                GetAccountID(DgnACGRLiabities)
                SLFStatus.Items(0).Text = DgnACGRLiabities.RowCount & " Row(s)"
            Case "tpEquity"
                GetAccountID(DgnACGREquity)
                SLFStatus.Items(0).Text = DgnACGREquity.RowCount & " Row(s)"
            Case "tpRevenue"
                GetAccountID(DgnACGRRevenue)
                SLFStatus.Items(0).Text = DgnACGRRevenue.RowCount & " Row(s)"
            Case "tpExpense"
                GetAccountID(DgnACGRExpense)
                SLFStatus.Items(0).Text = DgnACGRExpense.RowCount & " Row(s)"
        End Select
    End Sub

#End Region

#Region "Menu Strip Function"
    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventDataAddNew() Handles _MMSmenu.EventDataAddNew
        With varFormProperties
            .RowID = "-1"
            .IsNew = True
        End With
        frmACGReditor = New ACGR_Editor
        Display(frmACGReditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new account for each accounting book and accounting group", True)
        Call GetRowID()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventDataEdit() Handles _MMSmenu.EventDataEdit
        Call GetRowID()
        varFormProperties.IsNew = False
        If Convert.ToString(Convert.ToString(varFormProperties.RowID)) = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            frmACGReditor = New ACGR_Editor
            Display(frmACGReditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your account data", True)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventDataDelete() Handles _MMSmenu.EventDataDelete
        Call GetRowID()
        If Convert.ToString(Convert.ToString(varFormProperties.RowID)) = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            varFormProperties.IsNew = False
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (LibSQL.Commands.ACGR.View.DeleteData(varDatabaseName, varDatabaseEngine, Convert.ToString(Convert.ToString(varFormProperties.RowID)))) Then
                    Call GetDataGrid(True)
                    Mainframe_n_6.Ts_status.Text = "Success"
                Else
                    Mainframe_n_6.Ts_status.Text = "Delete failed"
                End If
            End If
        End If
        Call GetRowID()
    End Sub

    Private Sub _MMSMenu_EventToolsFind() Handles _MMSmenu.EventToolsFind
        TxtFind.Focus()
    End Sub
#End Region

#Region "Upper Form Bar"
    <SupportedOSPlatform("windows")>
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GetDataGrid()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GetData()
        Call GetDataGrid(True)
        TxtFind.ClearSearch()
    End Sub
#End Region

#Region "Main Form Events"
    Private Sub frmAccountGroup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        V_ISclosing = True
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub frmAccountGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _MMSmenu.LoadIn(Me)
        _MMSmenu.ShowMenuData(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        Call GetData()
        Call GetDataGrid()
        V_Selectedgroup = TbctlAccountGroup.SelectedTab.Name
        Call GetRowID()
        V_ISfirstload = False
    End Sub
#End Region

#Region "Component Events"
    Private Sub TbctlAccountGroup_Selected(sender As Object, e As TabControlEventArgs) Handles TbctlAccountGroup.Selected
        If Not (V_ISclosing) Then
            V_Selectedgroup = TbctlAccountGroup.SelectedTab.Name
            Call GetRowID()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub CboAccountingBook_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboAccountingBook.SelectedIndexChanged
        If Not (V_ISfirstload) Then
            Call GetDataGrid(True)
            Call GetRowID()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub CboPlant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCompany.SelectedIndexChanged
        If Not (V_ISfirstload) Then
            LibSQL.Commands.ACGR.View.FillAccountingBook(varDatabaseName, varDatabaseEngine, CboAccountingBook, CboCompany)
            Call GetDataGrid(True)
        End If
    End Sub
#End Region

#Region "WithEvents"
    <SupportedOSPlatform("windows")>
    Private Sub RecordSaved() Handles frmACGReditor.RecordSaved
        Call GetDataGrid(True)
    End Sub
#End Region

End Class
