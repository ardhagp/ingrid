Imports System.Runtime.Versioning

Namespace UI.Canvas
    Public Class FRMccinEditor

#Region "Declaration"
        Public Event EventRecordSaved()
        Private varDataParameters As New Dictionary(Of String, Object)
        Private Const tCompany As String = "man_company"

        'Parameters
        Private Const pCompanyCode As String = "@CompanyCode"
        Private Const pCompanyName As String = "@CompanyName"
        Private Const pCompanySearchTerm1 As String = "@CompanySearchTerm1"
        Private Const pCompanySearchTerm2 As String = "@CompanySearchTerm2"
        Private Const pCompanyDescription As String = "@CompanyDescription"
#End Region

#Region "Subs Collections"
        <SupportedOSPlatform("windows")>
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
                ChkAddNew.Visible = True
                ChkAddNew.Checked = False
            Else
                ChkAddNew.Visible = False
                ChkAddNew.Checked = False
                CMDccin.Editor.GetCompanyProperties(varDataProperties, varDatasetIngrid)
                If varDatasetIngrid.Tables(tCompany).Rows.Count > 0 Then
                    With varDatasetIngrid.Tables(tCompany).Rows(0)
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
        <SupportedOSPlatform("windows")>
        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            Me.Close()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            Call CheckAllInput()

            With varDataProperties
                .AllParameters.Remove(pCompanyCode)
                .AllParameters.Add(pCompanyCode, TxtCode.XOSqlText)
                .AllParameters.Remove(pCompanyName)
                .AllParameters.Add(pCompanyName, TxtName.XOSqlText)
                .AllParameters.Remove(pCompanySearchTerm1)
                .AllParameters.Add(pCompanySearchTerm1, IIf(TxtSearchTerm1.XOSqlText = String.Empty OrElse TxtSearchTerm1.XOSqlText = "", DBNull.Value, TxtSearchTerm1.XOSqlText))
                .AllParameters.Remove(pCompanySearchTerm2)
                .AllParameters.Add(pCompanySearchTerm2, IIf(TxtSearchTerm2.XOSqlText = String.Empty OrElse TxtSearchTerm2.XOSqlText = "", DBNull.Value, TxtSearchTerm2.XOSqlText))
                .AllParameters.Remove(pCompanyDescription)
                .AllParameters.Add(pCompanyDescription, IIf(TxtDescription.XOSqlText = String.Empty OrElse TxtDescription.XOSqlText = "", DBNull.Value, TxtDescription.XOSqlText))
            End With

            If (varDataProperties.AllParameters(pCompanyCode).ToString = String.Empty) OrElse (varDataProperties.AllParameters(pCompanyName).ToString = String.Empty) Then
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

        Private Sub ClearParameters()
            With varDataProperties
                .AllParameters.Remove("@CompanyCode")
                .AllParameters.Remove("@CompanyName")
                .AllParameters.Remove("@CompanySearchTerm1")
                .AllParameters.Remove("@CompanySearchTerm2")
                .AllParameters.Remove("@CompanyDescription")
            End With
        End Sub
#End Region

    End Class
End Namespace