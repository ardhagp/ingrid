Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMdummyEditor
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
            Btn1 = New CMCv.UI.Control.Btn(components)
            Btn2 = New CMCv.UI.Control.Btn(components)
            PnlBottomButton.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' PnlBottomButton
            ' 
            PnlBottomButton.Controls.Add(Btn2)
            PnlBottomButton.Controls.Add(Btn1)
            PnlBottomButton.Location = New Point(0, 699)
            PnlBottomButton.Margin = New Padding(7, 10, 7, 10)
            PnlBottomButton.Size = New Size(1094, 97)
            PnlBottomButton.Controls.SetChildIndex(Btn1, 0)
            PnlBottomButton.Controls.SetChildIndex(Btn2, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(7, 10, 7, 10)
            pnl_.Size = New Size(1094, 104)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Margin = New Padding(7, 10, 7, 10)
            SLFPanel.Size = New Size(1094, 796)
            ' 
            ' Btn1
            ' 
            Btn1.BackColor = Color.RoyalBlue
            Btn1.Cursor = Cursors.Hand
            Btn1.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
            Btn1.FlatAppearance.BorderSize = 2
            Btn1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
            Btn1.FlatStyle = FlatStyle.Flat
            Btn1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            Btn1.ForeColor = Color.White
            Btn1.Location = New Point(731, 13)
            Btn1.Margin = New Padding(6, 5, 6, 5)
            Btn1.Name = "Btn1"
            Btn1.Size = New Size(167, 77)
            Btn1.TabIndex = 1
            Btn1.Text = "Btn1"
            Btn1.UseVisualStyleBackColor = False
            Btn1.XOButtonType = ControlCodeBase.buttonType.Default
            Btn1.XOShowBorderOnFocus = False
            Btn1.XOValidateAllInput = False
            Btn1.XOValidateAllInputTag = Nothing
            ' 
            ' Btn2
            ' 
            Btn2.BackColor = Color.RoyalBlue
            Btn2.Cursor = Cursors.Hand
            Btn2.FlatAppearance.BorderColor = Color.FromArgb(CByte(5), CByte(45), CByte(165))
            Btn2.FlatAppearance.BorderSize = 2
            Btn2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(85), CByte(125), CByte(245))
            Btn2.FlatStyle = FlatStyle.Flat
            Btn2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            Btn2.ForeColor = Color.White
            Btn2.Location = New Point(909, 13)
            Btn2.Margin = New Padding(6, 5, 6, 5)
            Btn2.Name = "Btn2"
            Btn2.Size = New Size(167, 77)
            Btn2.TabIndex = 2
            Btn2.Text = "Btn2"
            Btn2.UseVisualStyleBackColor = False
            Btn2.XOButtonType = ControlCodeBase.buttonType.Default
            Btn2.XOShowBorderOnFocus = False
            Btn2.XOValidateAllInput = False
            Btn2.XOValidateAllInputTag = Nothing
            ' 
            ' FRMdummyEditor
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1094, 922)
            KeyPreview = True
            Margin = New Padding(10, 5, 10, 5)
            Name = "FRMdummyEditor"
            PnlBottomButton.ResumeLayout(False)
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub
        Friend WithEvents Btn1 As CMCv.UI.Control.Btn
        Friend WithEvents Btn2 As CMCv.UI.Control.Btn

    End Class
End Namespace