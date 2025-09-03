Imports System.Data
Imports System.Runtime.Versioning
Imports CMCv
Imports Microsoft.CodeAnalysis.VisualBasic.Syntax

Namespace Application

    Public Class Access
        Public Enum TypeOfAccess
            View = 1
            Add = 2
            Edit = 3
            Delete = 4
            Report = 5
        End Enum

        Private ReadOnly V_DBR_MSSQL2008(2) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Function User(ByVal TCode As String, ByVal UID As String, ByVal TypeOfAccess As TypeOfAccess) As Boolean
            Dim V_View As Integer
            Dim V_TypeOfAccess As String = String.Empty

            Select Case TypeOfAccess
                Case Access.TypeOfAccess.View
                    V_TypeOfAccess = "uac.useraccess_view"
                Case Access.TypeOfAccess.Add
                    V_TypeOfAccess = "uac.useraccess_add"
                Case Access.TypeOfAccess.Edit
                    V_TypeOfAccess = "uac.useraccess_edit"
                Case Access.TypeOfAccess.Delete
                    V_TypeOfAccess = "uac.useraccess_delete"
                Case Access.TypeOfAccess.Report
                    V_TypeOfAccess = "uac.useraccess_reports"
            End Select

            Try
                Dim _IsRoot As Integer = 0
                V_DBR_MSSQL2008(1).Query = String.Format("select count(usr.user_id) from dbo.[[sys]]user] usr where (usr.user_id = '{0}') and (usr.user_root = 1)", UID)

                _IsRoot = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query), Integer)

                If _IsRoot = 1 Then
                    Return True
                Else
                    V_DBR_MSSQL2008(1).Query = String.Format("select count(uac.useraccess_id) as [useraccess_id] from dbo.[[sys]]useraccess] uac inner join dbo.[[sys]]module] mo on mo.module_id = uac.useraccess_module where (mo.module_code = '{0}') and (uac.useraccess_user = '{1}') and ({2} = 1)", TCode, UID, V_TypeOfAccess)
                    V_View = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query), Integer)

                    If V_View = 0 Then
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
        Private _DS As DataSet

        <SupportedOSPlatform("windows")>
        Public Shared Function Exist(ByVal DBEngine As String, ByVal TCODE As String) As Boolean
            Dim V_isExist As Boolean

            Try
                If DBEngine = "MSSQL" Then
                    V_DBR_MSSQL2008(1).Query = String.Format("select count(mo.module_id) from dbo.[[sys]]module] mo where mo.module_code = '{0}'", TCODE)
                    V_isExist = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query), Boolean)
                ElseIf DBEngine = "MYSQL" Then

                End If

                Return V_isExist
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function Locked(ByVal DBEngine As String, ByVal TCODE As String) As Boolean
            Dim V_isLocked As Boolean

            Try
                If DBEngine = "MSSQL" Then
                    V_DBR_MSSQL2008(1).Query = String.Format("select count(mo.module_id) from dbo.[[sys]]module] mo where mo.module_code = '{0}' and mo.module_ismaintenance = 'true'", TCODE)
                    V_isLocked = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(1).Query), Boolean)
                ElseIf DBEngine = "MYSQL" Then

                End If
                Return V_isLocked
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Function DisplayAutoComplete() As DataSet
            Try
                _DS = New DataSet

                V_DBR_MSSQL2008(2).Query = "select mods.module_code from dbo.[[sys]]module] mods where mods.module_issystem = 0 order by mods.module_code"

                _DS = V_DBE_MSSQL2008.GETDATASET(V_DBR_MSSQL2008(2), "TCMD")

                Return _DS
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function MaxPDFAllowed() As Double
            Dim V_SettingValue As Double

            Try
                V_DBR_MSSQL2008(0).Query = String.Format("select top 1 s.settings_uploadpdf from db_universe_erp.dbo.[[sys]]settings] s")

                V_SettingValue = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query), Double)
            Catch ex As Exception
                V_SettingValue = 0.9
            End Try

            Return V_SettingValue
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function MaxPhotoAllowed() As Double
            Dim V_SettingValue As Double

            Try
                V_DBR_MSSQL2008(0).Query = String.Format("select top 1 s.settings_uploadphoto from db_universe_erp.dbo.[[sys]]settings] s")

                V_SettingValue = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query), Double)
            Catch ex As Exception
                V_SettingValue = 0.9
            End Try

            Return V_SettingValue
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function MinPasswordLength() As Integer
            Dim V_MinPasswordLength As Integer

            Try
                V_DBR_MSSQL2008(0).Query = String.Format("select top 1 s.settings_minpasswordlength from db_universe_erp.dbo.[[sys]]settings] s")

                V_MinPasswordLength = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query), Integer)
            Catch ex As Exception
                V_MinPasswordLength = 8
            End Try

            Return V_MinPasswordLength
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function TextMark(ByVal IsAdministrator As Boolean) As String
            Dim V_Value As Integer
            Dim V_SettingValue As String

            Try
                V_DBR_MSSQL2008(0).Query = String.Format("select s.settings_showwatermark from dbo.[[sys]]settings] s where s.settings_id = 1")
                V_Value = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query), Integer)

                V_DBR_MSSQL2008(0).Query = String.Format("select top 1 s.settings_textmark from db_universe_erp.dbo.[[sys]]settings] s")

                If (V_Value = 1 AndAlso (IsAdministrator)) OrElse (V_Value = 2 AndAlso Not (IsAdministrator)) OrElse (V_Value = 3) Then
                    V_SettingValue = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query).ToString
                Else
                    V_SettingValue = String.Empty
                End If
            Catch ex As Exception
                V_SettingValue = String.Empty
            End Try

            Return V_SettingValue
        End Function
    End Class

    Public Class Notification
        Private ReadOnly V_DBR_MSSQL2008(1) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Function Exist(ByVal EmployeeID As String) As Integer
            Dim V_isExist As Integer

            Try
                V_DBR_MSSQL2008(0).Query = String.Format("select count(nt.notification_id) as [new_notification] from dbo.[[sys]]notification] nt where (nt.notification_employee = '{0}') and (nt.notification_isread = 0)", EmployeeID)
                V_isExist = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query), Integer)

                Return V_isExist
            Catch ex As Exception
                Return 0
            End Try
        End Function
    End Class

    Public Class RunningText
        Private ReadOnly V_DBR_MSSQL2008(1) As Database.Adapter.MSSQL2008.Display.Request

        <SupportedOSPlatform("windows")>
        Public Function Show(Optional ByVal IsAdministrator As Boolean = False) As Boolean
            Dim V_Value As Integer

            Try
                V_DBR_MSSQL2008(0).Query = String.Format("select s.settings_showrunningtext from dbo.[[sys]]settings] s where s.settings_id = 1")
                V_Value = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query), Integer)

                If V_Value = 1 AndAlso (IsAdministrator) Then
                    Return True
                ElseIf V_Value = 2 AndAlso (Not (IsAdministrator)) Then
                    Return True
                ElseIf V_Value = 3 Then
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
        Public Shared Function Show(Optional ByVal IsAdmininstrator As Boolean = False) As Boolean
            Dim V_Value As Integer

            Try
                V_DBR_MSSQL2008(0).Query = String.Format("select top 1 s.settings_showstorage from dbo.[[sys]]settings] s")
                V_Value = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query), Integer)

                If V_Value = 1 AndAlso (IsAdmininstrator) Then
                    Return True
                ElseIf V_Value = 2 AndAlso (Not (IsAdmininstrator)) Then
                    Return True
                ElseIf V_Value = 3 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function DataCurrentSize() As Double
            Dim V_Size As Double

            Try
                V_DBR_MSSQL2008(0).Query = String.Format("SELECT (size*8)/1024 AS SizeMB FROM sys.database_files where name='db_universe_erp'")
                V_Size = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query), Double)

                Return V_Size
            Catch ex As Exception
                Return 0
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function FileCurrentSize() As Double
            Dim V_Size As Double

            Try
                V_DBR_MSSQL2008(0).Query = String.Format("SELECT (size*8)/1024 AS SizeMB FROM sys.database_files where name='db_universe_erp_file'")
                V_Size = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query, "db_universe_erp_file"), Double)

                Return V_Size
            Catch ex As Exception
                Return 0
            End Try
        End Function

        Public Enum DBSizeType
            MaxSize = 1
            FreeSpace = 2
        End Enum

        <SupportedOSPlatform("windows")>
        Public Shared Function MaxSize(ByVal SizeType As DBSizeType, Optional ByVal DBName As String = "") As Double
            Dim V_Size As Double
            If DBName = String.Empty Then
                DBName = "db_universe_erp"
            End If

            Try
                'Line 1 For Production
                If SizeType = 1 Then
                    V_DBR_MSSQL2008(0).Query = String.Format("SELECT max_db_size_in_gb = CASE WHEN engine_edition = 4 THEN CASE WHEN d.sversion_name LIKE '%203%' THEN (10 * 1024)  WHEN d.sversion_name LIKE '%202%' THEN (10 * 1024)  WHEN d.sversion_name LIKE '%201%' THEN (10 * 1024) WHEN d.sversion_name LIKE '%2008 R2%' THEN (10 * 1024) WHEN d.sversion_name LIKE '%2008%' THEN (4 * 1024) WHEN d.sversion_name LIKE '%2005%' THEN (4 * 1024) END ELSE '0' END FROM (SELECT sversion_name = v.ver, engine_edition = SERVERPROPERTY('EngineEdition'), edition = SERVERPROPERTY('Edition'), server_name = SERVERPROPERTY('ServerName') FROM (SELECT ver = @@VERSION) v) d")
                    V_Size = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query, DBName), Double)
                Else
                    V_DBR_MSSQL2008(0).Query = "select sv.var_value from [dbo].[[sys]]variables] sv where sv.var_name = 'drive_free_space'"
                    V_Size = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query, DBName), Double)
                End If


                'Line 2 For testing bypass purpose
                '_Size = "0"
                'Please refer to actual remaining disk space. code : https://stackoverflow.com/questions/2243121/determine-available-disk-size-with-a-sql-query

                Return V_Size
            Catch ex As Exception
                Return 0
            End Try
        End Function
    End Class

    Public Class ProfilePanel
        ReadOnly _DBR_MSSQL2008(1) As Database.Adapter.MSSQL2008.Display.Request
        ReadOnly _IMG As New CMCv.ImageEditor.Proccessor.Compress

        <SupportedOSPlatform("windows")>
        Public Function GETPhoto(ByVal EmployeeID As String, ByVal Gender As String) As System.Drawing.Image
            Dim V_Photo As System.Drawing.Image
            Dim V_Bytes As Byte()

            Try
                V_DBR_MSSQL2008(0).Query = String.Format("select f.file_content from db_universe_erp_file.dbo.[[sto]]file] f where f.file_parent = '{0}' and f.file_tag = 'EMPLOYEE-PROFILE-PHOTO' and f.file_filetype = 'jpg'", EmployeeID)
                V_Bytes = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query), Byte())

                If Not IsNothing(V_Bytes) Then
                    V_Photo = CMCv.ImageEditor.Proccessor.Compress.OutputAsImage(V_Bytes)
                Else
                    If (Gender = "MALE") OrElse (Gender = "") Then
                        V_Photo = My.Resources.MALE_001_512_icon

                    Else
                        V_Photo = My.Resources.FEMALE_001_512_icon
                    End If
                End If

                Return V_Photo
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function Show(Optional ByVal IsAdministrator As Boolean = False) As Boolean
            Dim V_Value As Integer

            Try
                V_DBR_MSSQL2008(0).Query = String.Format("select top 1 s.settings_showprofile from dbo.[[sys]]settings] s")
                V_Value = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query), Integer)

                If V_Value = 1 AndAlso (IsAdministrator) Then
                    Return True
                ElseIf V_Value = 2 AndAlso (Not (IsAdministrator)) Then
                    Return True
                ElseIf V_Value = 3 Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function Welcome() As String
            Dim V_Welcome As String

            Try
                V_DBR_MSSQL2008(0).Query = String.Format("select top 1 t.template_text1 from dbo.[[doc]]template] t where t.template_module = 'F2887E94E365C068D1CCB3FF03DB7969' and t.template_title = 'PROFILE' order by newid()")
                V_Welcome = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query).ToString

                Return V_Welcome
            Catch ex As Exception
                Return "Welcome,"
            End Try
        End Function

    End Class
End Namespace

