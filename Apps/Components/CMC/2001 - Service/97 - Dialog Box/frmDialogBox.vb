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
    Public Sub New(windowtitle As String, message As String, caption As String, messageicon As MessageIcon, buttontype As MessageTypes)

        ' This call is required by the designer.
        InitializeComponent()

        ' Event triggered by Message Icon.
        Select Case messageicon
            Case frmDialogBox.MessageIcon.Alert
                Me.SLFLogo.Image = My.Resources.ALERT_001_256_ICON
                Me.SLFLogo.BackColor = System.Drawing.Color.Orange
                If caption = String.Empty Then
                    SLFNamaForm.Text = "Alert"
                End If
            Case frmDialogBox.MessageIcon.Error
                Me.SLFLogo.Image = My.Resources.ERROR_001_256_ICON
                Me.SLFLogo.BackColor = System.Drawing.Color.Red
                If caption = String.Empty Then
                    SLFNamaForm.Text = "Error"
                End If
            Case frmDialogBox.MessageIcon.Information
                Me.SLFLogo.Image = My.Resources.INFORMATION_001_256_ICON
                Me.SLFLogo.BackColor = System.Drawing.Color.SteelBlue
                If caption = String.Empty Then
                    SLFNamaForm.Text = "Information"
                End If
            Case frmDialogBox.MessageIcon.Question
                Me.SLFLogo.Image = My.Resources.QUESTION_001_256_ICON
                Me.SLFLogo.BackColor = System.Drawing.Color.DodgerBlue
                If caption = String.Empty Then
                    SLFNamaForm.Text = "Question"
                End If
        End Select

        ' Event triggered by Caption
        If caption <> String.Empty Then
            SLFNamaForm.Text = caption.Trim
        End If

        SLFSubNamaForm.Text = String.Empty

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
