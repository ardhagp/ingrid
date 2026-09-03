Namespace UI.Canvas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMconn
        Inherits CMCv.UI.Canvas.FRMstandardFindFooter

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMconn))
            Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
            DgnConnection = New CMCv.UI.Control.Dgn(components)
            id = New DataGridViewTextBoxColumn()
            connectionname = New DataGridViewTextBoxColumn()
            databaseengine = New DataGridViewTextBoxColumn()
            serveraddress = New DataGridViewTextBoxColumn()
            serverport = New DataGridViewTextBoxColumn()
            defaultconnection = New DataGridViewCheckBoxColumn()
            spring = New DataGridViewTextBoxColumn()
            Btn_Close = New CMCv.UI.Control.Btn(components)
            PnlBottomButton.SuspendLayout()
            PnlFind.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            CType(XOLogo, ComponentModel.ISupportInitialize).BeginInit()
            CType(DgnConnection, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' PnlBottomButton
            ' 
            PnlBottomButton.Controls.Add(Btn_Close)
            PnlBottomButton.Location = New Point(0, 847)
            PnlBottomButton.Margin = New Padding(7, 10, 7, 10)
            PnlBottomButton.Controls.SetChildIndex(Btn_Close, 0)
            ' 
            ' BtnClear
            ' 
            BtnClear.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
            BtnClear.FlatAppearance.BorderSize = 2
            BtnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
            ' 
            ' TxtFind
            ' 
            TxtFind.Margin = New Padding(7, 5, 7, 5)
            ' 
            ' SLFLogo
            ' 
            SLFLogo.BackColor = Color.Transparent
            SLFLogo.Image = CType(resources.GetObject("SLFLogo.Image"), Image)
            SLFLogo.Margin = New Padding(7, 5, 7, 5)
            SLFLogo.Size = New Size(84, 98)
            ' 
            ' SLFSubNamaForm
            ' 
            SLFSubNamaForm.Margin = New Padding(7, 0, 7, 0)
            SLFSubNamaForm.Size = New Size(311, 25)
            SLFSubNamaForm.Text = "Configure Ingrid database connection"
            ' 
            ' SLFNamaForm
            ' 
            SLFNamaForm.Margin = New Padding(7, 0, 7, 0)
            SLFNamaForm.Size = New Size(359, 48)
            SLFNamaForm.Text = "Connection Settings"
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(7, 10, 7, 10)
            pnl_.Size = New Size(1307, 113)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(DgnConnection)
            SLFPanel.Location = New Point(0, 113)
            SLFPanel.Margin = New Padding(7, 10, 7, 10)
            SLFPanel.Size = New Size(1307, 943)
            SLFPanel.Controls.SetChildIndex(PnlFind, 0)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(DgnConnection, 0)
            ' 
            ' XOLogo
            ' 
            XOLogo.Size = New Size(84, 98)
            ' 
            ' DgnConnection
            ' 
            DgnConnection.AllowUserToAddRows = False
            DgnConnection.AllowUserToDeleteRows = False
            DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(197), CByte(224), CByte(178))
            DgnConnection.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            DgnConnection.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnConnection.BorderStyle = BorderStyle.None
            DgnConnection.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnConnection.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = Color.YellowGreen
            DataGridViewCellStyle2.Font = New Font("Verdana", 8F)
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle2.SelectionForeColor = Color.Black
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
            DgnConnection.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            DgnConnection.ColumnHeadersHeight = 43
            DgnConnection.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnConnection.Columns.AddRange(New DataGridViewColumn() {id, connectionname, databaseengine, serveraddress, serverport, defaultconnection, spring})
            DgnConnection.Dock = DockStyle.Fill
            DgnConnection.EnableHeadersVisualStyles = False
            DgnConnection.Font = New Font("Verdana", 8F)
            DgnConnection.Location = New Point(0, 88)
            DgnConnection.Margin = New Padding(6, 5, 6, 5)
            DgnConnection.Name = "DgnConnection"
            DgnConnection.ReadOnly = True
            DgnConnection.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = Color.YellowGreen
            DataGridViewCellStyle3.Font = New Font("Verdana", 8F)
            DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle3.SelectionForeColor = Color.Black
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
            DgnConnection.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            DgnConnection.RowHeadersWidth = 62
            DgnConnection.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnConnection.Size = New Size(1307, 759)
            DgnConnection.StandardTab = True
            DgnConnection.TabIndex = 997
            DgnConnection.XOIsGroupFirstRow = False
            DgnConnection.XOIsShowRowNumber = True
            ' 
            ' id
            ' 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            id.DataPropertyName = "ID"
            id.HeaderText = "ID"
            id.MinimumWidth = 8
            id.Name = "id"
            id.ReadOnly = True
            id.Visible = False
            id.Width = 150
            ' 
            ' connectionname
            ' 
            connectionname.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            connectionname.DataPropertyName = "CONNECTIONNAME"
            connectionname.HeaderText = "CONNECTION NAME"
            connectionname.MinimumWidth = 8
            connectionname.Name = "connectionname"
            connectionname.ReadOnly = True
            connectionname.Width = 187
            ' 
            ' databaseengine
            ' 
            databaseengine.DataPropertyName = "DATABASEENGINE"
            databaseengine.HeaderText = "DB ENGINE"
            databaseengine.MinimumWidth = 8
            databaseengine.Name = "databaseengine"
            databaseengine.ReadOnly = True
            databaseengine.Width = 150
            ' 
            ' serveraddress
            ' 
            serveraddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            serveraddress.DataPropertyName = "SERVERADDRESS"
            serveraddress.HeaderText = "SERVER ADDRESS"
            serveraddress.MinimumWidth = 8
            serveraddress.Name = "serveraddress"
            serveraddress.ReadOnly = True
            serveraddress.Width = 171
            ' 
            ' serverport
            ' 
            serverport.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            serverport.DataPropertyName = "SERVERPORT"
            serverport.HeaderText = "PORT"
            serverport.MinimumWidth = 8
            serverport.Name = "serverport"
            serverport.ReadOnly = True
            serverport.Width = 86
            ' 
            ' defaultconnection
            ' 
            defaultconnection.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            defaultconnection.DataPropertyName = "DEFAULTCONNECTION"
            defaultconnection.FalseValue = "0"
            defaultconnection.HeaderText = "DEFAULT"
            defaultconnection.MinimumWidth = 8
            defaultconnection.Name = "defaultconnection"
            defaultconnection.ReadOnly = True
            defaultconnection.Resizable = DataGridViewTriState.True
            defaultconnection.SortMode = DataGridViewColumnSortMode.Automatic
            defaultconnection.TrueValue = "1"
            defaultconnection.Width = 113
            ' 
            ' spring
            ' 
            spring.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            spring.HeaderText = ""
            spring.MinimumWidth = 8
            spring.Name = "spring"
            spring.ReadOnly = True
            ' 
            ' Btn_Close
            ' 
            Btn_Close.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            Btn_Close.BackColor = Color.Red
            Btn_Close.FlatAppearance.BorderColor = Color.FromArgb(CByte(195), CByte(0), CByte(0))
            Btn_Close.FlatAppearance.BorderSize = 2
            Btn_Close.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(20), CByte(20))
            Btn_Close.FlatStyle = FlatStyle.Flat
            Btn_Close.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
            Btn_Close.ForeColor = Color.White
            Btn_Close.Location = New Point(1147, 18)
            Btn_Close.Margin = New Padding(4, 5, 4, 5)
            Btn_Close.Name = "Btn_Close"
            Btn_Close.Size = New Size(143, 67)
            Btn_Close.TabIndex = 1
            Btn_Close.Text = "&Close"
            Btn_Close.UseVisualStyleBackColor = False
            Btn_Close.XOButtonType = CMCv.UI.Control.ControlCodeBase.ButtonType.No
            Btn_Close.XOShowBorderOnFocus = False
            Btn_Close.XOValidateAllInput = False
            Btn_Close.XOValidateAllInputTag = Nothing
            ' 
            ' FRMconn
            ' 
            AutoScaleDimensions = New SizeF(10F, 25F)
            ClientSize = New Size(1307, 1078)
            Icon = CType(resources.GetObject("$this.Icon"), Icon)
            Margin = New Padding(11, 5, 11, 5)
            Name = "FRMconn"
            StartPosition = FormStartPosition.CenterScreen
            PnlBottomButton.ResumeLayout(False)
            PnlFind.ResumeLayout(False)
            PnlFind.PerformLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            CType(XOLogo, ComponentModel.ISupportInitialize).EndInit()
            CType(DgnConnection, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Friend WithEvents DgnConnection As CMCv.UI.Control.Dgn
        Friend WithEvents Btn_Close As CMCv.UI.Control.Btn
        Friend WithEvents id As DataGridViewTextBoxColumn
        Friend WithEvents connectionname As DataGridViewTextBoxColumn
        Friend WithEvents databaseengine As DataGridViewTextBoxColumn
        Friend WithEvents serveraddress As DataGridViewTextBoxColumn
        Friend WithEvents serverport As DataGridViewTextBoxColumn
        Friend WithEvents defaultconnection As DataGridViewCheckBoxColumn
        Friend WithEvents spring As DataGridViewTextBoxColumn
    End Class
End Namespace