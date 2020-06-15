Public Class WorkspaceClass
#Region "Variables"
    Private _CommandExist As Boolean
    Private _CommandRestricted As Boolean
    Private _TCode() As String
    Private _SQL As New LibSQL.Workspace
    Private _MODSName As String
    Private _MODSDesc As String
#End Region

#Region "Declare Modules"
    'Accounting
    Private WithEvents _ACGR As New ACGR
    Private WithEvents _ACBK As New ACBK

    'Management
    Private WithEvents _CCIN As New CCIN
    Private WithEvents _CDIN As New CDIN
    Private WithEvents _POST As New POST
    Private WithEvents _EPLS As New EPLS

    'Logistic
    Private WithEvents _PLNT As New PLNT
    Private WithEvents _SLOC As New SLOC
    Private WithEvents _MCTG As New MCTG
    Private WithEvents _MMTY As New MMTY
    Private WithEvents _MMGR As New MMGR

    'Custom
    Private WithEvents _DAR As New DAR
    Private WithEvents _DARD As New DARD
    Private WithEvents _DRTM As New DRTM
    Private WithEvents _DRAA As New DRAA
    Private WithEvents _PEPR As New PEPR
    Private WithEvents _REMS As New REMS

    'System
    Private WithEvents _UAC As New UAC
    Private WithEvents _MODS As New MODS
    Private WithEvents _MOGS As New MOGS
    Private WithEvents _syss As New SYSS

    'Tools
    Private WithEvents _SAY As New SAY
    Private WithEvents _PHTRZ As New CMCv.PHTRZ

    'Dummy
    Private WithEvents _DUMMY As New Dummy
#End Region

    Public Sub Open(ByVal Mainframe As Form, ByVal UID As String, ByVal TCode As String, Optional StatusBar As CMCv.stt = Nothing)
        Try
            _TCode = TCode.ToString.Split("-".ToCharArray, StringSplitOptions.RemoveEmptyEntries)
            '_CommandExist = True
            '_CommandRestricted = False
            _MODSName = _SQL.GETModuleName(TCode)
            _MODSDesc = _SQL.GETModuleDescription(TCode)

            Select Case _TCode(0)
                'ACCOUNTING
                Case "ACGR"
                    If (_ACGR.IsHandleCreated = False) Or (IsNothing(_ACGR)) Then
                        _ACGR = New ACGR
                        DISPLAY(_ACGR, IMAGEDB.Main.ImageLibrary.ACGR_icon, "[" & TCode.ToUpper & "] " & _MODSName, _MODSDesc, False, Mainframe)
                    Else
                        _ACGR.Focus()
                    End If
                Case "ACBK"
                    If (_ACBK.IsHandleCreated = False) Or (IsNothing(_ACBK)) Then
                        _ACBK = New ACBK
                        DISPLAY(_ACBK, IMAGEDB.Main.ImageLibrary.ACBK_icon, "[" & TCode.ToUpper & "] " & _MODSName, _MODSDesc, False, Mainframe)
                    Else
                        _ACBK.Focus()
                    End If


                    'LOGISTICS
                Case "MCTG"
                    If (_MCTG.IsHandleCreated = False) Or (IsNothing(_MCTG)) Then
                        _MCTG = New MCTG
                        DISPLAY(_MCTG, IMAGEDB.Main.ImageLibrary.Catalogue_001_90_FFFFFFFF_, "[" & TCode.ToUpper & "] " & _MODSName, _MODSDesc, False, Mainframe)
                    Else
                        _MCTG.Focus()
                    End If
                Case "MMTY"
                    If (_MMTY.IsHandleCreated = False) Or (IsNothing(_MMTY)) Then
                        _MMTY = New MMTY
                        DISPLAY(_MMTY, IMAGEDB.Main.ImageLibrary.Catalogue_001_90_FFFFFFFF_, "[" & TCode.ToUpper & "] " & _MODSName, _MODSDesc, False, Mainframe)
                    Else
                        _MMTY.Focus()
                    End If
                Case "MMGR"
                    If (_MMGR.IsHandleCreated = False) Or (IsNothing(_MMGR)) Then
                        _MMGR = New MMGR
                        DISPLAY(_MMGR, IMAGEDB.Main.ImageLibrary.Catalogue_001_90_FFFFFFFF_, "[" & TCode.ToUpper & "] " & _MODSName, _MODSDesc, False, Mainframe)
                    Else
                        _MMGR.Focus()
                    End If
                Case "SLOC"
                    If (_SLOC.IsHandleCreated = False) Or (IsNothing(_SLOC)) Then
                        _SLOC = New SLOC
                        DISPLAY(_SLOC, IMAGEDB.Main.ImageLibrary.Storage_001_90_FFFFFFFF_, "[" & TCode.ToUpper & "] " & _MODSName, _MODSDesc, False, Mainframe)
                    Else
                        _SLOC.Focus()
                    End If
                Case "PLNT"
                    If (_PLNT.IsHandleCreated = False) Or (IsNothing(_PLNT)) Then
                        _PLNT = New PLNT
                        DISPLAY(_PLNT, IMAGEDB.Main.ImageLibrary.Plant_002_90_FFFFFFFF_, "[" & TCode.ToUpper & "] " & _MODSName, _MODSDesc, False, Mainframe)
                    Else
                        _PLNT.Focus()
                    End If


                    'MANAGEMENT
                Case "CCIN"
                    If (_CCIN.IsHandleCreated = False) Or (IsNothing(_CCIN)) Then
                        _CCIN = New CCIN
                        DISPLAY(_CCIN, IMAGEDB.Main.ImageLibrary.CCIN_001_512_icon, "[" & TCode.ToUpper & "] " & _MODSName, _MODSDesc, False, Mainframe)
                    Else
                        _CCIN.Focus()
                    End If
                Case "CDIN"
                    If (_CDIN.IsHandleCreated = False) Or (IsNothing(_CDIN)) Then
                        _CDIN = New CDIN
                        DISPLAY(_CDIN, IMAGEDB.Main.ImageLibrary.Departement_001_90_FFFFFFFF_, "[" & TCode.ToUpper & "] " & _MODSName, _MODSDesc, False, Mainframe)
                    Else
                        _CDIN.Focus()
                    End If
                Case "EPLS"
                    If (_EPLS.IsHandleCreated = False) Or (IsNothing(_EPLS)) Then
                        _EPLS = New EPLS
                        DISPLAY(_EPLS, IMAGEDB.Main.ImageLibrary.EPLS_001_512_icon, "[" & TCode.ToUpper & "] " & _MODSName, _MODSDesc, False, Mainframe)
                    Else
                        _EPLS.Focus()
                    End If
                Case "POST"
                    If (_POST.IsHandleCreated = False) Or (IsNothing(_POST)) Then
                        _POST = New POST
                        DISPLAY(_POST, IMAGEDB.Main.ImageLibrary.POST_001_512_icon, "[" & TCode.ToUpper & "] " & _MODSName, _MODSDesc, False, Mainframe)
                    Else
                        _POST.Focus()
                    End If


                    'CUSTOM
                Case "DAR"
                    If (_DAR.IsHandleCreated = False) Or (IsNothing(_DAR)) Then
                        _DAR = New DAR
                        DISPLAY(_DAR, IMAGEDB.Main.ImageLibrary.DAR_icon, "[" & TCode.ToUpper & "] " & _MODSName, _MODSDesc, False, Mainframe)
                    Else
                        _DAR.Focus()
                    End If
                Case "DARD"
                    If (_DARD.IsHandleCreated = False) Or (IsNothing(_DARD)) Then
                        _DARD = New DARD
                        DISPLAY(_DARD, IMAGEDB.Main.ImageLibrary.DAR_icon, "[" & TCode.ToUpper & "] " & _MODSName, _MODSDesc, False, Mainframe)
                    Else
                        _DAR.Focus()
                    End If
                Case "DRTM"
                    If (_DRTM.IsHandleCreated = False) Or (IsNothing(_DRTM)) Then
                        _DRTM = New DRTM
                        DISPLAY(_DRTM, IMAGEDB.Main.ImageLibrary.DAR_icon, "[" & TCode.ToUpper & "] " & _MODSName, _MODSDesc, False, Mainframe)
                    Else
                        _DRTM.Focus()
                    End If
                Case "DRAA"
                    If (_DRAA.IsHandleCreated = False) Or (IsNothing(_DRAA)) Then
                        _DRAA = New DRAA
                        DISPLAY(_DRAA, IMAGEDB.Main.ImageLibrary.DAR_icon, "[" & TCode.ToUpper & "] " & _MODSName, _MODSDesc, False, Mainframe)
                    Else
                        _DRAA.Focus()
                    End If
                Case "PEPR"
                    If (_PEPR.IsHandleCreated = False) Or (IsNothing(_PEPR)) Then
                        _PEPR = New PEPR
                        DISPLAY(_PEPR, IMAGEDB.Main.ImageLibrary.JJP_icon, "[" & TCode.ToUpper & "] " & _MODSName, _MODSDesc, False, Mainframe)
                    Else
                        _REMS.Focus()
                    End If
                Case "REMS"
                    If (_REMS.IsHandleCreated = False) Or (IsNothing(_REMS)) Then
                        _REMS = New REMS
                        DISPLAY(_REMS, IMAGEDB.Main.ImageLibrary.JJP_icon, "[" & TCode.ToUpper & "] " & _MODSName, _MODSDesc, False, Mainframe)
                    Else
                        _REMS.Focus()
                    End If
                Case "SAY"
                    If (_SAY.IsHandleCreated = False) Or (IsNothing(_SAY)) Then
                        _SAY = New SAY
                        Display(_SAY, IMAGEDB.Main.ImageLibrary.Plant_001_90_FFFFFFFF_, "[" & TCode.ToUpper & "] " & _MODSName, _MODSDesc, False,)
                    Else
                        _CCIN.Focus()
                    End If


                    'SYSTEM
                Case "MODS"
                    If (_MODS.IsHandleCreated = False) Or (IsNothing(_MODS)) Then
                        _MODS = New MODS
                        DISPLAY(_MODS, IMAGEDB.Main.ImageLibrary.MODS_001_512_icon, "[" & TCode.ToUpper & "] " & _MODSName, _MODSDesc, False, Mainframe)
                    Else
                        _MODS.Focus()
                    End If
                Case "MOGS"
                    If (_MOGS.IsHandleCreated = False) Or (IsNothing(_MOGS)) Then
                        _MOGS = New MOGS
                        DISPLAY(_MOGS, IMAGEDB.Main.ImageLibrary.MODS_001_512_icon, "[" & TCode.ToUpper & "] " & _MODSName, _MODSDesc, False, Mainframe)
                    Else
                        _MOGS.Focus()
                    End If
                Case "UAC"
                    If (_UAC.IsHandleCreated = False) Or (IsNothing(_UAC)) Then
                        _UAC = New UAC
                        DISPLAY(_UAC, IMAGEDB.Main.ImageLibrary.UAC_001_512_icon, "[" & TCode.ToUpper & "] " & _MODSName, _MODSDesc, False, Mainframe)
                    Else
                        _UAC.Focus()
                    End If
                Case "SYSS"
                    If (_syss.IsHandleCreated = False) Or (IsNothing(_syss)) Then
                        _syss = New SYSS
                        DISPLAY(_syss, IMAGEDB.Main.ImageLibrary.UAC_001_512_icon, "[" & TCode.ToUpper & "] " & _MODSName, _MODSDesc, False, Mainframe)
                    Else
                        _syss.Focus()
                    End If


                 'INSIDE APPS
                Case "DUMMY"
                    If (_DUMMY.IsHandleCreated = False) Or (IsNothing(_DUMMY)) Then
                        _DUMMY = New Dummy
                        DISPLAY(_DUMMY, IMAGEDB.Main.ImageLibrary.DUMMY_icon, "[DUMMY] Dummy Form", "Dummy Form for testing", False, Mainframe)
                    Else
                        _DUMMY.Focus()
                    End If
                Case "PHTRZ"
                    If (_DUMMY.IsHandleCreated = False) Or (IsNothing(_DUMMY)) Then
                        _PHTRZ = New CMCv.PHTRZ
                        Display(_PHTRZ, IMAGEDB.Main.ImageLibrary.COMPRESS_icon, _MODSName, _MODSDesc, True,)
                    Else
                        _PHTRZ.Focus()
                    End If



            End Select

            'If _CommandExist = True And _CommandRestricted = False Then
            '    StatusBar.Items("ts_status").Text = ""
            'End If
        Catch ex As Exception
            Call PUSHERRORDATA(CMCv.Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, 0, ex.StackTrace, GETAPPVERSION, , True, True)
            Call PUSHERRORDATASHOW()
        End Try
    End Sub

    Private Sub _MODS_DATACHANGED() Handles _MODS.DATACHANGED
        _ForceRefreshMainframeData = True
    End Sub
End Class
