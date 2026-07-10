Namespace UI.Canvas
    Public Class FRMuacEmployee
#Region "Declaration"
        Public Event EventRecordSelected()

        'Private Const pEmployeeId As String = "@EmployeeId"
        Private Const pEmployeeNumber As String = "@EmployeeNumber"
        Private Const pEmployeeFullName As String = "@EmployeeFullName"
#End Region

#Region "Subs Collections"
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GetRowID()
            varDataProperties.EmployeeId = 0
            If DgnAddinEmployee.RowCount > 0 Then
                varDataProperties.EmployeeId = CLng(DgnAddinEmployee.CurrentRow.Cells(tEmployee.C_EmployeeId).Value)
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GetData(Optional forcerefresh As Boolean = False)
            CMDuac.Addins.Browse.Employee.DisplayData(varDataProperties, DgnAddinEmployee, SLFStatus, TxtFind, forcerefresh)
        End Sub

#End Region

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMuacEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Call GetData()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
            If DgnAddinEmployee.RowCount = 0 Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
            Else
                With DgnAddinEmployee.CurrentRow
                    SetValue(varDataProperties.AllParameters, tEmployee.P_EmployeeId, CLng(.Cells(tEmployee.C_EmployeeId).Value))
                    SetValue(varDataProperties.AllParameters, tEmployee.P_EmployeeNumber, .Cells(tEmployee.C_EmployeeNumber).Value)
                    SetValue(varDataProperties.AllParameters, tEmployee.P_EmployeeFullName, .Cells(tEmployee.C_EmployeeFullName).Value)
                End With
                RaiseEvent EventRecordSelected()
                Me.Close()
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
            Me.Close()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
            If e.KeyCode = Keys.Enter Then
                Call GetData()
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            TxtFind.Clear()
            Call GetData(True)
            TxtFind.ClearSearch()
        End Sub
    End Class
End Namespace