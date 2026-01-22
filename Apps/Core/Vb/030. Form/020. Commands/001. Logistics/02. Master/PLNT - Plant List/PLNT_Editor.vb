Imports System.Runtime.Versioning

Public Class FRMplntEditor
#Region "Variables"
    Public Event EventRecordSaved()
    Private varIsLoad As Boolean
#End Region

#Region "Sub Collections"
    <SupportedOSPlatform("windows")>
    Private Sub GetCompany()
        Call CMDplnt.Editor.GetCompany(varDatabaseName, varDatabaseEngine, CboCompany)
    End Sub

    Private Sub CheckAllInput()
        CboCompany.Focus()
        TxtPlantCode.Focus()
        TxtPlantName1.Focus()
        TxtPlantName2.Focus()
        TxtCity.Focus()
        TxtPostalCode.Focus()
        TxtDescription.Focus()
        TxtSearchTerm1.Focus()
        TxtSearchTerm2.Focus()
        BtnSave.Focus()
    End Sub
#End Region
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Call CheckAllInput()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub FRMplntEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        varIsLoad = True
        Call GetCompany()
        varIsLoad = False
    End Sub
End Class
