Imports System.Runtime.Versioning

Namespace UI.Control
    ''' <project>CMCC</project>
    ''' <author>Ardha Gp</author>
    ''' <summary>
    ''' Datagridview dengan warna random dan nomor urut baris.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class dgn
        Public Event XOSelected()
        'Public Event SLF_NewGridColor()

        <SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            Call ActivateLicenses()
            'MyBase.AlternatingRowsDefaultCellStyle.BackColor = CBS.WarnaAcakBaru(190, 190, 190, 255, 255, 255)
            MyBase.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            MyBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            MyBase.ColumnHeadersHeightSizeMode = system.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            MyBase.ColumnHeadersHeight = 43
            MyBase.Font = globalFontDgn
            MyBase.EnableHeadersVisualStyles = False
            MyBase.ColumnHeadersBorderStyle = system.Windows.Forms.DataGridViewHeaderBorderStyle.None
            MyBase.ColumnHeadersDefaultCellStyle.BackColor = Drawing.Color.YellowGreen
            MyBase.ColumnHeadersDefaultCellStyle.SelectionBackColor = Drawing.Color.YellowGreen
            MyBase.ColumnHeadersDefaultCellStyle.SelectionForeColor = Drawing.Color.Black
            MyBase.RowHeadersBorderStyle = system.Windows.Forms.DataGridViewHeaderBorderStyle.None
            MyBase.RowHeadersDefaultCellStyle.BackColor = Drawing.Color.YellowGreen
            MyBase.RowHeadersDefaultCellStyle.SelectionBackColor = Drawing.Color.Yellow
            MyBase.RowHeadersDefaultCellStyle.SelectionForeColor = Drawing.Color.Black
            MyBase.CellBorderStyle = system.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            MyBase.StandardTab = True
            MyBase.BorderStyle = system.Windows.Forms.BorderStyle.None
            MyBase.DoubleBuffered = True
        End Sub


        Private _varGunakanNomorBaris As Boolean
        Public Property XOGunakanNomorBaris() As Boolean
            Get
                Return _varGunakanNomorBaris
            End Get
            Set(ByVal value As Boolean)
                _varGunakanNomorBaris = value
            End Set
        End Property

        Private _varGroupFirstRows As Boolean
        Public Property XOGroupFirstRows As Boolean
            Get
                Return _varGroupFirstRows
            End Get
            Set(value As Boolean)
                _varGroupFirstRows = value
            End Set
        End Property

        Private Shared Function RGB(p1 As Integer) As System.Drawing.Color
            Throw New NotImplementedException
        End Function

        <SupportedOSPlatform("windows")>
        Private Sub dgn_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles Me.CellFormatting
            If XOGroupFirstRows Then
                If e.RowIndex > 0 And e.ColumnIndex = 0 Then
                    If MyBase.Item(0, e.RowIndex - 1).Value Is e.Value Then
                        e.Value = String.Empty
                        'MyBase.AdvancedCellBorderStyle.Top = system.Windows.Forms.DataGridViewAdvancedCellBorderStyle.None
                        'MyBase.Rows(e.RowIndex).DefaultCellStyle.BackColor = System.Drawing.Color.White
                    ElseIf e.RowIndex < MyBase.Rows.Count - 1 Then

                    End If
                End If

            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub dgn_CellMouseDown(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Me.CellMouseDown
            If (e.Button = System.Windows.Forms.MouseButtons.Right) Or (e.Button = System.Windows.Forms.MouseButtons.Left) Then
                Try
                    MyBase.CurrentCell = Me(e.ColumnIndex, e.RowIndex)
                    RaiseEvent XOSelected()
                Catch ex As Exception
                    'do nothing
                End Try
            End If
        End Sub

        Public Enum eGETNewColor
            Yes
            No
        End Enum

        <SupportedOSPlatform("windows")>
        Public Sub XOGETNewColor()
            Call GENERATENewColor()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub dgn_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
            Call GENERATENewColor()
        End Sub

        Private Sub dgn_SelectionChanged(sender As Object, e As EventArgs) Handles Me.SelectionChanged
            RaiseEvent XOSelected()
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub GENERATENewColor()
            MyBase.AlternatingRowsDefaultCellStyle.BackColor = ControlCodeBase.WarnaAcakBaru(190, 255, 190, 255, 90, 190)
        End Sub
    End Class
End Namespace