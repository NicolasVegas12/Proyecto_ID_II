Public Class Alumnos
    Private BIM_NroCarnet As Char
    Private BIM_IdCarrera As Integer
    Private BIM_IdCiclo As Integer
    Private BIM_DNI As Char
    Private BIM_IdEstadoA As Integer
    'Getters y Setters
    Public Property NroCarnet() As Char
        Get
            Return BIM_NroCarnet
        End Get
        Set(ByVal value As Char)
            BIM_NroCarnet = value
        End Set
    End Property

    Public Property IdCarrera() As Integer
        Get
            Return BIM_IdCarrera
        End Get
        Set(ByVal value As Integer)
            BIM_IdCarrera = value
        End Set
    End Property

    Public Property IdCiclo() As Integer
        Get
            Return BIM_IdCiclo
        End Get
        Set(ByVal value As Integer)
            BIM_IdCiclo = value
        End Set
    End Property

    Public Property IdDNI() As Char
        Get
            Return BIM_DNI
        End Get
        Set(ByVal value As Char)
            BIM_DNI = value
        End Set
    End Property

    Public Property IdEstadoA() As Integer
        Get
            Return BIM_IdEstadoA
        End Get
        Set(ByVal value As Integer)
            BIM_IdEstadoA = value
        End Set
    End Property
End Class
