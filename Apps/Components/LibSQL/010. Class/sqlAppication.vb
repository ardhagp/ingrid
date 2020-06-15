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

        Private _DBR_MSSQL2008(2) As Database.Adapter.MSSQL2008.Display.Request

        Public Function User(ByVal TCode As String, ByVal UID As String, ByVal TypeOfAccess As TypeOfAccess) As Boolean
            Dim _View As Integer = 0
            Dim _TypeOfAccess As String = String.Empty

            Select Case TypeOfAccess
                Case Access.TypeOfAccess.View
                    _TypeOfAccess = "uac.useraccess_view"
                Case Access.TypeOfAccess.Add
                    _TypeOfAccess = "uac.useraccess_add"
                Case Access.TypeOfAccess.Edit
                    _TypeOfAccess = "uac.useraccess_edit"
                Case Access.TypeOfAccess.Delete
                    _TypeOfAccess = "uac.useraccess_delete"
                Case Access.TypeOfAccess.Report
                    _TypeOfAccess = "uac.useraccess_reports"
            End Select

            Try
                Dim _IsRoot As Integer = 0
                _DBR_MSSQL2008(1).Query = String.Format("select count(usr.user_id) from dbo.[[sys]]user] usr where (usr.user_id = '{0}') and (usr.user_root = 1)", UID)

                _IsRoot = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)

                If _IsRoot = 1 Then
                    Return True
                Else
                    _DBR_MSSQL2008(1).Query = String.Format("select count(uac.useraccess_id) as [useraccess_id] from dbo.[[sys]]useraccess] uac inner join dbo.[[sys]]module] mo on mo.module_id = uac.useraccess_module where (mo.module_code = '{0}') and (uac.useraccess_user = '{1}') and ({2} = 1)", TCode, UID, _TypeOfAccess)
                    _View = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)

                    If _View = 0 Then
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
        Private _DBR_MSSQL2008(2) As Database.Adapter.MSSQL2008.Display.Request

        Public Function Exist(ByVal TCODE As String) As Boolean
            Dim _isExist As Boolean = False

            Try
                _DBR_MSSQL2008(1).Query = String.Format("select count(mo.module_id) from dbo.[[sys]]module] mo where mo.module_code = '{0}'", TCODE)
                _isExist = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)

                Return _isExist
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Function Locked(ByVal TCODE As String) As Boolean
            Dim _isLocked As Boolean = False

            Try
                _DBR_MSSQL2008(1).Query = String.Format("select count(mo.module_id) from dbo.[[sys]]module] mo where mo.module_code = '{0}' and mo.module_ismaintenance = 'true'", TCODE)
                _isLocked = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(1).Query)

                Return _isLocked
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Function DisplayAutoComplete() As DataSet
            Try
                _DS = New DataSet

                _DBR_MSSQL2008(2).Query = "select mods.module_code from dbo.[[sys]]module] mods where mods.module_issystem = 0 order by mods.module_code"

                _DS = _DBE_MSSQL2008.GETDATASET(_DBR_MSSQL2008(2), "TCMD")

                Return _DS
            Catch ex As Exception
                MsgBox(ex.ToString)
                Return Nothing
            End Try
        End Function

        Public Function MaxPDFAllowed() As Decimal
            Dim _SettingValue As Decimal = 0

            Try
                _DBR_MSSQL2008(0).Query = String.Format("select top 1 s.settings_uploadpdf from db_universe_erp.dbo.[[sys]]settings] s")

                _SettingValue = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)
            Catch ex As Exception
                _SettingValue = 0.9
            End Try

            Return _SettingValue
        End Function

        Public Function MaxPhotoAllowed() As Decimal
            Dim _SettingValue As Decimal = 0

            Try
                _DBR_MSSQL2008(0).Query = String.Format("select top 1 s.settings_uploadphoto from db_universe_erp.dbo.[[sys]]settings] s")

                _SettingValue = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)
            Catch ex As Exception
                _SettingValue = 0.9
            End Try

            Return _SettingValue
        End Function

        Public Function MinPasswordLength() As Integer
            Dim _MinPasswordLength As Integer = 0

            Try
                _DBR_MSSQL2008(0).Query = String.Format("select top 1 s.settings_minpasswordlength from db_universe_erp.dbo.[[sys]]settings] s")

                _MinPasswordLength = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)
            Catch ex As Exception
                _MinPasswordLength = 8
            End Try

            Return _MinPasswordLength
        End Function

        Public Function TextMark(ByVal IsAdministrator As Boolean) As String
            Dim _Value As Integer = 0
            Dim _SettingValue As String = String.Empty

            Try
                _DBR_MSSQL2008(0).Query = String.Format("select s.settings_showwatermark from dbo.[[sys]]settings] s where s.settings_id = 1")
                _Value = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

                _DBR_MSSQL2008(0).Query = String.Format("select top 1 s.settings_textmark from db_universe_erp.dbo.[[sys]]settings] s")

                If (_Value = 1 And IsAdministrator = True) Or (_Value = 2 And IsAdministrator = False) Or (_Value = 3) Then
                    _SettingValue = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)
                Else
                    _SettingValue = String.Empty
                End If
            Catch ex As Exception
                _SettingValue = String.Empty
            End Try

            Return _SettingValue
        End Function
    End Class

    Public Class Notification
        Private _DBR_MSSQL2008(1) As Database.Adapter.MSSQL2008.Display.Request

        Public Function Exist(ByVal EmployeeID As String) As Integer
            Dim _isExist As Integer = 0

            Try
                _DBR_MSSQL2008(0).Query = String.Format("select count(nt.notification_id) as [new_notification] from dbo.[[sys]]notification] nt where (nt.notification_employee = '{0}') and (nt.notification_isread = 0)", EmployeeID)
                _isExist = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

                Return _isExist
            Catch ex As Exception
                Return 0
            End Try
        End Function
    End Class

    Public Class RunningText
        Private _DBR_MSSQL2008(1) As Database.Adapter.MSSQL2008.Display.Request

        Public Function Show(Optional ByVal IsAdministrator As Boolean = False) As Integer
            Dim _Value As Integer = 0

            Try
                _DBR_MSSQL2008(0).Query = String.Format("select s.settings_showrunningtext from dbo.[[sys]]settings] s where s.settings_id = 1")
                _Value = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

                If _Value = 1 And IsAdministrator = True Then
                    Return True
                ElseIf _Value = 2 And IsAdministrator = False Then
                    Return True
                ElseIf _Value = 3 Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                Return 0
            End Try
        End Function
    End Class

    Public Class StorageSense
        Private _DBR_MSSQL2008(0) As Database.Adapter.MSSQL2008.Display.Request

        Public Function Show(Optional ByVal IsAdmininstrator As Boolean = False) As Boolean
            Dim _Value As Integer = 0

            Try
                _DBR_MSSQL2008(0).Query = String.Format("select top 1 s.settings_showstorage from dbo.[[sys]]settings] s")
                _Value = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

                If _Value = 1 And IsAdmininstrator = True Then
                    Return True
                ElseIf _Value = 2 And IsAdmininstrator = False Then
                    Return True
                ElseIf _value = 3 Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Function DataCurrentSize() As Double
            Dim _Size As Double = 0

            Try
                _DBR_MSSQL2008(0).Query = String.Format("SELECT (size*8)/1024 AS SizeMB FROM sys.database_files where name='db_universe_erp'")
                _Size = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

                Return _Size
            Catch ex As Exception
                Return 0
            End Try
        End Function

        Public Function FileCurrentSize() As Double
            Dim _Size As Double = 0

            Try
                _DBR_MSSQL2008(0).Query = String.Format("SELECT (size*8)/1024 AS SizeMB FROM sys.database_files where name='db_universe_erp_file'")
                _Size = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query, "db_universe_erp_file")

                Return _Size
            Catch ex As Exception
                Return 0
            End Try
        End Function

        Public Function MaxSize() As String
            Dim _Size As String = String.Empty

            Try
                _DBR_MSSQL2008(0).Query = String.Format("SELECT max_db_size_in_gb = CASE WHEN engine_edition = 4 THEN CASE WHEN d.sversion_name LIKE '%2012%' THEN 10 WHEN d.sversion_name LIKE '%2008 R2%' THEN 10 WHEN d.sversion_name LIKE '%2008%' THEN 4 WHEN d.sversion_name LIKE '%2005%' THEN 4 END ELSE '∞' END FROM (SELECT sversion_name = SUBSTRING(v.ver, 0, CHARINDEX('-', v.ver) - 1), engine_edition = SERVERPROPERTY('EngineEdition'), edition = SERVERPROPERTY('Edition'), server_name = SERVERPROPERTY('ServerName') FROM (SELECT ver = @@VERSION) v) d")
                _Size = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query, "db_universe_erp_file")

                Return _Size
            Catch ex As Exception
                Return "0"
            End Try
        End Function
    End Class

    Public Class ProfilePanel
        Private _DBR_MSSQL2008(1) As Database.Adapter.MSSQL2008.Display.Request
        Private _IMG As New CMCv.ImageEditor.Proccessor.Compress

        Public Function GETPhoto(ByVal EmployeeID As String, ByVal Gender As String) As System.Drawing.Image
            Dim _Photo As System.Drawing.Image = Nothing
            Dim _Bytes As Byte() = Nothing

            Try
                _DBR_MSSQL2008(0).Query = String.Format("select f.file_content from db_universe_erp_file.dbo.[[sto]]file] f where f.file_parent = '{0}' and f.file_tag = 'EMPLOYEE-PROFILE-PHOTO' and f.file_filetype = 'jpg'", EmployeeID)
                _Bytes = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

                If Not IsNothing(_Bytes) Then
                    _Photo = _IMG.OutputAsImage(_Bytes)
                Else
                    If (Gender = "MALE") Or (Gender = "") Then
                        _Photo = My.Resources.MALE_001_512_icon

                    Else
                        _Photo = My.Resources.FEMALE_001_512_icon
                    End If
                End If

                Return _Photo
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function Show(Optional ByVal IsAdministrator As Boolean = False) As Boolean
            Dim _Value As Integer = 0

            Try
                _DBR_MSSQL2008(0).Query = String.Format("select top 1 s.settings_showprofile from dbo.[[sys]]settings] s")
                _Value = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

                If _Value = 1 And IsAdministrator = True Then
                    Return True
                ElseIf _Value = 2 And IsAdministrator = False Then
                    Return True
                ElseIf _Value = 3 Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                Return False
            End Try
        End Function


        Public Function Welcome() As String
            Dim _Welcome As String = String.Empty

            Try
                _DBR_MSSQL2008(0).Query = String.Format("select top 1 t.template_text1 from dbo.[[doc]]template] t where t.template_module = 'F2887E94E365C068D1CCB3FF03DB7969' and t.template_title = 'PROFILE' order by newid()")
                _Welcome = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

                Return _Welcome
            Catch ex As Exception
                Return "Welcome,"
            End Try
        End Function

    End Class
End Namespace

