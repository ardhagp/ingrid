<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PDFVWR
    Inherits CMCv.Std_Fo

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim MessageBoxSettings1 As Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings = New Windows.Forms.PdfViewer.MessageBoxSettings()
        Dim PdfViewerPrinterSettings1 As Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings = New Windows.PdfViewer.PdfViewerPrinterSettings()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PDFVWR))
        Dim TextSearchSettings1 As Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings = New Windows.Forms.PdfViewer.TextSearchSettings()
        BtnClose = New btn(components)
        PDFContent = New Windows.Forms.PdfViewer.PdfViewerControl()
        PnlBottomButton.SuspendLayout()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Controls.Add(BtnClose)
        PnlBottomButton.Location = New System.Drawing.Point(0, 412)
        PnlBottomButton.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        PnlBottomButton.Size = New System.Drawing.Size(766, 58)
        PnlBottomButton.Controls.SetChildIndex(BtnClose, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        pnl_.Size = New System.Drawing.Size(766, 61)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(PDFContent)
        SLFPanel.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        SLFPanel.Size = New System.Drawing.Size(766, 470)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(PDFContent, 0)
        ' 
        ' BtnClose
        ' 
        BtnClose.Anchor = Windows.Forms.AnchorStyles.Top Or Windows.Forms.AnchorStyles.Right
        BtnClose.BackColor = Drawing.Color.Red
        BtnClose.Cursor = Windows.Forms.Cursors.Hand
        BtnClose.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnClose.FlatAppearance.BorderSize = 2
        BtnClose.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(255), CByte(20), CByte(20))
        BtnClose.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnClose.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        BtnClose.ForeColor = Drawing.Color.White
        BtnClose.Location = New System.Drawing.Point(635, 8)
        BtnClose.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New System.Drawing.Size(117, 46)
        BtnClose.TabIndex = 1
        BtnClose.Text = "&Close"
        BtnClose.UseVisualStyleBackColor = False
        BtnClose.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnClose.XOTampilkanFocusBorder = False
        BtnClose.XOValidasiSemuaInput = False
        BtnClose.XOValidasiSemuaInputTag = Nothing
        ' 
        ' PDFContent
        ' 
        PDFContent.BackColor = Drawing.Color.Gainsboro
        PDFContent.BackgroundImageLayout = Windows.Forms.ImageLayout.None
        PDFContent.CursorMode = Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool
        PDFContent.Dock = Windows.Forms.DockStyle.Fill
        PDFContent.EnableContextMenu = True
        PDFContent.EnableNotificationBar = True
        PDFContent.HorizontalScrollOffset = 0
        PDFContent.IsBookmarkEnabled = True
        PDFContent.IsTextSearchEnabled = True
        PDFContent.IsTextSelectionEnabled = True
        PDFContent.Location = New System.Drawing.Point(0, 0)
        PDFContent.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        MessageBoxSettings1.EnableNotification = True
        PDFContent.MessageBoxSettings = MessageBoxSettings1
        PDFContent.MinimumZoomPercentage = 50
        PDFContent.Name = "PDFContent"
        PDFContent.PageBorderThickness = 1
        PdfViewerPrinterSettings1.Copies = 1
        PdfViewerPrinterSettings1.PageOrientation = Windows.PdfViewer.PdfViewerPrintOrientation.Auto
        PdfViewerPrinterSettings1.PageSize = Windows.PdfViewer.PdfViewerPrintSize.ActualSize
        PdfViewerPrinterSettings1.PrintLocation = CType(resources.GetObject("PdfViewerPrinterSettings1.PrintLocation"), Drawing.PointF)
        PdfViewerPrinterSettings1.ShowPrintStatusDialog = True
        PDFContent.PrinterSettings = PdfViewerPrinterSettings1
        PDFContent.ReferencePath = Nothing
        PDFContent.ScrollDisplacementValue = 0
        PDFContent.ShowHorizontalScrollBar = True
        PDFContent.ShowToolBar = True
        PDFContent.ShowVerticalScrollBar = True
        PDFContent.Size = New System.Drawing.Size(766, 412)
        PDFContent.SpaceBetweenPages = 8
        PDFContent.TabIndex = 999
        PDFContent.Text = "PDF Controls"
        TextSearchSettings1.CurrentInstanceColor = Drawing.Color.FromArgb(CByte(127), CByte(255), CByte(171), CByte(64))
        TextSearchSettings1.HighlightAllInstance = True
        TextSearchSettings1.OtherInstanceColor = Drawing.Color.FromArgb(CByte(127), CByte(254), CByte(255), CByte(0))
        PDFContent.TextSearchSettings = TextSearchSettings1
        PDFContent.ThemeName = "Office2016Colorful"
        PDFContent.VerticalScrollOffset = 0
        PDFContent.VisualStyle = Windows.Forms.PdfViewer.VisualStyle.Office2016Colorful
        PDFContent.ZoomMode = Windows.Forms.PdfViewer.ZoomMode.FitPage
        ' 
        ' PDFVWR
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
        ClientSize = New System.Drawing.Size(766, 553)
        KeyPreview = True
        Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Name = "PDFVWR"
        PnlBottomButton.ResumeLayout(False)
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Public WithEvents BtnClose As btn
    Public WithEvents PDFContent As Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl
End Class
