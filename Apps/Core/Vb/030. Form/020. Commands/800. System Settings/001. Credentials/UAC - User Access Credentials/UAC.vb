Imports System.Runtime.Versioning
Imports CMCv

Public Class UAC
#Region "Variables"
    Private V_SQL As New Commands.UAC.View
    Private WithEvents V_UAC_Editor As UAC_Editor
    Private WithEvents V_MMSMenu As New CMCv.UI.View.MenuStrip
#End Region

#Region "Subs Collections"

    <SupportedOSPlatform("windows")>
    Private Sub GetData(Optional ByVal ForceRefresh As Boolean = False)
        Commands.UAC.View.DisplayData(varDatabaseName, varDatabaseEngine, DgnUAC, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    Private Sub GetTableID()
        varFormAttributes.RowID = "-1"

        If DgnUAC.RowCount > 0 Then
            varFormAttributes.RowID = DgnUAC.CurrentRow.Cells("user_id").Value.ToString
        End If
    End Sub
#End Region

#Region "Menu Strip Functions"

    <SupportedOSPlatform("windows")>
    Private Sub EventDataAddNew() Handles V_MMSMenu.EventDataAddNew
        varFormAttributes.IsChangePasswordForm = False

        If Not (varUserAccess.User(varDatabaseName, "UAC", varUserAttributes.UID, LibSQL.Application.Access.TypeOfAccess.Add)) Then
            Decision("You are not authorized to : Add new record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        varFormAttributes.IsNew = True
        varFormAttributes.RowID = "-1"
        varFormAttributes.Hash = Security.Encrypt.MD5()
        V_UAC_Editor = New UAC_Editor
        DISPLAY(V_UAC_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new credential data", True)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataEdit() Handles V_MMSMenu.EventDataEdit
        varFormAttributes.IsChangePasswordForm = False

        If Not (varUserAccess.User(varDatabaseName, "UAC", varUserAttributes.UID, LibSQL.Application.Access.TypeOfAccess.Edit)) Then
            Decision("You are not authorized to : Modify existing record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        Call GETTableID()
        varFormAttributes.IsNew = False

        If varFormAttributes.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            varFormAttributes.IsNew = False
            V_UAC_Editor = New UAC_Editor
            DISPLAY(V_UAC_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your employee data", True)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles V_MMSMenu.EventDataDelete
        If Not (varUserAccess.User(varDatabaseName, "UAC", varUserAttributes.UID, LibSQL.Application.Access.TypeOfAccess.Delete)) Then
            Decision("You are not authorized to : Delete record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        Call GETTableID()

        If varFormAttributes.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (Commands.UAC.View.DeleteData(varDatabaseName, varDatabaseEngine, varFormAttributes.RowID)) Then
                    Call GetData(True)
                    Mainframe_n_6.Ts_status.Text = "Success"
                Else
                    Mainframe_n_6.Ts_status.Text = "Delete failed"
                End If
            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataRefresh() Handles V_MMSMenu.EventDataRefresh
        TxtFind.Clear()
        Call GetData(True)
    End Sub

    Private Sub EventDataClose() Handles V_MMSMenu.EventDataClose
        Me.Close()
    End Sub

    Private Sub EventToolsFind() Handles V_MMSMenu.EventToolsFind
        TxtFind.Focus()
    End Sub
#End Region

    <SupportedOSPlatform("windows")>
    Private Sub UAC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        V_MMSMenu.LoadIn(Me)
        V_MMSMenu.ShowMenuDATA(UI.View.MenuStrip.ShowItem.Yes)
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
    Private Sub _UAC_Editor_RecordSaved() Handles V_UAC_Editor.RecordSaved
        Call GetData()
    End Sub
End Class
