Imports Microsoft.Reporting.WinForms.ReportViewer
Imports Microsoft.Reporting.WinForms
Imports System.Runtime.Versioning

Public Class DAR_RPTContainer
    Public Event ReportClosed()
    Public _DS As New DAR_RDS
    Public _Creator As String
    Public _Color As Boolean
    Public _Version As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal DataSetName As DAR_RDS, ByVal Creator As String, ByVal RColor As Boolean, ByVal AppVersion As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _DS = DataSetName
        _Creator = Creator
        _Color = RColor
        _Version = AppVersion
    End Sub

    Private Sub DAR_RPTContainer_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        RaiseEvent ReportClosed()
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DAR_RPTContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim _DSo = New ReportDataSource("employeeactivity", _DS.Tables(0))
            With Rv_
                .LocalReport.DataSources.Clear()
                .LocalReport.DataSources.Add(_DSo)
                .LocalReport.ReportEmbeddedResource = "ingrid.DAR_RContent.rdlc"
                .LocalReport.SetParameters(CType(New ReportParameter("paramCreator", _Creator), ReportParameter))
                .LocalReport.SetParameters(CType(New ReportParameter("paramColor", _Color.ToString), ReportParameter))
                .LocalReport.SetParameters(CType(New ReportParameter("paramVersion", _Version), ReportParameter))
                .SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                .ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
                .RefreshReport()
            End With
        Catch ex As Exception
            With proLog
                .AppVersion = GetAppVersion()
                .FromSender = "[DAR_RPTContainer_Load] $Ingrid\Apps\Core\Vb\030. Form\020. Commands\750. Custom\Activity Reports\DAR - Daily Activity Reports\Reports\DAR_RPTContainer.vb"
                .InternalStackTrace = ex.StackTrace
                .Message = ex.Message
                .Number = ex.HResult
                .ResumeNext = True
                .SaveInBetterLog = True
                .SaveLogInLocal = False
                .ShowErrorReporting = True
                .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.ApplicationRunTime
                .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
            End With

            Dim clsLog As New Ladybug.Log.Events
            clsLog.ShowData(proLog)
            clsLog = Nothing
        End Try

    End Sub
End Class
