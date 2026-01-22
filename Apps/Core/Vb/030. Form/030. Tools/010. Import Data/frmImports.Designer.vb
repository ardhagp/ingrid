<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMimports
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
        Pnl1 = New pnl(components)
        LblFileName = New lbl(components)
        TxtProgress = New txt(components)
        od = New OpenFileDialog()
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        Pnl1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PnlBottomButton
        ' 
        PnlBottomButton.Location = New Point(0, 699)
        PnlBottomButton.Size = New Size(1095, 96)
        ' 
        ' pnl_
        ' 
        pnl_.Size = New Size(1095, 104)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(TxtProgress)
        SLFPanel.Controls.Add(Pnl1)
        SLFPanel.Size = New Size(1095, 795)
        SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
        SLFPanel.Controls.SetChildIndex(Pnl1, 0)
        SLFPanel.Controls.SetChildIndex(TxtProgress, 0)
        ' 
        ' Pnl1
        ' 
        Pnl1.Controls.Add(LblFileName)
        Pnl1.Dock = DockStyle.Top
        Pnl1.Location = New Point(0, 0)
        Pnl1.Margin = New Padding(5, 6, 5, 6)
        Pnl1.Name = "Pnl1"
        Pnl1.Size = New Size(1095, 88)
        Pnl1.TabIndex = 1
        ' 
        ' LblFileName
        ' 
        LblFileName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LblFileName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LblFileName.Location = New Point(197, 25)
        LblFileName.Margin = New Padding(5, 0, 5, 0)
        LblFileName.Name = "LblFileName"
        LblFileName.Size = New Size(879, 44)
        LblFileName.TabIndex = 1
        LblFileName.XOCustomElipsis = True
        ' 
        ' TxtProgress
        ' 
        TxtProgress.Dock = DockStyle.Fill
        TxtProgress.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtProgress.Location = New Point(0, 88)
        TxtProgress.Margin = New Padding(5, 6, 5, 6)
        TxtProgress.MaxLength = Integer.MaxValue
        TxtProgress.Multiline = True
        TxtProgress.Name = "TxtProgress"
        TxtProgress.ReadOnly = True
        TxtProgress.ScrollBars = ScrollBars.Both
        TxtProgress.Size = New Size(1095, 611)
        TxtProgress.TabIndex = 2
        TxtProgress.Tag = "txt"
        TxtProgress.WordWrap = False
        TxtProgress.XOAutoTrim = False
        TxtProgress.XOHarusDiisi = False
        TxtProgress.XOHarusDiisiWarnaLatar = Color.LightPink
        TxtProgress.XOHarusDiisiWarnaLatarDefault = Color.White
        TxtProgress.XOHightlightSaatFokus = False
        TxtProgress.XOHightlightSaatFokusWarna = Color.LightYellow
        TxtProgress.XOIsBlank = True
        TxtProgress.XOIsSearchBox = False
        TxtProgress.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtProgress.XOPilihSemuaSaatFokus = False
        TxtProgress.XOPwdLengthMin = 8
        TxtProgress.XOPwdStrengthCalculate = False
        TxtProgress.XOPwdStrengthScore = 0
        TxtProgress.XOPwdStrengthText = Nothing
        TxtProgress.XORestriction = ControlCodeBase.enuRestriction.None
        TxtProgress.XOSearchBoxText = "Type then press Enter"
        TxtProgress.XOSQLText = Nothing
        TxtProgress.XOTanpaSpasi = False
        TxtProgress.XOValidasiField = Nothing
        ' 
        ' od
        ' 
        od.DefaultExt = "[*.csv]"
        od.SupportMultiDottedExtensions = True
        od.Title = "Browse file to import..."
        ' 
        ' FRMimports
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        ClientSize = New Size(1095, 921)
        KeyPreview = True
        Margin = New Padding(22, 44, 22, 44)
        Name = "FRMimports"
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        SLFPanel.PerformLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        Pnl1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents Pnl1 As CMCv.pnl
    Friend WithEvents BtnBrowse As CMCv.btn
    Friend WithEvents BtnSave As CMCv.btn
    Friend WithEvents TxtProgress As CMCv.txt
    Friend WithEvents BtnClose As CMCv.btn
    Friend WithEvents od As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LblFileName As CMCv.lbl

End Class
