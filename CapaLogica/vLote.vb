Public Class vLote
    Dim idlote As Integer
    Dim fecha_vencimiento As Date
    Dim cantidad As Double
    Dim activo As String


    Public Property gidlote
        Get
            Return idlote
        End Get
        Set(ByVal value)
            idlote = value
        End Set
    End Property

    Public Property gcantidad
        Get
            Return cantidad
        End Get
        Set(ByVal value)
            cantidad = value
        End Set
    End Property

    Public Property gfecha_vencimiento
        Get
            Return fecha_vencimiento
        End Get
        Set(ByVal value)
            fecha_vencimiento = value
        End Set
    End Property

    Public Property gactivo
        Get
            Return activo

        End Get
        Set(ByVal value)
            activo = value
        End Set
    End Property



    Public Sub New()

    End Sub


    Public Sub New(ByVal idlote As Integer,
                   ByVal cantidad As Double,
                   ByVal fecha_vencimiento As Date,
                   ByVal activo As String)
        gidlote = idlote
        gcantidad = cantidad
        gfecha_vencimiento = fecha_vencimiento
        gactivo = activo


    End Sub
End Class
