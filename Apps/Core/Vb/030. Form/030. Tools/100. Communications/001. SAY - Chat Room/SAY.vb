Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Public Class SAY
    Private _Server As TcpListener = Nothing
    Private _ServerThread As Thread = Nothing
    Private _Threads As New List(Of Thread)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _Server = New TcpListener(IPAddress.Any, 8786)
        _ServerThread = New Thread(AddressOf ConnectionListener)
        _ServerThread.IsBackground = True
        _ServerThread.Start()
    End Sub

    Private Sub ConnectionListener()
        Try
            _Server.Start()
            While True
                Dim _Client As TcpClient = _Server.AcceptTcpClient
                Dim _T As New Thread(AddressOf StartChatForm)
                _T.Start(_Client)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        _Server.Stop()
    End Sub

    Private Sub StartChatForm()
        'app run...code here.
        _Threads.Remove(Thread.CurrentThread)
    End Sub
End Class
