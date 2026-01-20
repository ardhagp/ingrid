Imports System
Imports System.IO
Imports System.Runtime.Versioning
Imports System.Windows.Forms
Imports CMCv

Namespace Commands.UAC

    Public Class Login
        'ReadOnly _IMG As New ImageEditor.Proccessor.Compress

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
        Public Shared Function GetUID(databasename As String, dbengine As String, username As String, password As String, Optional additionalfield As Object = Nothing) As String
            Dim varUserID As String = String.Empty
            Dim varExist As Integer = 0
            Try
                If dbengine = "MSSQL" Then 'Run if MSSQL
                    V_DBR_MSSQL2008(1).Query = String.Format("select count(usr.user_id) as [user_id] from dbo.sys_user usr where (usr.user_username = '{0}') and (usr.user_password = '{1}')", username, CMCv.Security.Encrypt.MD5(password))
                    varExist = CType(V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query), Integer)

                    If varExist = 0 Then
                        varUserID = String.Empty
                    Else
                        V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_id from dbo.sys_user usr where (usr.user_username = '{0}') and (usr.user_password = '{1}')", username, CMCv.Security.Encrypt.MD5(password))
                        varUserID = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query).ToString

                        V_DBR_MSSQL2008(1).Query = String.Format("update dbo.sys_user set user_lastlogin = getdate() where user_id = '{0}'", varUserID)
                        V_DBE_MSSQL2008.PushData(databasename, V_DBR_MSSQL2008(1).Query)
                    End If
                ElseIf dbengine = "MYSQL" Then 'Run if MYSQL
                    V_DBR_MYSQL(1).Query = String.Format("select count(usr.user_id) as user_id from sys_user usr where (usr.user_username = '{0}') and (usr.user_password = '{1}')", username, CMCv.Security.Encrypt.MD5(password))
                    varExist = CType(V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(1).Query), Integer)

                    If varExist = 0 Then
                        varUserID = String.Empty
                    Else
                        V_DBR_MYSQL(1).Query = String.Format("select usr.user_id from sys_user usr where (usr.user_username = '{0}') and (usr.user_password = '{1}')", username, CMCv.Security.Encrypt.MD5(password))
                        varUserID = V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(1).Query).ToString

                        V_DBR_MYSQL(1).Query = String.Format("update sys_user set user_lastlogin = getdate() where user_id = '{0}'", varUserID)
                        V_DBE_MYSQL.PushData(databasename, V_DBR_MYSQL(1).Query)
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
        Public Shared Function GetEID(databasename As String, dbengine As String, uid As String) As String
            Dim varEmployeeID As String

            Try
                varEmployeeID = String.Empty

                If dbengine = "MSSQL" Then 'Run if MSSQL
                    V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_employee from dbo.sys_user usr where usr.user_id = '{0}';", uid)
                    varEmployeeID = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query).ToString
                ElseIf dbengine = "MYSQL" Then 'Run if MYSQL
                    V_DBR_MYSQL(1).Query = String.Format("select usr.user_employee from sys_user usr where usr.user_id = '{0}';", uid)
                    varEmployeeID = V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(1).Query).ToString
                End If
            Catch ex As Exception
                varEmployeeID = String.Empty
            End Try

            Return varEmployeeID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetFirstName(databasename As String, dbengine As String, uid As String) As String
            Dim varFullName As String = String.Empty

            Try
                If dbengine = "MSSQL" Then 'Run if MSSQL
                    V_DBR_MSSQL2008(1).Query = String.Format("select emp.employee_fullname from dbo.sys_user usr inner join dbo.man_employee emp on emp.employee_id = usr.user_employee where (usr.[user_id] = '{0}')", uid)
                    varFullName = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query).ToString
                ElseIf dbengine = "MYSQL" Then 'Run if MYSQL
                    V_DBR_MYSQL(1).Query = String.Format("select emp.employee_fullname from sys_user usr inner join man_employee emp on emp.employee_id = usr.user_employee where (usr.user_id = '{0}')", uid)
                    varFullName = V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(1).Query).ToString
                End If
            Catch ex As Exception
                varFullName = String.Empty
            End Try

            Return varFullName
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetLastName(databasename As String, dbengine As String, uid As String) As String
            Dim varFullName As String = String.Empty

            Try
                If dbengine = "MSSQL" Then 'Run if MSSQL
                    V_DBR_MSSQL2008(1).Query = String.Format("select emp.employee_fullname from dbo.sys_user usr inner join dbo.man_employee emp on emp.employee_id = usr.user_employee where (usr.[user_id] = '{0}')", uid)
                    varFullName = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query).ToString
                ElseIf dbengine = "MYSQL" Then 'Run if MYSQL
                    V_DBR_MYSQL(1).Query = String.Format("select emp.employee_fullname from sys_user usr inner join man_employee emp on emp.employee_id = usr.user_employee where (usr.user_id = '{0}')", uid)
                    varFullName = V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(1).Query).ToString
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
        Public Shared Function GetEmployeeNumber(databasename As String, dbengine As String, uid As String) As String
            Dim varEmployeeNumber As String = String.Empty

            Try
                If dbengine = "MSSQL" Then 'Run if MSSQL
                    V_DBR_MSSQL2008(1).Query = String.Format("select emp.employee_number from dbo.sys_user usr inner join dbo.man_employee emp on emp.employee_id = usr.user_employee where (usr.[user_id] = '{0}')", uid)
                    varEmployeeNumber = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query).ToString
                ElseIf dbengine = "MYSQL" Then 'Run if MYSQL
                    V_DBR_MYSQL(1).Query = String.Format("select emp.employee_number from sys_user usr inner join man_employee emp on emp.employee_id = usr.user_employee where (usr.[user_id] = '{0}')", uid)
                    varEmployeeNumber = V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(1).Query).ToString
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
        Public Shared Function GetGender(databasename As String, dbengine As String, uid As String) As String
            Dim varEmployeeNumber As String = String.Empty

            Try
                If dbengine = "MSSQL" Then 'Run if MSSQL
                    V_DBR_MSSQL2008(1).Query = String.Format("select emp.employee_gender from dbo.sys_user usr inner join dbo.man_employee emp on emp.employee_id = usr.user_employee where (usr.[user_id] = '{0}')", uid)
                    varEmployeeNumber = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query).ToString
                ElseIf dbengine = "MYSQL" Then 'Run if MYSQL
                    V_DBR_MYSQL(1).Query = String.Format("select emp.employee_gender from sys_user usr inner join man_employee emp on emp.employee_id = usr.user_employee where (usr.user_id = '{0}')", uid)
                    varEmployeeNumber = V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(1).Query).ToString
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
        Public Shared Function GetPosition(databasename As String, dbengine As String, uid As String) As String
            Dim varEmployeeNumber As String = String.Empty

            Try
                If dbengine = "MSSQL" Then 'Run if MSSQL
                    V_DBR_MSSQL2008(1).Query = String.Format("select p.position_name from dbo.sys_user usr inner join dbo.man_employee emp on emp.employee_id = usr.user_employee " &
                                                        "inner join dbo.man_position p on p.position_id = emp.employee_position where (usr.[user_id] = '{0}')", uid)
                    varEmployeeNumber = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query).ToString
                ElseIf dbengine = "MYSQL" Then 'Run if MYSQL
                    V_DBR_MYSQL(1).Query = String.Format("select p.position_name from sys_user usr inner join man_employee emp on emp.employee_id = usr.user_employee " &
                                                        "inner join man_position p on p.position_id = emp.employee_position where (usr.user_id = '{0}')", uid)
                    varEmployeeNumber = V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(1).Query).ToString
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
        Public Shared Function GetAccess(databasename As String, dbengine As String, authtype As EnuAuthType, sysmodule As String, uid As Integer) As Boolean
            Dim varIsAuth As Integer

            If authtype = EnuAuthType.Read Then
                'TODO: Read method
            ElseIf authtype = EnuAuthType.Write Then
                'TODO: Write method
            ElseIf authtype = EnuAuthType.Execute Then
                'TODO: Execute method
            End If

            If dbengine = "MSSQL" Then 'Run if MSSQL
                V_DBR_MSSQL2008(0).Query = ""
                varIsAuth = CType(V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(0).Query), Integer)
            ElseIf dbengine = "MYSQL" Then 'Run if MYSQL
                V_DBR_MYSQL(0).Query = ""
                varIsAuth = CType(V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(0).Query), Integer)
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
        Public Function GetPhoto(databasename As String, dbengine As String, uid As String) As System.Drawing.Image
            'TODO: To be moved into cloud storage

            Dim varUID As String = uid
            Dim varPhoto As System.Drawing.Image = Nothing
            Dim varFileStream As IO.FileStream = Nothing

            Try
                If dbengine = "MSSQL" Then
                    V_DBR_MSSQL2008(0).Query = String.Format("SELECT f.file_content FROM db_universe_erp_file.dbo.sto_file f where f.file_tag = 'EMPLOYEE-PROFILE-PHOTO' and f.file_parent = '{0}' ;", varUID)
                    varFileStream = CType(V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(0).Query), FileStream)
                ElseIf dbengine = "MYSQL" Then
                    V_DBR_MYSQL(0).Query = String.Format("SELECT f.file_content FROM db_universe_erp_file.dbo.sto_file f where f.file_tag = 'EMPLOYEE-PROFILE-PHOTO' and f.file_parent = '{0}' ;", varUID)
                    varFileStream = CType(V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(0).Query), FileStream)
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
        Public Shared Function GetAdministrator(databasename As String, dbengine As String, uid As String) As Boolean
            Dim varIsAdministrator As Boolean = False

            Try
                If dbengine = "MSSQL" Then 'Run if MSSQL
                    V_DBR_MSSQL2008(0).Query = String.Format("select u.user_root from dbo.sys_user u where u.user_id = '{0}'", uid)
                    varIsAdministrator = CType(V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(0).Query), Boolean)
                ElseIf dbengine = "MYSQL" Then 'Run if MYSQL
                    V_DBR_MYSQL(0).Query = String.Format("select u.user_root from sys_user u where u.user_id = '{0}'", uid)
                    varIsAdministrator = CType(V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(0).Query), Boolean)
                End If
            Catch ex As Exception
                varIsAdministrator = False
            End Try

            Return varIsAdministrator
        End Function

        Public Shared Function GetUID() As Integer
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
        Public Shared Sub DisplayData(databasename As String, dbengine As String, datagrid As dgn, statusbar As stt, find As txt, Optional forcerefresh As Boolean = False)
            If dbengine = "MSSQL" Then 'Run if MSSQL
                If (find.XOSQLText = String.Empty) OrElse (forcerefresh) Then
                    V_DBR_MSSQL2008(0).Query = String.Format("select usr.user_id, em.employee_number, em.employee_fullname, usr.user_username, iif(usr.user_root=1,'Administrator','') as [user_root], usr.user_lastlogin, " &
                                                            "usr.user_locked from dbo.sys_user usr inner join dbo.man_employee em on em.employee_id = usr.user_employee order by em.employee_fullname")
                Else
                    V_DBR_MSSQL2008(0).Query = String.Format("select usr.user_id, em.employee_number, em.employee_fullname, usr.user_username, iif(usr.user_root=1,'Administrator','') as [user_root], usr.user_lastlogin, " &
                                                            "usr.user_locked from dbo.sys_user usr inner join dbo.man_employee em on em.employee_id = usr.user_employee where (em.employee_number = '{0}') or " &
                                                            "(em.employee_fullname like '%{0}%') or (usr.user_username = '{0}') order by em.employee_fullname", find.XOSQLText)
                End If
                V_DBR_MSSQL2008(0).DataGrid = datagrid
                V_DBR_MSSQL2008(0).StatusBar = statusbar
                V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(0), "TUAC")
            ElseIf dbengine = "MYSQL" Then 'Run in MYSQL
                If (find.XOSQLText = String.Empty) OrElse (forcerefresh) Then
                    V_DBR_MYSQL(0).Query = String.Format("select usr.user_id, em.employee_number, em.employee_fullname, usr.user_username, iif(usr.user_root=1,'Administrator','') as `user_root`, usr.user_lastlogin, " &
                                                            "usr.user_locked from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee order by em.employee_fullname")
                Else
                    V_DBR_MYSQL(0).Query = String.Format("select usr.user_id, em.employee_number, em.employee_fullname, usr.user_username, iif(usr.user_root=1,'Administrator','') as `user_root`, usr.user_lastlogin, " &
                                                            "usr.user_locked from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where (em.employee_number = '{0}') or " &
                                                            "(em.employee_fullname like '%{0}%') or (usr.user_username = '{0}') order by em.employee_fullname", find.XOSQLText)
                End If
                V_DBR_MYSQL(0).DataGrid = datagrid
                V_DBR_MYSQL(0).StatusBar = statusbar
                V_DBE_MYSQL.GetDataTable(databasename, V_DBR_MYSQL(0), "TUAC")
            End If
        End Sub

        ''' <summary>
        ''' Delete Data From UAC
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function DeleteData(databasename As String, dbengine As String, rowid As String) As Boolean
            Dim varSuccess As Boolean
            Try
                If dbengine = "MSSQL" Then 'Run if MSSQL
                    V_DBR_MSSQL2008(1).Query = String.Format("delete from dbo.sys_user where (user_id = '{0}')", rowid)
                    V_DBE_MSSQL2008.PushData(databasename, V_DBR_MSSQL2008(1).Query)
                ElseIf dbengine = "MYSQL" Then 'Run if MYSQL
                    V_DBR_MYSQL(1).Query = String.Format("delete from sys_user where (user_id = '{0}')", rowid)
                    V_DBE_MYSQL.PushData(databasename, V_DBR_MYSQL(1).Query)
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
        Public Shared Sub DisplayData(databasename As String, dbengine As String, grid As dgn, Optional rowid As String = "-1")
            If dbengine = "MSSQL" Then
                ReDim V_DBR_MSSQL2008(2)

                If rowid = "-1" Then
                    V_DBR_MSSQL2008(2).Query = String.Format("select mog.modulegroup_name, mo.module_code, 0 as [useraccess_view], 0 as [useraccess_add], 0 as [useraccess_edit], 0 as [useraccess_delete], " &
                                                            "0 as [useraccess_reports], '' as [useraccess_id], mo.module_id from dbo.sys_module mo inner join dbo.[[sys]]modulegroup] mog " &
                                                            "on mog.modulegroup_id = mo.module_modulegroup order by mog.modulegroup_order, mo.module_code")
                Else
                    V_DBR_MSSQL2008(2).Query = String.Format("select mog.modulegroup_name, mo.module_code, (select uac1.useraccess_view from dbo.[[sys]]useraccess] uac1 inner join dbo.sys_module mo1 " &
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

                V_DBR_MSSQL2008(2).DataGrid = grid
                V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(2), "TUserAccess")
            ElseIf dbengine = "MYSQL" Then
                ReDim V_DBR_MYSQL(2)

                If rowid = "-1" Then
                    V_DBR_MYSQL(2).Query = String.Format("select mog.modulegroup_name, mo.module_code, 0 as [useraccess_view], 0 as [useraccess_add], 0 as [useraccess_edit], 0 as [useraccess_delete], " &
                                                            "0 as [useraccess_reports], '' as [useraccess_id], mo.module_id from sys_module mo inner join sys_modulegroup mog " &
                                                            "on mog.modulegroup_id = mo.module_modulegroup order by mog.modulegroup_order, mo.module_code")
                Else
                    V_DBR_MYSQL(2).Query = String.Format("select mog.modulegroup_name, mo.module_code, (select uac1.useraccess_view from sys_useraccess uac1 inner join sys_module mo1 " &
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

                V_DBR_MYSQL(2).DataGrid = grid
                V_DBE_MYSQL.GetDataTable(databasename, V_DBR_MYSQL(2), "TUserAccess")
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function GetUIDbyEmployeeID(databasename As String, dbengine As String, employeeid As String) As String
            Dim varUID As String = String.Empty

            Try
                If dbengine = "MSSQL" Then
                    V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_id from dbo.sys_user usr where usr.user_employee = '{0}';", employeeid)

                    varUID = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query).ToString
                    IIf(IsDBNull(varUID), "", varUID)
                ElseIf dbengine = "MYSQL" Then
                    V_DBR_MYSQL(1).Query = String.Format("select usr.user_id from sys_user usr where usr.user_employee = '{0}';", employeeid)

                    varUID = V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(1).Query).ToString
                    IIf(IsDBNull(varUID), "", varUID)
                End If
            Catch ex As Exception
                varUID = Nothing
            End Try

            Return varUID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetEmployeeNumber(databasename As String, dbengine As String, userid As String) As String
            Dim varEmployeeNumber As String = String.Empty

            If dbengine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select em.employee_number from dbo.sys_user usr inner join dbo.man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varEmployeeNumber = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query).ToString
            ElseIf dbengine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select em.employee_number from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varEmployeeNumber = V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(1).Query).ToString
            End If

            Return varEmployeeNumber
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetEmployeeFullName(databasename As String, dbengine As String, userid As String) As String
            Dim varEmployeeFullName As String = String.Empty

            If dbengine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select em.employee_fullname from dbo.sys_user usr inner join dbo.man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varEmployeeFullName = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query).ToString
            ElseIf dbengine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select em.employee_fullname from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varEmployeeFullName = V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(1).Query).ToString
            End If

            Return varEmployeeFullName
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetUsernameByUserID(databasename As String, dbengine As String, ByVal userid As String) As String
            Dim varUsername As String = String.Empty

            If dbengine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_username from dbo.sys_user usr inner join dbo.man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varUsername = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query).ToString
            ElseIf dbengine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select usr.user_username from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varUsername = V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(1).Query).ToString
            End If

            Return varUsername
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetUsernameByEmployeeID(databasename As String, dbengine As String, employeeid As String) As String
            Dim varUsername As String = String.Empty

            If dbengine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_username from dbo.sys_user usr where usr.user_employee = '{0}'", employeeid)

                varUsername = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query).ToString
            ElseIf dbengine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select usr.user_username from sys_user usr where usr.user_employee = '{0}'", employeeid)

                varUsername = V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(1).Query).ToString
            End If

            Return varUsername
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetPassword(databasename As String, dbengine As String, userid As String) As String
            Dim varPassword As String = String.Empty

            If dbengine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_password from dbo.sys_user usr inner join dbo.man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varPassword = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query).ToString
            ElseIf dbengine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select usr.user_password from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varPassword = V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(1).Query).ToString
            End If

            Return varPassword
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetLocked(databasename As String, dbengine As String, userid As String) As Boolean
            Dim varLocked As Boolean = True

            If dbengine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_locked from dbo.sys_user usr inner join dbo.man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varLocked = CType(V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query), Boolean)
            ElseIf dbengine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select usr.user_locked from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varLocked = CType(V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(1).Query), Boolean)
            End If

            Return varLocked
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetAdministrator(databasename As String, dbengine As String, userid As String) As Boolean
            Dim varRoot As Boolean = False

            If dbengine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_root from dbo.sys_user usr inner join dbo.man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varRoot = CType(V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query), Boolean)
            ElseIf dbengine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select usr.user_root from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", userid)

                varRoot = CType(V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(1).Query), Boolean)
            End If

            Return varRoot
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(databasename As String, dbengine As String, username As String, Optional rowid As String = "-1") As Boolean
            Dim varIsDuplicate As Integer = 0

            If rowid = "-1" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select count(usr.user_id) as [user_id] from dbo.sys_user usr where (usr.user_username = '{0}')", username)
            Else
                V_DBR_MSSQL2008(1).Query = String.Format("select count(usr.user_id) as [user_id] from dbo.sys_user usr where (usr.user_username = '{0}') and (usr.user_id <> '{1}')", username, rowid)
            End If
            varIsDuplicate = CType(V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(1).Query), Integer)

            If varIsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PushData(databasename As String, dbengine As String, employeeid As String, username As String, password As String, locked As Boolean, administrator As Boolean, uac As dgn, Optional rowid As String = "-1", Optional hash As String = "", Optional ispasswordchange As Boolean = False) As Boolean
            Dim varSuccess As Boolean = False

            Try
                Dim varEQuery As String = String.Empty

                If dbengine = "MSSQL" Then 'Run if MSSQL
                    ReDim V_DBR_MSSQL2008(4)

                    If rowid = "-1" Then
                        V_DBR_MSSQL2008(1).Query = String.Format("insert into dbo.sys_user(user_id, user_employee, user_username, user_password, user_locked, user_root, user_datecreated) " &
                                                                "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', (select getdate()));", hash, employeeid, username, password, locked, administrator)


                        For Each Row As DataGridViewRow In uac.Rows
                            varEQuery = String.Format("insert into dbo.[[sys]]useraccess](useraccess_id, useraccess_user, useraccess_module, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports) " &
                                                    "values('{0}', '{1}', (select mo.module_id from dbo.sys_module mo " &
                                                    "where mo.module_code = '{2}'), '{3}', '{4}', '{5}', '{6}', '{7}');", CMCv.Security.Encrypt.MD5(), hash, Row.Cells("module_code").Value, Row.Cells("useraccess_view").Value, Row.Cells("useraccess_add").Value, Row.Cells("useraccess_edit").Value, Row.Cells("useraccess_delete").Value, Row.Cells("useraccess_reports").Value)
                            V_DBR_MSSQL2008(1).Query += varEQuery
                        Next

                    Else
                        If (ispasswordchange) Then
                            V_DBR_MSSQL2008(1).Query = String.Format("update dbo.sys_user set user_username = '{0}', user_password = '{1}', user_locked = '{2}', user_root = '{3}' where user_id = '{4}';", username, password, locked, administrator, rowid)
                        Else
                            V_DBR_MSSQL2008(1).Query = String.Format("update dbo.sys_user set user_username = '{0}', user_locked = '{1}', user_root = '{2}' where user_id = '{3}';", username, locked, administrator, rowid)
                        End If

                        Dim _Exist As Integer = 0
                        For Each Row As DataGridViewRow In uac.Rows
                            V_DBR_MSSQL2008(3).Query = String.Format("select count(uac.useraccess_id) as [useraccess_id] from dbo.[[sys]]useraccess] uac inner join dbo.sys_module mo on mo.module_id = uac.useraccess_module " &
                                                                    "where uac.useraccess_user = '{0}' and mo.module_code = '{1}'", rowid, Row.Cells("module_code").Value)
                            _Exist = CType(V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(3).Query), Integer)

                            If _Exist = 0 Then
                                varEQuery = String.Format("insert into dbo.[[sys]]useraccess](useraccess_id, useraccess_user, useraccess_module, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports) " &
                                                        "values('{0}', '{1}', (select mo.module_id from dbo.sys_module mo " &
                                                        "where mo.module_code = '{2}'), '{3}', '{4}', '{5}', '{6}', '{7}');", CMCv.Security.Encrypt.MD5(), rowid, Row.Cells("module_code").Value, Row.Cells("useraccess_view").Value, Row.Cells("useraccess_add").Value, Row.Cells("useraccess_edit").Value, Row.Cells("useraccess_delete").Value, Row.Cells("useraccess_reports").Value)
                            Else
                                varEQuery = String.Format("update dbo.[[sys]]useraccess] set useraccess_view = '{0}', useraccess_add = '{1}', useraccess_edit = '{2}', useraccess_delete = '{3}', useraccess_reports = '{5}' " &
                                                        "where useraccess_id = '{4}';", Row.Cells("useraccess_view").Value, Row.Cells("useraccess_add").Value, Row.Cells("useraccess_edit").Value, Row.Cells("useraccess_delete").Value, Row.Cells("useraccess_id").Value, Row.Cells("useraccess_reports").Value)
                            End If
                            V_DBR_MSSQL2008(1).Query += varEQuery
                        Next
                    End If
                    V_DBE_MSSQL2008.PushData(databasename, V_DBR_MSSQL2008(1).Query)
                    varSuccess = True

                ElseIf dbengine = "MYSQL" Then 'Run if MYSQL
                    ReDim V_DBR_MYSQL(4)

                    If rowid = "-1" Then
                        V_DBR_MYSQL(1).Query = String.Format("insert into sys_user(user_id, user_employee, user_username, user_password, user_locked, user_root, user_datecreated) " &
                                                                "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', (select getdate()));", hash, employeeid, username, password, locked, administrator)


                        For Each Row As DataGridViewRow In uac.Rows
                            varEQuery = String.Format("insert into sys_useraccess(useraccess_id, useraccess_user, useraccess_module, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports) " &
                                                    "values('{0}', '{1}', (select mo.module_id from sys_module mo " &
                                                    "where mo.module_code = '{2}'), '{3}', '{4}', '{5}', '{6}', '{7}');", CMCv.Security.Encrypt.MD5(), hash, Row.Cells("module_code").Value, Row.Cells("useraccess_view").Value, Row.Cells("useraccess_add").Value, Row.Cells("useraccess_edit").Value, Row.Cells("useraccess_delete").Value, Row.Cells("useraccess_reports").Value)
                            V_DBR_MYSQL(1).Query += varEQuery
                        Next

                    Else
                        If (ispasswordchange) Then
                            V_DBR_MYSQL(1).Query = String.Format("update sys_user set user_username = '{0}', user_password = '{1}', user_locked = '{2}', user_root = '{3}' where user_id = '{4}';", username, password, locked, administrator, rowid)
                        Else
                            V_DBR_MYSQL(1).Query = String.Format("update sys_user set user_username = '{0}', user_locked = '{1}', user_root = '{2}' where user_id = '{3}';", username, locked, administrator, rowid)
                        End If

                        Dim _Exist As Integer = 0
                        For Each Row As DataGridViewRow In uac.Rows
                            V_DBR_MYSQL(3).Query = String.Format("select count(uac.useraccess_id) as [useraccess_id] from sys_useraccess uac inner join sys_module mo on mo.module_id = uac.useraccess_module " &
                                                                    "where uac.useraccess_user = '{0}' and mo.module_code = '{1}'", rowid, Row.Cells("module_code").Value)
                            _Exist = CType(V_DBE_MYSQL.GetValue(databasename, V_DBR_MYSQL(3).Query), Integer)

                            If _Exist = 0 Then
                                varEQuery = String.Format("insert into sys_useraccess(useraccess_id, useraccess_user, useraccess_module, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports) " &
                                                        "values('{0}', '{1}', (select mo.module_id from sys_module mo " &
                                                        "where mo.module_code = '{2}'), '{3}', '{4}', '{5}', '{6}', '{7}');", CMCv.Security.Encrypt.MD5(), rowid, Row.Cells("module_code").Value, Row.Cells("useraccess_view").Value, Row.Cells("useraccess_add").Value, Row.Cells("useraccess_edit").Value, Row.Cells("useraccess_delete").Value, Row.Cells("useraccess_reports").Value)
                            Else
                                varEQuery = String.Format("update sys_useraccess set useraccess_view = '{0}', useraccess_add = '{1}', useraccess_edit = '{2}', useraccess_delete = '{3}', useraccess_reports = '{5}' " &
                                                        "where useraccess_id = '{4}';", Row.Cells("useraccess_view").Value, Row.Cells("useraccess_add").Value, Row.Cells("useraccess_edit").Value, Row.Cells("useraccess_delete").Value, Row.Cells("useraccess_id").Value, Row.Cells("useraccess_reports").Value)
                            End If
                            V_DBR_MYSQL(1).Query += varEQuery
                        Next
                    End If
                    V_DBE_MYSQL.PushData(databasename, V_DBR_MYSQL(1).Query)
                    varSuccess = True
                End If
            Catch ex As Exception
                varSuccess = False
            End Try

            Return varSuccess
        End Function
    End Class

End Namespace
