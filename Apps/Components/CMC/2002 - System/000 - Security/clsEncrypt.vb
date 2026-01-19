Imports System.Runtime.Versioning
Imports System.Text
Imports NETCore.Encrypt

Namespace Security
    Public Class Encrypt
        Private Shared ReadOnly Table As UInteger() = CreateTable()
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
        Public Shared Function AES(message As String) As String
            Dim varMessage As String = EncryptProvider.AESEncrypt(message, V_SALT)
            Try
                Return varMessage
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[AES] $\Ingrid\Apps\Components\CMC\2002 - System\000 - Security\clsEncrypt.vb"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Number = ex.HResult
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.SupportServiceDatabaseEngine
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New Ladybug.Log.Events
                clsLog.ShowData(proLog)
                clsLog = Nothing

                Return String.Empty
            End Try
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

        <SupportedOSPlatform("windows")>
        Public Shared Function CRC32(message As String, Optional returnashex As Boolean = True) As String
            Try
                Dim varCRCvalue As UInteger
                varCRCvalue = ComputeCRC(message)

                If returnashex Then
                    Return varCRCvalue.ToString("X8", Globalization.CultureInfo.InvariantCulture)
                Else
                    Return varCRCvalue.ToString(Globalization.CultureInfo.InvariantCulture)
                End If
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[CRC32] $\Ingrid\Apps\Components\CMC\2002 - System\000 - Security\clsEncrypt.vb"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Number = ex.HResult
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.SupportServiceDatabaseEngine
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New Ladybug.Log.Events
                clsLog.ShowData(proLog)
                clsLog = Nothing

                Return String.Empty
            End Try
        End Function
        Private Shared Function ComputeCRC(message As String) As UInteger
            Dim bytes = Encoding.UTF8.GetBytes(message)
            Dim crc As UInteger = &HFFFFFFFFUI

            For Each b As Byte In bytes
                Dim idx As Integer = CInt((crc And &HFFUI) Xor CUInt(b))
                crc = (crc >> 1) Xor Table(idx)
            Next

            Return Not crc
        End Function

        Private Shared Function CreateTable() As UInteger()
            Const poly As UInteger = &HEDB88320UI
            Dim table(255) As UInteger

            For i As Integer = 0 To 255
                Dim crc As UInteger = CUInt(i)
                For j As Integer = 0 To 7
                    If (crc And 1UI) = 1UI Then
                        crc = (crc >> 1) Xor poly
                    Else
                        crc >>= 1
                    End If
                Next
                table(i) = crc
            Next

            Return table
        End Function
    End Class

    Public Class Decrypt
        <SupportedOSPlatform("windows")>
        Public Shared Function AES(message As String) As String
            Try
                Dim varMessage As String = EncryptProvider.AESDecrypt(message, V_SALT)
                Return varMessage
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[AES] $\Ingrid\Apps\Components\CMC\2002 - System\000 - Security\clsEncrypt.vb"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Number = ex.HResult
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.SupportServiceDatabaseEngine
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New Ladybug.Log.Events
                clsLog.ShowData(proLog)
                clsLog = Nothing

                Return String.Empty
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function GetSalt() As String
            Try
                Dim varMessage As String = V_SALT
                Return varMessage
            Catch ex As Exception
                With proLog
                    .AppVersion = GetAppVersion()
                    .FromSender = "[GetSalt] $\Ingrid\Apps\Components\CMC\2002 - System\000 - Security\clsEncrypt.vb"
                    .InternalStackTrace = ex.StackTrace
                    .Message = ex.Message
                    .Number = ex.HResult
                    .ResumeNext = True
                    .SaveInBetterLog = True
                    .SaveLogInLocal = False
                    .ShowErrorReporting = True
                    .TypeOfFaulty = Ladybug.Log.Fields.TypeOfFaulties.SupportServiceDatabaseEngine
                    .TypeOfLog = Ladybug.Log.Fields.TypeOfLogs.Error
                End With

                Dim clsLog As New Ladybug.Log.Events
                clsLog.ShowData(proLog)
                clsLog = Nothing

                Return String.Empty
            End Try
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

