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

    Public Sub AgregarLibros(ByVal objLibro As Libro)
        cn = conexion.conectar
        Try
            da = New SqlDataAdapter("pa_NuevoLibro", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@Titulo", SqlDbType.VarChar).Value = objLibro.Titulo
                .Add("@FechaEdicion", SqlDbType.VarChar).Value = objLibro.FechaEdicion
                .Add("@IdEditorial", SqlDbType.Int).Value = objLibro.IdEditorial
                .Add("@Stock", SqlDbType.Int).Value = objLibro.Stock
                .Add("@IdIdioma", SqlDbType.Int).Value = objLibro.IdIdioma
                .Add("@IdAutor", SqlDbType.Int).Value = objLibro.IdAutor
                .Add("@IdArea", SqlDbType.Int).Value = objLibro.IdArea
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
    Public Sub EditarLibro(ByVal objL As Libro)
        cn = conexion.conectar
        Try
            da = New SqlDataAdapter("sp_AccionesLibros", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IdLibro", SqlDbType.Char).Value = objL.IdLibro
                .Add("@Titulo", SqlDbType.VarChar).Value = objL.Titulo
                .Add("@FechaEdicion", SqlDbType.Char).Value = objL.FechaEdicion
                .Add("@IdEditorial", SqlDbType.Int).Value = objL.IdEditorial
                .Add("@Stock", SqlDbType.Int).Value = objL.Stock
                .Add("@IdIdioma", SqlDbType.Int).Value = objL.IdIdioma
                .Add("@IdAutor", SqlDbType.Int).Value = objL.IdAutor
                .Add("@IdArea", SqlDbType.Int).Value = objL.IdArea
                .Add("@tipoAccion", SqlDbType.Int).Value = 3
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

    Public Function ListarLibro() As DataTable
        cn = conexion.conectar
        Dim vsql As String
        vsql = "SELECT * FROM Libro L inner join Editorial E on E.IdEditorial=L.IdEditorial;"
        Dim da As New SqlDataAdapter(vsql, cn)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function SeleccionarLibro(IdLibro As String) As Libro
        Dim objL As New Libro
        cn = conexion.conectar
        Dim vsql As String
        vsql = "Exec sp_AccionesLibros @IdLibro ='" & IdLibro & "', @tipoAccion=4"
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(vsql, cn)
        da.Fill(dt)

        objL.IdLibro = dt.Rows(0).Item(0)
        objL.Titulo = dt.Rows(0).Item(1)
        objL.FechaEdicion = dt.Rows(0).Item(2)
        objL.IdEditorial = dt.Rows(0).Item(3)
        objL.Stock = dt.Rows(0).Item(4)
        objL.IdIdioma = dt.Rows(0).Item(5)
        objL.IdAutor = dt.Rows(0).Item(6)
        objL.IdArea = dt.Rows(0).Item(7)
        Return objL
    End Function

    Public Function FiltrosLibro(objL As Libro) As DataTable
        cn = conexion.conectar
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter("sp_AccionesLibros", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IdEditorial", SqlDbType.Int).Value = objL.IdEditorial
                .Add("@IdIdioma", SqlDbType.Int).Value = objL.IdIdioma
                .Add("@IdAutor", SqlDbType.Int).Value = objL.IdAutor
                .Add("@IdArea", SqlDbType.Int).Value = objL.IdArea
                .Add("@tipoAccion", SqlDbType.Int).Value = 5
            End With
            cn.Open()
            da.SelectCommand.ExecuteNonQuery()

            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox("error: " & ex.Message)
            Return dt
        Finally
            da.Dispose()
            cn.Close()
        End Try
    End Function
End Class
