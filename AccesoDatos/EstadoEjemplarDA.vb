Imports System.Data.SqlClient
Imports Entidades
Public Class EstadoEjemplarDA
    Dim conexion As New Conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Public Function LlenarEstadoEjemplar() As DataTable
        cn = conexion.conectar
        Dim vsql As String
        vsql = "SELECT IdEstadoE, Descripcion from EstadoEjemplar"
        Dim da As New SqlDataAdapter(vsql, cn)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
End Class
