Imports System.Runtime.Versioning

Public Class WorkspaceClass
#Region "Declaration"
    Private varCommandCode As String()
    Private varModuleCode As String
    Private varModuleCaption As String
#End Region

#Region "Declare Modules"
    'Accounting
    Private WithEvents Frm_acgr As New UI.FRMacgr
    Private WithEvents Frm_acbk As New UI.FRMacbk

    'Management
    Private WithEvents Frm_ccin As New UI.FRMccin
    Private WithEvents Frm_cdin As New UI.FRMcdin
    Private WithEvents Frm_post As New UI.FRMpost
    Private WithEvents Frm_epls As New UI.FRMepls

    'Logistic
    Private WithEvents Frm_plnt As New UI.FRMplnt
    Private WithEvents Frm_sloc As New UI.FRMsloc
    Private WithEvents Frm_mctg As New UI.FRMmctg
    Private WithEvents Frm_mmty As New UI.FRMmmty
    Private WithEvents Frm_mmgr As New UI.FRMmmgr

    'Custom
    Private WithEvents Frm_dar As New UI.FRMdar
    Private WithEvents Frm_dard As New UI.FRMdard
    Private WithEvents Frm_drtm As New UI.FRMdrtm
    Private WithEvents Frm_draa As New UI.FRMdraa
    Private WithEvents Frm_pepr As New UI.FRMpepr
    Private WithEvents Frm_rems As New UI.FRMrems

    'System
    Private WithEvents Frm_uac As New UI.FRMuac
    Private WithEvents Frm_mods As New UI.FRMmods
    Private WithEvents Frm_mogs As New UI.FRMmogs
    Private WithEvents Frm_syss As New UI.FRMsyss

    'Tools
    Private WithEvents Frm_say As New UI.FRMsay
    Private WithEvents Frm_phtrz As New FRMphtrz

    'Others
    Private WithEvents Frm_dummy As New UI.FRMdummy
    Private WithEvents Frm_reset As New UI.FRMreset
#End Region

    <SupportedOSPlatform("windows")>
    Public Sub Open(mainframe As Form, commandcode As String, Optional statusbar As CMCv.stt = Nothing)
        Try
            varCommandCode = commandcode.ToString.Split("-".ToCharArray, StringSplitOptions.RemoveEmptyEntries)

            varModuleCode = LibSQL.Workspace.GetModuleName(varDatabaseName, varDatabaseEngineE, commandcode)
            varModuleCaption = LibSQL.Workspace.GetModuleDescription(varDatabaseName, varDatabaseEngineE, commandcode)

            Dim titleBase As String = "[" & commandcode.ToUpper & "] "

            Select Case varCommandCode(0)
                'ACCOUNTING
                Case "ACGR"
                    EnsureOpen(Of UI.FRMacgr)(Frm_acgr, IMAGEDB.Main.ImageLibrary.ACGR_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "ACBK"
                    EnsureOpen(Of UI.FRMacbk)(Frm_acbk, IMAGEDB.Main.ImageLibrary.ACBK_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)

                'LOGISTICS
                Case "MCTG"
                    EnsureOpen(Of UI.FRMmctg)(Frm_mctg, IMAGEDB.Main.ImageLibrary.CATALOGUE_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "MMTY"
                    EnsureOpen(Of UI.FRMmmty)(Frm_mmty, IMAGEDB.Main.ImageLibrary.CATALOGUE_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "MMGR"
                    EnsureOpen(Of UI.FRMmmgr)(Frm_mmgr, IMAGEDB.Main.ImageLibrary.CATALOGUE_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "SLOC"
                    EnsureOpen(Of UI.FRMsloc)(Frm_sloc, IMAGEDB.Main.ImageLibrary.STORAGE_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "PLNT"
                    EnsureOpen(Of UI.FRMplnt)(Frm_plnt, IMAGEDB.Main.ImageLibrary.PLANT_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)

                'MANAGEMENT
                Case "CCIN"
                    EnsureOpen(Of UI.FRMccin)(Frm_ccin, IMAGEDB.Main.ImageLibrary.CCIN_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "CDIN"
                    EnsureOpen(Of UI.FRMcdin)(Frm_cdin, IMAGEDB.Main.ImageLibrary.CDIN_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "EPLS"
                    EnsureOpen(Of UI.FRMepls)(Frm_epls, IMAGEDB.Main.ImageLibrary.EPLS_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "POST"
                    EnsureOpen(Of UI.FRMpost)(Frm_post, IMAGEDB.Main.ImageLibrary.POST_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)

                'CUSTOM
                Case "DAR"
                    EnsureOpen(Of UI.FRMdar)(Frm_dar, IMAGEDB.Main.ImageLibrary.DAR_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "DARD"
                    EnsureOpen(Of UI.FRMdard)(Frm_dard, IMAGEDB.Main.ImageLibrary.DAR_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "DRTM"
                    EnsureOpen(Of UI.FRMdrtm)(Frm_drtm, IMAGEDB.Main.ImageLibrary.DAR_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "DRAA"
                    EnsureOpen(Of UI.FRMdraa)(Frm_draa, IMAGEDB.Main.ImageLibrary.DAR_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "PEPR"
                    EnsureOpen(Of UI.FRMpepr)(Frm_pepr, IMAGEDB.Main.ImageLibrary.JJP_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "REMS"
                    EnsureOpen(Of UI.FRMrems)(Frm_rems, IMAGEDB.Main.ImageLibrary.JJP_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)

                Case "SAY"
                    EnsureOpen(Of UI.FRMsay)(Frm_say, IMAGEDB.Main.ImageLibrary.PLANT_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)

                'SYSTEM
                Case "MODS"
                    EnsureOpen(Of UI.FRMmods)(Frm_mods, IMAGEDB.Main.ImageLibrary.MODS_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "MOGS"
                    EnsureOpen(Of UI.FRMmogs)(Frm_mogs, IMAGEDB.Main.ImageLibrary.MODS_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "UAC"
                    EnsureOpen(Of UI.FRMuac)(Frm_uac, IMAGEDB.Main.ImageLibrary.UAC_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "SYSS"
                    EnsureOpen(Of UI.FRMsyss)(Frm_syss, IMAGEDB.Main.ImageLibrary.UAC_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)

                'INSIDE APPS
                Case "DUMMY"
                    EnsureOpen(Of UI.FRMdummy)(Frm_dummy, IMAGEDB.Main.ImageLibrary.DUMMY_ICON, "[DUMMY] Dummy Form", "Dummy Form for testing", False, mainframe)
                Case "PHTRZ"
                    EnsureOpen(Of FRMphtrz)(Frm_phtrz, IMAGEDB.Main.ImageLibrary.COMPRESS_ICON, varModuleCode, varModuleCaption, True, mainframe)
                Case "RESET"
                    EnsureOpen(Of UI.FRMreset)(Frm_reset, IMAGEDB.Main.ImageLibrary.RESET_ICON, "[RESET] Reset Your Application Settings", "Restore your application to initial configuration", True, mainframe)
            End Select
        Catch ex As Exception
            With proLog
                .AppVersion = GetAppVersion()
                .FromSender = "[Open] $\Ingrid\Apps\Core\Vb\010. Class\WorkspaceClass.vb"
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

    Private Shared Sub FRMmods_EventDataChanged() Handles Frm_mods.EventDataChanged
        varForceRefreshMainframeData = True
    End Sub

    ''' <summary>
    ''' Ensures a form instance exists and is shown (or focused if already created).
    ''' This reduces method complexity by centralizing the open-or-focus logic.
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub EnsureOpen(Of F As {CMCv.frmStandard, New})(ByRef formcode As F, icon As Object, title As String, caption As String, Optional isModal As Boolean = False, Optional parent As Form = Nothing)
        If formcode Is Nothing OrElse Not formcode.IsHandleCreated Then
            formcode = New F()
            Display(formcode, CType(icon, Image), My.Application.Info.AssemblyName.ToUpper, title, caption, isModal, parent)
        Else
            formcode.Focus()
        End If
    End Sub
End Class