Imports System.Runtime.Versioning
Imports Syncfusion.Windows.Forms

Namespace UI
    Public Class FRMccinEditor

#Region "Declaration"
        Public Event EventRecordSaved()
        Const consCompany As String = "man_company"
#End Region

#Region "Subs Collections"
        Private Sub CheckAllInput()
            'Call CheckAllControls()
            TxtCode.Focus()
            TxtName.Focus()
            TxtSearchTerm1.Focus()
            TxtSearchTerm2.Focus()
            TxtDescription.Focus()
            BtnSave.Focus()
        End Sub
#End Region

#Region "Form Events"

        <SupportedOSPlatform("windows")>
        Private Sub FRMccinEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If (varDataProperties.CompanyIsNew) Then
                varDataProperties.CompanyId = "-1"
                ChkAddNew.Visible = True
                ChkAddNew.Checked = False
            Else
                ChkAddNew.Visible = False
                ChkAddNew.Checked = False
                CMDccin.Editor.GetCompanyProperties(varDataProperties, varDatasetIngrid)
                If varDatasetIngrid.Tables(consCompany).Rows.Count > 0 Then
                    With varDatasetIngrid.Tables(consCompany).Rows(0)
                        TxtCode.Text = .Item("company_code").ToString
                        TxtName.Text = .Item("company_name").ToString
                        TxtSearchTerm1.Text = .Item("company_searchterm1").ToString
                        TxtSearchTerm2.Text = .Item("company_searchterm2").ToString
                        TxtDescription.Text = .Item("company_description").ToString
                    End With
                End If
            End If
        End Sub
#End Region

#Region "Component Events"
        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            Me.Close()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            Call CheckAllInput()
            With varDataProperties
                .CompanyCode = TxtCode.XOSQLText
                .CompanyName = TxtName.XOSQLText
                .CompanySearchTerm1 = TxtSearchTerm1.XOSQLText
                .CompanySearchTerm2 = TxtSearchTerm2.XOSQLText
                .CompanyDescription = TxtDescription.XOSQLText
            End With

            If (varDataProperties.CompanyCode = String.Empty) OrElse (varDataProperties.CompanyName = String.Empty) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "Ensure that the Company Code and Company Name fields are properly filled in.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf ((varDataProperties.CompanyIsNew) AndAlso (CMDccin.Editor.IsDuplicate(varDataProperties))) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "This Company Code is already registered.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf (Not (varDataProperties.CompanyIsNew) AndAlso (CMDccin.Editor.IsDuplicate(varDataProperties))) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "The Company Code cannot be used because it is already assigned to another company.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            If (CMDccin.Editor.PushData(varDataProperties)) Then
                UI.FRMmainframe6.Ts_status.Text = "Success"
                RaiseEvent EventRecordSaved()
            Else
                UI.FRMmainframe6.Ts_status.Text = "Failed to save"
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
                Me.Close()
            End If
        End Sub
#End Region

    End Class
End Namespace