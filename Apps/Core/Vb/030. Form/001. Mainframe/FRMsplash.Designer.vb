<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMsplash
    Inherits CMCv.Blank

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMsplash))
        Pctbx1 = New pctbx(components)
        _ExecuteTime = New Timer(components)
        tlp_ = New TableLayoutPanel()
        LblTitle = New lbl(components)
        LblAdditional = New lbl(components)
        _LoadingTime = New Timer(components)
        CType(Pctbx1, ComponentModel.ISupportInitialize).BeginInit()
        tlp_.SuspendLayout()
        SuspendLayout()
        ' 
        ' Pctbx1
        ' 
        Pctbx1.BackColor = Color.White
        Pctbx1.Dock = DockStyle.Fill
        Pctbx1.ErrorImage = CType(resources.GetObject("Pctbx1.ErrorImage"), Image)
        Pctbx1.Image = My.Resources.Resources.StartUp
        Pctbx1.InitialImage = CType(resources.GetObject("Pctbx1.InitialImage"), Image)
        Pctbx1.Location = New Point(0, 0)
        Pctbx1.Margin = New Padding(5, 6, 5, 6)
        Pctbx1.Name = "Pctbx1"
        Pctbx1.Size = New Size(1095, 463)
        Pctbx1.SizeMode = PictureBoxSizeMode.StretchImage
        Pctbx1.TabIndex = 0
        Pctbx1.TabStop = False
        Pctbx1.XOTampilkanBorder = False
        Pctbx1.XOWarnaBorder = Color.DodgerBlue
        ' 
        ' _ExecuteTime
        ' 
        _ExecuteTime.Enabled = True
        ' 
        ' tlp_
        ' 
        tlp_.AutoSizeMode = AutoSizeMode.GrowAndShrink
        tlp_.BackColor = Color.Black
        tlp_.BackgroundImageLayout = ImageLayout.Stretch
        tlp_.ColumnCount = 1
        tlp_.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlp_.Controls.Add(LblTitle, 0, 0)
        tlp_.Controls.Add(LblAdditional, 0, 2)
        tlp_.Dock = DockStyle.Fill
        tlp_.Location = New Point(0, 0)
        tlp_.Margin = New Padding(5, 6, 5, 6)
        tlp_.Name = "tlp_"
        tlp_.RowCount = 3
        tlp_.RowStyles.Add(New RowStyle(SizeType.Absolute, 212F))
        tlp_.RowStyles.Add(New RowStyle(SizeType.Absolute, 38F))
        tlp_.RowStyles.Add(New RowStyle())
        tlp_.Size = New Size(1095, 463)
        tlp_.TabIndex = 1
        ' 
        ' LblTitle
        ' 
        LblTitle.Dock = DockStyle.Fill
        LblTitle.FlatStyle = FlatStyle.Flat
        LblTitle.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblTitle.ForeColor = Color.White
        LblTitle.Location = New Point(5, 0)
        LblTitle.Margin = New Padding(5, 0, 5, 0)
        LblTitle.Name = "LblTitle"
        LblTitle.Size = New Size(1085, 212)
        LblTitle.TabIndex = 0
        LblTitle.TextAlign = ContentAlignment.BottomCenter
        LblTitle.UseCompatibleTextRendering = True
        LblTitle.XOCustomElipsis = False
        ' 
        ' LblAdditional
        ' 
        LblAdditional.AutoSize = True
        LblAdditional.Dock = DockStyle.Fill
        LblAdditional.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LblAdditional.ForeColor = Color.White
        LblAdditional.Location = New Point(5, 250)
        LblAdditional.Margin = New Padding(5, 0, 5, 0)
        LblAdditional.Name = "LblAdditional"
        LblAdditional.Size = New Size(1085, 213)
        LblAdditional.TabIndex = 1
        LblAdditional.Text = "Loading..."
        LblAdditional.TextAlign = ContentAlignment.BottomRight
        LblAdditional.XOCustomElipsis = False
        ' 
        ' _LoadingTime
        ' 
        _LoadingTime.Enabled = True
        _LoadingTime.Interval = 10000
        ' 
        ' FRMsplash
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        ClientSize = New Size(1095, 463)
        ControlBox = False
        Controls.Add(tlp_)
        Controls.Add(Pctbx1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(8, 12, 8, 12)
        Name = "FRMsplash"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = ""
        TopMost = True
        CType(Pctbx1, ComponentModel.ISupportInitialize).EndInit()
        tlp_.ResumeLayout(False)
        tlp_.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents Pctbx1 As CMCv.pctbx
    Friend WithEvents _ExecuteTime As Timer
    Friend WithEvents tlp_ As TableLayoutPanel
    Friend WithEvents _LoadingTime As Timer
    Friend WithEvents LblTitle As CMCv.lbl
    Friend WithEvents LblAdditional As CMCv.lbl
End Class
