Imports Entidades
Imports AccesoDatos
Imports System.Data
Public Class IdiomaLN
    Public Function LlenarIdiomaLN() As DataTable
        Dim objIdioma As New IdiomaAD
        Return objIdioma.LlenarIdioma()
    End Function
End Class
