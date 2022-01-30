Imports Entidades
Imports AccesoDatos
Imports System.Data
Public Class EditorialLN
    Public Function LlenarEditorialLN() As DataTable
        Dim objEditorial As New EditorialAD
        Return objEditorial.LlenarEditorial()
    End Function
End Class
