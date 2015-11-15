
Public Class vCliente
    Dim idcliente, idciudad As Integer
    Dim nombres, apellidos, dni, tipo_cliente, domicilio, telefono, email, web, estado As String
    Dim fecha_alta, fecha_ultimo_movimiento As Date
    Dim imagen() As Byte

    'seeter y getter

    Public Property gidcliente
        Get
            Return idcliente
        End Get
        Set(ByVal value)
            idcliente = value
        End Set
    End Property

    Public Property gnombres
        Get
            Return nombres
        End Get
        Set(ByVal value)
            nombres = value
        End Set
    End Property

    Public Property gapellidos
        Get
            Return apellidos
        End Get
        Set(ByVal value)
            apellidos = value
        End Set
    End Property

    Public Property gdni
        Get
            Return dni
        End Get
        Set(ByVal value)
            dni = value
        End Set
    End Property

    Public Property gtipo_cliente
        Get
            Return tipo_cliente

        End Get
        Set(ByVal value)
            tipo_cliente = value
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
            Return idciudad

        End Get
        Set(ByVal value)
            idciudad = value
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
    'constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal idcliente As Integer,
                   ByVal nombres As String,
                   ByVal apellidos As String,
                   ByVal dni As String,
                   ByVal tipo_cliente As String,
                   ByVal idciudad As Integer,
                   ByVal domicilio As String,
                   ByVal telefono As String,
                   ByVal email As String,
                   ByVal web As String,
                   ByVal imagen() As Byte,
                   ByVal fecha_alta As Date,
                   ByVal fecha_ultimo_movimiento As Date,
                   ByVal estado As String)
        gidcliente = idcliente
        gnombres = nombres
        gapellidos = apellidos
        gdni = dni
        gtipo_cliente = tipo_cliente
        gdomicilio = domicilio
        gidciudad = idciudad
        gtelefono = telefono
        gemail = email
        gweb = web
        gimagen = imagen
        gfecha_alta = fecha_alta
        gfecha_ultimo_movimiento = fecha_ultimo_movimiento
        gestado = estado

    End Sub
End Class
