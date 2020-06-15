Imports LibSQL

Public Class frmAccountGroup

#Region "Variables"
    Private _SQL As New LibSQL.Commands.AccountGroup
    Private _SelectedGroup As String = ""
    Private _Firstload As Boolean = True
    Private _IsClosing As Boolean = False
    Private WithEvents _frmAccountGroup_Editor As frmAccountGroup_Editor
#End Region

#Region "Sub Collections"
    ''' <summary>
    ''' Isikan data buku akuntansi ke CBO
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GETDATA()
        _SQL.GETPlant(CboPlant)
        _SQL.GETAccountingBook(CboAccountingBook, CboPlant)
    End Sub

    ''' <summary>
    ''' Isikan data nama-nama akun ke dalam datagrid sesuai pilihan buku akuntasi pada CBO
    ''' </summary>
    ''' <param name="ForceRefresh">True / False</param>
    ''' <remarks>True akan memaksa data untuk direfresh tanpa filter apapun</remarks>
    Private Sub GETDATAGRID(Optional ByVal ForceRefresh As Boolean = False)
        _SQL.GETAccountList(DgnAssets, DgnLiabities, DgnCapital, DgnWage, DgnExpense, CboAccountingBook, TxtFind, ForceRefresh)
    End Sub

    'Private _RowID As Integer

    ''' <summary>
    ''' Prosedur untuk mendapatkan Akun ID
    ''' </summary>
    ''' <param name="GridTable"></param>
    ''' <remarks></remarks>
    Private Function GetAccountID(ByVal GridTable As CMCv.dgn) As Integer
        With GridTable
            If .Rows.Count < 1 Then
                _FORMAttrib.RowID = -1
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
                GetAccountID(DgnAssets)
            Case "tpLiabilities"
                GetAccountID(DgnLiabities)
            Case "tpCapital"
                GetAccountID(DgnCapital)
            Case "tpWage"
                GetAccountID(DgnWage)
            Case "tpExpense"
                GetAccountID(DgnExpense)
        End Select
    End Sub

#End Region

#Region "Menu Strip Function"
    '- Data
    Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem.Click
        _FORMAttrib.IsNew = True
        _FORMAttrib.RowID = -1
        _frmAccountGroup_Editor = New frmAccountGroup_Editor
        Display(_frmAccountGroup_Editor, QERP.Main.ImageLibrary.TextEditor_001_90_FFFFFFFF_, "Add New", "Add new account data", True)
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Call GetTableID()
        _FORMAttrib.IsNew = False
        If _FORMAttrib.RowID = -1 Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            _frmAccountGroup_Editor = New frmAccountGroup_Editor
            Display(_frmAccountGroup_Editor, QERP.Main.ImageLibrary.TextEditor_001_90_FFFFFFFF_, "Update", "Update your account data", True)
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Call GETDATA()
        Call GETDATAGRID(True)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Call GetTableID()
        If _FORMAttrib.RowID = -1 Then
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
    End Sub

    '- Tools
    Private Sub ImportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportsToolStripMenuItem.Click
        Display(New frmImports(Import.Data.DataType.TypeofImports.MaterialMasterCatalog), QERP.Main.ImageLibrary.Imports_001_90_FFFFFFFF_, "Catalog Imports", "Imports your catalog data from other database", True)
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
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
    End Sub
#End Region

#Region "Main Form Events"

    Private Sub frmAccountGroup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _IsClosing = True
    End Sub
    Private Sub frmAccountGroup_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call GETDATA()
        Call GETDATAGRID()
        _SelectedGroup = TbctlAccountGroup.SelectedTab.Name
        _Firstload = False
    End Sub
#End Region

#Region "Component Events"
    Private Sub TbctlAccountGroup_Selected(sender As Object, e As TabControlEventArgs) Handles TbctlAccountGroup.Selected
        If _IsClosing = False Then
            _SelectedGroup = TbctlAccountGroup.SelectedTab.Name
        End If
    End Sub

    Private Sub CboAccountingBook_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboAccountingBook.SelectedIndexChanged
        If _Firstload = False Then
            Call GETDATAGRID(True)
        End If
    End Sub

    Private Sub CboPlant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPlant.SelectedIndexChanged
        If _Firstload = False Then
            _SQL.GETAccountingBook(CboAccountingBook, CboPlant)
            Call GETDATAGRID(True)
        End If
    End Sub
#End Region

#Region "WithEvents"
    Private Sub RecordSaved() Handles _frmAccountGroup_Editor.RecordSaved
        Call GETDATAGRID(True)
    End Sub
#End Region

End Class
