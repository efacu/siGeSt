Public Class vIngreso

    Dim idingreso, idproveedor As Integer
    Dim fecha_ingreso As Date
    Dim tipo_ingreso, tipo_documento, num_documento, observaciones, estado As String
    Dim monto As Double

    Public Property gidingreso
        Get
            Return idingreso
        End Get
        Set(ByVal value)
            idingreso = value
        End Set
    End Property

    Public Property gidproveedor
        Get
            Return idproveedor
        End Get
        Set(ByVal value)
            idproveedor = value
        End Set
    End Property

    Public Property gfecha_ingreso
        Get
            Return fecha_ingreso
        End Get
        Set(ByVal value)
            fecha_ingreso = value
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
    Public Property gtipo_ingreso
        Get
            Return tipo_ingreso

        End Get
        Set(ByVal value)
            tipo_ingreso = value
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


    Public Sub New(ByVal idingreso As Integer,
                   ByVal idproveedor As Integer,
                    ByVal tipo_ingreso As String,
                    ByVal fecha_ingreso As Date,
                   ByVal tipo_documento As String,
                   ByVal num_documento As String,
                    ByVal monto As Double,
                     ByVal observaciones As String,
                   ByVal estado As String)
        gidingreso = idingreso
        gidproveedor = idproveedor
        gtipo_ingreso = tipo_ingreso
        gfecha_ingreso = fecha_ingreso
        gtipo_documento = tipo_documento
        gnum_documento = num_documento
        gmonto = monto
        gobservaciones = observaciones
        gestado = estado

    End Sub
End Class

