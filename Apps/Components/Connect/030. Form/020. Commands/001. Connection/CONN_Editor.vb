Imports System.Configuration
Imports System.Data.SQLite
Imports System.IO
Imports System.Net.Http
Imports System.Net.Security
Imports System.Runtime.Versioning
Imports CMCv
Imports Org.BouncyCastle.Crypto.Agreement.Kdf

Public Class CONN_Editor

#Region "Declarations"
    Public Event RecordSaved()
    Private WithEvents ComponentMainframeMenu As New CMCv.UI.View.MenuStrip
    Private varSQL As New Commands.CONN.Editor
    Private varPasswordChange As Boolean
    Private varOldPassword As String
    Private varConnectionName As String
#End Region

#Region "Functions and Subs"

    <SupportedOSPlatform("windows")>
    Private Sub LoadData()
        Commands.CONN.Editor.GETRowValue(varFormAttributes.RowID.ToString, TxtConnectionName, CboDBEngine, TxtAddress, TxtPort, TxtUsername, TxtPassword, TxtDatabaseName, varOldPassword, ChkDefault)
    End Sub

    Private Function CheckAllInput() As Boolean
        Dim varValidScore As Integer = 0
        'TxtConnectionName.Focus()
        'TxtAddress.Focus()
        'TxtPort.Focus()
        'TxtUsername.Focus()
        'TxtPassword.Focus()
        'TxtDatabaseName.Focus()

        If TxtConnectionName.Text = String.Empty Then
            varValidScore += 1
        End If
        If TxtAddress.Text = String.Empty Then
            varValidScore += 1
        End If
        If TxtPort.Text = CStr(0) Then
            varValidScore += 1
        End If
        If TxtUsername.Text = String.Empty Then
            varValidScore += 1
        End If
        If TxtPassword.Text = String.Empty Then
            varValidScore += 1
        End If
        If TxtDatabaseName.Text = String.Empty Then
            varValidScore += 1
        End If
        If varValidScore = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

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
        If Not CheckAllInput() Then
            Return
        End If

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
    Function ReadConnectionString(url As String, connectioncode As String) As String
        Try
            Dim varFullurl As String
            varFullurl = url & "/conf/" & connectioncode.Trim & "/host.conn"

            Using client As New HttpClient()
                Dim response = client.GetAsync(varFullurl).Result
                response.EnsureSuccessStatusCode()
                Dim content = response.Content.ReadAsStringAsync().Result
                Return content.Trim()
            End Using

        Catch ex As Exception
            With proLog
                .AppVersion = GetAppVersion()
                .FromSender = "[ReadConnectionString] $\Ingrid\Apps\Components\Connect\030. Form\020. Commands\001. Connection\CONN_Editor.vb"
                .InternalStackTrace = ex.StackTrace
                .Message = ex.Message
                .Number = ex.HResult
                .ResumeNext = True
                .SaveInBetterLog = True
                .SaveLogInLocal = False
                .ShowErrorReporting = True
                .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.ApplicationRunTime
                .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
            End With

            Dim clsLog As New Ladybug.Log.Events
            clsLog.ShowData(proLog)
            clsLog = Nothing

            Return Nothing
        End Try
    End Function

#End Region

#Region "Form Events"
    ''' <summary>
    ''' Loads existing connection data into the form fields based on the RowID.
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub CONN_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComponentMainframeMenu.LoadIn(Me, True)
        ComponentMainframeMenu.ShowMenuFILE(CMCv.UI.View.MenuStrip.ShowItem.Yes)
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
        Dim varDownloadCenter As String = String.Empty

        If txtImportCode.Text = String.Empty Then
            MessageBox.Show("Please enter the connection code to import.")
            Return
        End If

        varDownloadCenter = My.Settings.ConnectionURL

        Dim conn As String = ReadConnectionString(varDownloadCenter, txtImportCode.Text)
        txtImportContent.Text = conn
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If Not CheckAllInput() Then
            Return
        End If

        Dim exportConn As String
        exportConn = String.Format("{0}||{1}||{2}||{3}||{4}||{5}||{6}||{7}", TxtConnectionName.Text.Trim, CboDBEngine.Text.Trim, TxtAddress.Text.Trim, TxtPort.Text, TxtUsername.Text.Trim, CMCv.Security.Encrypt.AES(TxtPassword.Text.Trim), TxtDatabaseName.Text.Trim, ChkDefault.Checked.ToString())

        txtImportContent.Text = CMCv.Security.Encrypt.AES(exportConn)
        varConnectionName = CMCv.Security.Encrypt.CRC32(TxtConnectionName.Text.Trim)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub btnSaveAs_Click(sender As Object, e As EventArgs) Handles btnSaveAs.Click
        Dim dlg As New FolderBrowserDialog()
        dlg.Description = "Select a folder to save the connection config"

        If varConnectionName = String.Empty Then
            MessageBox.Show("Please export the connection first to generate the connection code.")
            Return
        End If

        If dlg.ShowDialog() = DialogResult.OK Then
            Dim selectedPath As String = dlg.SelectedPath

            ' Compute CRC (example)
            Dim crc As String = varConnectionName  ' replace with your CRC5 or CRC32 result

            ' Create CRC folder
            Dim crcFolder As String = Path.Combine(selectedPath, crc)
            If Not Directory.Exists(crcFolder) Then
                Directory.CreateDirectory(crcFolder)
            End If

            ' Encrypted content
            Dim encrypted As String
            encrypted = txtImportContent.Text.Trim

            ' Save as host.conn
            Dim filePath As String = Path.Combine(crcFolder, "host.conn")
            File.WriteAllText(filePath, encrypted)

            MessageBox.Show("Config saved to: " & filePath)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        If txtImportContent.Text = String.Empty Then
            MessageBox.Show("Please enter the connection content to import.")
            Return
        End If

        Dim decryptedConn As String
        decryptedConn = CMCv.Security.Decrypt.AES(txtImportContent.Text.Trim)

        Dim varConnproperties() As String = decryptedConn.Split(New String() {"||"}, StringSplitOptions.None)

        If varConnproperties.Length <> 8 Then
            MessageBox.Show("The connection content is invalid.")
            Return
        End If

        TxtConnectionName.Text = varConnproperties(0)
        CboDBEngine.Text = varConnproperties(1)
        TxtAddress.Text = varConnproperties(2)
        TxtPort.Text = varConnproperties(3)
        TxtUsername.Text = varConnproperties(4)
        TxtPassword.Text = CMCv.Security.Decrypt.AES(varConnproperties(5))
        TxtDatabaseName.Text = varConnproperties(6)
        ChkDefault.Checked = Convert.ToBoolean(varConnproperties(7))
        MessageBox.Show("Connection imported successfully.")
    End Sub
#End Region

End Class
