Imports System.Runtime.Versioning

Namespace UI
    Public Class FRMreset

#Region "Declaration"

#End Region

        <SupportedOSPlatform("windows")>
        Private Sub BtnRun_Click(sender As Object, e As EventArgs) Handles BtnRun.Click
            If Txt_Confirmation.Text.Trim = "Confirm" Then
                'reset db settings
                If (Decision(My.Application.Info.AssemblyName.ToUpper, "Last Warning, do you want to reset application settings?", LibApp.Ingrid.Global.PopupType.ConfirmationBeforeReset, "", cmcv.ui.canvas.FRMdialogbox.MessageIcon.Alert, cmcv.ui.canvas.FRMdialogbox.MessageTypes.YesNo) = DialogResult.Yes) AndAlso (CMDreset.Editor.PushData(varDataProperties)) Then
                    Decision(My.Application.Info.AssemblyName.ToUpper, "You have successfully resetting application settings", LibApp.Ingrid.Global.PopupType.Information, "", cmcv.ui.canvas.FRMdialogbox.MessageIcon.Information, cmcv.ui.canvas.FRMdialogbox.MessageTypes.OkOnly)
                    Me.Close()
                End If
            Else
                'display warning
                Decision(My.Application.Info.AssemblyName.toupper, "Confirmation text is different from instruction.", LibApp.Ingrid.Global.PopupType.WrongInstructionSet, "", cmcv.ui.canvas.FRMdialogbox.MessageIcon.Error, cmcv.ui.canvas.FRMdialogbox.MessageTypes.OkOnly)
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
            Me.Close()
        End Sub
    End Class
End Namespace