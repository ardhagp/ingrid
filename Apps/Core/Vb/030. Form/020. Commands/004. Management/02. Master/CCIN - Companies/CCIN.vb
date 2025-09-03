Imports System.Runtime.Versioning
Imports CMCv

Public Class CCIN
#Region "Variables"
    Private _SQL As New LibSQL.Commands.CCIN.View
    Private WithEvents _CCIN_Editor As CCIN_Editor
    Private WithEvents _MMSMenu As New CMCv.UI.View.MenuStrip
#End Region

#Region "Function Collections"

#End Region

#Region "Sub Collections"

    ''' <summary>
    ''' Untuk mengambil data dari database
    ''' </summary>
    ''' <param name="ForceRefresh">True/False</param>
    ''' <remarks></remarks>
    <SupportedOSPlatform("windows")>
    Private Sub GETDATA(Optional ForceRefresh As Boolean = False)
        LibSQL.Commands.CCIN.View.DISPLAYDATA(V_DatabaseEngine, DgnCCIN, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    Private Sub GETTableID()
        If DgnCCIN.RowCount = 0 Then
            V_FORMAttrib.RowID = "-1"
        Else
            V_FORMAttrib.RowID = DgnCCIN.CurrentRow.Cells("company_id").Value.ToString
        End If
    End Sub
#End Region

#Region "Menu Strip Function"
    <SupportedOSPlatform("windows")>
    Private Sub EventDataAddNew() Handles _MMSMenu.EventDataAddNew
        V_FORMAttrib.IsNew = True
        V_FORMAttrib.RowID = "-1"
        _CCIN_Editor = New CCIN_Editor
        Display(_CCIN_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new company data", True)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataEdit() Handles _MMSMenu.EventDataEdit
        Call GETTableID()
        If V_FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            V_FORMAttrib.IsNew = False
            _CCIN_Editor = New CCIN_Editor
            Display(_CCIN_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your company data", True)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles _MMSMenu.EventDataDelete
        Call GETTableID()
        If V_FORMAttrib.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            V_FORMAttrib.IsNew = False
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (LibSQL.Commands.CCIN.View.DELETEDATA(V_DatabaseEngine, V_FORMAttrib.RowID)) Then
                    Call GETDATA(True)
                    Mainframe_n_6.Ts_status.Text = "Success"
                Else
                    Mainframe_n_6.Ts_status.Text = "Delete failed"
                End If
            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataRefresh() Handles _MMSMenu.EventDataRefresh
        TxtFind.Clear()
        Call GETDATA(True)
    End Sub

    Private Sub EventDataClose() Handles _MMSMenu.EventDataClose
        Me.Close()
    End Sub

    Private Sub EventToolsFind() Handles _MMSMenu.EventToolsFind
        TxtFind.Focus()
    End Sub
#End Region

#Region "Form Events"
    <SupportedOSPlatform("windows")>
    Private Sub frmCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _MMSMenu.LoadIn(Me)
        _MMSMenu.ShowMenuDATA(UI.View.MenuStrip.ShowItem.Yes)
        Call GETDATA(True)
    End Sub
#End Region

#Region "Component Events"
    <SupportedOSPlatform("windows")>
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA(True)
        TxtFind.ClearSearch()
    End Sub
#End Region

    <SupportedOSPlatform("windows")>
    Private Sub _CCIN_Editor_RecordSaved() Handles _CCIN_Editor.RecordSaved
        Call GETDATA(True)
    End Sub

End Class
