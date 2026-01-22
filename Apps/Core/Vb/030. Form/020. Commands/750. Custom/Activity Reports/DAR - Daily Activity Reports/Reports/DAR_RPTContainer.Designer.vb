<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMdarRptContainer
    Inherits CMCv.Rpt_Bsc

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Rv_ = New Microsoft.Reporting.WinForms.ReportViewer()
        EmployeeactivityBindingSource = New BindingSource(components)
        DAR_RDS = New DAR_RDS()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        CType(EmployeeactivityBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(DAR_RDS, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Rv_
        ' 
        Rv_.Dock = DockStyle.Fill
        Rv_.DocumentMapWidth = 1
        Rv_.Location = New Point(0, 0)
        Rv_.Margin = New Padding(6, 5, 6, 5)
        Rv_.Name = "Rv_"
        Rv_.ServerReport.BearerToken = Nothing
        Rv_.Size = New Size(0, 0)
        Rv_.TabIndex = 996
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Margin = New Padding(10, 17, 10, 17)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(Rv_, 0)
        ' 
        ' EmployeeactivityBindingSource
        ' 
        EmployeeactivityBindingSource.DataMember = "employeeactivity"
        EmployeeactivityBindingSource.DataSource = DAR_RDS
        ' 
        ' DAR_RDS
        ' 
        DAR_RDS.DataSetName = "DAR_RDS"
        DAR_RDS.Namespace = "http://tempuri.org/DAR_RDS.xsd"
        DAR_RDS.SchemaSerializationMode = Data.SchemaSerializationMode.IncludeSchema
        ' 
        ' FRMdarRptContainer
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        ClientSize = New Size(1307, 1078)
        Margin = New Padding(11, 5, 11, 5)
        Name = "FRMdarRptContainer"
        WindowState = FormWindowState.Maximized
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        CType(EmployeeactivityBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(DAR_RDS, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents EmployeeactivityBindingSource As BindingSource
    Friend WithEvents DAR_RDS As DAR_RDS
    Friend WithEvents Rv_ As Microsoft.Reporting.WinForms.ReportViewer
End Class
