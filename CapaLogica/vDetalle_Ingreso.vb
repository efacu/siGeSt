

Public Class vDetalle_Ingreso

    Dim iddetalle_ingreso, idingreso, idproducto As Integer
    Dim cantidad, precio_unitario, descuento, impuesto As Double



    Public Property giddetalle_ingreso
        Get
            Return iddetalle_ingreso

        End Get
        Set(ByVal value)
            iddetalle_ingreso = value
        End Set
    End Property
    Public Property gidingreso
        Get
            Return idingreso

        End Get
        Set(ByVal value)
            idingreso = value
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


    Public Sub New(ByVal iddetalle_ingreso As Integer,
                   ByVal idingreso As Integer,
                   ByVal idproducto As Integer,
                   ByVal cantidad As Double,
                    ByVal precio_unitario As Double,
                   ByVal descuento As Double,
                   ByVal impuesto As Double)
        giddetalle_ingreso = iddetalle_ingreso
        gidingreso = idingreso
        gidproducto = idproducto
        gcantidad = cantidad
        gprecio_unitario = precio_unitario
        gdescuento = descuento
        gimpuesto = impuesto


    End Sub

End Class
