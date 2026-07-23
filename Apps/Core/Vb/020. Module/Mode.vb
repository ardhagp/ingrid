Module Mode
    ''' <summary>
    ''' This variable indicates whether the application is running in production mode or not. It is set based on the application's settings and can be used to control behavior that should differ between development and production environments.
    ''' </summary>
    Public varProductionMode As Boolean = My.Settings.PRODUCTIONMODE

    ''' <summary>
    ''' This constant represents the status code for "Time Wait" in the application. It is used to indicate that a certain operation or process is in a waiting state, typically after a connection has been closed and is waiting for a timeout period before it can be reused.
    ''' </summary>
    Public Const varStatusTimeWait As Integer = 2

    ''' <summary>
    ''' This variable defines the maximum upload size for photos in megabytes.
    ''' </summary>
    Public varMaxUploadSizePhoto As Double = 1.0

    ''' <summary>
    ''' This variable defines the maximum upload size for PDF files in megabytes.
    ''' </summary>
    Public varMaxUploadSizePDF As Double = 1.0

    ''' <summary>
    ''' This variable defines the maximum upload size for Excel files in megabytes.
    ''' </summary>
    Public varMaxUploadSizeExcel As Double = 1.0

    ''' <summary>
    ''' This variable defines the text for notifications.
    ''' </summary>
    Public varTextmark As String = "Notification text"

    ''' <summary>
    ''' This variable defines the minimum password length for the application.
    ''' </summary>
    Public varMinPasswordLength As Integer = 8
End Module
