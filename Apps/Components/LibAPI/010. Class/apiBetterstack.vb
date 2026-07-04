Imports System.Text

Namespace Api.Betterstack
    Public Class Heartbeats
        Private endpoints As String = "https://uptime.betterstack.com/api/v1/heartbeat/"
        Private ReadOnly client As New System.Net.Http.HttpClient

        Public Async Function SendSuccess(token As String) As Task
            endpoints &= token
            Await client.GetAsync(endpoints)
        End Function

        Public Async Function SendFailure(token As String) As Task
            endpoints &= token
            Await client.GetAsync(endpoints & "/fail")
        End Function
    End Class
End Namespace