

Public Class vProducto
    Dim idproducto, idcategoria, idmarca As Integer
    Dim nombre, descripcion, codigo_barra, estado As String
    Dim stock_actual, stock_min, stock_max, precio_ingreso, precio_egreso, precio_ingreso_anterior As Double
    Dim fecha_vencimiento As Date
    Dim imagen() As Byte




    Public Property gidproducto
        Get
            Return idproducto

        End Get
        Set(ByVal value)
            idproducto = value
        End Set
    End Property

    Public Property gidcategoria
        Get
            Return idcategoria
        End Get
        Set(ByVal value)
            idcategoria = value
        End Set
    End Property
    Public Property gcodigo_barra
        Get
            Return codigo_barra

        End Get
        Set(ByVal value)
            codigo_barra = value
        End Set
    End Property

    Public Property gidmarca
        Get
            Return idmarca
        End Get
        Set(ByVal value)
            idmarca = value
        End Set
    End Property

    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(ByVal value)
            nombre = value
        End Set
    End Property

    Public Property gdescripcion
        Get
            Return descripcion

        End Get
        Set(ByVal value)
            descripcion = value
        End Set
    End Property


    Public Property gstock_actual
        Get
            Return stock_actual

        End Get
        Set(ByVal value)
            stock_actual = value
        End Set
    End Property
    Public Property gstock_min
        Get
            Return stock_min
        End Get
        Set(ByVal value)
            stock_min = value
        End Set
    End Property
    Public Property gstock_max
        Get
            Return stock_max
        End Get
        Set(ByVal value)
            stock_max = value
        End Set
    End Property
    Public Property gprecio_ingreso_anterior
        Get
            Return precio_ingreso_anterior

        End Get
        Set(ByVal value)
            precio_ingreso_anterior = value

        End Set
    End Property
    Public Property gprecio_ingreso
        Get
            Return precio_ingreso

        End Get
        Set(ByVal value)
            precio_ingreso = value

        End Set
    End Property


    Public Property gprecio_egreso
        Get
            Return precio_egreso
        End Get
        Set(ByVal value)
            precio_egreso = value
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


    Public Property gimagen
        Get
            Return imagen
        End Get
        Set(ByVal value)
            imagen = value
        End Set
    End Property

    Public Property gestado
        Get
            Return estado
        End Get
        Set(ByVal value)
            estado = value
        End Set
    End Property

    Public Sub New()

    End Sub


    Public Sub New(ByVal idproducto As Integer,
                   ByVal idcategoria As Integer,
                   ByVal codigo_barra As String,
                   ByVal idmarca As Integer,
                   ByVal nombre As String,
                   ByVal descripcion As String,
                   ByVal stock_actual As Double,
                   ByVal stock_min As Double,
                   ByVal stock_max As Double,
                   ByVal precio_ingreso_anterior As Double,
                   ByVal precio_ingreso As Double,
                   ByVal precio_egreso As Double,
                   ByVal fecha_vencimiento As Date,
                   ByVal imagen() As Byte,
                   ByVal estado As String)
        gidproducto = idproducto
        gidcategoria = idcategoria
        gcodigo_barra = codigo_barra
        gidmarca = idmarca
        gnombre = nombre
        gdescripcion = descripcion
        gstock_actual = stock_actual
        gstock_min = stock_min
        gstock_max = stock_max
        gprecio_ingreso = precio_ingreso_anterior
        gprecio_ingreso = precio_ingreso
        gprecio_egreso = precio_egreso
        gfecha_vencimiento = fecha_vencimiento
        gimagen = imagen
        gestado = estado





    End Sub



End Class

