Imports System.Runtime.Versioning

Namespace UI
    Public Class FRMeplsPosition
#Region "Declaration"
        Public Event EventRecordSelected()

        'Parameters
        Private Const pCompanyName As String = "@CompanyName"
        Private Const pDepartmentName As String = "@DepartmentName"
#End Region

#Region "Subs Collections"
        Private Sub GetRowID()
            varDataProperties.EmployeeId = "-1"
            If DgnAddinPosition.RowCount > 0 Then
                varDataProperties.EmployeeId = DgnAddinPosition.CurrentRow.Cells("employee_id").Value.ToString
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub GetData(Optional forcerefresh As Boolean = False)
            CMDepls.Addins.Browse.Position.DisplayData(varDataProperties, DgnAddinPosition, SLFStatus, TxtFind, forcerefresh)
        End Sub
#End Region

        Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
            If DgnAddinPosition.RowCount = 0 Then
                Decision(My.Application.Info.AssemblyName.toupper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.FRMdialogbox.MessageIcon.Error, CMCv.FRMdialogbox.MessageTypes.OkOnly)
            Else
                With DgnAddinPosition.CurrentRow
                    varDataProperties.AllParameters.Remove(pCompanyName)
                    varDataProperties.AllParameters.Add(pCompanyName, .Cells("company_name").Value.ToString)
                    varDataProperties.AllParameters.Remove(pDepartmentName)
                    varDataProperties.AllParameters.Add(pDepartmentName, .Cells("departement_name").Value.ToString)
                    varDataProperties.Field03 = .Cells("position_id").Value
                    varDataProperties.Field04 = .Cells("position_name").Value
                End With
                RaiseEvent EventRecordSelected()
                Me.Close()
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub FRMeplsPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Call GetData()
        End Sub

        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            Me.Close()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
            If e.KeyCode = Keys.Enter Then
                Call GetData()
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            TxtFind.Clear()
            Call GetData(True)
        End Sub
    End Class
End Namespace