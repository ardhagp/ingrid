Imports CMCv
Imports LibSQL

Public Class frmCatalog

#Region "Variables"
    Private _SQL As New LibSQL.Commands.Catalog
#End Region

#Region "Sub Collections"
    ''' <summary>
    ''' Ambil data dari database untuk mengisi datagrid Catalog
    ''' </summary>
    ''' <param name="ForceRefresh">True/False</param>
    ''' <remarks>True untuk mengambil data tanpa filter</remarks>
    Private Sub GETDATA(Optional ForceRefresh As Boolean = False)
        _SQL.DisplayData(DgnCatalog, SLFStatus, TxtFind, ForceRefresh)
    End Sub
#End Region

#Region "Menu Strip Function"
    '- Data
    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Call GETDATA(True)
    End Sub

    '- Tools
    Private Sub ImportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportsToolStripMenuItem.Click
        Display(New frmImports(Import.Data.DataType.TypeofImports.MaterialMasterCatalog), QERP.Main.ImageLibrary.Imports_001_90_FFFFFFFF_, "Catalog Imports", "Imports your catalog data from other database", True)
    End Sub
#End Region

#Region "Upper Form Bar"
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA()
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA(True)
    End Sub
#End Region

#Region "Form Events"
    Private Sub frmCatalog_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call GETDATA(True)
    End Sub
#End Region

#Region "Component Events"
    Private Sub TxtFind_TextChanged(sender As Object, e As EventArgs) Handles TxtFind.TextChanged
    End Sub
#End Region

End Class
