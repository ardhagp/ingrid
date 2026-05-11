Imports System.Runtime.Versioning

Namespace UI
    Public Class FRMplnt
        'Private V_SQL As New CMDplnt.View
        Private WithEvents Frm_plnt_Editor As New FRMplntEditor
        Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip

        Private Const pCommand As String = "@Command"
        Private Const pPlantId As String = "@PlantId"

#Region "Sub Collections"
        <SupportedOSPlatform("windows")>
        Private Sub GetData(Optional forcerefresh As Boolean = False)
            DblBuffer(DgnPLNT)
            varDataProperties.PlantIsForceRefresh = forcerefresh
            CMDplnt.View.DisplayData(varDataProperties, DgnPLNT, SLFStatus, TxtFind)
        End Sub

        ''' <summary>
        ''' Get row ID on record clicked
        ''' </summary>
        Private Sub GetRowID()
            If DgnPLNT.RowCount = 0 Then
                varDataProperties.PlantIsNew = True
            Else
                varDataProperties.PlantIsNew = False
                varDataProperties.AllParameters.Remove(pPlantId)
                varDataProperties.AllParameters.Add(pPlantId, CLng(DgnPLNT.CurrentRow.Cells("plant_id").Value))
            End If
        End Sub

#End Region

#Region "Menu Strip Functions"
        ''' <summary>
        ''' Add new data
        ''' </summary>
        <SupportedOSPlatform("windows")>
        Private Sub CommmsMenu_EventDataAddNew() Handles Com_mms_Menu.EventDataAddNew
            varDataProperties.SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Add
            varDataProperties.AllParameters.Remove(pCommand)
            varDataProperties.AllParameters.Add(pCommand, "PLNT")
            If Not varUserAccess.User(varDataProperties) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Add new record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            varDataProperties.PlantIsNew = True
            Frm_plnt_Editor = New FRMplntEditor
            Display(Frm_plnt_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Add New Record", "Add new plant", True)
            UI.FRMmainframe6.Ts_status.Text = String.Empty
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub CommmsMenu_EventDataEdit() Handles Com_mms_Menu.EventDataEdit
            varDataProperties.SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Edit
            varDataProperties.AllParameters.Remove(pCommand)
            varDataProperties.AllParameters.Add(pCommand, "PLNT")
            If Not varUserAccess.User(varDataProperties) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Modify existing record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            Call GetRowID()

            If varDataProperties.PlantIsNew Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Else
                Frm_plnt_Editor = New FRMplntEditor
                Display(Frm_plnt_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Update Record", "Update plant data", True)
            End If
            UI.FRMmainframe6.Ts_status.Text = String.Empty
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub CommmsMenu_EventDataDelete() Handles Com_mms_Menu.EventDataDelete
            varDataProperties.SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Delete
            varDataProperties.AllParameters.Remove(pCommand)
            varDataProperties.AllParameters.Add(pCommand, "PLNT")
            If Not (varUserAccess.User(varDataProperties)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Delete record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            Call GetRowID()

            If varDataProperties.PlantIsNew Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Else
                If Decision(My.Application.Info.AssemblyName.ToUpper, "Do you want to delete this record?", LibApp.Ingrid.Global.PopupType.Delete, "", CMCv.FRMdialogbox.MessageIcon.Question, CMCv.FRMdialogbox.MessageTypes.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                    If CMDplnt.View.DeleteData(varDataProperties) Then
                        Call GetData(True)
                        UI.FRMmainframe6.Ts_status.Text = "Success"
                    Else
                        UI.FRMmainframe6.Ts_status.Text = "Delete failed"
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
            Com_mms_Menu.ShowMenuData(CMCv.UI.View.MenuStrip.ShowItem.Yes)
            DgnPLNT.XOGETNewColor()
            Call GetData(True)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            'Call SavedOrRefresh()'
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub FRMplntEditor_RecordSaved() Handles Frm_plnt_Editor.EventRecordSaved
            'Call SavedOrRefresh()'
        End Sub

#End Region
    End Class
End Namespace