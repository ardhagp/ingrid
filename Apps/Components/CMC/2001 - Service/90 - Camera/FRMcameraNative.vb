Imports System.ComponentModel
Imports System.Windows.Forms
Imports DirectShowLib

Namespace UI.Canvas
    Public Class FRMcameraNative

        Private graph As IFilterGraph2
        Private captureGraph As ICaptureGraphBuilder2
        Private videoDevice As DsDevice
        Private videoWindow As IVideoWindow
        Private mediaControl As IMediaControl

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMcameraNative_Load(sender As Object, e As EventArgs) Handles Me.Load
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

            videoWindow = CType(graph, IVideoWindow)
            videoWindow.put_Owner(targetHandle)
            videoWindow.put_MessageDrain(Me.Handle)
            videoWindow.put_WindowStyle(WindowStyle.Child Or WindowStyle.ClipSiblings)
            videoWindow.put_Visible(OABool.True)
            videoWindow.put_AutoShow(OABool.True)
            videoWindow.SetWindowPosition(0, 0, PbxLive.Width, PbxLive.Height)

            mediaControl = CType(graph, IMediaControl)
            mediaControl.Run()
        End Sub

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
        Private Sub PbxLive_Resize(sender As Object, e As EventArgs)
            If videoWindow IsNot Nothing Then
                videoWindow.SetWindowPosition(0, 0, PbxLive.Width, PbxLive.Height)
            End If
        End Sub

        <Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub PbxLive_VisibleChanged(sender As Object, e As EventArgs)
            If videoWindow IsNot Nothing AndAlso PbxLive.Visible Then
                videoWindow.put_Visible(OABool.True)
            End If
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMcamera_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
            StopPreview()
        End Sub

        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Private Sub FRMcameraNative_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            StartPreview(CboCamera.SelectedIndex, PbxLive.Handle)
        End Sub
    End Class
End Namespace