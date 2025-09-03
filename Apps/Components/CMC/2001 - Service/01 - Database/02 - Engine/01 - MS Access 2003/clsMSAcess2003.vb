Imports System.Data
Imports System.Runtime.Versioning
Imports System.Windows.Forms

Namespace Database.Engine
    Public Class MSAccess2003
        Private ReadOnly varConnectionstring(2) As String
        Private ReadOnly varFilepath(2) As String

        Private ReadOnly varConnection(2) As OleDb.OleDbConnection
        Private ReadOnly varCommand(2) As OleDb.OleDbCommand
        Private ReadOnly varDatareader(2) As OleDb.OleDbDataReader

        Private ReadOnly varMsa2003c As New Connect.MSAccess2003Connection

        <SupportedOSPlatform("windows")>
        Public Shared Function CheckDBCatalog() As Boolean
            Try
                Dim vardbpath As String = Nothing
                Dim vardbexists(2) As Boolean

                System.IO.Directory.CreateDirectory(Application.StartupPath & "\Resources")

                vardbpath = Application.StartupPath & "\Resources\CATALOG.mdb"
                If OperatingSystem.File.Info.IsExists(vardbpath) Then
                    vardbexists(1) = True
                Else
                    'My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\Resources", My.Resources.catalog, True)
                    vardbexists(1) = False
                End If

                vardbpath = Application.StartupPath & "\Resources\DEV_CATALOG.mdb"
                If OperatingSystem.File.Info.IsExists(vardbpath) Then
                    vardbexists(2) = True
                Else
                    'My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\Resources", My.Resources.dev_catalog, True)
                    vardbexists(2) = False
                End If

                vardbpath = Application.StartupPath & "\Resources\ERRLOG.mdb"
                If OperatingSystem.File.Info.IsExists(vardbpath) Then
                    vardbexists(2) = True
                Else
                    'My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\Resources", My.Resources.errlog, True)
                    vardbexists(2) = False
                End If

                If (vardbexists(1)) AndAlso (vardbexists(2)) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Call PUSHERRORDATA("[CheckDBCatalog] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\01 - MS Access 2003\clsMSAcess2003.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, "", ex.StackTrace, GETAPPVERSION, False, , False)
                Call PUSHERRORDATASHOW()
                Return False
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub Open(Optional ByVal IsProductionMode As Boolean = False)
            Try
                CheckDBCatalog()

                If (IsProductionMode) Then
                    varFilepath(0) = Application.StartupPath & "\Resources\CATALOG.mdb"
                Else
                    varFilepath(0) = Application.StartupPath & "\Resources\DEV_CATALOG.mdb"
                End If

                Dim V_FileInfo As New OperatingSystem.File.Info

                If OperatingSystem.File.Info.IsExists(varFilepath(0)) Then
                    varConnectionstring(0) = varMsa2003c.MicrosoftOLEDBStandard(varFilepath(0), "admin", "")

                    varConnection(0) = New OleDb.OleDbConnection(varConnectionstring(0))
                    varConnection(0).Open()
                End If

                varFilepath(1) = Application.StartupPath & "\Resources\ERRLOG.mdb"

                If OperatingSystem.File.Info.IsExists(varFilepath(1)) Then
                    varConnectionstring(1) = varMsa2003c.MicrosoftOLEDBStandard(varFilepath(1), "admin", "")

                    varConnection(1) = New OleDb.OleDbConnection(varConnectionstring(1))
                    varConnection(1).Open()
                End If

            Catch ex As Exception
                Call PUSHERRORDATA("[Open] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\01 - MS Access 2003\clsMSAcess2003.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, "0", ex.StackTrace, GETAPPVERSION, False, , False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Function GetDatabaseProperties(ByVal Fields As Database.Properties.Fields) As Database.Properties.Fields
            Try
                varDatareader(0) = GETDATAROW("SELECT LIST.SERVERADDRESS, LIST.USERNAME, LIST.PASSWORD, LIST.ACCEPTEDLINECONNECTION FROM LIST WHERE LIST.ID =1;", varConnection(0), varCommand(0))

                With varDatareader(0)
                    Fields.ServerAddress = .GetString(0)
                    Fields.Username = .GetString(1)
                    Fields.Password = CMCv.Security.Decrypt.AES(.GetString(2))
                    Fields.Port = CType(.GetValue(3), Integer)
                    Fields.DataStorage = .GetString(4)
                    Fields.FileStorage = .GetString(5)
                End With

                Return Fields
            Catch ex As System.Data.OleDb.OleDbException
                Call PUSHERRORDATA("[GetDatabaseProperties] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\01 - MS Access 2003\clsMSAcess2003.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.ErrorCode.ToString, ex.StackTrace, GETAPPVERSION, False, , False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Sub SaveErrorData(ByVal ErrorCatcher As Catcher.Error.Fields)
            Dim NowDateTime As String = Now.Year & "-" & Now.Month & "-" & Now.Day & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second
            Call PUSHDATA("insert into ERRORLOG(ERRORTYPE,ERRORDESCRIPTION,ERRORNUMBER,ERRORINTERNALSTACKTRACE,ERRORREPORTING,ERRORDATETIME) values ('" & ErrorCatcher.Type & "','" & ErrorCatcher.Message & "'," & ErrorCatcher.Number & ",'" & ErrorCatcher.InternalStackTrace & "'," & ErrorCatcher.EnableErrorReporting & ",'" & NowDateTime & "');", varConnection(1), varCommand(1))
        End Sub

        <SupportedOSPlatform("windows")>
        Private Shared Function GETDATAROW(ByVal Query As String, ByVal MyConnection As OleDb.OleDbConnection, ByVal MyCommand As OleDb.OleDbCommand) As OleDb.OleDbDataReader
            Try
                Dim varDatareader As OleDb.OleDbDataReader

                MyCommand = New OleDb.OleDbCommand With {
                .Connection = MyConnection,
                .CommandType = CommandType.Text,
                .CommandText = Query}

                MyCommand = New System.Data.OleDb.OleDbCommand(Query, MyConnection)
                varDatareader = MyCommand.ExecuteReader

                If varDatareader.HasRows Then
                    varDatareader.Read()
                End If

                Return varDatareader
            Catch ex As System.Data.OleDb.OleDbException
                Call PUSHERRORDATA("[GETDATAROW] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\01 - MS Access 2003\clsMSAcess2003.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.StackTrace, ex.ErrorCode.ToString, GETAPPVERSION, False, , False)
                Call PUSHERRORDATASHOW()
                Return Nothing
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Private Shared Sub PUSHDATA(ByVal Query As String, ByVal MyConnection As OleDb.OleDbConnection, ByVal MyCommand As OleDb.OleDbCommand)
            Try
                MyCommand = New OleDb.OleDbCommand With {
                .Connection = MyConnection,
                .CommandType = CommandType.Text,
                .CommandText = Query}
                MyCommand.ExecuteNonQuery()
            Catch ex As System.Data.OleDb.OleDbException
                Call PUSHERRORDATA("[PUSHDATA] $\Ingrid\Apps\Components\CMC\2001 - Service\01 - Database\02 - Engine\01 - MS Access 2003\clsMSAcess2003.vb", Catcher.Error.Fields.TypeOfFaulties.SupportServiceDatabaseEngine, ex.Message, ex.ErrorCode.ToString, ex.StackTrace, GETAPPVERSION, False, False, False)
                Call PUSHERRORDATASHOW()
            End Try
        End Sub

        <SupportedOSPlatform("windows")>
        Public Sub Close()
            varConnection(1).Close()
            varConnection(2).Close()
            varConnection(1).Dispose()
            varConnection(2).Dispose()
        End Sub
    End Class
End Namespace
