<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DARD
    Inherits CMCv.Std_Fi

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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.Tbctl1 = New CMCv.tbctl(Me.components)
        Me.tp_Dashboard = New System.Windows.Forms.TabPage()
        Me.tlpUpper = New System.Windows.Forms.TableLayoutPanel()
        Me.chrtDaily = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.chrtMonthly = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chrtYearly = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PnlFind.SuspendLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_.SuspendLayout()
        Me.SLFPanel.SuspendLayout()
        Me.Tbctl1.SuspendLayout()
        Me.tp_Dashboard.SuspendLayout()
        Me.tlpUpper.SuspendLayout()
        CType(Me.chrtDaily, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        CType(Me.chrtMonthly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrtYearly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlFind
        '
        Me.PnlFind.Size = New System.Drawing.Size(990, 46)
        '
        'BtnClear
        '
        Me.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClear.FlatAppearance.BorderSize = 2
        Me.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        '
        'pnl_
        '
        Me.pnl_.Size = New System.Drawing.Size(990, 54)
        '
        'SLFPanel
        '
        Me.SLFPanel.Controls.Add(Me.Tbctl1)
        Me.SLFPanel.Size = New System.Drawing.Size(990, 657)
        Me.SLFPanel.Controls.SetChildIndex(Me.PnlFind, 0)
        Me.SLFPanel.Controls.SetChildIndex(Me.Tbctl1, 0)
        '
        'Tbctl1
        '
        Me.Tbctl1.Controls.Add(Me.tp_Dashboard)
        Me.Tbctl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tbctl1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Tbctl1.Location = New System.Drawing.Point(0, 46)
        Me.Tbctl1.Name = "Tbctl1"
        Me.Tbctl1.SelectedIndex = 0
        Me.Tbctl1.Size = New System.Drawing.Size(990, 611)
        Me.Tbctl1.TabIndex = 802
        '
        'tp_Dashboard
        '
        Me.tp_Dashboard.AutoScroll = True
        Me.tp_Dashboard.Controls.Add(Me.tlpUpper)
        Me.tp_Dashboard.Location = New System.Drawing.Point(4, 30)
        Me.tp_Dashboard.Name = "tp_Dashboard"
        Me.tp_Dashboard.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_Dashboard.Size = New System.Drawing.Size(982, 577)
        Me.tp_Dashboard.TabIndex = 0
        Me.tp_Dashboard.Text = "DASHBOARD"
        Me.tp_Dashboard.UseVisualStyleBackColor = True
        '
        'tlpUpper
        '
        Me.tlpUpper.ColumnCount = 1
        Me.tlpUpper.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpUpper.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpUpper.Controls.Add(Me.chrtDaily, 0, 0)
        Me.tlpUpper.Controls.Add(Me.tlpMiddle, 0, 1)
        Me.tlpUpper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpUpper.Location = New System.Drawing.Point(3, 3)
        Me.tlpUpper.Name = "tlpUpper"
        Me.tlpUpper.RowCount = 2
        Me.tlpUpper.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpUpper.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpUpper.Size = New System.Drawing.Size(976, 571)
        Me.tlpUpper.TabIndex = 0
        '
        'chrtDaily
        '
        ChartArea1.AxisX.MajorGrid.Enabled = False
        ChartArea1.AxisY.MajorGrid.Enabled = False
        ChartArea1.AxisY2.MajorGrid.Enabled = False
        ChartArea1.BackColor = System.Drawing.Color.White
        ChartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        ChartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ChartArea1.BorderColor = System.Drawing.Color.DimGray
        ChartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea1.BorderWidth = 3
        ChartArea1.Name = "ChartArea1"
        ChartArea1.ShadowOffset = 5
        Me.chrtDaily.ChartAreas.Add(ChartArea1)
        Me.chrtDaily.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Enabled = False
        Legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row
        Legend1.Name = "Legend1"
        Me.chrtDaily.Legends.Add(Legend1)
        Me.chrtDaily.Location = New System.Drawing.Point(3, 3)
        Me.chrtDaily.Name = "chrtDaily"
        Me.chrtDaily.Padding = New System.Windows.Forms.Padding(5)
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.CustomProperties = "IsXAxisQuantitative=True, EmptyPointValue=Zero"
        Series1.EmptyPointStyle.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Series1.EmptyPointStyle.IsValueShownAsLabel = True
        Series1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.LabelBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chrtDaily.Series.Add(Series1)
        Me.chrtDaily.Size = New System.Drawing.Size(970, 279)
        Me.chrtDaily.TabIndex = 1
        Me.chrtDaily.TabStop = False
        Title1.DockedToChartArea = "ChartArea1"
        Title1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.ForeColor = System.Drawing.Color.SteelBlue
        Title1.IsDockedInsideChartArea = False
        Title1.Name = "DARChartTitle"
        Title1.Text = "Daily (The Last 30 Days)"
        Me.chrtDaily.Titles.Add(Title1)
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 2
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tlpMiddle.Controls.Add(Me.chrtMonthly, 0, 0)
        Me.tlpMiddle.Controls.Add(Me.chrtYearly, 0, 0)
        Me.tlpMiddle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMiddle.Location = New System.Drawing.Point(3, 288)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 1
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(970, 280)
        Me.tlpMiddle.TabIndex = 0
        '
        'chrtMonthly
        '
        ChartArea2.AxisX.MajorGrid.Enabled = False
        ChartArea2.AxisY.MajorGrid.Enabled = False
        ChartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        ChartArea2.BackSecondaryColor = System.Drawing.Color.MistyRose
        ChartArea2.Name = "ChartArea1"
        Me.chrtMonthly.ChartAreas.Add(ChartArea2)
        Me.chrtMonthly.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chrtMonthly.Location = New System.Drawing.Point(391, 3)
        Me.chrtMonthly.Name = "chrtMonthly"
        Me.chrtMonthly.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire
        Series2.ChartArea = "ChartArea1"
        Series2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.LabelBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Series2.Name = "Series1"
        Me.chrtMonthly.Series.Add(Series2)
        Me.chrtMonthly.Size = New System.Drawing.Size(576, 274)
        Me.chrtMonthly.TabIndex = 2
        Me.chrtMonthly.TabStop = False
        Title2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.ForeColor = System.Drawing.Color.RoyalBlue
        Title2.Name = "Title1"
        Title2.Text = "Monthly"
        Me.chrtMonthly.Titles.Add(Title2)
        '
        'chrtYearly
        '
        ChartArea3.AxisX.MajorGrid.Enabled = False
        ChartArea3.AxisY.MajorGrid.Enabled = False
        ChartArea3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        ChartArea3.BackSecondaryColor = System.Drawing.Color.LightGreen
        ChartArea3.BorderColor = System.Drawing.Color.Empty
        ChartArea3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea3.Name = "ChartArea1"
        Me.chrtYearly.ChartAreas.Add(ChartArea3)
        Me.chrtYearly.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chrtYearly.Location = New System.Drawing.Point(3, 3)
        Me.chrtYearly.Name = "chrtYearly"
        Series3.ChartArea = "ChartArea1"
        Series3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series3.IsVisibleInLegend = False
        Series3.LabelBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Series3.Name = "Series1"
        Me.chrtYearly.Series.Add(Series3)
        Me.chrtYearly.Size = New System.Drawing.Size(382, 274)
        Me.chrtYearly.TabIndex = 1
        Me.chrtYearly.TabStop = False
        Title3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title3.ForeColor = System.Drawing.Color.OrangeRed
        Title3.Name = "Title1"
        Title3.ShadowColor = System.Drawing.Color.CornflowerBlue
        Title3.Text = "Yearly"
        Me.chrtYearly.Titles.Add(Title3)
        '
        'DARD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(990, 733)
        Me.Name = "DARD"
        Me.PnlFind.ResumeLayout(False)
        Me.PnlFind.PerformLayout()
        CType(Me.SLFLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_.ResumeLayout(False)
        Me.pnl_.PerformLayout()
        Me.SLFPanel.ResumeLayout(False)
        Me.Tbctl1.ResumeLayout(False)
        Me.tp_Dashboard.ResumeLayout(False)
        Me.tlpUpper.ResumeLayout(False)
        CType(Me.chrtDaily, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        CType(Me.chrtMonthly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrtYearly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tbctl1 As CMCv.tbctl
    Friend WithEvents tp_Dashboard As TabPage
    Friend WithEvents tlpUpper As TableLayoutPanel
    Friend WithEvents tlpMiddle As TableLayoutPanel
    Friend WithEvents chrtDaily As DataVisualization.Charting.Chart
    Friend WithEvents chrtYearly As DataVisualization.Charting.Chart
    Friend WithEvents chrtMonthly As DataVisualization.Charting.Chart
End Class
