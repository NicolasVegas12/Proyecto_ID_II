Imports Entidades
Imports AccesoDatos
Imports System.Data
Public Class ListaLibrosPrestadosLN
    Public Function registrarLibrosPrestadosLN(objA As ListaLibroPrestado) As Boolean
        Try
            Dim objAD As New ListaLibrosPrestadosAD
            objAD.IngresarLibrosPrestados(objA)
            Return True
        Catch e As Exception
            MsgBox("error: " & e.Message)
            Return False
        End Try
    End Function
    Public Function devolverLibrosPrestadosLN(IdPrestamo As String, nroCarnet As String) As Boolean
        Try
            Dim objAD As New ListaLibrosPrestadosAD
            objAD.DevolverLibro(IdPrestamo, nroCarnet)
            Return True
        Catch e As Exception
            MsgBox("error: " & e.Message)
            Return False
        End Try
    End Function
    Public Function ListarLibrosPrestadosTotalesLN() As DataTable
        Dim objLibrosP As New ListaLibrosPrestadosAD
        Return objLibrosP.ListarLibrosPrestadosTotales()
    End Function
    Public Function ListarLibrosPrestadosPendientesLN() As DataTable
        Dim objLibrosP As New ListaLibrosPrestadosAD
        Return objLibrosP.ListarLibrosPrestadosPendientes()
    End Function
    Public Function ListarPrestamosXAlumnoLN(nroCodigo As String) As DataTable
        Dim objLibrosP As New ListaLibrosPrestadosAD
        Return objLibrosP.ListarPrestamosXAlumno(nroCodigo)
    End Function
    Public Function ListarLibrosXAlumnoLN(nroCodigo As String) As DataTable
        Dim objLibrosP As New ListaLibrosPrestadosAD
        Return objLibrosP.ListarLibrosxAlumno(nroCodigo)
    End Function
    Public Function ReportarPerdidoLN(IdPrestamo As String, IdLibro As String) As Boolean
        Try
            Dim objAD As New ListaLibrosPrestadosAD
            objAD.ReportarPerdido(IdPrestamo, IdLibro)
            Return True
        Catch e As Exception
            MsgBox("error: " & e.Message)
            Return False
        End Try
    End Function
End Class
