
Public Class vCiudad
    Dim idciudad, idprovincias As Integer
    Dim codigo_postal, nombre_ciudad As String




    Public Property gidciudad
        Get
            Return idciudad
        End Get
        Set(ByVal value)
            idciudad = value
        End Set
    End Property
    Public Property gcodigo_postal
        Get
            Return codigo_postal
        End Get
        Set(ByVal value)
            codigo_postal = value
        End Set
    End Property


    Public Property gnombre_ciudad
        Get
            Return nombre_ciudad
        End Get
        Set(ByVal value)
            nombre_ciudad = value
        End Set
    End Property




    Public Property gidprovincias
        Get
            Return idprovincias
        End Get
        Set(ByVal value)
            idprovincias = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idciudad As Integer, ByVal codigo_postal As String, ByVal nombre_ciudad As String, ByVal idprovincias As Integer)

        gidciudad = idciudad
        gcodigo_postal = codigo_postal
        gnombre_ciudad = nombre_ciudad
        gidprovincias = idprovincias

    End Sub
End Class
