Imports System.Runtime.Versioning

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
        MyBase.ColumnHeadersHeightSizeMode = Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        MyBase.ColumnHeadersHeight = 43
        MyBase.Font = globalFontDgn
        MyBase.EnableHeadersVisualStyles = False
        MyBase.ColumnHeadersBorderStyle = Windows.Forms.DataGridViewHeaderBorderStyle.None
        MyBase.ColumnHeadersDefaultCellStyle.BackColor = Drawing.Color.YellowGreen
        MyBase.ColumnHeadersDefaultCellStyle.SelectionBackColor = Drawing.Color.YellowGreen
        MyBase.ColumnHeadersDefaultCellStyle.SelectionForeColor = Drawing.Color.Black
        MyBase.RowHeadersBorderStyle = Windows.Forms.DataGridViewHeaderBorderStyle.None
        MyBase.RowHeadersDefaultCellStyle.BackColor = Drawing.Color.YellowGreen
        MyBase.RowHeadersDefaultCellStyle.SelectionBackColor = Drawing.Color.Yellow
        MyBase.RowHeadersDefaultCellStyle.SelectionForeColor = Drawing.Color.Black
        MyBase.CellBorderStyle = Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        MyBase.StandardTab = True
        MyBase.BorderStyle = Windows.Forms.BorderStyle.None
        MyBase.DoubleBuffered = True
    End Sub


    Private varGunakanNomorBaris As Boolean
    Public Property XOGunakanNomorBaris() As Boolean
        Get
            Return varGunakanNomorBaris
        End Get
        Set(ByVal value As Boolean)
            varGunakanNomorBaris = value
        End Set
    End Property

    Private varGroupFirstRows As Boolean
    Public Property XOGroupFirstRows As Boolean
        Get
            Return varGroupFirstRows
        End Get
        Set(value As Boolean)
            varGroupFirstRows = value
        End Set
    End Property

    Private Shared Function RGB(p1 As Integer) As System.Drawing.Color
        Throw New NotImplementedException
    End Function

    Private Sub dgn_CellFormatting(sender As Object, e As Windows.Forms.DataGridViewCellFormattingEventArgs) Handles Me.CellFormatting
        If (XOGroupFirstRows) AndAlso (e.RowIndex > 0 AndAlso e.ColumnIndex = 0) Then
            If MyBase.Item(0, e.RowIndex - 1).Value Is e.Value Then
                e.Value = String.Empty
                'MyBase.AdvancedCellBorderStyle.Top = Windows.Forms.DataGridViewAdvancedCellBorderStyle.None
                'MyBase.Rows(e.RowIndex).DefaultCellStyle.BackColor = System.Drawing.Color.White
            ElseIf e.RowIndex < MyBase.Rows.Count - 1 Then
                'TODO: Create formating 
            End If
        End If
    End Sub

    Private Sub dgn_CellMouseDown(sender As Object, e As Windows.Forms.DataGridViewCellMouseEventArgs) Handles Me.CellMouseDown
        If (e.Button = Windows.Forms.MouseButtons.Right) Or (e.Button = Windows.Forms.MouseButtons.Left) Then
            Try
                MyBase.CurrentCell = Me(e.ColumnIndex, e.RowIndex)
                RaiseEvent XOSelected()
            Catch ex As Exception
                'do nothing
            End Try
        End If
    End Sub

    Public Enum EGetNewColor
        Yes
        No
    End Enum

    Public Sub XOGeTNewColor()
        Call GenerateNewColor()
    End Sub

    Private Sub dgn_HandleCreated(sender As Object, e As EventArgs) Handles Me.HandleCreated
        Call GenerateNewColor()
    End Sub

    Private Sub dgn_SelectionChanged(sender As Object, e As EventArgs) Handles Me.SelectionChanged
        RaiseEvent XOSelected()
    End Sub

    Private Sub GenerateNewColor()
        MyBase.AlternatingRowsDefaultCellStyle.BackColor = ControlCodeBase.WarnaAcakBaru(190, 255, 190, 255, 90, 190)
    End Sub
End Class

