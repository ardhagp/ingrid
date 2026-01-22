<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMdard
    Inherits CMCv.FRMstandardFind

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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New DataVisualization.Charting.Title()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New DataVisualization.Charting.Title()
        Tbctl1 = New tbctl(components)
        tp_Dashboard = New TabPage()
        tlpUpper = New TableLayoutPanel()
        chrtDaily = New DataVisualization.Charting.Chart()
        tlpMiddle = New TableLayoutPanel()
        chrtMonthly = New DataVisualization.Charting.Chart()
        chrtYearly = New DataVisualization.Charting.Chart()
        PnlFind.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        Tbctl1.SuspendLayout()
        tp_Dashboard.SuspendLayout()
        tlpUpper.SuspendLayout()
        CType(chrtDaily, ComponentModel.ISupportInitialize).BeginInit()
        tlpMiddle.SuspendLayout()
        CType(chrtMonthly, ComponentModel.ISupportInitialize).BeginInit()
        CType(chrtYearly, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlFind
        ' 
        PnlFind.Margin = New Padding(7, 5, 7, 5)
        PnlFind.Size = New Size(1650, 88)
        ' 
        ' BtnClear
        ' 
        BtnClear.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnClear.FlatAppearance.BorderSize = 2
        BtnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
        ' 
        ' TxtFind
        ' 
        TxtFind.Margin = New Padding(7, 5, 7, 5)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New Padding(7, 5, 7, 5)
        pnl_.Size = New Size(1650, 104)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(Tbctl1)
        SLFPanel.Margin = New Padding(7, 5, 7, 5)
        SLFPanel.Size = New Size(1650, 1044)
        SLFPanel.Controls.SetChildIndex(PnlFind, 0)
        SLFPanel.Controls.SetChildIndex(Tbctl1, 0)
        ' 
        ' Tbctl1
        ' 
        Tbctl1.Controls.Add(tp_Dashboard)
        Tbctl1.Dock = DockStyle.Fill
        Tbctl1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Tbctl1.Location = New Point(0, 88)
        Tbctl1.Margin = New Padding(6, 5, 6, 5)
        Tbctl1.Name = "Tbctl1"
        Tbctl1.SelectedIndex = 0
        Tbctl1.Size = New Size(1650, 956)
        Tbctl1.TabIndex = 802
        ' 
        ' tp_Dashboard
        ' 
        tp_Dashboard.AutoScroll = True
        tp_Dashboard.Controls.Add(tlpUpper)
        tp_Dashboard.Location = New Point(4, 41)
        tp_Dashboard.Margin = New Padding(6, 5, 6, 5)
        tp_Dashboard.Name = "tp_Dashboard"
        tp_Dashboard.Padding = New Padding(6, 5, 6, 5)
        tp_Dashboard.Size = New Size(1642, 911)
        tp_Dashboard.TabIndex = 0
        tp_Dashboard.Text = "DASHBOARD"
        tp_Dashboard.UseVisualStyleBackColor = True
        ' 
        ' tlpUpper
        ' 
        tlpUpper.ColumnCount = 1
        tlpUpper.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpUpper.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 33F))
        tlpUpper.Controls.Add(chrtDaily, 0, 0)
        tlpUpper.Controls.Add(tlpMiddle, 0, 1)
        tlpUpper.Dock = DockStyle.Fill
        tlpUpper.Location = New Point(6, 5)
        tlpUpper.Margin = New Padding(6, 5, 6, 5)
        tlpUpper.Name = "tlpUpper"
        tlpUpper.RowCount = 2
        tlpUpper.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        tlpUpper.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        tlpUpper.Size = New Size(1630, 901)
        tlpUpper.TabIndex = 0
        ' 
        ' chrtDaily
        ' 
        ChartArea1.AxisX.MajorGrid.Enabled = False
        ChartArea1.AxisY.MajorGrid.Enabled = False
        ChartArea1.AxisY2.MajorGrid.Enabled = False
        ChartArea1.BackColor = Color.White
        ChartArea1.BackGradientStyle = DataVisualization.Charting.GradientStyle.TopBottom
        ChartArea1.BackSecondaryColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        ChartArea1.BorderColor = Color.DimGray
        ChartArea1.BorderDashStyle = DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea1.BorderWidth = 3
        ChartArea1.Name = "ChartArea1"
        ChartArea1.ShadowOffset = 5
        chrtDaily.ChartAreas.Add(ChartArea1)
        chrtDaily.Dock = DockStyle.Fill
        Legend1.Enabled = False
        Legend1.LegendStyle = DataVisualization.Charting.LegendStyle.Row
        Legend1.Name = "Legend1"
        chrtDaily.Legends.Add(Legend1)
        chrtDaily.Location = New Point(6, 5)
        chrtDaily.Margin = New Padding(6, 5, 6, 5)
        chrtDaily.Name = "chrtDaily"
        chrtDaily.Padding = New Padding(9, 10, 9, 10)
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = DataVisualization.Charting.SeriesChartType.Line
        Series1.CustomProperties = "IsXAxisQuantitative=True, EmptyPointValue=Zero"
        Series1.EmptyPointStyle.Color = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        Series1.EmptyPointStyle.IsValueShownAsLabel = True
        Series1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Series1.IsValueShownAsLabel = True
        Series1.LabelBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        chrtDaily.Series.Add(Series1)
        chrtDaily.Size = New Size(1618, 440)
        chrtDaily.TabIndex = 1
        chrtDaily.TabStop = False
        Title1.DockedToChartArea = "ChartArea1"
        Title1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Title1.ForeColor = Color.SteelBlue
        Title1.IsDockedInsideChartArea = False
        Title1.Name = "DARChartTitle"
        Title1.Text = "Daily (The Last 30 Days)"
        chrtDaily.Titles.Add(Title1)
        ' 
        ' tlpMiddle
        ' 
        tlpMiddle.ColumnCount = 2
        tlpMiddle.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        tlpMiddle.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60F))
        tlpMiddle.Controls.Add(chrtMonthly, 0, 0)
        tlpMiddle.Controls.Add(chrtYearly, 0, 0)
        tlpMiddle.Dock = DockStyle.Fill
        tlpMiddle.Location = New Point(6, 455)
        tlpMiddle.Margin = New Padding(6, 5, 6, 5)
        tlpMiddle.Name = "tlpMiddle"
        tlpMiddle.RowCount = 1
        tlpMiddle.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpMiddle.Size = New Size(1618, 441)
        tlpMiddle.TabIndex = 0
        ' 
        ' chrtMonthly
        ' 
        ChartArea2.AxisX.MajorGrid.Enabled = False
        ChartArea2.AxisY.MajorGrid.Enabled = False
        ChartArea2.BackGradientStyle = DataVisualization.Charting.GradientStyle.TopBottom
        ChartArea2.BackSecondaryColor = Color.MistyRose
        ChartArea2.Name = "ChartArea1"
        chrtMonthly.ChartAreas.Add(ChartArea2)
        chrtMonthly.Dock = DockStyle.Fill
        chrtMonthly.Location = New Point(653, 5)
        chrtMonthly.Margin = New Padding(6, 5, 6, 5)
        chrtMonthly.Name = "chrtMonthly"
        chrtMonthly.Palette = DataVisualization.Charting.ChartColorPalette.Fire
        Series2.ChartArea = "ChartArea1"
        Series2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Series2.LabelBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        Series2.Name = "Series1"
        chrtMonthly.Series.Add(Series2)
        chrtMonthly.Size = New Size(959, 431)
        chrtMonthly.TabIndex = 2
        chrtMonthly.TabStop = False
        Title2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Title2.ForeColor = Color.RoyalBlue
        Title2.Name = "Title1"
        Title2.Text = "Monthly"
        chrtMonthly.Titles.Add(Title2)
        ' 
        ' chrtYearly
        ' 
        ChartArea3.AxisX.MajorGrid.Enabled = False
        ChartArea3.AxisY.MajorGrid.Enabled = False
        ChartArea3.BackGradientStyle = DataVisualization.Charting.GradientStyle.TopBottom
        ChartArea3.BackSecondaryColor = Color.LightGreen
        ChartArea3.BorderColor = Color.Empty
        ChartArea3.BorderDashStyle = DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea3.Name = "ChartArea1"
        chrtYearly.ChartAreas.Add(ChartArea3)
        chrtYearly.Dock = DockStyle.Fill
        chrtYearly.Location = New Point(6, 5)
        chrtYearly.Margin = New Padding(6, 5, 6, 5)
        chrtYearly.Name = "chrtYearly"
        Series3.ChartArea = "ChartArea1"
        Series3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Series3.IsVisibleInLegend = False
        Series3.LabelBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        Series3.Name = "Series1"
        chrtYearly.Series.Add(Series3)
        chrtYearly.Size = New Size(635, 431)
        chrtYearly.TabIndex = 1
        chrtYearly.TabStop = False
        Title3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Title3.ForeColor = Color.OrangeRed
        Title3.Name = "Title1"
        Title3.ShadowColor = Color.CornflowerBlue
        Title3.Text = "Yearly"
        chrtYearly.Titles.Add(Title3)
        ' 
        ' FRMdard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        ClientSize = New Size(1650, 1170)
        KeyPreview = True
        Margin = New Padding(10, 5, 10, 5)
        Name = "FRMdard"
        PnlFind.ResumeLayout(False)
        PnlFind.PerformLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        Tbctl1.ResumeLayout(False)
        tp_Dashboard.ResumeLayout(False)
        tlpUpper.ResumeLayout(False)
        CType(chrtDaily, ComponentModel.ISupportInitialize).EndInit()
        tlpMiddle.ResumeLayout(False)
        CType(chrtMonthly, ComponentModel.ISupportInitialize).EndInit()
        CType(chrtYearly, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Tbctl1 As tbctl
    Friend WithEvents tp_Dashboard As TabPage
    Friend WithEvents tlpUpper As TableLayoutPanel
    Friend WithEvents tlpMiddle As TableLayoutPanel
    Friend WithEvents chrtDaily As DataVisualization.Charting.Chart
    Friend WithEvents chrtYearly As DataVisualization.Charting.Chart
    Friend WithEvents chrtMonthly As DataVisualization.Charting.Chart
End Class
