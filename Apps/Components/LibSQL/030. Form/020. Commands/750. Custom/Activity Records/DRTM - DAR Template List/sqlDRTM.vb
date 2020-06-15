Imports CMCv
Imports System.Windows.Forms

Namespace Commands.DRTM
    Public Class View
        Public _IsEmpFilter As Boolean
        Public _EID As String
        Public _ContentID As String

        Public Sub DisplayGrid(ByVal Find As txt, ByVal DateGrid As dgn, ByVal ContentStatusBar As stt, Optional ByVal ForceRefresh As Boolean = False)
            Try
                Dim _Where As String = String.Format("where ")

                If (Find.SLFSQLText = String.Empty) And (ForceRefresh = True) Then
                    _Where += "tpl.template_module = (select mdl.module_id from dbo.[[sys]]module] mdl where mdl.module_code = 'DAR') "
                Else
                    _Where += "tpl.template_module = (select mdl.module_id from dbo.[[sys]]module] mdl where mdl.module_code = 'DAR') and "

                    Dim _ContainText() As String = Find.SLFSQLText.Split("||")
                    Dim _Repeater As Integer = 0

                    _Where += String.Format("(")

                    For Each _Text As String In _ContainText
                        If Not _Text = "" Then
                            If _Repeater = 0 Then
                                _Where += String.Format("tpl.template_text1 like '%{0}%'", _Text)
                            Else
                                _Where += String.Format(" and tpl.template_text1 like '%{0}%'", _Text)
                            End If
                        End If
                        _Repeater += 1
                    Next

                    _Where += String.Format(")")
                End If

                _DBR_MSSQL2008(0).Query = String.Format("select tpl.template_id, tpl.template_title, tpl.template_text1 from dbo.[[doc]]template] tpl {0} order by tpl.template_title", _Where)

                _DBR_MSSQL2008(0).DataGrid = DateGrid
                _DBR_MSSQL2008(0).StatusBar = ContentStatusBar
                _DBE_MSSQL2008.GETDATATABLE(_DBR_MSSQL2008(0), "TDARTemplate")

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub
    End Class

    Public Class Editor

    End Class
End Namespace
