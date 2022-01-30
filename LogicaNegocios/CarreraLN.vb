Imports Entidades
Imports System.Data
Imports AccesoDatos
Public Class CarreraLN
    Public Function LlenarCarreraLN() As DataTable
        Dim objCarrera As New CarreraAD
        Return objCarrera.LlenarCarrera()
    End Function
End Class
