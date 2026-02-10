Imports System.Runtime.Versioning
Imports Serilog.Sinks.Http

''' <summary>
''' Module : DAR View
''' </summary>
Public Class FRMdar
#Region "Variables"
    Private WithEvents Frm_dar_SinglePhotoViewer As DAR_SinglePhotoViewer
    Private WithEvents Frm_dar_SinglePDFViewer As DAR_SinglePDFViewer
    Private WithEvents Frm_dar_Editor As New FRMdarEditor
    Private WithEvents Frm_dar_Reports As DAR_RPTFilter
    Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip
    Private WithEvents Com_cs_Menu As New CMCv.UI.View.ContextMenu

    Private varShowAttachment As Boolean
    Private varContentID As String
    Private varLoadDgDateFinished As Boolean
    Private varLoadDgContentFinished As Boolean
    Private varPhotoByte As Byte() 'Variabel untuk konversi foto
    Private varPhotoRow As Integer = 0 'Variabel baris foto
    Private varCurrentDate As Date
    Private varCurrentDateString As String

    Const varMessageViewAttachment As String = "EventToolsViewAttachment"
    Const varMessageNotAuthorized As String = "Not Authorized"
#End Region

#Region "Sub Collections"
    ''' <summary>
    ''' Mengisi CBOBy dengan data karyawan
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub FillEmployee()
        CMDdar.View.FillEmployee(varDatabaseName, varDatabaseEngine, CboBy)
    End Sub

    ''' <summary>
    ''' Menampilkan data awal
    ''' </summary>
    ''' <param name="ForceRefresh">Boolean</param>
    <SupportedOSPlatform("windows")>
    Private Sub GetData(Optional forcerefresh As Boolean = False)
        'Menyatakan bahwa datagrid belum selesai memuat data
        varLoadDGDateFinished = False
        varLoadDgContentFinished = False

        'Buffer Datagrid
        DblBuffer(DgnDARDate)
        DblBuffer(DgnDARActivity)

        'Mengisi nilai variabel ShowAttachment
        varShowAttachment = Com_mms_Menu.Checked(varMessageViewAttachment)

        'Mengisi Datagrid dengan data dari database    
        CMDdar.View.DisplayMainGrid(varDatabaseName, varDatabaseEngine, TxtFind, DgnDARDate, SLFStatus, SttActivity, ChkEnableDateFilter, DtpMonth, ChkEnableByFilter, CboBy, forcerefresh)

        'Mengisi Datagrid Activity dengan data dari database
        Call OnDgnDateChange()
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
        Com_mms_Menu.ShowMenuTools(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        'Menampilkan Menu REPORTS
        Com_mms_Menu.ShowMenuReports(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        'Menampilkan Menu TOOLS > View Attachment
        Com_mms_Menu.Visible(varMessageViewAttachment, CType(True, CMCv.UI.View.MenuStrip.ShowItem))

        'Mengambil nilai dari database usersettings, jika ya maka tampilkan Menu Show Attachment
        If (CMDdar.View.CheckSettings(varDatabaseName, varDatabaseEngine, varProperties.UserID, "viewphototab")) Then
            Com_mms_Menu.Checked(varMessageViewAttachment, CType(True, CMCv.UI.View.MenuStrip.ShowItem))
            SpcContent.Panel2Collapsed = False
            Call LoadAttachment(varShowAttachment)
        Else
            SpcContent.Panel2Collapsed = True
        End If
    End Sub

    ''' <summary>
    ''' Memuat setting datagrid
    ''' </summary>
    Private Sub LoadDgn()
        'Memuat warna acak
        DgnDARDate.XOGETNewColor()
        DgnDARActivity.XOGETNewColor()
        DgnPhoto.XOGETNewColor()
        DgnFile.XOGETNewColor()

        'Memuat menu klik kanan
        Com_cs_Menu.LoadInGrid(DgnDARActivity)
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub OnDgnDateChange()
        If DgnDARDate.RowCount <> 0 Then
            varCurrentDate = CType(DgnDARDate.CurrentRow.Cells("employeeactivity_datetime").Value, Date)
            varCurrentDateString = varCurrentDate.Year & "-" & varCurrentDate.Month & "-" & varCurrentDate.Day
        Else
            varCurrentDate = Now.AddYears(2)
            varCurrentDateString = "9999-12-31"
        End If
        CMDdar.View.DisplaySecondGrid(varDatabaseName, varDatabaseEngine, varCurrentDateString, DgnDARActivity, SttActivity, TxtFind, varShowAttachment, DgnPhoto, DgnFile)

        Call PhotoPlugin(varShowAttachment)
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    <SupportedOSPlatform("windows")>
    Private Sub DgnDarActivity_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnDARActivity.CellClick
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
                varPhotoByte = CType(DgnPhoto.CurrentRow.Cells("photo_content").Value, Byte())
                Dim varPhotoStream = New System.IO.MemoryStream(varPhotoByte)

                PctbxActivityPhoto.Image = System.Drawing.Image.FromStream(varPhotoStream)
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
        Call GetData(True)
        Call FillEmployee()
    End Sub

    ''' <summary>
    ''' Load attachment
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub LoadAttachment(ByVal istabattachmentvisible As Boolean)
        If (istabattachmentvisible) Then
            DblBuffer(DgnPhoto)
            CMDdar.View.DisplayPhotoGrid(varDatabaseName, varDatabaseEngine, varContentID, DgnPhoto)

            Call PhotoPlugin(varShowAttachment)

            DblBuffer(DgnFile)
            CMDdar.View.DisplayFileGrid(varDatabaseName, varDatabaseEngine, varContentID, DgnFile)
        End If
    End Sub
#End Region

#Region "Menu Strip Function"
    ''' <summary>
    ''' Add new data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub EventDataAddNew() Handles Com_mms_Menu.EventDataAddNew
        If Not (varUserAccess.User(varDatabaseName, "DAR", varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Add)) Then
            Decision("You are not authorized to : Add new record", varMessageNotAuthorized, CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Return
        End If
        varFormProperties.IsNew = True
        varFormProperties.RowID = "-1"
        Frm_dar_Editor = New FRMdarEditor
        Display(Frm_dar_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new activity", True)
        FRMmainframe6.Ts_status.Text = String.Empty
    End Sub

    ''' <summary>
    ''' Edit existing data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Public Sub EventDataEdit() Handles Com_mms_Menu.EventDataEdit
        If Not (varUserAccess.User(varDatabaseName, "DAR", varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Edit)) Then
            Decision("You are not authorized to : Modify existing record", varMessageNotAuthorized, CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Return
        End If

        Call GetRowID()
        varFormProperties.IsNew = False

        If Convert.ToString(varFormProperties.RowID) Is "-1" Then
            Decision("No record selected", "Error", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        Else
            Frm_dar_Editor = New FRMdarEditor
            Display(Frm_dar_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "update activity", True)
        End If
        FRMmainframe6.Ts_status.Text = String.Empty
    End Sub

    ''' <summary>
    ''' Delete selected data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles Com_mms_Menu.EventDataDelete
        If Not (varUserAccess.User(varDatabaseName, "DAR", varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Delete)) Then
            Decision("You are not authorized to : Delete record", varMessageNotAuthorized, CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Return
        End If
        Call GetRowID()
        If Convert.ToString(varFormProperties.RowID) Is "-1" Then
            Decision("No record selected", "Error", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        Else
            varFormProperties.IsNew = False
            If Decision("Do you want to delete this record?" & vbCrLf & vbCrLf & "=======================================================" & vbCrLf & DgnDARActivity.CurrentRow.Cells("employeeactivity_description").Value.ToString & vbCrLf & "=======================================================", "Delete", CMCv.FRMdialogbox.MessageIcon.Question, CMCv.FRMdialogbox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (CMDdar.View.DeleteData(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID).ToString)) Then
                    Call GetData(True)
                    Call FillEmployee()
                    FRMmainframe6.Ts_status.Text = "Success"
                Else
                    FRMmainframe6.Ts_status.Text = "Delete failed"
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' Load data with filter applied
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub EventDataRefresh() Handles Com_mms_Menu.EventDataRefresh
        TxtFind.Clear()
        ChkEnableDateFilter.Checked = False
        Call GetData(True)
    End Sub

    ''' <summary>
    ''' Close form
    ''' </summary>
    Private Sub EventDataClose() Handles Com_mms_Menu.EventDataClose
        Me.Close()
    End Sub

    ''' <summary>
    ''' Search mode
    ''' </summary>
    Private Sub EventToolsFind() Handles Com_mms_Menu.EventToolsFind
        TxtFind.Focus()
    End Sub

    ''' <summary>
    ''' Toogle view photo menu
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub EventToolsViewAttachment() Handles Com_mms_Menu.EventToolsViewAttachment
        If (Com_mms_Menu.Checked(varMessageViewAttachment)) Then
            Com_mms_Menu.Checked(varMessageViewAttachment, CType(False, CMCv.UI.View.MenuStrip.ShowItem))
            SpcContent.Panel2Collapsed = True
            varShowAttachment = False
        Else
            Com_mms_Menu.Checked(varMessageViewAttachment, CType(True, CMCv.UI.View.MenuStrip.ShowItem))
            SpcContent.Panel2Collapsed = False
            SpcContent.SplitterDistance = 200
            SpcPhoto.SplitterDistance = (TPPhotos.Width - (300 + SpcPhoto.SplitterWidth))
            varShowAttachment = True
        End If
        Call LoadAttachment(varShowAttachment)
    End Sub
#End Region

#Region "Context Menu Event"
    Private Sub ContextCopy() Handles Com_cs_Menu.ContextCopy
        If DgnDARActivity.RowCount = 0 Then
            Decision("No record selected", "Error", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
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
    Private Sub FRMdar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Memuat Menu
        Call LoadMenu()

        'Memuat Datagrid
        Call LoadDgn()

        'Memuat Data
        Call ClearFind()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub FRMdar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (Com_mms_Menu.Checked(varMessageViewAttachment)) Then
            CMDdar.View.SaveSettings(varDatabaseName, varDatabaseEngine, varProperties.UserID, "ViewPhotoTab", "True")
        Else
            CMDdar.View.SaveSettings(varDatabaseName, varDatabaseEngine, varProperties.UserID, "ViewPhotoTab", "False")
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub FRMdar_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        SpcDate.SplitterDistance = 190
        If (Com_mms_Menu.Checked(varMessageViewAttachment)) Then
            'SpcContent.SplitterDistance = 200
        End If
        SpcPhoto.SplitterDistance = (TPPhotos.Width - (300 + SpcPhoto.SplitterWidth))
    End Sub
#End Region

#Region "Component Events : Cbo"
    <SupportedOSPlatform("windows")>
    Private Sub CboBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboBy.SelectedIndexChanged
        If (ChkEnableByFilter.Checked) Then
            Call GetData(False)
        End If
    End Sub
#End Region

#Region "Component Events : Chk"
    <SupportedOSPlatform("windows")>
    Private Sub ByFilterChkEnableBy_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEnableByFilter.CheckedChanged
        CboBy.Enabled = ChkEnableByFilter.Checked
        If (ChkEnableByFilter.Checked) Then
            Call GetData(False)
        End If
    End Sub
#End Region

#Region "Component Events : Dgn"
    <SupportedOSPlatform("windows")>
    Private Sub DgndarDate_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnDARDate.CellClick
        If DgnDARDate.RowCount <> 0 Then
            Call OnDgnDateChange()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgndarDate_KeyUp(sender As Object, e As KeyEventArgs) Handles DgnDARDate.KeyUp
        If ((e.KeyCode = Keys.Up) OrElse (e.KeyCode = Keys.Down)) AndAlso (DgnDARDate.RowCount > 1) Then
            Call OnDgnDateChange()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub OnDgnActivityChange()
        If DgnDARActivity.RowCount <> 0 Then
            varContentID = DgnDARActivity.CurrentRow.Cells("employeeactivity_id").Value.ToString
        Else
            varContentID = "-1"
        End If

        Call LoadAttachment(varShowAttachment)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgndarActivity_KeyUp(sender As Object, e As KeyEventArgs) Handles DgnDARActivity.KeyUp
        If ((e.KeyCode = Keys.Up) OrElse (e.KeyCode = Keys.Down)) AndAlso (DgnDARActivity.RowCount > 1) Then
            Call OnDgnActivityChange()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnPhoto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnPhoto.CellContentClick
        Dim sendergrid = DirectCast(sender, CMCv.dgn)

        If TypeOf sendergrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            Frm_dar_SinglePhotoViewer = New DAR_SinglePhotoViewer(PctbxActivityPhoto.Image)
            Display(Frm_dar_SinglePhotoViewer, IMAGEDB.Main.ImageLibrary.PCTPRV_ICON, "Photo Viewer", "Preview your photo", True)
            FRMmainframe6.Ts_status.Text = String.Empty
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnPhoto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnPhoto.CellClick
        Call PhotoPlugin(varShowAttachment)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnPhoto_KeyUp(sender As Object, e As KeyEventArgs) Handles DgnPhoto.KeyUp
        If ((e.KeyCode = Keys.Up) OrElse (e.KeyCode = Keys.Down)) AndAlso (DgnPhoto.RowCount > 1) Then
            Call PhotoPlugin(varShowAttachment)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnFile_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnFile.CellContentClick
        Dim sendergrid = DirectCast(sender, CMCv.dgn)
        Dim varBytes As Byte()

        Try
            If TypeOf sendergrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
                Dim varFileName As String = DgnFile.CurrentRow.Cells("file_id").Value.ToString
                Dim varFullPath As String = Nothing
                Dim varDirTempLocation As String = Nothing

                'Cek apakah folder sudah ada
                varDirTempLocation = CheckRequiredFolder(DirName.PDF)

                varFullPath = varDirTempLocation & varFileName & ".pdf"

                If (Not System.IO.File.Exists(varFullPath)) Then
                    varBytes = CType(CMDdar.View.GetPdfFile(varDatabaseName, varDatabaseEngine, varFileName), Byte())
                    System.IO.File.WriteAllBytes(varFullPath, varBytes)
                End If

                Frm_dar_SinglePDFViewer = New DAR_SinglePDFViewer(varFullPath, varFileName, True)
                Display(Frm_dar_SinglePDFViewer, IMAGEDB.Main.ImageLibrary.PDFPRV_ICON, "PDF Viewer", "Preview your file", True)
                FRMmainframe6.Ts_status.Text = String.Empty

                varBytes = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Component Events : Btn"

    <SupportedOSPlatform("windows")>
    Private Sub BtnCopyPhoto_Click(sender As Object, e As EventArgs) Handles BtnCopyPhoto.Click
        Dim varCopyPicture As Image = Nothing

        If PctbxActivityPhoto.Image Is Nothing Then
            Decision("No photo selected.", "Alert", CMCv.FRMdialogbox.MessageIcon.Alert, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        Else
            If varTextmark = String.Empty Then
                varCopyPicture = PctbxActivityPhoto.Image
            Else
                varCopyPicture = CMCv.ImageEditor.Proccessor.Editor.WaterMarker(PctbxActivityPhoto.Image, varTextmark)
            End If
            Clipboard.SetImage(varCopyPicture)
        End If
        varCopyPicture.Dispose()
        'CopyPicture.Dispose()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim varSavePicture As Image = Nothing

        If PctbxActivityPhoto.Image Is Nothing Then
            Decision("No photo selected.", "Alert", CMCv.FRMdialogbox.MessageIcon.Alert, CMCv.FRMdialogbox.MessageTypes.OkOnly)
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
        varSavePicture.Dispose()
        'SavePicture.Dispose()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnLike_Click(sender As Object, e As EventArgs) Handles BtnLike.Click
        If PctbxActivityPhoto.Image Is Nothing Then
            Decision("No photo selected.", "Alert", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
        Else
            If Not (CMDdar.View.IsLike(varDatabaseName, varDatabaseEngine, DgnPhoto.CurrentRow.Cells("photo_id").Value.ToString, varProperties.EmployeeID)) Then
                If (CMDdar.View.LikePhoto(varDatabaseName, varDatabaseEngine, DgnPhoto.CurrentRow.Cells("photo_id").Value.ToString, varProperties.EmployeeID, DgnDARActivity.CurrentRow.Cells("employee_id").Value.ToString)) Then
                    FRMmainframe6.Ts_status.Text = DgnPhoto.CurrentRow.Cells("photo_employee_fullname").Value.ToString & " would like to say thank you for your appreciation."
                Else
                    SLFStatus.Items(0).Text = ""
                End If
            End If
        End If
    End Sub
#End Region

#Region "WithEvents"
    <SupportedOSPlatform("windows")>
    Private Sub FRMdarEditor_RecordSaved() Handles Frm_dar_Editor.EventRecordSaved
        Call GetData(True)
        Call FillEmployee()
    End Sub

    Private Sub FRMdarEditor_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Frm_dar_Editor.FormClosed
        Me.Focus()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub CommmsMenu_EventReportShow() Handles Com_mms_Menu.EventReportShow
        If Not (varUserAccess.User(varDatabaseName, "DAR", varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Report)) Then
            Decision("You are not authorized to : Generate Report", varMessageNotAuthorized, CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Return
        End If
        Frm_dar_Reports = New DAR_RPTFilter
        Display(Frm_dar_Reports, IMAGEDB.Main.ImageLibrary.SEARCH_ICON, "Report Filter", "", True,)
    End Sub
#End Region

End Class
