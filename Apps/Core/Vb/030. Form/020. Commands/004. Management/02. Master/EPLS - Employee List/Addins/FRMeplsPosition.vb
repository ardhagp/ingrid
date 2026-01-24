Imports System.Runtime.Versioning

Public Class FRMeplsPosition
#Region "Variables"
    Public Event EventRecordSelected()
#End Region

#Region "Subs Collections"
    Private Sub GetRowID()
        varFormProperties.RowID = "-1"
        If DgnAddinPosition.RowCount > 0 Then
            varFormProperties.RowID = DgnAddinPosition.CurrentRow.Cells("employee_id").Value.ToString
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub GetData(Optional forcerefresh As Boolean = False)
        CMDepls.Addins.Browse.Position.DisplayData(varDatabaseName, DgnAddinPosition, SLFStatus, TxtFind, forcerefresh)
    End Sub
#End Region

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If DgnAddinPosition.RowCount = 0 Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            With DgnAddinPosition.CurrentRow
                varFormProperties.Field01 = .Cells("company_name").Value
                varFormProperties.Field02 = .Cells("departement_name").Value
                varFormProperties.Field03 = .Cells("position_id").Value
                varFormProperties.Field04 = .Cells("position_name").Value
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
