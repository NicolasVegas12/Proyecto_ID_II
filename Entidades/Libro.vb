Public Class Libro
    Private BIM_IdLibro As Integer
    Private BIM_Titulo As String
    Private BIM_FechaEdicion As Char
    Private BIM_IdEditorial As String
    Private BIM_Stock As Integer
    Private BIM_IdIdioma As String
    Private BIM_IdAutor As String
    Private BIM_IdArea As String
    'Getters y Setters

    Public Property IdTitulo() As Integer
        Get
            Return BIM_IdLibro
        End Get
        Set(ByVal value As Integer)
            BIM_IdLibro = value
        End Set
    End Property
    Public Property Titulo() As String
        Get
            Return BIM_Titulo
        End Get
        Set(ByVal value As String)
            BIM_Titulo = value
        End Set
    End Property
    Public Property FechaEdicion() As Char
        Get
            Return BIM_FechaEdicion
        End Get
        Set(ByVal value As Char)
            BIM_FechaEdicion = value
        End Set
    End Property
    Public Property IdEditorial() As String
        Get
            Return BIM_IdEditorial
        End Get
        Set(ByVal value As String)
            BIM_IdEditorial = value
        End Set
    End Property
    Public Property Stock() As Integer
        Get
            Return BIM_Stock
        End Get
        Set(ByVal value As Integer)
            BIM_Stock = value
        End Set
    End Property
    Public Property IdIdioma() As String
        Get
            Return BIM_IdIdioma
        End Get
        Set(ByVal value As String)
            BIM_IdIdioma = value
        End Set
    End Property
    Public Property IdAutor() As String
        Get
            Return BIM_IdAutor
        End Get
        Set(ByVal value As String)
            BIM_IdAutor = value
        End Set
    End Property
    Public Property IdArea() As String
        Get
            Return BIM_IdArea
        End Get
        Set(ByVal value As String)
            BIM_IdArea = value
        End Set
    End Property
End Class
