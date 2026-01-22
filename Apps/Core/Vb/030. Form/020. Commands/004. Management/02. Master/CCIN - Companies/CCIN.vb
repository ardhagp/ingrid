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
    Private Sub GetData(Optional forcerefresh As Boolean = False)
        LibSQL.Commands.CCIN.View.DisplayData(varDatabaseName, varDatabaseEngine, DgnCCIN, SLFStatus, TxtFind, forcerefresh)
    End Sub

    Private Sub GetRowID()
        If DgnCCIN.RowCount = 0 Then
            varFormProperties.RowID = "-1"
        Else
            varFormProperties.RowID = DgnCCIN.CurrentRow.Cells("company_id").Value.ToString
        End If
    End Sub
#End Region

#Region "Menu Strip Function"
    <SupportedOSPlatform("windows")>
    Private Sub EventDataAddNew() Handles _MMSmenu.EventDataAddNew
        With varFormProperties
            .IsNew = True
            .RowID = "-1"
        End With

        V_CCIN_Editor = New CCIN_Editor
        Display(V_CCIN_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new company data", True)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataEdit() Handles _MMSmenu.EventDataEdit
        Call GetRowID()
        If Convert.ToString(varFormProperties.RowID) = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            varFormProperties.IsNew = False
            V_CCIN_Editor = New CCIN_Editor
            Display(V_CCIN_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update your company data", True)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles _MMSmenu.EventDataDelete
        Call GetRowID()
        If Convert.ToString(varFormProperties.RowID) = "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            varFormProperties.IsNew = False
            If Decision("Do you want to delete this record?", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (LibSQL.Commands.CCIN.View.DeleteData(varDatabaseName, varDatabaseEngine, Convert.ToString(varFormProperties.RowID))) Then
                    Call GetData(True)
                    FRMmainframe6.Ts_status.Text = "Success"
                Else
                    FRMmainframe6.Ts_status.Text = "Delete failed"
                End If
            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EventDataRefresh() Handles _MMSMenu.EventDataRefresh
        TxtFind.Clear()
        Call GetData(True)
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
        _MMSmenu.ShowMenuData(UI.View.MenuStrip.ShowItem.Yes)
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
    Private Sub _CCIN_Editor_RecordSaved() Handles V_CCIN_Editor.RecordSaved
        Call GetData(True)
    End Sub

End Class
