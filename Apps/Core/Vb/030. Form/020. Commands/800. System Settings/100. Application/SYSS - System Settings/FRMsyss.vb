'Imports System.Runtime.Versioning

Namespace UI.Canvas
    Public Class FRMsyss
        Const varMessageDisabled As String = "Disabled"
        Const varMessageAdministratorOnly As String = "Administrator Only"
        Const varUserOnly As String = "User Only"
        Const varAllUsers As String = "All Users"

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GetData()
            CMDsyss.View.GetSettingsProperties(varDataProperties, varDataProperties.AllParameters, varDatasetIngrid)

            'Get Profile
            With CboProfile.Items
                .Clear()
                .Add(varMessageDisabled)
                .Add(varMessageAdministratorOnly)
                .Add(varUserOnly)
                .Add(varAllUsers)
            End With

            'Get Storage
            With CboStorage.Items
                .Clear()
                .Add(varMessageDisabled)
                .Add(varMessageAdministratorOnly)
                .Add(varUserOnly)
                .Add(varAllUsers)
            End With

            'Get NewsTicker
            With CboNewsTicker.Items
                .Clear()
                .Add(varMessageDisabled)
                .Add(varMessageAdministratorOnly)
                .Add(varUserOnly)
                .Add(varAllUsers)
            End With

            'Get Watermark
            With CboWatermark.Items
                .Clear()
                .Add(varMessageDisabled)
                .Add(varMessageAdministratorOnly)
                .Add(varUserOnly)
                .Add(varAllUsers)
            End With

            'Get Storage Provider
            With CboStorageProvider.Items
                .Clear()
                .Add("Disabled")
                .Add("BackBlaze B2")
            End With

            If varDatasetIngrid.Tables(dtSettings).Rows.Count > 0 Then
                With varDatasetIngrid.Tables(dtSettings).Rows(0)
                    varDataProperties.SystemSettingsId = CInt(.Item(tSettings.C_SettingsId))
                    CboProfile.SelectedIndex = CInt(.Item(tSettings.C_SettingsShowProfile))
                    CboStorage.SelectedIndex = CInt(.Item(tSettings.C_SettingsShowStorage))
                    CboNewsTicker.SelectedIndex = CInt(.Item(tSettings.C_SettingsShowRunningText))
                    nudUploadPhoto.Value = CInt(.Item(tSettings.C_SettingsUploadPhoto))
                    nudUploadPDF.Value = CInt(.Item(tSettings.C_SettingsUploadPdf))
                    CboWatermark.SelectedIndex = CInt(.Item(tSettings.C_SettingsShowWatermark))
                    TxtWatermark.Text = .Item(tSettings.C_SettingsTextMark).ToString
                    CboStorageProvider.Text = .Item(tSettings.C_SettingsStorageProvider).ToString
                    TxtApiKey.Text = If(.Item(tSettings.C_SettingsApiKey) Is Nothing, "", CMCv.Security.Decrypt.Aes(.Item(tSettings.C_SettingsApiKey).ToString))
                    TxtApiSecret.Text = If(.Item(tSettings.C_SettingsApiSecret) Is Nothing, "", CMCv.Security.Decrypt.Aes(CMCv.Security.Decrypt.Aes(.Item(tSettings.C_SettingsApiSecret).ToString)))
                    TxtApiBucketName.Text = If(.Item(tSettings.C_SettingsApiBucketName) Is Nothing, "", CMCv.Security.Decrypt.Aes(.Item(tSettings.C_SettingsApiBucketName).ToString))
                    TxtApiServiceUrl.Text = If(.Item(tSettings.C_SettingsApiServiceUrl) Is Nothing, "", CMCv.Security.Decrypt.Aes(.Item(tSettings.C_SettingsApiServiceUrl).ToString))
                    TxtFileDb.Text = .Item(tSettings.C_SettingsStorageDb).ToString
                    nudMinPassword.Value = CInt(.Item(tSettings.C_SettingsMinPasswordLength))
                    TxtClientCode.Text = .Item(tClient.C_ClientCode).ToString
                    TxtClientName.Text = .Item(tClient.C_ClientName).ToString
                End With
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMsyss_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Call GetData()
            If CboStorageProvider.Text = "None" Then
                TxtFileDb.Visible = False
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub CboWatermark_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboWatermark.SelectedIndexChanged
            If CboWatermark.SelectedIndex = 0 Then
                TxtWatermark.Enabled = False
            Else
                TxtWatermark.Enabled = True
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            Try
                With varDataProperties
                    SetValue(.AllParameters, tSettings.P_SettingsId, varDataProperties.SystemSettingsId)
                    SetValue(.AllParameters, tSettings.P_SettingsShowProfile, CboProfile.SelectedIndex)
                    SetValue(.AllParameters, tSettings.P_SettingsShowStorage, CboStorage.SelectedIndex)
                    SetValue(.AllParameters, tSettings.P_SettingsShowRunningText, CboNewsTicker.SelectedIndex)
                    SetValue(.AllParameters, tSettings.P_SettingsTextMark, TxtWatermark.Text.Trim)
                    SetValue(.AllParameters, tSettings.P_SettingsShowWatermark, CboWatermark.SelectedIndex)
                    SetValue(.AllParameters, tSettings.P_SettingsUploadPhoto, CInt(nudUploadPhoto.Value))
                    SetValue(.AllParameters, tSettings.P_SettingsUploadPdf, CInt(nudUploadPDF.Value))
                    SetValue(.AllParameters, tSettings.P_SettingsStorageProvider, CboStorageProvider.Text)
                    SetValue(.AllParameters, tSettings.P_SettingsApiKey, TxtApiKey.Text.Trim)
                    SetValue(.AllParameters, tSettings.P_SettingsApiSecret, CMCv.Security.Encryption.Aes(TxtApiSecret.Text.Trim))
                    SetValue(.AllParameters, tSettings.P_SettingsApiBucketName, TxtApiBucketName.Text.Trim)
                    SetValue(.AllParameters, tSettings.P_SettingsApiServiceUrl, TxtApiServiceUrl.Text.Trim)
                    SetValue(.AllParameters, tSettings.P_SettingsStorageDb, TxtFileDb.Text.Trim)
                    SetValue(.AllParameters, tSettings.P_SettingsMinPasswordLength, CInt(nudMinPassword.Value))
                End With

                If CMDsyss.Editor.SaveSettings(varDataProperties, varDataProperties.AllParameters) Then
                    SLFStatus.Items(0).Text = "Saved"
                End If
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[BtnSave_Click] $\Ingrid\Apps\Core\Vb\030. Form\020. Commands\800. System Settings\100. Application\SYSS - System Settings\SYSS.vb"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Number = ex.HResult
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.ApplicationRunTime
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New Ladybug.Log.Events
                clsLog.ShowData(proLog)
                clsLog = Nothing
            End Try
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
            Me.Close()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub OnCboProviderTextChanged()
            With CboStorageProvider
                If .Text = "Disabled" Then
                    TxtApiKey.Enabled = False
                    TxtApiSecret.Enabled = False
                    TxtFileDb.Enabled = False
                    TxtApiServiceUrl.Enabled = False
                    TxtApiBucketName.Enabled = False
                ElseIf .Text = "Database" Then
                    ULblApiKey.XOText = "File Database"
                    TxtApiKey.Enabled = False
                    TxtApiKey.Visible = False
                    ULblApiSecret.Visible = False
                    TxtApiSecret.Enabled = False
                    TxtApiSecret.Visible = False
                    ULblApiServiceUrl.Visible = False
                    TxtApiServiceUrl.Enabled = False
                    TxtApiServiceUrl.Visible = False
                    TxtFileDb.Visible = True
                    TxtFileDb.Enabled = True
                    TxtApiBucketName.Enabled = False
                    TxtApiBucketName.Visible = False
                Else
                    ULblApiKey.Visible = True
                    ULblApiKey.XOText = "API Key"
                    ULblApiSecret.Visible = True
                    ULblApiSecret.XOText = "API Secret"
                    TxtApiKey.Visible = True
                    TxtApiKey.Enabled = True
                    TxtApiSecret.Visible = True
                    TxtApiSecret.Enabled = True
                    ULblApiServiceUrl.Visible = True
                    If .Text = "BackBlaze B2" Then
                        ULblApiServiceUrl.XOText = "API Service URL"
                    ElseIf .Text = "Cloudinary" Then
                        ULblApiServiceUrl.XOText = "Cloud Name"
                    End If
                    TxtApiServiceUrl.Enabled = True
                    TxtApiServiceUrl.Visible = True
                    TxtApiBucketName.Enabled = True
                    TxtApiBucketName.Visible = True
                    TxtFileDb.Enabled = False
                    TxtFileDb.Visible = False
                End If
            End With
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub CboStorageProvider_TextChanged(sender As Object, e As EventArgs) Handles CboStorageProvider.TextChanged
            Call OnCboProviderTextChanged()
        End Sub
    End Class
End Namespace