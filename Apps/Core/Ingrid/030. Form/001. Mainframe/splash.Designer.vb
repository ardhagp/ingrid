<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splash
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(splash))
        Me.Pctbx1 = New CMCv.pctbx(Me.components)
        Me._ExecuteTime = New System.Windows.Forms.Timer(Me.components)
        Me.tlp_ = New System.Windows.Forms.TableLayoutPanel()
        Me.LblTitle = New CMCv.lbl(Me.components)
        Me._LoadingTime = New System.Windows.Forms.Timer(Me.components)
        Me.LblAdditional = New CMCv.lbl(Me.components)
        CType(Me.Pctbx1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlp_.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pctbx1
        '
        Me.Pctbx1.BackColor = System.Drawing.Color.White
        Me.Pctbx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pctbx1.ErrorImage = CType(resources.GetObject("Pctbx1.ErrorImage"), System.Drawing.Image)
        Me.Pctbx1.Image = Global.ingrid.My.Resources.Resources.StartUp
        Me.Pctbx1.InitialImage = CType(resources.GetObject("Pctbx1.InitialImage"), System.Drawing.Image)
        Me.Pctbx1.Location = New System.Drawing.Point(0, 0)
        Me.Pctbx1.Name = "Pctbx1"
        Me.Pctbx1.Size = New System.Drawing.Size(657, 241)
        Me.Pctbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pctbx1.SLFTampilkanBorder = False
        Me.Pctbx1.SLFWarnaBorder = System.Drawing.Color.DodgerBlue
        Me.Pctbx1.TabIndex = 0
        Me.Pctbx1.TabStop = False
        '
        '_ExecuteTime
        '
        Me._ExecuteTime.Enabled = True
        '
        'tlp_
        '
        Me.tlp_.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlp_.BackColor = System.Drawing.Color.Black
        Me.tlp_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tlp_.ColumnCount = 1
        Me.tlp_.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_.Controls.Add(Me.LblTitle, 0, 0)
        Me.tlp_.Controls.Add(Me.LblAdditional, 0, 2)
        Me.tlp_.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_.Location = New System.Drawing.Point(0, 0)
        Me.tlp_.Name = "tlp_"
        Me.tlp_.RowCount = 3
        Me.tlp_.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tlp_.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp_.Size = New System.Drawing.Size(657, 241)
        Me.tlp_.TabIndex = 1
        '
        'LblTitle
        '
        Me.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.White
        Me.LblTitle.Location = New System.Drawing.Point(3, 0)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(651, 110)
        Me.LblTitle.SLFCustomElipsis = False
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LblTitle.UseCompatibleTextRendering = True
        '
        '_LoadingTime
        '
        Me._LoadingTime.Enabled = True
        Me._LoadingTime.Interval = 10000
        '
        'LblAdditional
        '
        Me.LblAdditional.AutoSize = True
        Me.LblAdditional.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblAdditional.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LblAdditional.ForeColor = System.Drawing.Color.White
        Me.LblAdditional.Location = New System.Drawing.Point(3, 130)
        Me.LblAdditional.Name = "LblAdditional"
        Me.LblAdditional.Size = New System.Drawing.Size(651, 111)
        Me.LblAdditional.SLFCustomElipsis = False
        Me.LblAdditional.TabIndex = 1
        Me.LblAdditional.Text = "Loading..."
        Me.LblAdditional.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(657, 241)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlp_)
        Me.Controls.Add(Me.Pctbx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "splash"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.TopMost = True
        CType(Me.Pctbx1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlp_.ResumeLayout(False)
        Me.tlp_.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pctbx1 As CMCv.pctbx
    Friend WithEvents _ExecuteTime As Timer
    Friend WithEvents tlp_ As TableLayoutPanel
    Friend WithEvents _LoadingTime As Timer
    Friend WithEvents LblTitle As CMCv.lbl
    Friend WithEvents LblAdditional As CMCv.lbl
End Class
