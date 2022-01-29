Public Class Area
    Private BIM_IdArea As Integer
    Private BIM_Descripcion As String
    'Getters Y Setters
    Public Property IdArea() As Integer
        Get
            Return BIM_IdArea
        End Get
        Set(ByVal value As Integer)
            BIM_IdArea = value
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
