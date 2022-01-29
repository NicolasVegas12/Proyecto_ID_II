Public Class Autor
    Private BIM_IdAutor As Integer
    Private BIM_Nombre As String
    Private BIM_Email As String
    Private BIM_Nacionalidad As String
    'Getters y Setters
    Public Property IdAutor() As Integer
        Get
            Return BIM_IdAutor
        End Get
        Set(ByVal value As Integer)
            BIM_IdAutor = value
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
    Public Property Email() As String
        Get
            Return BIM_Email
        End Get
        Set(ByVal value As String)
            BIM_Email = value
        End Set
    End Property
    Public Property Nacionalidad() As String
        Get
            Return BIM_Nacionalidad
        End Get
        Set(value As String)
            BIM_Nacionalidad = value
        End Set
    End Property
End Class
