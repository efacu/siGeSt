Imports System.Data.SqlClient
Imports CapaLogica
Public Class vProvincia
    Dim idprovincia, idpais As Integer
    Dim nombre_provincia As String




    Public Property gidprovincia
        Get
            Return idprovincia
        End Get
        Set(ByVal value)
            idprovincia = value
        End Set
    End Property



    Public Property gnombre_provincia
        Get
            Return nombre_provincia
        End Get
        Set(ByVal value)
            nombre_provincia = value
        End Set
    End Property


    Public Property gidpais
        Get
            Return idpais
        End Get
        Set(ByVal value)
            idpais = value
        End Set
    End Property


    Public Sub New()

    End Sub

    Public Sub New(ByVal idcprovincia As Integer, ByVal nombre_provincia As String)

        gidprovincia = idprovincia
        gnombre_provincia = nombre_provincia
        gidpais = idpais

    End Sub

End Class
