Module Mode
    'False to use development phase
    Public V_PRODUCTIONMODE As Boolean = My.Settings.PRODUCTIONMODE

    'Still unused
    'Public Const _LOADINGTIME As Integer = 0 

    'Still unused
    Public Const varStatustimewait As Integer = 2

    'In megabytes
    Public varMaxuploadsize_photo As Double = 1.0

    'In megabytes
    Public varMaxuploadsize_pdf As Double = 1.0

    'Default picture watermark
    Public varTextmark As String = "CagakMelon - INGRID"

    'Default minimum password strenght
    Public varMinpasswordlength As Integer = 8

End Module
