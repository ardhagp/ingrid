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
        Public Shared Function GetUserID(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, username As String, password As String, Optional additionalfield As Object = Nothing) As String
            Dim varUserID As String = String.Empty
            Dim varExist As Integer
            Try
                If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then 'Run if MSSQL
                    varDatabaseRequestMssql2008(1).Query = String.Format("select count(usr.user_id) as [user_id] from dbo.sys_user usr where (usr.user_username = '{0}') and (usr.user_password = '{1}')", username, CMCv.Security.Encrypt.MD5(password))
                    varExist = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query), Integer)

                    If varExist = 0 Then
                        varUserID = String.Empty
                    Else
                        varDatabaseRequestMssql2008(1).Query = String.Format("select usr.user_id from dbo.sys_user usr where (usr.user_username = '{0}') and (usr.user_password = '{1}')", username, CMCv.Security.Encrypt.MD5(password))
                        varUserID = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString

                        varDatabaseRequestMssql2008(1).Query = String.Format("update dbo.sys_user set user_lastlogin = getdate() where user_id = '{0}'", varUserID)
                        varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(1).Query)
                    End If
                ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then 'Run if MYSQL
                    varDatabaseRequestMysql(1).Query = String.Format("select count(usr.user_id) as user_id from sys_user usr where (usr.user_username = '{0}') and (usr.user_password = '{1}')", username, CMCv.Security.Encrypt.MD5(password))
                    varExist = CType(varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query), Integer)

                    If varExist = 0 Then
                        varUserID = String.Empty
                    Else
                        varDatabaseRequestMysql(1).Query = String.Format("select usr.user_id from sys_user usr where (usr.user_username = '{0}') and (usr.user_password = '{1}')", username, CMCv.Security.Encrypt.MD5(password))
                        varUserID = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query).ToString

                        varDatabaseRequestMysql(1).Query = String.Format("update sys_user set user_lastlogin = getdate() where user_id = '{0}'", varUserID)
                        varDatabaseEngineMysql.PushData(databasename, varDatabaseRequestMysql(1).Query)
                    End If
                End If
            Catch ex As Exception
                varUserID = String.Empty
            End Try
            Return varUserID
        End Function

        ''' <summary>
        ''' Get Employee ID
        ''' </summary>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GetEmployeeID(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, uid As String) As String
            Dim varEmployeeID As String

            Try
                varEmployeeID = String.Empty

                If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then 'Run if MSSQL
                    varDatabaseRequestMssql2008(1).Query = String.Format("select usr.user_employee from dbo.sys_user usr where usr.user_id = '{0}';", uid)
                    varEmployeeID = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString
                ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then 'Run if MYSQL
                    varDatabaseRequestMysql(1).Query = String.Format("select usr.user_employee from sys_user usr where usr.user_id = '{0}';", uid)
                    varEmployeeID = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query).ToString
                End If
            Catch ex As Exception
                varEmployeeID = String.Empty
            End Try
            Return varEmployeeID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetFirstName(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, uid As String) As String
            Dim varFullName As String = String.Empty

            Try
                If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then 'Run if MSSQL
                    varDatabaseRequestMssql2008(1).Query = String.Format("select emp.employee_fullname from dbo.sys_user usr inner join dbo.man_employee emp on emp.employee_id = usr.user_employee where (usr.[user_id] = '{0}')", uid)
                    varFullName = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString
                ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then 'Run if MYSQL
                    varDatabaseRequestMysql(1).Query = String.Format("select emp.employee_fullname from sys_user usr inner join man_employee emp on emp.employee_id = usr.user_employee where (usr.user_id = '{0}')", uid)
                    varFullName = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query).ToString
                End If
            Catch ex As Exception
                varFullName = String.Empty
            End Try
            Return varFullName
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetLastName(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, uid As String) As String
            Dim varFullName As String = String.Empty

            Try
                If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then 'Run if MSSQL
                    varDatabaseRequestMssql2008(1).Query = String.Format("select emp.employee_fullname from dbo.sys_user usr inner join dbo.man_employee emp on emp.employee_id = usr.user_employee where (usr.[user_id] = '{0}')", uid)
                    varFullName = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString
                ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then 'Run if MYSQL
                    varDatabaseRequestMysql(1).Query = String.Format("select emp.employee_fullname from sys_user usr inner join man_employee emp on emp.employee_id = usr.user_employee where (usr.user_id = '{0}')", uid)
                    varFullName = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query).ToString
                End If
            Catch ex As Exception
                varFullName = String.Empty
            End Try
            Return varFullName
        End Function

        ''' <summary>
        ''' Get Company Employee Number ID
        ''' </summary>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GetEmployeeNumber(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, uid As String) As String
            Dim varEmployeeNumber As String = String.Empty

            Try
                If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then 'Run if MSSQL
                    varDatabaseRequestMssql2008(1).Query = String.Format("select emp.employee_number from dbo.sys_user usr inner join dbo.man_employee emp on emp.employee_id = usr.user_employee where (usr.[user_id] = '{0}')", uid)
                    varEmployeeNumber = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString
                ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then 'Run if MYSQL
                    varDatabaseRequestMysql(1).Query = String.Format("select emp.employee_number from sys_user usr inner join man_employee emp on emp.employee_id = usr.user_employee where (usr.[user_id] = '{0}')", uid)
                    varEmployeeNumber = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query).ToString
                End If
            Catch ex As Exception
                varEmployeeNumber = String.Empty
            End Try
            Return varEmployeeNumber
        End Function

        ''' <summary>
        ''' Get Employee Gender
        ''' </summary>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GetGender(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, uid As String) As String
            Dim varEmployeeNumber As String = String.Empty

            Try
                If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then 'Run if MSSQL
                    varDatabaseRequestMssql2008(1).Query = String.Format("select emp.employee_gender from dbo.sys_user usr inner join dbo.man_employee emp on emp.employee_id = usr.user_employee where (usr.[user_id] = '{0}')", uid)
                    varEmployeeNumber = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString
                ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then 'Run if MYSQL
                    varDatabaseRequestMysql(1).Query = String.Format("select emp.employee_gender from sys_user usr inner join man_employee emp on emp.employee_id = usr.user_employee where (usr.user_id = '{0}')", uid)
                    varEmployeeNumber = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query).ToString
                End If
            Catch ex As Exception
                varEmployeeNumber = "MALE"
            End Try
            Return varEmployeeNumber
        End Function

        ''' <summary>
        ''' Get Employee Position
        ''' </summary>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GetPosition(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, uid As String) As String
            Dim varEmployeeNumber As String = String.Empty

            Try
                If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then 'Run if MSSQL
                    varDatabaseRequestMssql2008(1).Query = String.Format("select p.position_name from dbo.sys_user usr inner join dbo.man_employee emp on emp.employee_id = usr.user_employee " &
                                                        "inner join dbo.man_position p on p.position_id = emp.employee_position where (usr.[user_id] = '{0}')", uid)
                    varEmployeeNumber = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString
                ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then 'Run if MYSQL
                    varDatabaseRequestMysql(1).Query = String.Format("select p.position_name from sys_user usr inner join man_employee emp on emp.employee_id = usr.user_employee " &
                                                        "inner join man_position p on p.position_id = emp.employee_position where (usr.user_id = '{0}')", uid)
                    varEmployeeNumber = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query).ToString
                End If
            Catch ex As Exception
                varEmployeeNumber = "#ERROR"
            End Try
            Return varEmployeeNumber
        End Function

        ''' <summary>
        ''' Get Employee Authorization
        ''' </summary>
        ''' <param name="AuthType"></param>
        ''' <param name="SysModule"></param>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GetAccess(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, authtype As EnuAuthType, sysmodule As String, uid As Integer) As Boolean
            Dim varIsAuth As Integer

            If authtype = EnuAuthType.Read Then
                'TODO: Read method
            ElseIf authtype = EnuAuthType.Write Then
                'TODO: Write method
            ElseIf authtype = EnuAuthType.Execute Then
                'TODO: Execute method
            End If

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then 'Run if MSSQL
                varDatabaseRequestMssql2008(0).Query = ""
                varIsAuth = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Integer)
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then 'Run if MYSQL
                varDatabaseRequestMysql(0).Query = ""
                varIsAuth = CType(varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(0).Query), Integer)
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
        Public Function GetPhoto(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, uid As String) As System.Drawing.Image
            'TODO: To be moved into cloud storage

            Dim varUserID As String = uid
            Dim varPhoto As System.Drawing.Image = Nothing
            Dim varFileStream As IO.FileStream = Nothing

            Try
                If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(0).Query = String.Format("SELECT f.file_content FROM db_universe_erp_file.dbo.sto_file f where f.file_tag = 'EMPLOYEE-PROFILE-PHOTO' and f.file_parent = '{0}' ;", varUserID)
                    varFileStream = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), FileStream)
                ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(0).Query = String.Format("SELECT f.file_content FROM db_universe_erp_file.dbo.sto_file f where f.file_tag = 'EMPLOYEE-PROFILE-PHOTO' and f.file_parent = '{0}' ;", varUserID)
                    varFileStream = CType(varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(0).Query), FileStream)
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
        Public Shared Function GetAdministrator(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, uid As String) As Boolean
            Dim varIsAdministrator As Boolean = False

            Try
                If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then 'Run if MSSQL
                    varDatabaseRequestMssql2008(0).Query = String.Format("select u.user_root from dbo.sys_user u where u.user_id = '{0}'", uid)
                    varIsAdministrator = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Boolean)
                ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then 'Run if MYSQL
                    varDatabaseRequestMysql(0).Query = String.Format("select u.user_root from sys_user u where u.user_id = '{0}'", uid)
                    varIsAdministrator = CType(varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(0).Query), Boolean)
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
        Public Shared Sub DisplayData(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, datagrid As dgn, statusbar As stt, find As txt, Optional forcerefresh As Boolean = False)
            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then 'Run if MSSQL
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
                varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(0), "TUAC")
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then 'Run in MYSQL
                If (find.XOSQLText = String.Empty) OrElse (forcerefresh) Then
                    varDatabaseRequestMysql(0).Query = String.Format("select usr.user_id, em.employee_number, em.employee_fullname, usr.user_username, iif(usr.user_root=1,'Administrator','') as `user_root`, usr.user_lastlogin, " &
                                                            "usr.user_locked from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee order by em.employee_fullname")
                Else
                    varDatabaseRequestMysql(0).Query = String.Format("select usr.user_id, em.employee_number, em.employee_fullname, usr.user_username, iif(usr.user_root=1,'Administrator','') as `user_root`, usr.user_lastlogin, " &
                                                            "usr.user_locked from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where (em.employee_number = '{0}') or " &
                                                            "(em.employee_fullname like '%{0}%') or (usr.user_username = '{0}') order by em.employee_fullname", find.XOSQLText)
                End If
                varDatabaseRequestMysql(0).DataGrid = datagrid
                varDatabaseRequestMysql(0).StatusBar = statusbar
                varDatabaseEngineMysql.GetDataTable(databasename, varDatabaseRequestMysql(0), "TUAC")
            End If
        End Sub

        ''' <summary>
        ''' Delete Data From UAC
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function DeleteData(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, rowid As String) As Boolean
            Dim varSuccess As Boolean
            Try
                If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then 'Run if MSSQL
                    varDatabaseRequestMssql2008(1).Query = String.Format("delete from dbo.sys_user where (user_id = '{0}')", rowid)
                    varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(1).Query)
                ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then 'Run if MYSQL
                    varDatabaseRequestMysql(1).Query = String.Format("delete from sys_user where (user_id = '{0}')", rowid)
                    varDatabaseEngineMysql.PushData(databasename, varDatabaseRequestMysql(1).Query)
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
        Public Shared Sub DisplayData(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, grid As dgn, Optional rowid As String = "-1")
            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
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
                varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(2), "TUserAccess")
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                ReDim varDatabaseRequestMysql(2)

                If rowid = "-1" Then
                    varDatabaseRequestMysql(2).Query = String.Format("select mog.modulegroup_name, mo.module_code, 0 as [useraccess_view], 0 as [useraccess_add], 0 as [useraccess_edit], 0 as [useraccess_delete], " &
                                                            "0 as [useraccess_reports], '' as [useraccess_id], mo.module_id from sys_module mo inner join sys_modulegroup mog " &
                                                            "on mog.modulegroup_id = mo.module_modulegroup order by mog.modulegroup_order, mo.module_code")
                Else
                    varDatabaseRequestMysql(2).Query = String.Format("select mog.modulegroup_name, mo.module_code, (select uac1.useraccess_view from sys_useraccess uac1 inner join sys_module mo1 " &
                                                            "on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{0}' and mo1.module_code = mo.module_code) as [useraccess_view], (select uac1.useraccess_add " &
                                                            "from sys_useraccess uac1 inner join sys_module mo1 on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{0}' and " &
                                                            "mo1.module_code = mo.module_code) as [useraccess_add], (select uac1.useraccess_edit from sys_useraccess uac1 inner join sys_module mo1 " &
                                                            "on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{0}' and mo1.module_code = mo.module_code) as [useraccess_edit], " &
                                                            "(select uac1.useraccess_delete from sys_useraccess uac1 inner join sys_module mo1 on mo1.module_id = uac1.useraccess_module " &
                                                            "where uac1.useraccess_user = '{0}' and mo1.module_code = mo.module_code) as [useraccess_delete], (select uac1.useraccess_reports from sys_useraccess uac1 " &
                                                            "inner join sys_module mo1 on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{0}' and " &
                                                            "mo1.module_code = mo.module_code) as [useraccess_reports], (select uac1.useraccess_id from sys_useraccess uac1 inner join sys_module mo1 " &
                                                            "on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{0}' and mo1.module_code = mo.module_code) as [useraccess_id], mo.module_id " &
                                                            "from sys_module mo inner join sys_modulegroup mog on mog.modulegroup_id = mo.module_modulegroup order by mog.modulegroup_order, mo.module_code", rowid)
                End If

                varDatabaseRequestMysql(2).DataGrid = grid
                varDatabaseEngineMysql.GetDataTable(databasename, varDatabaseRequestMysql(2), "TUserAccess")
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function GetUIDbyEmployeeID(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, employeeid As String) As String
            Dim varUserID As String = String.Empty

            Try
                If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                    varDatabaseRequestMssql2008(1).Query = String.Format("select usr.user_id from dbo.sys_user usr where usr.user_employee = '{0}';", employeeid)

                    varUserID = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString
                    IIf(IsDBNull(varUserID), "", varUserID)
                ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                    varDatabaseRequestMysql(1).Query = String.Format("select usr.user_id from sys_user usr where usr.user_employee = '{0}';", employeeid)

                    varUserID = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query).ToString
                    IIf(IsDBNull(varUserID), "", varUserID)
                End If
            Catch ex As Exception
                varUserID = Nothing
            End Try
            Return varUserID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetEmployeeNumber(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, userid As String) As String
            Dim varEmployeeNumber As String = String.Empty

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_number from dbo.sys_user usr inner join dbo.man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varEmployeeNumber = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = String.Format("select em.employee_number from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varEmployeeNumber = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query).ToString
            End If
            Return varEmployeeNumber
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetEmployeeFullName(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, userid As String) As String
            Dim varEmployeeFullName As String = String.Empty

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select em.employee_fullname from dbo.sys_user usr inner join dbo.man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varEmployeeFullName = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = String.Format("select em.employee_fullname from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varEmployeeFullName = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query).ToString
            End If

            Return varEmployeeFullName
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetUsernameByUserID(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, ByVal userid As String) As String
            Dim varUsername As String = String.Empty

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select usr.user_username from dbo.sys_user usr inner join dbo.man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varUsername = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = String.Format("select usr.user_username from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varUsername = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query).ToString
            End If

            Return varUsername
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetUsernameByEmployeeID(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, employeeid As String) As String
            Dim varUsername As String = String.Empty

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select usr.user_username from dbo.sys_user usr where usr.user_employee = '{0}'", employeeid)

                varUsername = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = String.Format("select usr.user_username from sys_user usr where usr.user_employee = '{0}'", employeeid)

                varUsername = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query).ToString
            End If

            Return varUsername
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetPassword(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, userid As String) As String
            Dim varPassword As String = String.Empty

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select usr.user_password from dbo.sys_user usr inner join dbo.man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varPassword = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query).ToString
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = String.Format("select usr.user_password from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varPassword = varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query).ToString
            End If

            Return varPassword
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetLocked(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, userid As String) As Boolean
            Dim varLocked As Boolean = True

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select usr.user_locked from dbo.sys_user usr inner join dbo.man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varLocked = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query), Boolean)
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = String.Format("select usr.user_locked from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varLocked = CType(varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query), Boolean)
            End If

            Return varLocked
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetAdministrator(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, userid As String) As Boolean
            Dim varRoot As Boolean = False

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select usr.user_root from dbo.sys_user usr inner join dbo.man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varRoot = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query), Boolean)
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                varDatabaseRequestMysql(1).Query = String.Format("select usr.user_root from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varRoot = CType(varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(1).Query), Boolean)
            End If

            Return varRoot
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, username As String, Optional rowid As String = "-1") As Boolean
            Dim varIsDuplicate As Integer

            If rowid = "-1" AndAlso dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select count(usr.user_id) as [user_id] from dbo.sys_user usr where (usr.user_username = '{0}')", username)
            ElseIf rowid <> "-1" AndAlso dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varDatabaseRequestMssql2008(1).Query = String.Format("select count(usr.user_id) as [user_id] from dbo.sys_user usr where (usr.user_username = '{0}') and (usr.user_id <> '{1}')", username, rowid)
            End If

            If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then
                varIsDuplicate = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query), Integer)
            ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then
                'TODO: MYSQL version
            End If

            If varIsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PushData(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, employeeid As String, username As String, password As String, locked As Boolean, administrator As Boolean, uac As dgn, Optional rowid As String = "-1", Optional hash As String = "", Optional ispasswordchange As Boolean = False) As Boolean
            Dim varSuccess As Boolean = False

            Try
                Dim varExtendedQuery As String = String.Empty

                If dbengine = LibApp.Ingrid.Global.DatabaseEngine.MSSQL Then 'Run if MSSQL
                    ReDim varDatabaseRequestMssql2008(4)

                    If rowid = "-1" Then
                        varDatabaseRequestMssql2008(1).Query = String.Format("insert into dbo.sys_user(user_id, user_employee, user_username, user_password, user_locked, user_root, user_datecreated) " &
                                                                "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', (select getdate()));", hash, employeeid, username, password, locked, administrator)


                        For Each varEachRow As DataGridViewRow In uac.Rows
                            varExtendedQuery = String.Format("insert into dbo.[[sys]]useraccess](useraccess_id, useraccess_user, useraccess_module, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports) " &
                                                    "values('{0}', '{1}', (select mo.module_id from dbo.sys_module mo " &
                                                    "where mo.module_code = '{2}'), '{3}', '{4}', '{5}', '{6}', '{7}');", CMCv.Security.Encrypt.MD5(), hash, varEachRow.Cells("module_code").Value, varEachRow.Cells("useraccess_view").Value, varEachRow.Cells("useraccess_add").Value, varEachRow.Cells("useraccess_edit").Value, varEachRow.Cells("useraccess_delete").Value, varEachRow.Cells("useraccess_reports").Value)
                            varDatabaseRequestMssql2008(1).Query += varExtendedQuery
                        Next

                    Else
                        If (ispasswordchange) Then
                            varDatabaseRequestMssql2008(1).Query = String.Format("update dbo.sys_user set user_username = '{0}', user_password = '{1}', user_locked = '{2}', user_root = '{3}' where user_id = '{4}';", username, password, locked, administrator, rowid)
                        Else
                            varDatabaseRequestMssql2008(1).Query = String.Format("update dbo.sys_user set user_username = '{0}', user_locked = '{1}', user_root = '{2}' where user_id = '{3}';", username, locked, administrator, rowid)
                        End If

                        Dim varIsExist As Integer = 0
                        For Each varEachRow As DataGridViewRow In uac.Rows
                            varDatabaseRequestMssql2008(3).Query = String.Format("select count(uac.useraccess_id) as [useraccess_id] from dbo.[[sys]]useraccess] uac inner join dbo.sys_module mo on mo.module_id = uac.useraccess_module " &
                                                                    "where uac.useraccess_user = '{0}' and mo.module_code = '{1}'", rowid, varEachRow.Cells("module_code").Value)
                            varIsExist = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(3).Query), Integer)

                            If varIsExist = 0 Then
                                varExtendedQuery = String.Format("insert into dbo.[[sys]]useraccess](useraccess_id, useraccess_user, useraccess_module, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports) " &
                                                        "values('{0}', '{1}', (select mo.module_id from dbo.sys_module mo " &
                                                        "where mo.module_code = '{2}'), '{3}', '{4}', '{5}', '{6}', '{7}');", CMCv.Security.Encrypt.MD5(), rowid, varEachRow.Cells("module_code").Value, varEachRow.Cells("useraccess_view").Value, varEachRow.Cells("useraccess_add").Value, varEachRow.Cells("useraccess_edit").Value, varEachRow.Cells("useraccess_delete").Value, varEachRow.Cells("useraccess_reports").Value)
                            Else
                                varExtendedQuery = String.Format("update dbo.[[sys]]useraccess] set useraccess_view = '{0}', useraccess_add = '{1}', useraccess_edit = '{2}', useraccess_delete = '{3}', useraccess_reports = '{5}' " &
                                                        "where useraccess_id = '{4}';", varEachRow.Cells("useraccess_view").Value, varEachRow.Cells("useraccess_add").Value, varEachRow.Cells("useraccess_edit").Value, varEachRow.Cells("useraccess_delete").Value, varEachRow.Cells("useraccess_id").Value, varEachRow.Cells("useraccess_reports").Value)
                            End If
                            varDatabaseRequestMssql2008(1).Query += varExtendedQuery
                        Next
                    End If
                    varDatabaseEngineMssql2008.PushData(databasename, varDatabaseRequestMssql2008(1).Query)
                    varSuccess = True

                ElseIf dbengine = LibApp.Ingrid.Global.DatabaseEngine.MYSQL Then 'Run if MYSQL
                    ReDim varDatabaseRequestMysql(4)

                    If rowid = "-1" Then
                        varDatabaseRequestMysql(1).Query = String.Format("insert into sys_user(user_id, user_employee, user_username, user_password, user_locked, user_root, user_datecreated) " &
                                                                "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', (select getdate()));", hash, employeeid, username, password, locked, administrator)


                        For Each varEachRow As DataGridViewRow In uac.Rows
                            varExtendedQuery = String.Format("insert into sys_useraccess(useraccess_id, useraccess_user, useraccess_module, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports) " &
                                                    "values('{0}', '{1}', (select mo.module_id from sys_module mo " &
                                                    "where mo.module_code = '{2}'), '{3}', '{4}', '{5}', '{6}', '{7}');", CMCv.Security.Encrypt.MD5(), hash, varEachRow.Cells("module_code").Value, varEachRow.Cells("useraccess_view").Value, varEachRow.Cells("useraccess_add").Value, varEachRow.Cells("useraccess_edit").Value, varEachRow.Cells("useraccess_delete").Value, varEachRow.Cells("useraccess_reports").Value)
                            varDatabaseRequestMysql(1).Query += varExtendedQuery
                        Next

                    Else
                        If (ispasswordchange) Then
                            varDatabaseRequestMysql(1).Query = String.Format("update sys_user set user_username = '{0}', user_password = '{1}', user_locked = '{2}', user_root = '{3}' where user_id = '{4}';", username, password, locked, administrator, rowid)
                        Else
                            varDatabaseRequestMysql(1).Query = String.Format("update sys_user set user_username = '{0}', user_locked = '{1}', user_root = '{2}' where user_id = '{3}';", username, locked, administrator, rowid)
                        End If

                        Dim varIsExist As Integer = 0
                        For Each varEachRow As DataGridViewRow In uac.Rows
                            varDatabaseRequestMysql(3).Query = String.Format("select count(uac.useraccess_id) as [useraccess_id] from sys_useraccess uac inner join sys_module mo on mo.module_id = uac.useraccess_module " &
                                                                    "where uac.useraccess_user = '{0}' and mo.module_code = '{1}'", rowid, varEachRow.Cells("module_code").Value)
                            varIsExist = CType(varDatabaseEngineMysql.GetValue(databasename, varDatabaseRequestMysql(3).Query), Integer)

                            If varIsExist = 0 Then
                                varExtendedQuery = String.Format("insert into sys_useraccess(useraccess_id, useraccess_user, useraccess_module, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports) " &
                                                        "values('{0}', '{1}', (select mo.module_id from sys_module mo " &
                                                        "where mo.module_code = '{2}'), '{3}', '{4}', '{5}', '{6}', '{7}');", CMCv.Security.Encrypt.MD5(), rowid, varEachRow.Cells("module_code").Value, varEachRow.Cells("useraccess_view").Value, varEachRow.Cells("useraccess_add").Value, varEachRow.Cells("useraccess_edit").Value, varEachRow.Cells("useraccess_delete").Value, varEachRow.Cells("useraccess_reports").Value)
                            Else
                                varExtendedQuery = String.Format("update sys_useraccess set useraccess_view = '{0}', useraccess_add = '{1}', useraccess_edit = '{2}', useraccess_delete = '{3}', useraccess_reports = '{5}' " &
                                                        "where useraccess_id = '{4}';", varEachRow.Cells("useraccess_view").Value, varEachRow.Cells("useraccess_add").Value, varEachRow.Cells("useraccess_edit").Value, varEachRow.Cells("useraccess_delete").Value, varEachRow.Cells("useraccess_id").Value, varEachRow.Cells("useraccess_reports").Value)
                            End If
                            varDatabaseRequestMysql(1).Query += varExtendedQuery
                        Next
                    End If
                    varDatabaseEngineMysql.PushData(databasename, varDatabaseRequestMysql(1).Query)
                    varSuccess = True
                End If
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function
    End Class

End Namespace
