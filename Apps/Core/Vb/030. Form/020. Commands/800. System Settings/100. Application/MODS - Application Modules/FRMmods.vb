Imports System.Runtime.Versioning

Namespace UI
    Public Class FRMmods
#Region "Declaration"
        Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip
        Private WithEvents Frm_mods_Editor As New FRMmodsEditor

        Private Const pCommand As String = "@Command"
        Private Const pSystemModuleId As String = "@pSystemModuleId"

        Public Event EventDataChanged()
#End Region

#Region "Subs Collection"

        <SupportedOSPlatform("windows")>
        Private Sub GetData(Optional ByVal forcerefresh As Boolean = False)
            DblBuffer(DgnMODS)
            CMDmods.View.DisplayData(varDataProperties, DgnMODS, SLFStatus, TxtFind, forcerefresh)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub GetRowID()
            varDataProperties.AllParameters.Remove(pSystemModuleId)
            If DgnMODS.RowCount = 0 Then
                varDataProperties.SystemModuleIsNew = True
            Else
                varDataProperties.SystemModuleIsNew = False
                varDataProperties.AllParameters.Add(pSystemModuleId, CLng(DgnMODS.CurrentRow.Cells("module_id").Value))
            End If
        End Sub
#End Region

#Region "Menu Strip Functions"

        <SupportedOSPlatform("windows")>
        Private Sub CommmsMenu_EventDataAddNew() Handles Com_mms_Menu.EventDataAddNew
            varDataProperties.SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Add
            varDataProperties.AllParameters.Remove(pCommand)
            varDataProperties.AllParameters.Add(pCommand, "MODS")
            If Not (varUserAccess.User(varDataProperties)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Add new record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.ui.canvas.FRMdialogbox.MessageIcon.Error, CMCv.ui.canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            varDataProperties.SystemModuleIsNew = True
            Frm_mods_Editor = New FRMmodsEditor
            Display(Frm_mods_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Add New Record", "Add new module", True)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub EventDataEdit() Handles Com_mms_Menu.EventDataEdit
            varDataProperties.SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Edit
            varDataProperties.AllParameters.Remove(pCommand)
            varDataProperties.AllParameters.Add(pCommand, "MODS")
            If Not (varUserAccess.User(varDataProperties)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Modify existing record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.ui.canvas.FRMdialogbox.MessageIcon.Error, CMCv.ui.canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            Call GetRowID()

            If varDataProperties.SystemModuleIsNew Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.ui.canvas.FRMdialogbox.MessageIcon.Error, CMCv.ui.canvas.FRMdialogbox.MessageTypes.OkOnly)
            Else
                Frm_mods_Editor = New FRMmodsEditor
                Display(Frm_mods_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Update Record", "Update your employee data", True)
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub EventDataDelete() Handles Com_mms_Menu.EventDataDelete
            varDataProperties.SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Delete
            varDataProperties.AllParameters.Remove(pCommand)
            varDataProperties.AllParameters.Add(pCommand, "MODS")
            If Not (varUserAccess.User(varDataProperties)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Delete record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.ui.canvas.FRMdialogbox.MessageIcon.Error, CMCv.ui.canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            Call GetRowID()

            If varDataProperties.SystemModuleIsNew Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.ui.canvas.FRMdialogbox.MessageIcon.Error, CMCv.ui.canvas.FRMdialogbox.MessageTypes.OkOnly)
            Else
                If Decision(My.Application.Info.AssemblyName.ToUpper, "Do you want to delete this record?", LibApp.Ingrid.Global.PopupType.Delete, "", CMCv.ui.canvas.FRMdialogbox.MessageIcon.Question, CMCv.ui.canvas.FRMdialogbox.MessageTypes.YesNo) = system.Windows.Forms.DialogResult.Yes Then
                    If (CMDdar.View.DeleteData(varDataProperties, Convert.ToString(varDataProperties.SystemModuleId))) Then
                        Call GetData(True)
                        RaiseEvent EventDataChanged()
                        UI.FRMmainframe6.Ts_status.Text = "Success"
                    Else
                        UI.FRMmainframe6.Ts_status.Text = "Delete failed"
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

        <SupportedOSPlatform("windows")>
        Private Sub EventDataClose() Handles Com_mms_Menu.EventDataClose
            Me.Close()
        End Sub

        <SupportedOSPlatform("windows")>
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
            DgnMODS.XOGETNewColor()
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

        <SupportedOSPlatform("windows")>
        Private Sub CommmsMenu_EventToolsFind() Handles Com_mms_Menu.EventToolsFind
            TxtFind.Focus()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub FRMmodsEditor_RecordSaved() Handles Frm_mods_Editor.EventRecordSaved
            Call GetData()
            RaiseEvent EventDataChanged()
        End Sub

#End Region
    End Class
End Namespace