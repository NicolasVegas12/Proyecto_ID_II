Imports Entidades
Imports AccesoDatos
Imports System.Data
Public Class AreaLN
    Public Function LlenarAreaLN() As DataTable
        Dim objArea As New AreaAD
        Return objArea.LlenarArea()
    End Function
End Class
