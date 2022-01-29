Public Class ListaLibroPrestado
    Private BIM_NroCarnet As Integer
    Private BIM_IdLibro As Integer
    Private BIM_IdEjemplar As Integer
    Private BIM_IdPrestamo As Integer
    Private BIM_IdEstadoP As Integer
    'Getters y Setters
    Public Property NroCarnet() As Integer
        Get
            Return BIM_NroCarnet
        End Get
        Set(ByVal value As Integer)
            BIM_NroCarnet = value
        End Set
    End Property
    Public Property IdLibro() As Integer
        Get
            Return BIM_IdLibro
        End Get
        Set(ByVal value As Integer)
            BIM_IdLibro = value
        End Set
    End Property
    Public Property IdEjemplar() As Integer
        Get
            Return BIM_IdEjemplar
        End Get
        Set(ByVal value As Integer)
            BIM_IdEjemplar = value
        End Set
    End Property
    Public Property IdPrestamo() As Integer
        Get
            Return BIM_IdPrestamo
        End Get
        Set(ByVal value As Integer)
            BIM_IdPrestamo = value
        End Set
    End Property
    Public Property IdEstadoP() As Integer
        Get
            Return BIM_IdEstadoP
        End Get
        Set(ByVal value As Integer)
            BIM_IdEstadoP = value
        End Set
    End Property
End Class
