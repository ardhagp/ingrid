Imports System
Imports System.IO
Imports System.Runtime.Versioning
Imports CMCv

Namespace Tools.Import.SharedFunction
    Class Calculate
        Private varRowCount As Integer

        <SupportedOSPlatform("windows")>
        Public Function TotalRows(databasename As String, Query As String, ByVal Keyword As String) As Integer
            varRowCount = CType(varDatabaseEngineMssql2008.GetValue(databasename, Query.Replace("%n", Keyword)), Integer)
            Return varRowCount
        End Function
    End Class
End Namespace

Namespace Tools.Import.MaterialMaster
    Public Class Catalog
        ReadOnly _CAL As New Tools.Import.SharedFunction.Calculate

        <SupportedOSPlatform("windows")>
        Public Function Execute(databasename As String, displaylogs As txt, filelocation As String, Optional headerexist As Boolean = True) As Boolean
            Dim varIsSuccess As Boolean = True
            Dim varCSVvalue As String()
            Dim varCSVrow As Integer
            'Dim CSVRowFound As Integer

            Dim Search As String = "SELECT COUNT(m.material_id) FROM dbo.log_material m WHERE m.material_id = '%n'"

            If (File.Exists(filelocation)) Then
                displaylogs.AppendText("Done." & Environment.NewLine)

                Dim CSVParser As New Microsoft.VisualBasic.FileIO.TextFieldParser(filelocation) With {
                .TextFieldType = FileIO.FieldType.Delimited,
                .Delimiters = New String() {";"}
                }

                'varDatabaseDisplayMssql2008.Query = "INSERT INTO dbo.material(material_id,material_materialtype,material_description,material_potext,material_materialgroup) VALUES "
                varCSVrow = 1
                While Not CSVParser.EndOfData
                    varCSVvalue = CSVParser.ReadFields
                    If (headerexist) Then
                        If varCSVrow = 1 Then
                            displaylogs.AppendText("Skip Header Row.." & Environment.NewLine)
                        ElseIf varCSVrow > 1 Then
                            'first row
                            displaylogs.AppendText("Processing Line : " & varCSVrow & ". ")
                            If varCSVrow = 2 Then
                                If _CAL.TotalRows(databasename, Search, varCSVvalue(1)) = 0 Then
                                    varDatabaseDisplayMssql2008.Query += "INSERT INTO dbo.log_material(material_id,material_materialtype,material_description,material_potext,material_materialgroup) " &
                                        "VALUES ('" & varCSVvalue(1) & "','" & varCSVvalue(0) & "','" & varCSVvalue(2).Replace("'", "''") & "','" & varCSVvalue(3).Replace("'", "''") & "','" & varCSVvalue(4) & "');"
                                    displaylogs.AppendText("NEW." & Environment.NewLine)
                                Else
                                    varDatabaseDisplayMssql2008.Query += "UPDATE dbo.log_material SET material_materialtype='" & varCSVvalue(0) & "',material_description='" & varCSVvalue(2).Replace("'", "''") & "', " &
                                        "material_potext='" & varCSVvalue(3).Replace("'", "''") & "',material_materialgroup='" & varCSVvalue(4) & "' WHERE material_id='" & varCSVvalue(1) & "';"
                                    displaylogs.AppendText("UPDATE." & Environment.NewLine)
                                End If
                            Else
                                If _CAL.TotalRows(databasename, Search, varCSVvalue(1)) = 0 Then
                                    varDatabaseDisplayMssql2008.Query += vbCrLf & "INSERT INTO dbo.log_material(material_id,material_materialtype,material_description,material_potext,material_materialgroup) " &
                                        "VALUES ('" & varCSVvalue(1) & "','" & varCSVvalue(0) & "','" & varCSVvalue(2).Replace("'", "''") & "','" & varCSVvalue(3).Replace("'", "''") & "','" & varCSVvalue(4) & "');"
                                    displaylogs.AppendText("NEW." & Environment.NewLine)
                                Else
                                    varDatabaseDisplayMssql2008.Query += vbCrLf & "UPDATE dbo.log_material SET material_materialtype='" & varCSVvalue(0) & "',material_description='" & varCSVvalue(2).Replace("'", "''") & "', " &
                                        "material_potext='" & varCSVvalue(3).Replace("'", "''") & "',material_materialgroup='" & varCSVvalue(4) & "' WHERE material_id='" & varCSVvalue(1) & "';"
                                    displaylogs.AppendText("UPDATE." & Environment.NewLine)
                                End If
                            End If
                        End If
                    Else
                        If varCSVrow = 1 Then
                            If _CAL.TotalRows(databasename, Search, varCSVvalue(1)) = 0 Then
                                varDatabaseDisplayMssql2008.Query += "INSERT INTO dbo.log_material(material_id,material_materialtype,material_description,material_potext,material_materialgroup) " &
                                    "VALUES ('" & varCSVvalue(1) & "','" & varCSVvalue(0) & "','" & varCSVvalue(2).Replace("'", "''") & "','" & varCSVvalue(3).Replace("'", "''") & "','" & varCSVvalue(4) & "');"
                                displaylogs.AppendText("NEW." & Environment.NewLine)
                            Else
                                varDatabaseDisplayMssql2008.Query += "UPDATE dbo.log_material SET material_materialtype='" & varCSVvalue(0) & "',material_description='" & varCSVvalue(2).Replace("'", "''") & "', " &
                                    "material_potext='" & varCSVvalue(3).Replace("'", "''") & "',material_materialgroup='" & varCSVvalue(4) & "' WHERE material_id='" & varCSVvalue(1) & "';"
                                displaylogs.AppendText("UPDATE." & Environment.NewLine)
                            End If
                        Else
                            If _CAL.TotalRows(databasename, Search, varCSVvalue(1)) = 0 Then
                                varDatabaseDisplayMssql2008.Query += vbCrLf & "INSERT INTO dbo.log_material(material_id,material_materialtype,material_description,material_potext,material_materialgroup) " &
                                    "VALUES ('" & varCSVvalue(1) & "','" & varCSVvalue(0) & "','" & varCSVvalue(2).Replace("'", "''") & "','" & varCSVvalue(3).Replace("'", "''") & "','" & varCSVvalue(4) & "');"
                                displaylogs.AppendText("NEW." & Environment.NewLine)
                            Else
                                varDatabaseDisplayMssql2008.Query += vbCrLf & "UPDATE dbo.log_material SET material_materialtype='" & varCSVvalue(0) & "',material_description='" & varCSVvalue(2).Replace("'", "''") & "', " &
                                    "material_potext='" & varCSVvalue(3).Replace("'", "''") & "',material_materialgroup='" & varCSVvalue(4) & "' WHERE material_id='" & varCSVvalue(1) & "';"
                                displaylogs.AppendText("UPDATE." & Environment.NewLine)
                            End If
                        End If
                    End If
                    varCSVrow += 1
                End While
                Try
                    varDatabaseEngineMssql2008.PushData(databasename, varDatabaseDisplayMssql2008.Query)
                Catch ex As Exception
                    varIsSuccess = False
                End Try
            Else
                varIsSuccess = False
                displaylogs.AppendText("Failed." & Environment.NewLine)
                displaylogs.AppendText("Your file is missing." & Environment.NewLine)
            End If

            Return varIsSuccess
        End Function
    End Class
End Namespace

