Imports System.Runtime.Versioning
Imports System.Text
Imports NETCore.Encrypt

Namespace Security
    Public Class Encrypt

        Private Shared Function RandomString() As String
            Dim r As New Random
            Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
            Dim sb As New StringBuilder
            Dim cnt As Integer = r.Next(15, 33)
            For i As Integer = 1 To cnt
                Dim idx As Integer = r.Next(0, s.Length)
                sb.Append(s.AsSpan(idx, 1))
            Next
            Return sb.ToString()
        End Function

        Public Shared Function MD5(Optional ByVal Message As String = "") As String
            Dim _EMessage As String
            Dim _GUID As String

            If Message = String.Empty Then
                _GUID = System.Guid.NewGuid.ToString
                _EMessage = EncryptProvider.Md5(CStr(Now) & RandomString() & _GUID)
            Else
                _EMessage = EncryptProvider.Md5(Message)
            End If

            Return _EMessage
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function AES(Message As String) As String
            Dim _EMessage As String = EncryptProvider.AESEncrypt(Message, V_SALT)
            Return _EMessage
        End Function

        'Public Function Rijndael(ByVal Message As String) As String
        '    Security.Engine.EncryptionAlgorithm = Engine.Algorithm.Rijndael
        '    Security.Engine.Encoding = Engine.EncodingType.HEX
        '    Security.Engine.Key = V_SALT

        '    If Security.Engine.EncryptString(Message) Then
        '        Return Security.Engine.Content
        '    Else
        '        Return String.Empty
        '    End If

        'End Function
    End Class

    Public Class Decrypt
        <SupportedOSPlatform("windows")>
        Public Shared Function AES(Message As String) As String
            Dim _EMessage As String = EncryptProvider.AESDecrypt(Message, V_SALT)
            Return _EMessage
        End Function

        'Public Function Rijndael(ByVal Message As String) As String
        '    Security.Engine.EncryptionAlgorithm = Engine.Algorithm.Rijndael
        '    Security.Engine.Encoding = Engine.EncodingType.HEX
        '    Security.Engine.Key = V_SALT
        '    Security.Engine.Content = Message

        '    If Security.Engine.DecryptString Then
        '        Return Security.Engine.Content
        '    Else
        '        Return String.Empty
        '    End If

        'End Function
    End Class
End Namespace

