Imports System.IO
Imports System.Net.Http
Imports System.Runtime.Versioning

Namespace UI.Canvas
    Public Class FRMconnEditor

        Private WithEvents ComponentMainframeMenu As New CMCv.UI.View.MenuStrip

        Public Event EventRecordSaved()

        Private varIsPasswordChange As Boolean
        Private varOldPassword As String
        Private varConnectionName As String

        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

        End Sub
        <SupportedOSPlatform("windows")>
        Private Sub LoadData()
            Try
                CMDconn.Editor.GetRowValue(varDataProperties)

                With varDataProperties
                    If (.ConnectionIsMasked) Then
                        TxtAddress.UseSystemPasswordChar = True
                        TxtPort.UseSystemPasswordChar = True
                        TxtUsername.UseSystemPasswordChar = True
                        TxtDatabaseName.UseSystemPasswordChar = True
                    End If

                    TxtConnectionName.Text = .ConnectionName
                    CboDBEngine.Text = .ConnectionDatabaseEngine
                    TxtAddress.Text = .ConnectionServerAddress
                    TxtPort.Text = Convert.ToString(.ConnectionServerPort)
                    TxtUsername.Text = .ConnectionUsername
                    TxtPassword.Text = .ConnectionPassword
                    varOldPassword = .ConnectionPasswordOld
                    TxtDatabaseName.Text = .ConnectionDatabaseName
                    TxtClient.Text = .ConnectionClientCode
                    ChkDefault.Checked = .ConnectionIsDefault
                    ChkIsMasked.Checked = .ConnectionIsMasked
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

        <SupportedOSPlatform("windows")>
        Private Function CheckAllInput() As Boolean
            Dim varValidScore As Integer = 0

            If TxtConnectionName.Text = String.Empty Then
                varValidScore += 1
            End If
            If TxtAddress.Text = String.Empty Then
                varValidScore += 1
            End If
            If CInt(TxtPort.Text) <= 0 Then
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
            If TxtPassword.XOSqlText = varOldPassword Then
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
                Decision(My.Application.Info.AssemblyName, "Cannot save your record." & Environment.NewLine & "Make sure the Connection Name, Address, Port, Username, Password, and Database Name are filled in correctly.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            With varDataProperties
                .ConnectionName = TxtConnectionName.Text.Trim
                .ConnectionDatabaseEngine = CboDBEngine.Text
                .ConnectionServerAddress = TxtAddress.Text.Trim
                .ConnectionServerPort = Convert.ToInt32(TxtPort.Text.Trim)
                .ConnectionUsername = TxtUsername.Text.Trim
                .ConnectionPassword = TxtPassword.Text
                .ConnectionDatabaseName = TxtDatabaseName.Text.Trim
                .ConnectionIsDefault = ChkDefault.Checked
                .ConnectionIsMasked = ChkIsMasked.Checked
                .ConnectionIsPasswordChanged = varIsPasswordChange
                .ConnectionClientCode = TxtClient.Text.Trim
                .ConnectionId = Convert.ToString(varDataProperties.ConnectionId)
            End With

            If (CMDconn.Editor.PushData(varDataProperties)) Then
                SLFStatus.Text = "Success"
                RaiseEvent EventRecordSaved()
                Me.Close()
            Else
                SLFStatus.Text = "Failed to save"
                Return
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Function ReadConnectionString(url As String, connectioncode As String) As String
            Try
                Dim varFullurl As String
                varFullurl = url & "conf/" & connectioncode.Trim & "/host.conn"

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

        ''' <summary>
        ''' Loads existing connection data into the form fields based on the RowID.
        ''' </summary>
        <SupportedOSPlatform("windows")>
        Private Sub FRMconnEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ComponentMainframeMenu.LoadIn(Me, True)
            ComponentMainframeMenu.ShowMenuFile(CMCv.UI.View.MenuStrip.ShowItem.Yes)
            varIsPasswordChange = False

            CboDBEngine.DataSource = [Enum].GetValues(GetType(LibApp.Ingrid.Global.DatabaseEngine))

            If (varDataProperties.ConnectionIsNew) Then
                varDataProperties.ConnectionId = CMCv.Security.Encryption.MD5()
                ChkIsMasked.Visible = True
            Else
                ChkIsMasked.Visible = False
                Call LoadData()
            End If

        End Sub

        <SupportedOSPlatform("windows")>
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

        <SupportedOSPlatform("windows")>
        Private Sub ComponentMainframeMenu_EventFileCancel() Handles ComponentMainframeMenu.EventFileCancel
            Me.Close()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub ComponentMainframeMenu_EventFileUndoAll() Handles ComponentMainframeMenu.EventFileUndoAll
            If Decision(My.Application.Info.AssemblyName, "Do you want to undo all changes?", LibApp.Ingrid.Global.PopupType.Question, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Question, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.YesNo) = DialogResult.Yes Then
                If (varDataProperties.ConnectionIsNew) Then
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

            varDownloadCenter = Bridge.Getkey.CloudStorageUrl

            Dim conn As String = ReadConnectionString(varDownloadCenter, txtImportCode.Text)
            txtImportContent.Text = conn
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
            If Not CheckAllInput() Then
                Return
            End If

            Dim exportConn As String
            exportConn = $"{TxtConnectionName.Text.Trim}||{CboDBEngine.Text.Trim}||{CMCv.Security.Encryption.Aes(TxtAddress.Text.Trim)}||{CMCv.Security.Encryption.Aes(TxtPort.Text)}||{CMCv.Security.Encryption.Aes(TxtUsername.Text.Trim)}||{CMCv.Security.Encryption.Aes(TxtPassword.Text)}||{CMCv.Security.Encryption.Aes(TxtDatabaseName.Text.Trim)}||{Convert.ToString(ChkDefault.Checked)}||{Convert.ToString(ChkIsMasked.Checked)}||{TxtClient.Text.Trim}"

            txtImportContent.Text = CMCv.Security.Encryption.Aes(exportConn)
            varConnectionName = CMCv.Security.Encryption.CRC32(TxtConnectionName.Text.Trim)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub btnSaveAs_Click(sender As Object, e As EventArgs) Handles btnSaveAs.Click
            Dim varDialog As New FolderBrowserDialog With {
        .Description = "Select a folder to save the connection config"
        }

            If varConnectionName = String.Empty Then
                MessageBox.Show("Please export the connection first to generate the connection code.")
                Return
            End If

            If varDialog.ShowDialog() = DialogResult.OK Then
                Dim selectedPath As String = varDialog.SelectedPath

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
            decryptedConn = CMCv.Security.Decrypt.Aes(txtImportContent.Text.Trim)

            Dim varConnproperties() As String = decryptedConn.Split({"||"}, StringSplitOptions.None)

            If varConnproperties.Length <> 10 Then
                MessageBox.Show("The connection content is invalid.")
                Return
            End If

            TxtConnectionName.Text = varConnproperties(0)
            CboDBEngine.Text = varConnproperties(1)
            TxtAddress.Text = CMCv.Security.Decrypt.Aes(varConnproperties(2))
            TxtPort.Text = CMCv.Security.Decrypt.Aes(varConnproperties(3))
            TxtUsername.Text = CMCv.Security.Decrypt.Aes(varConnproperties(4))
            TxtPassword.Text = CMCv.Security.Decrypt.Aes(varConnproperties(5))
            TxtDatabaseName.Text = CMCv.Security.Decrypt.Aes(varConnproperties(6))
            ChkDefault.Checked = Convert.ToBoolean(varConnproperties(7))
            ChkIsMasked.Checked = Convert.ToBoolean(varConnproperties(8))
            TxtClient.Text = varConnproperties(9)
            Call ChangeIsMaskedState()
            If ChkIsMasked.Checked Then
                ChkIsMasked.Visible = False
            Else
                ChkIsMasked.Visible = True
            End If
            MessageBox.Show("Connection imported successfully.")
        End Sub

        <SupportedOSPlatform("windows")>
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

        <SupportedOSPlatform("windows")>
        Private Sub BtnTest_Click(sender As Object, e As EventArgs) Handles Btn_Test.Click
            If CboDBEngine.Text = "MYSQL" Then
                Try
                    Dim varMysql As New CMCv.Database.Connect.Mysqlconnection
                    Dim varConnection As MySql.Data.MySqlClient.MySqlConnection
                    varConnection = New MySql.Data.MySqlClient.MySqlConnection(varMysql.Mysqlforcessl(TxtAddress.XOSqlText, CInt(TxtPort.XOSqlText), TxtDatabaseName.XOSqlText, TxtUsername.XOSqlText, TxtPassword.XOSqlText))
                    varConnection.Open()
                    MessageBox.Show("Connection test successful.")
                    varConnection.Close()
                    varConnection.Dispose()
                Catch ex As Exception
                    MessageBox.Show("Connection test failed: " & ex.Message)
                End Try
            End If
        End Sub
    End Class
End Namespace