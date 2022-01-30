Imports Entidades
Imports AccesoDatos
Imports System.Data
Public Class EstadoEjemplarLN
    Public Function LlenarEstadoEjemplarLN() As DataTable
        Dim objEstadoE As New EstadoEjemplarDA
        Return objEstadoE.LlenarEstadoEjemplar()
    End Function
End Class
