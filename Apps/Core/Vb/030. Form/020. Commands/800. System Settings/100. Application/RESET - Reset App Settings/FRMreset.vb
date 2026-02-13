Imports System.Runtime.Versioning

Namespace UI
    Public Class FRMreset

#Region "Declaration"

#End Region

        <SupportedOSPlatform("windows")>
        Private Sub BtnRun_Click(sender As Object, e As EventArgs) Handles BtnRun.Click
            If Txt_Confirmation.Text.Trim = "Confirm" Then
                'reset db settings
                If (Decision(My.Application.Info.AssemblyName.toupper, "Last Warning, do you want to reset application settings?", LibApp.Ingrid.Global.PopupType.ConfirmationBeforeReset, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.YesNo) = DialogResult.Yes) AndAlso (CMDreset.Editor.PushData(varDatabaseName, varDatabaseEngineE)) Then
                    Decision(My.Application.Info.AssemblyName.toupper, "You have successfully resetting application settings", LibApp.Ingrid.Global.PopupType.Information, "", FRMdialogbox.MessageIcon.Information, FRMdialogbox.MessageTypes.OkOnly)
                    Me.Close()
                End If
            Else
                'display warning
                Decision(My.Application.Info.AssemblyName.toupper, "Confirmation text is different from instruction.", LibApp.Ingrid.Global.PopupType.WrongInstructionSet, "", FRMdialogbox.MessageIcon.Error, FRMdialogbox.MessageTypes.OkOnly)
            End If
        End Sub

        Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
            Me.Close()
        End Sub
    End Class
End Namespace