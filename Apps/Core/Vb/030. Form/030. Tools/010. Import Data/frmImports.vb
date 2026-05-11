Imports System.IO
Imports System.Runtime.Versioning

Namespace UI
    Public Class FRMimports
        Private varSource As Import.Data.DataType.TypeofImports
        Private varOriginalSourceFile As String
        Private varSqlCatalog As New LibSQL.Tools.Import.MaterialMaster.Catalog

        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            varOriginalSourceFile = String.Empty
        End Sub

        Public Sub New(source As Import.Data.DataType.TypeofImports)
            InitializeComponent()
            varSource = source
            varOriginalSourceFile = String.Empty
        End Sub

        Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
            Dim varFileLoaded As Integer

            od.Filter = "Comma Separated Values|*.csv"
            od.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString
            varFileLoaded = od.ShowDialog()
            If varFileLoaded <> System.Windows.Forms.DialogResult.Cancel Then
                varOriginalSourceFile = od.FileName
                LblFileName.Text = CompactString(varOriginalSourceFile, LblFileName.Width, LblFileName.Font, TextFormatFlags.PathEllipsis)
                TxtProgress.AppendText("Preparing : " & varOriginalSourceFile & Environment.NewLine)
                TxtProgress.AppendText("Click [SAVE] to start importing your data..." & Environment.NewLine)
            End If
        End Sub

        Private Function CompactString(mystring As String, width As Integer,
font As Drawing.Font,
formatflags As System.Windows.Forms.TextFormatFlags) As String

            Dim varResult = New String(mystring.ToCharArray())

            TextRenderer.MeasureText(varResult, font, New Drawing.Size(width, 0),
            formatflags Or TextFormatFlags.WordBreak)

            Return varResult
        End Function

        <SupportedOSPlatform("windows")>
        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            If varOriginalSourceFile <> String.Empty Then
                TxtProgress.AppendText("Checking if your file exist... ")
                If File.Exists(varOriginalSourceFile) Then
                    Select Case varSource
                        Case Import.Data.DataType.TypeofImports.MaterialMasterCatalog
                            varSqlCatalog.Execute(varDataProperties, TxtProgress, varOriginalSourceFile)
                        Case Import.Data.DataType.TypeofImports.MaterialMasterPlant
                            'nothing
                    End Select
                End If
            Else
                TxtProgress.AppendText("No file selected." & Environment.NewLine)
            End If
        End Sub

        Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
            Me.Close()
        End Sub
    End Class
End Namespace