'Imports System.Text

Namespace Api.Betterstack
    ''' <summary>
    ''' The Heartbeats class is used to send heartbeat signals to the Betterstack Uptime API. It provides methods to send success and failure signals for monitoring the health of an application or service. The class uses an HttpClient to make asynchronous GET requests to the Betterstack API endpoints.
    ''' </summary>
    Public Class Heartbeats
        Private endpoints As String = "https://uptime.betterstack.com/api/v1/heartbeat/"
        Private ReadOnly client As New System.Net.Http.HttpClient

        ''' <summary>
        ''' Sends a success heartbeat signal to the Betterstack Uptime API for the specified token. This method appends the token to the endpoint URL and makes an asynchronous GET request to indicate that the monitored service is healthy.
        ''' </summary>
        ''' <param name="token">The token identifying the heartbeat to send.</param>
        ''' <returns>A task representing the asynchronous operation.</returns>
        Public Async Function SendSuccess(token As String) As Task
            endpoints &= token
            Await client.GetAsync(endpoints)
        End Function

        ''' <summary>
        ''' Sends a failure heartbeat signal to the Betterstack Uptime API for the specified token. This method appends the token to the endpoint URL and makes an asynchronous GET request to indicate that the monitored service has failed or is unhealthy.
        ''' </summary>
        ''' <param name="token">The token identifying the heartbeat to send.</param>
        ''' <returns>A task representing the asynchronous operation.</returns>
        Public Async Function SendFailure(token As String) As Task
            endpoints &= token
            Await client.GetAsync(endpoints & "/fail")
        End Function
    End Class
End Namespace