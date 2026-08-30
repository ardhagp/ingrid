Namespace UI.Canvas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMcamera
        Inherits UI.Canvas.FRMstandardFooter

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMcamera))
            CboCamera = New UI.Control.Cbo(components)
            BtnClose = New UI.Control.Btn(components)
            BtnOK = New UI.Control.Btn(components)
            PbxLive = New UI.Control.Pbx(components)
            PnlBottomButton.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            CType(XOLogo, ComponentModel.ISupportInitialize).BeginInit()
            CType(PbxLive, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' PnlBottomButton
            ' 
            PnlBottomButton.Controls.Add(BtnOK)
            PnlBottomButton.Controls.Add(BtnClose)
            PnlBottomButton.Size = New System.Drawing.Size(587, 96)
            PnlBottomButton.Controls.SetChildIndex(BtnClose, 0)
            PnlBottomButton.Controls.SetChildIndex(BtnOK, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Size = New System.Drawing.Size(587, 110)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(PbxLive)
            SLFPanel.Controls.Add(CboCamera)
            SLFPanel.Size = New System.Drawing.Size(587, 947)
            SLFPanel.Controls.SetChildIndex(CboCamera, 0)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(PbxLive, 0)
            ' 
            ' CboCamera
            ' 
            CboCamera.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            CboCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            CboCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            CboCamera.Font = New System.Drawing.Font("Segoe UI", 12.0F)
            CboCamera.FormattingEnabled = True
            CboCamera.Location = New System.Drawing.Point(12, 623)
            CboCamera.Name = "CboCamera"
            CboCamera.Size = New System.Drawing.Size(563, 40)
            CboCamera.TabIndex = 996
            ' 
            ' BtnClose
            ' 
            BtnClose.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            BtnClose.BackColor = Drawing.Color.Red
            BtnClose.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(195), CByte(0), CByte(0))
            BtnClose.FlatAppearance.BorderSize = 2
            BtnClose.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(255), CByte(20), CByte(20))
            BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            BtnClose.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Bold)
            BtnClose.ForeColor = Drawing.Color.White
            BtnClose.Location = New System.Drawing.Point(425, 17)
            BtnClose.Name = "BtnClose"
            BtnClose.Size = New System.Drawing.Size(150, 60)
            BtnClose.TabIndex = 1
            BtnClose.Text = "Close"
            BtnClose.UseVisualStyleBackColor = False
            BtnClose.XOButtonType = UI.Control.ControlCodeBase.ButtonType.No
            BtnClose.XOShowBorderOnFocus = False
            BtnClose.XOValidateAllInput = False
            BtnClose.XOValidateAllInputTag = Nothing
            ' 
            ' BtnOK
            ' 
            BtnOK.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
            BtnOK.BackColor = Drawing.Color.LimeGreen
            BtnOK.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(50), CByte(145), CByte(50))
            BtnOK.FlatAppearance.BorderSize = 2
            BtnOK.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(70), CByte(225), CByte(70))
            BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            BtnOK.Font = New System.Drawing.Font("Segoe UI", 12.0F, Drawing.FontStyle.Bold)
            BtnOK.ForeColor = Drawing.Color.White
            BtnOK.Location = New System.Drawing.Point(269, 17)
            BtnOK.Name = "BtnOK"
            BtnOK.Size = New System.Drawing.Size(150, 60)
            BtnOK.TabIndex = 2
            BtnOK.Text = "OK"
            BtnOK.UseVisualStyleBackColor = False
            BtnOK.XOButtonType = UI.Control.ControlCodeBase.ButtonType.Yes
            BtnOK.XOShowBorderOnFocus = False
            BtnOK.XOValidateAllInput = False
            BtnOK.XOValidateAllInputTag = Nothing
            ' 
            ' PbxLive
            ' 
            PbxLive.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            PbxLive.BackColor = Drawing.Color.White
            PbxLive.ErrorImage = CType(resources.GetObject("PbxLive.ErrorImage"), Drawing.Image)
            PbxLive.InitialImage = CType(resources.GetObject("PbxLive.InitialImage"), Drawing.Image)
            PbxLive.Location = New System.Drawing.Point(12, 15)
            PbxLive.Name = "PbxLive"
            PbxLive.Size = New System.Drawing.Size(563, 563)
            PbxLive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            PbxLive.TabIndex = 1001
            PbxLive.TabStop = False
            PbxLive.XOBorderColor = Drawing.Color.DodgerBlue
            PbxLive.XOShowBorder = False
            ' 
            ' FRMcamera
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(10F, 25F)
            ClientSize = New System.Drawing.Size(587, 1079)
            Name = "FRMcamera"
            PnlBottomButton.ResumeLayout(False)
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            CType(XOLogo, ComponentModel.ISupportInitialize).EndInit()
            CType(PbxLive, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Friend WithEvents CboCamera As UI.Control.Cbo
        Friend WithEvents BtnOK As UI.Control.Btn
        Friend WithEvents BtnClose As UI.Control.Btn
        Friend WithEvents PbxLive As UI.Control.Pbx
    End Class
End Namespace