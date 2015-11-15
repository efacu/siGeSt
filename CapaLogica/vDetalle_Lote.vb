Public Class vDetalle_Lote
    Dim iddetalle_lote, idlote, idproducto As Integer
    Dim deposito_stockactual As Double
    '' Dim deposito_stock_actual As Date
    Dim observacion As String


    Public Property giddetalle_lote
        Get
            Return iddetalle_lote

        End Get
        Set(ByVal value)
            iddetalle_lote = value
        End Set
    End Property
    Public Property gidlote
        Get
            Return idlote

        End Get
        Set(ByVal value)
            idlote = value
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

    Public Property gdeposito_stockactual
        Get
            Return deposito_stockactual

        End Get
        Set(ByVal value)
            deposito_stockactual = value
        End Set
    End Property

    Public Property gobservacion
        Get
            Return observacion

        End Get
        Set(ByVal value)
            observacion = value
        End Set
    End Property




    Public Sub New()

    End Sub


    Public Sub New(ByVal iddetalle_lote As Integer,
                   ByVal idlote As Integer,
                   ByVal idproducto As Integer,
                   ByVal deposito_stoclactual As Date,
                   ByVal descuento As String)
        giddetalle_lote = iddetalle_lote
        gidlote = idlote
        gidproducto = idproducto
        gdeposito_stockactual = deposito_stockactual
        gobservacion = observacion



    End Sub
End Class
