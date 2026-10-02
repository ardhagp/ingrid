Namespace UI
    Public Class FRMmods
        Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip
        Private WithEvents Frm_mods_Editor As New UI.Canvas.FRMmodsEditor

        Private Const pCommand As String = "@Command"
        Private Const pSystemModuleId As String = "@pSystemModuleId"

        Public Event EventDataChanged()

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GetData(Optional ByVal forcerefresh As Boolean = False)
            DblBuffer(DgnMODS)
            CMDmods.View.DisplayData(varDataProperties, DgnMODS, SLFStatus, TxtFind, forcerefresh)
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GetRowID()
            varDataProperties.AllParameters.Remove(pSystemModuleId)
            If DgnMODS.RowCount = 0 Then
                varDataProperties.SystemModuleIsNew = True
            Else
                varDataProperties.SystemModuleIsNew = False
                varDataProperties.AllParameters.Add(pSystemModuleId, CLng(DgnMODS.CurrentRow.Cells("module_id").Value))
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub CommmsMenu_EventDataAddNew() Handles Com_mms_Menu.EventDataAddNew
            With varDataProperties
                .SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Add
                .AllParameters.Remove(pCommand)
                .AllParameters.Add(pCommand, "MODS")
                If Not (varUserAccess.User(varDataProperties)) Then
                    Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Add new record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                    Return
                End If

                .SystemModuleIsNew = True
                Frm_mods_Editor = New UI.Canvas.FRMmodsEditor
                .IngridFormImage = ImageDb.Main.ImageLibrary.EDIT_ICON
                .IngridWindowName = My.Application.Info.AssemblyName.ToUpper
                .IngridFormTitle = "Add New Record"
                .IngridFormSubtitle = "Add new module"
                .IngridFormIsDialog = True
                Display(Frm_mods_Editor,, varDataProperties)
            End With
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataEdit() Handles Com_mms_Menu.EventDataEdit
            With varDataProperties
                .SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Edit
                .AllParameters.Remove(pCommand)
                .AllParameters.Add(pCommand, "MODS")
                If Not (varUserAccess.User(varDataProperties)) Then
                    Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Modify existing record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                    Return
                End If

                Call GetRowID()

                If .SystemModuleIsNew Then
                    Decision(My.Application.Info.AssemblyName.ToUpper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                Else
                    Frm_mods_Editor = New UI.Canvas.FRMmodsEditor
                    .IngridFormImage = ImageDb.Main.ImageLibrary.EDIT_ICON
                    .IngridWindowName = My.Application.Info.AssemblyName.ToUpper
                    .IngridFormTitle = "Update Record"
                    .IngridFormSubtitle = "Update your employee data"
                    .IngridFormIsDialog = True
                    Display(Frm_mods_Editor,, varDataProperties)
                End If
            End With
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataDelete() Handles Com_mms_Menu.EventDataDelete
            With varDataProperties
                .SystemTypeOfAccess = LibApp.Ingrid.Global.TypeOfAccess.Delete
                .AllParameters.Remove(pCommand)
                .AllParameters.Add(pCommand, "MODS")
                If Not (varUserAccess.User(varDataProperties)) Then
                    Decision(My.Application.Info.AssemblyName.ToUpper, "You are not authorized to : Delete record", LibApp.Ingrid.Global.PopupType.NotAuthorized, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                    Return
                End If

                Call GetRowID()

                If .SystemModuleIsNew Then
                    Decision(My.Application.Info.AssemblyName.ToUpper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                Else
                    If Decision(My.Application.Info.AssemblyName.ToUpper, "Do you want to delete this record?", LibApp.Ingrid.Global.PopupType.Delete, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Question, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                        If (CMDdar.View.DeleteData(varDataProperties, Convert.ToString(varDataProperties.SystemModuleId))) Then
                            Call GetData(True)
                            RaiseEvent EventDataChanged()
                            UI.Canvas.FRMmainframe6.Ts_status.Text = "Success"
                        Else
                            UI.Canvas.FRMmainframe6.Ts_status.Text = "Delete failed"
                        End If
                    End If
                End If
            End With
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataRefresh() Handles Com_mms_Menu.EventDataRefresh
            TxtFind.Clear()
            Call GetData(True)
            TxtFind.ClearSearch()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventDataClose() Handles Com_mms_Menu.EventDataClose
            Me.Close()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub EventToolsFind() Handles Com_mms_Menu.EventToolsFind
            TxtFind.Focus()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMmods_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Com_mms_Menu.LoadIn(Me)
            Com_mms_Menu.ShowMenuData(CMCv.UI.View.MenuStrip.ShowItem.Yes)
            TxtFind.ClearSearch()
            DgnMODS.XOGetNewColor()
            Call GetData(True)
            TxtFind.ClearSearch()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
            If e.KeyCode = Keys.Enter Then
                Call GetData()
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            TxtFind.Clear()
            Call GetData(True)
            TxtFind.ClearSearch()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub CommmsMenu_EventToolsFind() Handles Com_mms_Menu.EventToolsFind
            TxtFind.Focus()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMmodsEditor_RecordSaved() Handles Frm_mods_Editor.EventRecordSaved
            Call GetData()
            RaiseEvent EventDataChanged()
        End Sub
    End Class
End Namespace