Imports Entidades
Imports AccesoDatos
Imports System.Data
Public Class PrestamoLN
    Public Function LlenarPrestamoLN() As DataTable
        Dim objPrestamo As New PrestamoAD
        Return objPrestamo.LlenarPrestamos()
    End Function
    Public Function InsertarPrestamoLN(nroCarnet As String) As Boolean
        Try
            Dim objAD As New PrestamoAD
            objAD.InsertarPrestamo(nroCarnet)
            Return True
        Catch e As Exception
            MsgBox("error: " & e.Message)
            Return False
        End Try
    End Function
End Class
