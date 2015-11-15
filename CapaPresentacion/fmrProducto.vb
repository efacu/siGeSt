Imports CapaLogica
Imports CapaDatos
Public Class fmrProducto
    Private dt As New DataTable
#Region "sub funciones basicas"
    Private Sub frmproducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar()
        'Me.ReportViewer1.RefreshReport
    End Sub


    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnombre.Text = ""
        txtdesccripcion.Text = ""
        txtstock.Text = "0"
        txtprecio_compra.Text = "0"
        txtprecio_venta.Text = "0"
        txtidcproducto.Text = ""

        imagen.Image = Nothing
        imagen.BackgroundImage = My.Resources.productos
        imagen.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fProducto
            dt = func.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False


            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False
            Else
                datalistado.DataSource = Nothing
                txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        btnnuevo.Visible = True
        btneditar.Visible = False

        buscar()
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cbocampo.Text & " like '" & txtbuscar.Text & "%'"

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
    End Sub
#End Region


    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtdesccripcion.Text <> "" And txtstock.Text <> "" And txtprecio_compra.Text <> "" And txtprecio_venta.Text <> "" Then
            Try
                Dim dts As New vProducto
                Dim func As New fProducto
                dts.gcodigo_barra = txtCodigoBarra.Text
                dts.gidmarca = txtidmarca.Text
                dts.gidcategoria = txtidcategoria.Text
                dts.gnombre = StrConv((txtnombre.Text), VbStrConv.ProperCase)
                dts.gdescripcion = StrConv((txtdesccripcion.Text), VbStrConv.ProperCase)
                dts.gstock_actual = txtstock.Text
                dts.gprecio_ingreso = txtprecio_compra.Text
                dts.gprecio_egreso = txtprecio_venta.Text
                dts.gfecha_vencimiento = txtfecha_vencimiento.Text
                dts.gestado = "1"

                Dim ms As New IO.MemoryStream()

                If Not imagen.Image Is Nothing Then
                    imagen.Image.Save(ms, imagen.Image.RawFormat)
                Else
                    imagen.Image = My.Resources.productos
                    imagen.Image.Save(ms, imagen.Image.RawFormat)
                End If
                dts.gimagen = ms.GetBuffer


                If func.insertar(dts) Then
                    MessageBox.Show("producto registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("producto no fue registrado intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub datalistado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtidcproducto.Text = datalistado.SelectedCells.Item(1).Value
        txtidcategoria.Text = datalistado.SelectedCells.Item(2).Value
        txtnom_categoria.Text = datalistado.SelectedCells.Item(3).Value
        txtnombre.Text = datalistado.SelectedCells.Item(4).Value
        txtdesccripcion.Text = datalistado.SelectedCells.Item(5).Value
        txtstock.Text = datalistado.SelectedCells.Item(6).Value
        txtprecio_compra.Text = datalistado.SelectedCells.Item(7).Value
        txtprecio_venta.Text = datalistado.SelectedCells.Item(8).Value
        txtfecha_vencimiento.Text = datalistado.SelectedCells.Item(9).Value


        imagen.BackgroundImage = Nothing
        Dim b() As Byte = datalistado.SelectedCells.Item(10).Value
        Dim ms As New IO.MemoryStream(b)

        imagen.Image = Image.FromStream(ms)
        imagen.SizeMode = PictureBoxSizeMode.StretchImage



        btneditar.Visible = True
        btnguardar.Visible = False
    End Sub

    Private Sub datalistado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub btneditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos del producto?", "MOdificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtdesccripcion.Text <> "" And txtstock.Text <> "" And txtprecio_compra.Text <> "" And txtprecio_venta.Text <> "" And txtidcproducto.Text <> "" Then
                Try
                    Dim dts As New vProducto
                    Dim func As New fProducto

                    dts.gidproducto = txtidcproducto.Text
                    dts.gnombre = txtnombre.Text
                    dts.gidcategoria = txtidcategoria.Text
                    dts.gdescripcion = txtdesccripcion.Text
                    dts.gstock_actual = txtstock.Text
                    dts.gprecio_ingreso = txtprecio_compra.Text
                    dts.gprecio_egreso = txtprecio_venta.Text
                    dts.gfecha_vencimiento = txtfecha_vencimiento.Text


                    Dim ms As New IO.MemoryStream()

                    If Not imagen.Image Is Nothing Then
                        imagen.Image.Save(ms, imagen.Image.RawFormat)
                    Else
                        imagen.Image = My.Resources.productos
                        imagen.Image.Save(ms, imagen.Image.RawFormat)
                    End If

                    dts.gimagen = ms.GetBuffer


                    If func.editar(dts) Then
                        MessageBox.Show("producto MOdificado correctamente", "MOdificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("producto no fue modifcado intente de nuevo", "MOdificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falta ingresar algunos datos", "MOdificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub cbeliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("Eliminar").Visible = True
        Else
            datalistado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar los productos seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idproducto").Value)
                        Dim vdb As New vProducto
                        Dim func As New fProducto
                        vdb.gidproducto = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("producto no fue eliminado", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub btncargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncargar.Click
        If dlg.ShowDialog() = DialogResult.OK Then
            imagen.BackgroundImage = Nothing
            imagen.Image = New Bitmap(dlg.FileName)
            imagen.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub btnlimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpiar.Click
        imagen.Image = Nothing
        imagen.BackgroundImage = My.Resources.productos
        imagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub


    Private Sub btnbuscarcategoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarcategoria.Click
        fmrCategoria.txtflag.Text = "1"
        fmrCategoria.ShowDialog()
    End Sub




    Private Sub txtbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub datalistado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If txtflag.Text = "1" Then
            fmrDetalleEgreso.txtidproducto.Text = datalistado.SelectedCells.Item(1).Value
            fmrDetalleEgreso.txtnombre_producto.Text = datalistado.SelectedCells.Item(4).Value
            fmrDetalleEgreso.txtstock.Text = datalistado.SelectedCells.Item(6).Value
            fmrDetalleEgreso.txtprecio_unitario.Text = datalistado.SelectedCells.Item(8).Value
            Me.Close()

        End If
    End Sub






    Private Sub btnbuscmarca_Click(sender As Object, e As EventArgs) Handles btnbuscmarca.Click
        fmrMarca.txtflag.Text = "1"
        fmrMarca.ShowDialog()
    End Sub



#Region "validar dato numerico texbox"
    Private Sub txtstock_keypres(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtstock.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtprecio_compra_keypres(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecio_compra.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
#End Region


#Region "Validar campos no nulos globo rojo"
    Private Sub txtprecio_venta_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtprecio_venta.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el precio en el que se vendera el producto porfavor, este datos es obligatorio")
        End If
    End Sub
    Private Sub txtprecio_compra_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtprecio_compra.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el precio de compra del producto porfavor, este datos es obligatorio")
        End If
    End Sub

    Private Sub txtidcategoria_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtidcategoria.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Seleccione la categoría del producto, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtstock_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtstock.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el stock del producto porfavor, este datos es obligatorio")
        End If
    End Sub
    Private Sub txtnombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre del cliente porfavor, este datos es obligatorio")
        End If
    End Sub
#End Region


End Class