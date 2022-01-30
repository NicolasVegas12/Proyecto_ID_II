Imports System.Data.SqlClient
Imports Entidades
Public Class CarreraAD
    Dim conexion As New Conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Public Function LlenarCarrera() As DataTable
        cn = conexion.conectar
        Dim vsql As String
        vsql = "exec sp_carrera @tipo=1 "
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(vsql, cn)
        da.Fill(dt)
        Return dt
    End Function
End Class
