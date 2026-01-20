Imports System.Runtime.Versioning
Imports Serilog.Sinks.Http

''' <summary>
''' Module : DAR View
''' </summary>
Public Class DAR
#Region "Variables"
    'SQL Class
    Private V_SQL As New Commands.DAR.View

    'Variabel -> Class
    Private WithEvents F_DAR_Editor As New DAR_Editor
    Private WithEvents F_DAR_Reports As DAR_RPTFilter
    Private WithEvents V_MMSMenu As New CMCv.UI.View.MenuStrip
    Private WithEvents V_CSMenu As New CMCv.UI.View.ContextMenu
    Private WithEvents V_DAR_SinglePhotoViewer As DAR_SinglePhotoViewer
    Private WithEvents V_DAR_SinglePDFViewer As DAR_SinglePDFViewer

    'Variabel Biasa
    Private V_ShowAttachment As Boolean
    Private V_ContentID As String
    Private V_LoadDGDateFinished As Boolean
    Private V_LoadDGContentFinished As Boolean
    Private V_PhotoByte As Byte() 'Variabel untuk konversi foto
    Private V_PhotoRow As Integer = 0 'Variabel baris foto
    Private V_CurrentDate As Date
    Private V_CurrentDate_S As String
#End Region

#Region "Sub Collections"
    ''' <summary>
    ''' Mengisi CBOBy dengan data karyawan
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub FillEmployee()
        Commands.DAR.View.FillEmployee(varDatabaseName, varDatabaseEngine, CboBy)
    End Sub

    ''' <summary>
    ''' Menampilkan data awal
    ''' </summary>
    ''' <param name="ForceRefresh">Boolean</param>
    <SupportedOSPlatform("windows")>
    Private Sub GetData(Optional forcerefresh As Boolean = False)
        'Menyatakan bahwa datagrid belum selesai memuat data
        V_LoadDGDateFinished = False
        V_LoadDGContentFinished = False

        'Buffer Datagrid
        DblBuffer(DgnDARDate)
        DblBuffer(DgnDARActivity)

        'Mengisi nilai variabel ShowAttachment
        V_ShowAttachment = V_MMSMenu.Checked("EventToolsViewAttachment")

        'Mengisi Datagrid dengan data dari database    
        V_SQL.DisplayMainGrid(varDatabaseName, varDatabaseEngine, TxtFind, DgnDARDate, SLFStatus, SttActivity, ChkEnableDateFilter, DtpMonth, ChkEnableByFilter, CboBy, forcerefresh)

        'Mengisi Datagrid Activity dengan data dari database
        Call OnDgnDateChange()
    End Sub

    ''' <summary>
    ''' Menyisipkan menu pada form saat pertama kali dimuat.
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub LoadMenu()
        'Sisipkan ke dalam form
        V_MMSMenu.LoadIn(Me)

        'Menampilkan Menu DATA
        V_MMSMenu.ShowMenuDATA(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        'Menampilkan Menu TOOLS
        V_MMSMenu.ShowMenuTOOLS(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        'Menampilkan Menu REPORTS
        V_MMSMenu.ShowMenuREPORTS(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        'Menampilkan Menu TOOLS > View Attachment
        V_MMSMenu.Visible("EventToolsViewAttachment", CType(True, CMCv.UI.View.MenuStrip.ShowItem))

        'Mengambil nilai dari database usersettings, jika ya maka tampilkan Menu Show Attachment
        If (Commands.DAR.View.CheckSettings(varDatabaseName, varDatabaseEngine, varProperties.UserID, "viewphototab")) Then
            V_MMSMenu.Checked("EventToolsViewAttachment", CType(True, CMCv.UI.View.MenuStrip.ShowItem))
            SpcContent.Panel2Collapsed = False
            Call LoadAttachment(V_ShowAttachment)
        Else
            SpcContent.Panel2Collapsed = True
        End If
    End Sub

    ''' <summary>
    ''' Memuat setting datagrid
    ''' </summary>
    Private Sub LoadDGN()
        'Memuat warna acak
        DgnDARDate.XOGETNewColor()
        DgnDARActivity.XOGETNewColor()
        DgnPhoto.XOGETNewColor()
        DgnFile.XOGETNewColor()

        'Memuat menu klik kanan
        V_CSMenu.LoadInGrid(DgnDARActivity)
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub OnDgnDateChange()
        If DgnDARDate.RowCount <> 0 Then
            V_CurrentDate = CType(DgnDARDate.CurrentRow.Cells("employeeactivity_datetime").Value, Date)
            V_CurrentDate_S = V_CurrentDate.Year & "-" & V_CurrentDate.Month & "-" & V_CurrentDate.Day
        Else
            V_CurrentDate = Now.AddYears(2)
            V_CurrentDate_S = "9999-12-31"
        End If
        V_SQL.DisplaySecondGrid(varDatabaseName, varDatabaseEngine, V_CurrentDate_S, DgnDARActivity, SttActivity, TxtFind, V_ShowAttachment, DgnPhoto, DgnFile)

        Call PhotoPlugin(V_ShowAttachment)
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    <SupportedOSPlatform("windows")>
    Private Sub DgnDARActivity_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnDARActivity.CellClick
        Call OnDgnActivityChange()
    End Sub

    ''' <summary>
    ''' Menampilkan foto pada picture box
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Public Sub PhotoPlugin(ByVal istabattachmentvisible As Boolean)
        If (istabattachmentvisible) Then
            If DgnPhoto.RowCount = 0 Then
                PctbxActivityPhoto.Image = Nothing
                BtnCopyPhoto.Enabled = False
                BtnSave.Enabled = False
                BtnLike.Enabled = False
            Else
                V_PhotoByte = CType(DgnPhoto.CurrentRow.Cells("photo_content").Value, Byte())
                Dim _PhotoStream = New System.IO.MemoryStream(V_PhotoByte)

                PctbxActivityPhoto.Image = System.Drawing.Image.FromStream(_PhotoStream)
                BtnCopyPhoto.Enabled = True
                BtnSave.Enabled = True
                BtnLike.Enabled = True
            End If
        End If
    End Sub

    ''' <summary>
    ''' Get photo by option
    ''' </summary>
    ''' <param name="IsTabOpen"></param>
    Public Sub GetPhotos(Optional istabopen As Boolean = False)
        If (istabopen) AndAlso (DgnDARActivity.RowCount <> 0) Then
            'waiting some code
        End If
    End Sub

    ''' <summary>
    ''' Get row ID on record clicked
    ''' </summary>
    Private Sub GetRowID()
        varFormProperties.RowID = "-1"

        If DgnDARActivity.RowCount > 0 Then
            varFormProperties.RowID = DgnDARActivity.CurrentRow.Cells("employeeactivity_id").Value.ToString
        End If
    End Sub

    ''' <summary>
    ''' Clearing filters and load default data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub ClearFind()
        TxtFind.Clear()
        TxtFind.ClearSearch()
        ChkEnableDateFilter.Checked = False
        ChkEnableByFilter.Checked = False
        DtpMonth.Enabled = False
        DtpMonth.Value = CType(Now.Year & "-" & Now.Month & "-1", Date)
        CboBy.Enabled = False
        Call GETDATA(True)
        Call FillEmployee()
    End Sub

    ''' <summary>
    ''' Load attachment
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub LoadAttachment(ByVal istabattachmentvisible As Boolean)
        If (istabattachmentvisible) Then
            DblBuffer(DgnPhoto)
            Commands.DAR.View.DisplayPhotoGrid(varDatabaseName, varDatabaseEngine, V_ContentID, DgnPhoto)

            Call PhotoPlugin(V_ShowAttachment)

            DblBuffer(DgnFile)
            Commands.DAR.View.DisplayFileGrid(varDatabaseName, varDatabaseEngine, V_ContentID, DgnFile)
        End If
    End Sub
#End Region

#Region "Menu Strip Function"
    ''' <summary>
    ''' Add new data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub EventDataAddNew() Handles V_MMSMenu.EventDataAddNew
        If Not (varUserAccess.User(varDatabaseName, "DAR", varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Add)) Then
            Decision("You are not authorized to : Add new record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If
        varFormProperties.IsNew = True
        varFormProperties.RowID = "-1"
        F_DAR_Editor = New DAR_Editor
        Display(F_DAR_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new activity", True)
        Mainframe_n_6.Ts_status.Text = String.Empty
    End Sub

    ''' <summary>
    ''' Edit existing data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Public Sub EventDataEdit() Handles V_MMSMenu.EventDataEdit
        If Not (varUserAccess.User(varDatabaseName, "DAR", varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Edit)) Then
            Decision("You are not authorized to : Modify existing record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        Call GetRowID()
        varFormProperties.IsNew = False

        If Convert.ToString(varFormProperties.RowID) Is "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            F_DAR_Editor = New DAR_Editor
            DISPLAY(F_DAR_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "update activity", True)
        End If
        Mainframe_n_6.Ts_status.Text = String.Empty
    End Sub

    ''' <summary>
    ''' Delete selected data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles V_MMSMenu.EventDataDelete
        If Not (varUserAccess.User(varDatabaseName, "DAR", varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Delete)) Then
            Decision("You are not authorized to : Delete record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If
        Call GetRowID()
        If Convert.ToString(varFormProperties.RowID) Is "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            varFormProperties.IsNew = False
            If Decision("Do you want to delete this record?" & vbCrLf & vbCrLf & "=======================================================" & vbCrLf & DgnDARActivity.CurrentRow.Cells("employeeactivity_description").Value.ToString & vbCrLf & "=======================================================", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (Commands.DAR.View.DeleteData(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID).ToString)) Then
                    Call GETDATA(True)
                    Call FillEmployee()
                    Mainframe_n_6.Ts_status.Text = "Success"
                Else
                    Mainframe_n_6.Ts_status.Text = "Delete failed"
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' Load data with filter applied
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub EventDataRefresh() Handles V_MMSMenu.EventDataRefresh
        TxtFind.Clear()
        ChkEnableDateFilter.Checked = False
        Call GETDATA(True)
    End Sub

    ''' <summary>
    ''' Close form
    ''' </summary>
    Private Sub EventDataClose() Handles V_MMSMenu.EventDataClose
        Me.Close()
    End Sub

    ''' <summary>
    ''' Search mode
    ''' </summary>
    Private Sub EventToolsFind() Handles V_MMSMenu.EventToolsFind
        TxtFind.Focus()
    End Sub

    ''' <summary>
    ''' Toogle view photo menu
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub EventToolsViewAttachment() Handles V_MMSMenu.EventToolsViewAttachment
        If (V_MMSMenu.Checked("EventToolsViewAttachment")) Then
            V_MMSMenu.Checked("EventToolsViewAttachment", CType(False, CMCv.UI.View.MenuStrip.ShowItem))
            SpcContent.Panel2Collapsed = True
            V_ShowAttachment = False
        Else
            V_MMSMenu.Checked("EventToolsViewAttachment", CType(True, CMCv.UI.View.MenuStrip.ShowItem))
            SpcContent.Panel2Collapsed = False
            SpcContent.SplitterDistance = 200
            SpcPhoto.SplitterDistance = (TPPhotos.Width - (300 + SpcPhoto.SplitterWidth))
            V_ShowAttachment = True
        End If
        Call LoadAttachment(V_ShowAttachment)
    End Sub
#End Region

#Region "Context Menu Event"
    Private Sub ContextCopy() Handles V_CSMenu.ContextCopy
        If DgnDARActivity.RowCount = 0 Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            Clipboard.SetText(DgnDARActivity.CurrentRow.Cells("employeeactivity_description").Value.ToString)
        End If
    End Sub
#End Region

#Region "Upper Form Bar"
    <SupportedOSPlatform("windows")>
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GetData(False)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DtpMonth_KeyDown(sender As Object, e As KeyEventArgs) Handles DtpMonth.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GetData(False)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Call ClearFind()
    End Sub

    Private Sub ChkEnableDateFilter_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEnableDateFilter.CheckedChanged
        DtpMonth.Enabled = ChkEnableDateFilter.Checked
    End Sub
#End Region

#Region "Main Form Events"
    <SupportedOSPlatform("windows")>
    Private Sub frmDailyActivityReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Memuat Menu
        Call LoadMenu()

        'Memuat Datagrid
        Call LoadDGN()

        'Memuat Data
        Call ClearFind()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DAR_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (V_MMSMenu.Checked("EventToolsViewAttachment")) Then
            Commands.DAR.View.SaveSettings(varDatabaseName, varDatabaseEngine, varProperties.UserID, "ViewPhotoTab", "True")
        Else
            Commands.DAR.View.SaveSettings(varDatabaseName, varDatabaseEngine, varProperties.UserID, "ViewPhotoTab", "False")
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DAR_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        SpcDate.SplitterDistance = 190
        If (V_MMSMenu.Checked("EventToolsViewAttachment")) Then
            'SpcContent.SplitterDistance = 200
        End If
        SpcPhoto.SplitterDistance = (TPPhotos.Width - (300 + SpcPhoto.SplitterWidth))
    End Sub
#End Region

#Region "Component Events : Cbo"
    <SupportedOSPlatform("windows")>
    Private Sub CboBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboBy.SelectedIndexChanged
        If (ChkEnableByFilter.Checked) Then
            Call GETDATA(False)
        End If
    End Sub
#End Region

#Region "Component Events : Chk"
    <SupportedOSPlatform("windows")>
    Private Sub ByFilterChkEnableBy_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEnableByFilter.CheckedChanged
        CboBy.Enabled = ChkEnableByFilter.Checked
        If (ChkEnableByFilter.Checked) Then
            Call GETDATA(False)
        End If
    End Sub
#End Region

#Region "Component Events : Dgn"
    <SupportedOSPlatform("windows")>
    Private Sub DgnDARDate_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnDARDate.CellClick
        If DgnDARDate.RowCount <> 0 Then
            Call OnDgnDateChange()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnDARDate_KeyUp(sender As Object, e As KeyEventArgs) Handles DgnDARDate.KeyUp
        If ((e.KeyCode = Keys.Up) OrElse (e.KeyCode = Keys.Down)) AndAlso (DgnDARDate.RowCount > 1) Then
            Call OnDgnDateChange()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub OnDgnActivityChange()
        If DgnDARActivity.RowCount <> 0 Then
            V_ContentID = DgnDARActivity.CurrentRow.Cells("employeeactivity_id").Value.ToString
        Else
            V_ContentID = "-1"
        End If

        Call LoadAttachment(V_ShowAttachment)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnDARActivity_KeyUp(sender As Object, e As KeyEventArgs) Handles DgnDARActivity.KeyUp
        If ((e.KeyCode = Keys.Up) OrElse (e.KeyCode = Keys.Down)) AndAlso (DgnDARActivity.RowCount > 1) Then
            Call OnDgnActivityChange()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnPhoto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnPhoto.CellContentClick
        Dim sendergrid = DirectCast(sender, CMCv.dgn)

        If TypeOf sendergrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            V_DAR_SinglePhotoViewer = New DAR_SinglePhotoViewer(PctbxActivityPhoto.Image)
            Display(V_DAR_SinglePhotoViewer, IMAGEDB.Main.ImageLibrary.PCTPRV_ICON, "Photo Viewer", "Preview your photo", True)
            Mainframe_n_6.Ts_status.Text = String.Empty
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnPhoto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnPhoto.CellClick
        Call PhotoPlugin(V_ShowAttachment)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnPhoto_KeyUp(sender As Object, e As KeyEventArgs) Handles DgnPhoto.KeyUp
        If ((e.KeyCode = Keys.Up) OrElse (e.KeyCode = Keys.Down)) AndAlso (DgnPhoto.RowCount > 1) Then
            Call PhotoPlugin(V_ShowAttachment)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnFile_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnFile.CellContentClick
        Dim sendergrid = DirectCast(sender, CMCv.dgn)
        Dim _Bytes As Byte()

        Try
            If TypeOf sendergrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
                Dim V_FileName As String = DgnFile.CurrentRow.Cells("file_id").Value.ToString
                Dim V_FullPath As String = Nothing
                Dim V_DirTempLocation As String = Nothing

                'Cek apakah folder sudah ada
                V_DirTempLocation = CHECKREQUIREDFOLDER(DirName.PDF)

                V_FullPath = V_DirTempLocation & V_FileName & ".pdf"

                If (Not System.IO.File.Exists(V_FullPath)) Then
                    _Bytes = CType(Commands.DAR.View.GetPdfFile(varDatabaseName, varDatabaseEngine, V_FileName), Byte())
                    System.IO.File.WriteAllBytes(V_FullPath, _Bytes)
                End If

                V_DAR_SinglePDFViewer = New DAR_SinglePDFViewer(V_FullPath, V_FileName, True)
                Display(V_DAR_SinglePDFViewer, IMAGEDB.Main.ImageLibrary.PDFPRV_ICON, "PDF Viewer", "Preview your file", True)
                Mainframe_n_6.Ts_status.Text = String.Empty

                _Bytes = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Component Events : Btn"

    <SupportedOSPlatform("windows")>
    Private Sub BtnCopyPhoto_Click(sender As Object, e As EventArgs) Handles BtnCopyPhoto.Click
        Dim varCopyPicture As Image

        If PctbxActivityPhoto.Image Is Nothing Then
            Decision("No photo selected.", "Alert", CMCv.frmDialogBox.MessageIcon.Alert, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            If varTextmark = String.Empty Then
                varCopyPicture = PctbxActivityPhoto.Image
            Else
                varCopyPicture = CMCv.ImageEditor.Proccessor.Editor.WaterMarker(PctbxActivityPhoto.Image, varTextmark)
            End If
            Clipboard.SetImage(varCopyPicture)
        End If
        varCopyPicture = Nothing
        'CopyPicture.Dispose()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim varSavePicture As Image

        If PctbxActivityPhoto.Image Is Nothing Then
            Decision("No photo selected.", "Alert", CMCv.frmDialogBox.MessageIcon.Alert, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            SfdPhoto.Title = "Ingrid Photo - Save As..."
            SfdPhoto.FileName = DgnPhoto.CurrentRow.Cells("photo_id").Value.ToString & ".jpg"
            SfdPhoto.Filter = "Photo File|*.jpg"

            If SfdPhoto.ShowDialog = DialogResult.OK Then
                If varTextmark = String.Empty Then
                    varSavePicture = PctbxActivityPhoto.Image
                Else
                    varSavePicture = CMCv.ImageEditor.Proccessor.Editor.WaterMarker(PctbxActivityPhoto.Image, varTextmark)
                End If
                varSavePicture.Save(SfdPhoto.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
        End If
        varSavePicture = Nothing
        'SavePicture.Dispose()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnLike_Click(sender As Object, e As EventArgs) Handles BtnLike.Click
        If PctbxActivityPhoto.Image Is Nothing Then
            Decision("No photo selected.", "Alert", CMCv.frmDialogBox.MessageIcon.Alert, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            If Not (Commands.DAR.View.IsLike(varDatabaseName, varDatabaseEngine, DgnPhoto.CurrentRow.Cells("photo_id").Value.ToString, varProperties.EmployeeID)) Then
                If (Commands.DAR.View.LikePhoto(varDatabaseName, varDatabaseEngine, DgnPhoto.CurrentRow.Cells("photo_id").Value.ToString, varProperties.EmployeeID, DgnDARActivity.CurrentRow.Cells("employee_id").Value.ToString)) Then
                    Mainframe_n_6.Ts_status.Text = DgnPhoto.CurrentRow.Cells("photo_employee_fullname").Value.ToString & " would like to say thank you for your appreciation."
                Else
                    SLFStatus.Items(0).Text = ""
                End If
            End If
        End If
    End Sub
#End Region

#Region "WithEvents"
    <SupportedOSPlatform("windows")>
    Private Sub F_DAR_Editor_RecordSaved() Handles F_DAR_Editor.RecordSaved
        Call GetData(True)
        Call FillEmployee()
    End Sub

    Private Sub F_DAR_Editor_FormClosed(sender As Object, e As FormClosedEventArgs) Handles F_DAR_Editor.FormClosed
        Me.Focus()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventReportShow() Handles V_MMSMenu.EventReportShow
        If Not (varUserAccess.User(varDatabaseName, "DAR", varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Report)) Then
            Decision("You are not authorized to : Generate Report", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If
        F_DAR_Reports = New DAR_RPTFilter
        Display(F_DAR_Reports, IMAGEDB.Main.ImageLibrary.SEARCH_ICON, "Report Filter", "", True,)
    End Sub
#End Region

End Class
