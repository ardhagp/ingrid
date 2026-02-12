<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Std_Fi
    Inherits CMCv.frmStandard

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        PnlFind = New pnl(components)
        BtnClear = New btn(components)
        LblFind = New lbl(components)
        TxtFind = New txt(components)
        CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnl_.SuspendLayout()
        SLFPanel.SuspendLayout()
        CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
        PnlFind.SuspendLayout()
        SuspendLayout()
        ' 
        ' SLFLogo
        ' 
        SLFLogo.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
        ' 
        ' SLFSubNamaForm
        ' 
        SLFSubNamaForm.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        ' 
        ' SLFNamaForm
        ' 
        SLFNamaForm.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        ' 
        ' pnl_
        ' 
        pnl_.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
        pnl_.Size = New System.Drawing.Size(1307, 110)
        ' 
        ' SLFPanel
        ' 
        SLFPanel.Controls.Add(PnlFind)
        SLFPanel.Location = New System.Drawing.Point(0, 110)
        SLFPanel.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
        SLFPanel.Size = New System.Drawing.Size(1307, 947)
        ' 
        ' SLFBackground
        ' 
        SLFBackground.Margin = New System.Windows.Forms.Padding(8, 12, 8, 12)
        ' 
        ' PnlFind
        ' 
        PnlFind.Controls.Add(BtnClear)
        PnlFind.Controls.Add(LblFind)
        PnlFind.Controls.Add(TxtFind)
        PnlFind.Dock = Windows.Forms.DockStyle.Top
        PnlFind.Location = New System.Drawing.Point(0, 0)
        PnlFind.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        PnlFind.Name = "PnlFind"
        PnlFind.Size = New System.Drawing.Size(1307, 88)
        PnlFind.TabIndex = 801
        ' 
        ' BtnClear
        ' 
        BtnClear.BackColor = Drawing.Color.Red
        BtnClear.Cursor = Windows.Forms.Cursors.Hand
        BtnClear.FlatAppearance.BorderColor = Drawing.Color.FromArgb(CByte(195), CByte(0), CByte(0))
        BtnClear.FlatAppearance.BorderSize = 2
        BtnClear.FlatAppearance.MouseOverBackColor = Drawing.Color.FromArgb(CByte(255), CByte(20), CByte(20))
        BtnClear.FlatStyle = Windows.Forms.FlatStyle.Flat
        BtnClear.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        BtnClear.ForeColor = Drawing.Color.White
        BtnClear.Location = New System.Drawing.Point(437, 6)
        BtnClear.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New System.Drawing.Size(167, 77)
        BtnClear.TabIndex = 801
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = False
        BtnClear.XOJenisTombol = ControlCodeBase.enuJenisTombol.No
        BtnClear.XOTampilkanFocusBorder = False
        BtnClear.XOValidasiSemuaInput = False
        BtnClear.XOValidasiSemuaInputTag = Nothing
        ' 
        ' LblFind
        ' 
        LblFind.AutoSize = True
        LblFind.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        LblFind.Location = New System.Drawing.Point(20, 25)
        LblFind.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        LblFind.Name = "LblFind"
        LblFind.Size = New System.Drawing.Size(60, 32)
        LblFind.TabIndex = 5
        LblFind.Text = "Find"
        LblFind.XOCustomElipsis = False
        ' 
        ' TxtFind
        ' 
        TxtFind.Font = New System.Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        TxtFind.Location = New System.Drawing.Point(105, 19)
        TxtFind.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        TxtFind.MaxLength = 255
        TxtFind.Name = "TxtFind"
        TxtFind.Size = New System.Drawing.Size(319, 39)
        TxtFind.TabIndex = 800
        TxtFind.Tag = "txt"
        TxtFind.XOAutoTrim = False
        TxtFind.XOHarusDiisi = False
        TxtFind.XOHarusDiisiWarnaLatar = Drawing.Color.LightPink
        TxtFind.XOHarusDiisiWarnaLatarDefault = Drawing.Color.White
        TxtFind.XOHightlightSaatFokus = False
        TxtFind.XOHightlightSaatFokusWarna = Drawing.Color.LightYellow
        TxtFind.XOIsBlank = True
        TxtFind.XOIsSearchBox = True
        TxtFind.XOJenisKapital = ControlCodeBase.enuJenisKapital.Normal
        TxtFind.XOPilihSemuaSaatFokus = False
        TxtFind.XOPwdLengthMin = 8
        TxtFind.XOPwdStrengthCalculate = False
        TxtFind.XOPwdStrengthScore = 0
        TxtFind.XOPwdStrengthText = Nothing
        TxtFind.XORestriction = ControlCodeBase.enuRestriction.None
        TxtFind.XOSearchBoxText = "Type then press Enter"
        TxtFind.XOSQLText = Nothing
        TxtFind.XOTanpaSpasi = False
        TxtFind.XOValidasiField = Nothing
        ' 
        ' Std_Fi
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(10F, 25F)
        ClientSize = New System.Drawing.Size(1307, 1079)
        KeyPreview = True
        Margin = New System.Windows.Forms.Padding(13, 23, 13, 23)
        Name = "Std_Fi"
        Text = "Nama Form"
        CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
        pnl_.ResumeLayout(False)
        pnl_.PerformLayout()
        SLFPanel.ResumeLayout(False)
        CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
        PnlFind.ResumeLayout(False)
        PnlFind.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Public WithEvents PnlFind As pnl
    Public WithEvents BtnClear As btn
    Public WithEvents LblFind As lbl
    Public WithEvents TxtFind As txt
End Class
