Imports System.Runtime.Versioning
Imports CMCv

Public Class EPLS_Editor
#Region "Variables"
    Private _SQL As New Commands.EPLS.Editor
    Private _SQL_User As New Commands.UAC.Editor
    Public Event RecordSaved()
#End Region

#Region "Subs Collections"

#End Region
    Private WithEvents F_AddinPosition As New EPLS_Position
    Private _HavePhoto As Integer
    Private _ChangePhoto As Boolean
    Private _PositionID As String
    Private _Photo As System.Drawing.Image

    <SupportedOSPlatform("windows")>
    Private Sub EPLS_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _HavePhoto = 0
        _ChangePhoto = False
        If (varFormAttributes.IsNew) Then
            ChkAddNew.Visible = True
            ChkAddNew.Enabled = True
            CboGender.SelectedIndex = 0
        Else
            ChkAddNew.Visible = False
            ChkAddNew.Checked = False

            'Personal Detail
            TxtFullName.Text = Commands.EPLS.Editor.GETEmployeeFullName(V_DatabaseEngine, varFormAttributes.RowID)
            CboGender.SelectedItem = Commands.EPLS.Editor.GETGender(V_DatabaseEngine, varFormAttributes.RowID)
            TxtPersonalID.Text = Commands.EPLS.Editor.GETPersonalID(V_DatabaseEngine, varFormAttributes.RowID)
            DtpBirthDate.Value = CDate(Commands.EPLS.Editor.GETBirthDate(V_DatabaseEngine, varFormAttributes.RowID))
            TxtBirthPlace.Text = Commands.EPLS.Editor.GETBirthPlace(V_DatabaseEngine, varFormAttributes.RowID)
            TxtAddress.Text = Commands.EPLS.Editor.GETAddress(V_DatabaseEngine, varFormAttributes.RowID)

            'Work In...
            TxtCompany.Text = Commands.EPLS.Editor.GETCompany(V_DatabaseEngine, varFormAttributes.RowID)
            TxTDepartment.Text = Commands.EPLS.Editor.GETDepartment(V_DatabaseEngine, varFormAttributes.RowID)
            _PositionID = Commands.EPLS.Editor.GETPositionID(V_DatabaseEngine, varFormAttributes.RowID)
            TxtPosition.Text = Commands.EPLS.Editor.GETPosition(V_DatabaseEngine, varFormAttributes.RowID)
            TxtGradeID.Text = Commands.EPLS.Editor.GETGradeID(V_DatabaseEngine, varFormAttributes.RowID)
            TxtGrade.Text = Commands.EPLS.Editor.GETGrade(V_DatabaseEngine, varFormAttributes.RowID)
            TxtEmployeeNumber.Text = Commands.EPLS.Editor.GETEmployeeNumber(V_DatabaseEngine, varFormAttributes.RowID)
            TxtEmployeeNickname.Text = Commands.EPLS.Editor.GETEmployeeNickname(V_DatabaseEngine, varFormAttributes.RowID)
            TxtContractTypeID.Text = Commands.EPLS.Editor.GETContractTypeID(V_DatabaseEngine, varFormAttributes.RowID)
            TxtContractType.Text = Commands.EPLS.Editor.GETContractType(V_DatabaseEngine, varFormAttributes.RowID)
            ChkActiveEmployee.Checked = Commands.EPLS.Editor.GETActiveEmployee(V_DatabaseEngine, varFormAttributes.RowID)
            _HavePhoto = Commands.EPLS.Editor.GETIsHavePhoto(V_DatabaseEngine, varFormAttributes.RowID)

            'Permissions
            TxtLogin.Text = Commands.UAC.Editor.GETUsernameByEmployeeID(V_DatabaseEngine, varFormAttributes.RowID)
            varFormAttributes.Field01 = Commands.UAC.Editor.GETUIDByEmployeeID(V_DatabaseEngine, varFormAttributes.RowID)
            Commands.UAC.Editor.DisplayData(V_DatabaseEngine, DgnModulesRoles, varFormAttributes.Field01.ToString)

            TxtPersonalID.Focus()

            If _HavePhoto > 0 Then
                pctbxPhoto.Image = _SQL.GETPhoto(V_DatabaseEngine, varFormAttributes.RowID)
            End If
        End If

    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnBrowsePosition_Click(sender As Object, e As EventArgs) Handles BtnBrowsePosition.Click
        F_AddinPosition = New EPLS_Position
        DISPLAY(F_AddinPosition, IMAGEDB.Main.ImageLibrary.SEARCH_ICON, "Find Position", "Browse for position data", True)
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Public Sub CheckAllInputs()
        'TxtPersonalID.Focus()
        TxtEmployeeNumber.Focus()
        TxtFullName.Focus()
        TxtEmployeeNickname.Focus()
        ChkActiveEmployee.Focus()
        BtnSave.Focus()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call CheckAllInputs()

        If (Commands.EPLS.Editor.IsPersonalIDExist(V_DatabaseEngine, varFormAttributes.IsNew, TxtPersonalID.Text, varFormAttributes.RowID)) Then
            Decision("Cannot save your record." & Environment.NewLine & "Duplicate Personal ID", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf (TxtPersonalID.XOSQLText = String.Empty) OrElse (_PositionID = String.Empty) OrElse (TxtEmployeeNumber.XOSQLText = String.Empty) OrElse (TxtFullName.XOSQLText = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have Personal ID, Company, Department, Postition, Employee Number and Full Name are properly filled.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf Not (Commands.EPLS.Editor.IsPositionExist(V_DatabaseEngine, _PositionID)) Then
            Decision("Cannot save your record." & Environment.NewLine & "Position not found.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            SLFStatus.Items(0).Text = "Position not found"
            Return
        ElseIf (varFormAttributes.IsNew) AndAlso (Commands.EPLS.Editor.IsDuplicate(V_DatabaseEngine, _PositionID, TxtEmployeeNumber.XOSQLText)) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Employee Number already used.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf Not (varFormAttributes.IsNew) AndAlso (Commands.EPLS.Editor.IsDuplicate(V_DatabaseEngine, _PositionID, TxtEmployeeNumber.XOSQLText, varFormAttributes.RowID)) Then
            Decision("Cannot save your record." & Environment.NewLine & "This Employee Number already used by another employee.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        ElseIf _HavePhoto = 0 Then
            Decision("Cannot save your record." & Environment.NewLine & "Please pick employee photo.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        If (Commands.EPLS.Editor.PUSHData(V_DatabaseEngine, TxtPersonalID.XOSQLText, _PositionID, TxtEmployeeNumber.XOSQLText, TxtFullName.XOSQLText, DtpBirthDate, TxtBirthPlace.XOSQLText, TxtAddress.XOSQLText, TxtEmployeeNickname.XOSQLText, ChkActiveEmployee.Checked, CboGender.SelectedItem.ToString, _Photo, _ChangePhoto, varUserAttributes.EID, varFormAttributes.RowID)) Then
            Mainframe_n_6.Ts_status.Text = "Success"
            RaiseEvent RecordSaved()
        Else
            Mainframe_n_6.Ts_status.Text = "Failed to save"
            Return
        End If

        If (ChkAddNew.Checked) Then
            TxtCompany.Clear()
            TxTDepartment.Clear()
            _PositionID = String.Empty
            TxtPosition.Clear()
            TxtGradeID.Clear()
            TxtGrade.Clear()
            TxtEmployeeNumber.Clear()
            TxtFullName.Clear()
            TxtEmployeeNickname.Clear()
            TxtContractTypeID.Clear()
            TxtContractType.Clear()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub F_AddinPosition_RecordSelected() Handles F_AddinPosition.RecordSelected
        With varFormAttributes
            TxtCompany.Text = .Field01.ToString
            TxTDepartment.Text = .Field02.ToString
            _PositionID = .Field03.ToString
            TxtPosition.Text = .Field04.ToString
        End With
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnBrowsePhoto_Click(sender As Object, e As EventArgs) Handles BtnBrowsePhoto.Click
        OfdPhoto.Title = "Ingrid Photo Picker"
        OfdPhoto.FileName = ""
        OfdPhoto.Filter = "Photo File|*.Jpg;*.Jpeg"

        If OfdPhoto.ShowDialog = DialogResult.OK Then
            If (OperatingSystem.File.Upload.IsAllowedSize(OfdPhoto.FileName, V_MaxUploadSize_Photo, True)) Then
                _Photo = CMCv.ImageEditor.Proccessor.Compress.OutputAsImage(OfdPhoto.FileName)
                pctbxPhoto.Image = _Photo
                _ChangePhoto = True
                _HavePhoto = 1
            End If
        Else
            _HavePhoto = 1
            Return
        End If

    End Sub

    Private Sub CboGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboGender.SelectedIndexChanged
        If _HavePhoto = 0 Then
            If CboGender.Text = "MALE" Then
                pctbxPhoto.Image = My.Resources.MALE_001_512_icon
            Else
                pctbxPhoto.Image = My.Resources.FEMALE_001_512_icon
            End If
        End If
    End Sub

End Class
