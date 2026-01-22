Imports System.Runtime.Versioning

Public Class WorkspaceClass
#Region "Variables"
    'Private ReadOnly varCommandExist As Boolean
    'Private ReadOnly varCommandRestricted As Boolean
    'Private ReadOnly V_SQL As New LibSQL.Workspace

    Private varCommandCode As String()
    Private varModuleCode As String
    Private varModuleCaption As String
#End Region

#Region "Declare Modules"
    'Accounting
    Private WithEvents Frm_acgr As New FRMacgr
    Private WithEvents Frm_acbk As New FRMacbk

    'Management
    Private WithEvents Frm_ccin As New FRMccin
    Private WithEvents Frm_cdin As New FRMcdin
    Private WithEvents Frm_post As New FRMpost
    Private WithEvents Frm_epls As New FRMepls

    'Logistic
    Private WithEvents Frm_plnt As New FRMplnt
    Private WithEvents Frm_sloc As New FRMsloc
    Private WithEvents Frm_mctg As New FRMmctg
    Private WithEvents Frm_mmty As New FRMmmty
    Private WithEvents Frm_mmgr As New FRMmmgr

    'Custom
    Private WithEvents Frm_dar As New FRMdar
    Private WithEvents Frm_dard As New FRMdard
    Private WithEvents Frm_drtm As New FRMdrtm
    Private WithEvents Frm_draa As New FRMdraa
    Private WithEvents Frm_pepr As New PEPR
    Private WithEvents Frm_rems As New REMS

    'System
    Private WithEvents Frm_uac As New UAC
    Private WithEvents Frm_mods As New FRMmods
    Private WithEvents Frm_mogs As New MOGS
    Private WithEvents Frm_syss As New SYSS

    'Tools
    Private WithEvents Frm_say As New FRMsay
    Private WithEvents Frm_phtrz As New CMCv.FRMphotoresizer

    'Others
    Private WithEvents Frm_dummy As New Dummy
    Private WithEvents Frm_reset As New RESET
#End Region

    <SupportedOSPlatform("windows")>
    Public Sub Open(mainframe As Form, tcode As String, Optional statusbar As CMCv.stt = Nothing)
        Try
            varCommandCode = tcode.ToString.Split("-".ToCharArray, StringSplitOptions.RemoveEmptyEntries)

            '_CommandExist = True
            '_CommandRestricted = False

            varModuleCode = LibSQL.Workspace.GetModuleName(varDatabaseName, varDatabaseEngine, tcode)
            varModuleCaption = LibSQL.Workspace.GetModuleDescription(varDatabaseName, varDatabaseEngine, tcode)

            Dim titleBase As String = "[" & tcode.ToUpper & "] "

            Select Case varCommandCode(0)
                'ACCOUNTING
                Case "ACGR"
                    EnsureOpen(Of FRMacgr)(Frm_acgr, IMAGEDB.Main.ImageLibrary.ACGR_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "ACBK"
                    EnsureOpen(Of FRMacbk)(Frm_acbk, IMAGEDB.Main.ImageLibrary.ACBK_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)

                'LOGISTICS
                Case "MCTG"
                    EnsureOpen(Of FRMmctg)(Frm_mctg, IMAGEDB.Main.ImageLibrary.CATALOGUE_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "MMTY"
                    EnsureOpen(Of FRMmmty)(Frm_mmty, IMAGEDB.Main.ImageLibrary.CATALOGUE_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "MMGR"
                    EnsureOpen(Of FRMmmgr)(Frm_mmgr, IMAGEDB.Main.ImageLibrary.CATALOGUE_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "SLOC"
                    EnsureOpen(Of FRMsloc)(Frm_sloc, IMAGEDB.Main.ImageLibrary.STORAGE_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "PLNT"
                    EnsureOpen(Of FRMplnt)(Frm_plnt, IMAGEDB.Main.ImageLibrary.PLANT_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)

                'MANAGEMENT
                Case "CCIN"
                    EnsureOpen(Of FRMccin)(Frm_ccin, IMAGEDB.Main.ImageLibrary.CCIN_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "CDIN"
                    EnsureOpen(Of FRMcdin)(Frm_cdin, IMAGEDB.Main.ImageLibrary.CDIN_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "EPLS"
                    EnsureOpen(Of FRMepls)(Frm_epls, IMAGEDB.Main.ImageLibrary.EPLS_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "POST"
                    EnsureOpen(Of FRMpost)(Frm_post, IMAGEDB.Main.ImageLibrary.POST_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)

                'CUSTOM
                Case "DAR"
                    EnsureOpen(Of FRMdar)(Frm_dar, IMAGEDB.Main.ImageLibrary.DAR_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "DARD"
                    EnsureOpen(Of FRMdard)(Frm_dard, IMAGEDB.Main.ImageLibrary.DAR_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "DRTM"
                    EnsureOpen(Of FRMdrtm)(Frm_drtm, IMAGEDB.Main.ImageLibrary.DAR_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "DRAA"
                    EnsureOpen(Of FRMdraa)(Frm_draa, IMAGEDB.Main.ImageLibrary.DAR_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "PEPR"
                    EnsureOpen(Of PEPR)(Frm_pepr, IMAGEDB.Main.ImageLibrary.JJP_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "REMS"
                    EnsureOpen(Of REMS)(Frm_rems, IMAGEDB.Main.ImageLibrary.JJP_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)

                Case "SAY"
                    EnsureOpen(Of FRMsay)(Frm_say, IMAGEDB.Main.ImageLibrary.PLANT_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)

                'SYSTEM
                Case "MODS"
                    EnsureOpen(Of FRMmods)(Frm_mods, IMAGEDB.Main.ImageLibrary.MODS_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "MOGS"
                    EnsureOpen(Of MOGS)(Frm_mogs, IMAGEDB.Main.ImageLibrary.MODS_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "UAC"
                    EnsureOpen(Of UAC)(Frm_uac, IMAGEDB.Main.ImageLibrary.UAC_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)
                Case "SYSS"
                    EnsureOpen(Of SYSS)(Frm_syss, IMAGEDB.Main.ImageLibrary.UAC_ICON, titleBase & varModuleCode, varModuleCaption, False, mainframe)

                'INSIDE APPS
                Case "DUMMY"
                    EnsureOpen(Of Dummy)(Frm_dummy, IMAGEDB.Main.ImageLibrary.DUMMY_ICON, "[DUMMY] Dummy Form", "Dummy Form for testing", False, mainframe)
                Case "PHTRZ"
                    EnsureOpen(Of CMCv.FRMphotoresizer)(Frm_phtrz, IMAGEDB.Main.ImageLibrary.COMPRESS_ICON, varModuleCode, varModuleCaption, True, mainframe)
                Case "RESET"
                    EnsureOpen(Of RESET)(Frm_reset, IMAGEDB.Main.ImageLibrary.RESET_ICON, "[RESET] Reset Your Application Settings", "Restore your application to initial configuration", True, mainframe)
            End Select

            'Select Case varCommandCode(0)
            '    'ACCOUNTING
            '    Case "ACGR"
            '        If (Not (Frm_acgr.IsHandleCreated)) OrElse (IsNothing(Frm_acgr)) Then
            '            Frm_acgr = New FRMacgr
            '            Display(Frm_acgr, IMAGEDB.Main.ImageLibrary.ACGR_ICON, "[" & tcode.ToUpper & "] " & varModuleCode, varModuleCaption, False, mainframe)
            '        Else
            '            Frm_acgr.Focus()
            '        End If
            '    Case "ACBK"
            '        If (Not (Frm_acbk.IsHandleCreated)) OrElse (IsNothing(Frm_acbk)) Then
            '            Frm_acbk = New FRMacbk
            '            Display(Frm_acbk, IMAGEDB.Main.ImageLibrary.ACBK_ICON, "[" & tcode.ToUpper & "] " & varModuleCode, varModuleCaption, False, mainframe)
            '        Else
            '            Frm_acbk.Focus()
            '        End If


            '        'LOGISTICS
            '    Case "MCTG"
            '        If (Not (Frm_mctg.IsHandleCreated)) OrElse (IsNothing(Frm_mctg)) Then
            '            Frm_mctg = New FRMmctg
            '            Display(Frm_mctg, IMAGEDB.Main.ImageLibrary.CATALOGUE_ICON, "[" & tcode.ToUpper & "] " & varModuleCode, varModuleCaption, False, mainframe)
            '        Else
            '            Frm_mctg.Focus()
            '        End If
            '    Case "MMTY"
            '        If (Not (Frm_mmty.IsHandleCreated)) OrElse (IsNothing(Frm_mmty)) Then
            '            Frm_mmty = New FRMmmty
            '            Display(Frm_mmty, IMAGEDB.Main.ImageLibrary.CATALOGUE_ICON, "[" & tcode.ToUpper & "] " & varModuleCode, varModuleCaption, False, mainframe)
            '        Else
            '            Frm_mmty.Focus()
            '        End If
            '    Case "MMGR"
            '        If (Not (Frm_mmgr.IsHandleCreated)) OrElse (IsNothing(Frm_mmgr)) Then
            '            Frm_mmgr = New FRMmmgr
            '            Display(Frm_mmgr, IMAGEDB.Main.ImageLibrary.CATALOGUE_ICON, "[" & tcode.ToUpper & "] " & varModuleCode, varModuleCaption, False, mainframe)
            '        Else
            '            Frm_mmgr.Focus()
            '        End If
            '    Case "SLOC"
            '        If (Not (Frm_sloc.IsHandleCreated)) OrElse (IsNothing(Frm_sloc)) Then
            '            Frm_sloc = New FRMsloc
            '            Display(Frm_sloc, IMAGEDB.Main.ImageLibrary.STORAGE_ICON, "[" & tcode.ToUpper & "] " & varModuleCode, varModuleCaption, False, mainframe)
            '        Else
            '            Frm_sloc.Focus()
            '        End If
            '    Case "PLNT"
            '        If (Not (Frm_plnt.IsHandleCreated)) OrElse (IsNothing(Frm_plnt)) Then
            '            Frm_plnt = New FRMplnt
            '            Display(Frm_plnt, IMAGEDB.Main.ImageLibrary.PLANT_ICON, "[" & tcode.ToUpper & "] " & varModuleCode, varModuleCaption, False, mainframe)
            '        Else
            '            Frm_plnt.Focus()
            '        End If


            '        'MANAGEMENT
            '    Case "CCIN"
            '        If (Not (Frm_ccin.IsHandleCreated)) OrElse (IsNothing(Frm_ccin)) Then
            '            Frm_ccin = New FRMccin
            '            Display(Frm_ccin, IMAGEDB.Main.ImageLibrary.CCIN_ICON, "[" & tcode.ToUpper & "] " & varModuleCode, varModuleCaption, False, mainframe)
            '        Else
            '            Frm_ccin.Focus()
            '        End If
            '    Case "CDIN"
            '        If (Not (Frm_cdin.IsHandleCreated)) OrElse (IsNothing(Frm_cdin)) Then
            '            Frm_cdin = New FRMcdin
            '            Display(Frm_cdin, IMAGEDB.Main.ImageLibrary.CDIN_ICON, "[" & tcode.ToUpper & "] " & varModuleCode, varModuleCaption, False, mainframe)
            '        Else
            '            Frm_cdin.Focus()
            '        End If
            '    Case "EPLS"
            '        If (Not (Frm_epls.IsHandleCreated)) OrElse (IsNothing(Frm_epls)) Then
            '            Frm_epls = New FRMepls
            '            Display(Frm_epls, IMAGEDB.Main.ImageLibrary.EPLS_ICON, "[" & tcode.ToUpper & "] " & varModuleCode, varModuleCaption, False, mainframe)
            '        Else
            '            Frm_epls.Focus()
            '        End If
            '    Case "POST"
            '        If (Not (Frm_post.IsHandleCreated)) OrElse (IsNothing(Frm_post)) Then
            '            Frm_post = New FRMpost
            '            Display(Frm_post, IMAGEDB.Main.ImageLibrary.POST_ICON, "[" & tcode.ToUpper & "] " & varModuleCode, varModuleCaption, False, mainframe)
            '        Else
            '            Frm_post.Focus()
            '        End If


            '        'CUSTOM
            '    Case "DAR"
            '        If (Not (Frm_dar.IsHandleCreated)) OrElse (IsNothing(Frm_dar)) Then
            '            Frm_dar = New FRMdar
            '            Display(Frm_dar, IMAGEDB.Main.ImageLibrary.DAR_ICON, "[" & tcode.ToUpper & "] " & varModuleCode, varModuleCaption, False, mainframe)
            '        Else
            '            Frm_dar.Focus()
            '        End If
            '    Case "DARD"
            '        If (Not (Frm_dard.IsHandleCreated)) OrElse (IsNothing(Frm_dard)) Then
            '            Frm_dard = New FRMdard
            '            Display(Frm_dard, IMAGEDB.Main.ImageLibrary.DAR_ICON, "[" & tcode.ToUpper & "] " & varModuleCode, varModuleCaption, False, mainframe)
            '        Else
            '            Frm_dar.Focus()
            '        End If
            '    Case "DRTM"
            '        If (Not (Frm_drtm.IsHandleCreated)) OrElse (IsNothing(Frm_drtm)) Then
            '            Frm_drtm = New FRMdrtm
            '            Display(Frm_drtm, IMAGEDB.Main.ImageLibrary.DAR_ICON, "[" & tcode.ToUpper & "] " & varModuleCode, varModuleCaption, False, mainframe)
            '        Else
            '            Frm_drtm.Focus()
            '        End If
            '    Case "DRAA"
            '        If (Not (Frm_draa.IsHandleCreated)) OrElse (IsNothing(Frm_draa)) Then
            '            Frm_draa = New FRMdraa
            '            Display(Frm_draa, IMAGEDB.Main.ImageLibrary.DAR_ICON, "[" & tcode.ToUpper & "] " & varModuleCode, varModuleCaption, False, mainframe)
            '        Else
            '            Frm_draa.Focus()
            '        End If
            '    Case "PEPR"
            '        If (Not (Frm_pepr.IsHandleCreated)) OrElse (IsNothing(Frm_pepr)) Then
            '            Frm_pepr = New PEPR
            '            Display(Frm_pepr, IMAGEDB.Main.ImageLibrary.JJP_ICON, "[" & tcode.ToUpper & "] " & varModuleCode, varModuleCaption, False, mainframe)
            '        Else
            '            Frm_pepr.Focus()
            '        End If
            '    Case "REMS"
            '        If (Not (Frm_rems.IsHandleCreated)) OrElse (IsNothing(Frm_rems)) Then
            '            Frm_rems = New REMS
            '            Display(Frm_rems, IMAGEDB.Main.ImageLibrary.JJP_ICON, "[" & tcode.ToUpper & "] " & varModuleCode, varModuleCaption, False, mainframe)
            '        Else
            '            Frm_rems.Focus()
            '        End If
            '    Case "SAY"
            '        If (Not (Frm_say.IsHandleCreated)) OrElse (IsNothing(Frm_say)) Then
            '            Frm_say = New SAY
            '            Display(Frm_say, IMAGEDB.Main.ImageLibrary.PLANT_ICON, "[" & tcode.ToUpper & "] " & varModuleCode, varModuleCaption, False,)
            '        Else
            '            Frm_ccin.Focus()
            '        End If


            '        'SYSTEM
            '    Case "MODS"
            '        If (Not (Frm_mods.IsHandleCreated)) OrElse (IsNothing(Frm_mods)) Then
            '            Frm_mods = New FRMmods
            '            Display(Frm_mods, IMAGEDB.Main.ImageLibrary.MODS_ICON, "[" & tcode.ToUpper & "] " & varModuleCode, varModuleCaption, False, mainframe)
            '        Else
            '            Frm_mods.Focus()
            '        End If
            '    Case "MOGS"
            '        If (Not (Frm_mogs.IsHandleCreated)) OrElse (IsNothing(Frm_mogs)) Then
            '            Frm_mogs = New MOGS
            '            Display(Frm_mogs, IMAGEDB.Main.ImageLibrary.MODS_ICON, "[" & tcode.ToUpper & "] " & varModuleCode, varModuleCaption, False, mainframe)
            '        Else
            '            Frm_mogs.Focus()
            '        End If
            '    Case "UAC"
            '        If (Not (Frm_uac.IsHandleCreated)) OrElse (IsNothing(Frm_uac)) Then
            '            Frm_uac = New UAC
            '            Display(Frm_uac, IMAGEDB.Main.ImageLibrary.UAC_ICON, "[" & tcode.ToUpper & "] " & varModuleCode, varModuleCaption, False, mainframe)
            '        Else
            '            Frm_uac.Focus()
            '        End If
            '    Case "SYSS"
            '        If (Not (Frm_syss.IsHandleCreated)) OrElse (IsNothing(Frm_syss)) Then
            '            Frm_syss = New SYSS
            '            Display(Frm_syss, IMAGEDB.Main.ImageLibrary.UAC_ICON, "[" & tcode.ToUpper & "] " & varModuleCode, varModuleCaption, False, mainframe)
            '        Else
            '            Frm_syss.Focus()
            '        End If


            '     'INSIDE APPS
            '    Case CType("DUMMY", Char)
            '        If (Not (Frm_dummy.IsHandleCreated)) OrElse (IsNothing(Frm_dummy)) Then
            '            Frm_dummy = New Dummy
            '            Display(Frm_dummy, IMAGEDB.Main.ImageLibrary.DUMMY_ICON, "[DUMMY] Dummy Form", "Dummy Form for testing", False, mainframe)
            '        Else
            '            Frm_dummy.Focus()
            '        End If
            '    Case "PHTRZ"
            '        If (Not (Frm_phtrz.IsHandleCreated)) OrElse (IsNothing(Frm_dummy)) Then
            '            Frm_phtrz = New FRMphotoresizer
            '            Display(Frm_phtrz, IMAGEDB.Main.ImageLibrary.COMPRESS_ICON, varModuleCode, varModuleCaption, True,)
            '        Else
            '            Frm_phtrz.Focus()
            '        End If

            '    Case "RESET"
            '        If (Not (Frm_reset.IsHandleCreated)) OrElse (IsNothing(Frm_reset)) Then
            '            Frm_reset = New RESET
            '            Display(Frm_reset, IMAGEDB.Main.ImageLibrary.RESET_ICON, "[RESET] Reset Your Application Settings", "Restore your application to initial configuration", True,)
            '        Else
            '            Frm_reset.Focus()
            '        End If
            'End Select

        Catch ex As Exception
            With proLog
                .AppVersion = GetAppVersion()
                .FromSender = "[Open] $\Ingrid\Apps\Core\Vb\010. Class\[WorkspaceClass.vb]"
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
    Private Sub EnsureOpen(Of F As {CMCv.FRMstandard, New})(ByRef formcode As F, icon As Object, title As String, caption As String, Optional isModal As Boolean = False, Optional parent As Form = Nothing)
        If formcode Is Nothing OrElse Not formcode.IsHandleCreated Then
            formcode = New F()
            Display(formcode, CType(icon, Image), title, caption, isModal, parent)
        Else
            formcode.Focus()
        End If
    End Sub
End Class