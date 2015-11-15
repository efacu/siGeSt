
Public Class vDetalle_Egreso
    Dim iddetalle_egreso, idegreso, idproducto As Integer
    Dim cantidad, precio_unitario, descuento, impuesto As Double


    Public Property giddetalle_egreso
        Get
            Return iddetalle_egreso

        End Get
        Set(ByVal value)
            iddetalle_egreso = value
        End Set
    End Property

    Public Property gidegreso
        Get
            Return idegreso

        End Get
        Set(ByVal value)
            idegreso = value
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


    Public Property gprecio_unitario
        Get
            Return precio_unitario

        End Get
        Set(ByVal value)
            precio_unitario = value
        End Set
    End Property
    Public Property gdescuento
        Get
            Return descuento

        End Get
        Set(ByVal value)
            descuento = value
        End Set
    End Property
    Public Property gimpuesto
        Get
            Return impuesto

        End Get
        Set(ByVal value)
            impuesto = value
        End Set
    End Property

    Public Sub New()

    End Sub


    Public Sub New(ByVal iddetalle_egreso As Integer,
                   ByVal idegreso As Integer,
                   ByVal idproducto As Integer,
                   ByVal cantidad As Double,
                   ByVal precio_unitario As Double,
                    ByVal descuento As Double,
                   ByVal impuesto As Double)
        giddetalle_egreso = iddetalle_egreso
        gidegreso = idegreso
        gidproducto = idproducto
        gcantidad = cantidad
        gprecio_unitario = precio_unitario
        gdescuento = descuento
        gimpuesto = impuesto


    End Sub
End Class
