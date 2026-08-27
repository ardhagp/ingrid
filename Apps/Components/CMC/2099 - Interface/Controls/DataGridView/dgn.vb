Namespace UI.Control
    ''' <summary>
    ''' This control is a custom DataGridView that provides additional features and customization options for displaying tabular data in a Windows Forms application. It includes properties for showing row numbers, grouping rows, and customizing the appearance of the grid. The control also raises events when a cell is selected or when the selection changes, allowing developers to handle user interactions effectively.
    ''' </summary>
    Public Class Dgn
        Public Event XOSelected()

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            Call ActivateLicenses()
            'MyBase.AlternatingRowsDefaultCellStyle.BackColor = CBS.NewRandomColor(190, 190, 190, 255, 255, 255)
            MyBase.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            MyBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            MyBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            MyBase.ColumnHeadersHeight = 43
            MyBase.Font = globalFontDgn
            MyBase.EnableHeadersVisualStyles = False
            MyBase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            MyBase.ColumnHeadersDefaultCellStyle.BackColor = Drawing.Color.YellowGreen
            MyBase.ColumnHeadersDefaultCellStyle.SelectionBackColor = Drawing.Color.YellowGreen
            MyBase.ColumnHeadersDefaultCellStyle.SelectionForeColor = Drawing.Color.Black
            MyBase.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            MyBase.RowHeadersDefaultCellStyle.BackColor = Drawing.Color.YellowGreen
            MyBase.RowHeadersDefaultCellStyle.SelectionBackColor = Drawing.Color.Yellow
            MyBase.RowHeadersDefaultCellStyle.SelectionForeColor = Drawing.Color.Black
            MyBase.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            MyBase.StandardTab = True
            MyBase.BorderStyle = System.Windows.Forms.BorderStyle.None
            MyBase.BackgroundColor = System.Drawing.Color.FromArgb(11, 28, 45)
            MyBase.DoubleBuffered = True
        End Sub

        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Indicates whether the DataGridView displays row numbers in the row header area")>
        Private varIsShowRowNumber As Boolean
        Public Property XOIsShowRowNumber() As Boolean
            Get
                Return varIsShowRowNumber
            End Get
            Set(value As Boolean)
                varIsShowRowNumber = value
            End Set
        End Property

        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Indicates whether the first row of the DataGridView should be treated as a group header for the rows that follow")>
        Private varGroupFirstRow As Boolean
        Public Property XOIsGroupFirstRow As Boolean
            Get
                Return varGroupFirstRow
            End Get
            Set(value As Boolean)
                varGroupFirstRow = value
            End Set
        End Property

        Private Shared Function Rgb(p1 As Integer) As System.Drawing.Color
            Throw New NotImplementedException
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Dgn_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles Me.CellFormatting
            If XOIsGroupFirstRow AndAlso e.RowIndex > 0 AndAlso e.ColumnIndex = 0 AndAlso MyBase.Item(0, e.RowIndex - 1).Value Is e.Value Then
                e.Value = String.Empty
                'MyBase.AdvancedCellBorderStyle.Top = system.Windows.Forms.DataGridViewAdvancedCellBorderStyle.None
                'MyBase.Rows(e.RowIndex).DefaultCellStyle.BackColor = System.Drawing.Color.White
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Dgn_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Me.CellMouseDown
            If (e.Button = System.Windows.Forms.MouseButtons.Right) OrElse (e.Button = System.Windows.Forms.MouseButtons.Left) Then
                Try
                    MyBase.CurrentCell = Me(e.ColumnIndex, e.RowIndex)
                    RaiseEvent XOSelected()
                Catch ex As Exception
                    'do nothing
                End Try
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub XOGetNewColor()
            Call GenerateNewColor()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub Dgn_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
            Call GenerateNewColor()
        End Sub

        Private Sub Dgn_SelectionChanged(sender As Object, e As EventArgs) Handles Me.SelectionChanged
            RaiseEvent XOSelected()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub GenerateNewColor()
            MyBase.AlternatingRowsDefaultCellStyle.BackColor = UI.Control.ControlCodeBase.NewRandomColor(190, 255, 190, 255, 90, 190)
        End Sub
    End Class
End Namespace