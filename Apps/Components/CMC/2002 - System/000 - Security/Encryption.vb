Namespace Security
    ''' <summary>
    ''' This class provides methods for encrypting and hashing data using various algorithms such as MD5, AES, and CRC32. It includes functionality to generate random strings, compute CRC32 checksums, and handle encryption and decryption of messages.
    ''' </summary>
    Public Class Encryption
        Private Shared ReadOnly Table As UInteger() = CreateTable()
        ''' <summary>
        ''' Generates a random string of length between 15 and 32 characters, consisting of uppercase letters, lowercase letters, and digits.
        ''' </summary>
        ''' <returns>A randomly generated string.</returns>
        Private Shared Function RandomString() As String
            Dim r As New Random
            Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
            Dim sb As New System.Text.StringBuilder
            Dim cnt As Integer = r.Next(15, 33)
            For i As Integer = 1 To cnt
                Dim idx As Integer = r.Next(0, s.Length)
                sb.Append(s.AsSpan(idx, 1))
            Next
            Return sb.ToString()
        End Function

        ''' <summary>
        ''' Computes the MD5 hash of the provided message. If no message is provided, it generates a random string and computes its MD5 hash.
        ''' </summary>
        ''' <param name="message">The message to be hashed. If not provided, a random string will be used.</param>
        ''' <returns>The MD5 hash of the message.</returns>
        Public Shared Function MD5(Optional message As String = "") As String
            Dim varEMessage As String
            Dim varGuid As String

            If message = String.Empty Then
                varGuid = System.Guid.NewGuid.ToString
                varEMessage = NETCore.Encrypt.EncryptProvider.Md5(CStr(Now) & RandomString() & varGuid)
            Else
                varEMessage = NETCore.Encrypt.EncryptProvider.Md5(message)
            End If

            Return varEMessage
        End Function

        ''' <summary>
        ''' Encrypts the provided message using AES encryption with a predefined salt. If an error occurs during encryption, it logs the error details and returns an empty string.
        ''' </summary>
        ''' <param name="message">The message to be encrypted.</param>
        ''' <returns>The encrypted message, or an empty string if an error occurs.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function Aes(message As String) As String
            Dim varMessage As String = NETCore.Encrypt.EncryptProvider.AESEncrypt(message, UI.varSalt)
            Try
                Return varMessage
            Catch ex As Exception
                With UI.proLog
                    .AppVersion = UI.GetAppVersion()
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
                clsLog.ShowData(UI.proLog)
                clsLog = Nothing

                Return String.Empty
            End Try
        End Function

        ''' <summary>
        ''' Computes the CRC32 checksum of the provided message. The result can be returned as a hexadecimal string or as a decimal string based on the returnashex parameter. If an error occurs during computation, it logs the error details and returns an empty string.
        ''' </summary>
        ''' <param name="message">The message for which the CRC32 checksum will be computed.</param>
        ''' <param name="returnashex">Indicates whether the result should be returned as a hexadecimal string. If false, the result will be returned as a decimal string.</param>
        ''' <returns>The CRC32 checksum of the message as a string, either in hexadecimal or decimal format.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function CRC32(message As String, Optional returnashex As Boolean = True) As String
            Try
                Dim varCRCvalue As UInteger
                varCRCvalue = ComputeCrc(message)

                If returnashex Then
                    Return varCRCvalue.ToString("X8", Globalization.CultureInfo.InvariantCulture)
                Else
                    Return varCRCvalue.ToString(Globalization.CultureInfo.InvariantCulture)
                End If
            Catch ex As Exception
                With UI.proLog
                    .AppVersion = UI.GetAppVersion()
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
                clsLog.ShowData(UI.proLog)
                clsLog = Nothing

                Return String.Empty
            End Try
        End Function

        ''' <summary>
        ''' Computes the CRC32 checksum of the provided message using a precomputed lookup table. The method processes each byte of the message, updating the CRC value based on the current byte and the existing CRC value. Finally, it returns the computed CRC32 checksum as an unsigned integer.
        ''' </summary>
        ''' <param name="message">The message for which the CRC32 checksum will be computed.</param>
        ''' <returns>The computed CRC32 checksum as an unsigned integer.</returns>
        Private Shared Function ComputeCrc(message As String) As UInteger
            Dim bytes = System.Text.Encoding.UTF8.GetBytes(message)
            Dim crc As UInteger = &HFFFFFFFFUI

            For Each b As Byte In bytes
                Dim idx As Integer = CInt((crc And &HFFUI) Xor CUInt(b))
                crc = (crc >> 1) Xor Table(idx)
            Next

            Return Not crc
        End Function

        ''' <summary>
        ''' Creates a lookup table for CRC32 computation based on the polynomial &HEDB88320UI. The method initializes an array of 256 unsigned integers and populates it by iterating through each possible byte value (0 to 255). For each byte, it computes the corresponding CRC value by performing bitwise operations and XORing with the polynomial as needed. The resulting table is used for efficient CRC32 checksum calculations.
        ''' </summary>
        ''' <returns>An array of 256 unsigned integers representing the CRC32 lookup table.</returns>
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

    ''' <summary>
    ''' The Decrypt class provides methods for decrypting data that has been encrypted using AES encryption. It includes functionality to decrypt messages and retrieve the salt used for encryption. The class handles exceptions during decryption and logs error details if any issues arise.
    ''' </summary>
    Public Class Decrypt
        ''' <summary>
        ''' Decrypts the provided message using AES decryption with a predefined salt. If an error occurs during decryption, it logs the error details and returns an empty string.
        ''' </summary>
        ''' <param name="message">The message to be decrypted.</param>
        ''' <returns>The decrypted message as a string, or an empty string if an error occurs.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function Aes(message As String) As String
            Try
                Dim varMessage As String = NETCore.Encrypt.EncryptProvider.AESDecrypt(message, UI.varSalt)
                Return varMessage
            Catch ex As Exception
                With UI.proLog
                    .AppVersion = UI.GetAppVersion()
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
                clsLog.ShowData(UI.proLog)
                clsLog = Nothing

                Return String.Empty
            End Try
        End Function

        ''' <summary>
        ''' Retrieves the salt value used for encryption and decryption. If an error occurs while retrieving the salt, it logs the error details and returns an empty string.
        ''' </summary>
        ''' <returns>The salt value as a string, or an empty string if an error occurs.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function GetSalt() As String
            Try
                Dim varMessage As String = UI.varSalt
                Return varMessage
            Catch ex As Exception
                With UI.proLog
                    .AppVersion = UI.GetAppVersion()
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
                clsLog.ShowData(UI.proLog)
                clsLog = Nothing

                Return String.Empty
            End Try
        End Function
    End Class
End Namespace

