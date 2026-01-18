Imports System.Runtime.Versioning
Imports CMCv

<SupportedOSPlatform("windows")>
Public Class CONN
    Public Event ConnectFrameOpen()
    Public Event ConnectFrameClose()

    Private WithEvents comMainframeMenu As New UI.View.MenuStrip
    Private WithEvents frmCONN_Editor As New CONN_Editor

    Private varSQL As New Commands.CONN.View
    Private varIsProduction As Boolean = True
    Private varIsExtension As Boolean = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        varIsProduction = True
    End Sub

    Public Sub New(Optional ByVal isproduction As Boolean = False, Optional ByVal isextension As Boolean = True)

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
    Private Sub GETDATA(Optional forcerefresh As Boolean = False)
        DblBuffer(DgnConnection) ''' Enable double buffering to reduce flickering
        Commands.CONN.View.DisplayData(DgnConnection, SLFStatus, TxtFind, forcerefresh)
    End Sub

    ''' <summary>
    ''' Get row ID on record clicked
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub GETTableID()
        varFormAttributes.RowID = "-1"

        If DgnConnection.RowCount > 0 Then
            varFormAttributes.RowID = DgnConnection.CurrentRow.Cells("ID").Value
        End If
    End Sub
#End Region

    <SupportedOSPlatform("windows")>
    Private Sub CONN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RaiseEvent ConnectFrameOpen() ''' Notify that the connection settings form is opened

        Bridge.Security.Writelog.Sendlog("""message"" : ""Connection Settings is opened."",", "Information") ''' Log the event

        V_DBE_SQLite.Open(varIsProduction) ''' Open database connection

        Call LoadMenu() ''' Load mainframe menu

        DgnConnection.XOGETNewColor() ''' Apply custom color scheme

        Call GETDATA(True) ''' Load data into the grid
    End Sub

    Private Sub LoadMenu()
        comMainframeMenu.LoadIn(Me, True) ''' Load menu into the form
        comMainframeMenu.ShowMenuDATA(UI.View.MenuStrip.ShowItem.Yes) ''' Show data-related menu items
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub CONN_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        If Not (varIsExtension) Then
            '_DBE_LocalDB.Close()
            V_DBE_SQLite.Close()
        End If

        Bridge.Security.Writelog.Sendlog("""Connection Settings is closed."",", "Information")

        RaiseEvent ConnectFrameClose()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Call GETDATA(False)
    End Sub

    ''' <summary>
    ''' Add new data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub EventDataAddNew() Handles comMainframeMenu.EventDataAddNew
        varFormAttributes.IsNew = True
        varFormAttributes.RowID = "-1"
        frmCONN_Editor = New CONN_Editor
        Display(frmCONN_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Add New Record", "Add new connection", True)
        SLFStatus.Text = String.Empty
    End Sub

    ''' <summary>
    ''' Edit existing data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Public Sub EventDataEdit() Handles comMainframeMenu.EventDataEdit
        Call GETTableID()
        varFormAttributes.IsNew = False

        If varFormAttributes.RowID Is "-1" Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            frmCONN_Editor = New CONN_Editor
            Display(frmCONN_Editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, "Update Record", "Update connection", True)
        End If

        SLFStatus.Text = String.Empty
    End Sub

    ''' <summary>
    ''' Delete selected data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub EventDataDelete() Handles comMainframeMenu.EventDataDelete
        Call GETTableID()
        If varFormAttributes.RowID Is "-1" Then
            Decision("no record selected", "error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            varFormAttributes.IsNew = False
            If Decision("Do you want to delete this record?" & vbCrLf & vbCrLf & "=======================================================" & vbCrLf & DgnConnection.CurrentRow.Cells("connectionname").Value.ToString & vbCrLf & "=======================================================", "Delete", CMCv.frmDialogBox.MessageIcon.Question, CMCv.frmDialogBox.MessageTypes.YesNo) = Windows.Forms.DialogResult.Yes Then
                If (Commands.CONN.View.DELETEData(varFormAttributes.RowID.ToString)) Then
                    Call GETDATA(True)
                    SLFStatus.Text = "Success"
                Else
                    SLFStatus.Text = "Delete failed"
                End If
            End If
        End If
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Call GETDATA(False) ''' Load data with filter applied
    End Sub

    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA(False) ''' Load data with filter applied
        End If
    End Sub

    Private Sub BtnClear_Click_1(sender As Object, e As EventArgs) Handles BtnClear.Click
        Call ClearFind()
    End Sub

    ''' <summary>
    ''' Search mode
    ''' </summary>
    Private Sub EventToolsFind() Handles comMainframeMenu.EventToolsFind
        TxtFind.Focus()
    End Sub

    ''' <summary>
    ''' Load data with filter applied
    ''' </summary>
    Private Sub EventDataRefresh() Handles comMainframeMenu.EventDataRefresh
        TxtFind.Clear()
        Call GETDATA(True)
    End Sub

    ''' <summary>
    ''' Close form
    ''' </summary>
    Private Sub EventDataClose() Handles comMainframeMenu.EventDataClose
        Me.Close()
    End Sub

    ''' <summary>
    ''' Clear search filter
    ''' </summary>
    Private Sub ClearFind()
        TxtFind.Clear()
        TxtFind.ClearSearch()
        Call GETDATA(True)
    End Sub

    Private Sub frmCONN_Editor_RecordSaved() Handles frmCONN_Editor.RecordSaved
        TxtFind.Clear()
        Call GETDATA(True)
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub
End Class
