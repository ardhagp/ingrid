Imports System
Imports System.Runtime.Versioning
Imports CMCv
Imports FxResources

Namespace Commands.RESET

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Function PushData(databasename As String, dbengine As String) As Boolean
            Dim varSuccess As Boolean = False

            Try
                If dbengine = "MSSQL" Then
                    V_DBR_MSSQL2008(1).Query = String.Format("update [db_universe_erp].[dbo].sys_settings set [settings_showprofile] = 0, " &
                                                        "[settings_showstorage] = 0, [settings_showwatermark] = 0, [settings_showrunningtext] = 0, " &
                                                        "[settings_uploadphoto] = 30, [settings_uploadpdf] = 30, [settings_textmark] = '', " &
                                                        "[settings_minpasswordlength] = 3")
                    V_DBE_MSSQL2008.PushData(databasename, V_DBR_MSSQL2008(1).Query)
                ElseIf dbengine = "MYSQL" Then
                    V_DBR_MYSQL(1).Query = String.Format("update sys_settings set settings_showprofile = 0, " &
                                                        "settings_showstorage = 0, settings_showwatermark = 0, settings_showrunningtext = 0, " &
                                                        "settings_uploadphoto = 30, settings_uploadpdf = 30, settings_textmark = '', " &
                                                        "settings_minpasswordlength = 3")
                    V_DBE_MYSQL.PushData(databasename, V_DBR_MYSQL(1).Query)
                End If

                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function
    End Class

End Namespace