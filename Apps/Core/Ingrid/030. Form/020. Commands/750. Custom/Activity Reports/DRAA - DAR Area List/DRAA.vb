''' <summary>
''' Module : DRAA View
''' </summary>
Public Class DRAA
#Region "Variables"
    'SQL Class
    Private _SQL As New LibSQL.Commands.DRAA.View

    'Variabel -> Class
    Private WithEvents _DRAA_Editor As New DRAA_Editor
    Private WithEvents _DRAA_Reports As DAR_RPTFilter
    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip
#End Region

    ''' <summary>
    ''' Menampilkan data awal
    ''' </summary>
    ''' <param name="ForceRefresh">Boolean</param>
    Private Sub GETDATA(Optional ByVal ForceRefresh As Boolean = False)
        'Buffer Datagrid
        DblBuffer(DgnArea)

        'Mengisi Datagrid dengan data dari database    
        _SQL.DisplayMainGrid(TxtFind, DgnArea, SLFStatus, ForceRefresh)
    End Sub

    ''' <summary>
    ''' Menyisipkan menu pada form saat pertama kali dimuat.
    ''' </summary>
    Private Sub LoadMenu()
        'Sisipkan ke dalam form
        _MMSMenu.LoadIn(Me)

        'Menampilkan Menu DATA
        _MMSMenu.ShowMenuDATA(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        'Menampilkan Menu TOOLS
        _MMSMenu.ShowMenuTOOLS(CMCv.UI.View.MenuStrip.ShowItem.No)

        'Menampilkan Menu REPORTS
        _MMSMenu.ShowMenuREPORTS(CMCv.UI.View.MenuStrip.ShowItem.No)

        'Menampilkan Menu TOOLS > View Attachment
        _MMSMenu.Visible("EventToolsViewAttachment", False)

    End Sub

    ''' <summary>
    ''' Memuat setting datagrid
    ''' </summary>
    Private Sub LoadDGN()
        'Memuat warna acak
        DgnArea.SLF_GETNewColor()
    End Sub

    ''' <summary>
    ''' Get row ID on record clicked
    ''' </summary>
    Private Sub GETTableID()
        _FORMAttrib.RowID = "-1"

        If DgnArea.RowCount > 0 Then
            _FORMAttrib.RowID = DgnArea.CurrentRow.Cells("affectedarea_id").Value
        End If
    End Sub

    ''' <summary>
    ''' Clearing filters and load default data
    ''' </summary>
    Private Sub ClearFind()
        TxtFind.Clear()
        TxtFind.ClearSearch()
        Call GETDATA(True)
    End Sub

    Private Sub DRAA_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Memuat Menu
        Call LoadMenu()

        'Memuat Datagrid
        Call LoadDGN()

        'Memuat Data
        Call ClearFind()
    End Sub


End Class
