Public Class splash
    'Public _AbleToClose As Boolean
    'Private _Tick As Integer = 0

    Private Sub _ExecuteTime_Tick(sender As Object, e As EventArgs) Handles _ExecuteTime.Tick
        'If _AbleToClose = True Then
        '    Me.Close()
        '    mainframe.Show()
        'End If
    End Sub

    Private Sub splash_Load(sender As Object, e As EventArgs) Handles Me.Load
        '_AbleToClose = False
        My.Application.MinimumSplashScreenDisplayTime = 100000 'Mode._LOADINGTIME
    End Sub

    Private Sub _LoadingTime_Tick(sender As Object, e As EventArgs) Handles _LoadingTime.Tick
        '_Tick += 1

        'If _Tick = 10000 Then
        '    _AbleToClose = True
        'End If
    End Sub
End Class
