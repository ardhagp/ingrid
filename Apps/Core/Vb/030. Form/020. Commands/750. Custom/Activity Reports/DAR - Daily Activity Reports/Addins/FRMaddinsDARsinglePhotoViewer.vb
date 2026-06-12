Imports System.Runtime.Versioning

Namespace UI.Canvas
    Public Class FRMaddinsDARsinglePhotoViewer
        Private varFile As String
        Private varImage As Image
        Private varType As String

        Public Sub New(file As String)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            varFile = file
            varType = "String"
        End Sub

        Public Sub New(photo As Image)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            varImage = photo
            varType = "Image"
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub FRMaddinsDARsinglePhotoViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If varType = "String" Then
                PctbxPhoto.ImageLocation = varFile
            ElseIf varType = "Image" Then
                If varTextmark = String.Empty Then
                    PctbxPhoto.Image = varImage
                Else
                    PctbxPhoto.Image = CMCv.ImageEditor.Proccessor.Editor.WaterMarker(varImage, varTextmark)
                End If
            End If
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
            Me.Close()
        End Sub
    End Class
End Namespace