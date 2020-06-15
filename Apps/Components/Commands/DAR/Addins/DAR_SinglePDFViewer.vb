Imports System.IO

Public Class DAR_SinglePDFViewer
    Private _FILE As String
    Private _FileName As String
    Private _FS As Object
    Private _Type As String
    Private _ForcedStamp As Boolean

    Public Sub New(ByVal FileFullPath As String, ByVal FileName As String, ByVal IsForcedStamp As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _FILE = FileFullPath
        _FileName = FileName
        _Type = "String"
        _ForcedStamp = IsForcedStamp
    End Sub

    Public Sub New(ByVal FS As FileStream, ByVal IsForcedStamp As Boolean)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _FS = FS
        _Type = "FileStream"
        _ForcedStamp = IsForcedStamp
    End Sub

    Private Sub DAR_SinglePDFViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _Type = "String" Then
            _FS = New FileStream(_FILE, FileMode.Open, FileAccess.Read)
        End If

        PDFVWR_EnableFileOpen(IsActive.Disable)
        PDFVWR_LoadDocument(_FS, _FileName)
        'GetPageCount()

        'PDFContent.Show()

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PDFContent_Click(sender As Object, e As EventArgs) Handles PDFContent.Click

    End Sub
End Class
