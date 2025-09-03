Namespace Ingrid.Database
    Public Class Properties
        Private V_Text As String
        Public Property Engine As String
            Get
                Return V_Text
            End Get
            Set(value As String)
                V_Text = value
            End Set
        End Property

        Public Property DatabaseName As String
            Get

            End Get
            Set(value As String)

            End Set
        End Property
    End Class



End Namespace