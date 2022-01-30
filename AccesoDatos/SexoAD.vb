Imports System.Data.SqlClient
Imports Entidades
Public Class SexoAD
    Dim conexion As New Conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Public Function LlenarSexo() As DataTable
        cn = conexion.conectar
        Dim vsql As String
        vsql = "SELECT IdSexo,Descripcion from Sexo"
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(vsql, cn)
        da.Fill(dt)
        Return dt
    End Function
End Class
