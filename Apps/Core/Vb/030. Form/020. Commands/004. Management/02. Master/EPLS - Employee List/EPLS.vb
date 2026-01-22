Imports System.Runtime.Versioning
Imports CMCv

Public Class FRMepls
#Region "Variables"
    Private WithEvents Frm_epls_Editor As New FRMeplsEditor
    Private WithEvents Com_mms_Menu As New UI.View.MenuStrip
#End Region

#Region "Subs Collections"

    <SupportedOSPlatform("windows")>
    Private Sub GetData(Optional forcerefresh As Boolean = False)
        CMDepls.View.DisplayData(varDatabaseName, varDatabaseEngine, DgnEPLS, SLFStatus, TxtFind, forcerefresh)
    End Sub

    Private Sub GetRowID()
        varFormProperties.RowID = "-1"

        If DgnEPLS.RowCount > 0 Then
            varFormProperties.RowID = DgnEPLS.CurrentRow.Cells("employee_id").Value.ToString
        End If
    End Sub
#End Region

#Region "Menu Strip Functions"
    <SupportedOSPlatform("windows")>
    Private Sub EventDataAddNew() Handles Com_mms_Menu.EventDataAddNew
        If Not (varUserAccess.User(varDatabaseName, "EPLS", varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Add)) Then
            Decision("You are not authorized to : Add new record", "Not Authorized", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Return
        End If

        varFormProperties.IsNew = True
        varFormProperties.RowID = "-1"

        Frm_epls_Editor = New FRMeplsEditor
        Display(Frm_epls_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new employee data", True)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataEdit() Handles Com_mms_Menu.EventDataEdit
        If Not (varUserAccess.User(varDatabaseName, "EPLS", varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Edit)) Then
            Decision("You are not authorized to : Modify existing record", "Not Authorized", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Return
        End If

        Call GetRowID()
        varFormProperties.IsNew = False
        If Convert.ToString(varFormProperties.RowID) = "-1" Then
            Decision("No record selected", "Error", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        Else
            varFormProperties.IsNew = False
            Frm_epls_Editor = New FRMeplsEditor
            Display(Frm_epls_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your employee data", True)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles Com_mms_Menu.EventDataDelete
        If Not (varUserAccess.User(varDatabaseName, "EPLS", varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Delete)) Then
            Decision("You are not authorized to : Delete record", "Not Authorized", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Return
        End If

        Call GetRowID()
        If Convert.ToString(varFormProperties.RowID) = "-1" Then
            Decision("No record selected", "Error", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        Else
            If Decision("Do you want to delete this record?" & vbCrLf & vbCrLf & "=======================================================" & vbCrLf & DgnEPLS.CurrentRow.Cells("employee_fullname").Value.ToString & vbCrLf & "=======================================================", "Delete", CMCv.FRMdialogbox.MessageIcon.Question, CMCv.FRMdialogbox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (CMDepls.View.DeleteData(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))) Then
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
    Private Sub EPLS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Com_mms_Menu.LoadIn(Me)
        Com_mms_Menu.ShowMenuData(UI.View.MenuStrip.ShowItem.Yes)
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
    Private Sub F_EPLS_Editor_RecordSaved() Handles Frm_epls_Editor.EventRecordSaved
        Call GetData()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GetData(True)
        TxtFind.ClearSearch()
    End Sub

End Class
