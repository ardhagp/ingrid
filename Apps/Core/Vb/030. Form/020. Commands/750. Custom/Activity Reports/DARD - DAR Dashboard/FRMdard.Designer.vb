Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMdard
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
            components = New ComponentModel.Container()
            Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
            Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
            Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
            Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New DataVisualization.Charting.Title()
            Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
            Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
            Dim Title5 As System.Windows.Forms.DataVisualization.Charting.Title = New DataVisualization.Charting.Title()
            Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
            Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
            Dim Title6 As System.Windows.Forms.DataVisualization.Charting.Title = New DataVisualization.Charting.Title()
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
            Tbctl1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
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
            tlpUpper.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
            tlpUpper.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 33.0F))
            tlpUpper.Controls.Add(chrtDaily, 0, 0)
            tlpUpper.Controls.Add(tlpMiddle, 0, 1)
            tlpUpper.Dock = DockStyle.Fill
            tlpUpper.Location = New Point(6, 5)
            tlpUpper.Margin = New Padding(6, 5, 6, 5)
            tlpUpper.Name = "tlpUpper"
            tlpUpper.RowCount = 2
            tlpUpper.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
            tlpUpper.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
            tlpUpper.Size = New Size(1630, 901)
            tlpUpper.TabIndex = 0
            ' 
            ' chrtDaily
            ' 
            ChartArea4.AxisX.MajorGrid.Enabled = False
            ChartArea4.AxisY.MajorGrid.Enabled = False
            ChartArea4.AxisY2.MajorGrid.Enabled = False
            ChartArea4.BackColor = Color.White
            ChartArea4.BackGradientStyle = DataVisualization.Charting.GradientStyle.TopBottom
            ChartArea4.BackSecondaryColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
            ChartArea4.BorderColor = Color.DimGray
            ChartArea4.BorderDashStyle = DataVisualization.Charting.ChartDashStyle.Solid
            ChartArea4.BorderWidth = 3
            ChartArea4.Name = "ChartArea1"
            ChartArea4.ShadowOffset = 5
            chrtDaily.ChartAreas.Add(ChartArea4)
            chrtDaily.Dock = DockStyle.Fill
            Legend2.Enabled = False
            Legend2.LegendStyle = DataVisualization.Charting.LegendStyle.Row
            Legend2.Name = "Legend1"
            chrtDaily.Legends.Add(Legend2)
            chrtDaily.Location = New Point(6, 5)
            chrtDaily.Margin = New Padding(6, 5, 6, 5)
            chrtDaily.Name = "chrtDaily"
            chrtDaily.Padding = New Padding(9, 10, 9, 10)
            Series4.ChartArea = "ChartArea1"
            Series4.ChartType = DataVisualization.Charting.SeriesChartType.Line
            Series4.CustomProperties = "IsXAxisQuantitative=True, EmptyPointValue=Zero"
            Series4.EmptyPointStyle.Color = Color.FromArgb(CByte(255), CByte(192), CByte(255))
            Series4.EmptyPointStyle.IsValueShownAsLabel = True
            Series4.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
            Series4.IsValueShownAsLabel = True
            Series4.LabelBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
            Series4.Legend = "Legend1"
            Series4.Name = "Series1"
            chrtDaily.Series.Add(Series4)
            chrtDaily.Size = New Size(1618, 440)
            chrtDaily.TabIndex = 1
            chrtDaily.TabStop = False
            Title4.DockedToChartArea = "ChartArea1"
            Title4.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
            Title4.ForeColor = Color.SteelBlue
            Title4.IsDockedInsideChartArea = False
            Title4.Name = "DARChartTitle"
            Title4.Text = "Daily (The Last 30 Days)"
            chrtDaily.Titles.Add(Title4)
            ' 
            ' tlpMiddle
            ' 
            tlpMiddle.ColumnCount = 2
            tlpMiddle.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40.0F))
            tlpMiddle.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60.0F))
            tlpMiddle.Controls.Add(chrtMonthly, 0, 0)
            tlpMiddle.Controls.Add(chrtYearly, 0, 0)
            tlpMiddle.Dock = DockStyle.Fill
            tlpMiddle.Location = New Point(6, 455)
            tlpMiddle.Margin = New Padding(6, 5, 6, 5)
            tlpMiddle.Name = "tlpMiddle"
            tlpMiddle.RowCount = 1
            tlpMiddle.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
            tlpMiddle.Size = New Size(1618, 441)
            tlpMiddle.TabIndex = 0
            ' 
            ' chrtMonthly
            ' 
            ChartArea5.AxisX.MajorGrid.Enabled = False
            ChartArea5.AxisY.MajorGrid.Enabled = False
            ChartArea5.BackGradientStyle = DataVisualization.Charting.GradientStyle.TopBottom
            ChartArea5.BackSecondaryColor = Color.MistyRose
            ChartArea5.Name = "ChartArea1"
            chrtMonthly.ChartAreas.Add(ChartArea5)
            chrtMonthly.Dock = DockStyle.Fill
            chrtMonthly.Location = New Point(653, 5)
            chrtMonthly.Margin = New Padding(6, 5, 6, 5)
            chrtMonthly.Name = "chrtMonthly"
            chrtMonthly.Palette = DataVisualization.Charting.ChartColorPalette.Fire
            Series5.ChartArea = "ChartArea1"
            Series5.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
            Series5.LabelBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
            Series5.Name = "Series1"
            chrtMonthly.Series.Add(Series5)
            chrtMonthly.Size = New Size(959, 431)
            chrtMonthly.TabIndex = 2
            chrtMonthly.TabStop = False
            Title5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
            Title5.ForeColor = Color.RoyalBlue
            Title5.Name = "Title1"
            Title5.Text = "Monthly"
            chrtMonthly.Titles.Add(Title5)
            ' 
            ' chrtYearly
            ' 
            ChartArea6.AxisX.MajorGrid.Enabled = False
            ChartArea6.AxisY.MajorGrid.Enabled = False
            ChartArea6.BackGradientStyle = DataVisualization.Charting.GradientStyle.TopBottom
            ChartArea6.BackSecondaryColor = Color.LightGreen
            ChartArea6.BorderColor = Color.Empty
            ChartArea6.BorderDashStyle = DataVisualization.Charting.ChartDashStyle.Solid
            ChartArea6.Name = "ChartArea1"
            chrtYearly.ChartAreas.Add(ChartArea6)
            chrtYearly.Dock = DockStyle.Fill
            chrtYearly.Location = New Point(6, 5)
            chrtYearly.Margin = New Padding(6, 5, 6, 5)
            chrtYearly.Name = "chrtYearly"
            Series6.ChartArea = "ChartArea1"
            Series6.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
            Series6.IsVisibleInLegend = False
            Series6.LabelBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
            Series6.Name = "Series1"
            chrtYearly.Series.Add(Series6)
            chrtYearly.Size = New Size(635, 431)
            chrtYearly.TabIndex = 1
            chrtYearly.TabStop = False
            Title6.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
            Title6.ForeColor = Color.OrangeRed
            Title6.Name = "Title1"
            Title6.ShadowColor = Color.CornflowerBlue
            Title6.Text = "Yearly"
            chrtYearly.Titles.Add(Title6)
            ' 
            ' FRMdard
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
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
End Namespace