Imports CMCv.Database.Engine
Imports CMCv.Database.Properties
Imports CMCv.Database.Adapter

Imports Bridge.Security

Imports System.Reflection
Imports System.Runtime.Versioning

<SupportedOSPlatform("windows")>
Module Globals
    Public v_dbe_mssql2008 As New CMCv.Database.Engine.MSSQL2008
    Public V_DBE_SQLite As New SQLiteV3
    Public V_DB_Properties(1) As Fields
    Public V_BRIDGE_LOG As New WRITELOG

    Public V_DBR_SQLITE(1) As SQLite.Display.Request
    Public V_DBP_SQLITE As New SQLite.Execute

    Public varSecurityEncryption As New Security.Encrypt
    Public proLog As New Ladybug.Log.Fields

    Public varMajor As Integer = My.Application.Info.Version.Major
    Public varMinor As Integer = My.Application.Info.Version.Minor
    Public varBuild As Integer = My.Application.Info.Version.Build
    Public varRevision As Integer = My.Application.Info.Version.Revision
    Public varApplicationVersion As String = varMajor & "." & varMinor & "." & varBuild & "." & varRevision

    Public WithEvents MSG As New frmDialogBox
    Public WithEvents ERC As New frmErrorReporting
    Public ErrorCatcher As New Ladybug.Log.Fields

    Public varFormAttributes As New Connect.Main.GlobalRecord

#Region "Custom Message Box"
    ''' <summary>
    ''' Display custom message box with specified parameters
    ''' </summary>
    ''' <param name="message"></param>
    ''' <param name="title"></param>
    ''' <param name="messageicon"></param>
    ''' <param name="buttontype"></param>
    ''' <returns></returns>
    Public Function Decision(ByVal message As String, ByVal title As String,
                             ByVal messageicon As CMCv.frmDialogBox.MessageIcon,
                             ByVal buttontype As CMCv.frmDialogBox.MessageTypes) As _
                             System.Windows.Forms.DialogResult
        MSG = New CMCv.frmDialogBox(message, title, messageicon, buttontype)
        Return MSG.ShowDialog()
        MSG.Dispose()
    End Function
#End Region

    ''' <summary>
    ''' Enable double buffering on DataGridView to reduce flickering
    ''' </summary>
    ''' <param name="gridview"></param>
    Public Sub DblBuffer(ByVal gridview As DataGridView)
        Try
            Dim systemType As Type = gridview.GetType()
            Dim propertyInfo As PropertyInfo = systemType.GetProperty("DoubleBuffered",
                                                                      BindingFlags.Instance Or
                                                                      BindingFlags.NonPublic)
            propertyInfo.SetValue(gridview, True, Nothing)
        Catch ex As Exception
            With proLog
                .AppVersion = GETAPPVERSION()
                .FromSender = "[DblBuffer] $Ingrid\Apps\Components\Connect\020. Module\Globals.vb"
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
    Public Sub Display(ByVal formname As CMCv.Std_Fo, Optional ByVal formimage As System.Drawing.Image = Nothing,
                       Optional ByVal formtitle As String = "", Optional ByVal formsubtitle As String = "",
                       Optional ByVal isdialog As Boolean = False,
                       Optional ByVal parentframe As Windows.Forms.Form = Nothing)
        Try
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
                .AppVersion = GETAPPVERSION()
                .FromSender = "[Display] $Ingrid\Apps\Components\Connect\020. Module\Globals.vb"
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
                .FromSender = "[GetAppVersion] $Ingrid\Apps\Components\Connect\020. Module\Globals.vb"
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


#Region "Error Log"
    '''' <summary>
    '''' Function to temporarily store error log data
    '''' </summary>
    '''' <param name="fromsender"></param>
    '''' <param name="errortype"></param>
    '''' <param name="errormessage"></param>
    '''' <param name="errornumber"></param>
    '''' <param name="internalstacktrace"></param>
    '''' <param name="appversion"></param>
    '''' <param name="enableerrorreporting"></param>
    '''' <param name="saveerror"></param>
    '''' <param name="resumenext"></param>
    'Public Sub SUBlogdatapush(ByVal fromsender As String, ByVal errortype As Ladybug.Log.Fields.TypeOfFaulties,
    '                         ByVal errormessage As String, ByVal errornumber As String,
    '                         ByVal internalstacktrace As String, ByVal appversion As String,
    '                         Optional enableerrorreporting As Boolean = True,
    '                         Optional saveerror As Boolean = True,
    '                         Optional resumenext As Boolean = True)
    '    With ErrorCatcher
    '        .FromSender = fromsender
    '        .Type = errortype
    '        .Message = errormessage
    '        .Number = errornumber
    '        .InternalStackTrace = internalstacktrace
    '        .AppVersion = appversion
    '        .EnableErrorReporting = enableerrorreporting
    '        .SaveError = saveerror
    '        .ResumeNext = resumenext
    '    End With
    'End Sub

    '''' <summary>
    '''' Show error reporting dialog box
    '''' </summary>
    '''' <remarks></remarks>
    'Public Sub SUBlogdatashow()
    '    ERC = New CMCv.frmErrorReporting(ErrorCatcher, V_DBE_SQLite)
    '    ERC.ShowDialog()
    '    If Not (ERC.ResumeNext) Then
    '        Return
    '    End If
    'End Sub
#End Region
End Module
