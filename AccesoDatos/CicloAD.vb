Imports System.Data.SqlClient
Imports Entidades
Public Class CicloAD
    Dim conexion As New Conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Public Function LlenarCiclos() As DataTable
        cn = conexion.conectar
        Dim vsql As String
        vsql = "SELECT IdCiclo, Nombre from Ciclo"
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(vsql, cn)
        da.Fill(dt)
        Return dt
    End Function
End Class
