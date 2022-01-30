Imports Entidades
Imports AccesoDatos
Imports System.Data
Public Class PrestamoLN
    Public Function LlenarPrestamoLN() As DataTable
        Dim objPrestamo As New PrestamoAD
        Return objPrestamo.LlenarPrestamos()
    End Function
    Public Function InsertarPrestamoLN(objA As Prestamo) As Boolean
        Try
            Dim objAD As New PrestamoAD
            objAD.InsertarPrestamo(objA)
            Return True
        Catch e As Exception
            MsgBox("error: " & e.Message)
            Return False
        End Try
    End Function
End Class
