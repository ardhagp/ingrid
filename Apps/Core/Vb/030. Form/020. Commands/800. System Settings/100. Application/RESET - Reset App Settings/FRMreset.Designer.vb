Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMreset
        Inherits CMCv.FRMstandardFooter

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            components = New ComponentModel.Container()
            LblNotification = New CMCv.UI.Control.lbl(components)
            Txt_Confirmation = New CMCv.UI.Control.txt(components)
            BtnClose = New CMCv.UI.Control.Btn(components)
            BtnRun = New CMCv.UI.Control.Btn(components)
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
            PnlBottomButton.Location = New Point(0, 527)
            PnlBottomButton.Margin = New Padding(7, 10, 7, 10)
            PnlBottomButton.Size = New Size(1143, 97)
            PnlBottomButton.Controls.SetChildIndex(BtnClose, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(7, 10, 7, 10)
            pnl_.Size = New Size(1143, 104)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(BtnRun)
            SLFPanel.Controls.Add(Txt_Confirmation)
            SLFPanel.Controls.Add(LblNotification)
            SLFPanel.Margin = New Padding(7, 10, 7, 10)
            SLFPanel.Size = New Size(1143, 624)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(LblNotification, 0)
            SLFPanel.Controls.SetChildIndex(Txt_Confirmation, 0)
            SLFPanel.Controls.SetChildIndex(BtnRun, 0)
            ' 
            ' LblNotification
            ' 
            LblNotification.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            LblNotification.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            LblNotification.ForeColor = Color.Red
            LblNotification.Location = New Point(17, 140)
            LblNotification.Margin = New Padding(4, 0, 4, 0)
            LblNotification.Name = "LblNotification"
            LblNotification.Size = New Size(1109, 35)
            LblNotification.TabIndex = 996
            LblNotification.Text = "This action will reset your database settings. Please type 'Confirm' then click 'Run' when you are ready."
            LblNotification.TextAlign = ContentAlignment.TopCenter
            LblNotification.XOCustomElipsis = False
            ' 
            ' Txt_Confirmation
            ' 
            Txt_Confirmation.AcceptsReturn = True
            Txt_Confirmation.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            Txt_Confirmation.AutoCompleteMode = AutoCompleteMode.Suggest
            Txt_Confirmation.AutoCompleteSource = AutoCompleteSource.CustomSource
            Txt_Confirmation.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Txt_Confirmation.Location = New Point(399, 202)
            Txt_Confirmation.Margin = New Padding(4, 5, 4, 5)
            Txt_Confirmation.MaxLength = 255
            Txt_Confirmation.Name = "Txt_Confirmation"
            Txt_Confirmation.Size = New Size(346, 39)
            Txt_Confirmation.TabIndex = 0
            Txt_Confirmation.Tag = "txt"
            Txt_Confirmation.TextAlign = HorizontalAlignment.Center
            Txt_Confirmation.XOAutoTrim = False
            Txt_Confirmation.XOHarusDiisi = True
            Txt_Confirmation.XOHarusDiisiWarnaLatar = Color.LightPink
            Txt_Confirmation.XOHarusDiisiWarnaLatarDefault = Color.White
            Txt_Confirmation.XOHightlightSaatFokus = True
            Txt_Confirmation.XOHightlightSaatFokusWarna = Color.LightYellow
            Txt_Confirmation.XOIsBlank = False
            Txt_Confirmation.XOIsSearchBox = False
            Txt_Confirmation.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
            Txt_Confirmation.XOPilihSemuaSaatFokus = False
            Txt_Confirmation.XOPwdLengthMin = 8
            Txt_Confirmation.XOPwdStrengthCalculate = False
            Txt_Confirmation.XOPwdStrengthScore = 0
            Txt_Confirmation.XOPwdStrengthText = Nothing
            Txt_Confirmation.XORestriction = ControlCodeBase.enuRestriction.None
            Txt_Confirmation.XOSearchBoxText = ""
            Txt_Confirmation.XOSQLText = ""
            Txt_Confirmation.XOTanpaSpasi = False
            Txt_Confirmation.XOValidasiField = Nothing
            ' 
            ' BtnClose
            ' 
            BtnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            BtnClose.BackColor = Color.Red
            BtnClose.Cursor = Cursors.Hand
            BtnClose.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
            BtnClose.FlatAppearance.BorderSize = 2
            BtnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
            BtnClose.FlatStyle = FlatStyle.Flat
            BtnClose.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnClose.ForeColor = Color.White
            BtnClose.Location = New Point(957, 13)
            BtnClose.Margin = New Padding(6, 5, 6, 5)
            BtnClose.Name = "BtnClose"
            BtnClose.Size = New Size(167, 77)
            BtnClose.TabIndex = 2
            BtnClose.Text = "&Close"
            BtnClose.UseVisualStyleBackColor = False
            BtnClose.XOButtonType = ControlCodeBase.buttonType.No
            BtnClose.XOShowBorderOnFocus = False
            BtnClose.XOValidateAllInput = False
            BtnClose.XOValidateAllInputTag = Nothing
            ' 
            ' BtnRun
            ' 
            BtnRun.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            BtnRun.BackColor = Color.LimeGreen
            BtnRun.Cursor = Cursors.Hand
            BtnRun.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(145), CByte(50))
            BtnRun.FlatAppearance.BorderSize = 2
            BtnRun.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(70), CByte(225), CByte(70))
            BtnRun.FlatStyle = FlatStyle.Flat
            BtnRun.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
            BtnRun.ForeColor = Color.White
            BtnRun.Location = New Point(489, 270)
            BtnRun.Margin = New Padding(6, 5, 6, 5)
            BtnRun.Name = "BtnRun"
            BtnRun.Size = New Size(167, 77)
            BtnRun.TabIndex = 1
            BtnRun.Text = "&Run"
            BtnRun.UseVisualStyleBackColor = False
            BtnRun.XOButtonType = ControlCodeBase.buttonType.Yes
            BtnRun.XOShowBorderOnFocus = False
            BtnRun.XOValidateAllInput = False
            BtnRun.XOValidateAllInputTag = Nothing
            ' 
            ' FRMreset
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(1143, 750)
            ControlBox = False
            FormBorderStyle = FormBorderStyle.FixedSingle
            KeyPreview = True
            Margin = New Padding(19, 38, 19, 38)
            MaximizeBox = False
            MinimizeBox = False
            Name = "FRMreset"
            Text = "RESET"
            PnlBottomButton.ResumeLayout(False)
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            SLFPanel.PerformLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Friend WithEvents LblNotification As CMCv.UI.Control.lbl
        Friend WithEvents Txt_Confirmation As CMCv.UI.Control.txt
        Friend WithEvents BtnClose As CMCv.UI.Control.Btn
        Friend WithEvents BtnRun As CMCv.UI.Control.Btn
    End Class
End Namespace