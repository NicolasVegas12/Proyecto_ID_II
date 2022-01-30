Imports System.Data.SqlClient
Imports Entidades
Public Class EjemplarDA
    Dim conexion As New Conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Public Function LlenarEjemplar() As DataTable
        cn = conexion.conectar
        Dim vsql As String
        vsql = "EXEC sp_Ejemplar @tipo = 1"
        Dim da As New SqlDataAdapter(vsql, cn)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
End Class
