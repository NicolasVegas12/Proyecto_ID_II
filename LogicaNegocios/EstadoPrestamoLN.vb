Imports Entidades
Imports AccesoDatos
Imports System.Data
Public Class EstadoPrestamoLN
    Public Function LlenarEstadoPrestamoLN() As DataTable
        Dim objEstadoP As New EstadoPrestamoAD
        Return objEstadoP.LlenarEstadoPrestamo()
    End Function
End Class
