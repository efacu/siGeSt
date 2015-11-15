Public Class vDetallePedido


    Dim iddetallepedido, idpedido, idproducto As Integer
    Dim cantidad As Double
    Dim fecha_pedido As Date


    Public Property giddetallepedido
        Get
            Return iddetallepedido

        End Get
        Set(ByVal value)
            iddetallepedido = value
        End Set
    End Property

    Public Property gidpedido
        Get
            Return idpedido

        End Get
        Set(ByVal value)
            idpedido = value
        End Set
    End Property

    Public Property gidproducto
        Get
            Return idproducto

        End Get
        Set(ByVal value)
            idproducto = value
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


    'Public Property gprecio_unitario
    '    Get
    '        Return precio_unitario

    '    End Get
    '    Set(ByVal value)
    '        precio_unitario = value
    '    End Set
    'End Property
    Public Property gfecha_pedido
        Get
            Return fecha_pedido

        End Get
        Set(ByVal value)
            fecha_pedido = value
        End Set
    End Property
    'Public Property gimpuesto
    '    Get
    '        Return impuesto

    '    End Get
    '    Set(ByVal value)
    '        impuesto = value
    '    End Set
    'End Property

    Public Sub New()

    End Sub


    Public Sub New(ByVal iddetallepedido As Integer,
                   ByVal idpedido As Integer,
                   ByVal idproducto As Integer,
                   ByVal cantidad As Double,
                   ByVal fecha_pedido As Date)
        giddetallepedido = iddetallepedido
        gidpedido = idpedido
        gidproducto = idproducto
        gcantidad = cantidad

        gfecha_pedido = fecha_pedido



    End Sub


End Class
