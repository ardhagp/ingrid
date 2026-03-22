Imports System.Runtime.Versioning

Namespace UI
    Public Class FRMplntEditor
#Region "Declaration"
        Public Event EventRecordSaved()
        Private varIsLoad As Boolean
        Private Shared consTableName As String = "mat_plant"
#End Region

#Region "Sub Collections"
        <SupportedOSPlatform("windows")>
        Private Sub FillCompany(company As CMCv.UI.Control.cbo)
            Call CMDplnt.Editor.FillCompany(varDataProperties, company)
        End Sub

        Private Sub CheckAllInput()
            TxtPlantName.Focus()
            TxtDescription.Focus()
            TxtSearchTerm1.Focus()
            TxtSearchTerm2.Focus()
            TxtAddress.Focus()
            TxtPostalCode.Focus()
            BtnSave.Focus()
        End Sub
#End Region
        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            Call CheckAllInput()
            With varDataProperties
                .CompanyId = CboCompany.SelectedValue.ToString
                .PlantCode = TxtPlantCode.XOSQLText
                .PlantName = TxtPlantName.XOSQLText
                .PlantSearchTerm1 = TxtSearchTerm1.XOSQLText
                .PlantSearchTerm2 = TxtSearchTerm2.XOSQLText
                .PlantDescription = TxtDescription.XOSQLText
                .PlantAddress = TxtAddress.XOSQLText
                .PlantPostalCode = TxtPostalCode.XOSQLText
            End With

            If (CboCompany.Items.Count = 0) AndAlso (varDataProperties.PlantCode = String.Empty) AndAlso (varDataProperties.PlantName = String.Empty) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "Make sure you have Company selected, Plant Code and Plant Name are properly filled.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf (varDataProperties.PlantIsNew) AndAlso (CMDplnt.Editor.IsDuplicate(varDataProperties)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "This Plant Code is already registered.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            ElseIf Not (varDataProperties.PlantIsNew) AndAlso (CMDplnt.Editor.IsDuplicate(varDataProperties)) Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "Cannot save your record." & Environment.NewLine & "The Plant Code cannot be used because it is already assigned to another plant.", LibApp.Ingrid.Global.PopupType.Alert, "", FRMdialogbox.MessageIcon.Alert, FRMdialogbox.MessageTypes.OkOnly)
                Return
            End If

            If (CMDplnt.Editor.PushData(varDataProperties)) Then
                UI.FRMmainframe6.Ts_status.Text = "Success"
                RaiseEvent EventRecordSaved()
            Else
                UI.FRMmainframe6.Ts_status.Text = "Failed to save"
                Return
            End If

            If ChkAddNew.Checked Then
                CboCompany.SelectedIndex = 0
                TxtPlantCode.Clear()
                TxtPlantName.Clear()
                TxtSearchTerm1.Clear()
                TxtSearchTerm2.Clear()
                TxtDescription.Clear()
                TxtAddress.Clear()
                TxtPostalCode.Clear()
                TxtPlantCode.Focus()
            Else
                Me.Close()
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub FRMplntEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Call FillCompany(CboCompany)
            If varDataProperties.PlantId = "-1" Then
                ChkAddNew.Visible = True
                ChkAddNew.Checked = False
            Else
                ChkAddNew.Visible = False
                ChkAddNew.Checked = False
                CMDplnt.Editor.GetPlantProperties(varDataProperties, varDatasetIngrid)
                If varDatasetIngrid.Tables(consTableName).Rows.Count > 0 Then
                    With varDatasetIngrid.Tables(consTableName).Rows(0)
                        CboCompany.SelectedValue = .Item("plant_company").ToString
                        TxtPlantCode.Text = .Item("plant_code").ToString
                        TxtPlantName.Text = .Item("plant_name").ToString
                        TxtSearchTerm1.Text = .Item("plant_searchterm1").ToString
                        TxtSearchTerm2.Text = .Item("plant_searchterm2").ToString
                        TxtDescription.Text = .Item("plant_description").ToString
                        TxtAddress.Text = .Item("plant_address").ToString
                        TxtPostalCode.Text = .Item("plant_postalcode").ToString
                    End With
                End If
            End If

        End Sub

        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            Me.Close()
        End Sub
    End Class
End Namespace