Imports System
Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.MODS
    Public Class View
        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(ByVal DBEngine As String, ByVal DataGrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh = True) Then
                varDBreader_mssql2008(0).Query = String.Format("select modg.modulegroup_name, mods.module_code, mods.module_name, mods.module_description, mods.module_issystem, mods.module_ismaintenance, mods.module_id from dbo.[[sys]]module] mods inner join dbo.[[sys]]modulegroup] modg on modg.modulegroup_id = mods.module_modulegroup order by modg.modulegroup_order, mods.module_code")
            Else
                varDBreader_mssql2008(0).Query = String.Format("select modg.modulegroup_name, mods.module_code, mods.module_name, mods.module_description, mods.module_issystem, mods.module_ismaintenance, mods.module_id from dbo.[[sys]]module] mods inner join dbo.[[sys]]modulegroup] modg on modg.modulegroup_id = mods.module_modulegroup where (mods.module_code = '{0}') or (mods.module_name like '%{0}%') order by modg.modulegroup_order, mods.module_code", Find.XOSQLText)
            End If
            varDBreader_mssql2008(0).DataGrid = DataGrid
            varDBreader_mssql2008(0).StatusBar = StatusBar
            varDBengine_mssql2008.GETDATATABLE(varDBreader_mssql2008(0), "TMODS", "db_universe_erp")
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DELETEData(ByVal DBEngine As String, ByVal RowID As String) As Boolean
            Dim _Success As Boolean
            Try
                varDBreader_mssql2008(1).Query = String.Format("delete from dbo.[[sys]]module] where module_id = '{0}'", RowID)
                varDBengine_mssql2008.PUSHDATA(varDBreader_mssql2008(1).Query, "db_universe_erp")
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function

    End Class

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(ByVal DBEngine As String, ByVal Code As String, Optional ByVal RowID As String = "") As Boolean
            Dim _IsDuplicate As Boolean

            Try
                If RowID = String.Empty Then
                    varDBreader_mssql2008(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.[[sys]]module] mods where mods.module_code = '{0}'", Code.ToUpper)
                Else
                    varDBreader_mssql2008(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.[[sys]]module] mods where mods.module_code = '{0}' and mods.module_id <> '{1}'", Code.ToUpper, RowID.ToUpper)
                End If

                varISduplicate = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp"), Boolean)

                Return varISduplicate
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Sub FILLModuleGroup(ByVal DBEngine As String, ByVal ModuleGroup As cbo)
            V_DBR_MSSQL2008(1).Query = "select modg.modulegroup_id, modg.modulegroup_name from dbo.[[sys]]modulegroup] modg order by modg.modulegroup_order"
            V_DBR_MSSQL2008(1).Dropdown = ModuleGroup
            V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(1), "TModuleGroup")
            ModuleGroup.ValueMember = "modulegroup_id"
            ModuleGroup.DisplayMember = "modulegroup_name"
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function GETMODCode(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim _Code As String

            varDBreader_mssql2008(0).Query = String.Format("select mods.module_code from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
            varCode = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp").ToString

            Return varCode
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETMODName(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim _Name As String

            varDBreader_mssql2008(0).Query = String.Format("select mods.module_name from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
            varName = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp").ToString

            Return varName
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETMODGroupID(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim _GroupID As String

            varDBreader_mssql2008(0).Query = String.Format("select mods.module_modulegroup from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
            varIDgroup = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp").ToString

            Return varIDgroup
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETMODDescription(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim _Description As String

            varDBreader_mssql2008(0).Query = String.Format("select mods.module_description from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
            varDescription = varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp").ToString

            Return varDescription
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETMODSystem(ByVal DBEngine As String, ByVal RowID As String) As Boolean
            Dim _IsSystem As Boolean

            Try
                varDBreader_mssql2008(0).Query = String.Format("select mods.module_issystem from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
                varISsystem = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp"), Boolean)

                Return varISsystem
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETMODLocked(ByVal DBEngine As String, ByVal RowID As String) As Boolean
            Dim _IsLocked As Boolean

            Try
                varDBreader_mssql2008(0).Query = String.Format("select mods.module_ismaintenance from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
                varISlocked = CType(varDBengine_mssql2008.GETVALUE(varDBreader_mssql2008(0).Query, "db_universe_erp"), Boolean)

                Return varISlocked
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHData(ByVal DBEngine As String, ByVal ID As String, ByVal GroupID As String, ByVal Code As String, ByVal Name As String, ByVal Description As String, ByVal IsSystem As Boolean, ByVal IsLocked As Boolean, Optional ByVal RowID As String = "") As Boolean
            Dim _Success As Boolean

            Try
                If RowID = "-1" Then
                    varDBreader_mssql2008(1).Query = String.Format("insert into dbo.[[sys]]module](module_id, module_modulegroup, module_code, module_name, module_description, module_issystem, module_ismaintenance) " &
                                                            "values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", ID, GroupID, Code, Name, Description, IsSystem, IsLocked)
                Else
                    varDBreader_mssql2008(1).Query = String.Format("update dbo.[[sys]]module] set module_modulegroup = '{0}', module_name = '{1}', module_description = '{2}', module_issystem = '{3}', module_ismaintenance = '{4}' " &
                                                            "where module_id = '{5}'", GroupID, Name, Description, IsSystem, IsLocked, RowID)
                End If

                varDBengine_mssql2008.PUSHDATA(varDBreader_mssql2008(1).Query, "db_universe_erp")

                varSuccess = True
                Return varSuccess
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Class
End Namespace
