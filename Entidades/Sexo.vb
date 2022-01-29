Public Class Sexo
    Private BIM_IdSexo As Integer
    Private BIM_Descripcion As String
    'Getters y Setters
    Public Property IdSexo() As Integer
        Get
            Return BIM_IdSexo
        End Get
        Set(ByVal value As Integer)
            BIM_IdSexo = value
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
