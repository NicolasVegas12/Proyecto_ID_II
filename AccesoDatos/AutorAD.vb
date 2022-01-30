Imports System.Data.SqlClient
Imports Entidades
Public Class AutorAD
    Dim conexion As New Conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Public Function LlenarAutores() As DataTable
        cn = conexion.conectar
        Dim vsql As String
        vsql = "SELECT idAutor, Nombre, Email, Nacionalidad FROM Autor"
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(vsql, cn)
        da.Fill(dt)
        Return dt
    End Function
End Class
