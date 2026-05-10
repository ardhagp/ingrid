Imports System.Runtime.Versioning

Namespace CMDsyss
    Public Class View
        <SupportedOSPlatform("windows")>
        Public Shared Function GetSettingValue(dataproperties As LibApp.Ingrid.Global.Properties, dbcolumn As String) As Object
            Try
                Dim varValue As Object = Nothing

                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(0).Query = String.Format("select {0} from dbo.sys_settings st where st.settings_id = 1", dbcolumn)
                    varValue = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(0).Query = String.Format("select {0} from sys_settings st where st.settings_id = 1", dbcolumn)
                    varValue = varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query)
                End If
                Return varValue
            Catch ex As Exception
                Return 0
            End Try
        End Function
    End Class

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Function SaveSettings(dataproperties As LibApp.Ingrid.Global.Properties, profile As Integer, storage As Integer, newsticker As Integer, minphoto As Integer, minpdf As Integer, watermark As Integer, watermarktext As String, minpassword As Integer) As Boolean
            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(1).Query = String.Format("update dbo.sys_settings set settings_showprofile = {0}, settings_showstorage = {1}, settings_showrunningtext = {2}, settings_uploadphoto = {3}, " &
                                                        "settings_uploadpdf = {4},  settings_showwatermark = {5}, settings_textmark = '{6}', settings_minpasswordlength = {7} " &
                                                        "where settings_id = 1", profile, storage, newsticker, minphoto, minpdf, watermark, watermarktext, minpassword)

                    varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(1).Query = String.Format("update dbo.sys_settings set settings_showprofile = {0}, settings_showstorage = {1}, settings_showrunningtext = {2}, settings_uploadphoto = {3}, " &
                                                        "settings_uploadpdf = {4},  settings_showwatermark = {5}, settings_textmark = '{6}', settings_minpasswordlength = {7} " &
                                                        "where settings_id = 1", profile, storage, newsticker, minphoto, minpdf, watermark, watermarktext, minpassword)

                    varDatabaseEngineMysql.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query)
                End If
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Class
End Namespace
