Public Class vProveedor
    Dim idproveedor, idcuidad As Integer
    Dim nombre, apellido, razon_social,
        domicilio, telefono, cuit_cuil, tipo_proveedor, email, web, estado As String
    Dim fecha_alta, fecha_ultimo_movimiento As Date
    Dim imagen() As Byte


    Public Property gidproveedor
        Get
            Return idproveedor

        End Get
        Set(ByVal value)
            idproveedor = value
        End Set
    End Property
    Public Property grazon_social
        Get
            Return razon_social
        End Get
        Set(ByVal value)
            razon_social = value
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
    Public Property gapellido
        Get
            Return apellido
        End Get
        Set(ByVal value)
            apellido = value
        End Set
    End Property
    Public Property gcuit_cuil
        Get
            Return cuit_cuil

        End Get
        Set(ByVal value)
            cuit_cuil = value

        End Set
    End Property
    Public Property gtipo_proveedor
        Get
            Return tipo_proveedor

        End Get
        Set(ByVal value)
            tipo_proveedor = value
        End Set
    End Property
    Public Property gdomicilio
        Get
            Return domicilio

        End Get
        Set(ByVal value)
            domicilio = value
        End Set
    End Property
    Public Property gidciudad
        Get
            Return idcuidad

        End Get
        Set(ByVal value)
            idcuidad = value

        End Set
    End Property
    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(ByVal value)
            telefono = value
        End Set
    End Property
    Public Property gemail
        Get
            Return email

        End Get
        Set(ByVal value)
            email = value

        End Set
    End Property
    Public Property gweb
        Get
            Return web

        End Get
        Set(ByVal value)
            web = value

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
    Public Property gfecha_alta
        Get
            Return fecha_alta
        End Get
        Set(ByVal value)
            fecha_alta = value
        End Set
    End Property
    Public Property gfecha_ultimo_movimiento
        Get
            Return fecha_ultimo_movimiento
        End Get
        Set(ByVal value)
            fecha_ultimo_movimiento = value
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


    Public Sub New(ByVal idproveedor As Integer,
                   ByVal razon_social As String,
                   ByVal nombre As String,
                   ByVal apellido As String,
                   ByVal cuit_cuil As String,
                   ByVal tipo_proveedor As String,
                   ByVal domicilio As String,
                   ByVal idcuidad As Integer,
                   ByVal telefono As String,
                   ByVal email As String,
                   ByVal web As String,
                   ByVal imagen() As Byte,
                   ByVal fecha_alta As Date,
                   ByVal fecha_ultimo_movimiento As Date,
                   ByVal estado As String)
        gidproveedor = idproveedor
        grazon_social = razon_social
        gnombre = nombre
        gapellido = apellido
        gcuit_cuil = cuit_cuil
        gtipo_proveedor = tipo_proveedor
        gdomicilio = domicilio
        gidciudad = idcuidad
        gtelefono = telefono
        gemail = email
        gweb = web
        gimagen = imagen
        gfecha_alta = fecha_alta
        gfecha_ultimo_movimiento = fecha_ultimo_movimiento
        gestado = estado





    End Sub

End Class
