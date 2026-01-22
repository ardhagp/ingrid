Imports System.IO
Imports System.Net.Http
Imports System.Runtime.Versioning

Public Class FRMconnEditor

#Region "Declarations"
    Public Event RecordSaved()
    Private WithEvents ComponentMainframeMenu As New CMCv.UI.View.MenuStrip
    Private varSQL As New Commands.CONN.Editor
    Private varIsPasswordChange As Boolean
    Private varOldPassword As String
    Private varConnectionName As String
#End Region

#Region "Functions and Subs"

    <SupportedOSPlatform("windows")>
    Private Sub LoadData()
        Try
            Commands.CONN.Editor.GetRowValue(varProperties)

            With varProperties
                If (.IsMasked) Then
                    TxtAddress.UseSystemPasswordChar = True
                    TxtPort.UseSystemPasswordChar = True
                    TxtUsername.UseSystemPasswordChar = True
                    TxtDatabaseName.UseSystemPasswordChar = True
                End If

                TxtConnectionName.Text = .ConnectionName
                CboDBEngine.Text = .DatabaseEngine
                TxtAddress.Text = .ServerAddress
                TxtPort.Text = Convert.ToString(.ServerPort)
                TxtUsername.Text = .Username
                TxtPassword.Text = .Password
                varOldPassword = .PasswordOld
                TxtDatabaseName.Text = .DatabaseName
                ChkDefault.Checked = .IsDefault
                ChkIsMasked.Checked = .IsMasked
            End With
        Catch ex As Exception
            Dim clsLog As New Ladybug.Log.Events
            With proLog
                .AppVersion = GetAppVersion()
                .FromSender = "[LoadData] $\Ingrid\Apps\Components\Connect\030. Form\020. Commands\001. Connection\CONN_Editor.vb"
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
            clsLog.ShowData(proLog)
            clsLog = Nothing
        End Try
    End Sub

    Private Function CheckAllInput() As Boolean
        Dim varValidScore As Integer = 0

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
            varIsPasswordChange = False
        Else
            varIsPasswordChange = True
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
            Decision("Cannot save your record." & Environment.NewLine & "Make sure the Connection Name, Address, Port, Username, Password, and Database Name are filled in correctly.", "Alert", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
            Return
        End If

        With varProperties
            .ConnectionName = TxtConnectionName.Text
            .DatabaseEngine = CboDBEngine.Text
            .ServerAddress = TxtAddress.Text
            .ServerPort = Convert.ToInt32(TxtPort.Text)
            .Username = TxtUsername.Text
            .Password = TxtPassword.Text
            .DatabaseName = TxtDatabaseName.Text
            .IsDefault = ChkDefault.Checked
            .IsMasked = ChkIsMasked.Checked
            .IsNew = varProperties.IsNew
            .IsPasswordChanged = varIsPasswordChange
            .RowID = Convert.ToString(varProperties.RowID)
        End With

        If (Commands.CONN.Editor.PushData(varProperties)) Then
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
    Private Sub FRMconnEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComponentMainframeMenu.LoadIn(Me, True)
        ComponentMainframeMenu.ShowMenuFile(CMCv.UI.View.MenuStrip.ShowItem.Yes)
        varIsPasswordChange = False

        If (varProperties.IsNew) Then
            varProperties.RowID = CMCv.Security.Encrypt.MD5()
            ChkIsMasked.Visible = True
        Else
            ChkIsMasked.Visible = False
            Call LoadData()
        End If

    End Sub
#End Region

#Region "Control Events"
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs)
        Close
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs)
        Save
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
        If Decision("Do you want to undo all changes?", "Question", FRMdialogbox.MessageIcon.Question, FRMdialogbox.MessageTypes.YesNo) = DialogResult.Yes Then
            If (varProperties.IsNew) Then
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
    Private Sub btnGet_Click(sender As Object, e As EventArgs)
        Dim varDownloadCenter = String.Empty

        If txtImportCode.Text = String.Empty Then
            MessageBox.Show("Please enter the connection code to import.")
            Return
        End If

        varDownloadCenter = My.Settings.ConnectionURL

        Dim conn = ReadConnectionString(varDownloadCenter, txtImportCode.Text)
        txtImportContent.Text = conn
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub btnExport_Click(sender As Object, e As EventArgs)
        If Not CheckAllInput Then
            Return
        End If

        Dim exportConn As String
        exportConn = $"{TxtConnectionName.Text.Trim}||{CboDBEngine.Text.Trim}||{Security.Encrypt.AES(TxtAddress.Text.Trim)}||{Security.Encrypt.AES(TxtPort.Text)}||{Security.Encrypt.AES(TxtUsername.Text.Trim)}||{Security.Encrypt.AES(TxtPassword.Text)}||{Security.Encrypt.AES(TxtDatabaseName.Text.Trim)}||{Convert.ToString(ChkDefault.Checked)}||{Convert.ToString(ChkIsMasked.Checked)}"

        txtImportContent.Text = Security.Encrypt.AES(exportConn)
        varConnectionName = Security.Encrypt.CRC32(TxtConnectionName.Text.Trim)
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub btnSaveAs_Click(sender As Object, e As EventArgs)
        Dim varDialog As New FolderBrowserDialog With {
        .Description = "Select a folder to save the connection config"
        }


        If varConnectionName = String.Empty Then
            MessageBox.Show("Please export the connection first to generate the connection code.")
            Return
        End If

        If varDialog.ShowDialog = DialogResult.OK Then
            Dim selectedPath = varDialog.SelectedPath

            ' Compute CRC (example)
            Dim crc = varConnectionName  ' replace with your CRC5 or CRC32 result

            ' Create CRC folder
            Dim crcFolder = Path.Combine(selectedPath, crc)
            If Not Directory.Exists(crcFolder) Then
                Directory.CreateDirectory(crcFolder)
            End If

            ' Encrypted content
            Dim encrypted As String
            encrypted = txtImportContent.Text.Trim

            ' Save as host.conn
            Dim filePath = Path.Combine(crcFolder, "host.conn")
            File.WriteAllText(filePath, encrypted)

            MessageBox.Show("Config saved to: " & filePath)
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub btnImport_Click(sender As Object, e As EventArgs)
        If txtImportContent.Text = String.Empty Then
            MessageBox.Show("Please enter the connection content to import.")
            Return
        End If

        Dim decryptedConn As String
        decryptedConn = Security.Decrypt.AES(txtImportContent.Text.Trim)

        Dim varConnproperties = decryptedConn.Split({"||"}, StringSplitOptions.None)

        If varConnproperties.Length <> 9 Then
            MessageBox.Show("The connection content is invalid.")
            Return
        End If

        TxtConnectionName.Text = varConnproperties(0)
        CboDBEngine.Text = varConnproperties(1)
        TxtAddress.Text = Security.Decrypt.AES(varConnproperties(2))
        TxtPort.Text = Security.Decrypt.AES(varConnproperties(3))
        TxtUsername.Text = Security.Decrypt.AES(varConnproperties(4))
        TxtPassword.Text = Security.Decrypt.AES(varConnproperties(5))
        TxtDatabaseName.Text = Security.Decrypt.AES(varConnproperties(6))
        ChkDefault.Checked = Convert.ToBoolean(varConnproperties(7))
        ChkIsMasked.Checked = Convert.ToBoolean(varConnproperties(8))
        ChangeIsMaskedState
        MessageBox.Show("Connection imported successfully.")
    End Sub

    Private Sub ChangeIsMaskedState()
        If (ChkIsMasked.Checked) Then
            TxtAddress.UseSystemPasswordChar = True
            TxtPort.UseSystemPasswordChar = True
            TxtUsername.UseSystemPasswordChar = True
            TxtDatabaseName.UseSystemPasswordChar = True
        Else
            TxtAddress.UseSystemPasswordChar = False
            TxtPort.UseSystemPasswordChar = False
            TxtUsername.UseSystemPasswordChar = False
            TxtDatabaseName.UseSystemPasswordChar = False
        End If
    End Sub
#End Region

End Class
