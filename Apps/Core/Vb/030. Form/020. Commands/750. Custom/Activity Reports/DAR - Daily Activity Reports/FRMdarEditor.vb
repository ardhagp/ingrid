Imports System.Data
Imports System.Runtime.Versioning
Imports System.Text

Public Class FRMdarEditor
#Region "Declaration"
    Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip
    Private Frm_dar_SinglePhotoViewer As DAR_SinglePhotoViewer
    Private Frm_dar_SinglePDFViewer As DAR_SinglePDFViewer

    Public Event EventRecordSaved()

    Private varDataSet(2) As DataSet
    Private varPhotoByte As Byte()
    Private varExtendedQuery As String
    Private varHour, varMinute As String

    Const varMessageTablesPhotoFileEditor As String = "TPhotoFileEditor"
    Const varMessageTableFileEditor As String = "TFileEditor"
#End Region

#Region "Sub Collections"
    <SupportedOSPlatform("windows")>
    Private Sub GetAffectedArea()
        CMDdar.Editor.GetAffectedArea(varDatabaseName, varDatabaseEngineE, CboArea)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub GetTemplateTitle()
        CMDdar.Editor.GetTemplateTitle(varDatabaseName, varDatabaseEngineE, CboTemplate)
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
        varDataSet(0) = New DataSet

        DblBuffer(DgnPictureList)
        DgnPictureList.Rows.Clear()
        TxtPhotoPath.Clear()

        varDataSet(0) = CMDdar.Editor.DisplayPhotoGrid(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID).ToString, DgnPictureList)

        For i As Integer = 0 To varDataSet(0).Tables(varMessageTablesPhotoFileEditor).Rows.Count - 1
            DgnPictureList.Rows.Add(varDataSet(0).Tables(varMessageTablesPhotoFileEditor).Rows(i).Item("file_id"), varDataSet(0).Tables(varMessageTablesPhotoFileEditor).Rows(i).Item("file_filename"), varDataSet(0).Tables(varMessageTablesPhotoFileEditor).Rows(i).Item("file_datetime"), varDataSet(0).Tables(varMessageTablesPhotoFileEditor).Rows(i).Item("file_content"), "", varDataSet(0).Tables(varMessageTablesPhotoFileEditor).Rows(i).Item("file_uploader"))
        Next

        If DgnPictureList.RowCount = 0 Then
            PctbxPhoto.Image = Nothing
        End If

        DgnFileList.Rows.Clear()
        TxtFilePath.Clear()

        varDataSet(1) = New DataSet

        DblBuffer(DgnFileList)
        varDataSet(1) = CMDdar.Editor.DisplayFileGrid(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID).ToString, DgnFileList)

        For i As Integer = 0 To varDataSet(1).Tables(varMessageTableFileEditor).Rows.Count - 1
            DgnFileList.Rows.Add(varDataSet(1).Tables(varMessageTableFileEditor).Rows(i).Item("file_id"), varDataSet(1).Tables(varMessageTableFileEditor).Rows(i).Item("file_filename"), varDataSet(1).Tables(varMessageTableFileEditor).Rows(i).Item("file_tag"), varDataSet(1).Tables(varMessageTableFileEditor).Rows(i).Item("file_datetime"), varDataSet(1).Tables(varMessageTableFileEditor).Rows(i).Item("file_content"), "", varDataSet(1).Tables(varMessageTableFileEditor).Rows(i).Item("file_uploader"))
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
    Private Sub FRMdarEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GetAffectedArea()
        Call GetTemplateTitle()

        Com_mms_Menu.LoadIn(Me, True)
        Com_mms_Menu.ShowMenuFile(CMCv.UI.View.MenuStrip.ShowItem.Yes)

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

        If (varFormProperties.IsNew) Then
            varFormProperties.RowID = CMCv.Security.Encrypt.MD5()
            MebStart.Text = varHour & ":" & varMinute
            MebEnd.Text = varHour & ":" & varMinute
            TxtContent.Text = String.Empty
            ChkAddNew.Visible = True
            DtpStart.MinDate = CType("01/01/" & Year(Now()), Date)
        Else
            Call LoadData()
            ChkAddNew.Visible = False
        End If

        With CboFileTag
            .Items.Add("PACKING LIST / MANIFEST")
            .SelectedIndex = 0
            .Items.Add("CERTIFICATE")
            .Items.Add("MSDS / MANUALS")
            .Items.Add("BOOK / REFERENCE")
            .Items.Add("LETTER / AGREEMENT")
            .Items.Add("REVISION")
            .Items.Add("OTHERS")
        End With

        DtpStart.MaxDate = DtpEnd.Value
        DtpEnd.MinDate = DtpStart.Value
    End Sub
#End Region

#Region "Component Events"
    <SupportedOSPlatform("windows")>
    Private Sub BtnGetContent_Click(sender As Object, e As EventArgs) Handles BtnGETContent.Click
        If Not (varFormProperties.IsNew) Then
            If Decision(My.Application.Info.AssemblyName, "Do you want to replace Description with template content?", LibApp.Ingrid.Global.PopupType.Question, "", frmDialogBox.MessageIcon.Question, frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                TxtContent.Text = CMDdar.Editor.GetTemplateContent(varDatabaseName, varDatabaseEngineE, CboTemplate)
            End If
        Else
            TxtContent.Text = CMDdar.Editor.GetTemplateContent(varDatabaseName, varDatabaseEngineE, CboTemplate)
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
        Dim varActivityStartString As String
        Dim varActivityEndString As String
        Dim varActivityStartDate As Date
        Dim varActivityEndDate As Date

        Call CheckAllInput()

        If (TxtContent.Text = String.Empty) OrElse (CboArea.Items.Count = 0) OrElse (CboTemplate.Items.Count = 0) OrElse (MebStart.Text = String.Empty) OrElse (MebEnd.Text = String.Empty) Then
            Decision(My.Application.Info.AssemblyName, "Cannot save your record." & Environment.NewLine & "Make sure you have Start Time, End Time, Area Affected, Activity Template selected and Description are properly filled.", LibApp.Ingrid.Global.PopupType.Alert, "", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        varActivityStartString = DtpStart.Value.Year & "-" & DtpStart.Value.Month & "-" & DtpStart.Value.Day & " " & MebStart.Text
        varActivityEndString = DtpEnd.Value.Year & "-" & DtpEnd.Value.Month & "-" & DtpEnd.Value.Day & " " & MebEnd.Text
        varActivityStartDate = CDate(varActivityStartString)
        varActivityEndDate = CDate(varActivityEndString)

        If (varActivityStartDate > varActivityEndDate) Then
            Decision(My.Application.Info.AssemblyName, "Cannot save your record." & Environment.NewLine & "Start Time should be less than End Time.", LibApp.Ingrid.Global.PopupType.Alert, "", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        If (CMDdar.Editor.PushData(varDatabaseName, varDatabaseEngineE, CboArea.SelectedValue.ToString, CboTemplate.SelectedValue.ToString, CType(DtpStart.Value.Year & "-" & DtpStart.Value.Month & "-" & DtpStart.Value.Day, String), CType(MebStart.Text.Replace(".", ":"), String), CType(DtpEnd.Value.Year & "-" & DtpEnd.Value.Month & "-" & DtpEnd.Value.Day, String), CType(MebEnd.Text.Replace(".", ":"), String), TxtContent.XOSQLText, TxtFeedback.XOSQLText, varProperties.UserID, Convert.ToString(varFormProperties.RowID).ToString, varFormProperties.IsNew, varExtendedQuery)) Then
            varExtendedQuery = String.Empty
            FRMmainframe6.Ts_status.Text = "Success"

            Dim varNewPhotoAdded As Integer = 0
            For Each eachrow As DataGridViewRow In DgnPictureList.Rows
                If eachrow.Cells("photo_status").Value.ToString Is "Add" Then
                    varNewPhotoAdded += 1
                End If
            Next

            If varNewPhotoAdded > 0 Then
                If (CMDdar.Editor.PushPhoto(varDatabaseEngineE, DgnPictureList, Convert.ToString(varFormProperties.RowID).ToString, varFormProperties.IsNew, DtpStart.Value)) Then
                    FRMmainframe6.Ts_status.Text = "Success + All pictures has been added"
                Else
                    FRMmainframe6.Ts_status.Text = "Success + With errors while adding pictures"
                End If

                DgnPictureList.Rows.Clear()
                PctbxPhoto.Image = Nothing
            End If

            'Add new File
            Dim varNewFileAdded As Integer = 0
            For Each eachrow As DataGridViewRow In DgnFileList.Rows
                If eachrow.Cells("file_status").Value.ToString Is "Add" Then
                    varNewFileAdded += 1
                End If
            Next

            If varNewFileAdded > 0 Then
                If (CMDdar.Editor.PushFile(varDatabaseEngineE, DgnFileList, Convert.ToString(varFormProperties.RowID).ToString, varFormProperties.IsNew, DtpStart.Value)) Then
                    FRMmainframe6.Ts_status.Text = "Success + All file has been added"
                Else
                    FRMmainframe6.Ts_status.Text = "Success + With errors while adding files"
                End If

                DgnFileList.Rows.Clear()
                PctbxPhoto.Image = Nothing
            End If

            RaiseEvent EventRecordSaved()
        Else
            FRMmainframe6.Ts_status.Text = "Failed to save"
            Return
        End If

        TxtContent.Text = String.Empty

        If Not (ChkAddNew.Checked) Then
            Me.Close()
        Else
            varFormProperties.RowID = CMCv.Security.Encrypt.MD5()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub LoadData()
        CMDdar.Editor.GetRowValue(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID).ToString, DtpStart, MebStart, DtpEnd, MebEnd, CboArea, CboTemplate, TxtContent, TxtFeedback)
        Call LoadAttachment()
    End Sub
#End Region

    <SupportedOSPlatform("windows")>
    Private Sub CboTemplate_KeyDown(sender As Object, e As KeyEventArgs) Handles CboTemplate.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not (varFormProperties.IsNew) Then
                If Decision(My.Application.Info.AssemblyName, "Do you want to replace Description with template content?", LibApp.Ingrid.Global.PopupType.Question, "", frmDialogBox.MessageIcon.Question, frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                    TxtContent.Text = CMDdar.Editor.GetTemplateContent(varDatabaseName, varDatabaseEngineE, CboTemplate)
                End If
            Else
                TxtContent.Text = CMDdar.Editor.GetTemplateContent(varDatabaseName, varDatabaseEngineE, CboTemplate)
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
                Decision(My.Application.Info.AssemblyName, "Plase pick your photo first.", LibApp.Ingrid.Global.PopupType.NoFileSelected, "", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
                Return
            ElseIf Not CMCv.OperatingSystem.File.Info.IsExists(TxtPhotoPath.Text) Then
                Decision(My.Application.Info.AssemblyName, "Your photo cannot be found.", LibApp.Ingrid.Global.PopupType.FileNotFound, "", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
                Return
            ElseIf Not (CMCv.OperatingSystem.File.Upload.IsAllowedSize(TxtPhotoPath.Text, varMaxUploadSizePhoto, True)) Then
                Return
            End If

            Dim varRow As Object() = Nothing
            Dim varDate As Date = Now
            Dim varPhoto As System.Drawing.Image = CMCv.ImageEditor.Proccessor.Compress.OutputAsImage(TxtPhotoPath.Text) 'System.Drawing.Image.FromFile(TxtPhotoPath.Text)

            varRow = New Object() {CMCv.Security.Encrypt.MD5(), IO.Path.GetFileNameWithoutExtension(TxtPhotoPath.Text), varDate, varPhoto, "Add", varProperties.EmployeeID}

            With DgnPictureList.Rows
                .Add(varRow)
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
            Decision(My.Application.Info.AssemblyName, "Plase pick your photo first.", LibApp.Ingrid.Global.PopupType.NoFileSelected, "", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf Not CMCv.OperatingSystem.File.Info.IsExists(TxtPhotoPath.Text) Then
            Decision(My.Application.Info.AssemblyName, "Your photo cannot be found.", LibApp.Ingrid.Global.PopupType.FileNotFound, "", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        Frm_dar_SinglePhotoViewer = New DAR_SinglePhotoViewer(TxtPhotoPath.Text)
        Display(Frm_dar_SinglePhotoViewer, IMAGEDB.Main.ImageLibrary.PCTPRV_ICON, "Photo Viewer", "Preview your photo", True)

    End Sub

    Private Sub DgnPictureList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnPictureList.CellContentClick
        Dim varSendergrid = DirectCast(sender, dgn)

        If TypeOf varSendergrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            If Decision(My.Application.Info.AssemblyName, "Do you want to remove selected photo?", LibApp.Ingrid.Global.PopupType.Question, "", frmDialogBox.MessageIcon.Question, frmDialogBox.MessageTypes.YesNo) = DialogResult.Yes Then
                If DgnPictureList.CurrentRow.Cells("photo_status").Value IsNot "Add" Then
                    varExtendedQuery += String.Format("delete from db_universe_erp_file.dbo.sto_file where [file_id] = '{0}';", DgnPictureList.CurrentRow.Cells("photo_id").Value)
                End If

                DgnPictureList.Rows.Remove(DgnPictureList.SelectedRows(0))

                If DgnPictureList.RowCount = 0 Then
                    PctbxPhoto.Image = Nothing
                End If
            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DgnPictureListSlf_Selected() Handles DgnPictureList.XOSelected
        If DgnPictureList.RowCount <> 0 Then
            If DgnPictureList.CurrentRow.Cells("photo_status").Value.ToString Is "Add" Then
                PctbxPhoto.Image = CType(DgnPictureList.CurrentRow.Cells("photo_content").Value, Image)
            Else
                'Dim string64 As String
                'string64 = DgnPictureList.CurrentRow.Cells("photo_content").Value.ToString
                '_PhotoByte = Convert.FromBase64String(string64)

                varPhotoByte = CType(DgnPictureList.CurrentRow.Cells("photo_content").Value, Byte())

                Dim varPhotoStream = New System.IO.MemoryStream(varPhotoByte)
                PctbxPhoto.Image = System.Drawing.Image.FromStream(varPhotoStream)
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
            Decision(My.Application.Info.AssemblyName, "Plase pick your file first.", LibApp.Ingrid.Global.PopupType.NoFileSelected, "", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf Not (CMCv.OperatingSystem.File.Info.IsExists(TxtFilePath.Text)) Then
            Decision(My.Application.Info.AssemblyName, "Your file cannot be found.", LibApp.Ingrid.Global.PopupType.FileNotFound, "", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        Frm_dar_SinglePDFViewer = New DAR_SinglePDFViewer(TxtFilePath.Text, "", False)
        Display(Frm_dar_SinglePDFViewer, IMAGEDB.Main.ImageLibrary.PDFPRV_ICON, "PDF Viewer", "Preview your file", True)
    End Sub

    Private Sub BtnAddFile_Click(sender As Object, e As EventArgs) Handles BtnAddFile.Click
        Try
            If TxtFilePath.Text.Trim = String.Empty Then
                Decision(My.Application.Info.AssemblyName, "Plase pick your PDF file first.", LibApp.Ingrid.Global.PopupType.NoFileSelected, "", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
                Return
            ElseIf Not (CMCv.OperatingSystem.File.Info.IsExists(TxtFilePath.Text)) Then
                Decision(My.Application.Info.AssemblyName, "Your file cannot be found.", LibApp.Ingrid.Global.PopupType.FileNotFound, "", frmDialogBox.MessageIcon.Error, frmDialogBox.MessageTypes.OkOnly)
                Return
            ElseIf Not (CMCv.OperatingSystem.File.Upload.IsAllowedSize(TxtFilePath.Text, varMaxUploadSizePDF, True)) Then
                Return
            End If

            Dim varRow As Object() = Nothing
            Dim varDate As Date = Now
            'Dim _PDFFile As Object = New IO.FileStream(TxtFilePath.Text, FileMode.Open, FileAccess.Read) 'System.Drawing.Image.FromFile(TxtPhotoPath.Text)

            varRow = New Object() {CMCv.Security.Encrypt.MD5(), IO.Path.GetFileNameWithoutExtension(TxtFilePath.Text), CboFileTag.Text, varDate, TxtFilePath.Text, "Add", varProperties.EmployeeID}

            With DgnFileList.Rows
                .Add(varRow)
            End With

            TxtFilePath.Text = String.Empty
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DgnFileList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnFileList.CellContentClick
        Dim varSendergrid = DirectCast(sender, dgn)

        If TypeOf varSendergrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            If Decision(My.Application.Info.AssemblyName, "Do you want to remove selected file?", LibApp.Ingrid.Global.PopupType.Question, "", frmDialogBox.MessageIcon.Question, frmDialogBox.MessageTypes.YesNo) = DialogResult.Yes Then
                If DgnFileList.CurrentRow.Cells("file_status").Value IsNot "Add" Then
                    varExtendedQuery += String.Format("delete from db_universe_erp_file.dbo.sto_file where [file_id] = '{0}';", DgnFileList.CurrentRow.Cells("file_id").Value)
                End If
                DgnFileList.Rows.Remove(DgnFileList.SelectedRows(0))

            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub CommmsMenu_EventFileSave() Handles Com_mms_Menu.EventFileSave
        Call Save()
    End Sub

    Private Sub CommmsMenu_EventFileCancel() Handles Com_mms_Menu.EventFileCancel
        Me.Close()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub CommmsMenu_EventFileUndoAll() Handles Com_mms_Menu.EventFileUndoAll
        If Decision(My.Application.Info.AssemblyName, "Do you want to undo all changes?", LibApp.Ingrid.Global.PopupType.Question, "", frmDialogBox.MessageIcon.Question, frmDialogBox.MessageTypes.YesNo) = DialogResult.Yes Then
            If (varFormProperties.IsNew) Then
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
