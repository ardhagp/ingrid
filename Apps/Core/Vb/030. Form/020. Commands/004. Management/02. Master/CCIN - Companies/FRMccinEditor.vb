Namespace UI.Canvas
    Public Class FRMccinEditor

        Public Event EventRecordSaved()
        Private WithEvents ComponentMainframeMenu As New CMCv.UI.View.MenuStrip

        ' This Module Identifier
        Private varThisModuleId As Long = 0
        Private Const varThisModuleCode As String = "CCIN"

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Function CheckInvalidInput() As Boolean
            Dim varInvalidScore As Integer = 0

            TxtCode.Focus()
            If TxtCode.XOSqlText = String.Empty Then
                varInvalidScore += 1
            End If
            TxtName.Focus()
            If TxtName.XOSqlText = String.Empty Then
                varInvalidScore += 1
            End If
            TxtSearchTerm1.Focus()
            If TxtSearchTerm1.XOSqlText = String.Empty Then
                varInvalidScore += 1
            End If
            TxtSearchTerm2.Focus()
            If TxtSearchTerm2.XOSqlText = String.Empty Then
                varInvalidScore += 1
            End If
            TxtDescription.Focus()
            If varInvalidScore = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMccinEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            CMCv.ImageEditor.File.GetImage.GetSvgImageFromUrlAsync(My.Settings.URL_Logo_EDIT, XOLogo,, 512, 512, True, "Module")

            ComponentMainframeMenu.LoadIn(Me, True)
            ComponentMainframeMenu.ShowMenuFile(CMCv.UI.View.MenuStrip.ShowItem.Yes)

            SetValue(varDataProperties.AllParameters, tCompany.P_CompanyClient, varDataProperties.AllParameters(tIngrid.P_ClientId))
            If (varDataProperties.CompanyIsNew) Then
                ChkAddNew.Visible = True
                ChkAddNew.Checked = False
            Else
                ChkAddNew.Visible = False
                ChkAddNew.Checked = False
                Call LoadData()
            End If
        End Sub

        ''' <summary>
        ''' This subroutine loads the company data into the form fields. It retrieves the company properties using the CMDccin.Editor.GetCompanyProperties method and populates the text boxes (TxtCode, TxtName, TxtSearchTerm1, TxtSearchTerm2, TxtDescription) with the corresponding values from the dataset. The method is marked with the SupportedOSPlatform attribute, indicating that it is intended to run on Windows platforms. This ensures that the data loading functionality is only executed in a compatible environment.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub LoadData()
            CMDccin.Editor.GetCompanyProperties(varDataProperties, varDatasetIngrid)
            If varDatasetIngrid.Tables(tCompany.TableName).Rows.Count > 0 Then
                With varDatasetIngrid.Tables(tCompany.TableName).Rows(0)
                    TxtCode.Text = .Item(tCompany.C_CompanyCode).ToString
                    TxtName.Text = .Item(tCompany.C_CompanyName).ToString
                    TxtSearchTerm1.Text = .Item(tCompany.C_CompanySearchTerm1).ToString
                    TxtSearchTerm2.Text = .Item(tCompany.C_CompanySearchTerm2).ToString
                    TxtDescription.Text = .Item(tCompany.C_CompanyDescription).ToString
                End With
            End If
        End Sub

        ''' <summary>
        ''' This subroutine is an event handler for the "Save" menu item in the mainframe menu. When the "Save" option is selected, it triggers the Save() method to save the current company data. The method is marked with the SupportedOSPlatform attribute, indicating that it is intended to run on Windows platforms. This ensures that the save functionality is only executed in a compatible environment.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub ComponentMainframeMenu_EventFileSave() Handles ComponentMainframeMenu.EventFileSave
            Call Save()
        End Sub

        ''' <summary>
        ''' This subroutine is an event handler for the "Close" menu item in the mainframe menu. When the "Close" option is selected, it triggers the form to close by calling the Close() method. The method is marked with the SupportedOSPlatform attribute, indicating that it is intended to run on Windows platforms. This ensures that the close functionality is only executed in a compatible environment.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub ComponentMainframeMenu_EventFileExit() Handles ComponentMainframeMenu.EventFileCancel
            Me.Close()
        End Sub

        ''' <summary>
        ''' This subroutine is an event handler for the "Undo" menu item in the mainframe menu. When the "Undo" option is selected, it displays a message indicating that the undo functionality is not yet implemented. The method is marked with the SupportedOSPlatform attribute, indicating that it is intended to run on Windows platforms. This ensures that the undo functionality is only executed in a compatible environment.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub ComponentMainframeMenu_EventFileUndo() Handles ComponentMainframeMenu.EventFileUndoAll
            If Decision(My.Application.Info.AssemblyName, "Do you want to undo all changes?", LibApp.Ingrid.Global.PopupType.UndoChanges, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Question, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.YesNo) = DialogResult.Yes Then
                If (varDataProperties.CompanyIsNew) Then
                    TxtCode.Clear()
                    TxtName.Clear()
                    TxtDescription.Clear()
                    TxtSearchTerm1.Clear()
                    TxtSearchTerm2.Clear()
                Else
                    Call LoadData()
                End If
            End If
        End Sub

        ''' <summary>
        ''' This subroutine is an event handler for the "Cancel" menu item in the mainframe menu. When the "Cancel" option is selected, it triggers the form to close by calling the Close() method. The method is marked with the SupportedOSPlatform attribute, indicating that it is intended to run on Windows platforms. This ensures that the cancel functionality is only executed in a compatible environment.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub ComponentMainframeMenu_EventFileCancel() Handles ComponentMainframeMenu.EventFileCancel
            Call CancelEdit()
        End Sub

        ''' <summary>
        ''' This subroutine is intended to handle the saving of company data. It is currently a placeholder and does not contain any implementation. The method is marked with the SupportedOSPlatform attribute, indicating that it is intended to run on Windows platforms. When implemented, this method would likely include logic to validate input, prepare data for saving, and interact with a database or data service to persist the company information.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Save()
            If CheckInvalidInput() Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Unable to save your record." & Environment.NewLine & "Please verify that the Company Code, Company Name, Search Term1 and Search Term2 fields have been entered correctly.", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                Return
            End If

            With varDataProperties
                SetValue(.AllParameters, tCompany.P_CompanyCode, TxtCode.XOSqlText)
                SetValue(.AllParameters, tCompany.P_CompanyName, TxtName.XOSqlText)
                SetValue(.AllParameters, tCompany.P_CompanySearchTerm1, IIf(TxtSearchTerm1.XOSqlText = String.Empty OrElse TxtSearchTerm1.XOSqlText = "", DBNull.Value, TxtSearchTerm1.XOSqlText))
                SetValue(.AllParameters, tCompany.P_CompanySearchTerm2, IIf(TxtSearchTerm2.XOSqlText = String.Empty OrElse TxtSearchTerm2.XOSqlText = "", DBNull.Value, TxtSearchTerm2.XOSqlText))
                SetValue(.AllParameters, tCompany.P_CompanyDescription, IIf(TxtDescription.XOSqlText = String.Empty OrElse TxtDescription.XOSqlText = "", DBNull.Value, TxtDescription.XOSqlText))
            End With

            If (varDataProperties.AllParameters(tCompany.P_CompanyCode).ToString = String.Empty) OrElse (varDataProperties.AllParameters(tCompany.P_CompanyName).ToString = String.Empty) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "Ensure that the Company Code and Company Name fields are properly filled in.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                Call ClearParameters()
                Return
            ElseIf ((varDataProperties.CompanyIsNew) AndAlso (CMDccin.Editor.IsDuplicate(varDataProperties))) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "This Company Code is already registered.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                Call ClearParameters()
                Return
            ElseIf (Not (varDataProperties.CompanyIsNew) AndAlso (CMDccin.Editor.IsDuplicate(varDataProperties))) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "The Company Code cannot be used because it is already assigned to another company.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                Call ClearParameters()
                Return
            End If

            If CMDccin.Editor.PushData(varDataProperties) Then
                UI.Canvas.FRMmainframe6.Ts_status.Text = "Success"
                RaiseEvent EventRecordSaved()
            Else
                UI.Canvas.FRMmainframe6.Ts_status.Text = "Failed to save"
                Return
            End If

            If ChkAddNew.Checked Then
                TxtCode.Clear()
                TxtName.Clear()
                TxtSearchTerm1.Clear()
                TxtSearchTerm2.Clear()
                TxtDescription.Clear()
                TxtCode.Focus()
            Else
                Call ClearParameters()
                Me.Close()
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub CancelEdit()
            Me.Close()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            Call CancelEdit()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            Call Save()
        End Sub

        ''' <summary>
        ''' This subroutine clears the parameters in the varDataProperties.AllParameters collection related to company information. It removes the company code, name, search terms, and description from the collection, effectively resetting these values. This is useful for ensuring that no residual data remains when creating a new company record or when clearing the form after saving.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub ClearParameters()
            With varDataProperties
                .AllParameters.Remove(tCompany.P_CompanyCode)
                .AllParameters.Remove(tCompany.P_CompanyName)
                .AllParameters.Remove(tCompany.P_CompanySearchTerm1)
                .AllParameters.Remove(tCompany.P_CompanySearchTerm2)
                .AllParameters.Remove(tCompany.P_CompanyDescription)
            End With
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMccinEditor_Activated(sender As Object, e As EventArgs) Handles Me.Activated
            ' Set active module to UserParameters
            SetValue(varDataProperties.AllParameters, tIngrid.P_ModuleId, varThisModuleId)
            SetValue(varDataProperties.AllParameters, tIngrid.P_ModuleCode, varThisModuleCode)
        End Sub

    End Class
End Namespace