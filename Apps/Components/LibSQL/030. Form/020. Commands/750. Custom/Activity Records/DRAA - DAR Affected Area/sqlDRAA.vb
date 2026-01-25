Imports System
Imports System.Runtime.Versioning
Imports CMCv

Namespace CMDdraa
    Public Class View
        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayMainGrid(databasename As String, find As txt, contentgrid As dgn, contentstatusbar As stt, Optional forcerefresh As Boolean = False)
            Try
                Dim varWhere As String = String.Format("where ")

                If (find.XOSQLText = String.Empty) AndAlso (forcerefresh) Then
                    varWhere += String.Format("(aa.areaaffected_name like '%{0}%')", find.XOSQLText)
                Else
                    If find.XOSQLText = String.Empty Then

                    ElseIf find.XOSQLText.Trim.Contains("||") = False Then
                        varWhere += String.Format("(aa.areaaffected_name like '%{0}%')", find.XOSQLText)
                    Else
                        Dim varContainText() As String = find.XOSQLText.Split("||")
                        Dim varRepeater As Integer = 0

                        varWhere += String.Format("(")

                        For Each varText As String In varContainText
                            If varText <> "" Then
                                If varRepeater = 0 Then
                                    varWhere.Append(CChar($"aa.areaaffected_name like '%{varText}%'"))
                                Else
                                    varWhere.Append(CChar($" and aa.areaaffected_name like '%{varText}%'"))
                                End If
                            End If

                            varRepeater += 1
                        Next

                        varWhere += String.Format(")")
                    End If

                End If

                varDatabaseRequestMssql2008(0).Query = String.Format("select aa.areaaffected_id, aa.areaaffected_order, aa.areaaffected_name from dbo.doc_areaaffected aa {0} order by aa.areaaffected_order, aa.areaaffected_name", varWhere)

                varDatabaseRequestMssql2008(0).DataGrid = contentgrid
                varDatabaseRequestMssql2008(0).StatusBar = contentstatusbar
                varDatabaseEngineMssql2008.GetDataTable(databasename, varDatabaseRequestMssql2008(0), "TAreaAffected")

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub
    End Class

    Public Class Editor

    End Class
End Namespace
