Module [Global]
    Public varDatabaseEngineMssql2008 As New CMCv.Database.Engine.Mssql
    Public varDatabaseEngineMysql As New CMCv.Database.Engine.Mysql
    Public varDatabaseEngineSqlite As New CMCv.Database.Engine.SqliteV3
    Public databaseproperties(1) As LibApp.Ingrid.Global.Properties

    Public varDatabaseRequestMssql2008(1) As CMCv.Database.Adapter.MsSql.Display.Request
    Public varDatabaseRequestMysql(1) As CMCv.Database.Adapter.Mysql.Display.Request
    Public varDatabaseDisplayMssql2008 As New CMCv.Database.Adapter.MsSql.Execute
    Public varDatabaseDisplayMysql As New CMCv.Database.Adapter.Mysql.Execute

    Public proLog As New CMCv.Ladybug.Log.Fields
    Public varSecurityEncrypt As New CMCv.Security.Encrypt

    Public varSecurityAes As System.Security.Cryptography.Aes
    Public varSecurityMd5 As System.Security.Cryptography.MD5
    Public varSecurityCrc32 As New System.IO.Hashing.Crc32

    Public WithEvents MSG As New CMCv.UI.Canvas.FRMdialogbox

    Public tCompany As New LibApp.Table.Man.Company
    Public tPosition As New LibApp.Table.Man.Position
    Public tEmployee As New LibApp.Table.Man.Employee
    Public tUser As New LibApp.Table.Sys.User
    Public tModule As New LibApp.Table.Sys.Module
    Public tUserAccess As New LibApp.Table.Sys.UserAccess
    Public tLog As New LibApp.Table.Sys.Log
    Public tSettings As New LibApp.Table.Sys.Settings
    Public tClient As New LibApp.Table.Sys.Client
    Public tTemplate As New LibApp.Table.Cus.Template
    Public tAttachment As New LibApp.Table.File.Attachment

    ''' <summary>
    ''' Display a custom message box with specified parameters. This function creates an instance of the CMCv.UI.Canvas.FRMdialogbox class, sets its properties based on the provided arguments, and shows the dialog box to the user. The function returns the result of the dialog box interaction, indicating which button was pressed by the user.
    ''' </summary>
    ''' <param name="windowtitle">The title of the message box window.</param>
    ''' <param name="message">The message to be displayed in the message box.</param>
    ''' <param name="title">The title of the message box content.</param>
    ''' <param name="subtitle">The subtitle of the message box content.</param>
    ''' <param name="messageicon">The icon to be displayed in the message box.</param>
    ''' <param name="buttontype">The type of buttons to be displayed in the message box.</param>
    ''' <returns>The result of the dialog box interaction, indicating which button was pressed by the user.</returns>
    <System.Runtime.Versioning.SupportedOSPlatform("windows")>
    Public Function Decision(windowtitle As String, message As String, title As LibApp.Ingrid.Global.PopupType, subtitle As String, messageicon As CMCv.UI.Canvas.FRMdialogbox.MessageIcon, ByVal buttontype As CMCv.UI.Canvas.FRMdialogbox.MessageTypes) As System.Windows.Forms.DialogResult
        MSG = New CMCv.UI.Canvas.FRMdialogbox(windowtitle, message, title, subtitle, messageicon, buttontype)
        Dim result As System.Windows.Forms.DialogResult = MSG.ShowDialog()
        MSG.Dispose()
        Return result
    End Function

    ''' <summary>
    ''' Gets the application version as a string in the format "Major.Minor.Build.Revision". This function retrieves the version information from the application's assembly and formats it into a readable string. If an error occurs while retrieving the version, it logs the error details using the CMCv.Ladybug logging framework and returns a failure message.
    ''' </summary>
    ''' <returns>The application version as a string in the format "Major.Minor.Build.Revision".</returns>
    <System.Runtime.Versioning.SupportedOSPlatform("windows")>
    Public Function GetAppVersion() As String
        Try
            Return My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision
        Catch ex As Exception
            With proLog
                .AppVersion = GetAppVersion()
                .FromSender = "[DblBuffer] $\Ingrid\Apps\Core\Vb\020. Module\Globals.vb"
                .InternalStackTrace = ex.StackTrace
                .Message = ex.Message
                .Number = ex.HResult
                .ResumeNext = True
                .SaveInBetterLog = True
                .SaveLogInLocal = False
                .ShowErrorReporting = True
                .TypeOfFaulty = CMCv.Ladybug.Log.Fields.TypeOfFaulties.ApplicationRunTime
                .TypeOfLog = CMCv.Ladybug.Log.Fields.TypeOfLogs.Error
            End With

            Dim clsLog As New CMCv.Ladybug.Log.Events
            clsLog.ShowData(proLog)
            clsLog = Nothing

            Return " - Failed Getting Version"
        End Try
    End Function

    ''' <summary>
    ''' Sets a value in the provided dictionary (parametername) for the specified key. If the key already exists, it removes the existing entry before adding the new key-value pair. If the value is Nothing, it adds DBNull.Value instead. This method is marked to be supported only on Windows platforms.
    ''' </summary>
    ''' <param name="parametername">The dictionary in which to set the value.</param>
    ''' <param name="[key]">The key for which the value should be set.</param>
    ''' <param name="[value]">The value to set for the specified key. If Nothing, DBNull.Value is used.</param>
    <System.Runtime.Versioning.SupportedOSPlatform("windows")>
    Public Sub SetValue(parametername As Dictionary(Of String, Object), [key] As String, Optional [value] As Object = Nothing)
        With parametername
            If .ContainsKey([key]) Then
                .Remove([key])
            End If
            .Add([key], IIf([value] Is Nothing, DBNull.Value, [value]))
        End With
    End Sub
End Module
