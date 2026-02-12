Imports System.Runtime.Versioning

Public Class FRMfirstguide
    Private FirstRecord, EmploymentType1, EmploymentType2, EmploymentType3, EmploymentType4 As New LibApp.Ingrid.Global.Properties
    Private varStep As Integer

    <SupportedOSPlatform("windows")>
    Private Sub BtnProcess_Click(sender As Object, e As EventArgs) Handles Btn_Process.Click
        If varStep = 1 Then
            If Txt_Company.XOIsBlank OrElse Txt_Department.XOIsBlank OrElse Txt_Position.XOIsBlank OrElse Txt_EmployeeName.XOIsBlank OrElse Txt_EmployeeID.XOIsBlank Then
                Decision(My.Application.Info.AssemblyName, "Field(s) cannot be empty", LibApp.Ingrid.Global.PopupType.Alert, "", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
                If (Txt_Company.XOIsBlank) Then
                    Txt_Company.Focus()
                ElseIf (Txt_Department.XOIsBlank) Then
                    Txt_Department.Focus()
                ElseIf (Txt_Position.XOIsBlank) Then
                    Txt_Position.Focus()
                ElseIf (Txt_EmployeeName.XOIsBlank) Then
                    Txt_EmployeeName.Focus()
                Else
                    Txt_EmployeeID.Focus()
                End If
                Return
            End If
            'FirstRecord.CompanyID = CMCv.Security.Encrypt.MD5(Txt_Company.Text.ToUpper)
            'FirstRecord.CompanyName = Txt_Company.Text.ToUpper
            'FirstRecord.CompanyCode = CMCv.Security.Encrypt.CRC32(Txt_Company.Text.ToUpper)

            'Field_Record.Field02 = CMCv.Security.Encrypt.MD5(Txt_Department.Text.ToUpper)
            'Field_Record.Field03 = CMCv.Security.Encrypt.MD5(Txt_Position.Text.ToUpper)
            'Field_Record.Field04 = CMCv.Security.Encrypt.MD5(Txt_EmployeeID.Text.ToUpper)
            Gbx_Company.Visible = False
            Gbx_Login.Visible = True
            varStep += 1
            Lbl_Step.Text = $"Step {varStep} :"
            Btn_Close.XOJenisTombol = ControlCodeBase.enuJenisTombol.Default
            Btn_Close.Text = "&Prev"
        ElseIf varStep = 2 Then
            If (Txt_Username.XOIsBlank) OrElse (Txt_Password.XOIsBlank) Then
                Decision(My.Application.Info.AssemblyName, "Field(s) cannot be empty", LibApp.Ingrid.Global.PopupType.Alert, "", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
                If (Txt_Username.XOIsBlank) Then
                    Txt_Username.Focus()
                Else
                    Txt_Password.Focus()
                End If
                Return
            End If
            If Txt_Password.XOPwdStrengthScore < 70 Then
                MsgBox("Your password is not strong enough!", MsgBoxStyle.Exclamation, "Ingrid")
                Txt_Password.Focus()
                Return
            End If
            Gbx_Company.Visible = False
            Gbx_Login.Visible = False
            Gbx_Modules.Visible = True
            varStep += 1
            Lbl_Step.Text = $"Step {varStep} :"
        ElseIf varStep = 3 Then
            'TODO: Continue next step, open SQLite Database for App_Settings.db
            'ERL.

            varStep += 1
            Lbl_Step.Text = $"Step {varStep} :"
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub frmFistGuide_Load(sender As Object, e As EventArgs) Handles Me.Load

        varStep = 1
        Gbx_Company.Visible = True
        Gbx_Login.Visible = False

        EmploymentType1.EmploymentTypeID = CMCv.Security.Encrypt.MD5("PERMANENT")
        EmploymentType1.EmploymentTypeCode = CMCv.Security.Encrypt.CRC32("PERMANENT")
        EmploymentType1.EmploymentTypeName = "PERMANENT"
        EmploymentType1.EmploymentTypeDescription = "Permanent Employment Type"

        EmploymentType2.EmploymentTypeID = CMCv.Security.Encrypt.MD5("SERVICE CONTRACT")
        EmploymentType2.EmploymentTypeCode = CMCv.Security.Encrypt.CRC32("SERVICE CONTRACT")
        EmploymentType2.EmploymentTypeName = "SERVICE CONTRACT"
        EmploymentType2.EmploymentTypeDescription = "Service Contract Employment Type"

        EmploymentType3.EmploymentTypeID = CMCv.Security.Encrypt.MD5("TPC")
        EmploymentType3.EmploymentTypeCode = CMCv.Security.Encrypt.CRC32("TPC")
        EmploymentType3.EmploymentTypeName = "TPC"
        EmploymentType3.EmploymentTypeDescription = "Third Party Contract Employment Type"

        EmploymentType4.EmploymentTypeID = CMCv.Security.Encrypt.MD5("INTERN")
        EmploymentType4.EmploymentTypeCode = CMCv.Security.Encrypt.CRC32("INTERN")
        EmploymentType4.EmploymentTypeName = "INTERN"
        EmploymentType4.EmploymentTypeDescription = "Intern Employment Type"
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        If varStep = 1 Then
            If Decision(My.Application.Info.AssemblyName, "Are you sure want to exit the First Guide?", LibApp.Ingrid.Global.PopupType.Confirmation, "By closing this first guide you will also close the application", frmDialogBox.MessageIcon.Question, frmDialogBox.MessageTypes.YesNo) = MsgBoxResult.Yes Then
                Environment.Exit(0)
            End If
        ElseIf varStep = 2 Then
            Gbx_Company.Visible = True
            Gbx_Login.Visible = False
            varStep -= 1
            Lbl_Step.Text = $"Step {varStep} :"
            Btn_Close.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
            Btn_Close.Text = "&Close"
        ElseIf varStep = 3 Then
            Gbx_Login.Visible = True
            Gbx_Modules.Visible = False
            varStep -= 1
            Lbl_Step.Text = $"Step {varStep} :"
        End If
    End Sub

    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles Btn_Check.Click
        'TODO: Value not refreshing in realtime
        Call CheckPasswordStrength()
    End Sub

    Private Sub CheckPasswordStrength()
        UPwdStrength1.SLFPasswordStrengthScore = Txt_Password.XOPwdStrengthScore
        UPwdStrength1.SLFPasswordStrengthText = Txt_Password.XOPwdStrengthText
    End Sub

    Private Sub Txt_Password_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Password.KeyUp
        Call CheckPasswordStrength()
    End Sub
End Class

