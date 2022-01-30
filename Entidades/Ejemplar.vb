Public Class Ejemplar
    Private BIM_IdLibro As String
    Private BIM_IdEjemplar As Integer
    Private BIM_IdEstadoE As String
    'Getters y Setters
    Public Property IdLibro() As String
        Get
            Return BIM_IdLibro
        End Get
        Set(ByVal value As String)
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
    Public Property IdEstadoE() As String
        Get
            Return BIM_IdEstadoE
        End Get
        Set(ByVal value As String)
            BIM_IdEstadoE = value
        End Set
    End Property
End Class
