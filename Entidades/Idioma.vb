Public Class Idioma
    Private BIM_IdIdioma As Integer
    Private BIM_Nombre As String
    'Getters y setters
    Public Property IdIdioma() As Integer
        Get
            Return BIM_IdIdioma
        End Get
        Set(ByVal value As Integer)
            BIM_IdIdioma = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return BIM_Nombre
        End Get
        Set(ByVal value As String)
            BIM_Nombre = Nombre
        End Set
    End Property
End Class
