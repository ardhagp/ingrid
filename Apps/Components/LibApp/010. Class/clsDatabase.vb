Namespace Ingrid.Database
    Public Class Properties
        Private varText As String
        Public Property Engine As String
            Get
                Return varText
            End Get
            Set(value As String)
                varText = value
            End Set
        End Property

        Public Property DatabaseName As String
            Get
                Return varText
            End Get
            Set(value As String)
                varText = value
            End Set
        End Property
    End Class
End Namespace