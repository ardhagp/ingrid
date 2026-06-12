Imports System.IO
Imports System.Runtime.Versioning

Namespace UI.Canvas
    Public Class FRMaddinsDARsinglePdfViewer

        Private varFile As String
        Private varFilename As String
        Private varFilestream As Object
        Private varType As String
        Private varForcedstamp As Boolean

        Public Sub New(filefullpath As String, filename As String, isforcedstamp As Boolean)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            varFile = filefullpath
            varFilename = filename
            varType = "String"
            varForcedstamp = isforcedstamp
        End Sub

        Public Sub New(fs As FileStream, isforcedstamp As Boolean)
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            varFilestream = fs
            varType = "FileStream"
            varForcedstamp = isforcedstamp
        End Sub

        Private Sub FRMdarSinglePdfViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If varType = "String" Then
                varFilestream = New FileStream(varFile, FileMode.Open, FileAccess.Read)
            End If

            FRMpdfViewerEnableFileOpen(IsActive.Disable)
            FRMpdfViewerLoadDocument(varFilestream, varFilename)
            'GetPageCount()

            'PDFContent.Show()

        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnClose_Click(sender As Object, e As EventArgs)
            Me.Close()
        End Sub
    End Class
End Namespace