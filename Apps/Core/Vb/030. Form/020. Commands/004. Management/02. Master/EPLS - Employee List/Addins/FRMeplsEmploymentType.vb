Namespace UI.Canvas
    Public Class FRMeplsEmploymentType
        ' ----------------------------------------------------------
        ' Variables
        ' ----------------------------------------------------------
        Public Event EventRecordSelected()

        ' This Module Identifier
        Private varThisModuleId As Long = 0
        Private Const varThisModuleCode As String = "EPLT"


        ' ----------------------------------------------------------
        ' Forms Events Handlers
        ' ----------------------------------------------------------
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMeplsPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            varDataProperties.EmploymentTypeIsForceRefresh = True
            Call GetData()
            DatagridBehaviour.AdaptiveRowHeight(Me, DgnAddinEmploymentType)
        End Sub


        ' ----------------------------------------------------------
        ' Controls Events Handlers
        ' ----------------------------------------------------------
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
            If DgnAddinEmploymentType.RowCount = 0 Then
                Decision(My.Application.Info.AssemblyName.ToUpper, "No record selected", LibApp.Ingrid.Global.PopupType.Error, "", CMCv.UI.Canvas.FRMdialogbox.MessageIcon.Error, CMCv.UI.Canvas.FRMdialogbox.MessageTypes.OkOnly)
            Else
                With DgnAddinEmploymentType.CurrentRow
                    SetValue(varDataProperties.AllParameters, tEmploymentType.P_EmploymentTypeId, CLng(.Cells(tEmploymentType.C_EmploymentTypeId).Value))
                    SetValue(varDataProperties.AllParameters, tEmploymentType.P_EmploymentTypeCode, .Cells(tEmploymentType.C_EmploymentTypeCode).Value.ToString)
                    SetValue(varDataProperties.AllParameters, tEmploymentType.P_EmploymentTypeName, .Cells(tEmploymentType.C_EmploymentTypeName).Value.ToString)
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
            varDataProperties.EmploymentTypeIsForceRefresh = True
            Call GetData()
        End Sub


        ' ----------------------------------------------------------
        ' Functions and Subroutines
        ' ----------------------------------------------------------
        ''' <summary>
        ''' This function is used to get the data from the database and display it in the datagridview.
        ''' </summary>
        ''' <param name="forcerefresh"></param>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GetData()
            varDataProperties.EmploymentTypeIsForceRefresh = True

            If TxtFind.XOSqlText <> String.Empty Then
                SetValue(varDataProperties.AllParameters, tEmploymentType.P_EmploymentTypeSearch, TxtFind.XOSqlText)
                varDataProperties.EmploymentTypeIsForceRefresh = False
            End If

            CMDepls.Addins.Browse.EmploymentType.DisplayData(varDataProperties, DgnAddinEmploymentType, SLFStatus)
        End Sub
    End Class
End Namespace