Imports System.IO

Public Class FRMdarSinglePdfViewer
    Private varFile As String
    Private varFileName As String
    Private varFileStream As Object
    Private varType As String
    Private varForcedStamp As Boolean

    Public Sub New(filefullpath As String, filename As String, isforcedstamp As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        varFile = filefullpath
        varFileName = filename
        varType = "String"
        varForcedStamp = isforcedstamp
    End Sub

    Public Sub New(fs As FileStream, isforcedstamp As Boolean)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        varFileStream = fs
        varType = "FileStream"
        varForcedStamp = isforcedstamp
    End Sub

    Private Sub FRMdarSinglePdfViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If varType = "String" Then
            varFileStream = New FileStream(varFile, FileMode.Open, FileAccess.Read)
        End If

        FRMpdfviewerEnableFileOpen(IsActive.Disable)
        FRMpdfviewerLoadDocument(varFileStream, varFileName)
        'GetPageCount()

        'PDFContent.Show()

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class
