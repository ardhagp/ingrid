Imports System.ComponentModel
Imports System.Runtime.Versioning

Namespace UI.Canvas
    Public Class FRMstandard

        <SupportedOSPlatform("windows")>
        Private Sub FRMstandard_Load(sender As Object, e As EventArgs) Handles Me.Load
            Try
                Call ActivateLicenses()
                GC.Collect()
                Me.KeyPreview = True
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                GC.RemoveMemoryPressure(GC.GetTotalMemory(True))
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub FRMstandard_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
            If Not SLFStatusLabel.IsDisposed Then
                SLFStatusLabel.Text = ""
            End If
        End Sub

        Private Sub FRMstandard_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
            GC.Collect()
            GC.Collect(GC.MaxGeneration)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub FRMstandard_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
            SLFNamaForm.Width = pnl_.Width - 111
            SLFSubNamaForm.Width = pnl_.Width - 134
        End Sub

        Private Sub FRMstandard_Closed(sender As Object, e As EventArgs) Handles Me.Closed
            Me.Dispose()
        End Sub

        ''' <summary>
        ''' This Function still not working 
        ''' </summary>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Function CheckTextInputs() As Integer
            Dim varViolation As Integer = 0
            Dim varAllTxt As New List(Of System.Windows.Forms.Control)
            For Each _Txt As CMCv.UI.Control.txt In FindControlRecursive(varAllTxt, Me, GetType(CMCv.UI.Control.txt))
                If (_Txt.XOIsMandatory) AndAlso _Txt.XOSqlText = String.Empty Then
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
        <SupportedOSPlatform("windows")>
        Private Shared Function FindControlRecursive(list As List(Of System.Windows.Forms.Control), ByVal Parent As System.Windows.Forms.Control, ByVal CtrlType As System.Type) As List(Of System.Windows.Forms.Control)
            If Parent Is Nothing Then Return list
            If Parent.GetType Is CtrlType Then
                list.Add(Parent)
            End If

            For Each varEachChild As System.Windows.Forms.Control In Parent.Controls
                FindControlRecursive(list, varEachChild, CtrlType)
            Next

            Return list
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub CheckAllControls()
            Dim varAllControls As system.Windows.Forms.Control = Me.GetNextControl(Me, True)

            Do Until varAllControls Is Nothing
                varAllControls.Focus()
                varAllControls = Me.GetNextControl(varAllControls, True)
            Loop
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub FRMstandard_Activated(sender As Object, e As EventArgs) Handles Me.Activated
            If Me.IsMdiChild AndAlso XOWindowAlwaysMaximized Then
                Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            End If
        End Sub

        <Browsable(True)>
        <Category("Window Behaviour")>
        <Description("Window always maximize behaviour settings")>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Property XOWindowAlwaysMaximized As Boolean = False

    End Class
End Namespace