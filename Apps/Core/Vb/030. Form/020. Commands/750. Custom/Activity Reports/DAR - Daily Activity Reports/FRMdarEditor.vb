Imports System.Data
Imports System.Runtime.Versioning
Imports System.Text

Namespace UI
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

        Private Const varMessageTablesPhotoFileEditor As String = "TPhotoFileEditor"
        Private Const varMessageTableFileEditor As String = "TFileEditor"

        Private Const pCustomAffectedAreaId As String = "@CustomAffectedAreaId"
        Private Const pCustomTemplateId As String = "@CustomTemplateId"
        Private Const pCustomActivityDateStart As String = "@CustomActivityDateStart"
        Private Const pCustomActivityDateEnd As String = "@CustomActivityDateEnd"
        Private Const pCustomActivityTimeStart As String = "@CustomActivityTimeStart"
        Private Const pCustomActivityTimeEnd As String = "@CustomActivityTimeEnd"
        Private Const pCustomActivityContent As String = "@CustomActivityContent"
        Private Const pCustomActivityFeedback As String = "@CustomActivityFeedback"
#End Region

#Region "Sub Collections"
        <SupportedOSPlatform("windows")>
        Private Sub GetAffectedArea()
            CMDdar.Editor.GetAffectedArea(varDataProperties, CboArea)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub GetTemplateTitle()
            CMDdar.Editor.GetTemplateTitle(varDataProperties, CboTemplate)
        End Sub

        <SupportedOSPlatform("windows")>
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

            varDataSet(0) = CMDdar.Editor.DisplayPhotoGrid(varDataProperties, Convert.ToString(varDataProperties.CustomDailyActivityId).ToString, DgnPictureList)

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
            varDataSet(1) = CMDdar.Editor.DisplayFileGrid(varDataProperties, Convert.ToString(varDataProperties.CustomDailyActivityId).ToString, DgnFileList)

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

            If (varDataProperties.CustomDailyActivityIsNew) Then
                varDataProperties.CustomDailyActivityId = CMCv.Security.Encrypt.MD5()
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
            If Not (varDataProperties.CustomDailyActivityIsNew) Then
                If Decision(My.Application.Info.AssemblyName.ToUpper, "Do you want to replace Description with template content?", LibApp.Ingrid.Global.PopupType.Question, "", cmcv.ui.canvas.FRMdialogbox.MessageIcon.Question, cmcv.ui.canvas.FRMdialogbox.MessageTypes.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                    TxtContent.Text = CMDdar.Editor.GetTemplateContent(varDataProperties, CboTemplate)
                End If
            Else
                TxtContent.Text = CMDdar.Editor.GetTemplateContent(varDataProperties, CboTemplate)
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            Call Save()
        End Sub

        <SupportedOSPlatform("windows")>
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
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "Make sure you have Start Time, End Time, Area Affected, Activity Template selected and Description are properly filled.", LibApp.Ingrid.Global.PopupType.Alert, "", cmcv.ui.canvas.FRMdialogbox.MessageIcon.Alert, cmcv.ui.canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            varActivityStartString = Format(DtpStart.Value, "yyyy-mm-dd") & " " & MebStart.Text.Replace(".", ":")
            varActivityEndString = Format(DtpEnd.Value, "yyyy-mm-dd") & " " & MebEnd.Text.Replace(".", ":")
            varActivityStartDate = CDate(varActivityStartString)
            varActivityEndDate = CDate(varActivityEndString)

            If (varActivityStartDate > varActivityEndDate) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "Start Time should be less than End Time.", LibApp.Ingrid.Global.PopupType.Alert, "", cmcv.ui.canvas.FRMdialogbox.MessageIcon.Alert, cmcv.ui.canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            With varDataProperties
                .AllParameters.Remove(pCustomAffectedAreaId)
                .AllParameters.Add(pCustomAffectedAreaId, CboArea.SelectedValue)
                .AllParameters.Remove(pCustomTemplateId)
                .AllParameters.Add(pCustomTemplateId, CboTemplate.SelectedValue)
                .AllParameters.Remove(pCustomActivityDateStart)
                .AllParameters.Add(pCustomActivityDateStart, Format(DtpStart.Value, "yyyy-mm-dd"))
                .AllParameters.Remove(pCustomActivityTimeStart)
                .AllParameters.Add(pCustomActivityTimeStart, MebStart.Text.Replace(".", ":"))
                .AllParameters.Remove(pCustomActivityTimeEnd)
                .AllParameters.Add(pCustomActivityTimeEnd, MebEnd.Text.Replace(".", ":"))
                .AllParameters.Remove(pCustomActivityContent)
                .AllParameters.Add(pCustomActivityContent, TxtContent.XOSqlText)
                .AllParameters.Remove(pCustomActivityFeedback)
                .AllParameters.Add(pCustomActivityFeedback, TxtFeedback.XOSqlText)
            End With

            If (CMDdar.Editor.PushData(varDataProperties, varExtendedQuery)) Then
                varExtendedQuery = String.Empty
                UI.FRMmainframe6.Ts_status.Text = "Success"

                Dim varNewPhotoAdded As Integer = 0
                For Each eachrow As DataGridViewRow In DgnPictureList.Rows
                    If eachrow.Cells("photo_status").Value.ToString Is "Add" Then
                        varNewPhotoAdded += 1
                    End If
                Next

                If varNewPhotoAdded > 0 Then
                    If (CMDdar.Editor.PushPhoto(varDataProperties, DgnPictureList, Convert.ToString(varDataProperties.CustomDailyActivityId).ToString, varDataProperties.CustomDailyActivityIsNew, DtpStart.Value)) Then
                        UI.FRMmainframe6.Ts_status.Text = "Success + All pictures has been added"
                    Else
                        UI.FRMmainframe6.Ts_status.Text = "Success + With errors while adding pictures"
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
                    If (CMDdar.Editor.PushFile(varDataProperties, DgnFileList, Convert.ToString(varDataProperties.CustomDailyActivityId).ToString, varDataProperties.CustomDailyActivityIsNew, DtpStart.Value)) Then
                        UI.FRMmainframe6.Ts_status.Text = "Success + All file has been added"
                    Else
                        UI.FRMmainframe6.Ts_status.Text = "Success + With errors while adding files"
                    End If

                    DgnFileList.Rows.Clear()
                    PctbxPhoto.Image = Nothing
                End If
                RaiseEvent EventRecordSaved()
            Else
                UI.FRMmainframe6.Ts_status.Text = "Failed to save"
                Return
            End If

            TxtContent.Text = String.Empty

            If Not (ChkAddNew.Checked) Then
                Me.Close()
            Else
                varDataProperties.CustomDailyActivityId = CMCv.Security.Encrypt.MD5()
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub LoadData()
            CMDdar.Editor.GetRowValue(varDataProperties, Convert.ToString(varDataProperties.CustomDailyActivityId).ToString, DtpStart, MebStart, DtpEnd, MebEnd, CboArea, CboTemplate, TxtContent, TxtFeedback)
            Call LoadAttachment()
        End Sub
#End Region

        <SupportedOSPlatform("windows")>
        Private Sub CboTemplate_KeyDown(sender As Object, e As KeyEventArgs) Handles CboTemplate.KeyDown
            If e.KeyCode = Keys.Enter Then
                If Not (varDataProperties.CustomDailyActivityIsNew) Then
                    If Decision(My.Application.Info.AssemblyName.ToUpper, "Do you want to replace Description with template content?", LibApp.Ingrid.Global.PopupType.Question, "", cmcv.ui.canvas.FRMdialogbox.MessageIcon.Question, cmcv.ui.canvas.FRMdialogbox.MessageTypes.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                        TxtContent.Text = CMDdar.Editor.GetTemplateContent(varDataProperties, CboTemplate)
                    End If
                Else
                    TxtContent.Text = CMDdar.Editor.GetTemplateContent(varDataProperties, CboTemplate)
                End If
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub DtpStart_ValueChanged(sender As Object, e As EventArgs) Handles DtpStart.ValueChanged
            DtpEnd.MinDate = DtpStart.Value
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub DtpEnd_ValueChanged(sender As Object, e As EventArgs) Handles DtpEnd.ValueChanged
            DtpStart.MaxDate = DtpEnd.Value
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnAddPhoto_Click(sender As Object, e As EventArgs) Handles BtnAddPhoto.Click
            Try
                If TxtPhotoPath.Text.Trim = String.Empty Then
                    Decision(My.Application.Info.AssemblyName.ToUpper, "Plase pick your photo first.", LibApp.Ingrid.Global.PopupType.NoFileSelected, "", cmcv.ui.canvas.FRMdialogbox.MessageIcon.Error, cmcv.ui.canvas.FRMdialogbox.MessageTypes.OkOnly)
                    Return
                ElseIf Not CMCv.OperatingSystem.File.Info.IsExists(TxtPhotoPath.Text) Then
                    Decision(My.Application.Info.AssemblyName.ToUpper, "Your photo cannot be found.", LibApp.Ingrid.Global.PopupType.FileNotFound, "", cmcv.ui.canvas.FRMdialogbox.MessageIcon.Error, cmcv.ui.canvas.FRMdialogbox.MessageTypes.OkOnly)
                    Return
                ElseIf Not (CMCv.OperatingSystem.File.Upload.IsAllowedSize(TxtPhotoPath.Text, varMaxUploadSizePhoto, True)) Then
                    Return
                End If

                Dim varRow As Object() = Nothing
                Dim varDate As Date = Now
                Dim varPhoto As System.Drawing.Image = CMCv.ImageEditor.Proccessor.Compress.OutputAsImage(TxtPhotoPath.Text) 'System.Drawing.Image.FromFile(TxtPhotoPath.Text)

                varRow = New Object() {CMCv.Security.Encrypt.MD5(), IO.Path.GetFileNameWithoutExtension(TxtPhotoPath.Text), varDate, varPhoto, "Add", varDataProperties.EmployeeID}

                With DgnPictureList.Rows
                    .Add(varRow)
                End With

                TxtPhotoPath.Text = String.Empty
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
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
                Decision(My.Application.Info.AssemblyName.ToUpper, "Plase pick your photo first.", LibApp.Ingrid.Global.PopupType.NoFileSelected, "", cmcv.ui.canvas.FRMdialogbox.MessageIcon.Error, cmcv.ui.canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf Not CMCv.OperatingSystem.File.Info.IsExists(TxtPhotoPath.Text) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Your photo cannot be found.", LibApp.Ingrid.Global.PopupType.FileNotFound, "", cmcv.ui.canvas.FRMdialogbox.MessageIcon.Error, cmcv.ui.canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            Frm_dar_SinglePhotoViewer = New DAR_SinglePhotoViewer(TxtPhotoPath.Text)
            Display(Frm_dar_SinglePhotoViewer, IMAGEDB.Main.ImageLibrary.PCTPRV_ICON, My.Application.Info.AssemblyName.ToUpper, "Photo Viewer", "Preview your photo", True)

        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub DgnPictureList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnPictureList.CellContentClick
            Dim varSendergrid = DirectCast(sender, CMCv.UI.Control.dgn)

            If TypeOf varSendergrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 AndAlso Decision(My.Application.Info.AssemblyName.ToUpper, "Do you want to remove selected photo?", LibApp.Ingrid.Global.PopupType.Delete, "", cmcv.ui.canvas.FRMdialogbox.MessageIcon.Question, cmcv.ui.canvas.FRMdialogbox.MessageTypes.YesNo) = DialogResult.Yes Then
                If DgnPictureList.CurrentRow.Cells("photo_status").Value IsNot "Add" Then
                    varExtendedQuery += String.Format("delete from db_universe_erp_file.dbo.sto_file where [file_id] = '{0}';", DgnPictureList.CurrentRow.Cells("photo_id").Value)
                End If

                DgnPictureList.Rows.Remove(DgnPictureList.SelectedRows(0))

                If DgnPictureList.RowCount = 0 Then
                    PctbxPhoto.Image = Nothing
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

        <SupportedOSPlatform("windows")>
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
                Decision(My.Application.Info.AssemblyName.ToUpper, "Plase pick your file first.", LibApp.Ingrid.Global.PopupType.NoFileSelected, "", cmcv.ui.canvas.FRMdialogbox.MessageIcon.Error, cmcv.ui.canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf Not (CMCv.OperatingSystem.File.Info.IsExists(TxtFilePath.Text)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Your file cannot be found.", LibApp.Ingrid.Global.PopupType.FileNotFound, "", cmcv.ui.canvas.FRMdialogbox.MessageIcon.Error, cmcv.ui.canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            Frm_dar_SinglePDFViewer = New DAR_SinglePDFViewer(TxtFilePath.Text, "", False)
            Display(Frm_dar_SinglePDFViewer, IMAGEDB.Main.ImageLibrary.PDFPRV_ICON, My.Application.Info.AssemblyName.ToUpper, "PDF Viewer", "Preview your file", True)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnAddFile_Click(sender As Object, e As EventArgs) Handles BtnAddFile.Click
            Try
                If TxtFilePath.Text.Trim = String.Empty Then
                    Decision(My.Application.Info.AssemblyName.ToUpper, "Plase pick your PDF file first.", LibApp.Ingrid.Global.PopupType.NoFileSelected, "", cmcv.ui.canvas.FRMdialogbox.MessageIcon.Error, cmcv.ui.canvas.FRMdialogbox.MessageTypes.OkOnly)
                    Return
                ElseIf Not (CMCv.OperatingSystem.File.Info.IsExists(TxtFilePath.Text)) Then
                    Decision(My.Application.Info.AssemblyName.ToUpper, "Your file cannot be found.", LibApp.Ingrid.Global.PopupType.FileNotFound, "", cmcv.ui.canvas.FRMdialogbox.MessageIcon.Error, cmcv.ui.canvas.FRMdialogbox.MessageTypes.OkOnly)
                    Return
                ElseIf Not (CMCv.OperatingSystem.File.Upload.IsAllowedSize(TxtFilePath.Text, varMaxUploadSizePDF, True)) Then
                    Return
                End If

                Dim varRow As Object() = Nothing
                Dim varDate As Date = Now
                'Dim _PDFFile As Object = New IO.FileStream(TxtFilePath.Text, FileMode.Open, FileAccess.Read) 'System.Drawing.Image.FromFile(TxtPhotoPath.Text)

                varRow = New Object() {CMCv.Security.Encrypt.MD5(), IO.Path.GetFileNameWithoutExtension(TxtFilePath.Text), CboFileTag.Text, varDate, TxtFilePath.Text, "Add", varDataProperties.EmployeeID}

                With DgnFileList.Rows
                    .Add(varRow)
                End With

                TxtFilePath.Text = String.Empty
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub DgnFileList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgnFileList.CellContentClick
            Dim varSendergrid = DirectCast(sender, CMCv.UI.Control.dgn)

            If TypeOf varSendergrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 AndAlso Decision(My.Application.Info.AssemblyName.ToUpper, "Do you want to remove selected file?", LibApp.Ingrid.Global.PopupType.Question, "", cmcv.ui.canvas.FRMdialogbox.MessageIcon.Question, cmcv.ui.canvas.FRMdialogbox.MessageTypes.YesNo) = DialogResult.Yes Then
                If DgnFileList.CurrentRow.Cells("file_status").Value IsNot "Add" Then
                    varExtendedQuery += String.Format("delete from db_universe_erp_file.dbo.sto_file where [file_id] = '{0}';", DgnFileList.CurrentRow.Cells("file_id").Value)
                End If
                DgnFileList.Rows.Remove(DgnFileList.SelectedRows(0))

            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub CommmsMenu_EventFileSave() Handles Com_mms_Menu.EventFileSave
            Call Save()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub CommmsMenu_EventFileCancel() Handles Com_mms_Menu.EventFileCancel
            Me.Close()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub CommmsMenu_EventFileUndoAll() Handles Com_mms_Menu.EventFileUndoAll
            If Decision(My.Application.Info.AssemblyName.ToUpper, "Do you want to undo all changes?", LibApp.Ingrid.Global.PopupType.Question, "", cmcv.ui.canvas.FRMdialogbox.MessageIcon.Question, cmcv.ui.canvas.FRMdialogbox.MessageTypes.YesNo) = DialogResult.Yes Then
                If (varDataProperties.CustomDailyActivityIsNew) Then
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
End Namespace