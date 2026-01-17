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
    Private Sub GETDATA()
        LibSQL.Commands.ACGR.View.FILLCompany(varDatabaseEngine, CboCompany)
        LibSQL.Commands.ACGR.View.FILLAccountingBook(varDatabaseEngine, CboAccountingBook, CboCompany)
    End Sub

    ''' <summary>
    ''' Isikan data nama-nama akun ke dalam datagrid sesuai pilihan buku akuntasi pada CBO
    ''' </summary>
    ''' <param name="ForceRefresh">True / False</param>
    ''' <remarks>True akan memaksa data untuk direfresh tanpa filter apapun</remarks>
    <SupportedOSPlatform("windows")>
    Private Sub GETDATAGRID(Optional ByVal ForceRefresh As Boolean = False)
        LibSQL.Commands.ACGR.View.GETAccountList(varDatabaseEngine, DgnACGRAssets, DgnACGRLiabities, DgnACGREquity, DgnACGRRevenue, DgnACGRExpense, CboAccountingBook, TxtFind, ForceRefresh)
    End Sub

    'Private _RowID As Integer

    ''' <summary>
    ''' Prosedur untuk mendapatkan Akun ID
    ''' </summary>
    ''' <param name="GridTable"></param>
    ''' <remarks></remarks>
    Private Function GetAccountID(ByVal GridTable As CMCv.dgn) As String
        With GridTable
            If .Rows.Count < 1 Then
                varFormAttributes.RowID = "-1"
            Else
                varFormAttributes.RowID = .CurrentRow.Cells(0).Value.ToString
            End If
            Return varFormAttributes.RowID
        End With
    End Function

    ''' <summary>
    ''' Prosedur untuk mendapatkan Tabel ID
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetTableID()
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
        With varFormAttributes
            .RowID = "-1"
            .IsNew = True
        End With
        frmACGReditor = New ACGR_Editor
        DISPLAY(frmACGReditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new account for each accounting book and accounting group", True)
        Call GetTableID()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventDataEdit() Handles _MMSmenu.EventDataEdit
        Call GetTableID()
        varFormAttributes.IsNew = False
        If varFormAttributes.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            frmACGReditor = New ACGR_Editor
            DISPLAY(frmACGReditor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your account data", True)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventDataDelete() Handles _MMSmenu.EventDataDelete
        Call GetTableID()
        If varFormAttributes.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            varFormAttributes.IsNew = False
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (LibSQL.Commands.ACGR.View.DELETEData(varDatabaseEngine, varFormAttributes.RowID)) Then
                    Call GETDATAGRID(True)
                    Mainframe_n_6.Ts_status.Text = "Success"
                Else
                    Mainframe_n_6.Ts_status.Text = "Delete failed"
                End If
            End If
        End If
        Call GetTableID()
    End Sub

    Private Sub _MMSMenu_EventToolsFind() Handles _MMSmenu.EventToolsFind
        TxtFind.Focus()
    End Sub
#End Region

#Region "Upper Form Bar"
    <SupportedOSPlatform("windows")>
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATAGRID()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA()
        Call GETDATAGRID(True)
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
        _MMSmenu.ShowMenuDATA(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        Call GETDATA()
        Call GETDATAGRID()
        V_Selectedgroup = TbctlAccountGroup.SelectedTab.Name
        Call GetTableID()
        V_ISfirstload = False
    End Sub
#End Region

#Region "Component Events"
    Private Sub TbctlAccountGroup_Selected(sender As Object, e As TabControlEventArgs) Handles TbctlAccountGroup.Selected
        If Not (V_ISclosing) Then
            V_Selectedgroup = TbctlAccountGroup.SelectedTab.Name
            Call GetTableID()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub CboAccountingBook_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboAccountingBook.SelectedIndexChanged
        If Not (V_ISfirstload) Then
            Call GETDATAGRID(True)
            Call GetTableID()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub CboPlant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCompany.SelectedIndexChanged
        If Not (V_ISfirstload) Then
            LibSQL.Commands.ACGR.View.FILLAccountingBook(varDatabaseEngine, CboAccountingBook, CboCompany)
            Call GETDATAGRID(True)
        End If
    End Sub
#End Region

#Region "WithEvents"
    <SupportedOSPlatform("windows")>
    Private Sub RecordSaved() Handles frmACGReditor.RecordSaved
        Call GETDATAGRID(True)
    End Sub
#End Region

End Class
