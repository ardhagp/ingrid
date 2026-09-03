Imports System.Data

Namespace CMDsyss
    Public Class View
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Sub GetSettingsProperties(dataproperties As LibApp.Ingrid.Global.Properties, parametername As Dictionary(Of String, Object), datasetname As System.Data.DataSet)
            Try
                Dim varValue As Object

                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(0).Query = $"select {0} from dbo.sys_settings st where st.settings_id = 1"
                    varValue = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(0).Query = $"select {tSettings.S}.{tSettings.C_SettingsId}, " &
                                                       $"{tSettings.S}.{tSettings.C_SettingsShowProfile}, " &
                                                       $"{tSettings.S}.{tSettings.C_SettingsShowStorage}, " &
                                                       $"{tSettings.S}.{tSettings.C_SettingsShowWatermark}, " &
                                                       $"{tSettings.S}.{tSettings.C_SettingsTextMark}, " &
                                                       $"{tSettings.S}.{tSettings.C_SettingsTextMarkLength}, " &
                                                       $"{tSettings.S}.{tSettings.C_SettingsShowRunningText}, " &
                                                       $"{tSettings.S}.{tSettings.C_SettingsUploadPhoto}, " &
                                                       $"{tSettings.S}.{tSettings.C_SettingsUploadPdf}, " &
                                                       $"{tSettings.S}.{tSettings.C_SettingsStorageProvider}, " &
                                                       $"{tSettings.S}.{tSettings.C_SettingsApiKey}, " &
                                                       $"{tSettings.S}.{tSettings.C_SettingsApiSecret}, " &
                                                       $"{tSettings.S}.{tSettings.C_SettingsApiBucketName}, " &
                                                       $"{tSettings.S}.{tSettings.C_SettingsApiServiceUrl}, " &
                                                       $"{tSettings.S}.{tSettings.C_SettingsStorageDb}, " &
                                                       $"{tSettings.S}.{tSettings.C_SettingsClient}, " &
                                                       $"{tClient.S}.{tClient.C_ClientName}, " &
                                                       $"{tClient.S}.{tClient.C_ClientCode}, " &
                                                       $"{tSettings.S}.{tSettings.C_SettingsMinPasswordLength} " &
                                                       $"from {tSettings.TableName} {tSettings.S} " &
                                                       $"inner join {tClient.TableName} {tClient.S} " &
                                                       $"on {tClient.S}.{tClient.C_ClientId} = {tSettings.S}.{tSettings.C_SettingsClient} " &
                                                       $"where {tClient.S}.{tClient.C_ClientCode} = {tIngrid.P_ClientCode}"
                    datasetname = varDatabaseEngineMysql.FillDataSet(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query, datasetname, dstTableName.SyssEditor, parametername)
                    Dim varColumnstoEncrypt As String() = {"settings_apikey", "settings_apisecret", "settings_apibucketname", "settings_apiserviceurl"}
                    For Each row As DataRow In datasetname.Tables(dstTableName.SyssEditor).Rows
                        For Each col In varColumnstoEncrypt
                            If row(col) IsNot DBNull.Value OrElse String.IsNullOrEmpty(CStr(row(col))) Then
                                row(col) = CMCv.Security.Encryption.Aes(CStr(row(col)))
                            End If
                        Next
                    Next
                    dataproperties.DatasetCopy = datasetname.Copy
                End If
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[Closing] Mainframe"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Number = ex.HResult
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = CMCv.Ladybug.Log.Fields.TypeOfFaulties.ApplicationRunTime
                    .TypeOfLog = CMCv.Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New CMCv.Ladybug.Log.Events
                clsLog.ShowData(proLog)
                clsLog = Nothing
            End Try
        End Sub
    End Class

    Public Class Editor
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function SaveSettings(dataproperties As LibApp.Ingrid.Global.Properties, parametername As Dictionary(Of String, Object)) As Boolean
            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(1).Query = $"update dbo.sys_settings set settings_showprofile = {0}, settings_showstorage = {1}, settings_showrunningtext = {2}, settings_uploadphoto = {3}, " &
                                                           $"settings_uploadpdf = {4},  settings_showwatermark = {5}, settings_textmark = '{6}', settings_minpasswordlength = {7} " &
                                                           $"where settings_id = 1"

                    varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(1).Query = $"update {tSettings.TableName} set " &
                                                       $"{tSettings.C_SettingsShowProfile} = {tSettings.P_SettingsShowProfile}, " &
                                                       $"{tSettings.C_SettingsShowStorage} = {tSettings.P_SettingsShowStorage}, " &
                                                       $"{tSettings.C_SettingsShowRunningText} = {tSettings.P_SettingsShowRunningText}, " &
                                                       $"{tSettings.C_SettingsUploadPhoto} = {tSettings.P_SettingsUploadPhoto}, " &
                                                       $"{tSettings.C_SettingsUploadPdf} = {tSettings.P_SettingsUploadPdf}, " &
                                                       $"{tSettings.C_SettingsShowWatermark} = {tSettings.P_SettingsShowWatermark}, " &
                                                       $"{tSettings.C_SettingsTextMark} = {tSettings.P_SettingsTextMark}, " &
                                                       $"{tSettings.C_SettingsStorageProvider} = {tSettings.P_SettingsStorageProvider}, " &
                                                       $"{tSettings.C_SettingsApiKey} = {tSettings.P_SettingsApiKey}, " &
                                                       $"{tSettings.C_SettingsApiSecret} = {tSettings.P_SettingsApiSecret}, " &
                                                       $"{tSettings.C_SettingsApiBucketName} = {tSettings.P_SettingsApiBucketName}, " &
                                                       $"{tSettings.C_SettingsApiServiceUrl} = {tSettings.P_SettingsApiServiceUrl}, " &
                                                       $"{tSettings.C_SettingsStorageDb} = {tSettings.P_SettingsStorageDb}, " &
                                                       $"{tSettings.C_SettingsMinPasswordLength} = {tSettings.P_SettingsMinPasswordLength} " &
                                                       $"where {tSettings.C_SettingsId} = {tSettings.P_SettingsId}"

                    varDatabaseEngineMysql.PushData(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query, parametername)
                End If
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Class
End Namespace
