Imports Entidades
Imports System.Data
Imports AccesoDatos
Public Class EjemplarLN
    Public Function LlenarEjemplarLN() As DataTable
        Dim objEjemplar As New EjemplarDA
        Return objEjemplar.LlenarEjemplar()
    End Function
End Class
