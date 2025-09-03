Imports System
Imports System.Runtime.Versioning
Imports CMCv

Namespace Commands.DRTM
    Public Class View
        Public V_IsEmpFilter As Boolean
        Public V_EID As String
        Public V_ContentID As String

        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayGrid(ByVal DBEngine As String, ByVal Find As txt, ByVal DateGrid As dgn, ByVal ContentStatusBar As stt, Optional ByVal ForceRefresh As Boolean = False)
            Try
                Dim V_Where As String = String.Format("where ")

                If DBEngine = "MSSQL" Then
                    If (Find.XOSQLText = String.Empty) AndAlso (ForceRefresh = True) Then
                        V_Where += "tpl.template_module = (select mdl.module_id from dbo.[[sys]]module] mdl where mdl.module_code = 'DAR') "
                    Else
                        V_Where += "tpl.template_module = (select mdl.module_id from dbo.[[sys]]module] mdl where mdl.module_code = 'DAR') and "

                        Dim V_ContainText() As String = Find.XOSQLText.Split("||")
                        Dim V_Repeater As Integer = 0

                        V_Where += String.Format("(")

                        For Each V_Text As String In V_ContainText
                            If V_Text <> "" Then
                                If V_Repeater = 0 Then
                                    V_Where += String.Format("tpl.template_text1 like '%{0}%'", V_Text)
                                Else
                                    V_Where += String.Format(" and tpl.template_text1 like '%{0}%'", V_Text)
                                End If
                            End If
                            V_Repeater += 1
                        Next

                        V_Where += String.Format(")")
                    End If

                    V_DBR_MSSQL2008(0).Query = String.Format("select tpl.template_id, tpl.template_title, tpl.template_text1 from dbo.[[doc]]template] tpl {0} order by tpl.template_title", V_Where)

                    V_DBR_MSSQL2008(0).DataGrid = DateGrid
                    V_DBR_MSSQL2008(0).StatusBar = ContentStatusBar
                    V_DBE_MSSQL2008.GETDATATABLE(V_DBR_MSSQL2008(0), "TDARTemplate")
                ElseIf DBEngine = "MYSQL" Then
                    If (Find.XOSQLText = String.Empty) AndAlso (ForceRefresh = True) Then
                        V_Where += "tpl.template_module = (select mdl.module_id from sys_module mdl where mdl.module_code = 'DAR') "
                    Else
                        V_Where += "tpl.template_module = (select mdl.module_id from sys_module mdl where mdl.module_code = 'DAR') and "

                        Dim V_ContainText() As String = Find.XOSQLText.Split("||")
                        Dim V_Repeater As Integer = 0

                        V_Where += String.Format("(")

                        For Each V_Text As String In V_ContainText
                            If V_Text <> "" Then
                                If V_Repeater = 0 Then
                                    V_Where += String.Format("tpl.template_text1 like '%{0}%'", V_Text)
                                Else
                                    V_Where += String.Format(" and tpl.template_text1 like '%{0}%'", V_Text)
                                End If
                            End If
                            V_Repeater += 1
                        Next

                        V_Where += String.Format(")")
                    End If

                    V_DBR_MYSQL(0).Query = String.Format("select tpl.template_id, tpl.template_title, tpl.template_text1 from doc_template tpl {0} order by tpl.template_title", V_Where)

                    V_DBR_MYSQL(0).DataGrid = DateGrid
                    V_DBR_MYSQL(0).StatusBar = ContentStatusBar
                    V_DBE_MYSQL.GETDATATABLE(V_DBR_MYSQL(0), "TDARTemplate")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub
    End Class

    Public Class Editor

    End Class
End Namespace
