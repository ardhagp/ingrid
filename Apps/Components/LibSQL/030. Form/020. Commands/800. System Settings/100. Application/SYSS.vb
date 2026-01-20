Imports System
Imports System.Runtime.Versioning

Namespace Commands.SYSS
    Public Class View
        <SupportedOSPlatform("windows")>
        Public Shared Function GetSettingValue(databasename As String, dbengine As String, dbcolumn As String) As Object
            Try
                Dim varValue As Object = Nothing

                If dbengine = "MSSQL" Then
                    V_DBR_MSSQL2008(0).Query = String.Format("select {0} from dbo.sys_settings st where st.settings_id = 1", dbcolumn)
                    varValue = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(0).Query)
                ElseIf dbengine = "MYSQL" Then
                    V_DBR_MYSQL(0).Query = String.Format("select {0} from sys_settings st where st.settings_id = 1", dbcolumn)
                    varValue = V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(0).Query)
                End If

                Return varValue
            Catch ex As Exception
                Return 0
            End Try
        End Function
    End Class

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Function SaveSettings(databasename As String, dbengine As String, profile As Integer, storage As Integer, newsticker As Integer, minphoto As Integer, minpdf As Integer, watermark As Integer, watermarktext As String, minpassword As Integer) As Boolean
            Try
                If dbengine = "MSSQL" Then
                    V_DBR_MSSQL2008(1).Query = String.Format("update dbo.sys_settings set settings_showprofile = {0}, settings_showstorage = {1}, settings_showrunningtext = {2}, settings_uploadphoto = {3}, " &
                                                        "settings_uploadpdf = {4},  settings_showwatermark = {5}, settings_textmark = '{6}', settings_minpasswordlength = {7} " &
                                                        "where settings_id = 1", profile, storage, newsticker, minphoto, minpdf, watermark, watermarktext, minpassword)

                    V_DBE_MSSQL2008.PushData(databasename, V_DBR_MSSQL2008(1).Query)
                ElseIf dbengine = "MYSQL" Then
                    V_DBR_MYSQL(1).Query = String.Format("update dbo.sys_settings set settings_showprofile = {0}, settings_showstorage = {1}, settings_showrunningtext = {2}, settings_uploadphoto = {3}, " &
                                                        "settings_uploadpdf = {4},  settings_showwatermark = {5}, settings_textmark = '{6}', settings_minpasswordlength = {7} " &
                                                        "where settings_id = 1", profile, storage, newsticker, minphoto, minpdf, watermark, watermarktext, minpassword)

                    V_DBE_MYSQL.PushData(databasename, V_DBR_MYSQL(1).Query)
                End If

                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Class
End Namespace
