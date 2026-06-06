Imports System.Runtime.Versioning

Namespace UI.Control
    Public Class Dtp
        Inherits System.Windows.Forms.DateTimePicker

        <SupportedOSPlatform("windows")>
        Public Sub New()
            InitializeComponent()
            Call ActivateLicenses()
            MyBase.Font = globalFontTxt
            MyBase.MaxDate = DateAdd(DateInterval.Year, 10, Now.Date)
            MyBase.MinDate = DateAdd(DateInterval.Year, -100, Now.Date)
        End Sub

        <SupportedOSPlatform("windows")>
        Private Sub Dtp_EnabledChanged(sender As Object, e As EventArgs) Handles Me.EnabledChanged
            If (XOResetOnDisabled) AndAlso Not (Me.Enabled) Then
                MyBase.MaxDate = DateAdd(DateInterval.Year, 10, Now.Date)
                MyBase.MinDate = DateAdd(DateInterval.Year, -100, Now.Date)
                Value = Now.Date
            End If
        End Sub

        <System.ComponentModel.Category("XO.Format"),
            System.ComponentModel.Description("Resets the component’s date value to its default state whenever the control becomes disabled")>
        Private varResetOnDisabled As Boolean
        Public Property XOResetOnDisabled As Boolean
            Get
                Return varResetOnDisabled
            End Get
            Set(value As Boolean)
                varResetOnDisabled = value
            End Set
        End Property
    End Class
End Namespace