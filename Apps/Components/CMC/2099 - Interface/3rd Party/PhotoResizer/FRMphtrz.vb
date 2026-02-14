Imports System.Runtime.Versioning

Namespace UI
    Public Class FRMphtrz
        Private varImageCompressor As New CMCv.ImageEditor.Proccessor.Compress
        Private varFileHandler As New CMCv.OperatingSystem.File.Info

        Public Event EventDone()

        Const varMesageJpg As String = ".jpg"
        Const varMessageJpeg As String = ".jpeg"

        Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
            Close()
            RaiseEvent EventDone()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

            Try
                If TxtLoad.Text = String.Empty Then
                    SLFStatusLabel.Text = "Please pick one of your photo first."
                    Return
                ElseIf Not (CMCv.OperatingSystem.File.Info.IsExists(TxtLoad.Text)) Then
                    SLFStatusLabel.Text = "Your photo does not exist. Please recheck your file."
                    Return
                End If

                If Not (CMCv.ImageEditor.Proccessor.Compress.OutputAsFile(TxtLoad.Text, TxtSave.Text)) Then
                    SLFStatusLabel.Text = "Error occured while resizing. Compressing failed."
                    Return
                End If

                TxtLoad.Text = String.Empty
                TxtSave.Text = String.Empty
                PctbxPhoto.Image = Nothing

                SLFStatusLabel.Text = "Successfully compressed your photo."

                If Not (ChkAddNew.Checked) Then
                    Me.Close()
                    RaiseEvent EventDone()
                End If

            Catch ex As Exception
                SLFStatusLabel.Text = "Error occured while resizing. Compressing failed."
            End Try

        End Sub

        Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click
            SLFStatusLabel.Text = ""

            OfdLoad.Title = "Photo Compress"
            OfdLoad.FileName = ""
            OfdLoad.Filter = "Photo File|*.Jpg;*.Jpeg"

            If OfdLoad.ShowDialog = Windows.Forms.DialogResult.OK Then
                TxtLoad.Text = OfdLoad.FileName
                PctbxPhoto.ImageLocation = OfdLoad.FileName

                If (TxtLoad.Text.Contains(varMesageJpg)) AndAlso (ChkSaveAsACopy.Checked) Then
                    TxtSave.Text = TxtLoad.Text.Replace(varMesageJpg, "_COMPRESSED.jpg")
                ElseIf (TxtLoad.Text.Contains(varMessageJpeg)) AndAlso (ChkSaveAsACopy.Checked) Then
                    TxtSave.Text = TxtLoad.Text.Replace(varMessageJpeg, "_COMPRESSED.jpeg")
                Else
                    TxtSave.Text = TxtLoad.Text
                End If

            End If
        End Sub

        Private Sub TxtLoad_TextChanged(sender As Object, e As EventArgs) Handles TxtLoad.TextChanged
            If TxtLoad.Text IsNot String.Empty Then
                If (TxtLoad.Text.Contains(varMesageJpg)) AndAlso (ChkSaveAsACopy.Checked) Then
                    TxtSave.Text = TxtLoad.Text.Replace(varMesageJpg, "_COMPRESSED.jpg")
                ElseIf (TxtLoad.Text.Contains(varMessageJpeg)) AndAlso (ChkSaveAsACopy.Checked) Then
                    TxtSave.Text = TxtLoad.Text.Replace(varMessageJpeg, "_COMPRESSED.jpeg")
                Else
                    TxtSave.Text = TxtLoad.Text
                End If
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub FRMphtrz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Call ActivateLicenses()
            ChkSaveAsACopy.Checked = True
        End Sub

        Private Sub ChkSaveAsACopy_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSaveAsACopy.CheckedChanged
            If TxtLoad.Text IsNot String.Empty Then
                If (TxtLoad.Text.Contains(varMesageJpg)) AndAlso (ChkSaveAsACopy.Checked) Then
                    TxtSave.Text = TxtLoad.Text.Replace(varMesageJpg, "_COMPRESSED.jpg")
                ElseIf (TxtLoad.Text.Contains(varMessageJpeg)) AndAlso (ChkSaveAsACopy.Checked) Then
                    TxtSave.Text = TxtLoad.Text.Replace(varMessageJpeg, "_COMPRESSED.jpeg")
                Else
                    TxtSave.Text = TxtLoad.Text
                End If
            End If
        End Sub
    End Class
End Namespace