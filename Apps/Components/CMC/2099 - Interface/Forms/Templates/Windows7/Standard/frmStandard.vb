Imports System.Windows.Forms

Namespace UI.Canvas
    Public Class FRMstandard
        ' ----------------------------------------------------------
        ' Interfaces
        ' ----------------------------------------------------------
        Inherits UI.Canvas.FRMblank

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        <System.ComponentModel.Browsable(True)>
        <System.ComponentModel.Category("XO.Window Behaviour")>
        <System.ComponentModel.Description("Window always maximize behaviour settings")>
        <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)>
        Public Property XOWindowAlwaysMaximized As Boolean = False

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Property XOModuleCode As String = String.Empty

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Property XOModuleId As Long = 0

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        <System.ComponentModel.Category("XO.Window Behaviour")>
        <System.ComponentModel.Description("Wiki or guide page for current module")>
        Public Property XOWikiUrl As String = String.Empty

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        <System.ComponentModel.Category("XO.Window Behaviour")>
        <System.ComponentModel.Description("Logo for Wiki button")>
        Public Property XOWikiUrlLogo As String = String.Empty


        ' ----------------------------------------------------------
        ' Variables
        ' ----------------------------------------------------------


        ' ----------------------------------------------------------
        ' Forms Events Handlers
        ' ----------------------------------------------------------
        ''' <summary>
        ''' This event is triggered when the form is activated. It checks if the form is an MDI child and if the XOWindowAlwaysMaximized property is set to True. If both conditions are met, it maximizes the window state of the form.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMstandard_Activated(sender As Object, e As EventArgs) Handles Me.Activated
            If Me.IsMdiChild AndAlso XOWindowAlwaysMaximized Then
                Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            End If
        End Sub

        ''' <summary>
        ''' This event is triggered when the form is loaded. It performs garbage collection and sets the KeyPreview property of the form to True, allowing the form to receive key events before they are passed to the control that has focus.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Async Sub FRMstandard_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                GC.Collect()
                Me.KeyPreview = True

                If XOWikiUrl <> String.Empty Then
                    BtnHelp.Visible = True
                    Await ImageEditor.File.GetImage.GetSvgImageFromUrlAsync(My.Settings.URL_Logo_HELP, BtnHelp,, 64, 64, True, "Module")
                Else
                    BtnHelp.Visible = False
                End If
                Call ResizeTitle()
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                GC.RemoveMemoryPressure(GC.GetTotalMemory(True))
            End Try
        End Sub

        ''' <summary>
        ''' This event is triggered when the form is closed. It checks if the SLFStatusLabel control is not disposed and, if so, clears its text. This ensures that any status messages displayed in the label are cleared when the form is closed.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMstandard_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
            If Not SLFStatusLabel.IsDisposed Then
                SLFStatusLabel.Text = ""
            End If
        End Sub

        ''' <summary>
        ''' This event is triggered when the form is closing. It performs garbage collection to free up memory resources. The GC.Collect() method is called twice, once for the default generation and once for the maximum generation, to ensure that all unused objects are collected and memory is released.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMstandard_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
            GC.Collect()
            GC.Collect(GC.MaxGeneration)
        End Sub

        ''' <summary>
        ''' This event is triggered when the form is closed. It currently does not perform any actions, but it is set up to handle the Closed event of the form. The commented-out line suggests that the form could be disposed of when closed, but this action is not currently implemented.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMstandard_Closed(sender As Object, e As EventArgs) Handles Me.Closed
            'Me.Dispose()
        End Sub


        ' ----------------------------------------------------------
        ' Controls Events Handlers
        ' ----------------------------------------------------------


        ' ---------------------------------------------------------
        ' Functions and Subroutines
        ' ---------------------------------------------------------
        ''' <summary>
        ''' This Function still not working 
        ''' </summary>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function CheckTextInputs() As Integer
            Dim varViolation As Integer = 0
            Dim varAllTxt As New List(Of System.Windows.Forms.Control)
            For Each eachText As UI.Control.Txt In FindControlRecursive(varAllTxt, Me, GetType(UI.Control.Txt))
                If (eachText.XOIsMandatory) AndAlso eachText.XOSqlText = String.Empty Then
                    varViolation += 1
                End If
            Next
            Return varViolation
        End Function

        ''' <summary>
        ''' This function still not working
        ''' </summary>
        ''' <param name="list"></param>
        ''' <param name="Parent"></param>
        ''' <param name="CtrlType"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Shared Function FindControlRecursive(list As List(Of System.Windows.Forms.Control), parent As System.Windows.Forms.Control, ctrltype As System.Type) As List(Of System.Windows.Forms.Control)
            If parent Is Nothing Then Return list
            If parent.GetType Is ctrltype Then
                list.Add(parent)
            End If

            For Each eachChild As System.Windows.Forms.Control In parent.Controls
                FindControlRecursive(list, eachChild, ctrltype)
            Next
            Return list
        End Function

        ''' <summary>
        ''' This subroutine iterates through all controls on the form and sets focus to each control in turn. It uses the GetNextControl method to retrieve the next control in the tab order, starting from the form itself. The loop continues until there are no more controls to focus on. This can be useful for triggering validation or other events associated with each control.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub CheckAllControls()
            Dim varAllControls As System.Windows.Forms.Control = Me.GetNextControl(Me, True)

            Do Until varAllControls Is Nothing
                varAllControls.Focus()
                varAllControls = Me.GetNextControl(varAllControls, True)
            Loop
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub ResizeTitle()
            If XOWikiUrl <> String.Empty Then
                XOFormTitle.Width = pnl_.Width - 171 ' pnl_.width = 1307 ; XOFormTitle.widht = 1136
                XOSubtitle.Width = pnl_.Width - 200 ' pnl_.width = 1307 ; XOSubtitle.widht = 1107
            Else
                XOFormTitle.Width = pnl_.Width - 102 ' pnl_.width = 1307 ; XOFormTitle.widht = 1205
                XOSubtitle.Width = pnl_.Width - 131 ' pnl_.width = 1307 ; XOSubtitle.widht = 1176
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnHelp_Click(sender As Object, e As EventArgs) Handles BtnHelp.Click
            Try
                ' Open Wiki or guide page for current module in default browser
                Process.Start(New ProcessStartInfo(XOWikiUrl) With {.UseShellExecute = True})
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMstandard_Resize(sender As Object, e As EventArgs) Handles Me.Resize
            Call ResizeTitle()
        End Sub
    End Class
End Namespace