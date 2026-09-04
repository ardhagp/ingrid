Imports System.Runtime.Versioning

Namespace UI.Control
    Public Class ControlCodeBase
        ''' <summary>
        ''' Enumerasi jenis tombol
        ''' </summary>
        ''' <remarks></remarks>
        Public Enum ButtonType
            Yes = 1
            No = 2
            [Default] = 3
            Warning = 4
            Disabled = 5
            Custom = 99
        End Enum

        ''' <summary>
        ''' Enumerasi jenis warna label
        ''' </summary>
        ''' <remarks></remarks>
        Public Enum EnumColorSelect
            [Default] = 1
            Green = 2
            Red = 3
            Grey = 4
            Yellow = 5
            Custom = 99
        End Enum

        ''' <summary>
        ''' Enumerasi jenis warna
        ''' </summary>
        ''' <remarks></remarks>
        Public Enum EnumColorFill
            Solid = 1
            Gradien = 2
        End Enum

        ''' <summary>
        ''' Enumerasi arah gradien
        ''' </summary>
        ''' <remarks></remarks>
        Public Enum EnumGradientType
            Vertikal = 1
            Horizontal = 2
        End Enum

        ''' <summary>
        ''' Enumerasi jenis kapital
        ''' </summary>
        ''' <remarks></remarks>
        Public Enum EnumLetterCase
            UPPERCASE = 1
            lowercase = 2
            Normal = 99
        End Enum

        ''' <summary>
        ''' Enumerasi warna
        ''' </summary>
        ''' <remarks></remarks>
        Public Enum EnumColorRange
            Darker = 1
            Lighter = 2
        End Enum

        Public Enum EnumRestriction
            None = 0
            OnlyText = 1
            OnlyTextAndSpace = 2
            OnlyTextNoSpace = 3
            OnlyNumber = 4
            OnlyNumberAndSpace = 5
            OnlyNumberNoSpace = 6
            TextAndNumber = 7
            TextNumberAndSpace = 8
            TextNumberNoSpace = 9
            TextAndSymbol = 10
            TextSymbolAndSpace = 11
            TextSymbolNoSpace = 12
            NumberSymbolAndSpace = 13
            NumberSymbolNoSpace = 14
            TextNumberSymbolAndSpace = 15
            TextNumberSymbolNoSpace = 16
            Email = 17
        End Enum

        ''' <summary>
        ''' Fungsi untuk mengembalikan nilai warna baru secara acak.
        ''' </summary>
        ''' <returns>Color</returns>
        ''' <remarks></remarks>
        ''' <param name="RMin">Nilai minimum warna merah</param>
        ''' <param name="RMax">Nilai maksimum warna merah</param>
        ''' <param name="GMin">Nilai maminimum warna hijau</param>
        ''' <param name="GMax">Nilai maksimum warna hijau</param>
        ''' <param name="BMin">Nilai minimum warna biru</param>
        ''' <param name="BMax">Nilai maksimum warna biru</param>
        Public Shared Function NewRandomColor(rmin As Integer, rmax As Integer, gmin As Integer, gmax As Integer, bmin As Integer, bmax As Integer) As System.Drawing.Color
            Return System.Drawing.Color.FromArgb(Component.Properties.varRandomColor.Next(rmin, rmax), Component.Properties.varRandomColor.Next(gmin, gmax), Component.Properties.varRandomColor.Next(bmin, bmax))
        End Function

        ''' <summary>
        ''' Fungsi untuk mengambil warna.
        ''' </summary>
        ''' <param name="ValWarnaObjek">Objek warna.</param>
        ''' <param name="ValOpasitasWarna">Opasitas warna.</param>
        ''' <param name="ValIntensitasPerubahan">Intensitas perubahan.</param>
        ''' <returns>Wara RGB</returns>
        <SupportedOSPlatform("windows")>
        Public Shared Function GetColor(valwarnaObjek As System.Drawing.Color, valopasitaswarna As EnumColorRange, valintensitasperubahan As Integer) As System.Drawing.Color
            Dim re As Integer = valwarnaObjek.R
            Dim gr As Integer = valwarnaObjek.G
            Dim bl As Integer = valwarnaObjek.B

            Select Case valopasitaswarna
                Case EnumColorRange.Darker
                    If (re >= (0 + valintensitasperubahan)) Then
                        re -= valintensitasperubahan
                    End If
                    If (gr >= (0 + valintensitasperubahan)) Then
                        gr -= valintensitasperubahan
                    End If
                    If (bl >= (0 + valintensitasperubahan)) Then
                        bl -= valintensitasperubahan
                    End If
                Case EnumColorRange.Lighter
                    If (re <= (255 - valintensitasperubahan)) Then
                        re += valintensitasperubahan
                    End If
                    If (gr <= (255 - valintensitasperubahan)) Then
                        gr += valintensitasperubahan
                    End If
                    If (bl <= (255 - valintensitasperubahan)) Then
                        bl += valintensitasperubahan
                    End If
            End Select

            Return System.Drawing.Color.FromArgb(re, gr, bl)
        End Function

        'Public Function GantiJenisKapital(ByVal _valJenisKapital As enumLetterCase) As System.Windows.Forms.CharacterCasing
        '    Dim _varKapital As System.Windows.Forms.CharacterCasing
        '    Select Case _valJenisKapital
        '        Case enumLetterCase.UPPERCASE
        '            _varKapital = System.Windows.Forms.CharacterCasing.Upper
        '        Case enumLetterCase.lowercase
        '            _varKapital = System.Windows.Forms.CharacterCasing.Lower
        '        Case enumLetterCase.Normal
        '            _varKapital = System.Windows.Forms.CharacterCasing.Normal
        '    End Select

        '    Return _varKapital
        'End Function
    End Class
End Namespace