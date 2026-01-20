Imports System.Runtime.Versioning

Public Class MCTG

#Region "Variables"
    Private WithEvents C_MMSMenu As New UI.View.MenuStrip
    Private V_SQL As New Commands.MCTG.View
#End Region

#Region "Sub Collections"
    ''' <summary>
    ''' Ambil data dari database untuk mengisi datagrid Catalog
    ''' </summary>
    ''' <param name="ForceRefresh">True/False</param>
    ''' <remarks>True untuk mengambil data tanpa filter</remarks>
    <SupportedOSPlatform("windows")>
    Private Sub GetData(Optional forcerefresh As Boolean = False)
        DblBuffer(DgnMCTG)
        Commands.MCTG.View.DisplayData(varDatabaseName, varDatabaseEngine, DgnMCTG, SLFStatus, TxtFind, forcerefresh)
    End Sub
#End Region

#Region "Menu Strip Function"

    <SupportedOSPlatform("windows")>
    Private Sub EventDataRefresh() Handles C_MMSMenu.EventDataRefresh
        TxtFind.Clear()
        Call GETDATA(True)
    End Sub

    Private Sub EventDataClose() Handles C_MMSMenu.EventDataClose
        Me.Close()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventToolsImport() Handles C_MMSMenu.EventToolsImport
        DISPLAY(New frmImports(Import.Data.DataType.TypeofImports.MaterialMasterCatalog), IMAGEDB.Main.ImageLibrary.IMPORTS_ICON, "Catalog Imports", "Imports your catalog data from other database", True)
    End Sub

    Private Sub EventToolsFind() Handles C_MMSMenu.EventToolsFind
        TxtFind.Focus()
    End Sub
#End Region

#Region "Upper Form Bar"

    <SupportedOSPlatform("windows")>
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles TxtFind.Click
        TxtFind.Clear()
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub
#End Region

#Region "Form Events"
    <SupportedOSPlatform("windows")>
    Private Sub MCTG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadMenu()
        Call LoadDGN()
        Call ClearFind()
    End Sub
#End Region

#Region "Component Events"

    <SupportedOSPlatform("windows")>
    Private Sub LoadMenu()
        'Sisipkan ke dalam form
        C_MMSMenu.LoadIn(Me)

        'Menampilkan Menu DATA
        C_MMSMenu.ShowMenuDATA(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        'Menampilkan Menu TOOLS
        C_MMSMenu.ShowMenuTOOLS(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        'Menampilkan Menu REPORTS
        C_MMSMenu.ShowMenuREPORTS(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        'Menampilkan Menu TOOLS > View Attachment
        C_MMSMenu.Visible("EventToolsViewAttachment", CType(True, CMCv.UI.View.MenuStrip.ShowItem))

    End Sub

    Private Sub LoadDGN()
        'Memuat warna acak
        DgnMCTG.XOGETNewColor()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub ClearFind()
        TxtFind.Clear()
        TxtFind.ClearSearch()
        Call GETDATA(True)
    End Sub

#End Region


End Class
