Imports System.Data.SqlClient
Imports Entidades
Public Class LibroAD
    Dim conexion As New Conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter

    Public Function ListarLibros() As DataTable
        cn = conexion.conectar
        Dim vsql As String
        vsql = "EXEC sp_AccionesLibros @tipoAccion=1"
        Dim da As New SqlDataAdapter(vsql, cn)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

End Class
