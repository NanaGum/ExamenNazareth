Public Class Clientes


    Private _clienteId As Integer
    Private _nombre As String
    Private _apellidos As String
    Private _email As String
    Private _telefono As String



    Public Sub New(clienteId As Integer, nombre As String, apellidos As String, email As String, telefono As String)
        Me.ClienteId = clienteId
        Me.Nombre = nombre
        Me.Apellidos = apellidos
        Me.Email = email
        Me.Telefono = telefono
    End Sub

    Public Property ClienteId As Integer
        Get
            Return _clienteId
        End Get
        Set(value As Integer)
            _clienteId = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellidos As String
        Get
            Return _apellidos
        End Get
        Set(value As String)
            _apellidos = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property
End Class
