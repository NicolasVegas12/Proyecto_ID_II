Public Class EstadoAlumno
    Private BIM_IdEstadoA As Integer
    Private BIM_Descripcion As String
    'Getters y Setters
    Public Property IdEstadoA() As Integer
        Get
            Return BIM_IdEstadoA
        End Get
        Set(ByVal value As Integer)
            BIM_IdEstadoA = value
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