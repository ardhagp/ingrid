Imports System.Runtime.Versioning
Imports MySql.Data.MySqlClient
'Imports Syncfusion.Styles ' For future use if needed

Public Class CONN_Editor

#Region "Declarations"
    Public Event RecordSaved()
    Private WithEvents C_MMSMenu As New CMCv.UI.View.MenuStrip
    Private _SQL As New Commands.CONN.Editor
    Private _PWDChange As Boolean
    Private _OldPassword As String

#Region "Functions and Subs"
    ''' <summary>
    ''' Loads existing connection data into the form fields based on the RowID.
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub LoadData()
        Commands.CONN.Editor.GETRowValue(varFormAttributes.RowID.ToString, TxtConnectionName, CboDBEngine,
                                         TxtAddress, TxtPort, TxtUsername, TxtPassword,
                                         VarOldPassword, TxtDataStorage, ChkDefault)
    End Sub

    ''' <summary>
    ''' Saves the connection record after validating input fields.
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub Save()
        Call CheckAllInput()

        If (TxtConnectionName.Text = String.Empty) OrElse (TxtAddress.Text = String.Empty) OrElse
            (TxtPort.Text = String.Empty) OrElse (TxtUsername.Text = String.Empty) OrElse
            (TxtPassword.Text = String.Empty) Then
            Decision("Cannot save your record." & Environment.NewLine & "Make sure you have " &
                     "Connection Name, Address, Port, Username, Password are properly filled.",
                     "Alert", frmDialogBox.MessageIcon.Alert, frmDialogBox.MessageTypes.OkOnly)
            Return
        End If

        If Commands.CONN.Editor.PUSHData(TxtConnectionName.Text, CboDBEngine.Text, TxtAddress.Text,
                                          TxtPort.Text, TxtUsername.Text, TxtPassword.Text,
                                          TxtDataStorage.Text, ChkDefault.Checked,
                                          varFormAttributes.RowID.ToString, varFormAttributes.IsNew,
                                          VarPWDChange) Then
            SLFStatus.Text = "Success"
            RaiseEvent RecordSaved()
        Else
            SLFStatus.Text = "Failed to save"
            Return
        End If

        Me.Close()
    End Sub

    ''' <summary>
    ''' Tests a MySQL connection string by opening and closing the connection.
    ''' Returns True if successful, False otherwise.
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Public Shared Function TestConnection(connectionString As String) As Boolean
        Try
            If String.IsNullOrWhiteSpace(connectionString) Then
                Decision("Connection string is empty.", "Alert", frmDialogBox.MessageIcon.Alert,
                         frmDialogBox.MessageTypes.OkOnly)
                Return False
            End If

            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                ' If we reach here, connection succeeded
                Return True
            End Using
        Catch ex As MySqlException
            ' Handle MySQL-specific errors (wrong host, bad credentials, etc.)
            Decision("MySQL Error: " & ex.Message, "Error", frmDialogBox.MessageIcon.Error,
                     frmDialogBox.MessageTypes.OkOnly)
            Return False
        Catch ex As Exception
            ' Handle other unexpected errors
            Decision("General Error: " & ex.Message, "Error", frmDialogBox.MessageIcon.Error,
                     frmDialogBox.MessageTypes.OkOnly)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Forces focus on all input fields to trigger any validation or formatting logic.
    ''' </summary>
    Private Sub CheckAllInput()
        TxtConnectionName.Focus()
        TxtAddress.Focus()
        TxtPort.Focus()
        TxtUsername.Focus()
        TxtPassword.Focus()
    End Sub

    ''' <summary>
    ''' Checks if the password field has been changed compared to the old password.
    ''' </summary>
    Private Sub CheckPasswordChange()
        If TxtPassword.XOSQLText = VarOldPassword Then
            VarPWDChange = False
        Else
            VarPWDChange = True
        End If
    End Sub
#End Region

#Region "Form Events"
    ''' <summary>
    ''' Handles the form load event, initializing the menu and loading data if editing an existing record.
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub CONN_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComponentMainframeMenu.LoadIn(Me, True)
        ComponentMainframeMenu.ShowMenuFILE(CMCv.UI.View.MenuStrip.ShowItem.Yes)
        VarPWDChange = False

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
        If Decision("Do you want to undo all changes?", "Question",
                    frmDialogBox.MessageIcon.Question, frmDialogBox.MessageTypes.YesNo) =
                    DialogResult.Yes Then
            If varFormAttributes.IsNew Then
                TxtConnectionName.Clear()
                TxtAddress.Clear()
                TxtPort.Clear()
                TxtUsername.Clear()
                TxtPassword.Clear()
                TxtDataStorage.Clear()
            Else
                Call LoadData()
            End If
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnTest_Click(sender As Object, e As EventArgs) Handles BtnTest.Click
        Call TestConnection("")
    End Sub
#End Region

End Class
