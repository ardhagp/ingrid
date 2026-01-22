
Imports System.Runtime.Versioning

Public Class FRMdard
    Const varSeries1Message As String = "Series1"

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
        chrtDaily.Series(varSeries1Message).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        chrtDaily.Series(varSeries1Message).IsValueShownAsLabel = True
        chrtDaily.BorderlineWidth = 2
        chrtDaily.BorderColor = Color.MidnightBlue
        chrtDaily.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.All
        chrtDaily.Series(varSeries1Message).BorderColor = Color.Red
        chrtDaily.Series(varSeries1Message).BorderWidth = 5

        CMDdard.View.GetYearlyStatistic(varDatabaseName, chrtYearly)
        chrtYearly.Series(varSeries1Message).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
        chrtYearly.Series(varSeries1Message).IsValueShownAsLabel = True
        chrtYearly.BorderColor = Color.MidnightBlue
        chrtYearly.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.All

        CMDdard.View.GetMonthlyStatistic(varDatabaseName, chrtMonthly)
        chrtMonthly.Series(varSeries1Message).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
        chrtMonthly.Series(varSeries1Message).IsValueShownAsLabel = True
        chrtMonthly.BorderColor = Color.MidnightBlue
        chrtMonthly.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.All
    End Sub

End Class
