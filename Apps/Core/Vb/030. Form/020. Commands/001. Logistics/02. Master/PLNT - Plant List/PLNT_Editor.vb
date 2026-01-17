Imports System.Runtime.Versioning

Public Class PLNT_Editor
#Region "Variables"
    Public Event RecordSaved()
    Private V_SQL As New LibSQL.Commands.PLNT.Editor
    Private V_IsLoad As Boolean
#End Region

#Region "Sub Collections"
    <SupportedOSPlatform("windows")>
    Private Sub GETCompany()
        Call Commands.PLNT.Editor.GETCompany(varDatabaseEngine, CboCompany)
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
    Private Sub PLNT_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        V_IsLoad = True
        Call GETCompany()
        V_IsLoad = False
    End Sub
End Class
