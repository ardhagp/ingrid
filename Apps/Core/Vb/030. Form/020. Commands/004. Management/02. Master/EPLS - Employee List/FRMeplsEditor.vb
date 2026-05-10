Imports System.Runtime.Versioning
Imports Microsoft.CodeAnalysis.VisualBasic.Syntax

Namespace UI
    Public Class FRMeplsEditor
#Region "Declaration"
        Public Event EventRecordSaved()

        Private WithEvents Frm_epls_AddinPosition As New FRMeplsPosition
        Private varHavePhoto As Integer
        Private varChangePhoto As Boolean
        Private varPhoto As System.Drawing.Image

        Private Const pEmployeePersonalIdNumber As String = "@pEmployeePersonalIdNumber"
        Private Const pEmployeeFullName As String = "@pEmployeeFullName"
        Private Const pEmployeeBirthPlace As String = "@pEmployeeBirthPlace"
        Private Const pEmployeeGender As String = "@pEmployeeGender"
        Private Const pEmployeeAddress As String = "@pEmployeeAddress"
        Private Const pEmployeeNumber As String = "@EmployeeNumber"
        Private Const pEmployeeNickname As String = "@EmployeeNickname"
        Private Const pPositionId As String = "@PositionId"
        Private Const pEmploymentTypeId As String = "@EmploymentTypeId"

        Private Const varMessageCannotSave As String = "Cannot save your record."
#End Region

#Region "Subs Collections"

#End Region

        <SupportedOSPlatform("windows")>
        Private Sub FRMeplsEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            varHavePhoto = 0
            varChangePhoto = False
            If varDataProperties.EmployeeIsNew Then
                ChkAddNew.Visible = True
                ChkAddNew.Enabled = True
                CboGender.SelectedIndex = 0

                With varDataProperties.AllParameters
                    .Remove(pPositionId)
                    .Add(pPositionId, DBNull.Value)

                End With
            Else
                ChkAddNew.Visible = False
                ChkAddNew.Checked = False

                CMDepls.Editor.GetEmployeeProperties(varDataProperties, varDatasetIngrid)

                With varDatasetIngrid.Tables("EPLS_Editor").Rows(0)
                    'Displaying Employee Detail
                    TxtPersonalID.Text = .Item("employee_personalidnumber").ToString
                    TxtFullName.Text = .Item("employee_fullname").ToString
                    CboGender.SelectedItem = .Item("employee_gender").ToString
                    DtpBirthDate.Value = If(IsDBNull(.Item("employee_birthdate")) OrElse .Item("employee_birthdate") Is Nothing, Date.Today, CDate(.Item("employee_birthdate")))
                    TxtBirthPlace.Text = .Item("employee_birthplace").ToString
                    TxtAddress.Text = .Item("employee_address").ToString

                    'Displaying Employment Detail
                    TxtCompany.Text = .Item("company_name").ToString
                    TxTDepartment.Text = .Item("department_name").ToString
                    varDataProperties.AllParameters.Remove(pPositionId)
                    varDataProperties.AllParameters.Add(pPositionId, CLng(.Item("position_id")))
                    TxtPosition.Text = .Item("position_name").ToString
                    varDataProperties.AllParameters.Remove(pEmploymentTypeId)
                    varDataProperties.AllParameters.Add(pEmploymentTypeId, IIf(.Item("employee_employmenttype") Is Nothing OrElse .Item("employee_employmenttype").ToString = String.Empty OrElse .Item("employee_employmenttype").ToString = "", DBNull.Value, .Item("employee_employmenttype")))
                    TxtEmployeeNumber.Text = .Item("employee_number").ToString
                    TxtEmployeeNickname.Text = .Item("employee_nickname").ToString
                    ChkActiveEmployee.Checked = CBool(.Item("employee_isactive"))
                    'varHavePhoto = CMDepls.Editor.GetIsHavePhoto(varDataProperties, Convert.ToString(varDataProperties.EmployeeId))
                End With


                'Permissions
                'TxtLogin.Text = CMDuac.Editor.GetUsernameByEmployeeID(varDataProperties, Convert.ToString(varDataProperties.EmployeeId))
                'varDataProperties.Field01 = CMDuac.Editor.GetUIDbyEmployeeID(varDataProperties, Convert.ToString(varDataProperties.EmployeeId))
                'CMDuac.Editor.DisplayData(varDataProperties, DgnModulesRoles, varDataProperties.Field01.ToString)

                TxtPersonalID.Focus()

                If varHavePhoto > 0 Then
                    pctbxPhoto.Image = CMDepls.Editor.GetPhoto(varDataProperties, Convert.ToString(varDataProperties.EmployeeId))
                End If
            End If

        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnBrowsePosition_Click(sender As Object, e As EventArgs) Handles BtnBrowsePosition.Click
            Frm_epls_AddinPosition = New FRMeplsPosition
            Display(Frm_epls_AddinPosition, IMAGEDB.Main.ImageLibrary.SEARCH_ICON, My.Application.Info.AssemblyName.ToUpper, "Find Position", "Browse for position data", True)
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

            If Not CheckEmployeePersonalID() Then
                Return
            End If

            If Not CheckEmployeeMandatoryFields() Then
                Return
            End If

            If Not CheckDuplicateEmployeeNumber() Then
                Return
            End If

            If Not CheckEmployeePhoto() Then
                Return
            End If

            With varDataProperties
                .AllParameters.Remove(pEmployeePersonalIdNumber)
                .AllParameters.Add(pEmployeePersonalIdNumber, IIf(TxtPersonalID.XOSQLText = String.Empty OrElse TxtPersonalID.XOSQLText = "", DBNull.Value, TxtPersonalID.XOSQLText))
                .AllParameters.Remove(pEmployeeFullName)
                .AllParameters.Add(pEmployeeFullName, IIf(TxtFullName.XOSQLText = String.Empty OrElse TxtFullName.XOSQLText = "", DBNull.Value, TxtFullName.XOSQLText))
                .AllParameters.Remove(pEmployeeBirthPlace)
                .AllParameters.Add(pEmployeeBirthPlace, IIf(TxtBirthPlace.XOSQLText = String.Empty OrElse TxtBirthPlace.XOSQLText = "", DBNull.Value, TxtBirthPlace.XOSQLText))
                .AllParameters.Remove(pEmployeeGender)
                .AllParameters.Add(pEmployeeGender, IIf(CboGender.SelectedItem Is Nothing OrElse CboGender.SelectedItem.ToString = String.Empty, DBNull.Value, CboGender.SelectedItem.ToString))
                .AllParameters.Remove(pEmployeeAddress)
                .AllParameters.Add(pEmployeeAddress, IIf(TxtAddress.XOSQLText = String.Empty OrElse TxtAddress.XOSQLText = "", DBNull.Value, TxtAddress.XOSQLText))
                .AllParameters.Remove(pEmployeeNickname)
                .AllParameters.Add(pEmployeeNickname, IIf(TxtEmployeeNickname.XOSQLText = String.Empty OrElse TxtEmployeeNickname.XOSQLText = "", DBNull.Value, TxtEmployeeNickname.XOSQLText))
            End With

            If CMDepls.Editor.PushData(varDataProperties) Then
                UI.FRMmainframe6.Ts_status.Text = "Success"
                RaiseEvent EventRecordSaved()
            Else
                UI.FRMmainframe6.Ts_status.Text = "Failed to save"
                Return
            End If

            If ChkAddNew.Checked Then
                TxtCompany.Clear()
                TxTDepartment.Clear()
                TxtPosition.Clear()
                TxtEmploymentType.Clear()
                TxtEmployeeNumber.Clear()
                TxtFullName.Clear()
                TxtEmployeeNickname.Clear()
            Else
                Me.Close()
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Function CheckEmployeePersonalID() As Boolean
            If CMDepls.Editor.IsPersonalIdExist(varDataProperties) Then
                Return False
            End If
            Return True
        End Function

        <SupportedOSPlatform("windows")>
        Private Function CheckEmployeeMandatoryFields() As Boolean
            If (TxtPersonalID.XOSQLText = String.Empty OrElse IsDBNull(varDataProperties.AllParameters(pPositionId)) OrElse varDataProperties.AllParameters(pPositionId) Is Nothing OrElse (TxtEmployeeNumber.XOSQLText = String.Empty) OrElse (TxtFullName.XOSQLText = String.Empty)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, varMessageCannotSave & Environment.NewLine & "Ensure that the Personal ID, Full Name, Company, Department, Position and Employee Number fields are correctly completed.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return False
            End If
            Return True
        End Function

        <SupportedOSPlatform("windows")>
        Private Function CheckDuplicateEmployeeNumber() As Boolean
            If varDataProperties.EmployeeIsNew AndAlso CMDepls.Editor.IsEmployeeNumberDuplicate(varDataProperties) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, varMessageCannotSave & Environment.NewLine & "This Employee Number is already registered.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return False
            End If
            Return True
        End Function

        Private Function CheckEmployeePhoto() As Boolean
            If varHavePhoto = 0 Then
                Decision(My.Application.Info.AssemblyName.ToUpper, varMessageCannotSave & Environment.NewLine & "Please pick employee photo.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return False
            End If
            Return True
        End Function

        <SupportedOSPlatform("windows")>
        Private Sub FRMeplsAddinPosition_RecordSelected() Handles Frm_epls_AddinPosition.EventRecordSelected
            With varDataProperties
                TxtCompany.Text = .Field01.ToString
                TxTDepartment.Text = .Field02.ToString
                TxtPosition.Text = .Field04.ToString
            End With
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnBrowsePhoto_Click(sender As Object, e As EventArgs) Handles BtnBrowsePhoto.Click
            OfdPhoto.Title = "Ingrid Photo Picker"
            OfdPhoto.FileName = ""
            OfdPhoto.Filter = "Photo File|*.Jpg;*.Jpeg"

            If OfdPhoto.ShowDialog = DialogResult.OK Then
                If (CMCv.OperatingSystem.File.Upload.IsAllowedSize(OfdPhoto.FileName, varMaxUploadSizePhoto, True)) Then
                    varPhoto = CMCv.ImageEditor.Proccessor.Compress.OutputAsImage(OfdPhoto.FileName)
                    pctbxPhoto.Image = varPhoto
                    varChangePhoto = True
                    varHavePhoto = 1
                End If
            Else
                varHavePhoto = 1
                Return
            End If

        End Sub

        Private Sub CboGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboGender.SelectedIndexChanged
            If varHavePhoto = 0 Then
                If CboGender.Text = "MALE" Then
                    pctbxPhoto.Image = My.Resources.MALE_001_512_icon
                Else
                    pctbxPhoto.Image = My.Resources.FEMALE_001_512_icon
                End If
            End If
        End Sub


    End Class
End Namespace