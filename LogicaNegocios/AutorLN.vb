Imports Entidades
Imports AccesoDatos
Imports System.Data
Public Class AutorLN
    Public Function LlenarAutorLN() As DataTable
        Dim objAutor As New AutorAD
        Return objAutor.LlenarAutores()
    End Function
End Class
