Imports System.Runtime.Versioning

Public Class MODS
#Region "Variables"
    Private V_SQL As New Commands.MODS.View
    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip
    Private WithEvents _MODS_Editor As New MODS_Editor
    Public Event DATACHANGED()
#End Region

#Region "Subs Collection"

    <SupportedOSPlatform("windows")>
    Private Sub GETDATA(Optional ByVal ForceRefresh As Boolean = False)
        DblBuffer(DgnMODS)
        Commands.MODS.View.DisplayData(V_DatabaseEngine, DgnMODS, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    Private Sub GETTableID()
        V_FORMAttrib.RowID = "-1"

        If DgnMODS.RowCount > 0 Then
            V_FORMAttrib.RowID = DgnMODS.CurrentRow.Cells("module_id").Value.ToString
        End If
    End Sub
#End Region

#Region "Menu Strip Functions"

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventDataAddNew() Handles _MMSMenu.EventDataAddNew
        If Not (V_USERAccess.User("MODS", V_USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Add)) Then
            Decision("You are not authorized to : Add new record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        V_FORMAttrib.IsNew = True
        V_FORMAttrib.RowID = "-1"
        V_FORMAttrib.Hash = CMCv.Security.Encrypt.MD5()
        _MODS_Editor = New MODS_Editor
        Display(_MODS_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new module", True)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataEdit() Handles _MMSMenu.EventDataEdit
        If Not (V_USERAccess.User("UAC", V_USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Edit)) Then
            Decision("You are not authorized to : Modify existing record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        Call GETTableID()
        V_FORMAttrib.IsNew = False

        If V_FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            V_FORMAttrib.IsNew = False
            _MODS_Editor = New MODS_Editor
            Display(_MODS_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your employee data", True)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles _MMSMenu.EventDataDelete
        If Not (V_USERAccess.User("MODS", V_USERAttrib.UID, LibSQL.Application.Access.TypeOfAccess.Delete)) Then
            Decision("You are not authorized to : Delete record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        Call GETTableID()

        If V_FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (Commands.DAR.View.DELETEData(V_DatabaseEngine, V_FORMAttrib.RowID)) Then
                    Call GETDATA(True)
                    RaiseEvent DATACHANGED()
                    Mainframe_n_6.Ts_status.Text = "Success"
                Else
                    Mainframe_n_6.Ts_status.Text = "Delete failed"
                End If
            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataRefresh() Handles _MMSMenu.EventDataRefresh
        TxtFind.Clear()
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub

    Private Sub EventDataClose() Handles _MMSMenu.EventDataClose
        Me.Close()
    End Sub

    Private Sub EventToolsFind() Handles _MMSMenu.EventToolsFind
        TxtFind.Focus()
    End Sub
#End Region

#Region "Form Events"
    <SupportedOSPlatform("windows")>
    Private Sub MODS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _MMSMenu.LoadIn(Me)
        _MMSMenu.ShowMenuDATA(CMCv.UI.View.MenuStrip.ShowItem.Yes)
        TxtFind.ClearSearch()
        DgnMODS.XOGETNewColor()
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub

    Private Sub _MMSMenu_EventToolsFind() Handles _MMSMenu.EventToolsFind
        TxtFind.Focus()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MODS_Editor_RecordSaved() Handles _MODS_Editor.RecordSaved
        Call GETDATA()
        RaiseEvent DATACHANGED()
    End Sub

#End Region
End Class
