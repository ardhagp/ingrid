Imports System.Data
Imports System.Runtime.Versioning
Imports CMCv

Namespace Application

    Public Class Access
        Public Enum TypeOfAccess
            View = 1
            Add = 2
            Edit = 3
            Delete = 4
            Report = 5
        End Enum

        Private Shared ReadOnly varDatabaseRequestMssql2008(2) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Shared Function User(databasename As String, tcode As String, uid As String, typeofaccess As TypeOfAccess) As Boolean
            Dim varView As Integer
            Dim varTypeOfAccess As String = String.Empty

            Select Case typeofaccess
                Case Access.TypeOfAccess.View
                    varTypeOfAccess = "uac.useraccess_view"
                Case Access.TypeOfAccess.Add
                    varTypeOfAccess = "uac.useraccess_add"
                Case Access.TypeOfAccess.Edit
                    varTypeOfAccess = "uac.useraccess_edit"
                Case Access.TypeOfAccess.Delete
                    varTypeOfAccess = "uac.useraccess_delete"
                Case Access.TypeOfAccess.Report
                    varTypeOfAccess = "uac.useraccess_reports"
            End Select

            Try
                Dim varIsRoot As Integer = 0
                varDatabaseRequestMssql2008(1).Query = String.Format("select count(usr.user_id) from dbo.sys_user usr where (usr.user_id = '{0}') and (usr.user_root = 1)", uid)

                varIsRoot = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query), Integer)

                If varIsRoot = 1 Then
                    Return True
                Else
                    varDatabaseRequestMssql2008(1).Query = String.Format("select count(uac.useraccess_id) as [useraccess_id] from dbo.[[sys]]useraccess] uac inner join dbo.sys_module mo on mo.module_id = uac.useraccess_module where (mo.module_code = '{0}') and (uac.useraccess_user = '{1}') and ({2} = 1)", tcode, uid, varTypeOfAccess)
                    varView = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query), Integer)

                    If varView = 0 Then
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

    Public Class Modules
        Private varDataSet As DataSet

        <SupportedOSPlatform("windows")>
        Public Shared Function Exist(databasename As String, dbengine As String, tcode As String) As Boolean
            Dim varIsExist As Boolean

            Try
                If dbengine = "MSSQL" Then
                    varDatabaseRequestMssql2008(1).Query = String.Format("select count(mo.module_id) from dbo.sys_module mo where mo.module_code = '{0}'", tcode)
                    varIsExist = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query), Boolean)
                ElseIf dbengine = "MYSQL" Then

                End If

                Return varIsExist
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function Locked(databasename As String, dbengine As String, tcode As String) As Boolean
            Dim varIsLocked As Boolean

            Try
                If dbengine = "MSSQL" Then
                    varDatabaseRequestMssql2008(1).Query = String.Format("select count(mo.module_id) from dbo.sys_module mo where mo.module_code = '{0}' and mo.module_ismaintenance = 'true'", tcode)
                    varIsLocked = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(1).Query), Boolean)
                ElseIf dbengine = "MYSQL" Then

                End If
                Return varIsLocked
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Function DisplayAutoComplete(databasename As String) As DataSet
            Try
                varDataSet = New DataSet

                varDatabaseRequestMssql2008(2).Query = "select mods.module_code from dbo.sys_module mods where mods.module_issystem = 0 order by mods.module_code"

                varDataSet = varDatabaseEngineMssql2008.GetDataSet(databasename, varDatabaseRequestMssql2008(2), "TCMD")

                Return varDataSet
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function MaxPDFallowed(databasename As String) As Double
            Dim varSettingValue As Double

            Try
                varDatabaseRequestMssql2008(0).Query = String.Format("select top 1 s.settings_uploadpdf from db_universe_erp.dbo.sys_settings s")

                varSettingValue = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Double)
            Catch ex As Exception
                varSettingValue = 0.9
            End Try

            Return varSettingValue
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function MaxPhotoallowed(databasename As String) As Double
            Dim varSettingValue As Double

            Try
                varDatabaseRequestMssql2008(0).Query = String.Format("select top 1 s.settings_uploadphoto from db_universe_erp.dbo.sys_settings s")

                varSettingValue = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Double)
            Catch ex As Exception
                varSettingValue = 0.9
            End Try

            Return varSettingValue
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function MinPasswordLength(databasename As String) As Integer
            Dim varMinPasswordLength As Integer

            Try
                varDatabaseRequestMssql2008(0).Query = String.Format("select top 1 s.settings_minpasswordlength from db_universe_erp.dbo.sys_settings s")
                varMinPasswordLength = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Integer)
            Catch ex As Exception
                varMinPasswordLength = 8
            End Try

            Return varMinPasswordLength
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function TextMark(databasename As String, isadministrator As Boolean) As String
            Dim varValue As Integer
            Dim varSettingValue As String

            Try
                varDatabaseRequestMssql2008(0).Query = String.Format("select s.settings_showwatermark from dbo.sys_settings s where s.settings_id = 1")
                varValue = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Integer)

                varDatabaseRequestMssql2008(0).Query = String.Format("select top 1 s.settings_textmark from db_universe_erp.dbo.sys_settings s")

                If (varValue = 1 AndAlso (isadministrator)) OrElse (varValue = 2 AndAlso Not (isadministrator)) OrElse (varValue = 3) Then
                    varSettingValue = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query).ToString
                Else
                    varSettingValue = String.Empty
                End If
            Catch ex As Exception
                varSettingValue = String.Empty
            End Try

            Return varSettingValue
        End Function
    End Class

    Public Class Notification
        Private ReadOnly varDatabaseRequestMssql2008(1) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Function Exist(databasename As String, employeeid As String) As Integer
            Dim varIsExist As Integer

            Try
                varDatabaseRequestMssql2008(0).Query = String.Format("select count(nt.notification_id) as [new_notification] from dbo.[[sys]]notification] nt where (nt.notification_employee = '{0}') and (nt.notification_isread = 0)", employeeid)
                varIsExist = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Integer)

                Return varIsExist
            Catch ex As Exception
                Return 0
            End Try
        End Function
    End Class

    Public Class RunningText
        Private ReadOnly varDatabaseRequestMssql2008(1) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Function Show(databasename As String, Optional isadministrator As Boolean = False) As Boolean
            Dim varValue As Integer

            Try
                varDatabaseRequestMssql2008(0).Query = String.Format("select s.settings_showrunningtext from dbo.sys_settings s where s.settings_id = 1")
                varValue = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Integer)

                If varValue = 1 AndAlso (isadministrator) Then
                    Return True
                ElseIf varValue = 2 AndAlso (Not (isadministrator)) Then
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

    Public Class StorageSense

        <SupportedOSPlatform("windows")>
        Public Shared Function Show(databasename As String, Optional IsAdmininstrator As Boolean = False) As Boolean
            Dim varValue As Integer

            Try
                varDatabaseRequestMssql2008(0).Query = String.Format("select top 1 s.settings_showstorage from dbo.sys_settings s")
                varValue = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Integer)

                If varValue = 1 AndAlso (IsAdmininstrator) Then
                    Return True
                ElseIf varValue = 2 AndAlso (Not (IsAdmininstrator)) Then
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

        <SupportedOSPlatform("windows")>
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

        <SupportedOSPlatform("windows")>
        Public Shared Function FileCurrentSize(databasename As String) As Double
            Dim varSize As Double

            Try
                varDatabaseRequestMssql2008(0).Query = String.Format("SELECT (size*8)/1024 AS SizeMB FROM sys.database_files where name='db_universe_erp_file'")
                varSize = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Double)

                Return varSize
            Catch ex As Exception
                Return 0
            End Try
        End Function

        Public Enum DBSizeType
            MaxSize = 1
            FreeSpace = 2
        End Enum

        <SupportedOSPlatform("windows")>
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
        <SupportedOSPlatform("windows")>
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

        <SupportedOSPlatform("windows")>
        Public Shared Function Show(databasename As String, Optional isadministrator As Boolean = False) As Boolean
            Dim varValue As Integer

            Try
                varDatabaseRequestMssql2008(0).Query = String.Format("select top 1 s.settings_showprofile from dbo.sys_settings s")
                varValue = CType(varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query), Integer)

                If varValue = 1 AndAlso (isadministrator) Then
                    Return True
                ElseIf varValue = 2 AndAlso (Not (isadministrator)) Then
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

        <SupportedOSPlatform("windows")>
        Public Shared Function Welcome(databasename As String) As String
            Dim varWelcome As String

            Try
                varDatabaseRequestMssql2008(0).Query = String.Format("select top 1 t.template_text1 from dbo.doc_template t where t.template_module = 'F2887E94E365C068D1CCB3FF03DB7969' and t.template_title = 'PROFILE' order by newid()")
                varWelcome = varDatabaseEngineMssql2008.GetValue(databasename, varDatabaseRequestMssql2008(0).Query).ToString

                Return varWelcome
            Catch ex As Exception
                Return "Welcome,"
            End Try
        End Function

    End Class
End Namespace

