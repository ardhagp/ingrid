Imports System.Runtime.Versioning

Namespace UI
    Public Class FRMmctg

#Region "Declarations"
        Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip

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
            CMDmctg.View.DisplayData(varDataProperties, DgnMCTG, SLFStatus, TxtFind, forcerefresh)
        End Sub
#End Region

#Region "Menu Strip Function"

        <SupportedOSPlatform("windows")>
        Private Sub EventDataRefresh() Handles Com_mms_Menu.EventDataRefresh
            TxtFind.Clear()
            Call GetData(True)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub EventDataClose() Handles Com_mms_Menu.EventDataClose
            Me.Close()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub EventToolsImport() Handles Com_mms_Menu.EventToolsImport
            Display(New FRMimports(Import.Data.DataType.TypeofImports.MaterialMasterCatalog), IMAGEDB.Main.ImageLibrary.IMPORTS_ICON, My.Application.Info.AssemblyName.ToUpper, "Catalog Imports", "Imports your catalog data from other database", True)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub EventToolsFind() Handles Com_mms_Menu.EventToolsFind
            TxtFind.Focus()
        End Sub
#End Region

#Region "Upper Form Bar"

        <SupportedOSPlatform("windows")>
        Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
            If e.KeyCode = Keys.Enter Then
                Call GetData()
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles TxtFind.Click
            TxtFind.Clear()
            Call GetData(True)
            TxtFind.ClearSearch()
        End Sub
#End Region

#Region "Form Events"
        <SupportedOSPlatform("windows")>
        Private Sub FRMmctg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Call LoadMenu()
            Call LoadDGN()
            Call ClearFind()
        End Sub
#End Region

#Region "Component Events"

        <SupportedOSPlatform("windows")>
        Private Sub LoadMenu()
            'Sisipkan ke dalam form
            Com_mms_Menu.LoadIn(Me)

            'Menampilkan Menu DATA
            Com_mms_Menu.ShowMenuData(CMCv.UI.View.MenuStrip.ShowItem.Yes)

            'Menampilkan Menu TOOLS
            Com_mms_Menu.ShowMenuTools(CMCv.UI.View.MenuStrip.ShowItem.Yes)

            'Menampilkan Menu REPORTS
            Com_mms_Menu.ShowMenuReports(CMCv.UI.View.MenuStrip.ShowItem.Yes)

            'Menampilkan Menu TOOLS > View Attachment
            Com_mms_Menu.Visible("EventToolsViewAttachment", CType(True, CMCv.UI.View.MenuStrip.ShowItem))

        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub LoadDgn()
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
End Namespace