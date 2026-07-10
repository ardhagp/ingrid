Namespace UI.Canvas
    Public Class FRMccinEditor

#Region "Declaration"
        Public Event EventRecordSaved()

        ' This Module Identifier
        Private varThisModuleId As Long = 0
        Private Const varThisModuleCode As String = "CCIN"
#End Region

#Region "Subs Collections"
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub CheckAllInput()
            TxtCode.Focus()
            TxtName.Focus()
            TxtSearchTerm1.Focus()
            TxtSearchTerm2.Focus()
            TxtDescription.Focus()
            BtnSave.Focus()
        End Sub
#End Region

#Region "Form Events"

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMccinEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If (varDataProperties.CompanyIsNew) Then
                ChkAddNew.Visible = True
                ChkAddNew.Checked = False
            Else
                ChkAddNew.Visible = False
                ChkAddNew.Checked = False
                CMDccin.Editor.GetCompanyProperties(varDataProperties, varDatasetIngrid)
                If varDatasetIngrid.Tables(tCompany.TableName).Rows.Count > 0 Then
                    With varDatasetIngrid.Tables(tCompany.TableName).Rows(0)
                        TxtCode.Text = .Item(tCompany.C_CompanyCode).ToString
                        TxtName.Text = .Item(tCompany.C_CompanyName).ToString
                        TxtSearchTerm1.Text = .Item(tCompany.C_SearchTerm1).ToString
                        TxtSearchTerm2.Text = .Item(tCompany.C_SearchTerm2).ToString
                        TxtDescription.Text = .Item(tCompany.C_Description).ToString
                    End With
                End If
            End If
        End Sub
#End Region

#Region "Component Events"
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            Me.Close()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            Call CheckAllInput()

            With varDataProperties
                SetValue(.AllParameters, tCompany.P_CompanyCode, TxtCode.XOSqlText)
                SetValue(.AllParameters, tCompany.P_CompanyName, TxtName.XOSqlText)
                SetValue(.AllParameters, tCompany.P_SearchTerm1, IIf(TxtSearchTerm1.XOSqlText = String.Empty OrElse TxtSearchTerm1.XOSqlText = "", DBNull.Value, TxtSearchTerm1.XOSqlText))
                SetValue(.AllParameters, tCompany.P_SearchTerm2, IIf(TxtSearchTerm2.XOSqlText = String.Empty OrElse TxtSearchTerm2.XOSqlText = "", DBNull.Value, TxtSearchTerm2.XOSqlText))
                SetValue(.AllParameters, tCompany.P_Description, IIf(TxtDescription.XOSqlText = String.Empty OrElse TxtDescription.XOSqlText = "", DBNull.Value, TxtDescription.XOSqlText))
            End With

            If (varDataProperties.AllParameters(tCompany.P_CompanyCode).ToString = String.Empty) OrElse (varDataProperties.AllParameters(tCompany.P_CompanyName).ToString = String.Empty) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "Ensure that the Company Code and Company Name fields are properly filled in.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Call ClearParameters()
                Return
            ElseIf ((varDataProperties.CompanyIsNew) AndAlso (CMDccin.Editor.IsDuplicate(varDataProperties))) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "This Company Code is already registered.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
                Call ClearParameters()
                Return
            ElseIf (Not (varDataProperties.CompanyIsNew) AndAlso (CMDccin.Editor.IsDuplicate(varDataProperties))) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "The Company Code cannot be used because it is already assigned to another company.", LibApp.Ingrid.Global.PopupType.Alert, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Alert, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
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

        ''' <summary>
        ''' 
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub ClearParameters()
            With varDataProperties
                .AllParameters.Remove(tCompany.P_CompanyCode)
                .AllParameters.Remove(tCompany.P_CompanyName)
                .AllParameters.Remove(tCompany.P_SearchTerm1)
                .AllParameters.Remove(tCompany.P_SearchTerm2)
                .AllParameters.Remove(tCompany.P_Description)
            End With
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMccinEditor_Activated(sender As Object, e As EventArgs) Handles Me.Activated
            ' Set active module to UserParameters
            SetValue(varDataProperties.UserParameters, tModule.P_ModuleId, varThisModuleId)
            SetValue(varDataProperties.UserParameters, tModule.P_ModuleCode, varThisModuleCode)
        End Sub
#End Region

    End Class
End Namespace