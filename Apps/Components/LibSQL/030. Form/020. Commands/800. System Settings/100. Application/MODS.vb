Imports CMCv

Namespace Commands.MODS
    Public Class View
        Public Sub DisplayData(ByVal DataGrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            If (Find.SLFSQLText = String.Empty) Or (ForceRefresh = True) Then
                _DBR_MSSQL2008(0).Query = String.Format("select modg.modulegroup_name, mods.module_code, mods.module_name, mods.module_description, mods.module_issystem, mods.module_ismaintenance, mods.module_id from dbo.[[sys]]module] mods inner join dbo.[[sys]]modulegroup] modg on modg.modulegroup_id = mods.module_modulegroup order by modg.modulegroup_order, mods.module_code")
            Else
                _DBR_MSSQL2008(0).Query = String.Format("select modg.modulegroup_name, mods.module_code, mods.module_name, mods.module_description, mods.module_issystem, mods.module_ismaintenance, mods.module_id from dbo.[[sys]]module] mods inner join dbo.[[sys]]modulegroup] modg on modg.modulegroup_id = mods.module_modulegroup where (mods.module_code = '{0}') or (mods.module_name like '%{0}%') order by modg.modulegroup_order, mods.module_code", Find.SLFSQLText)
            End If
            _DBR_MSSQL2008(0).DataGrid = DataGrid
            _DBR_MSSQL2008(0).StatusBar = StatusBar
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TMODS")
        End Sub

        Public Function DELETEData(ByVal RowID As String) As Boolean
            Dim _Success As Boolean = False
            Try
                _DBR_MSSQL2008(1).Query = String.Format("delete from dbo.[[sys]]module] where module_id = '{0}'", RowID)
                _DBE_MSSQL2008.PUSHDATA(_DBR_MSSQL2008(1).Query)
                _Success = True
            Catch ex As Exception
                _Success = False
            End Try
            Return _Success
        End Function

    End Class

    Public Class Editor
        Public Function IsDuplicate(ByVal Code As String, Optional ByVal RowID As String = "") As Boolean
            Dim _IsDuplicate As Boolean = False

            Try
                If RowID = String.Empty Then
                    _DBR_MSSQL2008(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.[[sys]]module] mods where mods.module_code = '{0}'", Code.ToUpper)
                Else
                    _DBR_MSSQL2008(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.[[sys]]module] mods where mods.module_code = '{0}' and mods.module_id <> '{1}'", Code.ToUpper, RowID.ToUpper)
                End If

                _IsDuplicate = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

                Return _IsDuplicate
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Sub FILLModuleGroup(ByVal ModuleGroup As cbo)
            _DBR_MSSQL2008(1).Query = "select modg.modulegroup_id, modg.modulegroup_name from dbo.[[sys]]modulegroup] modg order by modg.modulegroup_order"
            _DBR_MSSQL2008(1).Dropdown = ModuleGroup
            _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(1), "TModuleGroup")
            ModuleGroup.ValueMember = "modulegroup_id"
            ModuleGroup.DisplayMember = "modulegroup_name"
        End Sub

        Public Function GETMODCode(ByVal RowID As String) As String
            Dim _Code As String = String.Empty

            _DBR_MSSQL2008(0).Query = String.Format("select mods.module_code from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
            _Code = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

            Return _Code
        End Function

        Public Function GETMODName(ByVal RowID As String) As String
            Dim _Name As String = String.Empty

            _DBR_MSSQL2008(0).Query = String.Format("select mods.module_name from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
            _Name = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

            Return _Name
        End Function

        Public Function GETMODGroupID(ByVal RowID As String) As String
            Dim _GroupID As String = String.Empty

            _DBR_MSSQL2008(0).Query = String.Format("select mods.module_modulegroup from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
            _GroupID = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

            Return _GroupID
        End Function

        Public Function GETMODDescription(ByVal RowID As String) As String
            Dim _Description As Object = Nothing

            _DBR_MSSQL2008(0).Query = String.Format("select mods.module_description from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
            _Description = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

            Return IIf(IsDBNull(_Description), "", _Description)

        End Function

        Public Function GETMODSystem(ByVal RowID As String) As Boolean
            Dim _IsSystem As Boolean = False

            Try
                _DBR_MSSQL2008(0).Query = String.Format("select mods.module_issystem from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
                _IsSystem = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

                Return _IsSystem
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Function GETMODLocked(ByVal RowID As String) As Boolean
            Dim _IsLocked As Boolean = False

            Try
                _DBR_MSSQL2008(0).Query = String.Format("select mods.module_ismaintenance from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
                _IsLocked = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

                Return _IsLocked
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Function PUSHData(ByVal ID As String, ByVal GroupID As String, ByVal Code As String, ByVal Name As String, ByVal Description As String, ByVal IsSystem As Boolean, ByVal IsLocked As Boolean, Optional ByVal RowID As String = "") As Boolean
            Dim _Success As Boolean = False

            Try
                If RowID = "-1" Then
                    _DBR_MSSQL2008(1).Query = String.Format("insert into dbo.[[sys]]module](module_id, module_modulegroup, module_code, module_name, module_description, module_issystem, module_ismaintenance) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", ID, GroupID, Code, Name, Description, IsSystem, IsLocked)
                Else
                    _DBR_MSSQL2008(1).Query = String.Format("update dbo.[[sys]]module] set module_modulegroup = '{0}', module_name = '{1}', module_description = '{2}', module_issystem = '{3}', module_ismaintenance = '{4}' where module_id = '{5}'", GroupID, Name, Description, IsSystem, IsLocked, RowID)
                End If

                _DBE_MSSQL2008.PUSHDATA(_DBR_MSSQL2008(1).Query)

                _Success = True
                Return _Success
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Class
End Namespace
