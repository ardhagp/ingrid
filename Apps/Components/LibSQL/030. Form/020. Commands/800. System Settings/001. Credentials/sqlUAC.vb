Imports System.IO
Imports System.Runtime.Versioning
Imports System.Windows.Forms
Imports CMCv

Namespace CMDuac

    Public Class Login
        Public Enum EnuAuthType
            Read = 4
            Write = 2
            Execute = 1
        End Enum

        ''' <summary>
        ''' Get User ID from Employee
        ''' </summary>
        ''' <param name="Username"></param>
        ''' <param name="Password"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Public Shared Sub GetUserProperties(dataproperties As LibApp.Ingrid.Global.Properties, datasetname As System.Data.DataSet)
            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then 'Run if MSSQL
                    'varDatabaseRequestMssql2008(1).Query = $"select count(usr.user_id) as [user_id] from dbo.sys_user usr where (usr.user_username = @Username and usr.user_password = @UserPassword)"
                    'varExist = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query), Integer)

                    'If varExist > 0 Then
                    '    varDatabaseRequestMssql2008(1).Query = $"select usr.user_id from dbo.sys_user usr where (usr.user_username = @Username and usr.user_password = @UserPassword)"
                    '    dataproperties.UserId = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString

                    '    varDatabaseRequestMssql2008(1).Query = String.Format("update dbo.sys_user set user_lastlogin = getdate() where user_id = '{0}'", varUserId)
                    '    varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query)
                    'End If
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then 'Run if MYSQL
                    varDatabaseRequestMysql(1).Query = $"select {tUser.S}.{tUser.C_UserId}, " &
                                                       $"{tUser.S}.{tUser.C_UserIsRoot}, " &
                                                       $"{tEmployee.S}.{tEmployee.C_EmployeeId}, " &
                                                       $"{tEmployee.S}.{tEmployee.C_EmployeeNumber}, " &
                                                       $"{tEmployee.S}.{tEmployee.C_EmployeeFullName}, " &
                                                       $"{tEmployee.S}.{tEmployee.C_EmployeeNickname}, " &
                                                       $"{tEmployee.S}.{tEmployee.C_EmployeePersonalIdNumber}, " &
                                                       $"{tEmployee.S}.{tEmployee.C_EmployeeGender}, " &
                                                       $"{tPosition.S}.{tPosition.C_PositionCode}, " &
                                                       $"{tPosition.S}.{tPosition.C_PositionName} " &
                                                       $"From {tUser.TableName} {tUser.S} " &
                                                       $"inner join {tEmployee.TableName} {tEmployee.S} " &
                                                       $"On {tEmployee.S}.{tEmployee.C_EmployeeId} = {tUser.S}.{tUser.C_UserEmployee} " &
                                                       $"inner join {tPosition.TableName} {tPosition.S} " &
                                                       $"On {tPosition.S}.{tPosition.C_PositionId} = {tEmployee.S}.{tEmployee.C_EmployeePosition} " &
                                                       $"where ({tUser.S}.{tUser.C_UserUsername} = {tUser.P_Username} " &
                                                       $"And {tUser.S}.{tUser.C_UserPassword} = {tUser.P_UserPassword})"
                    varDatabaseEngineMysql.FillDataSet(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query, datasetname, "UserData", dataproperties.AllParameters)

                    With datasetname
                        If .Tables("UserData").Rows.Count > 0 Then

                            dataproperties.AllParameters.Remove(tUser.P_UserId)
                            dataproperties.AllParameters.Add(tUser.P_UserId, CLng(.Tables("UserData").Rows(0).Item(tUser.C_UserId)))

                            varDatabaseRequestMysql(1).Query = $"update {tUser.TableName} " &
                                                               $"set {tUser.C_UserLastLogin} = now() " &
                                                               $"where {tUser.C_UserId} = {tUser.P_UserId}"
                            varDatabaseEngineMysql.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query, dataproperties.AllParameters)
                        End If
                    End With
                End If
            Catch ex As Exception
                dataproperties.UserId = Nothing
            End Try
        End Sub

        ''' <summary>
        ''' Get Employee Authorization
        ''' </summary>
        ''' <param name="AuthType"></param>
        ''' <param name="SysModule"></param>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GetAccess(dataproperties As LibApp.Ingrid.Global.Properties, authtype As EnuAuthType, sysmodule As String, uid As Integer) As Boolean
            Dim varIsAuth As Integer

            If authtype = EnuAuthType.Read Then
                'TODO: Read method
            ElseIf authtype = EnuAuthType.Write Then
                'TODO: Write method
            ElseIf authtype = EnuAuthType.Execute Then
                'TODO: Execute method
            End If

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then 'Run if MSSQL
                varDatabaseRequestMssql2008(0).Query = ""
                varIsAuth = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query), Integer)
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then 'Run if MYSQL
                varDatabaseRequestMysql(0).Query = ""
                varIsAuth = CType(varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query), Integer)
            End If

            If varIsAuth = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        ''' <summary>
        ''' Get Employee Photo
        ''' </summary>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Function GetPhoto(dataproperties As LibApp.Ingrid.Global.Properties, uid As String) As System.Drawing.Image
            'TODO: To be moved into cloud storage

            Dim varUserID As String = uid
            Dim varPhoto As System.Drawing.Image = Nothing
            Dim varFileStream As IO.FileStream = Nothing

            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(0).Query = String.Format("SELECT f.file_content FROM db_universe_erp_file.dbo.sto_file f where f.file_tag = 'EMPLOYEE-PROFILE-PHOTO' and f.file_parent = '{0}' ;", varUserID)
                    varFileStream = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query), FileStream)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(0).Query = $"SELECT f.file_content FROM db_universe_erp_file.dbo.sto_file f where f.file_tag = 'EMPLOYEE-PROFILE-PHOTO' and f.file_parent = '{varUserID}' ;"
                    varFileStream = CType(varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query), FileStream)
                End If

                If varFileStream IsNot Nothing Then
                    varPhoto = ImageEditor.Proccessor.Compress.OutputAsImage(varFileStream)
                End If
            Catch ex As Exception
                varPhoto = Nothing
            End Try
            Return varPhoto
        End Function

        ''' <summary>
        ''' Get Employee Administrator state
        ''' </summary>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GetAdministrator(dataproperties As LibApp.Ingrid.Global.Properties, uid As String) As Boolean
            Dim varIsAdministrator As Boolean = False

            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then 'Run if MSSQL
                    varDatabaseRequestMssql2008(0).Query = String.Format("select u.user_root from dbo.sys_user u where u.user_id = '{0}'", uid)
                    varIsAdministrator = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0).Query), Boolean)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then 'Run if MYSQL
                    varDatabaseRequestMysql(0).Query = $"select u.user_root from sys_user u where u.user_id = '{uid}'"
                    varIsAdministrator = CType(varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0).Query), Boolean)
                End If
            Catch ex As Exception
                varIsAdministrator = False
            End Try
            Return varIsAdministrator
        End Function

        Public Shared Function GetUserID() As Integer
            Return 1
        End Function
    End Class

    Public Class View

        ''' <summary>
        ''' Display Data from UAC Table
        ''' </summary>
        ''' <param name="DataGrid"></param>
        ''' <param name="StatusBar"></param>
        ''' <param name="Find"></param>
        ''' <param name="ForceRefresh"></param>
        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(dataproperties As LibApp.Ingrid.Global.Properties, datagrid As CMCv.UI.Control.dgn, statusbar As CMCv.UI.Control.stt, find As CMCv.UI.Control.txt, Optional forcerefresh As Boolean = False)
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then 'Run if MSSQL
                If (find.XOSQLText = String.Empty) OrElse (forcerefresh) Then
                    varDatabaseRequestMssql2008(0).Query = String.Format("select usr.user_id, em.employee_number, em.employee_fullname, usr.user_username, iif(usr.user_root=1,'Administrator','') as [user_root], usr.user_lastlogin, " &
                                                            "usr.user_locked from dbo.sys_user usr inner join dbo.man_employee em on em.employee_id = usr.user_employee order by em.employee_fullname")
                Else
                    varDatabaseRequestMssql2008(0).Query = String.Format("select usr.user_id, em.employee_number, em.employee_fullname, usr.user_username, iif(usr.user_root=1,'Administrator','') as [user_root], usr.user_lastlogin, " &
                                                            "usr.user_locked from dbo.sys_user usr inner join dbo.man_employee em on em.employee_id = usr.user_employee where (em.employee_number = '{0}') or " &
                                                            "(em.employee_fullname like '%{0}%') or (usr.user_username = '{0}') order by em.employee_fullname", find.XOSQLText)
                End If
                varDatabaseRequestMssql2008(0).DataGrid = datagrid
                varDatabaseRequestMssql2008(0).StatusBar = statusbar
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TUAC")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then 'Run in MYSQL
                If (find.XOSQLText = String.Empty) OrElse (forcerefresh) Then
                    varDatabaseRequestMysql(0).Query = $"select usr.user_id, em.employee_number, em.employee_fullname, usr.user_username, iif(usr.user_root=1,'Administrator','') as `user_root`, usr.user_lastlogin, " &
                                                       $"usr.user_locked from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee order by em.employee_fullname"
                Else
                    varDatabaseRequestMysql(0).Query = $"select usr.user_id, em.employee_number, em.employee_fullname, usr.user_username, iif(usr.user_root=1,'Administrator','') as `user_root`, usr.user_lastlogin, " &
                                                       $"usr.user_locked from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where (em.employee_number = '{find.XOSQLText}') or " &
                                                       $"(em.employee_fullname like '%{find.XOSQLText}%') or (usr.user_username = '{find.XOSQLText}') order by em.employee_fullname"
                End If
                varDatabaseRequestMysql(0).DataGrid = datagrid
                varDatabaseRequestMysql(0).StatusBar = statusbar
                varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(0), "TUAC")
            End If
        End Sub

        ''' <summary>
        ''' Delete Data From UAC
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function DeleteData(dataproperties As LibApp.Ingrid.Global.Properties, rowid As String) As Boolean
            Dim varSuccess As Boolean
            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then 'Run if MSSQL
                    varDatabaseRequestMssql2008(1).Query = String.Format("delete from dbo.sys_user where (user_id = '{0}')", rowid)
                    varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then 'Run if MYSQL
                    varDatabaseRequestMysql(1).Query = $"delete from {tUser.TableName} " &
                                                       $"where ({tUser.C_UserId} = {tUser.P_UserId})"
                    varDatabaseEngineMysql.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query)
                End If
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function
    End Class

    ''' <summary>
    ''' Editor Class
    ''' </summary>
    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(dataproperties As LibApp.Ingrid.Global.Properties, grid As CMCv.UI.Control.dgn, Optional rowid As String = "-1")
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                ReDim varDatabaseRequestMssql2008(2)

                If rowid = "-1" Then
                    varDatabaseRequestMssql2008(2).Query = String.Format("select mog.modulegroup_name, mo.module_code, 0 as [useraccess_view], 0 as [useraccess_add], 0 as [useraccess_edit], 0 as [useraccess_delete], " &
                                                            "0 as [useraccess_reports], '' as [useraccess_id], mo.module_id from dbo.sys_module mo inner join dbo.[[sys]]modulegroup] mog " &
                                                            "on mog.modulegroup_id = mo.module_modulegroup order by mog.modulegroup_order, mo.module_code")
                Else
                    varDatabaseRequestMssql2008(2).Query = String.Format("select mog.modulegroup_name, mo.module_code, (select uac1.useraccess_view from dbo.[[sys]]useraccess] uac1 inner join dbo.sys_module mo1 " &
                                                            "on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{0}' and mo1.module_code = mo.module_code) as [useraccess_view], (select uac1.useraccess_add " &
                                                            "from dbo.[[sys]]useraccess] uac1 inner join dbo.sys_module mo1 on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{0}' and " &
                                                            "mo1.module_code = mo.module_code) as [useraccess_add], (select uac1.useraccess_edit from dbo.[[sys]]useraccess] uac1 inner join dbo.sys_module mo1 " &
                                                            "on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{0}' and mo1.module_code = mo.module_code) as [useraccess_edit], " &
                                                            "(select uac1.useraccess_delete from dbo.[[sys]]useraccess] uac1 inner join dbo.sys_module mo1 on mo1.module_id = uac1.useraccess_module " &
                                                            "where uac1.useraccess_user = '{0}' and mo1.module_code = mo.module_code) as [useraccess_delete], (select uac1.useraccess_reports from dbo.[[sys]]useraccess] uac1 " &
                                                            "inner join dbo.sys_module mo1 on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{0}' and " &
                                                            "mo1.module_code = mo.module_code) as [useraccess_reports], (select uac1.useraccess_id from dbo.[[sys]]useraccess] uac1 inner join dbo.sys_module mo1 " &
                                                            "on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{0}' and mo1.module_code = mo.module_code) as [useraccess_id], mo.module_id " &
                                                            "from dbo.sys_module mo inner join dbo.[[sys]]modulegroup] mog on mog.modulegroup_id = mo.module_modulegroup order by mog.modulegroup_order, mo.module_code", rowid)
                End If

                varDatabaseRequestMssql2008(2).DataGrid = grid
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(2), "TUserAccess")
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                ReDim varDatabaseRequestMysql(2)

                If rowid = "-1" Then
                    varDatabaseRequestMysql(2).Query = $"select mog.modulegroup_name, mo.module_code, 0 as `useraccess_view`, 0 as `useraccess_add`, 0 as `useraccess_edit`, 0 as `useraccess_delete`, " &
                                                       $"0 as `useraccess_reports`, '' as `useraccess_id`, mo.module_id from sys_module mo inner join sys_modulegroup mog " &
                                                       $"on mog.modulegroup_id = mo.module_modulegroup order by mog.modulegroup_order, mo.module_code"
                Else
                    varDatabaseRequestMysql(2).Query = $"select mog.modulegroup_name, mo.module_code, (select uac1.useraccess_view from sys_useraccess uac1 inner join sys_module mo1 " &
                                                       $"on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{rowid}' and mo1.module_code = mo.module_code) as [useraccess_view], (select uac1.useraccess_add " &
                                                       $"from sys_useraccess uac1 inner join sys_module mo1 on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{rowid}' and " &
                                                       $"mo1.module_code = mo.module_code) as [useraccess_add], (select uac1.useraccess_edit from sys_useraccess uac1 inner join sys_module mo1 " &
                                                       $"on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{rowid}' and mo1.module_code = mo.module_code) as [useraccess_edit], " &
                                                       $"(select uac1.useraccess_delete from sys_useraccess uac1 inner join sys_module mo1 on mo1.module_id = uac1.useraccess_module " &
                                                       $"where uac1.useraccess_user = '{rowid}' and mo1.module_code = mo.module_code) as [useraccess_delete], (select uac1.useraccess_reports from sys_useraccess uac1 " &
                                                       $"inner join sys_module mo1 on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{rowid}' and " &
                                                       $"mo1.module_code = mo.module_code) as [useraccess_reports], (select uac1.useraccess_id from sys_useraccess uac1 inner join sys_module mo1 " &
                                                       $"on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{rowid}' and mo1.module_code = mo.module_code) as [useraccess_id], mo.module_id " &
                                                       $"from sys_module mo inner join sys_modulegroup mog on mog.modulegroup_id = mo.module_modulegroup order by mog.modulegroup_order, mo.module_code"
                End If

                varDatabaseRequestMysql(2).DataGrid = grid
                varDatabaseEngineMysql.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(2), "TUserAccess")
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function GetUIDbyEmployeeID(dataproperties As LibApp.Ingrid.Global.Properties, employeeid As String) As String
            Dim varUserID As String = String.Empty

            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(1).Query = String.Format("select usr.user_id from dbo.sys_user usr where usr.user_employee = '{0}';", employeeid)

                    varUserID = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString
                    IIf(IsDBNull(varUserID), "", varUserID)
                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(1).Query = String.Format("select usr.user_id from sys_user usr where usr.user_employee = '{0}';", employeeid)

                    varUserID = varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query).ToString
                    IIf(IsDBNull(varUserID), "", varUserID)
                End If
            Catch ex As Exception
                varUserID = Nothing
            End Try
            Return varUserID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Sub GetEmployeeProperties(dataproperties As LibApp.Ingrid.Global.Properties, datasetname As System.Data.DataSet)
            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = $""
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(0).Query = $"select emp.{tEmployee.C_EmployeeNumber}, " &
                                                   $"emp.{tEmployee.C_EmployeeFullName}, " &
                                                   $"usr.{tUser.C_UserIsRoot}, " &
                                                   $"usr.{tUser.C_UserIsLocked}, " &
                                                   $"from {tUser.TableName} usr inner join {tEmployee.TableName} emp " &
                                                   $"on emp.{tEmployee.C_EmployeeId} = usr.{tUser.C_UserEmployee} " &
                                                   $"where usr.{tUser.C_UserId} = {tUser.P_UserId}"
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function GetEmployeeNumber(dataproperties As LibApp.Ingrid.Global.Properties, userid As String) As String
            Dim varEmployeeNumber As String = String.Empty

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_number from dbo.sys_user usr inner join dbo.man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varEmployeeNumber = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = String.Format("select em.employee_number from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varEmployeeNumber = varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query).ToString
            End If
            Return varEmployeeNumber
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetEmployeeFullName(dataproperties As LibApp.Ingrid.Global.Properties, userid As String) As String
            Dim varEmployeeFullName As String = String.Empty

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_fullname from dbo.sys_user usr inner join dbo.man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varEmployeeFullName = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = String.Format("select em.employee_fullname from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varEmployeeFullName = varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query).ToString
            End If

            Return varEmployeeFullName
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetUsernameByUserID(dataproperties As LibApp.Ingrid.Global.Properties, ByVal userid As String) As String
            Dim varUsername As String = String.Empty

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select usr.user_username from dbo.sys_user usr inner join dbo.man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varUsername = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = String.Format("select usr.user_username from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varUsername = varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query).ToString
            End If

            Return varUsername
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetUsernameByEmployeeID(dataproperties As LibApp.Ingrid.Global.Properties, employeeid As String) As String
            Dim varUsername As String = String.Empty

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select usr.user_username from dbo.sys_user usr where usr.user_employee = '{0}'", employeeid)

                varUsername = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = String.Format("select usr.user_username from sys_user usr where usr.user_employee = '{0}'", employeeid)

                varUsername = varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query).ToString
            End If

            Return varUsername
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetPassword(dataproperties As LibApp.Ingrid.Global.Properties, userid As String) As String
            Dim varPassword As String = String.Empty

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select usr.user_password from dbo.sys_user usr inner join dbo.man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varPassword = varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query).ToString
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = String.Format("select usr.user_password from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varPassword = varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query).ToString
            End If

            Return varPassword
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetLocked(dataproperties As LibApp.Ingrid.Global.Properties, userid As String) As Boolean
            Dim varLocked As Boolean = True

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select usr.user_locked from dbo.sys_user usr inner join dbo.man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varLocked = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query), Boolean)
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = $"select usr.user_locked from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{userid}'"

                varLocked = CType(varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query), Boolean)
            End If

            Return varLocked
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetAdministrator(dataproperties As LibApp.Ingrid.Global.Properties, userid As String) As Boolean
            Dim varRoot As Boolean = False

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select usr.user_root from dbo.sys_user usr inner join dbo.man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)
                varRoot = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query), Boolean)
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = $"select usr.user_root from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{userid}'"
                varRoot = CType(varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query), Boolean)
            End If

            Return varRoot
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(dataproperties As LibApp.Ingrid.Global.Properties, username As String, Optional rowid As String = "-1") As Boolean
            Dim varIsDuplicate As Integer

            If rowid = "-1" AndAlso dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select count(usr.user_id) as [user_id] from dbo.sys_user usr where (usr.user_username = '{0}')", username)
            ElseIf rowid <> "-1" AndAlso dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select count(usr.user_id) as [user_id] from dbo.sys_user usr where (usr.user_username = '{0}') and (usr.user_id <> '{1}')", username, rowid)
            ElseIf rowid = "-1" AndAlso dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = $"select count(usr.user_id) as `user_id` from sys_user usr where (usr.user_username = '{username}')"
            ElseIf rowid <> "-1" AndAlso dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = $"select count(usr.user_id) as `user_id` from sys_user usr where (usr.user_username = '{username}') and (usr.user_id <> '{rowid}')"
            End If

            If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varIsDuplicate = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query), Integer)
            ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varIsDuplicate = CType(varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query), Integer)
            End If

            If varIsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        ' Local helpers
        Private Shared Function Safe(s As Object) As String
            If s Is Nothing Then
                Return String.Empty
            End If
            Return s.ToString().Replace("'", "''")
        End Function

        Private Shared Function BoolToSql(b As Boolean) As String
            ' Keep same textual boolean representation as original code used in string interpolation
            Return If(b, "1", "0")
        End Function

        <SupportedOSPlatform("windows")>
        <System.Diagnostics.CodeAnalysis.SuppressMessage("Security", "S2068:Hardcoded credentials")>
        Public Shared Function PushData(dataproperties As LibApp.Ingrid.Global.Properties, uac As CMCv.UI.Control.dgn) As Boolean
            Dim varSuccess As Boolean = False

            Try
                If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    ReDim varDatabaseRequestMssql2008(4)

                    Dim sb As New Text.StringBuilder()

                    If dataproperties.UserAccessIsNew Then
                        ' Insert new user
                        sb.AppendFormat($"insert into dbo.{tUser.TableName}(" &
                                        tUser.C_UserEmployee & ", " &
                                        tUser.C_UserUsername & ", " &
                                        tUser.C_UserPassword & ", " &
                                        tUser.C_UserIsLocked & ", " &
                                        tUser.C_UserIsRoot & ", " &
                                        tUser.C_UserDateCreated & " " &
                                        ") values (" &
                                        tEmployee.P_EmployeeId & ", " &
                                        tUser.P_Username & ", " &
                                        tUser.P_UserPassword & ", " &
                                        tUser.P_UserIsLocked & ", " &
                                        tUser.P_UserIsRoot & ", " &
                                        "(select getdate()));")

                        If uac IsNot Nothing Then
                            For Each varEachRow As DataGridViewRow In uac.Rows
                                With dataproperties.AllParameters
                                    .Remove(tModule.P_ModuleCode)
                                    .Add(tModule.P_ModuleCode, Safe(varEachRow.Cells(tModule.C_ModuleCode).Value))
                                    .Remove(tUserAccess.P_UserAccessView)
                                    .Add(tUserAccess.P_UserAccessView, Safe(varEachRow.Cells(tUserAccess.C_UserAccessView).Value))
                                    .Remove(tUserAccess.P_UserAccessAdd)
                                    .Add(tUserAccess.P_UserAccessAdd, Safe(varEachRow.Cells(tUserAccess.C_UserAccessAdd).Value))
                                    .Remove(tUserAccess.P_UserAccessEdit)
                                    .Add(tUserAccess.P_UserAccessEdit, Safe(varEachRow.Cells(tUserAccess.C_UserAccessEdit).Value))
                                    .Remove(tUserAccess.P_UserAccessDelete)
                                    .Add(tUserAccess.P_UserAccessDelete, Safe(varEachRow.Cells(tUserAccess.C_UserAccessDelete).Value))
                                    .Remove(tUserAccess.P_UserAccessReports)
                                    .Add(tUserAccess.P_UserAccessReports, Safe(varEachRow.Cells(tUserAccess.C_UserAccessReports).Value))
                                End With

                                sb.AppendFormat($"insert into dbo.{tUserAccess.TableName}( " &
                                                tUserAccess.C_UserAccessUser & ", " &
                                                tUserAccess.C_UserAccessModule & ", " &
                                                tUserAccess.C_UserAccessView & ", " &
                                                tUserAccess.C_UserAccessAdd & ", " &
                                                tUserAccess.C_UserAccessEdit & ", " &
                                                tUserAccess.C_UserAccessDelete & ", " &
                                                tUserAccess.C_UserAccessReports & " " &
                                                ") values (" &
                                                tUser.P_UserId & ", " &
                                                $"(select mo.{tModule.C_ModuleId} from dbo.{tModule.TableName} mo where mo.{tModule.C_ModuleCode} = {tModule.P_ModuleCode}), " &
                                                tUserAccess.P_UserAccessView & ", " &
                                                tUserAccess.P_UserAccessAdd & ", " &
                                                tUserAccess.P_UserAccessEdit & ", " &
                                                tUserAccess.P_UserAccessDelete & ", " &
                                                tUserAccess.P_UserAccessReports & ");")
                            Next
                        End If
                    Else
                        ' Update existing user
                        If dataproperties.UserAccessIsPasswordChanged Then
                            sb.AppendFormat($"update dbo.{tUser.TableName} set " &
                                            $"{tUser.C_UserUsername} =  {tUser.P_Username}, " &
                                            $"{tUser.C_UserPassword} =  {tUser.P_UserPassword}, " &
                                            $"{tUser.C_UserIsLocked} =  {tUser.P_UserIsLocked}, " &
                                            $"{tUser.C_UserIsRoot} =  {tUser.P_UserIsRoot} " &
                                            $"where {tUser.C_UserId} = {tUser.P_UserId} ;")
                        Else
                            sb.AppendFormat($"update dbo.{tUser.TableName} set " &
                                            $"{tUser.C_UserUsername} = {tUser.P_Username}, " &
                                            $"{tUser.C_UserIsLocked} = {tUser.P_UserIsLocked}, " &
                                            $"{tUser.C_UserIsRoot} = {tUser.P_UserIsRoot} " &
                                            $"where {tUser.C_UserId} = {tUser.P_UserId};")
                        End If

                        If uac IsNot Nothing Then
                            For Each varEachRow As DataGridViewRow In uac.Rows
                                With dataproperties.AllParameters
                                    .Remove(tModule.P_ModuleCode)
                                    .Add(tModule.P_ModuleCode, Safe(varEachRow.Cells(tModule.C_ModuleCode).Value))
                                    .Remove(tUserAccess.P_UserAccessView)
                                    .Add(tUserAccess.P_UserAccessView, Safe(varEachRow.Cells(tUserAccess.C_UserAccessView).Value))
                                    .Remove(tUserAccess.P_UserAccessAdd)
                                    .Add(tUserAccess.P_UserAccessAdd, Safe(varEachRow.Cells(tUserAccess.C_UserAccessAdd).Value))
                                    .Remove(tUserAccess.P_UserAccessEdit)
                                    .Add(tUserAccess.P_UserAccessEdit, Safe(varEachRow.Cells(tUserAccess.C_UserAccessEdit).Value))
                                    .Remove(tUserAccess.P_UserAccessDelete)
                                    .Add(tUserAccess.P_UserAccessDelete, Safe(varEachRow.Cells(tUserAccess.C_UserAccessDelete).Value))
                                    .Remove(tUserAccess.P_UserAccessReports)
                                    .Add(tUserAccess.P_UserAccessReports, Safe(varEachRow.Cells(tUserAccess.C_UserAccessReports).Value))
                                    .Remove(tUserAccess.P_UserAccessId)
                                    .Add(tUserAccess.P_UserAccessId, Safe(varEachRow.Cells(tUserAccess.C_UserAccessId).Value))
                                End With

                                ' Check existence (original behaviour)
                                varDatabaseRequestMssql2008(3).Query = $"select count(uac.{tUserAccess.C_UserAccessId}) as [useraccess_id] " &
                                                                       $"from dbo.{tUserAccess.TableName} uac " &
                                                                       $"inner join dbo.{tModule.TableName} mo " &
                                                                       $"on mo.{tModule.C_ModuleId} = uac.{tUserAccess.C_UserAccessModule} " &
                                                                       $"where uac.{tUserAccess.C_UserAccessUser} = {tUser.P_UserId} And " &
                                                                       $"mo.{tModule.C_ModuleCode} = {tModule.P_ModuleCode}"
                                Dim varIsExist = CInt(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(3).Query))

                                If varIsExist = 0 Then
                                    sb.AppendFormat($"insert into dbo.{tUserAccess.TableName}( " &
                                                    $"{tUserAccess.C_UserAccessUser}, " &
                                                    $"{tUserAccess.C_UserAccessModule}, " &
                                                    $"{tUserAccess.C_UserAccessView}, " &
                                                    $"{tUserAccess.C_UserAccessAdd}, " &
                                                    $"{tUserAccess.C_UserAccessEdit}, " &
                                                    $"{tUserAccess.C_UserAccessDelete}, " &
                                                    $"{tUserAccess.C_UserAccessReports} " &
                                                    ") values ( " &
                                                    $"{tUser.P_UserId}, " &
                                                    $"(select mo.{tModule.C_ModuleId} from dbo.sys_module mo where mo.{tModule.C_ModuleCode} = {tModule.P_ModuleCode}), " &
                                                    $"{tUserAccess.P_UserAccessView}, " &
                                                    $"{tUserAccess.P_UserAccessAdd}, " &
                                                    $"{tUserAccess.P_UserAccessEdit}, " &
                                                    $"{tUserAccess.P_UserAccessDelete}, " &
                                                    $"{tUserAccess.P_UserAccessReports});")
                                Else
                                    sb.AppendFormat($"update dbo.{tUserAccess.TableName} set " &
                                                    $"{tUserAccess.C_UserAccessView} = {tUserAccess.P_UserAccessView}, " &
                                                    $"{tUserAccess.C_UserAccessAdd} = {tUserAccess.P_UserAccessAdd}, " &
                                                    $"{tUserAccess.C_UserAccessEdit} = {tUserAccess.P_UserAccessEdit}, " &
                                                    $"{tUserAccess.C_UserAccessDelete} = {tUserAccess.P_UserAccessDelete}, " &
                                                    $"{tUserAccess.C_UserAccessReports} = {tUserAccess.P_UserAccessReports} " &
                                                    $"where {tUserAccess.C_UserAccessId} = {tUserAccess.P_UserAccessId};")
                                End If
                            Next
                        End If
                    End If

                    varDatabaseRequestMssql2008(1).Query = sb.ToString()
                    varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query)
                    varSuccess = True

                ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    ReDim varDatabaseRequestMysql(4)

                    Dim sb As New Text.StringBuilder()

                    If dataproperties.UserAccessIsNew Then
                        sb.AppendFormat($"insert into {tUser.TableName}(" &
                                        $"{tUser.C_UserEmployee}, " &
                                        $"{tUser.C_UserUsername}, " &
                                        $"{tUser.C_UserPassword}, " &
                                        $"{tUser.C_UserIsLocked}, " &
                                        $"{tUser.C_UserIsRoot}, " &
                                        $"{tUser.C_UserDateCreated} " &
                                        ") values (" &
                                        $"{tEmployee.P_EmployeeId}, " &
                                        $"{tUser.P_Username}, " &
                                        $"{tUser.P_UserPassword}, " &
                                        $"{tUser.P_UserIsLocked}, " &
                                        $"{tUser.P_UserIsRoot}, " &
                                        "(select now()))")

                        If uac IsNot Nothing Then
                            For Each varEachRow As DataGridViewRow In uac.Rows
                                With dataproperties.AllParameters
                                    .Remove(tModule.P_ModuleCode)
                                    .Add(tModule.P_ModuleCode, Safe(varEachRow.Cells(tModule.C_ModuleCode).Value))
                                    .Remove(tUserAccess.P_UserAccessView)
                                    .Add(tUserAccess.P_UserAccessView, Safe(varEachRow.Cells(tUserAccess.C_UserAccessView).Value))
                                    .Remove(tUserAccess.P_UserAccessAdd)
                                    .Add(tUserAccess.P_UserAccessAdd, Safe(varEachRow.Cells(tUserAccess.C_UserAccessAdd).Value))
                                    .Remove(tUserAccess.P_UserAccessEdit)
                                    .Add(tUserAccess.P_UserAccessEdit, Safe(varEachRow.Cells(tUserAccess.C_UserAccessEdit).Value))
                                    .Remove(tUserAccess.P_UserAccessDelete)
                                    .Add(tUserAccess.P_UserAccessDelete, Safe(varEachRow.Cells(tUserAccess.C_UserAccessDelete).Value))
                                    .Remove(tUserAccess.P_UserAccessReports)
                                    .Add(tUserAccess.P_UserAccessReports, Safe(varEachRow.Cells(tUserAccess.C_UserAccessReports).Value))
                                End With

                                sb.AppendFormat($"insert into {tUserAccess.TableName}(" &
                                                $"{tUserAccess.C_UserAccessUser}, " &
                                                $"{tUserAccess.C_UserAccessModule}, " &
                                                $"{tUserAccess.C_UserAccessView}, " &
                                                $"{tUserAccess.C_UserAccessAdd}, " &
                                                $"{tUserAccess.C_UserAccessEdit}, " &
                                                $"{tUserAccess.C_UserAccessDelete}, " &
                                                $"{tUserAccess.C_UserAccessReports} " &
                                                $") values (" &
                                                $"{tUser.P_UserId}, " &
                                                $"(select mo.{tModule.C_ModuleId} from {tModule.TableName} mo where mo.{tModule.C_ModuleCode} = {tModule.P_ModuleCode}), " &
                                                $"{tUserAccess.P_UserAccessView}, " &
                                                $"{tUserAccess.P_UserAccessAdd}, " &
                                                $"{tUserAccess.P_UserAccessEdit}, " &
                                                $"{tUserAccess.P_UserAccessDelete}, " &
                                                $"{tUserAccess.P_UserAccessReports})")
                            Next
                        End If
                    Else
                        If dataproperties.UserAccessIsPasswordChanged Then
                            sb.AppendFormat($"update {tUser.TableName} set " &
                                            $"{tUser.C_UserUsername} = {tUser.P_Username}, " &
                                            $"{tUser.C_UserPassword} = {tUser.P_UserPassword}, " &
                                            $"{tUser.C_UserIsLocked} = {tUser.P_UserIsLocked}, " &
                                            $"{tUser.C_UserIsRoot} = {tUser.P_UserIsRoot} " &
                                            $"where {tUser.C_UserId} = {tUser.P_UserId}")
                        Else
                            sb.AppendFormat($"update {tUser.TableName} set " &
                                            $"{tUser.C_UserUsername} = {tUser.P_Username}, " &
                                            $"{tUser.C_UserIsLocked} = {tUser.P_UserIsLocked}, " &
                                            $"{tUser.C_UserIsRoot} = {tUser.P_UserIsRoot} " &
                                            $"where {tUser.C_UserId} = {tUser.P_UserId}")
                        End If

                        If uac IsNot Nothing Then
                            For Each varEachRow As DataGridViewRow In uac.Rows
                                With dataproperties.AllParameters
                                    .Remove(tModule.P_ModuleCode)
                                    .Add(tModule.P_ModuleCode, Safe(varEachRow.Cells(tModule.C_ModuleCode).Value))
                                    .Remove(tUserAccess.P_UserAccessView)
                                    .Add(tUserAccess.P_UserAccessView, Safe(varEachRow.Cells(tUserAccess.C_UserAccessView).Value))
                                    .Remove(tUserAccess.P_UserAccessAdd)
                                    .Add(tUserAccess.P_UserAccessAdd, Safe(varEachRow.Cells(tUserAccess.C_UserAccessAdd).Value))
                                    .Remove(tUserAccess.P_UserAccessEdit)
                                    .Add(tUserAccess.P_UserAccessEdit, Safe(varEachRow.Cells(tUserAccess.C_UserAccessEdit).Value))
                                    .Remove(tUserAccess.P_UserAccessDelete)
                                    .Add(tUserAccess.P_UserAccessDelete, Safe(varEachRow.Cells(tUserAccess.C_UserAccessDelete).Value))
                                    .Remove(tUserAccess.P_UserAccessReports)
                                    .Add(tUserAccess.P_UserAccessReports, Safe(varEachRow.Cells(tUserAccess.C_UserAccessReports).Value))
                                    .Remove(tUserAccess.P_UserAccessId)
                                    .Add(tUserAccess.P_UserAccessId, Safe(varEachRow.Cells(tUserAccess.C_UserAccessId).Value))
                                End With

                                varDatabaseRequestMysql(3).Query = $"select count(uac.{tUserAccess.C_UserAccessId}) as `useraccess_id` " &
                                                                   $"from {tUserAccess.TableName} uac " &
                                                                   $"inner join {tModule.TableName} mo " &
                                                                   $"on mo.{tModule.C_ModuleId} = uac.{tUserAccess.C_UserAccessModule} " &
                                                                   $"where uac.{tUserAccess.C_UserAccessUser} = {tUser.P_UserId} and " &
                                                                   $"mo.{tModule.C_ModuleCode} = {tModule.P_ModuleCode}"
                                Dim varIsExist = CInt(varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(3).Query))

                                If varIsExist = 0 Then
                                    sb.AppendFormat($"insert into {tUserAccess.TableName}(" &
                                                    $"{tUserAccess.C_UserAccessUser}, " &
                                                    $"{tUserAccess.C_UserAccessModule}, " &
                                                    $"{tUserAccess.C_UserAccessView}, " &
                                                    $"{tUserAccess.C_UserAccessAdd}, " &
                                                    $"{tUserAccess.C_UserAccessEdit}, " &
                                                    $"{tUserAccess.C_UserAccessDelete}, " &
                                                    $"{tUserAccess.C_UserAccessReports}" &
                                                    $") values (" &
                                                    $"{tUser.P_UserId}, " &
                                                    $"(select mo.{tModule.C_ModuleId} from {tModule.TableName} mo where mo.{tModule.C_ModuleCode} = {tModule.P_ModuleCode}), " &
                                                    $"{tUserAccess.P_UserAccessView}, " &
                                                    $"{tUserAccess.P_UserAccessAdd}, " &
                                                    $"{tUserAccess.P_UserAccessEdit}, " &
                                                    $"{tUserAccess.P_UserAccessDelete}, " &
                                                    $"{tUserAccess.P_UserAccessReports})")
                                Else
                                    sb.AppendFormat($"update {tUserAccess.TableName} set " &
                                                    $"{tUserAccess.C_UserAccessView} = {tUserAccess.P_UserAccessView}, " &
                                                    $"{tUserAccess.C_UserAccessAdd} = {tUserAccess.P_UserAccessAdd}, " &
                                                    $"{tUserAccess.C_UserAccessEdit} = {tUserAccess.P_UserAccessEdit}, " &
                                                    $"{tUserAccess.C_UserAccessDelete} = {tUserAccess.P_UserAccessDelete}, " &
                                                    $"{tUserAccess.C_UserAccessReports} = {tUserAccess.P_UserAccessReports} " &
                                                    $"where {tUserAccess.C_UserAccessId} = {tUserAccess.P_UserAccessId}")
                                End If
                            Next
                        End If
                    End If

                    varDatabaseRequestMysql(1).Query = sb.ToString()
                    varDatabaseEngineMysql.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query, dataproperties.AllParameters)
                    varSuccess = True
                End If
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function

#Region "Obsolete Function/Routine"
        'Public Shared Function PushData(dataproperties As LibApp.Ingrid.Global.Properties, employeeid As String, username As String, password As String, locked As Boolean, administrator As Boolean, uac As cmcv.ui.control.dgn, Optional rowid As String = "-1", Optional hash As String = "", Optional ispasswordchange As Boolean = False) As Boolean
        '    Dim varSuccess As Boolean = False

        '    Try
        '        Dim varExtendedQuery As String = String.Empty

        '        If dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
        '            ReDim varDatabaseRequestMssql2008(4)

        '            If rowid = "-1" Then
        '                varDatabaseRequestMssql2008(1).Query = String.Format("insert into dbo.sys_user(user_id, user_employee, user_username, user_password, user_locked, user_root, user_datecreated) " &
        '                                                        "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', (select getdate()));", hash, employeeid, username, password, locked, administrator)


        '                For Each varEachRow As DataGridViewRow In uac.Rows
        '                    varExtendedQuery = String.Format("insert into dbo.[[sys]]useraccess](useraccess_id, useraccess_user, useraccess_module, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports) " &
        '                                            "values('{0}', '{1}', (select mo.module_id from dbo.sys_module mo " &
        '                                            "where mo.module_code = '{2}'), '{3}', '{4}', '{5}', '{6}', '{7}');", CMCv.Security.Encrypt.MD5(), hash, varEachRow.Cells("module_code").Value, varEachRow.Cells("useraccess_view").Value, varEachRow.Cells("useraccess_add").Value, varEachRow.Cells("useraccess_edit").Value, varEachRow.Cells("useraccess_delete").Value, varEachRow.Cells("useraccess_reports").Value)
        '                    varDatabaseRequestMssql2008(1).Query += varExtendedQuery
        '                Next

        '            Else
        '                If (ispasswordchange) Then
        '                    varDatabaseRequestMssql2008(1).Query = String.Format("update dbo.sys_user set user_username = '{0}', user_password = '{1}', user_locked = '{2}', user_root = '{3}' where user_id = '{4}';", username, password, locked, administrator, rowid)
        '                Else
        '                    varDatabaseRequestMssql2008(1).Query = String.Format("update dbo.sys_user set user_username = '{0}', user_locked = '{1}', user_root = '{2}' where user_id = '{3}';", username, locked, administrator, rowid)
        '                End If

        '                Dim varIsExist As Integer = 0
        '                For Each varEachRow As DataGridViewRow In uac.Rows
        '                    varDatabaseRequestMssql2008(3).Query = String.Format("select count(uac.useraccess_id) as [useraccess_id] from dbo.[[sys]]useraccess] uac inner join dbo.sys_module mo on mo.module_id = uac.useraccess_module " &
        '                                                            "where uac.useraccess_user = '{0}' and mo.module_code = '{1}'", rowid, varEachRow.Cells("module_code").Value)
        '                    varIsExist = CType(varDatabaseEngineMssql2008.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(3).Query), Integer)

        '                    If varIsExist = 0 Then
        '                        varExtendedQuery = String.Format("insert into dbo.[[sys]]useraccess](useraccess_id, useraccess_user, useraccess_module, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports) " &
        '                                                "values('{0}', '{1}', (select mo.module_id from dbo.sys_module mo " &
        '                                                "where mo.module_code = '{2}'), '{3}', '{4}', '{5}', '{6}', '{7}');", CMCv.Security.Encrypt.MD5(), rowid, varEachRow.Cells("module_code").Value, varEachRow.Cells("useraccess_view").Value, varEachRow.Cells("useraccess_add").Value, varEachRow.Cells("useraccess_edit").Value, varEachRow.Cells("useraccess_delete").Value, varEachRow.Cells("useraccess_reports").Value)
        '                    Else
        '                        varExtendedQuery = String.Format("update dbo.[[sys]]useraccess] set useraccess_view = '{0}', useraccess_add = '{1}', useraccess_edit = '{2}', useraccess_delete = '{3}', useraccess_reports = '{5}' " &
        '                                                "where useraccess_id = '{4}';", varEachRow.Cells("useraccess_view").Value, varEachRow.Cells("useraccess_add").Value, varEachRow.Cells("useraccess_edit").Value, varEachRow.Cells("useraccess_delete").Value, varEachRow.Cells("useraccess_id").Value, varEachRow.Cells("useraccess_reports").Value)
        '                    End If
        '                    varDatabaseRequestMssql2008(1).Query += varExtendedQuery
        '                Next
        '            End If
        '            varDatabaseEngineMssql2008.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(1).Query)
        '            varSuccess = True
        '        ElseIf dataproperties.ConnectionDatabaseEngineE = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
        '            ReDim varDatabaseRequestMysql(4)

        '            If rowid = "-1" Then
        '                varDatabaseRequestMysql(1).Query = $"insert into sys_user(user_id, user_employee, user_username, user_password, user_locked, user_root, user_datecreated) " &
        '                                                   $"values ('{hash}', '{employeeid}', '{username}', '{password}', '{locked}', '{administrator}', (select now()))"

        '                For Each eachRow As DataGridViewRow In uac.Rows
        '                    varExtendedQuery = $"insert into sys_useraccess(useraccess_id, useraccess_user, useraccess_module, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports) " &
        '                                       $"values('{CMCv.Security.Encrypt.MD5()}', '{hash}', (select mo.module_id from sys_module mo " &
        '                                       $"where mo.module_code = '{eachRow.Cells("module_code").Value}'), '{eachRow.Cells("useraccess_view").Value}', '{eachRow.Cells("useraccess_add").Value}', " &
        '                                       $"'{eachRow.Cells("useraccess_edit").Value}', '{eachRow.Cells("useraccess_delete").Value}', '{eachRow.Cells("useraccess_reports").Value}')"
        '                    varDatabaseRequestMysql(1).Query += varExtendedQuery
        '                Next
        '            Else
        '                If (ispasswordchange) Then
        '                    varDatabaseRequestMysql(1).Query = $"update sys_user set user_username = '{username}', user_password = '{password}', user_locked = '{locked}', user_root = '{administrator}' where user_id = '{rowid}'"
        '                Else
        '                    varDatabaseRequestMysql(1).Query = $"update sys_user set user_username = '{username}', user_locked = '{locked}', user_root = '{administrator}' where user_id = '{rowid}'"
        '                End If

        '                Dim varIsExist As Integer = 0
        '                For Each eachRow As DataGridViewRow In uac.Rows
        '                    varDatabaseRequestMysql(3).Query = $"select count(uac.useraccess_id) as `useraccess_id` from sys_useraccess uac inner join sys_module mo on mo.module_id = uac.useraccess_module " &
        '                                                       $"where uac.useraccess_user = '{rowid}' and mo.module_code = '{eachRow.Cells("module_code").Value}'"
        '                    varIsExist = CType(varDatabaseEngineMysql.GetValue(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(3).Query), Integer)

        '                    If varIsExist = 0 Then
        '                        varExtendedQuery = $"insert into sys_useraccess(useraccess_id, useraccess_user, useraccess_module, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports) " &
        '                                           $"values('{CMCv.Security.Encrypt.MD5()}', '{rowid}', (select mo.module_id from sys_module mo " &
        '                                           $"where mo.module_code = '{eachRow.Cells("module_code").Value}'), '{eachRow.Cells("useraccess_view").Value}', '{eachRow.Cells("useraccess_add").Value}', '{eachRow.Cells("useraccess_edit").Value}', '{eachRow.Cells("useraccess_delete").Value}', '{eachRow.Cells("useraccess_reports").Value}')"
        '                    Else
        '                        varExtendedQuery = $"update sys_useraccess set useraccess_view = '{eachRow.Cells("useraccess_view").Value}', useraccess_add = '{eachRow.Cells("useraccess_add").Value}', useraccess_edit = '{eachRow.Cells("useraccess_edit").Value}', useraccess_delete = '{eachRow.Cells("useraccess_delete").Value}', useraccess_reports = '{eachRow.Cells("useraccess_reports").Value}' " &
        '                                           $"where useraccess_id = '{eachRow.Cells("useraccess_id").Value}'"
        '                    End If
        '                    varDatabaseRequestMysql(1).Query += varExtendedQuery
        '                Next
        '            End If
        '            varDatabaseEngineMysql.PushData(dataproperties.ConnectionDatabaseName, varDatabaseRequestMysql(1).Query)
        '            varSuccess = True
        '        End If
        '    Catch ex As Exception
        '        varSuccess = False
        '    End Try
        '    Return varSuccess
        'End Function
#End Region
    End Class
End Namespace
