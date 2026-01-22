Imports System.IO
Imports System.Runtime.Versioning

Public Class FRMpdfviewer

    Private varLocalFS As FileStream
    Public Property LocalFS As FileStream
        Get
            Return varLocalFS
        End Get
        Set(value As FileStream)
            varLocalFS = value
        End Set
    End Property

    <SupportedOSPlatform("windows")>
    Private Sub FRMpdfviewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ActivateLicenses()

        'use this line for old version of pdf handler
        'PDFContent.RenderingEngine = Syncfusion.Windows.Forms.PdfViewer.PdfRenderingEngine.SfPdf
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        PDFContent.Dispose()
        Me.Close()
    End Sub

    Public Enum IsActive
        Enable = 1
        Disable = 0
    End Enum

    Public Sub FRMpdfviewerLoadDocument(fs As Object, filename As String)
        PDFContent.Load(CType(fs, Stream))
    End Sub

    Public Sub FRMpdfviewerEnableFileOpen(enableproperties As IsActive)
        If enableproperties = IsActive.Enable Then
            PDFContent.ToolbarSettings.OpenButton.IsEnabled = True
        Else
            PDFContent.ToolbarSettings.OpenButton.IsEnabled = False
        End If
    End Sub

    Public Sub FRMpdfviewerEnableFileSave(enableproperties As IsActive)
        If enableproperties = IsActive.Enable Then
            PDFContent.ToolbarSettings.SaveButton.IsEnabled = True
        Else
            PDFContent.ToolbarSettings.SaveButton.IsEnabled = False
        End If
    End Sub
End Class
