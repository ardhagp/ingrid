Imports Org.BouncyCastle.Cmp
Imports Org.BouncyCastle.Tls

Public Class frmDialogBox

#Region "Initialize"
    ''' <summary>
    ''' Custom Message Box
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    ''' <summary>
    ''' Custom Message Box
    ''' </summary>
    ''' <param name="Message">Tuliskan pesan anda di sini</param>
    ''' <param name="Caption">Judul Form dan Caption</param>
    ''' <param name="MessageIcon">Jenis icon yang akan digunakan</param>
    ''' <param name="ButtonType">Tipe tombol yang akan digunakan</param>
    ''' <remarks></remarks>
    Public Sub New(windowtitle As String, message As String, title As LibApp.Ingrid.Global.PopupType, subtitle As String, messageicon As MessageIcon, buttontype As MessageTypes)

        ' This call is required by the designer.
        InitializeComponent()

        ' Event triggered by Message Icon.
        Select Case messageicon
            Case frmDialogBox.MessageIcon.Alert
                Me.SLFLogo.Image = My.Resources.ALERT_001_256_ICON
                Me.SLFLogo.BackColor = System.Drawing.Color.Orange
            Case frmDialogBox.MessageIcon.Error
                Me.SLFLogo.Image = My.Resources.ERROR_001_256_ICON
                Me.SLFLogo.BackColor = System.Drawing.Color.Red
            Case frmDialogBox.MessageIcon.Information
                Me.SLFLogo.Image = My.Resources.INFORMATION_001_256_ICON
                Me.SLFLogo.BackColor = System.Drawing.Color.SteelBlue
            Case frmDialogBox.MessageIcon.Question
                Me.SLFLogo.Image = My.Resources.QUESTION_001_256_ICON
                Me.SLFLogo.BackColor = System.Drawing.Color.DodgerBlue
        End Select

        subtitle = subtitle.Trim
        SLFSubNamaForm.Text = subtitle

        Select Case title
            Case LibApp.Ingrid.Global.PopupType.Alert
                SLFNamaForm.Text = "Alert"
                If subtitle = String.Empty Then
                    SLFSubNamaForm.Text = "Please double check given parameters"
                End If
            Case LibApp.Ingrid.Global.PopupType.Confirmation
                SLFNamaForm.Text = "Confirmation"
                If subtitle = String.Empty Then
                    SLFSubNamaForm.Text = "Consider your decision"
                End If
            Case LibApp.Ingrid.Global.PopupType.ConfirmationBeforeReset
                SLFNamaForm.Text = "Confirmation Before Resetting App Settings"
                If subtitle = String.Empty Then
                    SLFSubNamaForm.Text = "Everything will be rolled back to factory settings."
                End If
            Case LibApp.Ingrid.Global.PopupType.Delete
                SLFNamaForm.Text = "Delete"
                If subtitle = String.Empty Then
                    SLFSubNamaForm.Text = "Please double check before you delete"
                End If
            Case LibApp.Ingrid.Global.PopupType.Error
                SLFNamaForm.Text = "Error"
                If subtitle = String.Empty Then
                    SLFSubNamaForm.Text = "Something has occured that prevent progress to continue"
                End If
            Case LibApp.Ingrid.Global.PopupType.FileNotFound
                SLFNamaForm.Text = "File Not Found"
                If subtitle = String.Empty Then
                    SLFSubNamaForm.Text = "Your file cannot be found"
                End If
            Case LibApp.Ingrid.Global.PopupType.LimitExceeded
                SLFNamaForm.Text = "Limit Exceeded"
                If subtitle = String.Empty Then
                    SLFSubNamaForm.Text = "Please check file size"
                End If
            Case LibApp.Ingrid.Global.PopupType.Logout
                SLFNamaForm.Text = "Logout"
                If subtitle = String.Empty Then
                    SLFSubNamaForm.Text = "Please confirm"
                End If
            Case LibApp.Ingrid.Global.PopupType.ModuleUnderMaintenance
                SLFNamaForm.Text = "Module Under Maintenance"
                If subtitle = String.Empty Then
                    SLFSubNamaForm.Text = "Please contact your administrator"
                End If
            Case LibApp.Ingrid.Global.PopupType.NoFileSelected
                SLFNamaForm.Text = "No File Selected"
                If subtitle = String.Empty Then
                    SLFSubNamaForm.Text = "Please select one file"
                End If
            Case LibApp.Ingrid.Global.PopupType.NotAuthorized
                SLFNamaForm.Text = "Not Authorized"
                If subtitle = String.Empty Then
                    SLFSubNamaForm.Text = "You have limited access for this action"
                End If
            Case LibApp.Ingrid.Global.PopupType.WrongInstructionSet
                SLFNamaForm.Text = "Wrong Instruction Set"
                If subtitle = String.Empty Then
                    SLFSubNamaForm.Text = "Please follow the instruction"
                End If
        End Select

        ' Event triggered by Button type.
        Select Case buttontype
            Case CType(1, MessageTypes)
                PnlBottomButton.Visible = False
                PnlBottomButtonYesNo.Visible = True
                PnlBottomButtonOkOnly.Visible = False
            Case CType(2, MessageTypes)
                PnlBottomButton.Visible = True
                PnlBottomButtonYesNo.Visible = False
                PnlBottomButtonOkOnly.Visible = False
            Case CType(3, MessageTypes)
                PnlBottomButton.Visible = False
                PnlBottomButtonYesNo.Visible = False
                PnlBottomButtonOkOnly.Visible = True
        End Select

        TxtMessage.Text = message
        Me.Text = windowtitle
    End Sub
#End Region

#Region "Variables"
    Public Enum MessageTypes
        YesNo = 1
        OkCancel = 2
        OkOnly = 3
    End Enum

    Public Enum MessageIcon
        Question = 1
        Alert = 2
        [Error] = 3
        Information = 4
    End Enum
#End Region

#Region "Component Events"
    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
        Me.DialogResult = Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BtnOkOnly_Click(sender As Object, e As EventArgs) Handles BtnOkOnly.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
#End Region
End Class
