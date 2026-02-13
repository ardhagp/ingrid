Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Namespace UI
    Public Class FRMsay
        Private varServer As TcpListener = Nothing
        Private varServerThread As Thread = Nothing
        Private varThreads As New List(Of Thread)

        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            varServer = New TcpListener(IPAddress.Any, 8786)
            varServerThread = New Thread(AddressOf ConnectionListener)
            varServerThread.IsBackground = True
            varServerThread.Start()
        End Sub

        Private Sub ConnectionListener()
            Try
                varServer.Start()
                While True
                    Dim varClient As TcpClient = varServer.AcceptTcpClient
                    Dim varThread As New Thread(AddressOf StartChatForm)
                    varThread.Start(varClient)
                End While
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            varServer.Stop()
        End Sub

        Private Sub StartChatForm()
            'app run...code here.
            varThreads.Remove(Thread.CurrentThread)
        End Sub
    End Class
End Namespace