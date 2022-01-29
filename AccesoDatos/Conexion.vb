Imports System.Data.SqlClient
Public Class Conexion
    Public Function conectar() As SqlConnection
        Dim vCadena As String
        vCadena = "Server=" & My.Settings.Servidor & "; Database=" & My.Settings.BaseDatos & ";Integrated Security=True"
        Dim cn As New SqlConnection(vCadena)
        Return cn
    End Function
End Class
