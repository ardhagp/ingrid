Imports System.Runtime.Versioning

Public Class FRMmods
#Region "Variables"
    Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip
    Private WithEvents Frm_mods_Editor As New MODS_Editor

    Public Event EventDataChanged()

#End Region

#Region "Subs Collection"

    <SupportedOSPlatform("windows")>
    Private Sub GetData(Optional ByVal forcerefresh As Boolean = False)
        DblBuffer(DgnMODS)
        Commands.MODS.View.DisplayData(varDatabaseName, varDatabaseEngine, DgnMODS, SLFStatus, TxtFind, forcerefresh)
    End Sub

    Private Sub GetRowID()
        varFormProperties.RowID = "-1"

        If DgnMODS.RowCount > 0 Then
            varFormProperties.RowID = DgnMODS.CurrentRow.Cells("module_id").Value.ToString
        End If
    End Sub
#End Region

#Region "Menu Strip Functions"

    <SupportedOSPlatform("windows")>
    Private Sub CommmsMenu_EventDataAddNew() Handles Com_mms_Menu.EventDataAddNew
        If Not (varUserAccess.User(varDatabaseName, "MODS", varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Add)) Then
            Decision("You are not authorized to : Add new record", "Not Authorized", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Return
        End If

        varFormProperties.IsNew = True
        varFormProperties.RowID = "-1"
        varFormProperties.Hash = CMCv.Security.Encrypt.MD5()
        Frm_mods_Editor = New MODS_Editor
        Display(Frm_mods_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new module", True)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataEdit() Handles Com_mms_Menu.EventDataEdit
        If Not (varUserAccess.User(varDatabaseName, "UAC", varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Edit)) Then
            Decision("You are not authorized to : Modify existing record", "Not Authorized", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Return
        End If

        Call GetRowID()
        varFormProperties.IsNew = False

        If Convert.ToString(varFormProperties.RowID) = "-1" Then
            Decision("No record selected", "Error", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        Else
            varFormProperties.IsNew = False
            Frm_mods_Editor = New MODS_Editor
            Display(Frm_mods_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your employee data", True)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles Com_mms_Menu.EventDataDelete
        If Not (varUserAccess.User(varDatabaseName, "MODS", varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Delete)) Then
            Decision("You are not authorized to : Delete record", "Not Authorized", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Return
        End If

        Call GetRowID()

        If Convert.ToString(varFormProperties.RowID) = "-1" Then
            Decision("No record selected", "Error", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        Else
            If Decision("Do you want to delete this record?", "Delete", CMCv.FRMdialogbox.MessageIcon.Question, CMCv.FRMdialogbox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (CMDdar.View.DeleteData(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))) Then
                    Call GetData(True)
                    RaiseEvent EventDataChanged()
                    FRMmainframe6.Ts_status.Text = "Success"
                Else
                    FRMmainframe6.Ts_status.Text = "Delete failed"
                End If
            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataRefresh() Handles Com_mms_Menu.EventDataRefresh
        TxtFind.Clear()
        Call GetData(True)
        TxtFind.ClearSearch()
    End Sub

    Private Sub EventDataClose() Handles Com_mms_Menu.EventDataClose
        Me.Close()
    End Sub

    Private Sub EventToolsFind() Handles Com_mms_Menu.EventToolsFind
        TxtFind.Focus()
    End Sub
#End Region

#Region "Form Events"
    <SupportedOSPlatform("windows")>
    Private Sub FRMmods_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Com_mms_Menu.LoadIn(Me)
        Com_mms_Menu.ShowMenuData(CMCv.UI.View.MenuStrip.ShowItem.Yes)
        TxtFind.ClearSearch()
        DgnMODS.XOGeTNewColor()
        Call GetData(True)
        TxtFind.ClearSearch()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GetData()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GetData(True)
        TxtFind.ClearSearch()
    End Sub

    Private Sub CommmsMenu_EventToolsFind() Handles Com_mms_Menu.EventToolsFind
        TxtFind.Focus()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub FRMmodsEditor_RecordSaved() Handles Frm_mods_Editor.RecordSaved
        Call GetData()
        RaiseEvent EventDataChanged()
    End Sub

#End Region
End Class
