Module Mode
    'False to use development phase
    Public V_PRODUCTIONMODE As Boolean = My.Settings.PRODUCTIONMODE

    'Still unused
    'Public Const _LOADINGTIME As Integer = 0 

    'Still unused
    Public Const V_StatusTimeWait As Integer = 2

    'In megabytes
    Public V_MaxUploadSize_Photo As Double = 1.0

    'In megabytes
    Public V_MaxUploadSize_PDF As Double = 1.0

    'Default picture watermark
    Public V_Textmark As String = "CagakMelon - INGRID"

    'Default minimum password strenght
    Public V_MinPasswordLength As Integer = 8

End Module
