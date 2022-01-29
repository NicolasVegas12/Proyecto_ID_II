Public Class DatosPersonales
    Private BIM_DNI As Char
    Private BIM_Nombres As String
    Private BIM_Apellidos As String
    Private BIM_Email As String
    Private BIM_Fijo As String
    Private BIM_Celular As String
    Private BIM_IdSexo As Integer
    'Getters y Setters
    Public Property IdDNI() As Char
        Get
            Return BIM_DNI
        End Get
        Set(ByVal value As Char)
            BIM_DNI = value
        End Set
    End Property

    Public Property Nombres() As String
        Get
            Return BIM_Nombres
        End Get
        Set(ByVal value As String)
            BIM_Nombres = value
        End Set
    End Property

    Public Property Apellidos() As String
        Get
            Return BIM_Apellidos
        End Get
        Set(ByVal value As String)
            BIM_Apellidos = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return BIM_Email
        End Get
        Set(ByVal value As String)
            BIM_Email = value
        End Set
    End Property

    Public Property Fijo() As String
        Get
            Return BIM_Fijo
        End Get
        Set(ByVal value As String)
            BIM_Fijo = value
        End Set
    End Property

    Public Property Celular() As String
        Get
            Return BIM_Celular
        End Get
        Set(ByVal value As String)
            BIM_Celular = value
        End Set
    End Property

    Public Property IdSexo() As Integer
        Get
            Return BIM_IdSexo
        End Get
        Set(ByVal value As Integer)
            BIM_IdSexo = value
        End Set
    End Property
End Class
