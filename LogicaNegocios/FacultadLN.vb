Imports Entidades
Imports AccesoDatos
Imports System.Data
Public Class FacultadLN
    Public Function LlenarFacultadLN() As DataTable
        Dim objFacultad As New FacultadAD
        Return objFacultad.LlenarFacultad()
    End Function
End Class
