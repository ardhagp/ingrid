Imports CMCv
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms

Namespace Commands.DRAA
    Public Class View
        Public Sub DisplayMainGrid(ByVal Find As txt, ByVal ContentGrid As dgn, ContentStatusBar As stt, Optional ByVal ForceRefresh As Boolean = False)
            Try
                Dim _Where As String = String.Format("where ")

                If (Find.SLFSQLText = String.Empty) AndAlso (ForceRefresh = True) Then
                    _Where += String.Format("(aa.areaaffected_name like '%{0}%')", Find.SLFSQLText)
                Else
                    If Find.SLFSQLText = String.Empty Then

                    ElseIf Find.SLFSQLText.Trim.Contains("||") = False Then
                        _Where += String.Format("(aa.areaaffected_name like '%{0}%')", Find.SLFSQLText)
                    Else
                        Dim _ContainText() As String = Find.SLFSQLText.Split("||")
                        Dim _Repeater As Integer = 0

                        _Where += String.Format("(")

                        For Each _Text As String In _ContainText
                            If Not _Text = "" Then
                                If _Repeater = 0 Then
                                    _Where += String.Format("aa.areaaffected_name like '%{0}%'", _Text)
                                Else
                                    _Where += String.Format(" and aa.areaaffected_name like '%{0}%'", _Text)
                                End If
                            End If

                            _Repeater += 1
                        Next

                        _Where += String.Format(")")
                    End If

                End If

                _DBR_MSSQL2008(0).Query = String.Format("select aa.areaaffected_id, aa.areaaffected_order, aa.areaaffected_name from dbo.[[doc]]areaaffected] aa {0} order by aa.areaaffected_order, aa.areaaffected_name", _Where)

                _DBR_MSSQL2008(0).DataGrid = ContentGrid
                _DBR_MSSQL2008(0).StatusBar = ContentStatusBar
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TAreaAffected")

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub
    End Class

    Public Class Editor

    End Class
End Namespace
