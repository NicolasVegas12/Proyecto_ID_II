Imports System.Data.SqlClient
Imports Entidades
Public Class FacultadAD
    Dim conexion As New Conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Public Function LlenarFacultad() As DataTable
        cn = conexion.conectar
        Dim vsql As String
        vsql = "SELECT IdFacultad,Nombre from Facultad"
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(vsql, cn)
        da.Fill(dt)
        Return dt
    End Function
End Class
