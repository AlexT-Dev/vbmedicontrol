Public Class UserClass
    'Para manejo de los datos

    Private _nombre As String
    Private _tipo As String
    Private _status As String
    Private _cuenta As String
    Private _password As String

    'Constructor vacío
    Public Sub New()
    End Sub

    'Variables get y set

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property

    Public Property Status As String
        Get
            Return _status
        End Get
        Set(value As String)
            _status = value
        End Set
    End Property

    Public Property Cuenta As String
        Get
            Return _cuenta
        End Get
        Set(value As String)
            _cuenta = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property
End Class
