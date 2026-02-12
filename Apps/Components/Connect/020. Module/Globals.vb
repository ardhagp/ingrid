Imports CMCv.Database.Engine
Imports CMCv.Database.Adapter
Imports System.Reflection
Imports System.Runtime.Versioning

<SupportedOSPlatform("windows")>
Module Globals
    'TODO:Remove
    'Public varDatabaseEngineMssql2008 As New CMCv.Database.Engine.Mssql2008
    'Public varDatabaseProperties(1) As Fields
    'Public V_BRIDGE_LOG As Writelog
    'Public varDatabaseProviderSqlite As New SQLite.Execute

    Public varDatabaseEngineSqlite As New SQLiteV3
    Public varDatabaseRequestSqlite(1) As SQLite.Display.Request

    Public varSecurityEncryption As New Security.Encrypt
    Public proLog As New Ladybug.Log.Fields

    Public varMajor As Integer = My.Application.Info.Version.Major
    Public varMinor As Integer = My.Application.Info.Version.Minor
    Public varBuild As Integer = My.Application.Info.Version.Build
    Public varRevision As Integer = My.Application.Info.Version.Revision
    Public varApplicationVersion As String = varMajor & "." & varMinor & "." & varBuild & "." & varRevision

    Public WithEvents MSG As New FRMdialogbox
    Public WithEvents ERC As New FRMerrorreporting
    Public ErrorCatcher As New Ladybug.Log.Fields

    Public varProperties As New LibApp.Ingrid.Global.Properties

#Region "Custom Message Box"
    ''' <summary>
    ''' Display custom message box with specified parameters
    ''' </summary>
    ''' <param name="message"></param>
    ''' <param name="title"></param>
    ''' <param name="messageicon"></param>
    ''' <param name="buttontype"></param>
    ''' <returns></returns>
    Public Function Decision(windowtitle As String, message As String, title As LibApp.Ingrid.Global.PopupType,
                             subtitle As String, messageicon As CMCv.FRMdialogbox.MessageIcon,
                             buttontype As CMCv.FRMdialogbox.MessageTypes) As _
                             System.Windows.Forms.DialogResult
        MSG = New CMCv.FRMdialogbox(windowtitle, message, title, subtitle, messageicon, buttontype)
        Dim result As System.Windows.Forms.DialogResult = MSG.ShowDialog()
        MSG.Dispose()
        Return result
    End Function
#End Region

    ''' <summary>
    ''' Enable double buffering on DataGridView to reduce flickering
    ''' </summary>
    ''' <param name="gridview"></param>
    Public Sub DblBuffer(gridview As DataGridView)
        Try
            Dim varSystemType As Type = gridview.GetType()
            Dim varPropertyInfo As PropertyInfo = varSystemType.GetProperty("DoubleBuffered",
                                                                      BindingFlags.Instance Or
                                                                      BindingFlags.NonPublic)
            varPropertyInfo.SetValue(gridview, True, Nothing)
        Catch ex As Exception
            With proLog
                .AppVersion = GetAppVersion()
                .FromSender = "[DblBuffer] $\Ingrid\Apps\Components\Connect\020. Module\Globals.vb"
                .InternalStackTrace = ex.StackTrace
                .Message = ex.Message
                .Number = ex.HResult
                .ResumeNext = True
                .SaveInBetterLog = True
                .SaveLogInLocal = False
                .ShowErrorReporting = True
                .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.ApplicationRunTime
                .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
            End With

            Dim clsLog As New Ladybug.Log.Events
            clsLog.ShowData(proLog)
            clsLog = Nothing
        End Try
    End Sub

    ''' <summary>
    ''' Display form with specified parameters
    ''' </summary>
    ''' <param name="formname"></param>
    ''' <param name="formimage"></param>
    ''' <param name="formtitle"></param>
    ''' <param name="formsubtitle"></param>
    ''' <param name="isdialog"></param>
    ''' <param name="parentframe"></param>
    Public Sub Display(formname As CMCv.Std_Fo, Optional formimage As System.Drawing.Image = Nothing,
                       Optional windowtitle As String = "", Optional formtitle As String = "", Optional formsubtitle As String = "",
                       Optional isdialog As Boolean = False,
                       Optional parentframe As Windows.Forms.Form = Nothing)
        Try
            formname.Text = windowtitle
            formname.SLFNamaForm.Text = formtitle

            If formimage IsNot Nothing Then
                formname.SLFLogo.Image = formimage
            End If

            formname.SLFSubNamaForm.Text = formsubtitle

            If isdialog Then
                formname.ShowDialog()
                formname.Dispose()
                Return
            End If

            If formname.IsHandleCreated Then
                formname.Focus()
                Return
            End If

            If parentframe IsNot Nothing Then
                formname.Visible = False
                formname.MdiParent = parentframe
                formname.WindowState = FormWindowState.Maximized
                formname.Show()
                formname.Visible = True
            Else
                formname.Show()
            End If
        Catch ex As Exception
            With proLog
                .AppVersion = GetAppVersion()
                .FromSender = "[Display] $\Ingrid\Apps\Components\Connect\020. Module\Globals.vb"
                .InternalStackTrace = ex.StackTrace
                .Message = ex.Message
                .Number = ex.HResult
                .ResumeNext = True
                .SaveInBetterLog = True
                .SaveLogInLocal = False
                .ShowErrorReporting = True
                .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.ApplicationRunTime
                .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
            End With

            Dim clsLog As New Ladybug.Log.Events
            clsLog.ShowData(proLog)
            clsLog = Nothing
        End Try
    End Sub

#Region "Get Application Version"

    ''' <summary>
    ''' Get application version
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function GetAppVersion() As String
        Try
            Dim varMajor, varMinor, varBuild, varRevision As Integer
            varMajor = My.Application.Info.Version.Major
            varMinor = My.Application.Info.Version.Minor
            varBuild = My.Application.Info.Version.Build
            varRevision = My.Application.Info.Version.Revision
            varApplicationVersion = varMajor & "." & varMinor & "." & varBuild & "." & varRevision
            Return varApplicationVersion
        Catch ex As Exception
            With proLog
                .AppVersion = GetAppVersion()
                .FromSender = "[GetAppVersion] $\Ingrid\Apps\Components\Connect\020. Module\Globals.vb"
                .InternalStackTrace = ex.StackTrace
                .Message = ex.Message
                .Number = ex.HResult
                .ResumeNext = True
                .SaveInBetterLog = True
                .SaveLogInLocal = False
                .ShowErrorReporting = True
                .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.ApplicationRunTime
                .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
            End With

            Dim clsLog As New Ladybug.Log.Events
            clsLog.ShowData(proLog)
            clsLog = Nothing

            varApplicationVersion = "0.0.0"
            Return varApplicationVersion
        End Try
    End Function
#End Region

End Module
