Public Class Ejemplar
    Private BIM_IdLibro As Integer
    Private BIM_IdEjemplar As Integer
    Private BIM_IdEstadoE As Integer
    'Getters y Setters
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
    Public Property IdEstadoE() As Integer
        Get
            Return BIM_IdEstadoE
        End Get
        Set(ByVal value As Integer)
            BIM_IdEstadoE = value
        End Set
    End Property
End Class
