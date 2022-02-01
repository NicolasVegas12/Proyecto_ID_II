Imports Entidades
Imports AccesoDatos
Imports System.Data
Public Class AlumnosLN
    Public Function LlenarAlumnosLN() As DataTable
        Dim objAlumnos As New AlumnosAD
        Return objAlumnos.LlenarAlumnos()
    End Function

    Public Function ObtenerAlumnoLN(objA As String) As DataTable
        Dim objAD As New AlumnosAD
        Return objAD.ObtenerAlumno(objA)
    End Function
End Class
