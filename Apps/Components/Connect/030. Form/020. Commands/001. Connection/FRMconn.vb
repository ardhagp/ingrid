Imports System.Runtime.Versioning
Imports System.Text

Namespace UI.Canvas
    <SupportedOSPlatform("windows")>
    Public Class FRMconn
        Private WithEvents FRMconn_editor As FRMconnEditor
        Private WithEvents COMmainframemenu As New CMCv.UI.View.MenuStrip

        Public Event ConnectFrameOpen()
        Public Event ConnectFrameClose()

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
            CMDconn.View.DisplayData(DgnConnection, SLFStatus, TxtFind, forcerefresh)
        End Sub

        ''' <summary>
        ''' Get row ID on record clicked
        ''' </summary>
        <SupportedOSPlatform("windows")>
        Private Sub GetRowID()
            varProperties.ConnectionId = "-1"

            If DgnConnection.RowCount > 0 Then
                varProperties.ConnectionId = DgnConnection.CurrentRow.Cells("ID").Value.ToString
            End If
        End Sub
#End Region

        <SupportedOSPlatform("windows")>
        Private Sub FRMconn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            RaiseEvent ConnectFrameOpen() ''' Notify that the connection settings form is opened

            Bridge.Security.Writelog.Sendlog("""message"" : ""Connection Settings is opened."",", "Information") ''' Log the event

            varDatabaseEngineSqlite.Open(varIsProduction) ''' Open database connection

            Call LoadMenu() ''' Load mainframe menu

            DgnConnection.XOGETNewColor() ''' Apply custom color scheme

            Call GetData(True) ''' Load data into the grid
        End Sub

        Private Sub LoadMenu()
            COMmainframemenu.LoadIn(Me, True) ''' Load menu into the form
            COMmainframemenu.ShowMenuData(CMCv.UI.View.MenuStrip.ShowItem.Yes) ''' Show data-related menu items
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub FRMconn_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
            If Not (varIsExtension) Then
                varDatabaseEngineSqlite.Close()
            End If

            Bridge.Security.Writelog.Sendlog("""Connection Settings is closed."",", "Information")

            RaiseEvent ConnectFrameClose()
        End Sub

        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            Call ClearFind()
        End Sub

        ''' <summary>
        ''' Add new data
        ''' </summary>
        <SupportedOSPlatform("windows")>
        Private Sub EventDataAddNew() Handles COMmainframemenu.EventDataAddNew
            varProperties.ConnectionIsNew = True
            varProperties.ConnectionId = "-1"
            FRMconn_editor = New FRMconnEditor
            Display(FRMconn_editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName, "Add New Record", "Add new connection", True)
            SLFStatus.Text = String.Empty
        End Sub

        ''' <summary>
        ''' Edit existing data
        ''' </summary>
        <SupportedOSPlatform("windows")>
        Public Sub EventDataEdit() Handles COMmainframemenu.EventDataEdit
            Call GetRowID()
            varProperties.ConnectionIsNew = False

            If varProperties.ConnectionId Is "-1" Then
                Decision(My.Application.Info.AssemblyName, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
            Else
                FRMconn_editor = New FRMconnEditor
                Display(FRMconn_editor, IMAGEDB.Main.ImageLibrary.EDIT_ICON, My.Application.Info.AssemblyName, "Update Record", "Update connection", True)
            End If
            SLFStatus.Text = String.Empty
        End Sub

        ''' <summary>
        ''' Delete selected data
        ''' </summary>
        <SupportedOSPlatform("windows")>
        Private Sub EventDataDelete() Handles COMmainframemenu.EventDataDelete
            Call GetRowID()
            If varProperties.ConnectionId Is "-1" Then
                Decision(My.Application.Info.AssemblyName, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
            Else
                varProperties.ConnectionIsNew = False

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

                    If Decision(My.Application.Info.AssemblyName, Convert.ToString(varMessage), LibApp.Ingrid.Global.PopupType.Delete, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Question, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                        If (CMDconn.View.DeleteData(Convert.ToString(varProperties.ConnectionId))) Then
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
        Private Sub EventToolsFind() Handles COMmainframemenu.EventToolsFind
            TxtFind.Focus()
        End Sub

        ''' <summary>
        ''' Load data with filter applied
        ''' </summary>
        Private Sub EventDataRefresh() Handles COMmainframemenu.EventDataRefresh
            Call SavedOrRefresh()
        End Sub

        ''' <summary>
        ''' Close form
        ''' </summary>
        Private Sub EventDataClose() Handles COMmainframemenu.EventDataClose
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

        Private Sub SavedOrRefresh()
            TxtFind.Clear()
            Call GetData(True)
        End Sub

        Private Sub FRMconnEditorSaved() Handles FRMconn_editor.EventRecordSaved
            Call SavedOrRefresh()
        End Sub

        Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
            Me.Close()
        End Sub
    End Class
End Namespace