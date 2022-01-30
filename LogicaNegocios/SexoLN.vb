Imports Entidades
Imports AccesoDatos
Imports System.Data
Public Class SexoLN
    Public Function LlenarSexoLN() As DataTable
        Dim objSexo As New SexoAD
        Return objSexo.LlenarSexo()
    End Function
End Class
