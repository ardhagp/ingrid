
Imports System.Runtime.Versioning

Public Class FRMdard
    Const varMessageSeries1 As String = "Series1"

    <SupportedOSPlatform("windows")>
    Private Sub FRMdard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GetChart()
    End Sub

    ''' <summary>
    ''' Load chart data
    ''' </summary>
    <SupportedOSPlatform("windows")>
    Private Sub GetChart()
        CMDdard.View.GetDailyStatistic(varDatabaseName, chrtDaily)
        chrtDaily.Series(varMessageSeries1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        chrtDaily.Series(varMessageSeries1).IsValueShownAsLabel = True
        chrtDaily.BorderlineWidth = 2
        chrtDaily.BorderColor = Color.MidnightBlue
        chrtDaily.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.All
        chrtDaily.Series(varMessageSeries1).BorderColor = Color.Red
        chrtDaily.Series(varMessageSeries1).BorderWidth = 5

        CMDdard.View.GetYearlyStatistic(varDatabaseName, chrtYearly)
        chrtYearly.Series(varMessageSeries1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
        chrtYearly.Series(varMessageSeries1).IsValueShownAsLabel = True
        chrtYearly.BorderColor = Color.MidnightBlue
        chrtYearly.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.All

        CMDdard.View.GetMonthlyStatistic(varDatabaseName, chrtMonthly)
        chrtMonthly.Series(varMessageSeries1).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
        chrtMonthly.Series(varMessageSeries1).IsValueShownAsLabel = True
        chrtMonthly.BorderColor = Color.MidnightBlue
        chrtMonthly.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.All
    End Sub

End Class
