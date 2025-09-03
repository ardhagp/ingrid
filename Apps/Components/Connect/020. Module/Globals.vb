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

    Public V_SECEncrypt As New Security.Encrypt

    Public V_Major As Integer = My.Application.Info.Version.Major
    Public V_Minor As Integer = My.Application.Info.Version.Minor
    Public V_Build As Integer = My.Application.Info.Version.Build
    Public V_Revision As Integer = My.Application.Info.Version.Revision
    Public V_APPVer As String = V_Major & "." & V_Minor & "." & V_Build & "." & V_Revision

    Public WithEvents MSG As New frmDialogBox
    Public WithEvents ERC As New frmErrorReporting
    Public ErrorCatcher As New Catcher.Error.Fields

    Public V_FORMAttrib As New Connect.Main.GlobalRecord

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
    Public Function Decision(ByVal Message As String, ByVal Title As String, ByVal MessageIcon As CMCv.frmDialogBox.MessageIcon, ByVal ButtonType As CMCv.frmDialogBox.MessageTypes) As System.Windows.Forms.DialogResult
        MSG = New CMCv.frmDialogBox(Message, Title, MessageIcon, ButtonType)
        Return MSG.ShowDialog()
        MSG.Dispose()
    End Function
#End Region

    Public Sub DblBuffer(ByVal GridView As DataGridView)
        Try
            Dim systemType As Type = GridView.GetType()
            Dim propertyInfo As PropertyInfo = systemType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
            propertyInfo.SetValue(GridView, True, Nothing)
        Catch ex As Exception
            PUSHERRORDATA("[DblBuffer] $\Ingrid\Apps\Components\Connect\020. Module\Globals.vb", Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message.ToString, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, True)
            PUSHERRORDATASHOW()
        End Try
    End Sub

    Public Sub Display(ByVal FormName As CMCv.Std_Fo, Optional ByVal FormImage As System.Drawing.Image = Nothing, Optional ByVal FormTitle As String = "", Optional ByVal FormSubTitle As String = "", Optional ByVal IsDialog As Boolean = False, Optional ByVal ParentFrame As Windows.Forms.Form = Nothing)
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
            Call PUSHERRORDATA("[Display] $\Ingrid\Apps\Components\Connect\020. Module\Globals.vb", Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult.ToString, ex.StackTrace, GETAPPVERSION, False, True, True)
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
            Dim V_Major, V_Minor, V_Build, V_Revision As Integer
            V_Major = My.Application.Info.Version.Major
            V_Minor = My.Application.Info.Version.Minor
            V_Build = My.Application.Info.Version.Build
            V_Revision = My.Application.Info.Version.Revision
            V_APPVer = V_Major & "." & V_Minor & "." & V_Build & "." & V_Revision
            Return V_APPVer
        Catch ex As Exception
            PUSHERRORDATA("[GETAPPVERSION] $\Ingrid\Apps\Components\Connect\020. Module\Globals.vb", Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult.ToString, ex.StackTrace, "0.0.0", False, True, True)
            PUSHERRORDATASHOW()
            V_APPVer = "0.0.0"
            Return V_APPVer
        End Try
    End Function
#End Region


#Region "Error Log"

    ''' <summary>
    ''' Metode untuk menyimpan log error
    ''' </summary>
    ''' <param name="ErrorType">Tipe Error</param>
    ''' <param name="ErrorMessage">Pesan Error</param>
    ''' <param name="ErrorNumber">Nomor Error</param>
    ''' <param name="InternalStackTrace">Internal Stack Trace</param>
    ''' <param name="AppVersion">Versi Aplikasi</param>
    ''' <param name="EnableErrorReporting">True/False</param>
    ''' <param name="SaveError">True/False</param>
    ''' <param name="ResumeNext">Lanjutkan saat terjadi kesalahan</param>
    ''' <remarks></remarks>
    Public Sub PUSHERRORDATA(ByVal FromSender As String, ByVal ErrorType As Catcher.Error.Fields.TypeOfFaulties, ByVal ErrorMessage As String, ByVal ErrorNumber As String, ByVal InternalStackTrace As String, ByVal AppVersion As String, Optional ByVal EnableErrorReporting As Boolean = True, Optional ByVal SaveError As Boolean = True, Optional ByVal ResumeNext As Boolean = True)
        With ErrorCatcher
            .FromSender = FromSender
            .Type = ErrorType
            .Message = ErrorMessage
            .Number = ErrorNumber
            .InternalStackTrace = InternalStackTrace
            .AppVersion = AppVersion
            .EnableErrorReporting = EnableErrorReporting
            .SaveError = SaveError
            .ResumeNext = ResumeNext
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
