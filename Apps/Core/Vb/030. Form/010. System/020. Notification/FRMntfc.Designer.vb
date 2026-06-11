Namespace UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FRMntfc
        Inherits CMCv.ui.canvas.FRMstandardFooter

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
            Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
            BtnClose = New CMCv.UI.Control.Btn(components)
            DgnNotification = New CMCv.UI.Control.dgn(components)
            notification_message = New DataGridViewTextBoxColumn()
            notification_datetime = New DataGridViewTextBoxColumn()
            PnlBottomButton.SuspendLayout()
            CType(SLFLogo, ComponentModel.ISupportInitialize).BeginInit()
            pnl_.SuspendLayout()
            SLFPanel.SuspendLayout()
            CType(SLFBackground, ComponentModel.ISupportInitialize).BeginInit()
            CType(DgnNotification, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' PnlBottomButton
            ' 
            PnlBottomButton.Controls.Add(BtnClose)
            PnlBottomButton.Location = New Point(0, 699)
            PnlBottomButton.Margin = New Padding(8, 12, 8, 12)
            PnlBottomButton.Size = New Size(1095, 96)
            PnlBottomButton.Controls.SetChildIndex(BtnClose, 0)
            ' 
            ' pnl_
            ' 
            pnl_.Margin = New Padding(8, 12, 8, 12)
            pnl_.Size = New Size(1095, 104)
            ' 
            ' SLFPanel
            ' 
            SLFPanel.Controls.Add(DgnNotification)
            SLFPanel.Margin = New Padding(8, 12, 8, 12)
            SLFPanel.Size = New Size(1095, 795)
            SLFPanel.Controls.SetChildIndex(PnlBottomButton, 0)
            SLFPanel.Controls.SetChildIndex(DgnNotification, 0)
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
            BtnClose.Location = New Point(909, 12)
            BtnClose.Margin = New Padding(5, 6, 5, 6)
            BtnClose.Name = "BtnClose"
            BtnClose.Size = New Size(167, 77)
            BtnClose.TabIndex = 1
            BtnClose.Text = "&Close"
            BtnClose.UseVisualStyleBackColor = False
            BtnClose.XOButtonType = CMCV.UI.Control.ControlCodeBase.buttonType.No
            BtnClose.XOShowBorderOnFocus = False
            BtnClose.XOValidateAllInput = False
            BtnClose.XOValidateAllInputTag = Nothing
            ' 
            ' DgnNotification
            ' 
            DgnNotification.AllowUserToAddRows = False
            DgnNotification.AllowUserToDeleteRows = False
            DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(190), CByte(247), CByte(189))
            DgnNotification.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
            DgnNotification.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
            DgnNotification.BorderStyle = BorderStyle.None
            DgnNotification.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            DgnNotification.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = Color.YellowGreen
            DataGridViewCellStyle5.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle5.SelectionBackColor = Color.YellowGreen
            DataGridViewCellStyle5.SelectionForeColor = Color.Black
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
            DgnNotification.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
            DgnNotification.ColumnHeadersHeight = 43
            DgnNotification.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            DgnNotification.Columns.AddRange(New DataGridViewColumn() {notification_message, notification_datetime})
            DgnNotification.Dock = DockStyle.Fill
            DgnNotification.EnableHeadersVisualStyles = False
            DgnNotification.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DgnNotification.Location = New Point(0, 0)
            DgnNotification.Margin = New Padding(5, 6, 5, 6)
            DgnNotification.Name = "DgnNotification"
            DgnNotification.ReadOnly = True
            DgnNotification.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = Color.YellowGreen
            DataGridViewCellStyle6.Font = New Font("Verdana", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = Color.Yellow
            DataGridViewCellStyle6.SelectionForeColor = Color.Black
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
            DgnNotification.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
            DgnNotification.RowHeadersWidth = 62
            DgnNotification.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            DgnNotification.Size = New Size(1095, 699)
            DgnNotification.StandardTab = True
            DgnNotification.TabIndex = 996
            DgnNotification.XOIsGroupFirstRow = False
            DgnNotification.XOIsShowRowNumber = True
            ' 
            ' notification_message
            ' 
            notification_message.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            notification_message.DataPropertyName = "notification_message"
            notification_message.HeaderText = "Message"
            notification_message.MinimumWidth = 8
            notification_message.Name = "notification_message"
            notification_message.ReadOnly = True
            ' 
            ' notification_datetime
            ' 
            notification_datetime.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            notification_datetime.DataPropertyName = "notification_datetime"
            notification_datetime.HeaderText = "At Time"
            notification_datetime.MinimumWidth = 8
            notification_datetime.Name = "notification_datetime"
            notification_datetime.ReadOnly = True
            notification_datetime.Width = 98
            ' 
            ' FRMntfc
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            ClientSize = New Size(1095, 921)
            KeyPreview = True
            Margin = New Padding(22, 44, 22, 44)
            Name = "FRMntfc"
            PnlBottomButton.ResumeLayout(False)
            CType(SLFLogo, ComponentModel.ISupportInitialize).EndInit()
            pnl_.ResumeLayout(False)
            pnl_.PerformLayout()
            SLFPanel.ResumeLayout(False)
            CType(SLFBackground, ComponentModel.ISupportInitialize).EndInit()
            CType(DgnNotification, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

        Friend WithEvents BtnClose As CMCv.UI.Control.Btn
        Friend WithEvents DgnNotification As CMCv.UI.Control.dgn
        Friend WithEvents notification_message As DataGridViewTextBoxColumn
        Friend WithEvents notification_datetime As DataGridViewTextBoxColumn
    End Class
End Namespace