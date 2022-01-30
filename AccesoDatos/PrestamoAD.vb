Imports System.Data.SqlClient
Imports Entidades
Public Class PrestamoAD
    Dim conexion As New Conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter
    Public Sub InsertarPrestamo(objP As Prestamo)
        cn = conexion.conectar
        Try
            da = New SqlDataAdapter("sp_prestamo", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@nroCarnet", SqlDbType.Char).Value = objP.NroCarnet
                .Add("@IdPrestamo", SqlDbType.Char).Value = objP.Prestamo
                .Add("@tipo", SqlDbType.TinyInt).Value = 1
            End With
            cn.Open()
            da.SelectCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            da.Dispose()
            cn.Close()
        End Try
    End Sub

    Public Function LlenarPrestamos() As DataTable
        cn = conexion.conectar
        Dim vsql As String
        vsql = " EXEC sp_prestamo @tipo=3"
        Dim da As New SqlDataAdapter(vsql, cn) ' se ejecutar en el servidor
        ' Data Tabla contendra localmente los datos del SQLDataAdapter
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function



End Class
