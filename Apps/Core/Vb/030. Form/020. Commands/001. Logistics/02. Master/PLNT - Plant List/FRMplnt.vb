Imports System.Runtime.Versioning

Public Class FRMplnt
    'Private V_SQL As New CMDplnt.View
    Private WithEvents Frm_plnt_Editor As New FRMplntEditor
    Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip

#Region "Sub Collections"
    <SupportedOSPlatform("windows")>
    Private Sub GetData(Optional forcerefresh As Boolean = False)
        DblBuffer(DgnPLNT)
        CMDplnt.View.DisplayData(varDatabaseName, varDatabaseEngine, DgnPLNT, SLFStatus, TxtFind, forcerefresh)
    End Sub

    ''' <summary>
    ''' Get row ID on record clicked
    ''' </summary>
    Private Sub GetRowID()
        varFormProperties.RowID = "-1"

        If DgnPLNT.RowCount > 0 Then
            varFormProperties.RowID = DgnPLNT.CurrentRow.Cells("plant_id").Value.ToString
        End If
    End Sub

#End Region

#Region "Menu Strip Functions"
    ''' <summary>
    ''' Add new data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub CommmsMenu_EventDataAddNew() Handles Com_mms_Menu.EventDataAddNew
        If Not varUserAccess.User(varDatabaseName, "PLNT", varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Add) Then
            Decision("You are not authorized to : Add new record", "Not Authorized", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Return
        End If

        varFormProperties.IsNew = True
        varFormProperties.RowID = "-1"
        Frm_plnt_Editor = New FRMplntEditor
        Display(Frm_plnt_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new plant", True)
        FRMmainframe6.Ts_status.Text = String.Empty
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub CommmsMenu_EventDataEdit() Handles Com_mms_Menu.EventDataEdit
        If Not varUserAccess.User(varDatabaseName, "PLNT", varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Edit) Then
            Decision("You are not authorized to : Modify existing record", "Not Authorized", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Return
        End If

        Call GetRowID()

        varFormProperties.IsNew = False

        If Convert.ToString(varFormProperties.RowID) = "-1" Then
            Decision("No record selected", "Error", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        Else
            Frm_plnt_Editor = New FRMplntEditor
            Display(Frm_plnt_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update plant data", True)
        End If

        FRMmainframe6.Ts_status.Text = String.Empty
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub CommmsMenu_EventDataDelete() Handles Com_mms_Menu.EventDataDelete
        If Not varUserAccess.User(varDatabaseName, "PLNT", varProperties.UserID, LibSQL.Application.Access.TypeOfAccess.Delete) Then
            Decision("You are not authorized to : Delete record", "Not Authorized", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Return
        End If

        Call GetRowID()

        If Convert.ToString(varFormProperties.RowID) = "-1" Then
            Decision("No record selected", "Error", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        Else
            varFormProperties.IsNew = False
            If Decision("Do you want to delete this record?", "Delete", CMCv.FRMdialogbox.MessageIcon.Question, CMCv.FRMdialogbox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If CMDplnt.View.DeleteData(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID)) Then
                    Call GetData(True)
                    FRMmainframe6.Ts_status.Text = "Success"
                Else
                    FRMmainframe6.Ts_status.Text = "Delete failed"
                End If
            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub CommmsMenu_EventDataRefresh() Handles Com_mms_Menu.EventDataRefresh
        TxtFind.Clear()
        Call GetData(True)
    End Sub

    Private Sub CommmsMenu_EventDataClose() Handles Com_mms_Menu.EventDataClose
        Me.Close()
    End Sub
#End Region

#Region "Upper Form Bar"

#End Region

#Region "Main Form Events"
    <SupportedOSPlatform("windows")>
    Private Sub FRMplnt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Com_mms_Menu.LoadIn(Me)
        DgnPLNT.XOGETNewColor()
        Call SavedOrRefresh()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Call SavedOrRefresh()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub FRMplntEditor_RecordSaved() Handles Frm_plnt_Editor.EventRecordSaved
        Call SavedOrRefresh()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub SavedOrRefresh()
        Call GetData(True)
    End Sub
#End Region
End Class