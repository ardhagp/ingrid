Imports System
Imports System.IO
Imports System.Runtime.Versioning
Imports CMCv

Namespace Tools.Import.SharedFunction
    Class Calculate
        Private _ROWCOUNT As Integer

        <SupportedOSPlatform("windows")>
        Public Function TotalRows(ByVal Query As String, ByVal Keyword As String) As Integer
            _ROWCOUNT = CType(V_DBE_MSSQL2008.GETVALUE(Query.Replace("%n", Keyword)), Integer)
            Return _ROWCOUNT
        End Function
    End Class
End Namespace

Namespace Tools.Import.MaterialMaster
    Public Class Catalog
        ReadOnly _CAL As New Tools.Import.SharedFunction.Calculate

        <SupportedOSPlatform("windows")>
        Public Function Execute(ByVal DisplayLogs As txt, ByVal FileLocation As String, Optional ByVal HeaderExist As Boolean = True) As Boolean
            Dim IsSuccess As Boolean = True
            Dim CSVValue As String()
            Dim CSVRow As Integer
            'Dim CSVRowFound As Integer

            Dim Search As String = "SELECT COUNT(m.material_id) FROM dbo.[[log]]material] m WHERE m.material_id = '%n'"

            If File.Exists(FileLocation) = True Then
                DisplayLogs.AppendText("Done." & Environment.NewLine)

                Dim CSVParser As New Microsoft.VisualBasic.FileIO.TextFieldParser(FileLocation) With {
                .TextFieldType = FileIO.FieldType.Delimited,
                .Delimiters = New String() {";"}
                }

                '_DBP_MSSQL2008.Query = "INSERT INTO dbo.material(material_id,material_materialtype,material_description,material_potext,material_materialgroup) VALUES "
                CSVRow = 1
                While Not CSVParser.EndOfData
                    CSVValue = CSVParser.ReadFields
                    If HeaderExist = True Then
                        If CSVRow = 1 Then
                            DisplayLogs.AppendText("Skip Header Row.." & Environment.NewLine)
                        ElseIf CSVRow > 1 Then
                            'first row
                            DisplayLogs.AppendText("Processing Line : " & CSVRow & ". ")
                            If CSVRow = 2 Then
                                If _CAL.TotalRows(Search, CSVValue(1)) = 0 Then
                                    _DBP_MSSQL2008.Query += "INSERT INTO dbo.[[log]]material](material_id,material_materialtype,material_description,material_potext,material_materialgroup) " &
                                        "VALUES ('" & CSVValue(1) & "','" & CSVValue(0) & "','" & CSVValue(2).Replace("'", "''") & "','" & CSVValue(3).Replace("'", "''") & "','" & CSVValue(4) & "');"
                                    DisplayLogs.AppendText("NEW." & Environment.NewLine)
                                Else
                                    _DBP_MSSQL2008.Query += "UPDATE dbo.[[log]]material] SET material_materialtype='" & CSVValue(0) & "',material_description='" & CSVValue(2).Replace("'", "''") & "', " &
                                        "material_potext='" & CSVValue(3).Replace("'", "''") & "',material_materialgroup='" & CSVValue(4) & "' WHERE material_id='" & CSVValue(1) & "';"
                                    DisplayLogs.AppendText("UPDATE." & Environment.NewLine)
                                End If
                            Else
                                If _CAL.TotalRows(Search, CSVValue(1)) = 0 Then
                                    _DBP_MSSQL2008.Query += vbCrLf & "INSERT INTO dbo.[[log]]material](material_id,material_materialtype,material_description,material_potext,material_materialgroup) " &
                                        "VALUES ('" & CSVValue(1) & "','" & CSVValue(0) & "','" & CSVValue(2).Replace("'", "''") & "','" & CSVValue(3).Replace("'", "''") & "','" & CSVValue(4) & "');"
                                    DisplayLogs.AppendText("NEW." & Environment.NewLine)
                                Else
                                    _DBP_MSSQL2008.Query += vbCrLf & "UPDATE dbo.[[log]]material] SET material_materialtype='" & CSVValue(0) & "',material_description='" & CSVValue(2).Replace("'", "''") & "', " &
                                        "material_potext='" & CSVValue(3).Replace("'", "''") & "',material_materialgroup='" & CSVValue(4) & "' WHERE material_id='" & CSVValue(1) & "';"
                                    DisplayLogs.AppendText("UPDATE." & Environment.NewLine)
                                End If
                            End If
                        End If
                    Else
                        If CSVRow = 1 Then
                            If _CAL.TotalRows(Search, CSVValue(1)) = 0 Then
                                _DBP_MSSQL2008.Query += "INSERT INTO dbo.[[log]]material](material_id,material_materialtype,material_description,material_potext,material_materialgroup) " &
                                    "VALUES ('" & CSVValue(1) & "','" & CSVValue(0) & "','" & CSVValue(2).Replace("'", "''") & "','" & CSVValue(3).Replace("'", "''") & "','" & CSVValue(4) & "');"
                                DisplayLogs.AppendText("NEW." & Environment.NewLine)
                            Else
                                _DBP_MSSQL2008.Query += "UPDATE dbo.[[log]]material] SET material_materialtype='" & CSVValue(0) & "',material_description='" & CSVValue(2).Replace("'", "''") & "', " &
                                    "material_potext='" & CSVValue(3).Replace("'", "''") & "',material_materialgroup='" & CSVValue(4) & "' WHERE material_id='" & CSVValue(1) & "';"
                                DisplayLogs.AppendText("UPDATE." & Environment.NewLine)
                            End If
                        Else
                            If _CAL.TotalRows(Search, CSVValue(1)) = 0 Then
                                _DBP_MSSQL2008.Query += vbCrLf & "INSERT INTO dbo.[[log]]material](material_id,material_materialtype,material_description,material_potext,material_materialgroup) " &
                                    "VALUES ('" & CSVValue(1) & "','" & CSVValue(0) & "','" & CSVValue(2).Replace("'", "''") & "','" & CSVValue(3).Replace("'", "''") & "','" & CSVValue(4) & "');"
                                DisplayLogs.AppendText("NEW." & Environment.NewLine)
                            Else
                                _DBP_MSSQL2008.Query += vbCrLf & "UPDATE dbo.[[log]]material] SET material_materialtype='" & CSVValue(0) & "',material_description='" & CSVValue(2).Replace("'", "''") & "', " &
                                    "material_potext='" & CSVValue(3).Replace("'", "''") & "',material_materialgroup='" & CSVValue(4) & "' WHERE material_id='" & CSVValue(1) & "';"
                                DisplayLogs.AppendText("UPDATE." & Environment.NewLine)
                            End If
                        End If
                    End If
                    CSVRow += 1
                End While
                Try
                    V_DBE_MSSQL2008.PUSHDATA(_DBP_MSSQL2008.Query)
                Catch ex As Exception
                    IsSuccess = False
                End Try
            Else
                IsSuccess = False
                DisplayLogs.AppendText("Failed." & Environment.NewLine)
                DisplayLogs.AppendText("Your file is missing." & Environment.NewLine)
            End If

            Return IsSuccess
        End Function
    End Class
End Namespace

