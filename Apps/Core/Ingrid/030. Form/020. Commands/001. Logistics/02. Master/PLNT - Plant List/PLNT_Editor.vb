Imports CMCv
Imports System.Windows.Forms

Public Class PLNT_Editor
#Region "Variables"
    Public Event RecordSaved()
    Private _SQL As New LibSQL.Commands.PLNT.Editor
    Private IsLoad As Boolean
#End Region

#Region "Sub Collections"
    Private Sub GETCompany()
        Call _SQL.GETCompany(CboCompany)
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

    Private Sub PLNT_Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsLoad = True
        Call GETCompany()
        IsLoad = False
    End Sub
End Class
