Imports CapaDatos
Imports CapaLogica
Imports System.Data.SqlClient


Public Class fmrDetallePedido


    Dim dt As New DataTable
    Private Sub fmrDetallepedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()

    End Sub
    Public Sub limpiar()
        btnguardar.Visible = True
        txtcodigo_barra.Text = ""
        txtidproducto.Text = ""
        txtnombre_producto.Text = ""
        txtcantidad.Value = 0
        txtstock.Value = 1
    End Sub




    Private Sub mostrar()
        Try
            Dim func As New fDetallePedido
            dt = func.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False


            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        btnnuevo.Visible = True


        buscar()
    End Sub

    Sub buscar_codigo(ByVal codigo_b As String)


    End Sub


    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = "idpepdido='" & txtidpedido.Text & "'"

            If dv.Count <> 0 Then
                inexistente.Visible = False
                datalistado.DataSource = dv
                ocultar_columnas()

            Else
                inexistente.Visible = True
                datalistado.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
        datalistado.Columns(2).Visible = False
        datalistado.Columns(3).Visible = False
        datalistado.Columns(4).Visible = False
        datalistado.Columns(5).Visible = False
        datalistado.Columns(12).Visible = False

    End Sub


    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
        frmReporteComprobante.txtidventa.Text = Me.txtidpedido.Text
        frmReporteComprobante.ShowDialog()


    End Sub



    Private Sub btnbuscar_producto_Click(sender As Object, e As EventArgs) Handles btnbuscar_producto.Click
        fmrElegirProducto.txtflag.Text = "3"
        fmrElegirProducto.ShowDialog()
    End Sub
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        If Me.ValidateChildren = True And txtidproducto.Text <> "" And txtcantidad.Text <> "0" Then
            Try
                Dim dts As New vDetallePedido
                Dim func As New fDetallePedido
                ''generar el id pedido
                dts.gidpedido = txtidpedido.Text
                dts.gidproducto = txtidproducto.Text
                dts.gcantidad = txtcantidad.Text
                ''dts.gprecio_unitario = txtprecio_unitario.Text
                ''dts.gdescuento = txtdescuento.Text
                ''dts.gimpuesto = txtinteres.Text


                If func.insertar(dts) Then
                    ''  If func.aumentar_stock(dts) Then

                    ''  End If
                    MessageBox.Show("Artículo fue añadido correctamente egreso", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()



                Else
                    MessageBox.Show("Artículo fue añadido correctamente a la venta intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cbeliminar_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("Eliminar").Visible = True
        Else
            datalistado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea quitar los artículos del pedido?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)



                    '''''
                    ''''
                    ''''arreglar procedimiento de almacenado idegreso cambiar por iddetalle_egreso
                    ''''
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("iddetallepedido").Value)
                        Dim vdb As New vDetallePedido
                        Dim func As New fDetallePedido
                        vdb.giddetallepedido = onekey

                        vdb.gidproducto = datalistado.SelectedCells.Item(2).Value
                        vdb.gidpedido = datalistado.SelectedCells.Item(3).Value
                        vdb.gcantidad = datalistado.SelectedCells.Item(9).Value



                        If func.eliminar(vdb) Then
                            If func.disminuir_stock(vdb) Then

                            End If
                        Else
                            MessageBox.Show("Artículo fue quitado del pedido", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If

                Next
                Call mostrar()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()
        End If

        Call limpiar()
    End Sub

    ' esto anda re bien lo unico que falta es odificar la edicion

    'Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick

    '    txtiddetallepedido.Text = datalistado.SelectedCells.Item(1).Value
    '    txtidproducto.Text = datalistado.SelectedCells.Item(3).Value
    '    txtcodigo_barra.Text = datalistado.SelectedCells.Item(5).Value
    '    txtnombre_producto.Text = datalistado.SelectedCells.Item(6).Value + " " + datalistado.SelectedCells.Item(7).Value + " " + datalistado.SelectedCells.Item(8).Value
    '    txtcantidad.Value = datalistado.SelectedCells.Item(9).Value
    '    txtdescuento.Text = datalistado.SelectedCells.Item(11).Value
    '    txtprecio_unitario.Text = datalistado.SelectedCells.Item(10).Value
    '    btneditar_articulo.Visible = True
    '    btneditar_articulo.Enabled = True
    '    btnguardar.Visible = False
    'End Sub

    Private Sub datalistado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub


    'Dim cantidad_actual As Double = txtcantidad.Value

    'Private Sub btneditar_articulo_Click(sender As Object, e As EventArgs) Handles btneditar_articulo.Click
    '    Dim result As DialogResult
    '    'preguntamos si esta seguro de editar o no los datos
    '    result = MessageBox.Show("Realmente desea modificar los datos del articulo?", "MOdificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
    '    If result = DialogResult.OK Then 'si esta seguro de modificar
    '        'verficamos que todos los campos no esten vacios
    '        If Me.ValidateChildren = True And txtmonto.Text <> "" Then
    '            Try
    '                Dim dts As New vDetallepedido 'instanciamos a la clase de variables de la tabla trabajador
    '                Dim func As New fDetallepedido 'instanciamos a la clase de funciones de la tabla trabajador

    '                'enviamos los datos 
    '                dts.giddetallepedido = txtiddetallepedido.Text
    '                dts.gidpedido = txtidigreso.Text
    '                dts.gidproducto = txtidproducto.Text
    '                dts.gcantidad = txtcantidad.Text
    '                dts.gprecio_unitario = txtprecio_unitario.Text
    '                dts.gdescuento = txtdescuento.Text
    '                dts.gimpuesto = txtinteres.Text






    '                'llamamos a la funcion mostrar del objeto func
    '                If func.editar(dts) Then
    '                    If cantidad_actual > txtcantidad.Value Then
    '                        If func.aumentar_stock(dts) Then

    '                        End If
    '                    ElseIf cantidad_actual < txtcantidad.Value Then
    '                        If func.disminuir_stock(dts) Then

    '                        End If
    '                    End If
    '                    MessageBox.Show("Equipo Modificado Correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    mostrar()
    '                    limpiar()
    '                Else

    '                    MessageBox.Show("Error al intentar Modificar el Equipo", "MOdificanco registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                End If


    '            Catch ex As Exception
    '                MsgBox(ex.Message)
    '            End Try
    '        Else
    '            'mostramos el mensaje en caso algunos de los campos esten vacios
    '            MessageBox.Show("Falta ingresar algunos datos", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '    Else
    '        'mostramos un mensaje en caso se cancele la modificacion
    '        MessageBox.Show("NO se ha modificado el equipo", "MOdificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Call mostrar()
    '    End If

    'End Sub


#Region "mostrar mensaje informativo "
    Private Sub txtcodigo_barra_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcodigo_barra.MouseHover
        'mostramos un mensaje informativo
        ttmensaje.SetToolTip(txtcodigo_barra, "Ingrese el codigo de barras, de esta manera el sistema autocompleta los demas campos")
        ttmensaje.ToolTipTitle = "Código barra"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcantidad_MouseHover(sender As Object, e As EventArgs) Handles txtcantidad.MouseHover
        ttmensaje.SetToolTip(txtcantidad, "Ingrese la cantidad de unidades del producto que desea agregar")
        ttmensaje.ToolTipTitle = "Cantidad"
        ttmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub



#End Region


#Region "validar globos rojo informativos"
    Private Sub txtnum_documento_validating(sender As Object, e As EventArgs) Handles txtnum_documento.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el numero de comprobante por favor, este dato es obligatorio")
        End If

    End Sub


    Private Sub txtcantidad_unitario_validating(sender As Object, e As EventArgs) Handles txtcantidad.Validating
        If DirectCast(sender, NumericUpDown).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la cantidad de unidades del producto por favor, este dato es obligatorio")
        End If
    End Sub



#End Region


#Region "validar '''validar solo numeros"

    Private Sub txtdescuento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'validamos que se ingresen solo numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtvantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtprecio_unitario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'validamos que se ingresen solo numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcantidad_unitario_validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtcantidad.Validating

    End Sub

    Private Sub txtprecio_unitario_validating(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub txtcuit_TextChanged(sender As Object, e As EventArgs) Handles txtcuit.TextChanged
        buscar_codigo(txtcodigo_barra.Text)
    End Sub







#End Region



    'Sub buscar_codigo_barra()
    '    Try
    '        Dim ds As New DataSet
    '        ds.Tables.Add(dt.Copy)
    '        Dim filas() As DataRow

    '        filas = dt.Select(txtcodigo_barra.Text)

    '        If filas.Length > 0 Then
    '            For Each dr As DataRow In filas



    '            Next
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)

    '    End Try

    'End Sub


    'Sub buscarnombrexcodigobarra(txtcodigo_barra) ''  As AutoCompleteStringCollection
    '    Using con As New SqlConnection("Data Source=(local);Initial Catalog=dbSGSv3;Integrated Security=True")
    '        con.Open()
    '        Dim consulta As String = "select * from producto"
    '        Dim cmd As New SqlCommand(consulta, con)

    '        Dim da As New SqlDataAdapter(cmd)

    '        da.Fill(dt)
    '        Dim coleccion As New AutoCompleteStringCollection

    '        For i = 0 To dt.Rows.Count - 1

    '            coleccion.Add(Convert.ToString(dt.Rows(i).Item("nombre")))

    '        Next
    '        Return coleccion
    '    End Using
    '    End

    'End Sub


    'Private Sub txtcodigo_barra_TextChanged_2(sender As Object, e As EventArgs) Handles txtcodigo_barra.TextChanged
    '    If (e.KeyCode = Keys.Enter) Then
    '        If txtcodigo_barra.Text <> "" Then

    '            txtnombre_producto.Focus()
    '            txtnombre_producto.Text = buscarnombrexcodigobarra(txtcodigo_barra.Text)
    '        End If
    '    End If
    'End Sub

End Class