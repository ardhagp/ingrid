Imports System.Data
Imports System.IO
Imports System.Runtime.Versioning
Imports System.Text
Imports CMCv
Imports Serilog.Sinks.Http

Public Class DAR_Editor
#Region "Variables"
    Public Event RecordSaved()
    Private V_DAR_SinglePhotoViewer As DAR_SinglePhotoViewer
    Private V_DAR_SinglePDFViewer As DAR_SinglePDFViewer
    Private V_SQL As New Commands.DAR.Editor
    Private WithEvents V_MMSMenu As New CMCv.UI.View.MenuStrip
    Private V_DS(2) As DataSet
    Private V_PhotoByte As Byte()
    Private V_ExtQuery As String
    Private varHour, varMinute As String
#End Region

#Region "Sub Collections"
    <SupportedOSPlatform("windows")>
    Private Sub GETAffectedArea()
        Commands.DAR.Editor.GETAffectedArea(V_DatabaseEngine, CboArea)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub GETTemplateTitle()
        Commands.DAR.Editor.GETTemplateTitle(V_DatabaseEngine, CboTemplate)
    End Sub

    Public Sub CheckAllInput()
        DtpStart.Focus()
        MebStart.Focus()
        DtpEnd.Focus()
        MebEnd.Focus()
        CboArea.Focus()
        CboTemplate.Focus()
        TxtContent.Focus()
        BtnSave.Focus()
    End Sub

    <SupportedOSPlatform("windows")>
    Public Sub LoadAttachment()
        V_DS(0) = New DataSet

        DblBuffer(DgnPictureList)
        DgnPictureList.Rows.Clear()
        TxtPhotoPath.Clear()

        V_DS(0) = V_SQL.DisplayPhotoGrid(V_DatabaseEngine, V_FORMAttrib.RowID.ToString, DgnPictureList)

        For i As Integer = 0 To V_DS(0).Tables("TPhotoFileEditor").Rows.Count - 1
            DgnPictureList.Rows.Add(V_DS(0).Tables("TPhotoFileEditor").Rows(i).Item("file_id"), V_DS(0).Tables("TPhotoFileEditor").Rows(i).Item("file_filename"), V_DS(0).Tables("TPhotoFileEditor").Rows(i).Item("file_datetime"), V_DS(0).Tables("TPhotoFileEditor").Rows(i).Item("file_content"), "", V_DS(0).Tables("TPhotoFileEditor").Rows(i).Item("file_uploader"))
        Next

        If DgnPictureList.RowCount = 0 Then
            PctbxPhoto.Image = Nothing
        End If

        DgnFileList.Rows.Clear()
        TxtFilePath.Clear()

        V_DS(1) = New DataSet

        DblBuffer(DgnFileList)
        V_DS(1) = V_SQL.DisplayFileGrid(V_DatabaseEngine, V_FORMAttrib.RowID.ToString, DgnFileList)

        For i As Integer = 0 To V_DS(1).Tables("TFileEditor").Rows.Count - 1
            DgnFileList.Rows.Add(V_DS(1).Tables("TFileEditor").Rows(i).Item("file_id"), V_DS(1).Tables("TFileEditor").Rows(i).Item("file_filename"), V_DS(1).Tables("TFileEditor").Rows(i).Item("file_tag"), V_DS(1).Tables("TFileEditor").Rows(i).Item("file_datetime"), V_DS(1).Tables("TFileEditor").Rows(i).Item("file_content"), "", V_DS(1).Tables("TFileEditor").Rows(i).Item("file_uploader"))
        Next
    End Sub
#End Region

#Region "Function Collections"

#End Region

#Region "Form Events"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub frmDailyActivityReports_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GETAffectedArea()
        Call GETTemplateTitle()

        V_MMSMenu.LoadIn(Me, True)
        V_MMSMenu.ShowMenuFILE(CMCv.UI.View.MenuStrip.ShowItem.Yes)

        DgnPictureList.XOGETNewColor()

        If Now.Hour.ToString.Length = 1 Then
            varHour = "0" & Now.Hour.ToString
        ElseIf Now.Hour.ToString.Length = 2 Then
            varHour = Now.Hour.ToString
        End If

        If Now.Minute.ToString.Length = 1 Then
            varMinute = "0" & Now.Minute.ToString
        ElseIf Now.Minute.ToString.Length = 2 Then
            varMinute = Now.Minute.ToString
        End If

        If (V_FORMAttrib.IsNew) Then
            V_FORMAttrib.RowID = CMCv.Security.Encrypt.MD5()
            MebStart.Text = varHour & ":" & varMinute
            MebEnd.Text = varHour & ":" & varMinute
            TxtContent.Text = String.Empty
            ChkAddNew.Visible = True
            DtpStart.MinDate = CType("01/01/" & Year(Now()), Date)
        Else
            Call LoadData()
            ChkAddNew.Visible = False
        End If

        CboFileTag.Items.Add("PACKING LIST / MANIFEST")
        CboFileTag.SelectedIndex = 0
        CboFileTag.Items.Add("CERTIFICATE")
        CboFileTag.Items.Add("MSDS / MANUALS")
        CboFileTag.Items.Add("BOOK / REFERENCE")
        CboFileTag.Items.Add("LETTER / AGREEMENT")
        CboFileTag.Items.Add("REVISION")
        CboFileTag.Items.Add("OTHERS")

        DtpStart.MaxDate = DtpEnd.Value
        DtpEnd.MinDate = DtpStart.Value
    End Sub
#End Region

#Region "Component Events"
    <SupportedOSPlatform("windows")>
    Private Sub BtnGETContent_Click(sender As Object, e As EventArgs) Handles BtnGETContent.Click
        If Not (V_FORMAttrib.IsNew) Then
            If Decision("Do you want to replace Description with template content?", "Question", frmDialogBox.MessageIcon.Question, frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                TxtContent.Text = Commands.DAR.Editor.GETTemplateContent(V_DatabaseEngine, CboTemplate)
            End If
        Else
            TxtContent.Text = Commands.DAR.Editor.GETTemplateContent(V_DatabaseEngine, CboTemplate)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call Save()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub Save()
        Dim V_ActivityStart_S As String
        Dim V_ActivityEnd_S As String
        Dim V_ActivityStart_D As Date
        Dim V_ActivityEnd_D As Date

        Call CheckAllInput()

        If (TxtContent.Text = String.Empty) OrElse (CboArea.Items.Count = 0) OrElse (CboTemplate.Items.Count = 0) OrElse (MebStart.Text = String.Empty) OrElse (MebEnd.Text = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Start Time, End Time, Area Affected, Activity Template selected and Description are properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        V_ActivityStart_S = DtpStart.Value.Year & "-" & DtpStart.Value.Month & "-" & DtpStart.Value.Day & " " & MebStart.Text
        V_ActivityEnd_S = DtpEnd.Value.Year & "-" & DtpEnd.Value.Month & "-" & DtpEnd.Value.Day & " " & MebEnd.Text
        V_ActivityStart_D = CDate(V_ActivityStart_S)
        V_ActivityEnd_D = CDate(V_ActivityEnd_S)

        If (V_ActivityStart_D > V_ActivityEnd_D) Then
            Decision("Cannot save your record." & Environment.NewLine & "Start Time should be less than End Time.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        If (Commands.DAR.Editor.PUSHData(V_DatabaseEngine, CboArea.SelectedValue.ToString, CboTemplate.SelectedValue.ToString, CType(DtpStart.Value.Year & "-" & DtpStart.Value.Month & "-" & DtpStart.Value.Day, String), CType(MebStart.Text.Replace(".", ":"), String), CType(DtpEnd.Value.Year & "-" & DtpEnd.Value.Month & "-" & DtpEnd.Value.Day, String), CType(MebEnd.Text.Replace(".", ":"), String), TxtContent.XOSQLText, TxtFeedback.XOSQLText, V_USERAttrib.UID, V_FORMAttrib.RowID.ToString, V_FORMAttrib.IsNew, V_ExtQuery)) Then
            V_ExtQuery = String.Empty
            Mainframe_n_6.Ts_status.Text = "Success"

            Dim V_NewPhotoAdded As Integer = 0
            For Each V_Row As DataGridViewRow In DgnPictureList.Rows
                If V_Row.Cells("photo_status").Value.ToString Is "Add" Then
                    V_NewPhotoAdded += 1
                End If
            Next

            If V_NewPhotoAdded > 0 Then
                If (Commands.DAR.Editor.PUSHPhoto(V_DatabaseEngine, DgnPictureList, V_FORMAttrib.RowID.ToString, V_FORMAttrib.IsNew, DtpStart.Value)) Then
                    Mainframe_n_6.Ts_status.Text = "Success + All pictures has been added"
                Else
                    Mainframe_n_6.Ts_status.Text = "Success + With errors while adding pictures"
                End If

                DgnPictureList.Rows.Clear()
                PctbxPhoto.Image = Nothing
            End If

            'Add new File
            Dim V_NewFileAdded As Integer = 0
            For Each V_Row As DataGridViewRow In DgnFileList.Rows
                If V_Row.Cells("file_status").Value.ToString Is "Add" Then
                    V_NewFileAdded += 1
                End If
            Next

            If V_NewFileAdded > 0 Then
                If (Commands.DAR.Editor.PUSHFile(V_DatabaseEngine, DgnFileList, V_FORMAttrib.RowID.ToString, V_FORMAttrib.IsNew, DtpStart.Value)) Then
                    Mainframe_n_6.Ts_status.Text = "Success + All file has been added"
                Else
                    Mainframe_n_6.Ts_status.Text = "Success + With errors while adding files"
                End If

                DgnFileList.Rows.Clear()
                PctbxPhoto.Image = Nothing
            End If


            RaiseEvent RecordSaved()
        Else
            Mainframe_n_6.Ts_status.Text = "Failed to save"
            Return
        End If

        TxtContent.Text = String.Empty

        If Not (ChkAddNew.Checked) Then
            Me.Close()
        Else
            V_FORMAttrib.RowID = CMCv.Security.Encrypt.MD5()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub LoadData()
        Commands.DAR.Editor.GETRowValue(V_DatabaseEngine, V_FORMAttrib.RowID.ToString, DtpStart, MebStart, DtpEnd, MebEnd, CboArea, CboTemplate, TxtContent, TxtFeedback)
        Call LoadAttachment()
    End Sub
#End Region

    <SupportedOSPlatform("windows")>
    Private Sub CboTemplate_KeyDown(sender As Object, e As KeyEventArgs) Handles CboTemplate.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not (V_FORMAttrib.IsNew) Then
                If Decision("Do you want to replace Description with template content?", "Question", frmDialogBox.MessageIcon.Question, frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                    TxtContent.Text = Commands.DAR.Editor.GETTemplateContent(V_DatabaseEngine, CboTemplate)
                End If
            Else
                TxtContent.Text = Commands.DAR.Editor.GETTemplateContent(V_DatabaseEngine, CboTemplate)
            End If
        End If
    End Sub

    Private Sub DtpStart_ValueChanged(sender As Object, e As EventArgs) Handles DtpStart.ValueChanged
        DtpEnd.MinDate = DtpStart.Value
    End Sub

    Private Sub DtpEnd_ValueChanged(sender As Object, e As EventArgs) Handles DtpEnd.ValueChanged
        DtpStart.MaxDate = DtpEnd.Value
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnAddPhoto_Click(sender As Object, e As EventArgs) Handles BtnAddPhoto.Click
        Try
            If TxtPhotoPath.Text.Trim = String.Empty Then
                Decision("Plase pick your photo first.", "No file selected", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
                Return
            ElseIf Not CMCv.OperatingSystem.File.Info.IsExists(TxtPhotoPath.Text) Then
                Decision("Your photo cannot be found.", "File not found", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
                Return
            ElseIf Not (OperatingSystem.File.Upload.IsAllowedSize(TxtPhotoPath.Text, _MAXUPLOADSIZE_PHOTO, True)) Then
                Return
            End If

            Dim Row As Object() = Nothing
            Dim V_Date As Date = Now
            Dim V_Photo As System.Drawing.Image = CMCv.ImageEditor.Proccessor.Compress.OutputAsImage(TxtPhotoPath.Text) 'System.Drawing.Image.FromFile(TxtPhotoPath.Text)

            Row = New Object() {CMCv.Security.Encrypt.MD5(), IO.Path.GetFileNameWithoutExtension(TxtPhotoPath.Text), V_Date, V_Photo, "Add", V_USERAttrib.EID}

            With DgnPictureList.Rows
                .Add(Row)
            End With

            TxtPhotoPath.Text = String.Empty
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnBrowsePhoto_Click(sender As Object, e As EventArgs) Handles BtnBrowsePhoto.Click
        OfdPhoto.Title = "Ingrid Photo Picker"
        OfdPhoto.FileName = ""
        OfdPhoto.Filter = "Photo File|*.Jpg;*.Jpeg"

        If OfdPhoto.ShowDialog = DialogResult.OK Then
            TxtPhotoPath.Text = OfdPhoto.FileName
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnPeekPhoto_Click(sender As Object, e As EventArgs) Handles BtnPeekPhoto.Click
        If TxtPhotoPath.Text.Trim = String.Empty Then
            Decision("Plase pick your photo first.", "No file selected", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf Not CMCv.OperatingSystem.File.Info.IsExists(TxtPhotoPath.Text) Then
            Decision("Your photo cannot be found.", "File not found", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        V_DAR_SinglePhotoViewer = New DAR_SinglePhotoViewer(TxtPhotoPath.Text)
        DISPLAY(V_DAR_SinglePhotoViewer, IMAGEDB.Main.ImageLibrary.PCTPRV_ICON, "Photo Viewer", "Preview your photo", True)

    End Sub

    Private Sub DgnPictureList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnPictureList.CellContentClick
        Dim V_Sendergrid = DirectCast(sender, dgn)

        If TypeOf V_Sendergrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            If Decision("Do you want to remove selected photo?", "Question", frmDialogBox.MessageIcon.Question, frmDialogBox.MessageTypes.YesNo) = DialogResult.Yes Then
                If DgnPictureList.CurrentRow.Cells("photo_status").Value IsNot "Add" Then
                    V_ExtQuery += String.Format("delete from db_universe_erp_file.dbo.[[sto]]file] where [file_id] = '{0}';", DgnPictureList.CurrentRow.Cells("photo_id").Value)
                End If

                DgnPictureList.Rows.Remove(DgnPictureList.SelectedRows(0))

                If DgnPictureList.RowCount = 0 Then
                    PctbxPhoto.Image = Nothing
                End If
            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnPictureList_SLF_Selected() Handles DgnPictureList.XOSelected
        If DgnPictureList.RowCount <> 0 Then
            If DgnPictureList.CurrentRow.Cells("photo_status").Value.ToString Is "Add" Then
                PctbxPhoto.Image = CType(DgnPictureList.CurrentRow.Cells("photo_content").Value, Image)
            Else
                'Dim string64 As String
                'string64 = DgnPictureList.CurrentRow.Cells("photo_content").Value.ToString
                '_PhotoByte = Convert.FromBase64String(string64)

                V_PhotoByte = CType(DgnPictureList.CurrentRow.Cells("photo_content").Value, Byte())

                Dim V_PhotoStream = New System.IO.MemoryStream(V_PhotoByte)
                PctbxPhoto.Image = System.Drawing.Image.FromStream(V_PhotoStream)
            End If
        End If
    End Sub

    Private Sub BtnBrowseFile_Click(sender As Object, e As EventArgs) Handles BtnBrowseFile.Click
        ofdFile.Title = "Ingrid File Picker"
        ofdFile.FileName = ""
        ofdFile.Filter = "PDF File|*.pdf;"

        If ofdFile.ShowDialog = DialogResult.OK Then
            TxtFilePath.Text = ofdFile.FileName
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnPeekFile_Click(sender As Object, e As EventArgs) Handles BtnPeekFile.Click
        If TxtFilePath.Text.Trim = String.Empty Then
            Decision("Plase pick your file first.", "No file selected", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf Not (CMCv.OperatingSystem.File.Info.IsExists(TxtFilePath.Text)) Then
            Decision("Your file cannot be found.", "File not found", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        V_DAR_SinglePDFViewer = New DAR_SinglePDFViewer(TxtFilePath.Text, "", False)
        DISPLAY(V_DAR_SinglePDFViewer, IMAGEDB.Main.ImageLibrary.PDFPRV_ICON, "PDF Viewer", "Preview your file", True)
    End Sub

    Private Sub BtnAddFile_Click(sender As Object, e As EventArgs) Handles BtnAddFile.Click
        Try
            If TxtFilePath.Text.Trim = String.Empty Then
                Decision("Plase pick your PDF file first.", "No file selected", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
                Return
            ElseIf Not (CMCv.OperatingSystem.File.Info.IsExists(TxtFilePath.Text)) Then
                Decision("Your file cannot be found.", "File not found", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
                Return
            ElseIf Not (OperatingSystem.File.Upload.IsAllowedSize(TxtFilePath.Text, _MAXUPLOADSIZE_PDF, True)) Then
                Return
            End If

            Dim Row As Object() = Nothing
            Dim V_Date As Date = Now
            'Dim _PDFFile As Object = New IO.FileStream(TxtFilePath.Text, FileMode.Open, FileAccess.Read) 'System.Drawing.Image.FromFile(TxtPhotoPath.Text)

            Row = New Object() {CMCv.Security.Encrypt.MD5(), IO.Path.GetFileNameWithoutExtension(TxtFilePath.Text), CboFileTag.Text, V_Date, TxtFilePath.Text, "Add", V_USERAttrib.EID}

            With DgnFileList.Rows
                .Add(Row)
            End With

            TxtFilePath.Text = String.Empty
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DgnFileList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnFileList.CellContentClick
        Dim V_Sendergrid = DirectCast(sender, dgn)

        If TypeOf V_Sendergrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            If Decision("Do you want to remove selected file?", "Question", frmDialogBox.MessageIcon.Question, frmDialogBox.MessageTypes.YesNo) = DialogResult.Yes Then
                If DgnFileList.CurrentRow.Cells("file_status").Value IsNot "Add" Then
                    V_ExtQuery += String.Format("delete from db_universe_erp_file.dbo.[[sto]]file] where [file_id] = '{0}';", DgnFileList.CurrentRow.Cells("file_id").Value)
                End If
                DgnFileList.Rows.Remove(DgnFileList.SelectedRows(0))

            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventFileSave() Handles V_MMSMenu.EventFileSave
        Call Save()
    End Sub

    Private Sub _MMSMenu_EventFileCancel() Handles V_MMSMenu.EventFileCancel
        Me.Close()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventFileUndoAll() Handles V_MMSMenu.EventFileUndoAll
        If Decision("Do you want to undo all changes?", "Question", frmDialogBox.MessageIcon.Question, frmDialogBox.MessageTypes.YesNo) = DialogResult.Yes Then
            If (V_FORMAttrib.IsNew) Then
                DtpStart.Value = Now.Date
                DtpEnd.Value = Now.Date
                CboArea.SelectedIndex = 0
                CboTemplate.SelectedIndex = 0
                TxtContent.Clear()
                TxtFeedback.Clear()
                TxtPhotoPath.Clear()
                DgnPictureList.Rows.Clear()
                PctbxPhoto.Image = Nothing
                CboFileTag.SelectedIndex = 0
                DgnFileList.Rows.Clear()
                TxtFilePath.Clear()
            Else
                Call LoadData()
            End If
        End If
    End Sub
End Class
