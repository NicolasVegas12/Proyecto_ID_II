Imports Entidades
Imports AccesoDatos
Imports System.Data
Public Class EstadoAlumnoLN
    Public Function LlenarEstadoAlumnoLN() As DataTable
        Dim objEstadoA As New EstadoAlumnoAD
        Return objEstadoA.LlenarEstadoAlumno()
    End Function
End Class
