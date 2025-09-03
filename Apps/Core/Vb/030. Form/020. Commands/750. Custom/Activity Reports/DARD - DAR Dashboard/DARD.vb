
Imports System.Runtime.Versioning

Public Class DARD
    Private V_SQL As New Commands.DARD.View

    <SupportedOSPlatform("windows")>
    Private Sub DARD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GETChart()
    End Sub

    ''' <summary>
    ''' Load chart data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub GETChart()
        Commands.DARD.View.GETDailyStatistic(chrtDaily)
        chrtDaily.Series("Series1").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        chrtDaily.Series("Series1").IsValueShownAsLabel = True
        chrtDaily.BorderlineWidth = 2
        chrtDaily.BorderColor = Color.MidnightBlue
        chrtDaily.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.All
        chrtDaily.Series("Series1").BorderColor = Color.Red
        chrtDaily.Series("Series1").BorderWidth = 5

        Commands.DARD.View.GETYearlyStatistic(chrtYearly)
        chrtYearly.Series("Series1").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
        chrtYearly.Series("Series1").IsValueShownAsLabel = True
        chrtYearly.BorderColor = Color.MidnightBlue
        chrtYearly.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.All

        Commands.DARD.View.GETMonthlyStatistic(chrtMonthly)
        chrtMonthly.Series("Series1").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
        chrtMonthly.Series("Series1").IsValueShownAsLabel = True
        chrtMonthly.BorderColor = Color.MidnightBlue
        chrtMonthly.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.All
    End Sub

End Class
