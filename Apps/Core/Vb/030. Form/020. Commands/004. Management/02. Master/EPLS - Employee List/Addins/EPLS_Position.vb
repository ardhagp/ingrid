Imports System.Runtime.Versioning

Public Class EPLS_Position
#Region "Variables"
    Private _SQL As New Commands.EPLS.Addins.Browse.Position
    Public Event RecordSelected()
#End Region

#Region "Subs Collections"
    Private Sub GETTableID()
        V_FORMAttrib.RowID = "-1"
        If DgnAddinPosition.RowCount > 0 Then
            V_FORMAttrib.RowID = DgnAddinPosition.CurrentRow.Cells("employee_id").Value.ToString
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub GETDATA(Optional ByVal ForceRefresh As Boolean = False)
        Commands.EPLS.Addins.Browse.Position.DISPLAYDATA(DgnAddinPosition, SLFStatus, TxtFind, ForceRefresh)
    End Sub
#End Region

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If DgnAddinPosition.RowCount = 0 Then
            Decision("No record selected", "Error", CMCv.frmDialogBox.MessageIcon.Error, CMCv.frmDialogBox.MessageTypes.OkOnly)
        Else
            With DgnAddinPosition.CurrentRow
                V_FORMAttrib.Field01 = .Cells("company_name").Value
                V_FORMAttrib.Field02 = .Cells("departement_name").Value
                V_FORMAttrib.Field03 = .Cells("position_id").Value
                V_FORMAttrib.Field04 = .Cells("position_name").Value
            End With
            RaiseEvent RecordSelected()
            Me.Close()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub EPLS_Position_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GETDATA()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub TxtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GETDATA()
        End If
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFind.Clear()
        Call GETDATA(True)
    End Sub
End Class
