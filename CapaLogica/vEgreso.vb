Public Class vEgreso
    Dim idegreso, idcliente As Integer
    Dim fecha_egreso As Date
    Dim tipo_documento, num_documento, tipo_egreso, observaciones, estado As String
    Dim monto As Double

    Public Property gidegreso
        Get
            Return idegreso
        End Get
        Set(ByVal value)
            idegreso = value
        End Set
    End Property

    Public Property gidcliente
        Get
            Return idcliente
        End Get
        Set(ByVal value)
            idcliente = value
        End Set
    End Property
    Public Property gtipo_egreso
        Get
            Return tipo_egreso

        End Get
        Set(ByVal value)
            tipo_egreso = value
        End Set
    End Property
    Public Property gfecha_egreso
        Get
            Return fecha_egreso
        End Get
        Set(ByVal value)
            fecha_egreso = value
        End Set
    End Property

    Public Property gtipo_documento
        Get
            Return tipo_documento

        End Get
        Set(ByVal value)
            tipo_documento = value
        End Set
    End Property

    Public Property gnum_documento
        Get
            Return num_documento

        End Get
        Set(ByVal value)
            num_documento = value
        End Set
    End Property
    Public Property gmonto
        Get
            Return monto

        End Get
        Set(ByVal value)
            monto = value
        End Set
    End Property
    Public Property gobservaciones
        Get
            Return observaciones
        End Get
        Set(ByVal value)
            observaciones = value
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


    Public Sub New(ByVal idegreso As Integer,
                   ByVal idcliente As Integer,
                   ByVal tipo_egreso As String,
                   ByVal fecha_egreso As Date,
                   ByVal tipo_documento As String,
                   ByVal num_documento As String,
                    ByVal monto As Double,
                     ByVal observaciones As String,
                   ByVal estado As String)
        gidegreso = idegreso
        gidcliente = idcliente
        gtipo_egreso = tipo_egreso
        gfecha_egreso = fecha_egreso
        gtipo_documento = tipo_documento
        gnum_documento = num_documento
        gmonto = monto
        gobservaciones = observaciones
        gestado = estado
    End Sub
End Class
