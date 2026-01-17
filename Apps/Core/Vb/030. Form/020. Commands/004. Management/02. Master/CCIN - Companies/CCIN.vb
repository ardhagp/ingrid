Imports System.Runtime.Versioning
Imports CMCv

Public Class CCIN
#Region "Variables"
    Private varSQLview As New LibSQL.Commands.CCIN.View
    Private WithEvents V_CCIN_Editor As CCIN_Editor
    Private WithEvents _MMSmenu As New CMCv.UI.View.MenuStrip
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
    Private Sub GETDATA(Optional ForceRefresh As Boolean = False)
        LibSQL.Commands.CCIN.View.DISPLAYDATA(varDatabaseEngine, DgnCCIN, SLFStatus, TxtFind, ForceRefresh)
    End Sub

    Private Sub GETTableID()
        If DgnCCIN.RowCount = 0 Then
            varFormAttributes.RowID = "-1"
        Else
            varFormAttributes.RowID = DgnCCIN.CurrentRow.Cells("company_id").Value.ToString
        End If
    End Sub
#End Region

#Region "Menu Strip Function"
    <SupportedOSPlatform("windows")>
    Private Sub EventDataAddNew() Handles _MMSmenu.EventDataAddNew
        With varFormAttributes
            .IsNew = True
            .RowID = "-1"
        End With

        V_CCIN_Editor = New CCIN_Editor
        DISPLAY(V_CCIN_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new company data", True)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataEdit() Handles _MMSmenu.EventDataEdit
        Call GETTableID()
        If varFormAttributes.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            varFormAttributes.IsNew = False
            V_CCIN_Editor = New CCIN_Editor
            DISPLAY(V_CCIN_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your company data", True)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles _MMSmenu.EventDataDelete
        Call GETTableID()
        If varFormAttributes.RowID = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            varFormAttributes.IsNew = False
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (LibSQL.Commands.CCIN.View.DELETEDATA(varDatabaseEngine, varFormAttributes.RowID)) Then
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
    Private Sub _CCIN_Editor_RecordSaved() Handles V_CCIN_Editor.RecordSaved
        Call GETDATA(True)
    End Sub

End Class
