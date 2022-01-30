Imports Entidades
Imports AccesoDatos
Imports System.Data
Public Class LibroLN
    Public Function registrarLibro(objA As Libro) As Boolean
        Try
            Dim objAD As New LibroAD
            objAD.InsertarLibros(objA)
            Return True
        Catch e As Exception
            MsgBox("error: " & e.Message)
            Return False
        End Try
    End Function
    Public Function LlenarLibroLN() As DataTable
        Dim objLibro As New LibroAD
        Return objLibro.ListarLibros()
    End Function
End Class
