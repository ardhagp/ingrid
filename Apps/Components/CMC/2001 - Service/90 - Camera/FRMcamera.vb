Imports System.ComponentModel
Imports System.Drawing
Imports System.Net.NetworkInformation
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports CMCv.Ladybug.Log
Imports DirectShowLib

Namespace UI.Canvas
    Public Class FRMcamera
        Inherits UI.Canvas.FRMstandardFooter

        Private graph As IFilterGraph2
        Private captureGraph As ICaptureGraphBuilder2
        Private videoDevice As DsDevice
        Private videoWindow As IVideoWindow
        Private mediaControl As IMediaControl
        Private sampleGrabber As ISampleGrabber
        Private grabberFilter As IBaseFilter

        Private varCameraMode As LibApp.Ingrid.Global.CameraMode
        Private varDataProperties As LibApp.Ingrid.Global.Properties
        Private varFirstLoad As Boolean = True
        Public Event PhotoCaptureSuccess()

        Private _cameraWidth As Integer
        Private _cameraHeight As Integer

        Public Sub New()

            'This call is required by the designer.
            InitializeComponent()

            'Add any initialization after the InitializeComponent() call.

        End Sub

        Public Sub New(cameramode As LibApp.Ingrid.Global.CameraMode, dataproperties As LibApp.Ingrid.Global.Properties)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            varCameraMode = cameramode
            varDataProperties = dataproperties
        End Sub

        Public Enum [Mode]
            PhotoCamera = 1
            QRCode = 2
        End Enum

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMcamera_Load(sender As Object, e As EventArgs) Handles Me.Load
            varFirstLoad = True
            PbxOverlay.BackColor = Color.Transparent
            PbxOverlay.Parent = PbxLive
            PbxOverlay.Dock = DockStyle.Fill
            CboCamera.Items.Clear()
            If varCameraMode = LibApp.Ingrid.Global.CameraMode.PhotoCamera Then
                BtnCapture.text = "Capture"
            Else
                BtnCapture.text = "Scan QR Code"
            End If

            Dim devices As DsDevice() = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice)

            For Each device As DsDevice In devices
                CboCamera.Items.Add(device.Name)
            Next

            Dim varDeviceId As Integer = My.Settings.CameraDeviceId

            If CboCamera.Items.Count > 0 Then
                CboCamera.SelectedIndex = 0
                If CboCamera.SelectedIndex <> varDeviceId Then
                    CboCamera.SelectedIndex = varDeviceId
                ElseIf varDeviceId < 0 OrElse varDeviceId >= CboCamera.Items.Count Then
                    varDeviceId = 0
                End If
            End If
            varFirstLoad = False
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub StartPreview(deviceIndex As Integer, targetHandle As IntPtr)
            Dim devices = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice)
            If devices Is Nothing OrElse devices.Length = 0 Then
                Debug.WriteLine("No video devices found.")
                Return
            End If
            If deviceIndex < 0 OrElse deviceIndex >= devices.Length Then
                Debug.WriteLine("Invalid device index.")
                Return
            End If

            videoDevice = devices(deviceIndex)

            graph = CType(New FilterGraph(), IFilterGraph2)
            captureGraph = CType(New CaptureGraphBuilder2(), ICaptureGraphBuilder2)
            captureGraph.SetFiltergraph(graph)

            Dim capFilter As IBaseFilter = Nothing
            Dim hr = graph.AddSourceFilterForMoniker(videoDevice.Mon, Nothing, videoDevice.Name, capFilter)
            Debug.WriteLine("AddSourceFilter HR = " & hr)

            If hr <> 0 OrElse capFilter Is Nothing Then
                Debug.WriteLine("Failed to add source filter.")
                Return
            End If

            ' Create SampleGrabber
            sampleGrabber = CType(New SampleGrabber(), ISampleGrabber)
            grabberFilter = CType(sampleGrabber, IBaseFilter)

            ' Configure SampleGrabber
            Dim mt As New AMMediaType With {
                .majorType = MediaType.Video,
                .subType = MediaSubType.RGB24,
                .formatType = FormatType.VideoInfo
            }
            sampleGrabber.SetMediaType(mt)

            ' Add SampleGrabber to graph
            graph.AddFilter(grabberFilter, "SampleGrabber")

            ' Connect SampleGrabber
            'captureGraph.RenderStream(PinCategory.Capture, MediaType.Video, capFilter, grabberFilter, Nothing)

            ' Set callback mode
            sampleGrabber.SetBufferSamples(True)
            sampleGrabber.SetOneShot(False)

            hr = captureGraph.RenderStream(PinCategory.Capture, MediaType.Video, capFilter, grabberFilter, Nothing)
            Debug.WriteLine("RenderStream HR = " & hr)
            If hr <> 0 Then
                Debug.WriteLine("Failed to render stream.")
                Return
            End If

            ' After successful RenderStream
            Dim streamConfigObj As Object = Nothing
            captureGraph.FindInterface(PinCategory.Capture, MediaType.Video, capFilter, GetType(IAMStreamConfig).GUID, streamConfigObj)

            Dim streamConfig As IAMStreamConfig = TryCast(streamConfigObj, IAMStreamConfig)

            If streamConfig IsNot Nothing Then
                'Dim mt As AMMediaType = Nothing
                streamConfig.GetFormat(mt)

                Dim vih As VideoInfoHeader = CType(Marshal.PtrToStructure(mt.formatPtr, GetType(VideoInfoHeader)), VideoInfoHeader)
                _cameraWidth = vih.BmiHeader.Width
                _cameraHeight = vih.BmiHeader.Height

                DsUtils.FreeAMMediaType(mt)
            End If

            videoWindow = CType(graph, IVideoWindow)
            videoWindow.put_Owner(targetHandle)
            videoWindow.put_MessageDrain(Me.Handle)
            videoWindow.put_WindowStyle(WindowStyle.Child Or WindowStyle.ClipSiblings)
            videoWindow.put_Visible(OABool.True)
            videoWindow.put_AutoShow(OABool.True)
            'videoWindow.SetWindowPosition(0, 0, PbxLive.Width, PbxLive.Height)
            Dim r As Rectangle = GetAspectRect(PbxLive.Width, PbxLive.Height)
            videoWindow.SetWindowPosition(r.X, r.Y, r.Width, r.Height)


            mediaControl = CType(graph, IMediaControl)
            mediaControl.Run()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Function GetAspectRect(containerWidth As Integer, containerHeight As Integer) As Rectangle
            If _cameraWidth <= 0 OrElse _cameraHeight <= 0 Then
                Return New Rectangle(0, 0, containerWidth, containerHeight)
            End If

            Dim videoAR As Double = _cameraWidth / _cameraHeight
            Dim containerAR As Double = containerWidth / containerHeight

            Dim w As Integer
            Dim h As Integer
            Dim x As Integer
            Dim y As Integer

            If containerAR > videoAR Then
                ' Container wider → limit by height
                h = containerHeight
                w = CInt(h * videoAR)
                x = (containerWidth - w) \ 2
                y = 0
            Else
                ' Container taller → limit by width
                w = containerWidth
                h = CInt(w / videoAR)
                x = 0
                y = (containerHeight - h) \ 2
            End If

            Return New Rectangle(x, y, w, h)
        End Function

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub StopPreview()
            If mediaControl IsNot Nothing Then mediaControl.Stop()
            If videoWindow IsNot Nothing Then
                videoWindow.put_Visible(OABool.False)
                videoWindow.put_Owner(IntPtr.Zero)
            End If
            videoWindow = Nothing
            mediaControl = Nothing
            graph = Nothing
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Function CaptureFrame() As Bitmap
            Dim bufferSize As Integer = 0
            sampleGrabber.GetCurrentBuffer(bufferSize, IntPtr.Zero)

            If bufferSize <= 0 Then
                Return Nothing
            End If

            Dim buffer As Byte() = New Byte(bufferSize - 1) {}
            Dim handle As GCHandle = GCHandle.Alloc(buffer, GCHandleType.Pinned)

            Try
                sampleGrabber.GetCurrentBuffer(bufferSize, handle.AddrOfPinnedObject())

                Dim bmp As New Bitmap(_cameraWidth, _cameraHeight, Imaging.PixelFormat.Format24bppRgb)
                Dim bmpData As Imaging.BitmapData = bmp.LockBits(New Rectangle(0, 0, bmp.Width, bmp.Height),
                                                         Imaging.ImageLockMode.WriteOnly,
                                                         bmp.PixelFormat)

                Marshal.Copy(buffer, 0, bmpData.Scan0, bufferSize)
                bmp.UnlockBits(bmpData)

                bmp.RotateFlip(RotateFlipType.RotateNoneFlipY) ' DirectShow stores upside-down

                Return bmp
            Finally
                handle.Free()
            End Try
        End Function


        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub CboCamera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCamera.SelectedIndexChanged
            StopPreview()
            StartPreview(CboCamera.SelectedIndex, PbxLive.Handle)
            If Not varFirstLoad Then
                My.Settings.CameraDeviceId = CboCamera.SelectedIndex
                My.Settings.Save()
            End If
        End Sub

        <Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub PbxLive_Resize(sender As Object, e As EventArgs) Handles PbxLive.Resize
            If videoWindow IsNot Nothing Then
                Dim r As Rectangle = GetAspectRect(PbxLive.Width, PbxLive.Height)
                'videoWindow.SetWindowPosition(0, 0, PbxLive.Width, PbxLive.Height)
                videoWindow.SetWindowPosition(r.X, r.Y, r.Width, r.Height)
            End If
        End Sub

        <Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub PbxLive_VisibleChanged(sender As Object, e As EventArgs) Handles PbxLive.VisibleChanged
            If videoWindow IsNot Nothing AndAlso PbxLive.Visible Then
                videoWindow.put_Visible(OABool.True)
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMcamera_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
            StopPreview()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMcamera_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            StartPreview(CboCamera.SelectedIndex, PbxLive.Handle)
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
            Me.Close()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub BtnCapture_Click(sender As Object, e As EventArgs) Handles BtnCapture.Click
            Dim bmp As Bitmap = CaptureFrame()

            If bmp Is Nothing Then
                MessageBox.Show("Failed to capture frame.")
                Return
            End If


            ' ----------------------------------------------------
            ' 1. Compute overlay rectangle (same math as Paint)
            ' ----------------------------------------------------

            Dim previewRect As Rectangle = GetAspectRect(PbxLive.Width, PbxLive.Height)
            Dim overlayRect As Rectangle = GetOverlayRect()

            ' Convert overlay → preview coordinates
            Dim relativeX As Double = (overlayRect.X - previewRect.X) / previewRect.Width
            Dim relativeY As Double = (overlayRect.Y - previewRect.Y) / previewRect.Height
            Dim relativeW As Double = overlayRect.Width / previewRect.Width
            Dim relativeH As Double = overlayRect.Height / previewRect.Height

            ' Convert preview → raw frame coordinates
            Dim cropX As Integer = CInt(relativeX * _cameraWidth)
            Dim cropY As Integer = CInt(relativeY * _cameraHeight)
            Dim cropW As Integer = CInt(relativeW * _cameraWidth)
            Dim cropH As Integer = CInt(relativeH * _cameraHeight)

            Dim cropRectRaw As New Rectangle(cropX, cropY, cropW, cropH)

            'Dim cropRect As Rectangle = GetOverlayRect()
            'PbxOverlay.XOBorderColor = Color.Red

            ' ----------------------------------------------------
            ' 2. Crop the snapshot to match overlay
            ' ----------------------------------------------------
            Dim cropped As New Bitmap(cropRectRaw.Width, cropRectRaw.Height)
            Using g = Graphics.FromImage(cropped)
                g.DrawImage(bmp,
                    New Rectangle(0, 0, cropRectRaw.Width, cropRectRaw.Height),
                    cropRectRaw,
                    GraphicsUnit.Pixel)
            End Using

            If varCameraMode = LibApp.Ingrid.Global.CameraMode.PhotoCamera Then
                ' Save photo to Ingrid storage
                Dim savePath As String = IO.Path.Combine(Application.StartupPath, "Captured_" & Now.Ticks & ".jpg")
                Dim savePathcrop As String = IO.Path.Combine(Application.StartupPath, "Cropped_" & Now.Ticks & ".jpg")
                bmp.Save(savePath, Imaging.ImageFormat.Jpeg)
                cropped.Save(savePathcrop, Imaging.ImageFormat.Jpeg)
                PbxSnapshot.Image = cropped

                RaiseEvent PhotoCaptureSuccess()
            Else
                ' QR mode → decode
                'Dim reader As New ZXing.BarcodeReader()
                'Dim result = reader.Decode(bmp)

                'If result IsNot Nothing Then
                '    MessageBox.Show("QR Code: " & result.Text)
                'Else
                '    MessageBox.Show("No QR code detected.")
                'End If
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Function GetOverlayRect() As Rectangle
            If varCameraMode = LibApp.Ingrid.Global.CameraMode.PhotoCamera Then
                Dim w = CInt(PbxOverlay.Width * 0.6)
                Dim h = CInt(w * 4 / 3)
                Dim x = (PbxOverlay.Width - w) \ 2
                Dim y = (PbxOverlay.Height - h) \ 2
                Return New Rectangle(x, y, w, h)
            Else
                Dim size = CInt(Math.Min(PbxOverlay.Width, PbxOverlay.Height) * 0.6)
                Dim x = (PbxOverlay.Width - size) \ 2
                Dim y = (PbxOverlay.Height - size) \ 2
                Return New Rectangle(x, y, size, size)
            End If
        End Function


        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub PbxOverlay_Paint(sender As Object, e As PaintEventArgs) Handles PbxOverlay.Paint
            Dim g = e.Graphics
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

            If varCameraMode = LibApp.Ingrid.Global.CameraMode.PhotoCamera Then
                ' Portrait box (3:4)
                Dim w = CInt(PbxOverlay.Width * 0.6)
                Dim h = CInt(w * 4 / 3)
                Dim x = (PbxOverlay.Width - w) \ 2
                Dim y = (PbxOverlay.Height - h) \ 2

                Using pen As New Pen(Color.FromArgb(200, Color.White), 3)
                    g.DrawRectangle(pen, x, y, w, h)
                End Using

            Else
                ' Square box (QR)
                Dim size = CInt(Math.Min(PbxOverlay.Width, PbxOverlay.Height) * 0.6)
                Dim x = (PbxOverlay.Width - size) \ 2
                Dim y = (PbxOverlay.Height - size) \ 2

                Using pen As New Pen(Color.FromArgb(200, Color.Lime), 3)
                    g.DrawRectangle(pen, x, y, size, size)
                End Using
            End If
        End Sub
    End Class
End Namespace