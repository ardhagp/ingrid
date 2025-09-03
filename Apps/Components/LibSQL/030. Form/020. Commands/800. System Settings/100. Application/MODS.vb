Imports System
Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.MODS
    Public Class View
        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(ByVal DBEngine As String, ByVal DataGrid As dgn, ByVal StatusBar As stt, ByVal Find As txt, Optional ByVal ForceRefresh As Boolean = False)
            If (Find.XOSQLText = String.Empty) OrElse (ForceRefresh = True) Then
                V_DBR_MSSQL2008(0).Query = String.Format("select modg.modulegroup_name, mods.module_code, mods.module_name, mods.module_description, mods.module_issystem, mods.module_ismaintenance, mods.module_id from dbo.[[sys]]module] mods inner join dbo.[[sys]]modulegroup] modg on modg.modulegroup_id = mods.module_modulegroup order by modg.modulegroup_order, mods.module_code")
            Else
                V_DBR_MSSQL2008(0).Query = String.Format("select modg.modulegroup_name, mods.module_code, mods.module_name, mods.module_description, mods.module_issystem, mods.module_ismaintenance, mods.module_id from dbo.[[sys]]module] mods inner join dbo.[[sys]]modulegroup] modg on modg.modulegroup_id = mods.module_modulegroup where (mods.module_code = '{0}') or (mods.module_name like '%{0}%') order by modg.modulegroup_order, mods.module_code", Find.XOSQLText)
            End If
            V_DBR_MSSQL2008(0).DataGrid = DataGrid
            V_DBR_MSSQL2008(0).StatusBar = StatusBar
            V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TMODS", "db_universe_erp")
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DELETEData(ByVal DBEngine As String, ByVal RowID As String) As Boolean
            Dim V_Success As Boolean = False
            Try
                V_DBR_MSSQL2008(1).Query = String.Format("delete from dbo.[[sys]]module] where module_id = '{0}'", RowID)
                V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query, "db_universe_erp")
                V_Success = True
            Catch ex As Exception
                V_Success = False
            End Try
            Return V_Success
        End Function

    End Class

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(ByVal DBEngine As String, ByVal Code As String, Optional ByVal RowID As String = "") As Boolean
            Dim V_IsDuplicate As Boolean = False

            Try
                If RowID = String.Empty Then
                    V_DBR_MSSQL2008(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.[[sys]]module] mods where mods.module_code = '{0}'", Code.ToUpper)
                Else
                    V_DBR_MSSQL2008(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.[[sys]]module] mods where mods.module_code = '{0}' and mods.module_id <> '{1}'", Code.ToUpper, RowID.ToUpper)
                End If

                V_IsDuplicate = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query, "db_universe_erp"), Boolean)

                Return V_IsDuplicate
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
            Dim V_Code As String = String.Empty

            V_DBR_MSSQL2008(0).Query = String.Format("select mods.module_code from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
            V_Code = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query, "db_universe_erp").ToString

            Return V_Code
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETMODName(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_Name As String = String.Empty

            V_DBR_MSSQL2008(0).Query = String.Format("select mods.module_name from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
            V_Name = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query, "db_universe_erp").ToString

            Return V_Name
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETMODGroupID(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_GroupID As String = String.Empty

            V_DBR_MSSQL2008(0).Query = String.Format("select mods.module_modulegroup from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
            V_GroupID = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query, "db_universe_erp").ToString

            Return V_GroupID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETMODDescription(ByVal DBEngine As String, ByVal RowID As String) As String
            Dim V_Description As String = String.Empty

            V_DBR_MSSQL2008(0).Query = String.Format("select mods.module_description from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
            V_Description = V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query, "db_universe_erp").ToString

            Return V_Description
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETMODSystem(ByVal DBEngine As String, ByVal RowID As String) As Boolean
            Dim V_IsSystem As Boolean = False

            Try
                V_DBR_MSSQL2008(0).Query = String.Format("select mods.module_issystem from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
                V_IsSystem = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query, "db_universe_erp"), Boolean)

                Return V_IsSystem
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GETMODLocked(ByVal DBEngine As String, ByVal RowID As String) As Boolean
            Dim V_IsLocked As Boolean = False

            Try
                V_DBR_MSSQL2008(0).Query = String.Format("select mods.module_ismaintenance from dbo.[[sys]]module] mods where mods.module_id = '{0}'", RowID)
                V_IsLocked = CType(V_DBE_MSSQL2008.GETVALUE(V_DBR_MSSQL2008(0).Query, "db_universe_erp"), Boolean)

                Return V_IsLocked
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PUSHData(ByVal DBEngine As String, ByVal ID As String, ByVal GroupID As String, ByVal Code As String, ByVal Name As String, ByVal Description As String, ByVal IsSystem As Boolean, ByVal IsLocked As Boolean, Optional ByVal RowID As String = "") As Boolean
            Dim V_Success As Boolean = False

            Try
                If RowID = "-1" Then
                    V_DBR_MSSQL2008(1).Query = String.Format("insert into dbo.[[sys]]module](module_id, module_modulegroup, module_code, module_name, module_description, module_issystem, module_ismaintenance) " &
                                                            "values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", ID, GroupID, Code, Name, Description, IsSystem, IsLocked)
                Else
                    V_DBR_MSSQL2008(1).Query = String.Format("update dbo.[[sys]]module] set module_modulegroup = '{0}', module_name = '{1}', module_description = '{2}', module_issystem = '{3}', module_ismaintenance = '{4}' " &
                                                            "where module_id = '{5}'", GroupID, Name, Description, IsSystem, IsLocked, RowID)
                End If

                V_DBE_MSSQL2008.PUSHDATA(V_DBR_MSSQL2008(1).Query, "db_universe_erp")

                V_Success = True
                Return V_Success
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Class
End Namespace
