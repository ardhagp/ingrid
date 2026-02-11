Imports System.Runtime.Versioning

Namespace CMDreset

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Function PushData(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine) As Boolean
            Dim varSuccess As Boolean = False

            Try
                If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(1).Query = String.Format("update [db_universe_erp].[dbo].sys_settings set [settings_showprofile] = 0, " &
                                                        "[settings_showstorage] = 0, [settings_showwatermark] = 0, [settings_showrunningtext] = 0, " &
                                                        "[settings_uploadphoto] = 30, [settings_uploadpdf] = 30, [settings_textmark] = '', " &
                                                        "[settings_minpasswordlength] = 3")
                    varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(1).Query)
                ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(1).Query = String.Format("update sys_settings set settings_showprofile = 0, " &
                                                        "settings_showstorage = 0, settings_showwatermark = 0, settings_showrunningtext = 0, " &
                                                        "settings_uploadphoto = 30, settings_uploadpdf = 30, settings_textmark = '', " &
                                                        "settings_minpasswordlength = 3")
                    varDatabaseEngineMysql.PushData(databasename, varDatabaseRequestMysql(1).Query)
                End If

                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function
    End Class

End Namespace