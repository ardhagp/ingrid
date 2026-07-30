Namespace UI.Control
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ULbl
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ULbl))
            UHead = New Pbx(components)
            UText = New lbl(components)
            Tmr_ = New System.Windows.Forms.Timer(components)
            CType(UHead, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' UHead
            ' 
            UHead.BackColor = Drawing.Color.DarkGray
            UHead.Dock = System.Windows.Forms.DockStyle.Left
            UHead.ErrorImage = CType(resources.GetObject("UHead.ErrorImage"), Drawing.Image)
            UHead.InitialImage = CType(resources.GetObject("UHead.InitialImage"), Drawing.Image)
            UHead.Location = New System.Drawing.Point(0, 0)
            UHead.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            UHead.Name = "UHead"
            UHead.Size = New System.Drawing.Size(17, 39)
            UHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            UHead.TabIndex = 0
            UHead.TabStop = False
            UHead.XOBorderColor = Drawing.Color.DodgerBlue
            UHead.XOShowBorder = False
            ' 
            ' UText
            ' 
            UText.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
            UText.BackColor = Drawing.Color.Transparent
            UText.Font = New System.Drawing.Font("Segoe UI", 12F)
            UText.Location = New System.Drawing.Point(17, 0)
            UText.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
            UText.Name = "UText"
            UText.Size = New System.Drawing.Size(228, 39)
            UText.TabIndex = 1
            UText.Text = "Text"
            UText.TextAlign = Drawing.ContentAlignment.MiddleLeft
            UText.XOCustomElipsis = False
            ' 
            ' Tmr_
            ' 
            ' 
            ' ULbl
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(10F, 25F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            BackColor = Drawing.Color.WhiteSmoke
            Controls.Add(UHead)
            Controls.Add(UText)
            Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
            Name = "ULbl"
            Size = New System.Drawing.Size(250, 39)
            CType(UHead, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)

        End Sub

        Friend WithEvents UHead As UI.Control.Pbx
        Friend WithEvents UText As UI.Control.Lbl
        Friend WithEvents Tmr_ As System.Windows.Forms.Timer
    End Class
End Namespace