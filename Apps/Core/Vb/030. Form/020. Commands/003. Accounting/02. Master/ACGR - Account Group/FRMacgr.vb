Imports System.Runtime.Versioning

Public Class FRMacgr

#Region "Variables"
    Private WithEvents Frm_acgr_Editor As New FRMacgrEditor
    Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip

    Private varSelectedGroup As String = String.Empty
    Private varIsFirstLoad As Boolean = True
    Private varIsClosing As Boolean = False

    Const msgRows As String = " Row(s)"
#End Region

#Region "Sub Collections"
    ''' <summary>
    ''' Isikan data buku akuntansi ke CBO
    ''' </summary>
    ''' <remarks></remarks>
    <SupportedOSPlatform("windows")>
    Private Sub GetData()
        CMDacgr.View.FillCompany(varDatabaseName, varDatabaseEngine, CboCompany)
        CMDacgr.View.FillAccountingBook(varDatabaseName, varDatabaseEngine, CboAccountingBook, CboCompany)
    End Sub

    ''' <summary>
    ''' Isikan data nama-nama akun ke dalam datagrid sesuai pilihan buku akuntasi pada CBO
    ''' </summary>
    ''' <param name="ForceRefresh">True / False</param>
    ''' <remarks>True akan memaksa data untuk direfresh tanpa filter apapun</remarks>
    <SupportedOSPlatform("windows")>
    Private Sub GetDataGrid(Optional forcerefresh As Boolean = False)
        CMDacgr.View.GetAccountList(varDatabaseName, varDatabaseEngine, DgnACGRAssets, DgnACGRLiabities, DgnACGREquity, DgnACGRRevenue, DgnACGRExpense, CboAccountingBook, TxtFind, forcerefresh)
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
        Select Case varSelectedGroup
            Case "tpAssets"
                GetAccountID(DgnACGRAssets)
                SLFStatus.Items(0).Text = DgnACGRAssets.RowCount & msgRows
            Case "tpLiabilities"
                GetAccountID(DgnACGRLiabities)
                SLFStatus.Items(0).Text = DgnACGRLiabities.RowCount & msgRows
            Case "tpEquity"
                GetAccountID(DgnACGREquity)
                SLFStatus.Items(0).Text = DgnACGREquity.RowCount & msgRows
            Case "tpRevenue"
                GetAccountID(DgnACGRRevenue)
                SLFStatus.Items(0).Text = DgnACGRRevenue.RowCount & msgRows
            Case "tpExpense"
                GetAccountID(DgnACGRExpense)
                SLFStatus.Items(0).Text = DgnACGRExpense.RowCount & msgRows
        End Select
    End Sub

#End Region

#Region "Menu Strip Function"
    <SupportedOSPlatform("windows")>
    Private Sub CommmmsMenu_EventDataAddNew() Handles Com_mms_Menu.EventDataAddNew
        With varFormProperties
            .RowID = "-1"
            .IsNew = True
        End With
        Frm_acgr_Editor = New FRMacgrEditor
        Display(Frm_acgr_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new account for each accounting book and accounting group", True)
        Call GetRowID()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub CommmmsMenu_EventDataEdit() Handles Com_mms_Menu.EventDataEdit
        Call GetRowID()
        varFormProperties.IsNew = False
        If Convert.ToString(Convert.ToString(varFormProperties.RowID)) = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            Frm_acgr_Editor = New FRMacgrEditor
            Display(Frm_acgr_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your account data", True)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub CommmmsMenu_EventDataDelete() Handles Com_mms_Menu.EventDataDelete
        Call GetRowID()
        If Convert.ToString(Convert.ToString(varFormProperties.RowID)) = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            varFormProperties.IsNew = False
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (CMDacgr.View.DeleteData(varDatabaseName, varDatabaseEngine, Convert.ToString(Convert.ToString(varFormProperties.RowID)))) Then
                    Call GetDataGrid(True)
                    FRMmainframe6.Ts_status.Text = "Success"
                Else
                    FRMmainframe6.Ts_status.Text = "Delete failed"
                End If
            End If
        End If
        Call GetRowID()
    End Sub

    Private Sub CommmmsMenu_EventToolsFind() Handles Com_mms_Menu.EventToolsFind
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
        varIsClosing = True
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub frmAccountGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Com_mms_Menu.LoadIn(Me)
        Com_mms_Menu.ShowMenuData(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        Call GetData()
        Call GetDataGrid()
        varSelectedGroup = TbctlAccountGroup.SelectedTab.Name
        Call GetRowID()
        varIsFirstLoad = False
    End Sub
#End Region

#Region "Component Events"
    Private Sub TbctlAccountGroup_Selected(sender As Object, e As TabControlEventArgs) Handles TbctlAccountGroup.Selected
        If Not (varIsClosing) Then
            varSelectedGroup = TbctlAccountGroup.SelectedTab.Name
            Call GetRowID()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub CboAccountingBook_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboAccountingBook.SelectedIndexChanged
        If Not (varIsFirstLoad) Then
            Call GetDataGrid(True)
            Call GetRowID()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub CboPlant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCompany.SelectedIndexChanged
        If Not (varIsFirstLoad) Then
            CMDacgr.View.FillAccountingBook(varDatabaseName, varDatabaseEngine, CboAccountingBook, CboCompany)
            Call GetDataGrid(True)
        End If
    End Sub
#End Region

#Region "WithEvents"
    <SupportedOSPlatform("windows")>
    Private Sub EventRecordSaved() Handles Frm_acgr_Editor.EventRecordSaved
        Call GetDataGrid(True)
    End Sub
#End Region

End Class
