Public Class DARD
    Private _SQL As New LibSQL.Commands.DARD.View

    Private Sub DARD_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call GETChart()
    End Sub

    ''' <summary>
    ''' Load chart data
    ''' </summary>
    Private Sub GETChart()
        _SQL.GETDailyStatistic(chrtDaily)
        chrtDaily.Series("Series1").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        chrtDaily.Series("Series1").IsValueShownAsLabel = True
        chrtDaily.BorderlineWidth = 2
        chrtDaily.BorderColor = Color.MidnightBlue
        chrtDaily.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.All
        chrtDaily.Series("Series1").BorderColor = Color.Red
        chrtDaily.Series("Series1").BorderWidth = 5

        _SQL.GETYearlyStatistic(chrtYearly)
        chrtYearly.Series("Series1").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
        chrtYearly.Series("Series1").IsValueShownAsLabel = True
        chrtYearly.BorderColor = Color.MidnightBlue
        chrtYearly.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.All

        _SQL.GETMonthlyStatistic(chrtMonthly)
        chrtMonthly.Series("Series1").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
        chrtMonthly.Series("Series1").IsValueShownAsLabel = True
        chrtMonthly.BorderColor = Color.MidnightBlue
        chrtMonthly.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.All
    End Sub

End Class
