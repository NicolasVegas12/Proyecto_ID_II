Imports System.Data.SqlClient
Imports Entidades
Public Class ListaLibrosPrestadosAD
    Dim conexion As New Conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Public Sub IngresarLibrosPrestados(ByVal objLibro As ListaLibroPrestado)
        cn = conexion.conectar
        Try
            da = New SqlDataAdapter("sp_LibrosPrestados", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@NroCarnet", SqlDbType.Char).Value = objLibro.NroCarnet
                .Add("@IdLibro", SqlDbType.Char).Value = objLibro.IdLibro
                .Add("@tipo", SqlDbType.Int).Value = 1
            End With
            cn.Open()
            da.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error:" & ex.Message)
        Finally
            da.Dispose()
            cn.Close()
        End Try
    End Sub

    Public Function DevolverLibro(IdPrestamo As Char, IdLibro As String) As Boolean
        cn = conexion.conectar
        Try
            da = New SqlDataAdapter("sp_LibrosPrestados", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IdLibro", SqlDbType.Char).Value = IdLibro
                .Add("@IdPrestamo", SqlDbType.Char).Value = IdPrestamo
                .Add("@tipo", SqlDbType.Int).Value = 2
            End With
            cn.Open()
            da.SelectCommand.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Error:" & ex.Message)
            Return False
        Finally
            da.Dispose()
            cn.Close()
        End Try
    End Function

    Public Function ListarLibrosPrestadosTotales() As DataTable
        cn = conexion.conectar
        Dim vsql As String
        vsql = " EXEC sp_LibrosPrestados @tipo = 3"
        Dim da As New SqlDataAdapter(vsql, cn) ' se ejecutar en el servidor
        ' Data Tabla contendra localmente los datos del SQLDataAdapter
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function ListarLibrosPrestadosPendientes() As DataTable
        cn = conexion.conectar
        Dim vsql As String
        vsql = " EXEC sp_LibrosPrestados @tipo = 4"
        Dim da As New SqlDataAdapter(vsql, cn) ' se ejecutar en el servidor
        ' Data Tabla contendra localmente los datos del SQLDataAdapter
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function ReportarPerdido(IdPrestamo As Char, IdLibro As String) As Boolean
        cn = conexion.conectar
        cn.Open()
        Try
            da = New SqlDataAdapter("sp_LibrosPrestados", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@IdLibro", SqlDbType.Char).Value = IdLibro
                .Add("@IdPrestamo", SqlDbType.Char).Value = IdPrestamo
                .Add("@tipo", SqlDbType.Int).Value = 5
            End With
            cn.Open()
            da.SelectCommand.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Error:" & ex.Message)
            Return False
        Finally
            da.Dispose()
            cn.Close()
        End Try
    End Function
    Public Function ListarPrestamosXAlumno(nroCarnet As String) As DataTable
        cn = conexion.conectar
        Dim vsql As String
        vsql = " EXEC sp_LibrosPrestados @tipo = 6, @NroCarnet=" & nroCarnet & ""
        Dim da As New SqlDataAdapter(vsql, cn) ' se ejecutar en el servidor
        ' Data Tabla contendra localmente los datos del SQLDataAdapter
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
    Public Function ListarLibrosxAlumno(nroCarnet As String) As DataTable
        cn = conexion.conectar
        Dim vsql As String
        vsql = " EXEC sp_LibrosPrestados @tipo = 8, @NroCarnet=" & nroCarnet & ""
        Dim da As New SqlDataAdapter(vsql, cn) ' se ejecutar en el servidor
        ' Data Tabla contendra localmente los datos del SQLDataAdapter
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function
End Class
