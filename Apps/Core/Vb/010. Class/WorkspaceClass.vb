Imports System.Runtime.Versioning
Imports Microsoft.CodeAnalysis.VisualBasic.Syntax

Public Class WorkspaceClass
#Region "Variables"
    Private ReadOnly V_CommandExist As Boolean
    Private ReadOnly V_CommandRestricted As Boolean
    Private V_TCode As String()
    Private ReadOnly V_SQL As New LibSQL.Workspace
    Private V_MODSName As String
    Private V_MODSDesc As String
#End Region

#Region "Declare Modules"
    'Accounting
    Private WithEvents V_ACGR As New ACGR
    Private WithEvents V_ACBK As New ACBK

    'Management
    Private WithEvents V_CCIN As New CCIN
    Private WithEvents V_CDIN As New CDIN
    Private WithEvents V_POST As New POST
    Private WithEvents V_EPLS As New EPLS

    'Logistic
    Private WithEvents V_PLNT As New PLNT
    Private WithEvents V_SLOC As New SLOC
    Private WithEvents V_MCTG As New MCTG
    Private WithEvents V_MMTY As New MMTY
    Private WithEvents V_MMGR As New MMGR

    'Custom
    Private WithEvents V_DAR As New DAR
    Private WithEvents V_DARD As New DARD
    Private WithEvents V_DRTM As New DRTM
    Private WithEvents V_DRAA As New DRAA
    Private WithEvents V_PEPR As New PEPR
    Private WithEvents V_REMS As New REMS

    'System
    Private WithEvents V_UAC As New UAC
    Private WithEvents V_MODS As New MODS
    Private WithEvents V_MOGS As New MOGS
    Private WithEvents V_SYSS As New SYSS

    'Tools
    Private WithEvents V_SAY As New SAY
    Private WithEvents V_PHTRZ As New CMCv.PHTRZ

    'DummVy
    Private WithEvents V_DUMMY As New Dummy

    Private WithEvents V_RESET As New RESET
#End Region

    <SupportedOSPlatform("windows")>
    Public Sub Open(ByVal Mainframe As Form, ByVal TCode As String, Optional StatusBar As CMCv.stt = Nothing)
        Try
            V_TCode = TCode.ToString.Split("-".ToCharArray, StringSplitOptions.RemoveEmptyEntries)
            '_CommandExist = True
            '_CommandRestricted = False
            V_MODSName = LibSQL.Workspace.GETModuleName(TCode)
            V_MODSDesc = LibSQL.Workspace.GETModuleDescription(TCode)

            Select Case V_TCode(0)
                'ACCOUNTING
                Case "ACGR"
                    If (Not (V_ACGR.IsHandleCreated)) OrElse (IsNothing(V_ACGR)) Then
                        V_ACGR = New ACGR
                        DISPLAY(V_ACGR, IMAGEDB.Main.ImageLibrary.ACGR_ICON, "[" & TCode.ToUpper & "] " & V_MODSName, V_MODSDesc, False, Mainframe)
                    Else
                        V_ACGR.Focus()
                    End If
                Case "ACBK"
                    If (Not (V_ACBK.IsHandleCreated)) OrElse (IsNothing(V_ACBK)) Then
                        V_ACBK = New ACBK
                        DISPLAY(V_ACBK, IMAGEDB.Main.ImageLibrary.ACBK_ICON, "[" & TCode.ToUpper & "] " & V_MODSName, V_MODSDesc, False, Mainframe)
                    Else
                        V_ACBK.Focus()
                    End If


                    'LOGISTICS
                Case "MCTG"
                    If (Not (V_MCTG.IsHandleCreated)) OrElse (IsNothing(V_MCTG)) Then
                        V_MCTG = New MCTG
                        DISPLAY(V_MCTG, IMAGEDB.Main.ImageLibrary.CATALOGUE_ICON, "[" & TCode.ToUpper & "] " & V_MODSName, V_MODSDesc, False, Mainframe)
                    Else
                        V_MCTG.Focus()
                    End If
                Case "MMTY"
                    If (Not (V_MMTY.IsHandleCreated)) OrElse (IsNothing(V_MMTY)) Then
                        V_MMTY = New MMTY
                        DISPLAY(V_MMTY, IMAGEDB.Main.ImageLibrary.CATALOGUE_ICON, "[" & TCode.ToUpper & "] " & V_MODSName, V_MODSDesc, False, Mainframe)
                    Else
                        V_MMTY.Focus()
                    End If
                Case "MMGR"
                    If (Not (V_MMGR.IsHandleCreated)) OrElse (IsNothing(V_MMGR)) Then
                        V_MMGR = New MMGR
                        DISPLAY(V_MMGR, IMAGEDB.Main.ImageLibrary.CATALOGUE_ICON, "[" & TCode.ToUpper & "] " & V_MODSName, V_MODSDesc, False, Mainframe)
                    Else
                        V_MMGR.Focus()
                    End If
                Case "SLOC"
                    If (Not (V_SLOC.IsHandleCreated)) OrElse (IsNothing(V_SLOC)) Then
                        V_SLOC = New SLOC
                        DISPLAY(V_SLOC, IMAGEDB.Main.ImageLibrary.STORAGE_ICON, "[" & TCode.ToUpper & "] " & V_MODSName, V_MODSDesc, False, Mainframe)
                    Else
                        V_SLOC.Focus()
                    End If
                Case "PLNT"
                    If (Not (V_PLNT.IsHandleCreated)) OrElse (IsNothing(V_PLNT)) Then
                        V_PLNT = New PLNT
                        DISPLAY(V_PLNT, IMAGEDB.Main.ImageLibrary.PLANT_ICON, "[" & TCode.ToUpper & "] " & V_MODSName, V_MODSDesc, False, Mainframe)
                    Else
                        V_PLNT.Focus()
                    End If


                    'MANAGEMENT
                Case "CCIN"
                    If (Not (V_CCIN.IsHandleCreated)) OrElse (IsNothing(V_CCIN)) Then
                        V_CCIN = New CCIN
                        DISPLAY(V_CCIN, IMAGEDB.Main.ImageLibrary.CCIN_ICON, "[" & TCode.ToUpper & "] " & V_MODSName, V_MODSDesc, False, Mainframe)
                    Else
                        V_CCIN.Focus()
                    End If
                Case "CDIN"
                    If (Not (V_CDIN.IsHandleCreated)) OrElse (IsNothing(V_CDIN)) Then
                        V_CDIN = New CDIN
                        DISPLAY(V_CDIN, IMAGEDB.Main.ImageLibrary.CDIN_ICON, "[" & TCode.ToUpper & "] " & V_MODSName, V_MODSDesc, False, Mainframe)
                    Else
                        V_CDIN.Focus()
                    End If
                Case "EPLS"
                    If (Not (V_EPLS.IsHandleCreated)) OrElse (IsNothing(V_EPLS)) Then
                        V_EPLS = New EPLS
                        DISPLAY(V_EPLS, IMAGEDB.Main.ImageLibrary.EPLS_ICON, "[" & TCode.ToUpper & "] " & V_MODSName, V_MODSDesc, False, Mainframe)
                    Else
                        V_EPLS.Focus()
                    End If
                Case "POST"
                    If (Not (V_POST.IsHandleCreated)) OrElse (IsNothing(V_POST)) Then
                        V_POST = New POST
                        DISPLAY(V_POST, IMAGEDB.Main.ImageLibrary.POST_ICON, "[" & TCode.ToUpper & "] " & V_MODSName, V_MODSDesc, False, Mainframe)
                    Else
                        V_POST.Focus()
                    End If


                    'CUSTOM
                Case "DAR"
                    If (Not (V_DAR.IsHandleCreated)) OrElse (IsNothing(V_DAR)) Then
                        V_DAR = New DAR
                        DISPLAY(V_DAR, IMAGEDB.Main.ImageLibrary.DAR_ICON, "[" & TCode.ToUpper & "] " & V_MODSName, V_MODSDesc, False, Mainframe)
                    Else
                        V_DAR.Focus()
                    End If
                Case "DARD"
                    If (Not (V_DARD.IsHandleCreated)) OrElse (IsNothing(V_DARD)) Then
                        V_DARD = New DARD
                        DISPLAY(V_DARD, IMAGEDB.Main.ImageLibrary.DAR_ICON, "[" & TCode.ToUpper & "] " & V_MODSName, V_MODSDesc, False, Mainframe)
                    Else
                        V_DAR.Focus()
                    End If
                Case "DRTM"
                    If (Not (V_DRTM.IsHandleCreated)) OrElse (IsNothing(V_DRTM)) Then
                        V_DRTM = New DRTM
                        DISPLAY(V_DRTM, IMAGEDB.Main.ImageLibrary.DAR_ICON, "[" & TCode.ToUpper & "] " & V_MODSName, V_MODSDesc, False, Mainframe)
                    Else
                        V_DRTM.Focus()
                    End If
                Case "DRAA"
                    If (Not (V_DRAA.IsHandleCreated)) OrElse (IsNothing(V_DRAA)) Then
                        V_DRAA = New DRAA
                        DISPLAY(V_DRAA, IMAGEDB.Main.ImageLibrary.DAR_ICON, "[" & TCode.ToUpper & "] " & V_MODSName, V_MODSDesc, False, Mainframe)
                    Else
                        V_DRAA.Focus()
                    End If
                Case "PEPR"
                    If (Not (V_PEPR.IsHandleCreated)) OrElse (IsNothing(V_PEPR)) Then
                        V_PEPR = New PEPR
                        DISPLAY(V_PEPR, IMAGEDB.Main.ImageLibrary.JJP_ICON, "[" & TCode.ToUpper & "] " & V_MODSName, V_MODSDesc, False, Mainframe)
                    Else
                        V_REMS.Focus()
                    End If
                Case "REMS"
                    If (Not (V_REMS.IsHandleCreated)) OrElse (IsNothing(V_REMS)) Then
                        V_REMS = New REMS
                        DISPLAY(V_REMS, IMAGEDB.Main.ImageLibrary.JJP_ICON, "[" & TCode.ToUpper & "] " & V_MODSName, V_MODSDesc, False, Mainframe)
                    Else
                        V_REMS.Focus()
                    End If
                Case "SAY"
                    If (Not (V_SAY.IsHandleCreated)) OrElse (IsNothing(V_SAY)) Then
                        V_SAY = New SAY
                        DISPLAY(V_SAY, IMAGEDB.Main.ImageLibrary.PLANT_ICON, "[" & TCode.ToUpper & "] " & V_MODSName, V_MODSDesc, False,)
                    Else
                        V_CCIN.Focus()
                    End If


                    'SYSTEM
                Case "MODS"
                    If (Not (V_MODS.IsHandleCreated)) OrElse (IsNothing(V_MODS)) Then
                        V_MODS = New MODS
                        DISPLAY(V_MODS, IMAGEDB.Main.ImageLibrary.MODS_ICON, "[" & TCode.ToUpper & "] " & V_MODSName, V_MODSDesc, False, Mainframe)
                    Else
                        V_MODS.Focus()
                    End If
                Case "MOGS"
                    If (Not (V_MOGS.IsHandleCreated)) OrElse (IsNothing(V_MOGS)) Then
                        V_MOGS = New MOGS
                        DISPLAY(V_MOGS, IMAGEDB.Main.ImageLibrary.MODS_ICON, "[" & TCode.ToUpper & "] " & V_MODSName, V_MODSDesc, False, Mainframe)
                    Else
                        V_MOGS.Focus()
                    End If
                Case "UAC"
                    If (Not (V_UAC.IsHandleCreated)) OrElse (IsNothing(V_UAC)) Then
                        V_UAC = New UAC
                        DISPLAY(V_UAC, IMAGEDB.Main.ImageLibrary.UAC_ICON, "[" & TCode.ToUpper & "] " & V_MODSName, V_MODSDesc, False, Mainframe)
                    Else
                        V_UAC.Focus()
                    End If
                Case "SYSS"
                    If (Not (V_SYSS.IsHandleCreated)) OrElse (IsNothing(V_SYSS)) Then
                        V_SYSS = New SYSS
                        DISPLAY(V_SYSS, IMAGEDB.Main.ImageLibrary.UAC_ICON, "[" & TCode.ToUpper & "] " & V_MODSName, V_MODSDesc, False, Mainframe)
                    Else
                        V_SYSS.Focus()
                    End If


                 'INSIDE APPS
                Case CType("DUMMY", Char)
                    If (Not (V_DUMMY.IsHandleCreated)) OrElse (IsNothing(V_DUMMY)) Then
                        V_DUMMY = New Dummy
                        DISPLAY(V_DUMMY, IMAGEDB.Main.ImageLibrary.DUMMY_ICON, "[DUMMY] Dummy Form", "Dummy Form for testing", False, Mainframe)
                    Else
                        V_DUMMY.Focus()
                    End If
                Case "PHTRZ"
                    If (Not (V_DUMMY.IsHandleCreated)) OrElse (IsNothing(V_DUMMY)) Then
                        V_PHTRZ = New CMCv.PHTRZ
                        DISPLAY(V_PHTRZ, IMAGEDB.Main.ImageLibrary.COMPRESS_ICON, V_MODSName, V_MODSDesc, True,)
                    Else
                        V_PHTRZ.Focus()
                    End If

                Case "RESET"
                    If (Not (V_RESET.IsHandleCreated)) OrElse (IsNothing(V_RESET)) Then
                        V_RESET = New RESET
                        DISPLAY(V_RESET, IMAGEDB.Main.ImageLibrary.RESET_ICON, "[RESET] Reset Your Application Settings", "Restore your application to initial configuration", True,)
                    Else
                        V_RESET.Focus()
                    End If
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

    Private Shared Sub V_MODS_DATACHANGED() Handles V_MODS.DATACHANGED
        varForceRefreshMainframeData = True
    End Sub
End Class