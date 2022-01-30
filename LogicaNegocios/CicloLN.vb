Imports Entidades
Imports AccesoDatos
Imports System.Data

Public Class CicloLN
    Public Function LlenarCicloLN() As DataTable
        Dim objCiclo As New CicloAD
        Return objCiclo.LlenarCiclos()
    End Function
End Class
