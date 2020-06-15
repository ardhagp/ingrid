Imports CMCv

Namespace Commands.SYSS
    Public Class View
        Public Function GETSettingValue(ByVal DBColumn As String) As Object
            Try
                Dim _Value As Object = 0

                _DBR_MSSQL2008(0).Query = String.Format("select {0} from dbo.[[sys]]settings] st where st.settings_id = 1", DBColumn)
                _Value = _DBE_MSSQL2008.GETVALUE(_DBR_MSSQL2008(0).Query)

                Return _Value
            Catch ex As Exception
                Return 0
            End Try
        End Function
    End Class

    Public Class Editor
        Public Function SaveSettings(ByVal Profile As Integer, ByVal Storage As Integer, ByVal NewsTicker As Integer, ByVal MinPhoto As Integer, ByVal MinPDF As Integer, ByVal Watermark As Integer, ByVal WatermarkText As String, ByVal MinPassword As Integer) As Boolean
            Try

                _DBR_MSSQL2008(1).Query = String.Format("update dbo.[[sys]]settings] set settings_showprofile = {0}, settings_showstorage = {1}, settings_showrunningtext = {2}, settings_uploadphoto = {3}, settings_uploadpdf = {4},  settings_showwatermark = {5}, settings_textmark = '{6}', settings_minpasswordlength = {7} where settings_id = 1", Profile, Storage, NewsTicker, MinPhoto, MinPDF, Watermark, WatermarkText, MinPassword)

                _DBE_MSSQL2008.PUSHDATA(_DBR_MSSQL2008(1).Query)

                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Class
End Namespace
