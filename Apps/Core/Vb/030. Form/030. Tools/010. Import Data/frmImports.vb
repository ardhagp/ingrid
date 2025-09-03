Imports System.IO
Imports System.Runtime.Versioning
Imports System.Security.Principal
Imports Syncfusion.Windows.Forms.Tools.Win32API

Public Class frmImports
    Private _Source As Import.Data.DataType.TypeofImports
    Private _varOriginalSourceFile As String
    Private _SQL_Catalog As New LibSQL.Tools.Import.MaterialMaster.Catalog

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _varOriginalSourceFile = String.Empty
    End Sub

    Public Sub New(ByVal Source As Import.Data.DataType.TypeofImports)
        InitializeComponent()
        _Source = Source
        _varOriginalSourceFile = String.Empty
    End Sub

    <Obsolete>
    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        Dim FileLoaded As Integer = 0

        od.Filter = "Comma Separated Values|*.csv"
        od.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString
        FileLoaded = od.ShowDialog()
        If FileLoaded <> System.Windows.Forms.DialogResult.Cancel Then
            _varOriginalSourceFile = od.FileName
            LblFileName.Text = CompactString(_varOriginalSourceFile, LblFileName.Width, LblFileName.Font, TextFormatFlags.PathEllipsis)
            TxtProgress.AppendText("Preparing : " & _varOriginalSourceFile & Environment.NewLine)
            TxtProgress.AppendText("Click [SAVE] to start importing your data..." & Environment.NewLine)
        End If
    End Sub

    <Obsolete>
    Private Function CompactString(ByVal MyString As String, ByVal Width As Integer,
ByVal Font As Drawing.Font,
ByVal FormatFlags As Windows.Forms.TextFormatFlags) As String

        Dim Result As String = String.Copy(MyString)

        TextRenderer.MeasureText(Result, Font, New Drawing.Size(Width, 0),
            FormatFlags Or TextFormatFlags.ModifyString)

        Return Result

    End Function

    <SupportedOSPlatform("windows")>
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If _varOriginalSourceFile <> String.Empty Then
            TxtProgress.AppendText("Checking if your file exist... ")
            If File.Exists(_varOriginalSourceFile) Then
                Select Case _Source
                    Case Import.Data.DataType.TypeofImports.MaterialMasterCatalog
                        _SQL_Catalog.Execute(TxtProgress, _varOriginalSourceFile)
                    Case Import.Data.DataType.TypeofImports.MaterialMasterPlant
                        'nothing
                End Select
            End If
        Else
            TxtProgress.AppendText("No file selected." & Environment.NewLine)
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class
