Imports System.Net.Http
Imports System.Runtime.Versioning
Imports CMCv

Public Class CONN_Editor

#Region "Declarations"
    Public Event RecordSaved()
    Private WithEvents ComponentMainframeMenu As New CMCv.UI.View.MenuStrip
    Private varSQL As New Commands.CONN.Editor
    Private varPasswordChange As Boolean
    Private varOldPassword As String
#End Region

#Region "Functions and Subs"

    <SupportedOSPlatform("windows")>
    Private Sub LoadData()
        Commands.CONN.Editor.GETRowValue(varFormAttributes.RowID.ToString, TxtConnectionName, CboDBEngine, TxtAddress, TxtPort, TxtUsername, TxtPassword, TxtDatabaseName, varOldPassword, ChkDefault)
    End Sub

    Private Sub CheckAllInput()
        TxtConnectionName.Focus()
        TxtAddress.Focus()
        TxtPort.Focus()
        TxtUsername.Focus()
        TxtPassword.Focus()
    End Sub

    Private Sub CheckPasswordChange()
        If TxtPassword.XOSQLText = varOldPassword Then
            varPasswordChange = False
        Else
            varPasswordChange = True
        End If
    End Sub

    ''' <summary>
    ''' Saves the connection record after validating input fields.
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub Save()
        Call CheckAllInput()

        If (TxtConnectionName.Text = String.Empty) OrElse (TxtAddress.Text = String.Empty) OrElse (TxtPort.Text = String.Empty) OrElse (TxtUsername.Text = String.Empty) OrElse (TxtPassword.Text = String.Empty) OrElse (TxtDatabaseName.Text = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure the Connection Name, Address, Port, Username, Password, and Database Name are filled in correctly.", "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        If (Commands.CONN.Editor.PUSHData(TxtConnectionName.Text, CboDBEngine.Text, TxtAddress.Text, TxtPort.Text, TxtUsername.Text, TxtPassword.Text, TxtDatabaseName.Text, ChkDefault.Checked, varFormAttributes.RowID.ToString, varFormAttributes.IsNew, varPasswordChange)) Then
            SLFStatus.Text = "Success"
            RaiseEvent RecordSaved()
        Else
            SLFStatus.Text = "Failed to save"
            Return
        End If

        Me.Close()
    End Sub

    <SupportedOSPlatform("windows")>
    Function ReadConnectionString() As String
        Try
            Dim url As String = txtImportAddress.Text.Trim()
            Using client As New HttpClient()
                Dim response = client.GetAsync(url).Result
                response.EnsureSuccessStatusCode()
                Dim content = response.Content.ReadAsStringAsync().Result
                Return content.Trim()
            End Using

        Catch ex As Exception
            PUSHERRORDATA("CONN Editor", Catcher.Error.Fields.TypeOfFaulties.SupportServiceWeb, ex.ToString, "0", "", "", True, True, True)
            PUSHERRORDATASHOW()
        End Try
    End Function

#End Region

#Region "Form Events"
    ''' <summary>
    ''' Loads existing connection data into the form fields based on the RowID.
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub CONN_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        componentMainframeMenu.LoadIn(Me, True)
        componentMainframeMenu.ShowMenuFILE(CMCv.UI.View.MenuStrip.ShowItem.Yes)
        varPasswordChange = False

        If (varFormAttributes.IsNew) Then
            varFormAttributes.RowID = CMCv.Security.Encrypt.MD5()
        Else
            Call LoadData()
        End If
    End Sub
#End Region

#Region "Control Events"
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call Save()
    End Sub

    Private Sub TxtPassword_LostFocus(sender As Object, e As EventArgs) Handles TxtPassword.LostFocus
        Call CheckPasswordChange()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub ComponentMainframeMenu_EventFileSave() Handles ComponentMainframeMenu.EventFileSave
        Call Save()
    End Sub

    Private Sub ComponentMainframeMenu_EventFileCancel() Handles ComponentMainframeMenu.EventFileCancel
        Me.Close()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub ComponentMainframeMenu_EventFileUndoAll() Handles ComponentMainframeMenu.EventFileUndoAll
        If Decision("Do you want to undo all changes?", "Question", frmDialogBox.MessageIcon.Question, frmDialogBox.MessageTypes.YesNo) = DialogResult.Yes Then
            If (varFormAttributes.IsNew) Then
                TxtConnectionName.Clear()
                TxtAddress.Clear()
                TxtPort.Clear()
                TxtUsername.Clear()
                TxtPassword.Clear()
                TxtDatabaseName.Clear()
            Else
                Call LoadData()
            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click
        Dim conn As String = ReadConnectionString()
        txtImportContent.Text = conn
        txtImportContent.Text += Environment.NewLine & Environment.NewLine & CMCv.Security.Decrypt.GetSalt
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Call CheckAllInput()

        Dim exportConn As String = String.Format("{0}||{1}||{2}||{3}||{4}||{5}||{6}||{7}", TxtConnectionName.Text.Trim, CboDBEngine.Text.Trim, TxtAddress.Text.Trim, TxtPort.Text, TxtUsername.Text.Trim, TxtPassword.Text.Trim, TxtDatabaseName.Text.Trim, ChkDefault.Checked.ToString())

        txtImportContent.Text = exportConn
    End Sub


#End Region

End Class
