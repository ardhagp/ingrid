Imports System.Runtime.Versioning

Public Class FRMreset

#Region "Variables"

#End Region

    <SupportedOSPlatform("windows")>
    Private Sub BtnRun_Click(sender As Object, e As EventArgs) Handles BtnRun.Click
        If Txt_Confirmation.Text.Trim = "Confirm" Then
            'reset db settings
            If (Decision("Last Warning, do you want to reset application settings?", "Confirmation Before Resetting App Settings", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.YesNo) = DialogResult.Yes) AndAlso (CMDreset.Editor.PushData(varDatabaseName, varDatabaseEngineE)) Then
                Decision("You have successfully resetting application settings", "Information", frmDialogBox.MessageIcon.Information, frmDialogBox.MessageTypes.OkOnly)
                Me.Close()
            End If
        Else
            'display warning
            Decision("Confirmation text is different from instruction.", "Wrong Instrution Set", FRMdialogbox.MessageIcon.Error, FRMdialogbox.MessageTypes.OkOnly)
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class