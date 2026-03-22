Imports System.Runtime.Versioning

Namespace UI
    Public Class FRMdraa
#Region "Variables"

        'Variabel -> Class
        Private WithEvents Frm_draa_Editor As New FRMdraaEditor
        Private WithEvents Frm_draa_Reports As DAR_RPTFilter
        Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip
#End Region

        ''' <summary>
        ''' Menampilkan data awal
        ''' </summary>
        ''' <param name="ForceRefresh">Boolean</param>
        <SupportedOSPlatform("windows")>
        Private Sub GetData(Optional forcerefresh As Boolean = False)
            'Buffer Datagrid
            DblBuffer(DgnArea)

            'Mengisi Datagrid dengan data dari database    
            CMDdraa.View.DisplayMainGrid(varDatabaseName, TxtFind, DgnArea, SLFStatus, forcerefresh)
        End Sub

        ''' <summary>
        ''' Menyisipkan menu pada form saat pertama kali dimuat.
        ''' </summary>
        <SupportedOSPlatform("windows")>
        Private Sub LoadMenu()
            'Sisipkan ke dalam form
            Com_mms_Menu.LoadIn(Me)

            'Menampilkan Menu DATA
            Com_mms_Menu.ShowMenuData(CMCv.UI.View.MenuStrip.ShowItem.Yes)

            'Menampilkan Menu TOOLS
            Com_mms_Menu.ShowMenuTools(CMCv.UI.View.MenuStrip.ShowItem.No)

            'Menampilkan Menu REPORTS
            Com_mms_Menu.ShowMenuReports(CMCv.UI.View.MenuStrip.ShowItem.No)

            'Menampilkan Menu TOOLS > View Attachment
            Com_mms_Menu.Visible("EventToolsViewAttachment", CType(False, CMCv.UI.View.MenuStrip.ShowItem))

        End Sub

        ''' <summary>
        ''' Memuat setting datagrid
        ''' </summary>
        Private Sub LoadDgn()
            'Memuat warna acak
            DgnArea.XOGETNewColor()
        End Sub

        ''' <summary>
        ''' Get row ID on record clicked
        ''' </summary>
        Private Sub GetRowID()
            varDataProperties.CustomDailyActivityAreaId = "-1"

            If DgnArea.RowCount > 0 Then
                varDataProperties.CustomDailyActivityAreaId = DgnArea.CurrentRow.Cells("affectedarea_id").Value.ToString
            End If
        End Sub

        ''' <summary>
        ''' Clearing filters and load default data
        ''' </summary>
        <SupportedOSPlatform("windows")>
        Private Sub ClearFind()
            TxtFind.Clear()
            TxtFind.ClearSearch()
            Call GETDATA(True)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub FRMdraa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            'Memuat Menu
            Call LoadMenu()

            'Memuat Datagrid
            Call LoadDgn()

            'Memuat Data
            Call ClearFind()
        End Sub
    End Class
End Namespace