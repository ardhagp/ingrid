Imports System.Runtime.Versioning
Imports CMCv

Namespace CMDdraa
    Public Class View
        <SupportedOSPlatform("windows")>
        Public Shared Sub DisplayMainGrid(dataproperties As LibApp.Ingrid.Global.Properties, find As CMCv.UI.Control.txt, contentgrid As CMCv.UI.Control.dgn, contentstatusbar As CMCv.UI.Control.stt, Optional forcerefresh As Boolean = False)
            Try
                ' Cache search text once and normalize
                Dim search As String = String.Empty
                If find IsNot Nothing AndAlso find.XOSQLText IsNot Nothing Then
                    search = find.XOSQLText.Trim()
                End If

                ' Build WHERE clause using a list then join — avoids malformed "where " and is faster than repeated string concatenation
                Dim whereParts As New List(Of String)

                If String.IsNullOrEmpty(search) Then
                    If forcerefresh Then
                        ' preserve original behaviour when forcerefresh = True and empty search -> use LIKE '%%' (returns all)
                        whereParts.Add("(aa.areaaffected_name LIKE '%%')")
                    End If
                Else
                    If Not search.Contains("||") Then
                        ' single-term search
                        Dim safe = search.Replace("'", "''")
                        whereParts.Add($"(aa.areaaffected_name LIKE '%{safe}%')")
                    Else
                        ' multi-term search separated by "||" -> require all terms (AND)
                        Dim tokens = search.Split(New String() {"||"}, StringSplitOptions.RemoveEmptyEntries)
                        Dim termParts As New List(Of String)
                        For Each t As String In tokens
                            Dim trimmed = t.Trim()
                            If trimmed <> String.Empty Then
                                Dim safe = trimmed.Replace("'", "''")
                                termParts.Add($"aa.areaaffected_name LIKE '%{safe}%'")
                            End If
                        Next

                        If termParts.Count > 0 Then
                            whereParts.Add("(" & String.Join(" AND ", termParts) & ")")
                        End If
                    End If
                End If

                Dim varWhere As String = If(whereParts.Count > 0, "WHERE " & String.Join(" AND ", whereParts), String.Empty)

                varDatabaseRequestMssql2008(0).Query = String.Format("select aa.areaaffected_id, aa.areaaffected_order, aa.areaaffected_name from dbo.doc_areaaffected aa {0} order by aa.areaaffected_order, aa.areaaffected_name", varWhere)

                varDatabaseRequestMssql2008(0).DataGrid = contentgrid
                varDatabaseRequestMssql2008(0).StatusBar = contentstatusbar
                varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TAreaAffected")

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub
        'Public Shared Sub DisplayMainGrid(databasename As String, find As txt, contentgrid As cmcv.ui.control.dgn, contentstatusbar As stt, Optional forcerefresh As Boolean = False)
        '    Try
        '        Dim varWhere As String = String.Format("where ")

        '        If (find.XOSQLText = String.Empty) AndAlso (forcerefresh) Then
        '            varWhere += String.Format("(aa.areaaffected_name like '%{0}%')", find.XOSQLText)
        '        Else
        '            If find.XOSQLText = String.Empty Then

        '            ElseIf find.XOSQLText.Trim.Contains("||") = False Then
        '                varWhere += String.Format("(aa.areaaffected_name like '%{0}%')", find.XOSQLText)
        '            Else
        '                Dim varContainText() As String = find.XOSQLText.Split("||")
        '                Dim varRepeater As Integer = 0

        '                varWhere += String.Format("(")

        '                For Each varText As String In varContainText
        '                    If varText <> "" Then
        '                        If varRepeater = 0 Then
        '                            varWhere.Append(CChar($"aa.areaaffected_name like '%{varText}%'"))
        '                        Else
        '                            varWhere.Append(CChar($" and aa.areaaffected_name like '%{varText}%'"))
        '                        End If
        '                    End If

        '                    varRepeater += 1
        '                Next

        '                varWhere += String.Format(")")
        '            End If

        '        End If

        '        varDatabaseRequestMssql2008(0).Query = String.Format("select aa.areaaffected_id, aa.areaaffected_order, aa.areaaffected_name from dbo.doc_areaaffected aa {0} order by aa.areaaffected_order, aa.areaaffected_name", varWhere)

        '        varDatabaseRequestMssql2008(0).DataGrid = contentgrid
        '        varDatabaseRequestMssql2008(0).StatusBar = contentstatusbar
        '        varDatabaseEngineMssql2008.GetDataTable(dataproperties.ConnectionDatabaseName, varDatabaseRequestMssql2008(0), "TAreaAffected")

        '    Catch ex As Exception
        '        MsgBox(ex.ToString)
        '    End Try
        'End Sub
    End Class

    Public Class Editor

    End Class
End Namespace
