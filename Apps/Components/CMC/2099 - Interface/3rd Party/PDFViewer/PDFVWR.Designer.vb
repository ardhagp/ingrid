Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMpdfViewer
        Inherits CMCv.FRMstandardFooter

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
            Dim MessageBoxSettings2 As Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings = New Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings()
            Dim PdfViewerPrinterSettings2 As Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings = New Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMpdfViewer))
            Dim TextSearchSettings2 As Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings = New Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings()
            BtnClose = New CMCv.UI.Control.Btn(components)
            PDFContent = New Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl()
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
            PnlBottomButton.Location = New System.Drawing.Point(0, 699)
            PnlBottomButton.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
            PnlBottomButton.Size = New System.Drawing.Size(1094, 97)
            PnlBottomButton.Controls.SetChildIndex(BtnClose, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
            pnl_.Size = New System.Drawing.Size(1094, 104)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(PDFContent)
            SLFPanel.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
            SLFPanel.Size = New System.Drawing.Size(1094, 796)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(PDFContent, 0)
            ' 
            ' BtnClose
            ' 
            BtnClose.Anchor = system.Windows.Forms.AnchorStyles.Top Or system.Windows.Forms.AnchorStyles.Right
            BtnClose.BackColor = Drawing.Color.Red
            BtnClose.Cursor = system.Windows.Forms.Cursors.Hand
            BtnClose.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(195), CByte(0), CByte(0))
            BtnClose.FlatAppearance.BorderSize = 2
            BtnClose.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(255), CByte(20), CByte(20))
            BtnClose.FlatStyle = system.Windows.Forms.FlatStyle.Flat
            BtnClose.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
            BtnClose.ForeColor = Drawing.Color.White
            BtnClose.Location = New System.Drawing.Point(907, 13)
            BtnClose.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
            BtnClose.Name = "BtnClose"
            BtnClose.Size = New System.Drawing.Size(167, 77)
            BtnClose.TabIndex = 1
            BtnClose.Text = "&Close"
            BtnClose.UseVisualStyleBackColor = False
            BtnClose.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.No
            BtnClose.XOShowBorderOnFocus = False
            BtnClose.XOValidateAllInput = False
            BtnClose.XOValidateAllInputTag = Nothing
            ' 
            ' PDFContent
            ' 
            PDFContent.BackColor = Drawing.Color.Gainsboro
            PDFContent.BackgroundImageLayout = system.Windows.Forms.ImageLayout.None
            PDFContent.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool
            PDFContent.Dock = system.Windows.Forms.DockStyle.Fill
            PDFContent.EnableContextMenu = True
            PDFContent.EnableNotificationBar = True
            PDFContent.HorizontalScrollOffset = 0
            PDFContent.IsBookmarkEnabled = True
            PDFContent.IsTextSearchEnabled = True
            PDFContent.IsTextSelectionEnabled = True
            PDFContent.Location = New System.Drawing.Point(0, 0)
            PDFContent.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
            MessageBoxSettings2.EnableNotification = True
            PDFContent.MessageBoxSettings = MessageBoxSettings2
            PDFContent.MinimumZoomPercentage = 50
            PDFContent.Name = "PDFContent"
            PDFContent.PageBorderThickness = 1
            PdfViewerPrinterSettings2.Copies = 1
            PdfViewerPrinterSettings2.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto
            PdfViewerPrinterSettings2.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize
            PdfViewerPrinterSettings2.PrintLocation = CType(resources.GetObject("PdfViewerPrinterSettings2.PrintLocation"), Drawing.PointF)
            PdfViewerPrinterSettings2.ShowPrintStatusDialog = True
            PDFContent.PrinterSettings = PdfViewerPrinterSettings2
            PDFContent.ReferencePath = Nothing
            PDFContent.ScrollDisplacementValue = 0
            PDFContent.ShowHorizontalScrollBar = True
            PDFContent.ShowToolBar = True
            PDFContent.ShowVerticalScrollBar = True
            PDFContent.Size = New System.Drawing.Size(1094, 699)
            PDFContent.SpaceBetweenPages = 8
            PDFContent.TabIndex = 999
            PDFContent.Text = "PDF Controls"
            TextSearchSettings2.CurrentInstanceColor = Drawing.Color.FromArgb(CByte(127), CByte(255), CByte(171), CByte(64))
            TextSearchSettings2.HighlightAllInstance = True
            TextSearchSettings2.OtherInstanceColor = Drawing.Color.FromArgb(CByte(127), CByte(254), CByte(255), CByte(0))
            PDFContent.TextSearchSettings = TextSearchSettings2
            PDFContent.ThemeName = "Office2016Colorful"
            PDFContent.VerticalScrollOffset = 0
            PDFContent.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Office2016Colorful
            PDFContent.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.FitPage
            ' 
            ' FRMpdfViewer
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(10.0F, 25.0F)
            ClientSize = New System.Drawing.Size(1094, 922)
            KeyPreview = True
            Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
            Name = "FRMpdfViewer"
            PnlBottomButton.ResumeLayout(False)
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub
        Public WithEvents BtnClose As CMCv.UI.Control.Btn
        Public WithEvents PDFContent As Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl
    End Class
End Namespace