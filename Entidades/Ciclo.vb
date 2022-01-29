Public Class Ciclo
    Private BIM_IdCiclo As Integer
    Private BIM_Nombre As String
    'Getters y Setters
    Public Property IdCiclo() As Integer
        Get
            Return BIM_IdCiclo
        End Get
        Set(ByVal value As Integer)
            BIM_IdCiclo = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return BIM_Nombre
        End Get
        Set(ByVal value As String)
            BIM_Nombre = value
        End Set
    End Property
End Class
