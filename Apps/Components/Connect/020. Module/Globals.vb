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

    Public varMajor As Integer = My.Application.Info.Version.Major
    Public varMinor As Integer = My.Application.Info.Version.Minor
    Public varBuild As Integer = My.Application.Info.Version.Build
    Public varRevision As Integer = My.Application.Info.Version.Revision
    Public varApplicationVersion As String = varMajor & "." & varMinor & "." & varBuild & "." & varRevision

    Public WithEvents MSG As New frmDialogBox
    Public WithEvents ERC As New frmErrorReporting
    Public ErrorCatcher As New Catcher.Error.Fields

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

    Public Sub DblBuffer(ByVal gridview As DataGridView)
        Try
            Dim systemType As Type = gridview.GetType()
            Dim propertyInfo As PropertyInfo = systemType.GetProperty("DoubleBuffered",
                                                                      BindingFlags.Instance Or
                                                                      BindingFlags.NonPublic)
            propertyInfo.SetValue(gridview, True, Nothing)
        Catch ex As Exception
            PUSHERRORDATA("[DblBuffer] $\Ingrid\Apps\Components\Connect\020. Module\Globals.vb",
                          Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime,
                          ex.Message.ToString, ex.HResult.ToString, ex.StackTrace,
                          GETAPPVERSION, False, True, True)
            PUSHERRORDATASHOW()
        End Try
    End Sub

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
            If Not (isdialog) Then
                If (formname.IsHandleCreated) Then
                    formname.Focus()
                Else
                    If parentframe IsNot Nothing Then
                        formname.Visible = False
                        formname.MdiParent = parentframe
                        formname.WindowState = FormWindowState.Maximized
                        formname.Show()
                        formname.Visible = True
                    Else
                        formname.Show()
                    End If
                End If
            Else
                formname.ShowDialog()
                formname.Dispose()
            End If
        Catch ex As Exception
            Call PUSHERRORDATA("[Display] $\Ingrid\Apps\Components\Connect\020. Module\Globals.vb",
                               Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message,
                               ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, True)
            Call PUSHERRORDATASHOW()
        End Try
    End Sub

#Region "Get App Version"

    ''' <summary>
    ''' Fungsi untuk mendapatkan versi app
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function GETAPPVERSION() As String
        Try
            Dim varMajor, varMinor, varBuild, varRevision As Integer
            varMajor = My.Application.Info.Version.Major
            varMinor = My.Application.Info.Version.Minor
            varBuild = My.Application.Info.Version.Build
            varRevision = My.Application.Info.Version.Revision
            varApplicationVersion = varMajor & "." & varMinor & "." & varBuild & "." & varRevision
            Return varApplicationVersion
        Catch ex As Exception
            PUSHERRORDATA("[GETAPPVERSION] $\Ingrid\Apps\Components\Connect\020. Module\Globals.vb",
                          Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message,
                          ex.HResult.ToString, ex.StackTrace, "0.0.0", False, True, True)
            PUSHERRORDATASHOW()
            varApplicationVersion = "0.0.0"
            Return varApplicationVersion
        End Try
    End Function
#End Region


#Region "Error Log"
    ''' <summary>
    ''' Function to temporarily store error log data
    ''' </summary>
    ''' <param name="fromsender"></param>
    ''' <param name="errortype"></param>
    ''' <param name="errormessage"></param>
    ''' <param name="errornumber"></param>
    ''' <param name="internalstacktrace"></param>
    ''' <param name="appversion"></param>
    ''' <param name="enableerrorreporting"></param>
    ''' <param name="saveerror"></param>
    ''' <param name="resumenext"></param>
    Public Sub PUSHERRORDATA(ByVal fromsender As String, ByVal errortype As Catcher.Error.Fields.TypeOfFaulties,
                             ByVal errormessage As String, ByVal errornumber As String,
                             ByVal internalstacktrace As String, ByVal appversion As String,
                             Optional enableerrorreporting As Boolean = True,
                             Optional saveerror As Boolean = True,
                             Optional resumenext As Boolean = True)
        With ErrorCatcher
            .FromSender = fromsender
            .Type = errortype
            .Message = errormessage
            .Number = errornumber
            .InternalStackTrace = internalstacktrace
            .AppVersion = appversion
            .EnableErrorReporting = enableerrorreporting
            .SaveError = saveerror
            .ResumeNext = resumenext
        End With
    End Sub

    ''' <summary>
    ''' Metode untuk menampilkan log error
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub PUSHERRORDATASHOW()
        ERC = New CMCv.frmErrorReporting(ErrorCatcher, V_DBE_SQLite)
        ERC.ShowDialog()
        If Not (ERC.ResumeNext) Then
            End
        End If
    End Sub
#End Region
End Module
