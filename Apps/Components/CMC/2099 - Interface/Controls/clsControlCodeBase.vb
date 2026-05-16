Imports System.Runtime.Versioning

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
    Public Enum JenisLabel
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
    Public Enum JenisWarna
        Solid = 1
        Gradien = 2
    End Enum

    ''' <summary>
    ''' Enumerasi arah gradien
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum ArahGradien
        Vertikal = 1
        Horizontal = 2
    End Enum

    ''' <summary>
    ''' Enumerasi jenis validasi
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum JenisValidasi
        Email = 1
        HanyaAngka = 2
        TanpaValidasi = 99
    End Enum

    ''' <summary>
    ''' Enumerasi jenis kapital
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum enuJenisKapital
        KAPITALSEMUA = 1
        kecilsemua = 2
        Normal = 99
    End Enum

    ''' <summary>
    ''' Enumerasi warna
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum enuOpasitasWarna
        Darker = 1
        Lighter = 2
    End Enum

    Public Enum enuRestriction
        None = 0
        OnlyText = 1
        OnlyNumber = 2
        TextAndNumber = 3
        TextAndSymbol = 4
        Email = 5
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
    Public Shared Function WarnaAcakBaru(rmin As Integer, rmax As Integer, gmin As Integer, gmax As Integer, bmin As Integer, bmax As Integer) As System.Drawing.Color
        Return System.Drawing.Color.FromArgb(varRandomColor.Next(rmin, rmax), varRandomColor.Next(gmin, gmax), varRandomColor.Next(bmin, bmax))
    End Function

    ''' <summary>
    ''' Fungsi untuk mengambil warna.
    ''' </summary>
    ''' <param name="ValWarnaObjek">Objek warna.</param>
    ''' <param name="ValOpasitasWarna">Opasitas warna.</param>
    ''' <param name="ValIntensitasPerubahan">Intensitas perubahan.</param>
    ''' <returns>Wara RGB</returns>
    <SupportedOSPlatform("windows")>
    Public Shared Function AmbilWarna(valwarnaObjek As System.Drawing.Color, valopasitaswarna As enuOpasitasWarna, valintensitasperubahan As Integer) As System.Drawing.Color
        Dim re As Integer = valwarnaObjek.R
        Dim gr As Integer = valwarnaObjek.G
        Dim bl As Integer = valwarnaObjek.B

        Select Case valopasitaswarna
            Case enuOpasitasWarna.Darker
                If (re >= (0 + valintensitasperubahan)) Then
                    re -= valintensitasperubahan
                End If
                If (gr >= (0 + valintensitasperubahan)) Then
                    gr -= valintensitasperubahan
                End If
                If (bl >= (0 + valintensitasperubahan)) Then
                    bl -= valintensitasperubahan
                End If
            Case enuOpasitasWarna.Lighter
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

    'Public Function GantiJenisKapital(ByVal _valJenisKapital As enuJenisKapital) As System.Windows.Forms.CharacterCasing
    '    Dim _varKapital As System.Windows.Forms.CharacterCasing
    '    Select Case _valJenisKapital
    '        Case enuJenisKapital.KAPITALSEMUA
    '            _varKapital = System.Windows.Forms.CharacterCasing.Upper
    '        Case enuJenisKapital.kecilsemua
    '            _varKapital = System.Windows.Forms.CharacterCasing.Lower
    '        Case enuJenisKapital.Normal
    '            _varKapital = System.Windows.Forms.CharacterCasing.Normal
    '    End Select

    '    Return _varKapital
    'End Function
End Class
