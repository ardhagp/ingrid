Module Mode
    'False to use development phase
    Public varProductionMode As Boolean = My.Settings.PRODUCTIONMODE

    'Still unused
    Public Const varStatusTimeWait As Integer = 2

    'In megabytes
    Public varMaxUploadSizePhoto As Double = 1.0

    'In megabytes
    Public varMaxUploadSizePDF As Double = 1.0

    'Default picture watermark
    Public varTextmark As String = "Notification text"

    'Default minimum password strenght
    Public varMinPasswordLength As Integer = 8
End Module
