Imports LibSQL

Public Class ACGR

#Region "Variables"
    Private _SQL As New LibSQL.Commands.ACGR.View
    Private _SelectedGroup As String = ""
    Private _Firstload As Boolean = True
    Private _IsClosing As Boolean = False
    Private WithEvents _ACGR_Editor As New ACGR_Editor
    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip

#End Region

#Region "Sub Collections"
    ''' <summary>
    ''' Isikan data buku akuntansi ke CBO
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GETDATA()
        _SQL.FILLCompany(CboCompany)
        _SQL.FILLAccountingBook(CboAccountingBook, CboCompany)
    End Sub

    ''' <summary>
    ''' Isikan data nama-nama akun ke dalam datagrid sesuai pilihan buku akuntasi pada CBO
    ''' </summary>
    ''' <param name="ForceRefresh">True / False</param>
    ''' <remarks>True akan memaksa data untuk direfresh tanpa filter apapun</remarks>
    Private Sub GETDATAGRID(Optional ByVal ForceRefresh As Boolean = False)
        _SQL.GETAccountList(DgnACGRAssets, DgnACGRLiabities, DgnACGREquity, DgnACGRRevenue, DgnACGRExpense, CboAccountingBook, TxtFind, ForceRefresh)
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
                _FORMAttrib.RowID = "-1"
            Else
                _FORMAttrib.RowID = .CurrentRow.Cells(0).Value
            End If
            Return _FORMAttrib.RowID
        End With
    End Function

    ''' <summary>
    ''' Prosedur untuk mendapatkan Tabel ID
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetTableID()
        Select Case _SelectedGroup
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
    Private Sub _MMSMenu_EventDataAddNew() Handles _MMSMenu.EventDataAddNew
        _FORMAttrib.IsNew = True
        _FORMAttrib.RowID = "-1"
        _ACGR_Editor = New ACGR_Editor
        Display(_ACGR_Editor, IMAGEDB.Main.ImageLibrary.EDIT_002_512_icon, "Add New Record", "Add new account for each accounting book and accounting group", True)
        Call GetTableID()
    End Sub

    Private Sub _MMSMenu_EventDataEdit() Handles _MMSMenu.EventDataEdit
        Call GetTableID()
        _FORMAttrib.IsNew = False
        If _FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            _ACGR_Editor = New ACGR_Editor
            Display(_ACGR_Editor, IMAGEDB.Main.ImageLibrary.EDIT_002_512_icon, "Update Record", "Update your account data", True)
        End If
    End Sub

    Private Sub _MMSMenu_EventDataDelete() Handles _MMSMenu.EventDataDelete
        Call GetTableID()
        If _FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            _FORMAttrib.IsNew = False
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If _SQL.DELETEData(_FORMAttrib.RowID) = True Then
                    Call GETDATAGRID(True)
                    mainframe.ts_status.Text = "Success"
                Else
                    mainframe.ts_status.Text = "Delete failed"
                End If
            End If
        End If
        Call GetTableID()
    End Sub

    Private Sub _MMSMenu_EventToolsFind() Handles _MMSMenu.EventToolsFind
        TxtFind.Focus()
    End Sub
#End Region

#Region "Upper Form Bar"
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATAGRID()
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA()
        Call GETDATAGRID(True)
        TxtFind.ClearSearch()
    End Sub
#End Region

#Region "Main Form Events"

    Private Sub frmAccountGroup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _IsClosing = True
    End Sub

    Private Sub frmAccountGroup_Load(sender As Object, e As EventArgs) Handles Me.Load
        _MMSMenu.LoadIn(Me)
        _MMSMenu.ShowMenuDATA(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        Call GETDATA()
        Call GETDATAGRID()
        _SelectedGroup = TbctlAccountGroup.SelectedTab.Name
        Call GetTableID()
        _Firstload = False
    End Sub
#End Region

#Region "Component Events"
    Private Sub TbctlAccountGroup_Selected(sender As Object, e As TabControlEventArgs) Handles TbctlAccountGroup.Selected
        If _IsClosing = False Then
            _SelectedGroup = TbctlAccountGroup.SelectedTab.Name
            Call GetTableID()
        End If
    End Sub

    Private Sub CboAccountingBook_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboAccountingBook.SelectedIndexChanged
        If _Firstload = False Then
            Call GETDATAGRID(True)
            Call GetTableID()
        End If
    End Sub

    Private Sub CboPlant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCompany.SelectedIndexChanged
        If _Firstload = False Then
            _SQL.FILLAccountingBook(CboAccountingBook, CboCompany)
            Call GETDATAGRID(True)
        End If
    End Sub
#End Region

#Region "WithEvents"
    Private Sub RecordSaved() Handles _ACGR_Editor.RecordSaved
        Call GETDATAGRID(True)
    End Sub
#End Region

End Class
