Public Class FRMdialogbox

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
    Public Sub New(ByVal Message As String, ByVal Caption As String, ByVal MessageIcon As MessageIcon, ByVal ButtonType As MessageTypes)

        ' This call is required by the designer.
        InitializeComponent()

        ' Event triggered by Message Icon.
        Select Case MessageIcon
            Case FRMdialogbox.MessageIcon.Alert
                Me.SLFLogo.Image = My.Resources.ALERT_001_256_ICON
                Me.SLFLogo.BackColor = System.Drawing.Color.Orange
                If Caption = String.Empty Then
                    Me.Text = "Alert"
                    SLFNamaForm.Text = "Alert"
                End If
            Case FRMdialogbox.MessageIcon.Error
                Me.SLFLogo.Image = My.Resources.ERROR_001_256_ICON
                Me.SLFLogo.BackColor = System.Drawing.Color.Red
                If Caption = String.Empty Then
                    Me.Text = "Error"
                    SLFNamaForm.Text = "Error"
                End If
            Case FRMdialogbox.MessageIcon.Information
                Me.SLFLogo.Image = My.Resources.INFORMATION_001_256_ICON
                Me.SLFLogo.BackColor = System.Drawing.Color.SteelBlue
                If Caption = String.Empty Then
                    Me.Text = "Information"
                    SLFNamaForm.Text = "Information"
                End If
            Case FRMdialogbox.MessageIcon.Question
                Me.SLFLogo.Image = My.Resources.QUESTION_001_256_ICON
                Me.SLFLogo.BackColor = System.Drawing.Color.DodgerBlue
                If Caption = String.Empty Then
                    Me.Text = "Question"
                    SLFNamaForm.Text = "Question"
                End If

        End Select

        ' Event triggered by Caption
        If Caption <> String.Empty Then
            Me.Text = Caption.Trim
            SLFNamaForm.Text = Caption.Trim
        End If

        SLFSubNamaForm.Text = String.Empty

        ' Event triggered by Button type.
        Select Case ButtonType
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

        TxtMessage.Text = Message

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
        DialogResult = Windows.Forms.DialogResult.Yes
        Close()
    End Sub

    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
        DialogResult = Windows.Forms.DialogResult.No
        Close()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()
    End Sub

    Private Sub BtnOkOnly_Click(sender As Object, e As EventArgs) Handles BtnOkOnly.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Close()
    End Sub

#End Region
End Class
