Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports DirectShowLib

Namespace UI.Canvas
    Public Class FRMcamera
        Inherits UI.Canvas.FRMstandardFooter

        Private graph As IFilterGraph2
        Private captureGraph As ICaptureGraphBuilder2
        Private videoDevice As DsDevice
        Private videoWindow As IVideoWindow
        Private mediaControl As IMediaControl

        Private _cameraWidth As Integer
        Private _cameraHeight As Integer

        Public Sub New()

            'This call is required by the designer.
            InitializeComponent()

            'Add any initialization after the InitializeComponent() call.

        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMcamera_Load(sender As Object, e As EventArgs) Handles Me.Load
            CboCamera.Items.Clear()

            Dim devices As DsDevice() = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice)

            For Each device As DsDevice In devices
                CboCamera.Items.Add(device.Name)
            Next

            If CboCamera.Items.Count > 0 Then
                CboCamera.SelectedIndex = 0
            End If
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

            hr = captureGraph.RenderStream(PinCategory.Capture, MediaType.Video, capFilter, Nothing, Nothing)
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
                Dim mt As AMMediaType = Nothing
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
        Private Sub CboCamera_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCamera.SelectedIndexChanged
            StopPreview()
            StartPreview(CboCamera.SelectedIndex, PbxLive.Handle)
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
    End Class
End Namespace