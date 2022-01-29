Public Class Prestamo
    Private BIM_NroCarnet As Char
    Private BIM_Prestamo As Char
    Private BIM_FechaPrestamo As Date
    Private BIM_FechaDevolucion As Date
    'Getters y Setters
    Public Property NroCarnet() As Char
        Get
            Return BIM_NroCarnet
        End Get
        Set(ByVal value As Char)
            BIM_NroCarnet = value
        End Set
    End Property

    Public Property Prestamo() As Char
        Get
            Return BIM_Prestamo
        End Get
        Set(ByVal value As Char)
            BIM_Prestamo = value
        End Set
    End Property

    Public Property FechaPrestamo() As Date
        Get
            Return BIM_FechaPrestamo
        End Get
        Set(ByVal value As Date)
            BIM_FechaPrestamo = value
        End Set
    End Property

    Public Property FechaDevolucion() As Date
        Get
            Return BIM_FechaDevolucion
        End Get
        Set(ByVal value As Date)
            BIM_FechaDevolucion = value
        End Set
    End Property
End Class
