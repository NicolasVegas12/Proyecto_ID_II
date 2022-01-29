Public Class Facultad
    Private BIM_IdFacultad As Integer
    Private BIM_Nombre As String
    'Getters Y Setters
    Public Property IdFacultad() As Integer
        Get
            Return BIM_IdFacultad
        End Get
        Set(ByVal value As Integer)
            BIM_IdFacultad = value
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
