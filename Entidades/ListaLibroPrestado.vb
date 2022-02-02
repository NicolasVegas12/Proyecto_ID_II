Public Class ListaLibroPrestado
    Private BIM_NroCarnet As String
    Private BIM_IdLibro As String
    Private BIM_IdEjemplar As String
    Private BIM_IdPrestamo As String
    Private BIM_IdEstadoP As Integer
    'Getters y Setters
    Public Property NroCarnet() As String
        Get
            Return BIM_NroCarnet
        End Get
        Set(ByVal value As String)
            BIM_NroCarnet = value
        End Set
    End Property
    Public Property IdLibro() As String
        Get
            Return BIM_IdLibro
        End Get
        Set(ByVal value As String)
            BIM_IdLibro = value
        End Set
    End Property
    Public Property IdEjemplar() As String
        Get
            Return BIM_IdEjemplar
        End Get
        Set(ByVal value As String)
            BIM_IdEjemplar = value
        End Set
    End Property
    Public Property IdPrestamo() As String
        Get
            Return BIM_IdPrestamo
        End Get
        Set(ByVal value As String)
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
