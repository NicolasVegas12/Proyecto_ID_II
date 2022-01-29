Public Class EstadoEjemplar
    Private BIM_IdEstadoE As Integer
    Private BIM_Descripcion As String
    'Getters y Setters
    Public Property IdEstadoE() As Integer
        Get
            Return BIM_IdEstadoE
        End Get
        Set(ByVal value As Integer)
            BIM_IdEstadoE = value
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
