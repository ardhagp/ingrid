Imports System.Runtime.Versioning

Namespace UI
    Public Class FRMccin
#Region "Declaration"
        Private WithEvents Frm_ccin_Editor As New FRMccinEditor
        Private WithEvents Com_mms_Menu As New CMCv.UI.View.MenuStrip
#End Region

#Region "Function Collections"
        'TODO: Functions
#End Region

#Region "Sub Collections"

        ''' <summary>
        ''' Untuk mengambil data dari database
        ''' </summary>
        ''' <param name="ForceRefresh">True/False</param>
        ''' <remarks></remarks>
        <SupportedOSPlatform("windows")>
        Private Sub GetData(Optional forcerefresh As Boolean = False)
            varDataProperties.CompanyIsForceRefresh = forcerefresh
            CMDccin.View.DisplayData(varDataProperties, DgnCCIN, SLFStatus, TxtFind)
        End Sub

        Private Sub GetRowID()
            If DgnCCIN.RowCount = 0 Then
                varDataProperties.CompanyID = "-1"
            Else
                varDataProperties.CompanyID = DgnCCIN.CurrentRow.Cells("company_id").Value.ToString
            End If
        End Sub
#End Region

#Region "Menu Strip Function"
        <SupportedOSPlatform("windows")>
        Private Sub EventDataAddNew() Handles Com_mms_Menu.EventDataAddNew
            With varDataProperties
                .CompanyIsNew = True
                .CompanyID = "-1"
            End With
            Frm_ccin_Editor = New FRMccinEditor
            Display(Frm_ccin_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Add New Record", "Add new company data", True)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub EventDataEdit() Handles Com_mms_Menu.EventDataEdit
            Call GetRowID()
            If varDataProperties.CompanyId = "-1" Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Else
                Frm_ccin_Editor = New FRMccinEditor
                Display(Frm_ccin_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName.ToUpper, "Update Record", "Update your company data", True)
            End If
            UI.FRMmainframe6.Ts_status.Text = String.Empty
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub EventDataDelete() Handles Com_mms_Menu.EventDataDelete
            Call GetRowID()
            If varDataProperties.CompanyId = "-1" Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Else
                If Decision(My.Application.Info.AssemblyName.ToUpper, "Do you want to delete this record?", LibApp.Ingrid.Global.PopupType.Delete, "", CMCv.FRMdialogbox.MessageIcon.Question, CMCv.FRMdialogbox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes AndAlso LibSQL.CMDccin.View.DeleteData(varDataProperties, varDatasetIngrid) Then
                    Call GetData(True)
                    UI.FRMmainframe6.Ts_status.Text = "Success"
                Else
                    UI.FRMmainframe6.Ts_status.Text = "Delete failed"
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

#Region "Form Events"
        <SupportedOSPlatform("windows")>
        Private Sub frmCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Com_mms_Menu.LoadIn(Me)
            Com_mms_Menu.ShowMenuData(CMCv.UI.View.MenuStrip.ShowItem.Yes)
            Call GetData(True)
        End Sub
#End Region

#Region "Component Events"
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
#End Region

        <SupportedOSPlatform("windows")>
        Private Sub FRMccinEditor_RecordSaved() Handles Frm_ccin_Editor.EventRecordSaved
            Call GetData(True)
        End Sub
    End Class
End Namespace