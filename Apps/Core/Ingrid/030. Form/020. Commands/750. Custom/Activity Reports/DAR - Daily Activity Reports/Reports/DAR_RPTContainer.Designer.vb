<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DAR_RPTContainer
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.EmployeeactivityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DAR_RDS = New DAR_RDS()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        CType(Me.EmployeeactivityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAR_RDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Rv_
        '
        Me.Rv_.BackColor = System.Drawing.Color.PowderBlue
        ReportDataSource1.Name = "employeeactivity"
        ReportDataSource1.Value = Me.EmployeeactivityBindingSource
        Me.Rv_.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Rv_.LocalReport.ReportEmbeddedResource = "ingrid.DAR_RContent.rdlc"
        Me.Rv_.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual
        Me.Rv_.PromptAreaCollapsed = True
        Me.Rv_.ShowBackButton = False
        Me.Rv_.ShowContextMenu = False
        Me.Rv_.ShowCredentialPrompts = False
        Me.Rv_.ShowDocumentMapButton = False
        Me.Rv_.ShowFindControls = False
        Me.Rv_.TabStop = False
        Me.Rv_.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'EmployeeactivityBindingSource
        '
        Me.EmployeeactivityBindingSource.DataMember = "employeeactivity"
        Me.EmployeeactivityBindingSource.DataSource = Me.DAR_RDS
        '
        'DAR_RDS
        '
        Me.DAR_RDS.DataSetName = "DAR_RDS"
        Me.DAR_RDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DAR_RPTContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Name = "DAR_RPTContainer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        CType(Me.EmployeeactivityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAR_RDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EmployeeactivityBindingSource As BindingSource
    Friend WithEvents DAR_RDS As DAR_RDS
End Class
