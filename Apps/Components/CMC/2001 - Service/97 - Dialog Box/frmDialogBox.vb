Namespace UI.Canvas
    Public Class FRMdialogBox
        Inherits UI.Canvas.FRMstandardFooter

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
        ''' This constructor initializes a custom message box with specified parameters, including window title, message content, popup type, subtitle, message icon, and button type. It configures the appearance and behavior of the message box based on the provided arguments.
        ''' </summary>
        ''' <param name="Message">Message content to be displayed in the custom message box.</param>
        ''' <param name="Caption">Title of the form and caption.</param>
        ''' <param name="MessageIcon">Type of icon to be used.</param>
        ''' <param name="ButtonType">Type of buttons to be used.</param>
        ''' <remarks></remarks>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub New(windowtitle As String, message As String, title As LibApp.Ingrid.Global.PopupType, subtitle As String, messageicon As MessageIcon, buttontype As MessageTypes)

            ' This call is required by the designer.
            InitializeComponent()

            ' --- Message icon (choose image + backcolor once) ---
            Dim logoImg = CType(Nothing, System.Drawing.Image)
            Dim logoColor = System.Drawing.Color.Transparent

            Select Case messageicon
                Case MessageIcon.Alert
                    logoImg = My.Resources.ALERT_001_256_ICON
                    logoColor = System.Drawing.Color.Orange
                Case MessageIcon.Error
                    logoImg = My.Resources.ERROR_001_256_ICON
                    logoColor = System.Drawing.Color.Red
                Case MessageIcon.Information
                    logoImg = My.Resources.INFORMATION_001_256_ICON
                    logoColor = System.Drawing.Color.SteelBlue
                Case MessageIcon.Question
                    logoImg = My.Resources.QUESTION_001_256_ICON
                    logoColor = System.Drawing.Color.DodgerBlue
            End Select

            Me.XOLogo.Image = logoImg
            Me.SLFLogo.BackColor = logoColor

            ' --- Title and subtitle (compute once, avoid repeated trims and checks) ---
            Dim trimmedSubtitle = If(subtitle, String.Empty).Trim()
            Dim headerText As String = String.Empty
            Dim defaultSubtitle As String = String.Empty

            Select Case title
                Case LibApp.Ingrid.Global.PopupType.Alert
                    headerText = "Alert"
                    defaultSubtitle = "Please verify the parameters provided."
                Case LibApp.Ingrid.Global.PopupType.Confirmation
                    headerText = "Confirmation"
                    defaultSubtitle = "Please ensure your decision has been thoroughly reviewed."
                Case LibApp.Ingrid.Global.PopupType.ConfirmationBeforeReset
                    headerText = "Confirmation Before Resetting App Settings"
                    defaultSubtitle = "Every setting will be returned to its original configuration."
                Case LibApp.Ingrid.Global.PopupType.Delete
                    headerText = "Delete"
                    defaultSubtitle = "Please ensure your choice is correct before proceeding with deletion."
                Case LibApp.Ingrid.Global.PopupType.Error
                    headerText = "Error"
                    defaultSubtitle = "An unexpected error has occurred, preventing the process from continuing."
                Case LibApp.Ingrid.Global.PopupType.FileNotFound
                    headerText = "File Not Found"
                    defaultSubtitle = "The file you are trying to access cannot be found."
                Case LibApp.Ingrid.Global.PopupType.LimitExceeded
                    headerText = "Limit Exceeded"
                    defaultSubtitle = "Please ensure the file size is correct."
                Case LibApp.Ingrid.Global.PopupType.Logout
                    headerText = "Logout"
                    defaultSubtitle = "Please confirm"
                Case LibApp.Ingrid.Global.PopupType.ModuleUnderMaintenance
                    headerText = "Module Under Maintenance"
                    defaultSubtitle = "Access is unavailable due to maintenance. Please consult your administrator."
                Case LibApp.Ingrid.Global.PopupType.NoFileSelected
                    headerText = "No File Selected"
                    defaultSubtitle = "Please select one file"
                Case LibApp.Ingrid.Global.PopupType.NotAuthorized
                    headerText = "Not Authorized"
                    defaultSubtitle = "Access denied. Your current permissions do not allow this operation."
                Case LibApp.Ingrid.Global.PopupType.WrongInstructionSet
                    headerText = "Wrong Instruction Set"
                    defaultSubtitle = "Invalid instruction set detected. Please follow the designated instructions."
                Case Else
                    headerText = String.Empty
                    defaultSubtitle = String.Empty
            End Select

            SLFNamaForm.Text = headerText
            SLFSubNamaForm.Text = If(String.IsNullOrEmpty(trimmedSubtitle), defaultSubtitle, trimmedSubtitle)

            ' --- Button layout (use enum values directly) ---
            Select Case buttontype
                Case MessageTypes.YesNo
                    PnlBottomButton.Visible = False
                    PnlBottomButtonYesNo.Visible = True
                    PnlBottomButtonOkOnly.Visible = False
                Case MessageTypes.OkCancel
                    PnlBottomButton.Visible = True
                    PnlBottomButtonYesNo.Visible = False
                    PnlBottomButtonOkOnly.Visible = False
                Case MessageTypes.OkOnly
                    PnlBottomButton.Visible = False
                    PnlBottomButtonYesNo.Visible = False
                    PnlBottomButtonOkOnly.Visible = True
                Case Else
                    ' Keep default designer visibility if unknown
            End Select

            TxtMessage.Text = message
            Me.Text = windowtitle
        End Sub
#End Region

#Region "Declaration"
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
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
            Me.DialogResult = System.Windows.Forms.DialogResult.Yes
            Me.Close()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
            Me.DialogResult = System.Windows.Forms.DialogResult.No
            Me.Close()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnOkOnly_Click(sender As Object, e As EventArgs) Handles BtnOkOnly.Click
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub
#End Region
    End Class
End Namespace