Public Class Editorial
    Private BIM_IdEditorial As Integer
    Private BIM_Nombre As String
    'Getters Y Setters
    Public Property IdEditorial() As Integer
        Get
            Return BIM_IdEditorial
        End Get
        Set(ByVal value As Integer)
            BIM_IdEditorial = value
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
