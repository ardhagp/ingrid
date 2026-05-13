Imports System.IO
Imports System.Runtime.Versioning

Namespace UI
    Public Class DAR_SinglePDFViewer

        Private _FILE As String
        Private _FileName As String
        Private _FS As Object
        Private _Type As String
        Private _ForcedStamp As Boolean

        Public Sub New(filefullpath As String, filename As String, isforcedstamp As Boolean)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            _FILE = filefullpath
            _FileName = filename
            _Type = "String"
            _ForcedStamp = isforcedstamp
        End Sub

        Public Sub New(fs As FileStream, isforcedstamp As Boolean)
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            _FS = fs
            _Type = "FileStream"
            _ForcedStamp = isforcedstamp
        End Sub

        Private Sub FRMdarSinglePdfViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If _Type = "String" Then
                _FS = New FileStream(_FILE, FileMode.Open, FileAccess.Read)
            End If

            FRMpdfViewerEnableFileOpen(IsActive.Disable)
            FRMpdfViewerLoadDocument(_FS, _FileName)
            'GetPageCount()

            'PDFContent.Show()

        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnClose_Click(sender As Object, e As EventArgs)
            Me.Close()
        End Sub
    End Class
End Namespace