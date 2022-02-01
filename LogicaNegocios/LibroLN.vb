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

    Public Function agregarLibro(objA As Libro) As Boolean
        Try
            Dim objAD As New LibroAD
            objAD.AgregarLibros(objA)
            Return True
        Catch e As Exception
            MsgBox("error: " & e.Message)
            Return False
        End Try
    End Function

    Public Function EditarLibro(objL As Libro) As Boolean
        Try
            Dim objAD As New LibroAD
            objAD.EditarLibro(objL)
            Return True
        Catch ex As Exception
            MsgBox("error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function SeleccionarLibro(IdLibro As String) As Libro
        Dim objL As New Libro
        Try
            Dim objAD As New LibroAD

            objL = objAD.SeleccionarLibro(IdLibro)
            Return objL
        Catch ex As Exception
            MsgBox("error: " & ex.Message)
            Return objL
        End Try
    End Function

    Public Function FiltrosLibros(objL As Libro) As DataTable
        Dim objLibro As New LibroAD
        Return objLibro.FiltrosLibro(objL)
    End Function

    Public Function LlenarLibroLN() As DataTable
        Dim objLibro As New LibroAD
        Return objLibro.ListarLibros()
    End Function

    Public Function ListarLibroLN() As DataTable
        Dim objLibro As New LibroAD
        Return objLibro.ListarLibro()
    End Function
End Class
