Imports System.Data.SqlClient
Imports CapaLogica

Public Class vPais
    Dim idpais As Integer
    Dim nombre_pais As String




    Public Property gidpais
        Get
            Return idpais
        End Get
        Set(ByVal value)
            idpais = value
        End Set
    End Property



    Public Property gnombre_pais
        Get
            Return nombre_pais
        End Get
        Set(ByVal value)
            nombre_pais = value
        End Set
    End Property





    Public Sub New()

    End Sub

    Public Sub New(ByVal idcpais As Integer, ByVal nombre_pais As String)

        gidpais = idpais
        gnombre_pais = nombre_pais


    End Sub

End Class
