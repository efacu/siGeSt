Public Class vMarca
    Dim idmarca As Integer
    Dim nombre_marca As String




    Public Property gidmarca
        Get
            Return idmarca
        End Get
        Set(ByVal value)
            idmarca = value
        End Set
    End Property



    Public Property gnombre_marca
        Get
            Return nombre_marca
        End Get
        Set(ByVal value)
            nombre_marca = value
        End Set
    End Property





    Public Sub New()

    End Sub

    Public Sub New(ByVal idcmarca As Integer, ByVal nombre_marca As String)

        gidmarca = idmarca
        gnombre_marca = nombre_marca


    End Sub
End Class
