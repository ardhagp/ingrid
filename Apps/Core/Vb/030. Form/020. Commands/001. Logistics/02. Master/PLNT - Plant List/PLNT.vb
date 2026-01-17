Imports System.Runtime.Versioning

Public Class PLNT
    Private V_SQL As New LibSQL.Commands.PLNT.View
    Private WithEvents V_PLNT_Editor As New PLNT_Editor
    Private WithEvents V_MMSMenu As New CMCv.UI.View.MenuStrip

#Region "Sub Collections"
    <SupportedOSPlatform("windows")>
    Private Sub GETDATA(Optional ByVal ForceRefresh As Boolean = False)
        DblBuffer(DgnPLNT)
        LibSQL.Commands.PLNT.View.DisplayData(varDatabaseEngine, DgnPLNT, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub ClearFind()
        Call GETDATA(True)
    End Sub

    ''' <summary>
    ''' Get row ID on record clicked
    ''' </summary>
    Private Sub GETTableID()
        varFormAttributes.RowID = "-1"

        If DgnPLNT.RowCount > 0 Then
            varFormAttributes.RowID = DgnPLNT.CurrentRow.Cells("plant_id").Value.ToString
        End If
    End Sub

#End Region

#Region "Menu Strip Functions"
    ''' <summary>
    ''' Add new data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventDataAddNew() Handles V_MMSMenu.EventDataAddNew
        If varUserAccess.User("PLNT", varUserAttributes.UID, LibSQL.Application.Access.TypeOfAccess.Add) = False Then
            Decision("You are not authorized to : Add new record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        End If
        varFormAttributes.IsNew = True
        varFormAttributes.RowID = "-1"
        V_PLNT_Editor = New PLNT_Editor
        DISPLAY(V_PLNT_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new plant", True)
        Mainframe_n_6.Ts_status.Text = String.Empty
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventDataEdit() Handles V_MMSMenu.EventDataEdit
        If varUserAccess.User("PLNT", varUserAttributes.UID, LibSQL.Application.Access.TypeOfAccess.Edit) = False Then
            Decision("You are not authorized to : Modify existing record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        End If
        Call GETTableID()
        varFormAttributes.IsNew = False
        If varFormAttributes.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            V_PLNT_Editor = New PLNT_Editor
            DISPLAY(V_PLNT_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update plant data", True)
        End If
        Mainframe_n_6.Ts_status.Text = String.Empty
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventDataDelete() Handles V_MMSMenu.EventDataDelete
        If varUserAccess.User("PLNT", varUserAttributes.UID, LibSQL.Application.Access.TypeOfAccess.Delete) = False Then
            Decision("You are not authorized to : Delete record", "Not Authorized", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
            Exit Sub
        End If
        Call GETTableID()
        If varFormAttributes.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            varFormAttributes.IsNew = False
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If LibSQL.Commands.PLNT.View.DELETEDATA(varDatabaseEngine, varFormAttributes.RowID) = True Then
                    Call GETDATA(True)
                    Mainframe_n_6.Ts_status.Text = "Success"
                Else
                    Mainframe_n_6.Ts_status.Text = "Delete failed"
                End If
            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub _MMSMenu_EventDataRefresh() Handles V_MMSMenu.EventDataRefresh
        TxtFind.Clear()
        Call GETDATA(True)
    End Sub

    Private Sub _MMSMenu_EventDataClose() Handles V_MMSMenu.EventDataClose
        Me.Close()
    End Sub
#End Region

#Region "Upper Form Bar"
    'TODO: Add upper form bar
#End Region

#Region "Main Form Events"
    <SupportedOSPlatform("windows")>
    Private Sub PLNT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        V_MMSMenu.LoadIn(Me)
        DgnPLNT.XOGETNewColor()
        Call ClearFind()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Call ClearFind()
        TxtFind.ClearSearch()
    End Sub
#End Region
End Class