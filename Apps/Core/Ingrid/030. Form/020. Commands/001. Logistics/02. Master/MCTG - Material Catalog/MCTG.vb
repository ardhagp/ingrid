Public Class MCTG

#Region "Variables"
    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip
    Private _SQL As New LibSQL.Commands.MCTG.View
#End Region

#Region "Sub Collections"
    ''' <summary>
    ''' Ambil data dari database untuk mengisi datagrid Catalog
    ''' </summary>
    ''' <param name="ForceRefresh">True/False</param>
    ''' <remarks>True untuk mengambil data tanpa filter</remarks>
    Private Sub GETDATA(Optional ForceRefresh As Boolean = False)
        DblBuffer(DgnMCTG)
        _SQL.DisplayData(DgnMCTG, SLFStatus, TxtFind, ForceRefresh)
    End Sub
#End Region

#Region "Menu Strip Function"
    Private Sub EventDataAddNew() Handles _MMSMenu.EventDataAddNew

    End Sub

    Private Sub EventDataEdit() Handles _MMSMenu.EventDataEdit

    End Sub

    Private Sub EventDataDelete() Handles _MMSMenu.EventDataDelete

    End Sub

    Private Sub EventDataRefresh() Handles _MMSMenu.EventDataRefresh
        TxtFind.Clear()
        Call GETDATA(True)
    End Sub

    Private Sub EventDataClose() Handles _MMSMenu.EventDataClose
        Me.Close()
    End Sub

    Private Sub EventToolsImport() Handles _MMSMenu.EventToolsImport
        Display(New frmImports(Import.Data.DataType.TypeofImports.MaterialMasterCatalog), IMAGEDB.Main.ImageLibrary.Imports_001_90_FFFFFFFF_, "Catalog Imports", "Imports your catalog data from other database", True)
    End Sub

    Private Sub EventToolsFind() Handles _MMSMenu.EventToolsFind
        TxtFind.Focus()
    End Sub
#End Region

#Region "Upper Form Bar"
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA()
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles TxtFind.Click
        TxtFind.Clear()
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub
#End Region

#Region "Form Events"
    Private Sub MCTG_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call LoadMenu()

        Call LoadDGN()

        Call ClearFind()
    End Sub
#End Region

#Region "Component Events"
    Private Sub LoadMenu()
        'Sisipkan ke dalam form
        _MMSMenu.LoadIn(Me)

        'Menampilkan Menu DATA
        _MMSMenu.ShowMenuDATA(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        'Menampilkan Menu TOOLS
        _MMSMenu.ShowMenuTOOLS(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        'Menampilkan Menu REPORTS
        _MMSMenu.ShowMenuREPORTS(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        'Menampilkan Menu TOOLS > View Attachment
        _MMSMenu.Visible("EventToolsViewAttachment", True)

    End Sub

    Private Sub LoadDGN()
        'Memuat warna acak
        DgnMCTG.SLF_GETNewColor()
    End Sub

    Private Sub ClearFind()
        TxtFind.Clear()
        TxtFind.ClearSearch()
        Call GETDATA(True)
    End Sub

#End Region


End Class
