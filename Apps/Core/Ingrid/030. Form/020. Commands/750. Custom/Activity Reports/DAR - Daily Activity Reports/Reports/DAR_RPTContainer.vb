Imports Microsoft.Reporting.WinForms

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

    Private Sub DAR_RPTContainer_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        RaiseEvent ReportClosed()
    End Sub

    Private Sub DAR_RPTContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim _DSo = New ReportDataSource("employeeactivity", _DS.Tables(0))
            Rv_.LocalReport.DataSources.Clear()
            Rv_.LocalReport.DataSources.Add(_DSo)
            Rv_.LocalReport.ReportEmbeddedResource = "ingrid.DAR_RContent.rdlc"
            Rv_.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("paramCreator", _Creator))
            Rv_.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("paramColor", _Color))
            Rv_.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("paramVersion", _Version))
            Rv_.SetDisplayMode(DisplayMode.PrintLayout)
            Rv_.ZoomMode = ZoomMode.PageWidth
            Rv_.RefreshReport()
        Catch ex As Exception
            Call PUSHERRORDATA(CMCv.Catcher.Error.Fields.TypeOfFaulties.ApplicationRunTime, ex.Message, ex.HResult, ex.StackTrace, GETAPPVERSION, False, True, True)
            Call PUSHERRORDATASHOW()
        End Try

    End Sub
End Class
