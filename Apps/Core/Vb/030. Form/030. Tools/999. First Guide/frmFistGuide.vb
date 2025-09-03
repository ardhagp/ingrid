Public Class frmFistGuide
    Private Field_Record As New Ingrid.Main.GlobalRecord
    Private _Step As Integer

    Private Sub Btn_Process_Click(sender As Object, e As EventArgs) Handles Btn_Process.Click
        If _Step = 1 Then

            If (Txt_Company.XOIsBlank) OrElse (Txt_Department.XOIsBlank) OrElse (Txt_Position.XOIsBlank) OrElse (Txt_EmployeeName.XOIsBlank) OrElse (Txt_EmployeeID.XOIsBlank) Then
                MsgBox("Field(s) cannot be emptied", MsgBoxStyle.Critical, "Ingrid")

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

                Exit Sub
            End If

            Field_Record.Field01 = CMCv.Security.Encrypt.MD5(Txt_Company.Text.ToUpper)
            Field_Record.Field02 = CMCv.Security.Encrypt.MD5(Txt_Department.Text.ToUpper)
            Field_Record.Field03 = CMCv.Security.Encrypt.MD5(Txt_Position.Text.ToUpper)
            Field_Record.Field04 = CMCv.Security.Encrypt.MD5(Txt_EmployeeID.Text.ToUpper)

            Gbx_Company.Visible = False
            Gbx_Login.Visible = True

            _Step += 1
            Lbl_Step.Text = String.Format("Step {0} :", _Step)

            Btn_Close.XOJenisTombol = ControlCodeBase.enuJenisTombol.Default
            Btn_Close.Text = "&Prev"

        ElseIf _Step = 2 Then
            If (Txt_Username.XOIsBlank) OrElse (Txt_Password.XOIsBlank) Then
                MsgBox("Field(s) cannot be emptied", MsgBoxStyle.Critical, "Ingrid")

                If (Txt_Username.XOIsBlank) Then
                    Txt_Username.Focus()
                Else
                    Txt_Password.Focus()
                End If

                Exit Sub
            End If

            If Txt_Password.XOPwdStrengthScore < 70 Then
                MsgBox("Your password is not strong enough!", MsgBoxStyle.Exclamation, "Ingrid")
                Txt_Password.Focus()
                Exit Sub
            End If

            Gbx_Company.Visible = False
            Gbx_Login.Visible = False
            Gbx_Modules.Visible = True

            _Step += 1
            Lbl_Step.Text = String.Format("Step {0} :", _Step)

        ElseIf _Step = 3 Then
            'TODO: Continue next step, open SQLite Database for App_Settings.db
            'ERL.

            _Step += 1
            Lbl_Step.Text = String.Format("Step {0} :", _Step)

        End If
    End Sub

    Private Sub frmFistGuide_Load(sender As Object, e As EventArgs) Handles Me.Load
        _Step = 1
        Gbx_Company.Visible = True
        Gbx_Login.Visible = False
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        If _Step = 1 Then
            Me.Close()
        ElseIf _Step = 2 Then
            Gbx_Company.Visible = True
            Gbx_Login.Visible = False

            _Step -= 1
            Lbl_Step.Text = String.Format("Step {0} :", _Step)

            Btn_Close.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
            Btn_Close.Text = "&Close"
        ElseIf _Step = 3 Then
            Gbx_Login.Visible = True
            Gbx_Modules.Visible = False

            _Step -= 1
            Lbl_Step.Text = String.Format("Step {0} :", _Step)
        End If
    End Sub

    Private Sub Btn_Check_Click(sender As Object, e As EventArgs) Handles Btn_Check.Click
        'TODO: Value not refreshing in realtime
        UPwdStrength1.SLFPasswordStrengthScore = Txt_Password.XOPwdStrengthScore
        UPwdStrength1.SLFPasswordStrengthText = Txt_Password.XOPwdStrengthText
    End Sub
End Class
