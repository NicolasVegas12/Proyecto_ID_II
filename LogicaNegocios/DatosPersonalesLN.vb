Imports Entidades
Imports AccesoDatos
Imports System.Data
Public Class DatosPersonalesLN
    Public Function LlenarDatosPersonalesLN() As DataTable
        Dim objDatosP As New DatosPersonalesADvb
        Return objDatosP.LlenarDatosPersonal()
    End Function
End Class
