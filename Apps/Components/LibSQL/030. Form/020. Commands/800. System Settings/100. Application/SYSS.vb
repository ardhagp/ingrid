Imports System
Imports System.Runtime.Versioning

Namespace Commands.SYSS
    Public Class View
        <SupportedOSPlatform("windows")>
        Public Shared Function GETSettingValue(ByVal DBEngine As String, ByVal DBColumn As String) As Object
            Try
                Dim V_Value As Object = Nothing

                If DBEngine = "MSSQL" Then
                    V_DBR_MSSQL2008(0).Query = String.Format("select {0} from dbo.[[sys]]settings] st where st.settings_id = 1", DBColumn)
                    V_Value = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query)
                ElseIf DBEngine = "MYSQL" Then
                    V_DBR_MYSQL(0).Query = String.Format("select {0} from sys_settings st where st.settings_id = 1", DBColumn)
                    V_Value = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(0).Query)
                End If

                Return V_Value
            Catch ex As Exception
                Return 0
            End Try
        End Function
    End Class

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Function SaveSettings(ByVal DBEngine As String, ByVal Profile As Integer, ByVal Storage As Integer, ByVal NewsTicker As Integer, ByVal MinPhoto As Integer, ByVal MinPDF As Integer, ByVal Watermark As Integer, ByVal WatermarkText As String, ByVal MinPassword As Integer) As Boolean
            Try
                If DBEngine = "MSSQL" Then
                    V_DBR_MSSQL2008(1).Query = String.Format("update dbo.[[sys]]settings] set settings_showprofile = {0}, settings_showstorage = {1}, settings_showrunningtext = {2}, settings_uploadphoto = {3}, " &
                                                        "settings_uploadpdf = {4},  settings_showwatermark = {5}, settings_textmark = '{6}', settings_minpasswordlength = {7} " &
                                                        "where settings_id = 1", Profile, Storage, NewsTicker, MinPhoto, MinPDF, Watermark, WatermarkText, MinPassword)

                    V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)
                ElseIf DBEngine = "MYSQL" Then
                    V_DBR_MYSQL(1).Query = String.Format("update dbo.[[sys]]settings] set settings_showprofile = {0}, settings_showstorage = {1}, settings_showrunningtext = {2}, settings_uploadphoto = {3}, " &
                                                        "settings_uploadpdf = {4},  settings_showwatermark = {5}, settings_textmark = '{6}', settings_minpasswordlength = {7} " &
                                                        "where settings_id = 1", Profile, Storage, NewsTicker, MinPhoto, MinPDF, Watermark, WatermarkText, MinPassword)

                    V_DBE_MYSQL.PUSHDATA(V_DBR_MYSQL(1).Query)
                End If

                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Class
End Namespace
