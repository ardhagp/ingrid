Namespace CMDapp
    ''' <summary>
    ''' SQL class for Ingrid Application access to several environment
    ''' </summary>
    Public Class Access

        Private ReadOnly varDatabaseRequestMssql2008(2) As CMCv.Database.Adapter.MsSql.Display.Request
        Private ReadOnly varDatabaseRequestMysql(2) As CMCv.Database.Adapter.Mysql.Display.Request

        ''' <summary>
        ''' Access to User
        ''' </summary>
        ''' <param name="dataproperties">Type of properties</param>
        ''' <param name="parametername">Type of parameter</param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function User(dataproperties As LibApp.Ingrid.Global.Properties, parametername As Dictionary(Of String, Object)) As Boolean
            Dim varView As Integer
            Dim varTypeOfAccess As String = String.Empty

            Select Case dataproperties.SystemTypeOfAccess
                Case LibApp.Ingrid.Global.TypeOfAccess.View
                    varTypeOfAccess = "uac.useraccess_view"
                Case LibApp.Ingrid.Global.TypeOfAccess.Add
                    varTypeOfAccess = "uac.useraccess_add"
                Case LibApp.Ingrid.Global.TypeOfAccess.Edit
                    varTypeOfAccess = "uac.useraccess_edit"
                Case LibApp.Ingrid.Global.TypeOfAccess.Delete
                    varTypeOfAccess = "uac.useraccess_delete"
                Case LibApp.Ingrid.Global.TypeOfAccess.Report
                    varTypeOfAccess = "uac.useraccess_reports"
            End Select

            Try
                Dim varIsAdmin As Boolean = False

                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(1).Query = String.Format("select count(usr.user_id) from dbo.sys_user usr where (usr.user_id = '{0}') and (usr.user_root = 1)", dataproperties.AllParameters("@UserId"))
                    varIsAdmin = CBool(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query))
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(1).Query = $"select count({tUser.S}.{tUser.C_UserId}) " &
                                                       $"from {tUser.TableName} {tUser.S} " &
                                                       $"where ({tUser.S}.{tUser.C_UserId} = {tIngrid.P_UserId}) " &
                                                       $"And ({tUser.S}.{tUser.C_UserIsRoot} = 1)"
                    varIsAdmin = CBool(varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query, parametername))
                End If

                If varIsAdmin Then
                    Return True
                Else
                    If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                        varDatabaseRequestMssql2008(1).Query = String.Format("select count(uac.useraccess_id) as [useraccess_id] from dbo.[[sys]]useraccess] uac " &
                                                                         "inner join dbo.sys_module mo on mo.module_id = uac.useraccess_module " &
                                                                         "where (mo.module_code = '{0}') and (uac.useraccess_user = '{1}') and ({2} = 1)", Command, dataproperties.AllParameters("@UserId"), varTypeOfAccess)
                        varView = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query), Integer)
                    ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                        varDatabaseRequestMysql(1).Query = $"select count({tUserAccess.S}.{tUserAccess.C_UserAccessId}) as `useraccess_id` " &
                                                           $"from {tUserAccess.TableName} {tUserAccess.S} " &
                                                           $"inner join {tModule.TableName} {tModule.S} " &
                                                           $"on {tModule.S}.{tModule.C_ModuleId} = {tUserAccess.S}.{tUserAccess.C_UserAccessModule} " &
                                                           $"where ({tModule.S}.{tModule.C_ModuleCode} = {tIngrid.P_ModuleCode}) " &
                                                           $"And ({tUserAccess.S}.{tUserAccess.C_UserAccessUser} = {tIngrid.P_UserId}) " &
                                                           $"And ({varTypeOfAccess} = 1)"
                        varView = CInt(varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query, parametername))
                    End If

                    If varView = 0 Then
                        System.Media.SystemSounds.Exclamation.Play()
                        Decision(My.Application.Info.AssemblyName.ToUpper, $"You are Not authorized to : " & IIf(dataproperties.SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Report, "View ", "").ToString & "{typeofaccess}" & IIf(dataproperties.SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Report, "", " record(s)").ToString, LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                        Return False
                    Else
                        Return True
                    End If
                End If
            Catch ex As Exception
                Return False
            End Try

        End Function
    End Class

    ''' <summary>
    ''' 
    ''' </summary>
    Public Class Modules
        Private varDataSet As System.Data.DataSet

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function Exist(dataproperties As LibApp.Ingrid.Global.Properties, parametername As Dictionary(Of String, Object)) As Boolean
            Dim varIsExist As Boolean

            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(1).Query = $"select count(mo.module_id) from dbo.sys_module mo where mo.module_code = '{dataproperties.AllParameters("@Command")}'"
                    varIsExist = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query), Boolean)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(1).Query = $"select count({tModule.S}.{tModule.C_ModuleId}) " &
                                                       $"from {tModule.TableName} {tModule.S} " &
                                                       $"where {tModule.S}.{tModule.C_ModuleCode} = {tIngrid.P_ModuleCode}"
                    varIsExist = CType(varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query, parametername), Boolean)
                End If
                Return varIsExist
            Catch ex As Exception
                Return False
            End Try
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <param name="parametername"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function Locked(dataproperties As LibApp.Ingrid.Global.Properties, parametername As Dictionary(Of String, Object)) As Boolean
            Dim varIsLocked As Boolean

            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(1).Query = $"select count(mo.module_id) from dbo.sys_module mo where mo.module_code = '{dataproperties.AllParameters("@Command")}' and mo.module_ismaintenance = 'true'"
                    varIsLocked = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query), Boolean)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(1).Query = $"select count({tModule.S}.{tModule.C_ModuleId}) " &
                                                       $"from {tModule.TableName} {tModule.S} " &
                                                       $"where {tModule.S}.{tModule.C_ModuleCode} = {tIngrid.P_ModuleCode} " &
                                                       $"And {tModule.S}.{tModule.C_ModuleIsMaintenance} = 1"
                    varIsLocked = CBool(varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query, parametername))
                End If
                Return varIsLocked
            Catch ex As Exception
                Return False
            End Try
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function DisplayAutoComplete(dataproperties As LibApp.Ingrid.Global.Properties) As System.Data.DataSet
            Try
                varDataSet = New System.Data.DataSet

                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(2).Query = "select mods.module_code from dbo.sys_module mods where mods.module_issystem = 0 order by mods.module_code"
                    varDataSet = varDatabaseEngineMssql2008.GetDataSet(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(2), "TCMD")
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(2).Query = $"select {tModule.S}.{tModule.C_ModuleCode} " &
                                                       $"from {tModule.TableName} {tModule.S} " &
                                                       $"where {tModule.S}.{tModule.C_ModuleIsSystem} = 0 " &
                                                       $"order by {tModule.S}.{tModule.C_ModuleCode}"
                    varDataSet = varDatabaseEngineMysql.GetDataSet(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(2), "TCMD")
                End If
                Return varDataSet
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function MaxPDFallowed(dataproperties As LibApp.Ingrid.Global.Properties) As Double
            Dim varSettingValue As Double

            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(0).Query = String.Format("select top 1 s.settings_uploadpdf from dbo.sys_settings s")
                    varSettingValue = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query), Double)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(0).Query = $"select s.settings_uploadpdf " &
                                                       $"from sys_settings s " &
                                                       $"limit 0,1"
                    varSettingValue = CDbl(varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query))
                End If
            Catch ex As Exception
                varSettingValue = 0.9
            End Try

            Return varSettingValue
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function MaxPhotoallowed(dataproperties As LibApp.Ingrid.Global.Properties) As Double
            Dim varSettingValue As Double

            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(0).Query = String.Format("select top 1 s.settings_uploadphoto from dbo.sys_settings s")
                    varSettingValue = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query), Double)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(0).Query = $"select s.settings_uploadphoto " &
                                                       $"from sys_settings s " &
                                                       $"limit 0,1"
                    varSettingValue = CDbl(varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query))
                End If
            Catch ex As Exception
                varSettingValue = 0.9
            End Try

            Return varSettingValue
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function MinPasswordLength(dataproperties As LibApp.Ingrid.Global.Properties) As Integer
            Dim varMinPasswordLength As Integer

            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(0).Query = String.Format("select top 1 s.settings_minpasswordlength from dbo.sys_settings s")
                    varMinPasswordLength = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query), Integer)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(0).Query = $"select s.settings_minpasswordlength " &
                                                       $"from sys_settings s " &
                                                       $"limit 0,1"
                    varMinPasswordLength = CType(varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query), Integer)
                End If
            Catch ex As Exception
                varMinPasswordLength = 8
            End Try
            Return varMinPasswordLength
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function TextMark(dataproperties As LibApp.Ingrid.Global.Properties) As String
            Dim varValue As Integer
            Dim varSettingValue As String = String.Empty

            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(0).Query = String.Format("select s.settings_showwatermark from dbo.sys_settings s where s.settings_id = 1")
                    varValue = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query), Integer)
                    varDatabaseRequestMssql2008(0).Query = String.Format("select top 1 s.settings_textmark from db_universe_erp.dbo.sys_settings s")
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(0).Query = $"select s.settings_showwatermark " &
                                                       $"from sys_settings s " &
                                                       $"where s.settings_id = 1"
                    varValue = CInt(varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query))
                    varDatabaseRequestMysql(0).Query = $"select s.settings_textmark " &
                                                       $"from sys_settings s " &
                                                       $"limit 0,1"
                End If

                If (varValue = 1 AndAlso (dataproperties.IsAdministrator)) OrElse (varValue = 2 AndAlso Not (dataproperties.IsAdministrator)) OrElse (varValue = 3) Then
                    If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                        varSettingValue = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query).ToString
                    ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                        varSettingValue = varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query).ToString
                    End If
                Else
                    varSettingValue = String.Empty
                End If
            Catch ex As Exception
                varSettingValue = String.Empty
            End Try
            Return varSettingValue
        End Function
    End Class

    ''' <summary>
    ''' 
    ''' </summary>
    Public Class Notification
        Private ReadOnly varDatabaseRequestMssql2008(1) As CMCv.Database.Adapter.MsSql.Display.Request
        Private ReadOnly varDatabaseRequestMysql(1) As CMCv.Database.Adapter.Mysql.Display.Request

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function Exist(dataproperties As LibApp.Ingrid.Global.Properties) As Integer
            Dim varIsExist As Integer

            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(0).Query = String.Format("select count(nt.notification_id) as [new_notification] from dbo.[[sys]]notification] nt where (nt.notification_employee = '{0}') and (nt.notification_isread = 0)", dataproperties.EmployeeId)
                    varIsExist = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query), Integer)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(0).Query = $"select count(nt.notification_id) as `new_notification` " &
                                                       $"from sys_notification nt " &
                                                       $"where (nt.notification_employee = {tIngrid.P_EmployeeId}) " &
                                                       $"And (nt.notification_isread = 0)"
                    varIsExist = CInt(varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query, dataproperties.AllParameters))
                End If
                Return varIsExist
            Catch ex As Exception
                Return 0
            End Try
        End Function
    End Class

    ''' <summary>
    ''' 
    ''' </summary>
    Public Class RunningText
        Private ReadOnly varDatabaseRequestMssql2008(1) As CMCv.Database.Adapter.MsSql.Display.Request
        Private ReadOnly varDatabaseRequestMysql(1) As CMCv.Database.Adapter.Mysql.Display.Request

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function Show(dataproperties As LibApp.Ingrid.Global.Properties) As Boolean
            Dim varValue As Integer

            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(0).Query = String.Format("select s.settings_showrunningtext from dbo.sys_settings s where s.settings_id = 1")
                    varValue = CInt(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query))
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(0).Query = $"select s.settings_showrunningtext " &
                                                       $"from sys_settings s " &
                                                       $"where s.settings_id = 1"
                    varValue = CInt(varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query))
                End If

                If varValue = 1 AndAlso (dataproperties.IsAdministrator) Then
                    Return True
                ElseIf varValue = 2 AndAlso (Not (dataproperties.IsAdministrator)) Then
                    Return True
                ElseIf varValue = 3 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Class

    ''' <summary>
    ''' 
    ''' </summary>
    Public Class StorageSense
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function Show(dataproperties As LibApp.Ingrid.Global.Properties) As Boolean
            Dim varValue As Integer

            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(0).Query = String.Format("select top 1 s.settings_showstorage from dbo.sys_settings s")
                    varValue = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query), Integer)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(0).Query = $"select s.settings_showstorage " &
                                                       $"from sys_settings s " &
                                                       $"limit 0,1"
                    varValue = CInt(varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query))
                End If

                If varValue = 1 AndAlso (dataproperties.IsAdministrator) Then
                    Return True
                ElseIf varValue = 2 AndAlso (Not (dataproperties.IsAdministrator)) Then
                    Return True
                ElseIf varValue = 3 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
            End Try
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="databasename"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function DataCurrentSize(databasename As String) As Double
            Dim varSize As Double

            Try
                varDatabaseRequestMssql2008(0).Query = String.Format("SELECT (size*8)/1024 AS SizeMB FROM sys.database_files where name='db_universe_erp'")
                varSize = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Double)

                Return varSize
            Catch ex As Exception
                Return 0
            End Try
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function FileCurrentSize(dataproperties As LibApp.Ingrid.Global.Properties) As Double
            Dim varSize As Double

            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(0).Query = $"SELECT (size*8)/1024 AS SizeMB FROM sys.database_files where name='db_universe_erp_file'"
                    varSize = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query), Double)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(0).Query = $"SELECT (size*8)/1024 AS SizeMB FROM sys.database_files where name='db_universe_erp_file'"
                    varSize = CType(varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query), Double)
                End If

                Return varSize
            Catch ex As Exception
                Return 0
            End Try
        End Function

        Public Enum DBSizeType
            MaxSize = 1
            FreeSpace = 2
        End Enum

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="databasename"></param>
        ''' <param name="sizetype"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function MaxSize(databasename As String, sizetype As DBSizeType) As Double
            Dim varSize As Double

            Try
                'Line 1 For Production
                If sizetype = 1 Then
                    varDatabaseRequestMssql2008(0).Query = String.Format("SELECT max_db_size_in_gb = CASE WHEN engine_edition = 4 THEN CASE WHEN d.sversion_name LIKE '%203%' THEN (10 * 1024)  WHEN d.sversion_name LIKE '%202%' THEN (10 * 1024)  WHEN d.sversion_name LIKE '%201%' THEN (10 * 1024) WHEN d.sversion_name LIKE '%2008 R2%' THEN (10 * 1024) WHEN d.sversion_name LIKE '%2008%' THEN (4 * 1024) WHEN d.sversion_name LIKE '%2005%' THEN (4 * 1024) END ELSE '0' END FROM (SELECT sversion_name = v.ver, engine_edition = SERVERPROPERTY('EngineEdition'), edition = SERVERPROPERTY('Edition'), server_name = SERVERPROPERTY('ServerName') FROM (SELECT ver = @@VERSION) v) d")
                    varSize = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Double)
                Else
                    varDatabaseRequestMssql2008(0).Query = "select sv.var_value from [dbo].[[sys]]variables] sv where sv.var_name = 'drive_free_space'"
                    varSize = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Double)
                End If

                'Line 2 For testing bypass purpose
                '_Size = "0"
                'Please refer to actual remaining disk space. code : https://stackoverflow.com/questions/2243121/determine-available-disk-size-with-a-sql-query

                Return varSize
            Catch ex As Exception
                Return 0
            End Try
        End Function
    End Class

    Public Class ProfilePanel

        ''' <summary>
        ''' Get the employee photo from the database. If the photo is not found, return a default
        ''' </summary>
        ''' <param name="databasename">The name of the database to query.</param>
        ''' <param name="employeeid">The ID of the employee whose photo is being retrieved.</param>
        ''' <param name="gender">The gender of the employee, used to determine the default photo if none is found.</param>
        ''' <returns>The employee's photo as a System.Drawing.Image. Returns a default image if no photo is found.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function GetPhoto(databasename As String, employeeid As String, gender As String) As System.Drawing.Image
            Dim varPhoto As System.Drawing.Image
            Dim varBytes As Byte()

            Try
                varDatabaseRequestMssql2008(0).Query = String.Format("select f.file_content from db_universe_erp_file.dbo.sto_file f where f.file_parent = '{0}' and f.file_tag = 'EMPLOYEE-PROFILE-PHOTO' and f.file_filetype = 'jpg'", employeeid)
                varBytes = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Byte())

                If Not IsNothing(varBytes) Then
                    varPhoto = CMCv.ImageEditor.Proccessor.Compress.OutputAsImage(varBytes)
                Else
                    If (gender = "MALE") OrElse (gender = "") Then
                        varPhoto = My.Resources.MALE_001_512_icon
                    Else
                        varPhoto = My.Resources.FEMALE_001_512_icon
                    End If
                End If
                Return varPhoto
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function Show(dataproperties As LibApp.Ingrid.Global.Properties) As Boolean
            Dim varValue As Integer

            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(0).Query = $"select top 1 s.settings_showprofile from dbo.sys_settings s"
                    varValue = CInt(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query))
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(0).Query = $"select s.settings_showprofile " &
                                                       $"from sys_settings s " &
                                                       $"limit 0, 1"
                    varValue = CInt(varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query))
                End If

                If varValue = 1 AndAlso (dataproperties.IsAdministrator) Then
                    Return True
                ElseIf varValue = 2 AndAlso (Not (dataproperties.IsAdministrator)) Then
                    Return True
                ElseIf varValue = 3 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
            End Try
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="dataproperties"></param>
        ''' <returns></returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function Welcome(dataproperties As LibApp.Ingrid.Global.Properties) As String
            Dim varWelcome As String = String.Empty
            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(0).Query = $"select top 1 t.template_text1 from dbo.doc_template t where t.template_module = 'F2887E94E365C068D1CCB3FF03DB7969' and t.template_title = 'PROFILE' order by newid()"
                    varWelcome = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query).ToString
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(0).Query = $"select {tTemplate.S}.{tTemplate.C_TemplateText1} " &
                                                       $"from {tTemplate.TableName} {tTemplate.S} " &
                                                       $"where {tTemplate.C_TemplateTitle} = 'PROFILE' " &
                                                       $"order by RAND() " &
                                                       $"limit 1;"
                    varWelcome = varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query).ToString
                End If
                Return varWelcome
            Catch ex As Exception
                Return "Welcome,"
            End Try
        End Function
    End Class

    ''' <summary>
    ''' The Client class provides functionality to retrieve the client ID from the database based on the provided client code. It supports both MSSQL and MySQL database engines, executing the appropriate query depending on the specified engine. The GetClientId method takes a Properties object containing database connection details and returns the corresponding client ID as a Long integer.
    ''' </summary>
    Public Class Client
        ''' <summary>
        ''' Gets the client ID from the database based on the provided client code. The method checks the database engine specified in the Properties object and executes the appropriate query to retrieve the client ID. If the client code is found, it returns the corresponding client ID; otherwise, it returns 0.
        ''' </summary>
        ''' <param name="dataproperties">The Properties object containing database connection details.</param>
        ''' <returns>The client ID as a Long integer.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function GetClientId(dataproperties As LibApp.Ingrid.Global.Properties) As Long
            Dim varResult As String = String.Empty
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(0).Query = ""
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(0).Query = $"select {tClient.S}.{tClient.C_ClientId} " &
                                                   $"from {tClient.TableName} {tClient.S} " &
                                                   $"where {tClient.S}.{tClient.C_ClientCode} = {tIngrid.P_ClientCode}"
                varResult = varDatabaseEngineMysql.GetValue(dataproperties, dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query, dataproperties.AllParameters).ToString
            End If
            Return If(String.IsNullOrEmpty(varResult), 0, CLng(varResult))
        End Function
    End Class
End Namespace

