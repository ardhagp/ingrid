Imports System.Runtime.Versioning

Public Class DAR_SinglePhotoViewer
    Private _FILE As String
    Private _IMAGE As Image
    Private _Type As String

    Public Sub New(ByVal File As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _FILE = File
        _Type = "String"
    End Sub

    Public Sub New(ByVal Photo As Image)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _IMAGE = Photo
        _Type = "Image"
    End Sub

    <SupportedOSPlatform("windows")>
    Private Sub DAR_SinglePhotoViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _Type = "String" Then
            PctbxPhoto.ImageLocation = _FILE
        ElseIf _Type = "Image" Then
            If varTextmark = String.Empty Then
                PctbxPhoto.Image = _IMAGE
            Else
                PctbxPhoto.Image = CMCv.ImageEditor.Proccessor.Editor.Watermarker(_IMAGE, varTextmark)
            End If
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class
