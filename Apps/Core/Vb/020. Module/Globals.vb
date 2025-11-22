Imports System.IO
Imports System.Reflection
Imports System.Runtime.Versioning
'Imports System.Deployment.application

Module Globals
#Region "Activate Licenses"
    <SupportedOSPlatform("windows")>
    Public Sub ActivateLicenses()
        Dim clsBridgekey As New Bridge.Security.Getkey
        Dim varSyncfusionkey As String = clsBridgekey.Syncfusion()

        'License for Syncfusion
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(varSyncfusionkey)
    End Sub
#End Region

#Region "Variables"
    Public varFormimage(4) As System.Drawing.Image
    Public varWorkspace As New WorkspaceClass
    Public varFileinfo As New CMCv.OperatingSystem.File.Info
    Public FolderHandler As New CMCv.OperatingSystem.Folder
    'Public SecurityEngine As New Security.Engine
    Public V_DatabaseEngine As String
    Public V_IMG_COMPRESS As New CMCv.ImageEditor.Proccessor.Compress
    Public V_IMG_EDITOR As New CMCv.ImageEditor.Proccessor.Editor
    Public varUserAccess As New Application.Access
    'Public V_SYSAPP As New Application.Modules
    Public varLogUser As New LibSQL.SystemLog.Activity.User
    Public varLogApplication As New LibSQL.SystemLog.Activity.Application
    Public varForceRefreshMainframeData As Boolean
    'Public clsBridgelog As New Bridge.Security.WRITELOG


    Public varSecurityencrypt As New CMCv.Security.Encrypt

    Public clsECerrorcatcher As New Catcher.Error.Fields

    'Public clsDBsqlite As Database.Engine.LocalDB
    Public clsDBsqlite As Database.Engine.SQLiteV3
    Public WithEvents frmERC As New frmErrorReporting
    'Public WithEvents TED As New frmTextEditor
    Public WithEvents frmMSG As New frmDialogBox

    Public varVersionapplication As String
    Public varVersionnetworkapplication As Version

    Public varFormAttributes As New Ingrid.Main.GlobalRecord
    Public varUserAttributes As New Ingrid.Main.GlobalUser
#End Region

    <SupportedOSPlatform("windows")>
    Public Sub FirstLoad()
        Call GETAPPVERSION()
        Call CHECKREQUIREDFOLDER()
    End Sub

    <SupportedOSPlatform("windows")>
    Public Sub DblBuffer(ByVal GridView As DataGridView)
        Try
            Dim systemType As Type = GridView.GetType()
            Dim propertyInfo As PropertyInfo = systemType.GetProperty("DoubleBuffered", bindingAttr:=BindingFlags.Instance Or BindingFlags.NonPublic)
            propertyInfo.SetValue(GridView, True, Nothing)
        Catch ex As Exception
            PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, True)
            PUSHERRORDATASHOW()
        End Try
    End Sub

#Region "Error Log"

    ''' <summary>
    ''' Store error data to error catcher class
    ''' </summary>
    ''' <param name="errortype"></param>
    ''' <param name="errormessage"></param>
    ''' <param name="errornumber"></param>
    ''' <param name="internalstacktrace"></param>
    ''' <param name="appversion"></param>
    ''' <param name="enableerrorreporting"></param>
    ''' <param name="saveerror"></param>
    ''' <param name="resumenext"></param>
    Public Sub PUSHERRORDATA(ByVal errortype As Catcher.Error.Fields.TypeOfFaulties,
                             ByVal errormessage As String, ByVal errornumber As String,
                             ByVal internalstacktrace As String, ByVal appversion As String,
                             Optional enableerrorreporting As Boolean = True,
                             Optional saveerror As Boolean = True,
                             Optional resumenext As Boolean = True)
        With clsECerrorcatcher
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
    ''' Display Error Reporting Form
    ''' </summary>
    ''' <remarks></remarks>
    <SupportedOSPlatform("windows")>
    Public Sub PUSHERRORDATASHOW()
        frmERC = New CMCv.frmErrorReporting(clsECerrorcatcher, clsDBsqlite)
        frmERC.ShowDialog()
        If Not (frmERC.ResumeNext) Then
            End
        End If
    End Sub
#End Region

#Region "Get App Version"

    ''' <summary>
    ''' Return Application Version
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    <SupportedOSPlatform("windows")>
    Public Function GETAPPVERSION() As String
        Try
            Dim varMajor, varMinor, varBuild, varRevision As Integer

            With My.Application.Info.Version
                varMajor = .Major
                varMinor = .Minor
                varBuild = .Build
                varRevision = .Revision
            End With

            varVersionapplication = varMajor & "." & varMinor & "." & varBuild & "." & varRevision
            Return varVersionapplication
        Catch ex As Exception
            PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult.ToString, ex.StackTrace, "0.0.0", False, True, True)
            PUSHERRORDATASHOW()
            varVersionapplication = " - Failed Getting Version"
            Return varVersionapplication
        End Try
    End Function
#End Region

#Region "Check Modules Folder"

    ''' <summary>
    ''' Check and Create Required Folder
    ''' </summary>
    Public Function CHECKREQUIREDFOLDER(ByVal Optional GetDirName As DirName = Nothing) As String
        If Not Directory.Exists("Commands") Then
            Directory.CreateDirectory("Commands")
        End If
        If Not Directory.Exists("Files.PDF") Then
            Directory.CreateDirectory("Files.PDF")
        End If
        If Not Directory.Exists("Files.Photo") Then
            Directory.CreateDirectory("Files.Photo")
        End If

        Select Case GetDirName
            Case DirName.Commands
                Return Directory.GetCurrentDirectory & "\Commands\" 'Folder for detachable modules
            Case DirName.PDF
                Return Directory.GetCurrentDirectory & "\Files.PDF\"
            Case DirName.PDF
                Return Directory.GetCurrentDirectory & "\Files.Photo\"
            Case Else
                Return ""
        End Select

    End Function

    Public Enum DirName
        Commands
        PDF
        Photo
    End Enum
#End Region

#Region "Display Form"

    ''' <summary>
    ''' Untuk menampilkan form Standard
    ''' </summary>
    ''' <param name="formName">Nama Form</param>
    ''' <param name="FormImage">Form Icon</param>
    ''' <param name="FormTitle">Form Title</param>
    ''' <param name="FormSubTitle">Form Subtitle</param>
    ''' <param name="IsDialog">True/False</param>
    ''' <param name="ParentFrame">MDI</param>
    ''' <remarks></remarks>
    <SupportedOSPlatform("windows")>
    Public Sub DISPLAY(ByVal formName As CMCv.frmStandard, Optional formimage As System.Drawing.Image = Nothing,
                       Optional formtitle As String = "", Optional formsubtitle As String = "",
                       Optional isdialog As Boolean = False, Optional parentframe As Windows.Forms.Form = Nothing)
        Try
            formName.SLFNamaForm.Text = formtitle
            'If formimage IsNot Nothing Then
            '    formName.SLFLogo.Image = formimage
            'End If
            'formName.SLFSubNamaForm.Text = formsubtitle
            'If Not (isdialog) Then
            '    If (formName.IsHandleCreated) Then
            '        formName.Focus()
            '    Else
            '        If parentframe IsNot Nothing Then
            '            formName.Visible = False
            '            formName.MdiParent = parentframe
            '            'formName.WindowState = FormWindowState.Maximized
            '            formName.Show()
            '            formName.Visible = True
            '        Else
            '            formName.Show()
            '        End If
            '    End If
            'Else
            '    formName.ShowDialog()
            '    formName.Dispose()
            'End If


        Catch ex As Exception
            PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, False)
            PUSHERRORDATASHOW()
        End Try
    End Sub

    ''' <summary>
    ''' Untuk menampilkan form Standard + Footer Container
    ''' </summary>
    ''' <param name="FormName">Nama Form</param>
    ''' <param name="FormImage">Form Icon</param>
    ''' <param name="FormTitle">Form Title</param>
    ''' <param name="FormSubTitle">Form Subtitle</param>
    ''' <param name="IsDialog">True/False</param>
    ''' <param name="ParentFrame">MDI</param>
    ''' <remarks></remarks>
    <SupportedOSPlatform("windows")>
    Public Sub DISPLAY(ByVal FormName As CMCv.Std_Fo, Optional ByVal FormImage As System.Drawing.Image = Nothing, Optional ByVal FormTitle As String = "", Optional ByVal FormSubTitle As String = "", Optional ByVal IsDialog As Boolean = False, Optional ByVal ParentFrame As Windows.Forms.Form = Nothing)
        Try
            FormName.SLFNamaForm.Text = FormTitle
            If FormImage IsNot Nothing Then
                FormName.SLFLogo.Image = FormImage
            End If
            FormName.SLFSubNamaForm.Text = FormSubTitle
            If Not (IsDialog) Then
                If (FormName.IsHandleCreated) Then
                    FormName.Focus()
                Else
                    If ParentFrame IsNot Nothing Then
                        FormName.Visible = False
                        FormName.MdiParent = ParentFrame
                        FormName.WindowState = FormWindowState.Maximized
                        FormName.Show()
                        FormName.Visible = True
                    Else
                        FormName.Show()
                    End If
                End If
            Else
                FormName.ShowDialog()
                FormName.Dispose()
            End If
        Catch ex As Exception
            Call PUSHERRORDATA(Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, True)
            Call PUSHERRORDATASHOW()
        End Try
    End Sub
#End Region

#Region "Custom Message Box"
    ''' <summary>
    ''' CMCv Message Box
    ''' </summary>
    ''' <param name="Message">Masukkan pesan anda di sini</param>
    ''' <param name="Title">Judul form</param>
    ''' <param name="MessageIcon">Jenis Icon</param>
    ''' <param name="ButtonType">Jenis Tombol</param>
    ''' <returns>DialogResult</returns>
    ''' <remarks></remarks>
    Public Function Decision(ByVal Message As String, ByVal Title As String, ByVal MessageIcon As CMCv.frmDialogBox.MessageIcon, ByVal ButtonType As CMCv.frmDialogBox.MessageTypes) As DialogResult
        frmMSG = New CMCv.frmDialogBox(Message, Title, MessageIcon, ButtonType)
        Return frmMSG.ShowDialog()
        frmMSG.Dispose()
    End Function
#End Region
End Module