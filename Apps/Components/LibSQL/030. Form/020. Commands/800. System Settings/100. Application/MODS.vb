Imports System
Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.MODS
    Public Class View
        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayData(databasename As String, dbengine As String, datagrid As dgn, statusbar As stt, find As txt, Optional forcerefresh As Boolean = False)
            If (find.XOSQLText = String.Empty) OrElse (forcerefresh = True) Then
                V_DBR_MSSQL2008(0).Query = String.Format("select modg.modulegroup_name, mods.module_code, mods.module_name, mods.module_description, mods.module_issystem, mods.module_ismaintenance, mods.module_id from dbo.sys_module mods inner join dbo.[[sys]]modulegroup] modg on modg.modulegroup_id = mods.module_modulegroup order by modg.modulegroup_order, mods.module_code")
            Else
                V_DBR_MSSQL2008(0).Query = String.Format("select modg.modulegroup_name, mods.module_code, mods.module_name, mods.module_description, mods.module_issystem, mods.module_ismaintenance, mods.module_id from dbo.sys_module mods inner join dbo.[[sys]]modulegroup] modg on modg.modulegroup_id = mods.module_modulegroup where (mods.module_code = '{0}') or (mods.module_name like '%{0}%') order by modg.modulegroup_order, mods.module_code", find.XOSQLText)
            End If

            V_DBR_MSSQL2008(0).DataGrid = datagrid
            V_DBR_MSSQL2008(0).StatusBar = statusbar
            V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(0), "TMODS")
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function DeleteData(databasename As String, dbengine As String, rowid As String) As Boolean
            Dim varSuccess As Boolean = False
            Try
                V_DBR_MSSQL2008(1).Query = String.Format("delete from dbo.sys_module where module_id = '{0}'", rowid)
                V_DBE_MSSQL2008.PushData(V_DBR_MSSQL2008(1).Query, "db_universe_erp")
                varSuccess = True
            Catch ex As Exception
                varSuccess = False
            End Try
            Return varSuccess
        End Function

    End Class

    Public Class Editor
        <SupportedOSPlatform("windows")>
        Public Shared Function IsDuplicate(databasename As String, dbengine As String, code As String, Optional rowid As String = "") As Boolean
            Dim varIsDuplicate As Boolean = False

            Try
                If rowid = String.Empty Then
                    V_DBR_MSSQL2008(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.sys_module mods where mods.module_code = '{0}'", code.ToUpper)
                Else
                    V_DBR_MSSQL2008(0).Query = String.Format("select count(mods.module_id) as module_found from dbo.sys_module mods where mods.module_code = '{0}' and mods.module_id <> '{1}'", code.ToUpper, rowid.ToUpper)
                End If

                varIsDuplicate = CType(V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(0).Query), Boolean)

                Return varIsDuplicate
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Sub FillModuleGroup(databasename As String, dbengine As String, modulegroup As cbo)
            V_DBR_MSSQL2008(1).Query = "select modg.modulegroup_id, modg.modulegroup_name from dbo.[[sys]]modulegroup] modg order by modg.modulegroup_order"
            V_DBR_MSSQL2008(1).Dropdown = modulegroup
            V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(1), "TModuleGroup")
            modulegroup.ValueMember = "modulegroup_id"
            modulegroup.DisplayMember = "modulegroup_name"
        End Sub

        <SupportedOSPlatform("windows")>
        Public Shared Function GetMODcode(databasename As String, dbengine As String, ByVal rowid As String) As String
            Dim varCode As String

            V_DBR_MSSQL2008(0).Query = String.Format("select mods.module_code from dbo.sys_module mods where mods.module_id = '{0}'", rowid)
            varCode = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(0).Query).ToString

            Return varCode
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetMODname(databasename As String, dbengine As String, rowid As String) As String
            Dim varName As String

            V_DBR_MSSQL2008(0).Query = String.Format("select mods.module_name from dbo.sys_module mods where mods.module_id = '{0}'", rowid)
            varName = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(0).Query).ToString

            Return varName
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetMODgroupid(databasename As String, dbengine As String, rowid As String) As String
            Dim varGroupID As String

            V_DBR_MSSQL2008(0).Query = String.Format("select mods.module_modulegroup from dbo.sys_module mods where mods.module_id = '{0}'", rowid)
            varGroupID = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(0).Query).ToString

            Return varGroupID
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetMODdescription(databasename As String, dbengine As String, rowid As String) As String
            Dim varDescription As String

            V_DBR_MSSQL2008(0).Query = String.Format("select mods.module_description from dbo.sys_module mods where mods.module_id = '{0}'", rowid)
            varDescription = V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(0).Query).ToString

            Return varDescription
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetMODsystem(databasename As String, dbengine As String, rowid As String) As Boolean
            Dim varIsSystem As Boolean

            Try
                V_DBR_MSSQL2008(0).Query = String.Format("select mods.module_issystem from dbo.sys_module mods where mods.module_id = '{0}'", rowid)
                varIsSystem = CType(V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(0).Query), Boolean)

                Return varIsSystem
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetMODlocked(databasename As String, ByVal dbengine As String, rowid As String) As Boolean
            Dim varIsLocked As Boolean

            Try
                V_DBR_MSSQL2008(0).Query = String.Format("select mods.module_ismaintenance from dbo.sys_module mods where mods.module_id = '{0}'", rowid)
                varIsLocked = CType(V_DBE_MSSQL2008.GetValue(databasename, V_DBR_MSSQL2008(0).Query), Boolean)

                Return varIsLocked
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function PushData(databasename As String, dbengine As String, id As String, groupid As String, code As String, name As String, description As String, issystem As Boolean, islocked As Boolean, Optional rowid As String = "") As Boolean
            Dim varSuccess As Boolean = False

            Try
                If rowid = "-1" Then
                    V_DBR_MSSQL2008(1).Query = String.Format("insert into dbo.sys_module(module_id, module_modulegroup, module_code, module_name, module_description, module_issystem, module_ismaintenance) " &
                                                            "values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", id, groupid, code, name, description, issystem, islocked)
                Else
                    V_DBR_MSSQL2008(1).Query = String.Format("update dbo.sys_module set module_modulegroup = '{0}', module_name = '{1}', module_description = '{2}', module_issystem = '{3}', module_ismaintenance = '{4}' " &
                                                            "where module_id = '{5}'", groupid, name, description, issystem, islocked, rowid)
                End If

                V_DBE_MSSQL2008.PushData(databasename, V_DBR_MSSQL2008(1).Query)

                varSuccess = True
                Return varSuccess
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Class
End Namespace
