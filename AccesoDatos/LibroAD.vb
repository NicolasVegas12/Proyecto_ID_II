Imports System.Data.SqlClient
Imports Entidades
Public Class LibroAD
    Dim conexion As New Conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter

    Public Sub InsertarLibros(ByVal objLibro As Libro)
        cn = conexion.conectar
        Try
            da = New SqlDataAdapter("sp_AccionesLibros", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IdLibro", SqlDbType.Char).Value = objLibro.IdLibro
                .Add("@Titulo", SqlDbType.VarChar).Value = objLibro.Titulo
                .Add("@FechaEdicion", SqlDbType.Char).Value = objLibro.FechaEdicion
                .Add("@IdEditorial", SqlDbType.Int).Value = objLibro.IdEditorial
                .Add("@Stock", SqlDbType.Int).Value = objLibro.Stock
                .Add("@IdIdioma", SqlDbType.Int).Value = objLibro.IdIdioma
                .Add("@IdAutor", SqlDbType.Int).Value = objLibro.IdAutor
                .Add("@IdArea", SqlDbType.Int).Value = objLibro.IdArea
                .Add("@tipoAccion", SqlDbType.Int).Value = 2
            End With
            cn.Open()
            da.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("error: " & ex.Message)
        Finally
            da.Dispose()
            cn.Close()
        End Try
    End Sub

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
