Public Class EstadoPrestamo
    Private BIM_IdEstadoP As Integer
    Private BIM_Descripcion As String
    'Getters y Setters
    Public Property IdEstadoP() As Integer
        Get
            Return BIM_IdEstadoP
        End Get
        Set(ByVal value As Integer)
            BIM_IdEstadoP = value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return BIM_Descripcion
        End Get
        Set(ByVal value As String)
            BIM_Descripcion = value
        End Set
    End Property
End Class
