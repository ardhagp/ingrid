Imports System.Runtime.Versioning

Public Class SYSS

    Private _SQL_View As New Commands.SYSS.View
    Private _SQL_Editor As New Commands.SYSS.Editor

    <SupportedOSPlatform("windows")>
    Private Sub GETDATA()
        'Get Profile
        With CboProfile.Items
            .Clear()
            .Add("Disabled")
            .Add("Administrator Only")
            .Add("User Only")
            .Add("All Users")
        End With
        CboProfile.SelectedIndex = CType(Commands.SYSS.View.GETSettingValue(V_DatabaseEngine, "settings_showprofile"), Integer)

        'Get Storage
        With CboStorage.Items
            .Clear()
            .Add("Disabled")
            .Add("Administrator Only")
            .Add("User Only")
            .Add("All Users")
        End With
        CboStorage.SelectedIndex = CType(Commands.SYSS.View.GETSettingValue(V_DatabaseEngine, "settings_showstorage"), Integer)

        'Get NewsTicker
        With CboNewsTicker.Items
            .Clear()
            .Add("Disabled")
            .Add("Administrator Only")
            .Add("User Only")
            .Add("All Users")
        End With
        CboNewsTicker.SelectedIndex = CType(Commands.SYSS.View.GETSettingValue(V_DatabaseEngine, "settings_showrunningtext"), Integer)

        'Get Minimum Photo Upload
        nudUploadPhoto.Value = CType(Commands.SYSS.View.GETSettingValue(V_DatabaseEngine, "settings_uploadphoto"), Decimal)

        'Get Minimum PDF Upload
        nudUploadPDF.Value = CType(Commands.SYSS.View.GETSettingValue(V_DatabaseEngine, "settings_uploadpdf"), Decimal)

        'Get Watermark
        With CboWatermark.Items
            .Clear()
            .Add("Disabled")
            .Add("Administrator Only")
            .Add("User Only")
            .Add("All Users")
        End With
        CboWatermark.SelectedIndex = CType(Commands.SYSS.View.GETSettingValue(V_DatabaseEngine, "settings_showwatermark"), Integer)
        TxtWatermark.Text = Commands.SYSS.View.GETSettingValue(V_DatabaseEngine, "settings_textmark").ToString

        'Get Minimum Password
        nudMinPassword.Value = CType(Commands.SYSS.View.GETSettingValue(V_DatabaseEngine, "settings_minpasswordlength"), Decimal)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub SYSS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GETDATA()
    End Sub

    Private Sub CboWatermark_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboWatermark.SelectedIndexChanged
        If CboWatermark.SelectedIndex = 0 Then
            TxtWatermark.Enabled = False
        Else
            TxtWatermark.Enabled = True
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            If (Commands.SYSS.Editor.SaveSettings(V_DatabaseEngine, CboProfile.SelectedIndex, CboStorage.SelectedIndex, CboNewsTicker.SelectedIndex, CType(nudUploadPhoto.Value, Integer), CType(nudUploadPDF.Value, Integer), CboWatermark.SelectedIndex, TxtWatermark.XOSQLText, CType(nudMinPassword.Value, Integer))) Then
                SLFStatus.Items(0).Text = "Saved"
            End If
        Catch ex As Exception
            PUSHERRORDATA(CMCv.Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.HResult.tostring, ex.StackTrace, GETAPPVERSION, False, True, True)
            PUSHERRORDATASHOW()
        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class
