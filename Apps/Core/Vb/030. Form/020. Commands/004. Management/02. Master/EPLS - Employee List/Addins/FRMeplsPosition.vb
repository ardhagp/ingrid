Namespace UI.Canvas
    Public Class FRMeplsPosition
#Region "Declaration"
        Public Event EventRecordSelected()

        ' This Module Identifier
        Private varThisModuleId As Long = 0
        Private Const varThisModuleCode As String = "POST"
#End Region

#Region "Subs Collections"
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="forcerefresh"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GetData(Optional forcerefresh As Boolean = False)
            CMDepls.Addins.Browse.Position.DisplayData(varDataProperties, DgnAddinPosition, SLFStatus, TxtFind, forcerefresh)
        End Sub
#End Region

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
            If DgnAddinPosition.RowCount = 0 Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
            Else
                With DgnAddinPosition.CurrentRow
                    SetValue(varDataProperties.AllParameters, tCompany.P_CompanyName, .Cells(tCompany.C_CompanyName).Value.ToString)
                    SetValue(varDataProperties.AllParameters, tDepartment.P_DepartmentName, .Cells(tDepartment.C_DepartmentName).Value.ToString)
                    SetValue(varDataProperties.AllParameters, tPosition.P_PositionId, CLng(.Cells(tPosition.C_PositionId).Value))
                    SetValue(varDataProperties.AllParameters, tPosition.P_PositionName, .Cells(tPosition.C_PositionName).Value.ToString)
                End With
                RaiseEvent EventRecordSelected()
                Me.Close()
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMeplsPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Call GetData()
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
        End Sub
    End Class
End Namespace