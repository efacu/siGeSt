Public Class vUsuario
    Dim idusuario, idciudad As Integer
    Dim nombres, apellidos, dni, telefono, sexo, direccion, email, login, password, estado As String
    Dim fecha_nac, fecha_alta As Date
    Dim imagen() As Byte
    Public Property gidusuario
        Get
            Return idusuario
        End Get
        Set(ByVal value)
            idusuario = value
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
    Public Property gfecha_nac
        Get
            Return fecha_nac
        End Get
        Set(ByVal value)
            fecha_nac = value
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
    Public Property gsexo
        Get
            Return sexo
        End Get
        Set(ByVal value)
            sexo = value
        End Set
    End Property
    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(ByVal value)
            direccion = value
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
    Public Property gemail
        Get
            Return email
        End Get
        Set(ByVal value)
            email = value
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

    Public Property glogin
        Get
            Return login
        End Get
        Set(ByVal value)
            login = value
        End Set
    End Property

    Public Property gpassword
        Get
            Return password
        End Get
        Set(ByVal value)
            password = value
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

    Public Sub New(ByVal idusuario As Integer,
                   ByVal nombres As String,
                   ByVal apellidos As String,
                   ByVal dni As String,
                   ByVal sexo As String,
                   ByVal fecha_nac As Date,
                   ByVal direccion As String,
                   ByVal idciudad As Integer,
                    ByVal telefono As String,
                   ByVal email As String,
                   ByVal imagen() As Byte,
                   ByVal login As String,
                   ByVal password As String,
                   ByVal fecha_alta As Date,
                   ByVal estado As String)
        gidusuario = idusuario
        gnombres = nombres
        gapellidos = apellidos
        gdni = dni
        gfecha_nac = fecha_nac
        gsexo = sexo
        gdireccion = direccion
        gidciudad = idciudad
        gtelefono = telefono
        gemail = email
        gimagen = imagen
        glogin = login
        gpassword = password
        gfecha_alta = fecha_alta
        gestado = estado
    End Sub




End Class
