Imports System.Data.SqlClient
Imports Entidades
Public Class EditorialAD
    Dim conexion As New Conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Public Function LlenarEditorial() As DataTable
        cn = conexion.conectar
        Dim vsql As String
        vsql = "SELECT IdEditorial, Nombre from Editorial"
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(vsql, cn)
        da.Fill(dt)
        Return (dt)
    End Function
End Class
