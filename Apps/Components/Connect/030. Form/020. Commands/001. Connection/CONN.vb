Imports System.Data.Common
Imports System.Runtime.Versioning
Imports System.Text

<SupportedOSPlatform("windows")>
Public Class FRMconn
    Public Event ConnectFrameOpen()
    Public Event ConnectFrameClose()

    Private WithEvents Com_mainframe_menu As New UI.View.MenuStrip
    Private WithEvents Frm_conn_Editor As New FRMconnEditor

    Private varSQL As New Commands.CONN.View
    Private varIsProduction As Boolean = True
    Private varIsExtension As Boolean = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        varIsProduction = True
    End Sub

    Public Sub New(Optional isproduction As Boolean = False, Optional isextension As Boolean = True)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        varIsProduction = isproduction
        varIsExtension = isextension
    End Sub

#Region "Sub Collections"
    ''' <summary>
    ''' Get data from database
    ''' </summary>
    ''' <param name="forcerefresh"></param>
    <SupportedOSPlatform("windows")>
    Private Sub GetData(Optional forcerefresh As Boolean = False)
        DblBuffer(DgnConnection) ''' Enable double buffering to reduce flickering
        Commands.CONN.View.DisplayData(DgnConnection, SLFStatus, TxtFind, forcerefresh)
    End Sub

    ''' <summary>
    ''' Get row ID on record clicked
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub GetRowID()
        varProperties.RowID = "-1"

        If DgnConnection.RowCount > 0 Then
            varProperties.RowID = DgnConnection.CurrentRow.Cells("ID").Value
        End If
    End Sub
#End Region

    <SupportedOSPlatform("windows")>
    Private Sub FRMconn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RaiseEvent ConnectFrameOpen() ''' Notify that the connection settings form is opened

        Bridge.Security.Writelog.Sendlog("""message"" : ""Connection Settings is opened."",", "Information") ''' Log the event

        varDatabaseEngineSqlite.Open(varIsProduction) ''' Open database connection

        Call LoadMenu() ''' Load mainframe menu

        DgnConnection.XOGeTNewColor() ''' Apply custom color scheme

        Call GetData(True) ''' Load data into the grid
    End Sub

    Private Sub LoadMenu()
        Com_mainframe_menu.LoadIn(Me, True) ''' Load menu into the form
        Com_mainframe_menu.ShowMenuData(UI.View.MenuStrip.ShowItem.Yes) ''' Show data-related menu items
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub FRMconn_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        If Not (varIsExtension) Then
            '_DBE_LocalDB.Close()
            varDatabaseEngineSqlite.Close()
        End If

        Bridge.Security.Writelog.Sendlog("""Connection Settings is closed."",", "Information")

        RaiseEvent ConnectFrameClose()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs)
        ClearFind()
    End Sub

    ''' <summary>
    ''' Add new data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub EventDataAddNew() Handles Com_mainframe_menu.EventDataAddNew
        varProperties.IsNew = True
        varProperties.RowID = "-1"
        Frm_conn_Editor = New FRMconnEditor
        Display(Frm_conn_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new connection", True)
        SLFStatus.Text = String.Empty
    End Sub

    ''' <summary>
    ''' Edit existing data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Public Sub EventDataEdit() Handles Com_mainframe_menu.EventDataEdit
        Call GetRowID()
        varProperties.IsNew = False

        If varProperties.RowID Is "-1" Then
            Decision("No record selected", "Error", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        Else
            Frm_conn_Editor = New FRMconnEditor
            Display(Frm_conn_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update connection", True)
        End If

        SLFStatus.Text = String.Empty
    End Sub

    ''' <summary>
    ''' Delete selected data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles Com_mainframe_menu.EventDataDelete
        Call GetRowID()
        If varProperties.RowID Is "-1" Then
            Decision("No record selected", "Error", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
        Else
            varProperties.IsNew = False

            With DgnConnection.CurrentRow
                Dim varMessage As New StringBuilder()
                varMessage.AppendLine("Do you want to delete this record?")

                Dim varLine As String = New String("─"c, 80)
                varMessage.AppendLine(varLine)

                varMessage.AppendLine("Connection ID : " & .Cells("id").Value.ToString & Environment.NewLine &
                        "Connection Name : " & .Cells("connectionname").Value.ToString & Environment.NewLine &
                        "DB Engine : " & .Cells("databaseengine").Value.ToString & Environment.NewLine &
                        "Server Address : " & .Cells("serveraddress").Value.ToString & Environment.NewLine &
                        "Server Port : " & .Cells("serverport").Value.ToString)

                varMessage.AppendLine(varLine)

                If Decision(Convert.ToString(varMessage), "Delete", CMCv.FRMdialogbox.MessageIcon.Question, CMCv.FRMdialogbox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                    If (Commands.CONN.View.DeleteData(Convert.ToString(varProperties.RowID))) Then
                        Call GetData(True)
                        SLFStatus.Text = "Success"
                    Else
                        SLFStatus.Text = "Delete failed"
                    End If
                End If
            End With
        End If
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Call GetData(False) ''' Load data with filter applied
    End Sub

    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GetData(False) ''' Load data with filter applied
        End If
    End Sub

    ''' <summary>
    ''' Search mode
    ''' </summary>
    Private Sub EventToolsFind() Handles Com_mainframe_menu.EventToolsFind
        TxtFind.Focus()
    End Sub

    ''' <summary>
    ''' Load data with filter applied
    ''' </summary>
    Private Sub EventDataRefresh() Handles Com_mainframe_menu.EventDataRefresh
        TxtFind.Clear()
        Call GetData(True)
    End Sub

    ''' <summary>
    ''' Close form
    ''' </summary>
    Private Sub EventDataClose() Handles Com_mainframe_menu.EventDataClose
        Me.Close()
    End Sub

    ''' <summary>
    ''' Clear search filter
    ''' </summary>
    Private Sub ClearFind()
        TxtFind.Clear()
        TxtFind.ClearSearch()
        Call GetData(True)
    End Sub

    Private Sub FRMconnEditor_RecordSaved() Handles Frm_conn_Editor.RecordSaved
        TxtFind.Clear()
        Call GetData(True)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs)
        Close()
    End Sub
End Class
