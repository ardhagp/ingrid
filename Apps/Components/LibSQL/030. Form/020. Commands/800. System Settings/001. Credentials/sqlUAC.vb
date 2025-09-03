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
        Public Shared Function GETUID(ByVal DBEngine As String, ByVal Username As String, ByVal Password As String, Optional ByVal AdditionalField As Object = Nothing) As String
            Dim V_UID As String = String.Empty
            Dim V_Exist As Integer = 0
            Try
                If DBEngine = "MSSQL" Then 'Run if MSSQL
                    V_DBR_MSSQL2008(1).Query = String.Format("select count(usr.user_id) as [user_id] from dbo.[[sys]]user] usr where (usr.user_username = '{0}') and (usr.user_password = '{1}')", Username, CMCv.Security.Encrypt.MD5(Password))
                    V_Exist = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query), Integer)

                    If V_Exist = 0 Then
                        V_UID = String.Empty
                    Else
                        V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_id from dbo.[[sys]]user] usr where (usr.user_username = '{0}') and (usr.user_password = '{1}')", Username, CMCv.Security.Encrypt.MD5(Password))
                        V_UID = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString

                        V_DBR_MSSQL2008(1).Query = String.Format("update dbo.[[sys]]user] set user_lastlogin = getdate() where user_id = '{0}'", V_UID)
                        V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)
                    End If
                ElseIf DBEngine = "MYSQL" Then 'Run if MYSQL
                    V_DBR_MYSQL(1).Query = String.Format("select count(usr.user_id) as user_id from sys_user usr where (usr.user_username = '{0}') and (usr.user_password = '{1}')", Username, CMCv.Security.Encrypt.MD5(Password))
                    V_Exist = CType(V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query), Integer)

                    If V_Exist = 0 Then
                        V_UID = String.Empty
                    Else
                        V_DBR_MYSQL(1).Query = String.Format("select usr.user_id from sys_user usr where (usr.user_username = '{0}') and (usr.user_password = '{1}')", Username, CMCv.Security.Encrypt.MD5(Password))
                        V_UID = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query).ToString

                        V_DBR_MYSQL(1).Query = String.Format("update sys_user set user_lastlogin = getdate() where user_id = '{0}'", V_UID)
                        V_DBE_MYSQL.PUSHDATA(V_DBR_MYSQL(1).Query)
                    End If
                End If
            Catch ex As Exception
                V_UID = String.Empty
            End Try
            Return V_UID
        End Function

        ''' <summary>
        ''' Get Employee ID
        ''' </summary>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETEID(ByVal DBEngine As String, ByVal UID As String) As String
            Dim V_EID As String = String.Empty

            Try
                V_EID = String.Empty

                If DBEngine = "MSSQL" Then 'Run if MSSQL
                    V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_employee from dbo.[[sys]]user] usr where usr.user_id = '{0}';", UID)
                    V_EID = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString
                ElseIf DBEngine = "MYSQL" Then 'Run if MYSQL
                    V_DBR_MYSQL(1).Query = String.Format("select usr.user_employee from sys_user usr where usr.user_id = '{0}';", UID)
                    V_EID = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query).ToString
                End If
            Catch ex As Exception
                V_EID = String.Empty
            End Try

            Return V_EID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETFirstName(ByVal DBEngine As String, ByVal UID As String) As String
            Dim V_FullName As String = String.Empty

            Try
                If DBEngine = "MSSQL" Then 'Run if MSSQL
                    V_DBR_MSSQL2008(1).Query = String.Format("select emp.employee_fullname from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] emp on emp.employee_id = usr.user_employee where (usr.[user_id] = '{0}')", UID)
                    V_FullName = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString
                ElseIf DBEngine = "MYSQL" Then 'Run if MYSQL
                    V_DBR_MYSQL(1).Query = String.Format("select emp.employee_fullname from sys_user usr inner join man_employee emp on emp.employee_id = usr.user_employee where (usr.user_id = '{0}')", UID)
                    V_FullName = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query).ToString
                End If
            Catch ex As Exception
                V_FullName = String.Empty
            End Try

            Return V_FullName
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETLastName(ByVal DBEngine As String, ByVal UID As String) As String
            Dim V_FullName As String = String.Empty

            Try
                If DBEngine = "MSSQL" Then 'Run if MSSQL
                    V_DBR_MSSQL2008(1).Query = String.Format("select emp.employee_fullname from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] emp on emp.employee_id = usr.user_employee where (usr.[user_id] = '{0}')", UID)
                    V_FullName = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString
                ElseIf DBEngine = "MYSQL" Then 'Run if MYSQL
                    V_DBR_MYSQL(1).Query = String.Format("select emp.employee_fullname from sys_user usr inner join man_employee emp on emp.employee_id = usr.user_employee where (usr.user_id = '{0}')", UID)
                    V_FullName = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query).ToString
                End If
            Catch ex As Exception
                V_FullName = String.Empty
            End Try

            Return V_FullName
        End Function

        ''' <summary>
        ''' Get Company Employee Number ID
        ''' </summary>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETEmployeeNumber(ByVal DBEngine As String, ByVal UID As String) As String
            Dim V_EmployeeNumber As String = String.Empty

            Try
                If DBEngine = "MSSQL" Then 'Run if MSSQL
                    V_DBR_MSSQL2008(1).Query = String.Format("select emp.employee_number from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] emp on emp.employee_id = usr.user_employee where (usr.[user_id] = '{0}')", UID)
                    V_EmployeeNumber = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString
                ElseIf DBEngine = "MYSQL" Then 'Run if MYSQL
                    V_DBR_MYSQL(1).Query = String.Format("select emp.employee_number from sys_user usr inner join man_employee emp on emp.employee_id = usr.user_employee where (usr.[user_id] = '{0}')", UID)
                    V_EmployeeNumber = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query).ToString
                End If
            Catch ex As Exception
                V_EmployeeNumber = String.Empty
            End Try

            Return V_EmployeeNumber
        End Function

        ''' <summary>
        ''' Get Employee Gender
        ''' </summary>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETGender(ByVal DBEngine As String, ByVal UID As String) As String
            Dim V_EmployeeNumber As String = String.Empty

            Try
                If DBEngine = "MSSQL" Then 'Run if MSSQL
                    V_DBR_MSSQL2008(1).Query = String.Format("select emp.employee_gender from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] emp on emp.employee_id = usr.user_employee where (usr.[user_id] = '{0}')", UID)
                    V_EmployeeNumber = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString
                ElseIf DBEngine = "MYSQL" Then 'Run if MYSQL
                    V_DBR_MYSQL(1).Query = String.Format("select emp.employee_gender from sys_user usr inner join man_employee emp on emp.employee_id = usr.user_employee where (usr.user_id = '{0}')", UID)
                    V_EmployeeNumber = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query).ToString
                End If
            Catch ex As Exception
                V_EmployeeNumber = "MALE"
            End Try

            Return V_EmployeeNumber
        End Function

        ''' <summary>
        ''' Get Employee Position
        ''' </summary>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETPosition(ByVal DBEngine As String, ByVal UID As String) As String
            Dim V_EmployeeNumber As String = String.Empty

            Try
                If DBEngine = "MSSQL" Then 'Run if MSSQL
                    V_DBR_MSSQL2008(1).Query = String.Format("select p.position_name from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] emp on emp.employee_id = usr.user_employee " &
                                                        "inner join dbo.[[man]]position] p on p.position_id = emp.employee_position where (usr.[user_id] = '{0}')", UID)
                    V_EmployeeNumber = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString
                ElseIf DBEngine = "MYSQL" Then 'Run if MYSQL
                    V_DBR_MYSQL(1).Query = String.Format("select p.position_name from sys_user usr inner join man_employee emp on emp.employee_id = usr.user_employee " &
                                                        "inner join man_position p on p.position_id = emp.employee_position where (usr.user_id = '{0}')", UID)
                    V_EmployeeNumber = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query).ToString
                End If
            Catch ex As Exception
                V_EmployeeNumber = "#ERROR"
            End Try

            Return V_EmployeeNumber
        End Function

        ''' <summary>
        ''' Get Employee Authorization
        ''' </summary>
        ''' <param name="AuthType"></param>
        ''' <param name="SysModule"></param>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETAccess(ByVal DBEngine As String, ByVal AuthType As EnuAuthType, ByVal SysModule As String, ByVal UID As Integer) As Boolean
            Dim V_IsAuth As Integer

            If AuthType = EnuAuthType.Read Then
                'TODO: Read method
            ElseIf AuthType = EnuAuthType.Write Then
                'TODO: Write method
            ElseIf AuthType = EnuAuthType.Execute Then
                'TODO: Execute method
            End If

            If DBEngine = "MSSQL" Then 'Run if MSSQL
                V_DBR_MSSQL2008(0).Query = ""
                V_IsAuth = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query), Integer)
            ElseIf DBEngine = "MYSQL" Then 'Run if MYSQL
                V_DBR_MYSQL(0).Query = ""
                V_IsAuth = CType(V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(0).Query), Integer)
            End If

            If V_IsAuth = 0 Then
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
        Public Function GETPhoto(ByVal DBEngine As String, ByVal UID As String) As System.Drawing.Image
            'TODO: To be moved into cloud storage

            Dim V_UID As String = UID
            Dim V_Photo As System.Drawing.Image = Nothing
            Dim V_FileStream As IO.FileStream = Nothing

            Try
                If DBEngine = "MSSQL" Then
                    V_DBR_MSSQL2008(0).Query = String.Format("SELECT f.file_content FROM db_universe_erp_file.dbo.[[sto]]file] f where f.file_tag = 'EMPLOYEE-PROFILE-PHOTO' and f.file_parent = '{0}' ;", V_UID)
                    V_FileStream = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query), FileStream)
                ElseIf DBEngine = "MYSQL" Then
                    V_DBR_MYSQL(0).Query = String.Format("SELECT f.file_content FROM db_universe_erp_file.dbo.[[sto]]file] f where f.file_tag = 'EMPLOYEE-PROFILE-PHOTO' and f.file_parent = '{0}' ;", V_UID)
                    V_FileStream = CType(V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(0).Query), FileStream)
                End If

                If V_FileStream IsNot Nothing Then
                    V_Photo = ImageEditor.Proccessor.Compress.OutputAsImage(V_FileStream)
                End If
            Catch ex As Exception
                V_Photo = Nothing
            End Try

            Return V_Photo

        End Function

        ''' <summary>
        ''' Get Employee Administrator state
        ''' </summary>
        ''' <param name="UID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GETAdministrator(ByVal DBEngine As String, ByVal UID As String) As Boolean
            Dim V_IsAdministrator As Boolean = False

            Try
                If DBEngine = "MSSQL" Then 'Run if MSSQL
                    V_DBR_MSSQL2008(0).Query = String.Format("select u.user_root from dbo.[[sys]]user] u where u.user_id = '{0}'", UID)
                    V_IsAdministrator = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query), Boolean)
                ElseIf DBEngine = "MYSQL" Then 'Run if MYSQL
                    V_DBR_MYSQL(0).Query = String.Format("select u.user_root from sys_user u where u.user_id = '{0}'", UID)
                    V_IsAdministrator = CType(V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(0).Query), Boolean)
                End If
            Catch ex As Exception
                V_IsAdministrator = False
            End Try

            Return V_IsAdministrator
        End Function

        Public Shared Function GETUID() As Integer
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
        Public Shared Sub DisplayData(ByVal DBEngine As String, ByVal DataGrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            If DBEngine = "MSSQL" Then 'Run if MSSQL
                If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh) Then
                    V_DBR_MSSQL2008(0).Query = String.Format("select usr.user_id, em.employee_number, em.employee_fullname, usr.user_username, iif(usr.user_root=1,'Administrator','') as [user_root], usr.user_lastlogin, " &
                                                            "usr.user_locked from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee order by em.employee_fullname")
                Else
                    V_DBR_MSSQL2008(0).Query = String.Format("select usr.user_id, em.employee_number, em.employee_fullname, usr.user_username, iif(usr.user_root=1,'Administrator','') as [user_root], usr.user_lastlogin, " &
                                                            "usr.user_locked from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee where (em.employee_number = '{0}') or " &
                                                            "(em.employee_fullname like '%{0}%') or (usr.user_username = '{0}') order by em.employee_fullname", Find.XOSQLText)
                End If
                V_DBR_MSSQL2008(0).DataGrid = DataGrid
                V_DBR_MSSQL2008(0).StatusBar = StatusBar
                V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TUAC")
            ElseIf DBEngine = "MYSQL" Then 'Run in MYSQL
                If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh) Then
                    V_DBR_MYSQL(0).Query = String.Format("select usr.user_id, em.employee_number, em.employee_fullname, usr.user_username, iif(usr.user_root=1,'Administrator','') as `user_root`, usr.user_lastlogin, " &
                                                            "usr.user_locked from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee order by em.employee_fullname")
                Else
                    V_DBR_MYSQL(0).Query = String.Format("select usr.user_id, em.employee_number, em.employee_fullname, usr.user_username, iif(usr.user_root=1,'Administrator','') as `user_root`, usr.user_lastlogin, " &
                                                            "usr.user_locked from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where (em.employee_number = '{0}') or " &
                                                            "(em.employee_fullname like '%{0}%') or (usr.user_username = '{0}') order by em.employee_fullname", Find.XOSQLText)
                End If
                V_DBR_MYSQL(0).DataGrid = DataGrid
                V_DBR_MYSQL(0).StatusBar = StatusBar
                V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(0), "TUAC")
            End If
        End Sub

        ''' <summary>
        ''' Delete Data From UAC
        ''' </summary>
        ''' <param name="RowID"></param>
        ''' <returns></returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function DELETEData(ByVal DBEngine As String, ByVal RowID As String) As Boolean
            Dim V_Success As Boolean = False
            Try
                If DBEngine = "MSSQL" Then 'Run if MSSQL
                    V_DBR_MSSQL2008(1).Query = String.Format("delete from dbo.[[sys]]user] where (user_id = '{0}')", RowID)
                    V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)
                ElseIf DBEngine = "MYSQL" Then 'Run if MYSQL
                    V_DBR_MYSQL(1).Query = String.Format("delete from sys_user where (user_id = '{0}')", RowID)
                    V_DBE_MYSQL.PUSHDATA(V_DBR_MYSQL(1).Query)
                End If

                V_Success = True
            Catch ex As Exception
                V_Success = False
            End Try
            Return V_Success
        End Function
    End Class

    ''' <summary>
    ''' Editor Class
    ''' </summary>
    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(ByVal DBEngine As String, ByVal Grid As dgn, Optional ByVal RowID As String = "-1")
            If DBEngine = "MSSQL" Then
                ReDim V_DBR_MSSQL2008(2)

                If RowID = "-1" Then
                    V_DBR_MSSQL2008(2).Query = String.Format("select mog.modulegroup_name, mo.module_code, 0 as [useraccess_view], 0 as [useraccess_add], 0 as [useraccess_edit], 0 as [useraccess_delete], " &
                                                            "0 as [useraccess_reports], '' as [useraccess_id], mo.module_id from dbo.[[sys]]module] mo inner join dbo.[[sys]]modulegroup] mog " &
                                                            "on mog.modulegroup_id = mo.module_modulegroup order by mog.modulegroup_order, mo.module_code")
                Else
                    V_DBR_MSSQL2008(2).Query = String.Format("select mog.modulegroup_name, mo.module_code, (select uac1.useraccess_view from dbo.[[sys]]useraccess] uac1 inner join dbo.[[sys]]module] mo1 " &
                                                            "on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{0}' and mo1.module_code = mo.module_code) as [useraccess_view], (select uac1.useraccess_add " &
                                                            "from dbo.[[sys]]useraccess] uac1 inner join dbo.[[sys]]module] mo1 on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{0}' and " &
                                                            "mo1.module_code = mo.module_code) as [useraccess_add], (select uac1.useraccess_edit from dbo.[[sys]]useraccess] uac1 inner join dbo.[[sys]]module] mo1 " &
                                                            "on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{0}' and mo1.module_code = mo.module_code) as [useraccess_edit], " &
                                                            "(select uac1.useraccess_delete from dbo.[[sys]]useraccess] uac1 inner join dbo.[[sys]]module] mo1 on mo1.module_id = uac1.useraccess_module " &
                                                            "where uac1.useraccess_user = '{0}' and mo1.module_code = mo.module_code) as [useraccess_delete], (select uac1.useraccess_reports from dbo.[[sys]]useraccess] uac1 " &
                                                            "inner join dbo.[[sys]]module] mo1 on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{0}' and " &
                                                            "mo1.module_code = mo.module_code) as [useraccess_reports], (select uac1.useraccess_id from dbo.[[sys]]useraccess] uac1 inner join dbo.[[sys]]module] mo1 " &
                                                            "on mo1.module_id = uac1.useraccess_module where uac1.useraccess_user = '{0}' and mo1.module_code = mo.module_code) as [useraccess_id], mo.module_id " &
                                                            "from dbo.[[sys]]module] mo inner join dbo.[[sys]]modulegroup] mog on mog.modulegroup_id = mo.module_modulegroup order by mog.modulegroup_order, mo.module_code", RowID)
                End If

                V_DBR_MSSQL2008(2).DataGrid = Grid
                V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(2), "TUserAccess")
            ElseIf DBEngine = "MYSQL" Then
                ReDim V_DBR_MYSQL(2)

                If RowID = "-1" Then
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
                                                            "from sys_module mo inner join sys_modulegroup mog on mog.modulegroup_id = mo.module_modulegroup order by mog.modulegroup_order, mo.module_code", RowID)
                End If

                V_DBR_MYSQL(2).DataGrid = Grid
                V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(2), "TUserAccess")
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function GETUIDByEmployeeID(ByVal DBEngine As String, ByVal EmployeeID As String) As String
            Dim V_UID As String = String.Empty

            Try
                If DBEngine = "MSSQL" Then
                    V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_id from dbo.[[sys]]user] usr where usr.user_employee = '{0}';", EmployeeID)

                    V_UID = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString
                    IIf(IsDBNull(V_UID), "", V_UID)
                ElseIf DBEngine = "MYSQL" Then
                    V_DBR_MYSQL(1).Query = String.Format("select usr.user_id from sys_user usr where usr.user_employee = '{0}';", EmployeeID)

                    V_UID = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query).ToString
                    IIf(IsDBNull(V_UID), "", V_UID)
                End If
            Catch ex As Exception
                V_UID = Nothing
            End Try

            Return V_UID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETEmployeeNumber(ByVal DBEngine As String, ByVal UserID As String) As String
            Dim V_EmployeeNumber As String = String.Empty

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select em.employee_number from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

                V_EmployeeNumber = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select em.employee_number from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

                V_EmployeeNumber = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query).ToString
            End If

            Return V_EmployeeNumber
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETEmployeeFullName(ByVal DBEngine As String, ByVal UserID As String) As String
            Dim V_EmployeeFullName As String = String.Empty

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select em.employee_fullname from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

                V_EmployeeFullName = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select em.employee_fullname from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

                V_EmployeeFullName = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query).ToString
            End If

            Return V_EmployeeFullName
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETUsernameByUserID(ByVal DBEngine As String, ByVal UserID As String) As String
            Dim V_Username As String = String.Empty

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_username from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

                V_Username = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select usr.user_username from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

                V_Username = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query).ToString
            End If

            Return V_Username
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETUsernameByEmployeeID(ByVal DBEngine As String, ByVal EmployeeID As String) As String
            Dim V_Username As String = String.Empty

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_username from dbo.[[sys]]user] usr where usr.user_employee = '{0}'", EmployeeID)

                V_Username = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select usr.user_username from sys_user usr where usr.user_employee = '{0}'", EmployeeID)

                V_Username = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query).ToString
            End If

            Return V_Username
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETPassword(ByVal DBEngine As String, ByVal UserID As String) As String
            Dim V_Password As String = String.Empty

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_password from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

                V_Password = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query).ToString
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select usr.user_password from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

                V_Password = V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query).ToString
            End If

            Return V_Password
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETLocked(ByVal DBEngine As String, ByVal UserID As String) As Boolean
            Dim V_Locked As Boolean = True

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_locked from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

                V_Locked = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query), Boolean)
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select usr.user_locked from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

                V_Locked = CType(V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query), Boolean)
            End If

            Return V_Locked
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETAdministrator(ByVal DBEngine As String, ByVal UserID As String) As Boolean
            Dim V_Root As Boolean = False

            If DBEngine = "MSSQL" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select usr.user_root from dbo.[[sys]]user] usr inner join dbo.[[man]]employee] em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

                V_Root = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query), Boolean)
            ElseIf DBEngine = "MYSQL" Then
                V_DBR_MYSQL(1).Query = String.Format("select usr.user_root from sys_user usr inner join man_employee em on em.employee_id = usr.user_employee where usr.user_id = '{0}'", UserID)

                V_Root = CType(V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(1).Query), Boolean)
            End If

            Return V_Root
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(ByVal DBEngine As String, ByVal Username As String, Optional ByVal RowID As String = "-1") As Boolean
            Dim V_IsDuplicate As Integer = 0

            If RowID = "-1" Then
                V_DBR_MSSQL2008(1).Query = String.Format("select count(usr.user_id) as [user_id] from dbo.[[sys]]user] usr where (usr.user_username = '{0}')", Username)
            Else
                V_DBR_MSSQL2008(1).Query = String.Format("select count(usr.user_id) as [user_id] from dbo.[[sys]]user] usr where (usr.user_username = '{0}') and (usr.user_id <> '{1}')", Username, RowID)
            End If
            V_IsDuplicate = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query, "db_universe_erp"), Integer)

            If V_IsDuplicate = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHData(ByVal DBEngine As String, ByVal EmployeeID As String, ByVal Username As String, ByVal Password As String, ByVal Locked As Boolean, ByVal Administrator As Boolean, ByVal UAC As dgn, Optional ByVal RowID As String = "-1", Optional ByVal Hash As String = "", Optional ByVal IsPasswordChange As Boolean = False) As Boolean
            Dim V_Success As Boolean = False

            Try
                Dim V_EQuery As String = String.Empty

                If DBEngine = "MSSQL" Then 'Run if MSSQL
                    ReDim V_DBR_MSSQL2008(4)

                    If RowID = "-1" Then
                        V_DBR_MSSQL2008(1).Query = String.Format("insert into dbo.[[sys]]user](user_id, user_employee, user_username, user_password, user_locked, user_root, user_datecreated) " &
                                                                "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', (select getdate()));", Hash, EmployeeID, Username, Password, Locked, Administrator)


                        For Each Row As DataGridViewRow In UAC.Rows
                            V_EQuery = String.Format("insert into dbo.[[sys]]useraccess](useraccess_id, useraccess_user, useraccess_module, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports) " &
                                                    "values('{0}', '{1}', (select mo.module_id from dbo.[[sys]]module] mo " &
                                                    "where mo.module_code = '{2}'), '{3}', '{4}', '{5}', '{6}', '{7}');", CMCv.Security.Encrypt.MD5(), Hash, Row.Cells("module_code").Value, Row.Cells("useraccess_view").Value, Row.Cells("useraccess_add").Value, Row.Cells("useraccess_edit").Value, Row.Cells("useraccess_delete").Value, Row.Cells("useraccess_reports").Value)
                            V_DBR_MSSQL2008(1).Query += V_EQuery
                        Next

                    Else
                        If (IsPasswordChange) Then
                            V_DBR_MSSQL2008(1).Query = String.Format("update dbo.[[sys]]user] set user_username = '{0}', user_password = '{1}', user_locked = '{2}', user_root = '{3}' where user_id = '{4}';", Username, Password, Locked, Administrator, RowID)
                        Else
                            V_DBR_MSSQL2008(1).Query = String.Format("update dbo.[[sys]]user] set user_username = '{0}', user_locked = '{1}', user_root = '{2}' where user_id = '{3}';", Username, Locked, Administrator, RowID)
                        End If

                        Dim _Exist As Integer = 0
                        For Each Row As DataGridViewRow In UAC.Rows
                            V_DBR_MSSQL2008(3).Query = String.Format("select count(uac.useraccess_id) as [useraccess_id] from dbo.[[sys]]useraccess] uac inner join dbo.[[sys]]module] mo on mo.module_id = uac.useraccess_module " &
                                                                    "where uac.useraccess_user = '{0}' and mo.module_code = '{1}'", RowID, Row.Cells("module_code").Value)
                            _Exist = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(3).Query), Integer)

                            If _Exist = 0 Then
                                V_EQuery = String.Format("insert into dbo.[[sys]]useraccess](useraccess_id, useraccess_user, useraccess_module, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports) " &
                                                        "values('{0}', '{1}', (select mo.module_id from dbo.[[sys]]module] mo " &
                                                        "where mo.module_code = '{2}'), '{3}', '{4}', '{5}', '{6}', '{7}');", CMCv.Security.Encrypt.MD5(), RowID, Row.Cells("module_code").Value, Row.Cells("useraccess_view").Value, Row.Cells("useraccess_add").Value, Row.Cells("useraccess_edit").Value, Row.Cells("useraccess_delete").Value, Row.Cells("useraccess_reports").Value)
                            Else
                                V_EQuery = String.Format("update dbo.[[sys]]useraccess] set useraccess_view = '{0}', useraccess_add = '{1}', useraccess_edit = '{2}', useraccess_delete = '{3}', useraccess_reports = '{5}' " &
                                                        "where useraccess_id = '{4}';", Row.Cells("useraccess_view").Value, Row.Cells("useraccess_add").Value, Row.Cells("useraccess_edit").Value, Row.Cells("useraccess_delete").Value, Row.Cells("useraccess_id").Value, Row.Cells("useraccess_reports").Value)
                            End If
                            V_DBR_MSSQL2008(1).Query += V_EQuery
                        Next
                    End If
                    V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query)
                    V_Success = True

                ElseIf DBEngine = "MYSQL" Then 'Run if MYSQL
                    ReDim V_DBR_MYSQL(4)

                    If RowID = "-1" Then
                        V_DBR_MYSQL(1).Query = String.Format("insert into sys_user(user_id, user_employee, user_username, user_password, user_locked, user_root, user_datecreated) " &
                                                                "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', (select getdate()));", Hash, EmployeeID, Username, Password, Locked, Administrator)


                        For Each Row As DataGridViewRow In UAC.Rows
                            V_EQuery = String.Format("insert into sys_useraccess(useraccess_id, useraccess_user, useraccess_module, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports) " &
                                                    "values('{0}', '{1}', (select mo.module_id from sys_module mo " &
                                                    "where mo.module_code = '{2}'), '{3}', '{4}', '{5}', '{6}', '{7}');", CMCv.Security.Encrypt.MD5(), Hash, Row.Cells("module_code").Value, Row.Cells("useraccess_view").Value, Row.Cells("useraccess_add").Value, Row.Cells("useraccess_edit").Value, Row.Cells("useraccess_delete").Value, Row.Cells("useraccess_reports").Value)
                            V_DBR_MYSQL(1).Query += V_EQuery
                        Next

                    Else
                        If (IsPasswordChange) Then
                            V_DBR_MYSQL(1).Query = String.Format("update sys_user set user_username = '{0}', user_password = '{1}', user_locked = '{2}', user_root = '{3}' where user_id = '{4}';", Username, Password, Locked, Administrator, RowID)
                        Else
                            V_DBR_MYSQL(1).Query = String.Format("update sys_user set user_username = '{0}', user_locked = '{1}', user_root = '{2}' where user_id = '{3}';", Username, Locked, Administrator, RowID)
                        End If

                        Dim _Exist As Integer = 0
                        For Each Row As DataGridViewRow In UAC.Rows
                            V_DBR_MYSQL(3).Query = String.Format("select count(uac.useraccess_id) as [useraccess_id] from sys_useraccess uac inner join sys_module mo on mo.module_id = uac.useraccess_module " &
                                                                    "where uac.useraccess_user = '{0}' and mo.module_code = '{1}'", RowID, Row.Cells("module_code").Value)
                            _Exist = CType(V_DBE_MYSQL.GETVALUE(V_DBR_MYSQL(3).Query), Integer)

                            If _Exist = 0 Then
                                V_EQuery = String.Format("insert into sys_useraccess(useraccess_id, useraccess_user, useraccess_module, useraccess_view, useraccess_add, useraccess_edit, useraccess_delete, useraccess_reports) " &
                                                        "values('{0}', '{1}', (select mo.module_id from sys_module mo " &
                                                        "where mo.module_code = '{2}'), '{3}', '{4}', '{5}', '{6}', '{7}');", CMCv.Security.Encrypt.MD5(), RowID, Row.Cells("module_code").Value, Row.Cells("useraccess_view").Value, Row.Cells("useraccess_add").Value, Row.Cells("useraccess_edit").Value, Row.Cells("useraccess_delete").Value, Row.Cells("useraccess_reports").Value)
                            Else
                                V_EQuery = String.Format("update sys_useraccess set useraccess_view = '{0}', useraccess_add = '{1}', useraccess_edit = '{2}', useraccess_delete = '{3}', useraccess_reports = '{5}' " &
                                                        "where useraccess_id = '{4}';", Row.Cells("useraccess_view").Value, Row.Cells("useraccess_add").Value, Row.Cells("useraccess_edit").Value, Row.Cells("useraccess_delete").Value, Row.Cells("useraccess_id").Value, Row.Cells("useraccess_reports").Value)
                            End If
                            V_DBR_MYSQL(1).Query += V_EQuery
                        Next
                    End If
                    V_DBE_MYSQL.PUSHDATA(V_DBR_MYSQL(1).Query)
                    V_Success = True
                End If
            Catch ex As Exception
                V_Success = False
            End Try

            Return V_Success
        End Function
    End Class

End Namespace
