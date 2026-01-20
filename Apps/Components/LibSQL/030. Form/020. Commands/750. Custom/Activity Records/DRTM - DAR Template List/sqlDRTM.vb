Imports System
Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.DRTM
    Public Class View
        Public varIsEmpFilter As Boolean
        Public varEID As String
        Public varContentID As String

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayGrid(databasename As String, dbengine As String, find As txt, dategrid As dgn, contentstatusbar As stt, Optional forcerefresh As Boolean = False)
            Try
                Dim varWhere As String = String.Format("where ")

                If dbengine = "MSSQL" Then
                    If (find.XOSQLText = String.Empty) AndAlso (forcerefresh = True) Then
                        varWhere += "tpl.template_module = (select mdl.module_id from dbo.sys_module mdl where mdl.module_code = 'DAR') "
                    Else
                        varWhere += "tpl.template_module = (select mdl.module_id from dbo.sys_module mdl where mdl.module_code = 'DAR') and "

                        Dim varContainText() As String = find.XOSQLText.Split("||")
                        Dim varRepeater As Integer = 0

                        varWhere += String.Format("(")

                        For Each varText As String In varContainText
                            If varText <> "" Then
                                If varRepeater = 0 Then
                                    varWhere.Append(CChar($"tpl.template_text1 LIKE '%{varText}%'"))
                                Else
                                    varWhere.Append(CChar($" and tpl.template_text1 like '%{varText}%'"))
                                End If
                            End If
                            varRepeater += 1
                        Next

                        varWhere += String.Format(")")
                    End If

                    V_DBR_MSSQL2008(0).Query = String.Format("select tpl.template_id, tpl.template_title, tpl.template_text1 from dbo.doc_template tpl {0} order by tpl.template_title", varWhere)

                    V_DBR_MSSQL2008(0).DataGrid = dategrid
                    V_DBR_MSSQL2008(0).StatusBar = contentstatusbar
                    V_DBE_MSSQL2008.GetDataTable(databasename, V_DBR_MSSQL2008(0), "TDARTemplate")
                ElseIf dbengine = "MYSQL" Then
                    If (find.XOSQLText = String.Empty) AndAlso (forcerefresh) Then
                        varWhere += "tpl.template_module = (select mdl.module_id from sys_module mdl where mdl.module_code = 'DAR') "
                    Else
                        varWhere += "tpl.template_module = (select mdl.module_id from sys_module mdl where mdl.module_code = 'DAR') and "

                        Dim varContainText() As String = find.XOSQLText.Split("||")
                        Dim varRepeater As Integer = 0

                        varWhere.Append(CChar("("))

                        For Each varText As String In varContainText
                            If varText <> "" Then
                                If varRepeater = 0 Then
                                    varWhere.Append(CChar($"tpl.template_text1 like '%{varText}%'"))
                                Else
                                    varWhere.Append(CChar($" and tpl.template_text1 like '%{varText}%'"))
                                End If
                            End If
                            varRepeater += 1
                        Next

                        varWhere.Append(CChar(")"))
                    End If

                    V_DBR_MYSQL(0).Query = String.Format("select tpl.template_id, tpl.template_title, tpl.template_text1 from doc_template tpl {0} order by tpl.template_title", varWhere)

                    V_DBR_MYSQL(0).DataGrid = dategrid
                    V_DBR_MYSQL(0).StatusBar = contentstatusbar
                    V_DBE_MYSQL.GetDataTable(databasename, V_DBR_MYSQL(0), "TDARTemplate")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub
    End Class

    Public Class Editor
        'TODO: Build
    End Class
End Namespace
