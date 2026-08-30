Namespace UI.Canvas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMcameraNative
        Inherits System.Windows.Forms.Form

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMcameraNative))
            CboCamera = New UI.Control.Cbo(components)
            PbxLive = New UI.Control.Pbx(components)
            CType(PbxLive, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' CboCamera
            ' 
            CboCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            CboCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            CboCamera.Font = New System.Drawing.Font("Segoe UI", 12.0F)
            CboCamera.FormattingEnabled = True
            CboCamera.Location = New System.Drawing.Point(12, 518)
            CboCamera.Name = "CboCamera"
            CboCamera.Size = New System.Drawing.Size(776, 40)
            CboCamera.TabIndex = 0
            ' 
            ' PbxLive
            ' 
            PbxLive.BackColor = Drawing.Color.White
            PbxLive.ErrorImage = CType(resources.GetObject("PbxLive.ErrorImage"), Drawing.Image)
            PbxLive.InitialImage = CType(resources.GetObject("PbxLive.InitialImage"), Drawing.Image)
            PbxLive.Location = New System.Drawing.Point(12, 12)
            PbxLive.Name = "PbxLive"
            PbxLive.Size = New System.Drawing.Size(776, 414)
            PbxLive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            PbxLive.TabIndex = 1
            PbxLive.TabStop = False
            PbxLive.XOBorderColor = Drawing.Color.DodgerBlue
            PbxLive.XOShowBorder = False
            ' 
            ' FRMcameraNative
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(10.0F, 25.0F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ClientSize = New System.Drawing.Size(800, 649)
            Controls.Add(PbxLive)
            Controls.Add(CboCamera)
            Name = "FRMcameraNative"
            Text = "FRMcameraNative"
            CType(PbxLive, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
        End Sub

        Friend WithEvents CboCamera As UI.Control.Cbo
        Friend WithEvents PbxLive As UI.Control.Pbx
    End Class
End Namespace