Imports System
Imports System.Runtime.Versioning
Imports CMCv
Imports FxResources

Namespace Commands.RESET

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHData(ByVal DBEngine As String) As Boolean
            Dim V_Success As Boolean = False

            Try
                If DBEngine = "MSSQL" Then
                    V_DBR_MSSQL2008(1).Query = String.Format("update [db_universe_erp].[dbo].[[sys]]settings] set [settings_showprofile] = 0, " &
                                                        "[settings_showstorage] = 0, [settings_showwatermark] = 0, [settings_showrunningtext] = 0, " &
                                                        "[settings_uploadphoto] = 30, [settings_uploadpdf] = 30, [settings_textmark] = '', " &
                                                        "[settings_minpasswordlength] = 3")
                    V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)
                ElseIf DBEngine = "MYSQL" Then
                    V_DBR_MYSQL(1).Query = String.Format("update sys_settings set settings_showprofile = 0, " &
                                                        "settings_showstorage = 0, settings_showwatermark = 0, settings_showrunningtext = 0, " &
                                                        "settings_uploadphoto = 30, settings_uploadpdf = 30, settings_textmark = '', " &
                                                        "settings_minpasswordlength = 3")
                    V_DBE_MYSQL.PUSHDATA(V_DBR_MYSQL(1).Query)
                End If

                V_Success = True
            Catch ex As Exception
                V_Success = False
            End Try

            Return V_Success
        End Function
    End Class

End Namespace