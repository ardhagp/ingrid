Namespace UI.Canvas
    Public Class FRMpostEditor
        ' ----------------------------------------------------------
        '  Variables
        ' ----------------------------------------------------------
        Public Event EventRecordSaved()
        Private WithEvents ComponentMainframeMenu As New CMCv.UI.View.MenuStrip

        Public varIsFirstLoad As Boolean


        ' ----------------------------------------------------------
        ' Form Events Handlers
        ' ----------------------------------------------------------
        ''' <summary>
        ''' Handles the Activated event of the FRMpostEditor form. This event is triggered when the form becomes active, and it sets the active module identifier to the current module's code and ID for user parameters management.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMpostEditor_Activated(sender As Object, e As EventArgs) Handles Me.Activated
            ' Set active module to UserParameters
            SetModuleIdentifier(varDataProperties.AllParameters, XOModuleCode, XOModuleId)
        End Sub

        ''' <summary>
        ''' Handles the Load event of the FRMpostEditor form. This event is triggered when the form is loaded, and it initializes the form by loading the logo image, setting up the mainframe menu, and populating the company and department combo boxes based on whether a new employee position is being created or an existing one is being edited.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMpostEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            CMCv.ImageEditor.File.GetImage.GetSvgImageFromUrlAsync(My.Settings.URL_Logo_EDIT, XOLogo,, 512, 512)

            ComponentMainframeMenu.LoadIn(Me, True)
            ComponentMainframeMenu.ShowMenuFile(CMCv.UI.View.MenuStrip.ShowItem.Yes)

            varIsFirstLoad = True

            ' Populate the company and department combo boxes based on whether a new employee position is being created or an existing one is being edited.
            If (varDataProperties.EmployeePositionIsNew) Then
                ChkAddNew.Visible = True
                CMDpost.Editor.FillCompany(varDataProperties, CboCompany)
                CMDpost.Editor.FillDepartement(varDataProperties, CboDepartement, CboCompany)
            Else
                ChkAddNew.Visible = False
                CMDpost.Editor.FillCompany(varDataProperties, CboCompany)
                Call LoadData()
            End If
            varIsFirstLoad = False
        End Sub


        ' ---------------------------------------------------------
        ' Functions and Subroutines
        ' ---------------------------------------------------------
        ''' <summary>
        ''' Loads the data for the current position being edited. It retrieves the position properties from the database and populates the form controls (company, department, position code, name, and description) with the corresponding values. This method is called when editing an existing position to display its details in the form.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub LoadData()
            CMDpost.Editor.GetPositionProperties(varDataProperties, varDatasetIngrid)

            ' Populate form controls with retrieved data
            If varDatasetIngrid.Tables(tPosition.TableName).Rows.Count > 0 Then
                With varDatasetIngrid.Tables(tPosition.TableName).Rows(0)
                    CboCompany.SelectedValue = .Item(tDepartment.C_DepartmentCompany).ToString
                    CMDpost.Editor.FillDepartement(varDataProperties, CboDepartement, CboCompany)
                    CboDepartement.SelectedValue = .Item(tPosition.C_PositionDepartment).ToString
                    TxtPositionCode.Text = .Item(tPosition.C_PositionCode).ToString
                    TxtPositionName.Text = .Item(tPosition.C_PositionName).ToString
                    TxtPositionDescription.Text = .Item(tPosition.C_PositionDescription).ToString
                End With
            End If
        End Sub

        ''' <summary>
        ''' Checks all input fields in the form by setting focus to each control in sequence. This method is used to ensure that all input fields are properly initialized and ready for user interaction.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub CheckAllInput()
            CboCompany.Focus()
            CboDepartement.Focus()
            TxtPositionCode.Focus()
            TxtPositionName.Focus()
            BtnSave.Focus()
        End Sub

        ''' <summary>
        ''' Saves the current position data. It validates the input fields, checks for duplicates, and pushes the data to the database. If the save is successful, it raises the EventRecordSaved event. If the "Add New" checkbox is checked, it clears the input fields for a new entry; otherwise, it closes the form.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Save()
            With varDataProperties
                SetValue(.AllParameters, tCompany.P_CompanyId, CLng(CboCompany.SelectedValue))
                SetValue(.AllParameters, tDepartment.P_DepartmentId, CLng(CboDepartement.SelectedValue))
                SetValue(.AllParameters, tPosition.P_PositionCode, TxtPositionCode.XOSqlText)
                SetValue(.AllParameters, tPosition.P_PositionName, TxtPositionName.XOSqlText)
                SetValue(.AllParameters, tPosition.P_PositionDescription, IIf(TxtPositionDescription.XOSqlText = String.Empty OrElse TxtPositionDescription.XOSqlText = "", DBNull.Value, TxtPositionDescription.XOSqlText))
            End With

            ' Validate input fields
            If (CboDepartement.Items.Count = 0) OrElse (varDataProperties.AllParameters(tPosition.P_PositionCode).ToString = String.Empty) OrElse (varDataProperties.AllParameters(tPosition.P_PositionName).ToString = String.Empty) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "Make sure you have Department selected, Postition Code and Position Description are properly filled.", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                Return
            ElseIf ((varDataProperties.EmployeePositionIsNew) AndAlso (CMDpost.Editor.IsDuplicate(varDataProperties))) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "This Posititon Code already used.", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                Return
            ElseIf (Not (varDataProperties.EmployeePositionIsNew) AndAlso (CMDpost.Editor.IsDuplicate(varDataProperties))) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "This Posititon Code already used.", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.OkOnly)
                Return
            End If

            ' Push data to database
            If (CMDpost.Editor.PushData(varDataProperties)) Then
                UI.Canvas.FRMmainframe6.Ts_status.Text = "Success"
                RaiseEvent EventRecordSaved()
            Else
                UI.Canvas.FRMmainframe6.Ts_status.Text = "Failed to save"
                Return
            End If

            ' If the "Add New" checkbox is checked, clear the input fields for a new entry; otherwise, close the form.
            If (ChkAddNew.Checked) Then
                TxtPositionCode.Clear()
                TxtPositionName.Clear()
                TxtPositionDescription.Clear()
                TxtPositionCode.Focus()
            Else
                Me.Close()
            End If
        End Sub


        ' ---------------------------------------------------------
        ' Components Handlers
        ' ---------------------------------------------------------
        ''' <summary>
        ''' Handles the Click event of the BtnCancel button. When clicked, it closes the current form (FRMpostEditor).
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            Me.Close()
        End Sub

        ''' <summary>
        ''' Handles the SelectedIndexChanged event of the CboCompany ComboBox. When the selected company changes, it fills the CboDepartement ComboBox with the corresponding departments for the selected company, but only if it's not the first load of the form.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub CboCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCompany.SelectedIndexChanged
            If Not varIsFirstLoad Then
                CMDpost.Editor.FillDepartement(varDataProperties, CboDepartement, CboCompany)
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the BtnSave button. When clicked, it calls the Save() method to save the current position data.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            Call Save()
        End Sub

        ''' <summary>
        ''' Handles the EventFileSave event from the ComponentMainframeMenu. When triggered, it calls the Save() method to save the current position data.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub ComponentMainframeMenu_EventFileSave() Handles ComponentMainframeMenu.EventFileSave
            Call Save()
        End Sub

        ''' <summary>
        ''' Handles the EventFileUndoAll event from the ComponentMainframeMenu. When triggered, it prompts the user to confirm if they want to undo all changes. If confirmed, it either clears the input fields for a new position or resets the position description for an existing position.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub ComponentMainframeMenu_EventFileUndoAll() Handles ComponentMainframeMenu.EventFileUndoAll
            If Decision(My.Application.Info.AssemblyName, "Do you want to undo all changes?", LibApp.Ingrid.Global.PopupType.UndoChanges, "", CMCv.UI.Canvas.FRMdialogBox.MessageIcon.Question, CMCv.UI.Canvas.FRMdialogBox.MessageTypes.YesNo) = DialogResult.Yes Then
                If (varDataProperties.EmployeePositionIsNew) Then
                    CboCompany.SelectedIndex = -1
                    CboDepartement.SelectedIndex = -1
                    TxtPositionCode.Clear()
                    TxtPositionName.Clear()
                    TxtPositionDescription.Clear()
                Else
                    Call LoadData()
                End If
            End If
        End Sub
    End Class
End Namespace