Imports System.Runtime.Versioning

Public Class FRMuac
#Region "Declaration"
    Private WithEvents Frm_uac_Editor As FRMuacEditor
    Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip
#End Region

#Region "Subs Collections"

    <SupportedOSPlatform("windows")>
    Private Sub GetData(Optional forcerefresh As Boolean = False)
        CMDuac.View.DisplayData(varDatabaseName, varDatabaseEngineE, DgnUAC, SLFStatus, TxtFind, forcerefresh)
    End Sub

    Private Sub GetRowID()
        varFormProperties.RowID = "-1"

        If DgnUAC.RowCount > 0 Then
            varFormProperties.RowID = DgnUAC.CurrentRow.Cells("user_id").Value.ToString
        End If
    End Sub
#End Region

#Region "Menu Strip Functions"

    <SupportedOSPlatform("windows")>
    Private Sub EventDataAddNew() Handles Com_mms_Menu.EventDataAddNew
        varFormProperties.IsChangePasswordForm = False

        If Not (varUserAccess.User(varDatabaseName, "UAC", varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Add)) Then
            Decision(My.Application.Info.AssemblyName, "You are not authorized to : Add new record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Return
        End If

        varFormProperties.IsNew = True
        varFormProperties.RowID = "-1"
        varFormProperties.Hash = Security.Encrypt.MD5()
        Frm_uac_Editor = New FRMuacEditor
        Display(Frm_uac_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Add New Record", "Add new credential data", True)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataEdit() Handles Com_mms_Menu.EventDataEdit
        varFormProperties.IsChangePasswordForm = False

        If Not (varUserAccess.User(varDatabaseName, "UAC", varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Edit)) Then
            Decision(My.Application.Info.AssemblyName, "You are not authorized to : Modify existing record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Return
        End If

        Call GetRowID()
        varFormProperties.IsNew = False

        If Convert.ToString(varFormProperties.RowID) = "-1" Then
            Decision(My.Application.Info.AssemblyName, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        Else
            varFormProperties.IsNew = False
            Frm_uac_Editor = New FRMuacEditor
            Display(Frm_uac_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Update Record", "Update your employee data", True)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles Com_mms_Menu.EventDataDelete
        If Not (varUserAccess.User(varDatabaseName, "UAC", varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Delete)) Then
            Decision(My.Application.Info.AssemblyName, "You are not authorized to : Delete record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Return
        End If

        Call GetRowID()

        If Convert.ToString(varFormProperties.RowID) = "-1" Then
            Decision(My.Application.Info.AssemblyName, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        Else
            If Decision(My.Application.Info.AssemblyName, "Do you want to delete this record?", LibApp.Ingrid.Global.PopupType.Delete, "", CMCv.FRMdialogbox.MessageIcon.Question, CMCv.FRMdialogbox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (CMDuac.View.DeleteData(varDatabaseName, varDatabaseEngineE, Convert.ToString(varFormProperties.RowID))) Then
                    Call GetData(True)
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
    End Sub

    Private Sub EventDataClose() Handles Com_mms_Menu.EventDataClose
        Me.Close()
    End Sub

    Private Sub EventToolsFind() Handles Com_mms_Menu.EventToolsFind
        TxtFind.Focus()
    End Sub
#End Region

    <SupportedOSPlatform("windows")>
    Private Sub FRMuac_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Com_mms_Menu.LoadIn(Me)
        Com_mms_Menu.ShowMenuData(UI.View.MenuStrip.ShowItem.Yes)
        DgnUAC.XOGETNewColor()
        Call GetData()
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

    <SupportedOSPlatform("windows")>
    Private Sub FRMuacEditor_RecordSaved() Handles Frm_uac_Editor.EventRecordSaved
        Call GetData()
    End Sub
End Class
