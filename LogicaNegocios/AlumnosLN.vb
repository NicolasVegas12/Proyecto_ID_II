Imports Entidades
Imports AccesoDatos
Imports System.Data
Public Class AlumnosLN
    Public Function LlenarAlumnosLN() As DataTable
        Dim objAlumnos As New AlumnosAD
        Return objAlumnos.LlenarAlumnos()
    End Function
End Class
