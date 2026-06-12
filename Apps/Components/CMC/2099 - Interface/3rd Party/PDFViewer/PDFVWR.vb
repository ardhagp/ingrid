Imports System.IO
Imports System.Runtime.Versioning

Namespace UI.Canvas
    Public Class FRMpdfViewer

        Private varLocalFs As FileStream
        Public Property LocalFS As FileStream
            Get
                Return varLocalFs
            End Get
            Set(value As FileStream)
                varLocalFs = value
            End Set
        End Property

        <SupportedOSPlatform("windows")>
        Private Sub FRMpdfViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Call ActivateLicenses()

            'use this line for old version of pdf handler
            'PDFContent.RenderingEngine = Syncfusion.Windows.Forms.PdfViewer.PdfRenderingEngine.SfPdf
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
            PDFContent.Dispose()
            Me.Close()
        End Sub

        Public Enum IsActive
            Enable = 1
            Disable = 0
        End Enum

        Public Sub FRMpdfViewerLoadDocument(fs As Object, filenname As String)
            PDFContent.Load(CType(fs, Stream))
        End Sub

        Public Sub FRMpdfViewerEnableFileOpen(enableproperties As IsActive)
            If enableproperties = IsActive.Enable Then
                PDFContent.ToolbarSettings.OpenButton.IsEnabled = True
            Else
                PDFContent.ToolbarSettings.OpenButton.IsEnabled = False
            End If
        End Sub

        Public Sub FRMpdfViewerEnableFileSave(enableproperties As IsActive)
            If enableproperties = IsActive.Enable Then
                PDFContent.ToolbarSettings.SaveButton.IsEnabled = True
            Else
                PDFContent.ToolbarSettings.SaveButton.IsEnabled = False
            End If
        End Sub
    End Class
End Namespace