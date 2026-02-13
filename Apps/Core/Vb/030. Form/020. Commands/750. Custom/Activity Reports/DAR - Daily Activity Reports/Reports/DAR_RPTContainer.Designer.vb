Namespace UI
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
            components = New ComponentModel.Container()
            Rv_ = New Microsoft.Reporting.WinForms.ReportViewer()
            EmployeeactivityBindingSource = New BindingSource(components)
            DAR_RDS = New UI.DAR_RDS()
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
            Rv_.Location = New Point(0, 0)
            Rv_.Margin = New Padding(4, 3, 4, 3)
            Rv_.Name = "Rv_"
            Rv_.ServerReport.BearerToken = Nothing
            Rv_.Size = New Size(915, 506)
            Rv_.TabIndex = 996
            ' 
            ' PnlBottomButton
            ' 
            PnlBottomButton.Location = New Point(0, 506)
            ' 
            ' SLFPanel
            ' 
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
            ' DAR_RPTContainer
            ' 
            AutoScaleDimensions = New SizeF(7.0F, 15.0F)
            ClientSize = New Size(915, 647)
            Margin = New Padding(8, 3, 8, 3)
            Name = "DAR_RPTContainer"
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
        Friend WithEvents DAR_RDS As UI.DAR_RDS
    End Class
End Namespace