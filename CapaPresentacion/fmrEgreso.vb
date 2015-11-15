
Imports CapaDatos
Imports CapaLogica

Public Class fmrEgreso

    Private dt As New DataTable
    Private Sub frmventa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar()

    End Sub
    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtidcliente.Text = ""
        txtnombre_cliente.Text = ""
        txtnum_documento.Text = ""
        txtnum_documento.Text = ""
        txtidegreso.Text = ""
    End Sub
    Private Sub mostrar()
        Try
            Dim func As New fEgreso
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
        datalistado.Columns(4).Visible = False
        datalistado.Columns(5).Visible = False
        datalistado.Columns(6).Visible = False
        datalistado.Columns(7).Visible = False
        datalistado.Columns(14).Visible = False
        datalistado.Columns(15).Visible = False
        datalistado.Columns(16).Visible = False
    End Sub


    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        '' If Me.ValidateChildren = True And txtidcliente.Text <> "" And txtnombre_cliente.Text <> "" And txtnum_documento.Text <> "" Then
        Try
                Dim dts As New vEgreso
                Dim func As New fEgreso

            dts.gidcliente = txtidcliente.Text
            dts.gtipo_egreso = cbtipo_egreso.Text
            dts.gfecha_egreso = txtfecha.Text
            dts.gtipo_documento = cbtipo_documento.Text
            dts.gnum_documento = txtnum_documento.Text
            dts.gmonto = txtmonto.Text
            dts.gobservaciones = txtobs.Text
            dts.gestado = "1"



            If func.insertar(dts) Then
                    MessageBox.Show("Egreso registrado correctamente vamos añadir productos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    cargar_detalle()


                Else
                    MessageBox.Show("El egreso no fue registrado intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ''  Else
        ''MessageBox.Show("Falta ingresar algunos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ''End If
    End Sub

    Private Sub datalistado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtidegreso.Text = datalistado.SelectedCells.Item(1).Value
        txtidcliente.Text = datalistado.SelectedCells.Item(2).Value
        cbtipo_egreso.Text = datalistado.SelectedCells.Item(10).Value
        txtfecha.Text = datalistado.SelectedCells.Item(11).Value
        txtnombre_cliente.Text = datalistado.SelectedCells.Item(3).Value + " " + datalistado.SelectedCells.Item(4).Value

        cbtipo_documento.Text = datalistado.SelectedCells.Item(13).Value
        txtnum_documento.Text = datalistado.SelectedCells.Item(14).Value
        txtmonto.Text = datalistado.SelectedCells.Item(15).Value
        txtobs.Text = datalistado.SelectedCells.Item(16).Value
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

        result = MessageBox.Show("Realmente desea editar los datos de la venta?", "MOdificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtidcliente.Text <> "" And txtnum_documento.Text <> "" And txtidegreso.Text <> "" Then
                Try
                    Dim dts As New vEgreso
                    Dim func As New fEgreso

                    dts.gidegreso = txtidegreso.Text
                    dts.gidcliente = txtidcliente.Text
                    dts.gtipo_documento = cbtipo_documento.Text
                    dts.gfecha_egreso = txtfecha.Text
                    dts.gnum_documento = txtnum_documento.Text
                    dts.gmonto = txtmonto.Text
                    dts.gobservaciones = txtobs.Text
                    dts.gestado = "1"

                    If func.editar(dts) Then
                        MessageBox.Show("venta MOdificada correctamente", "MOdificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Venta no fue modifcada intente de nuevo", "MOdificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub txtbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub


    Private Sub cargar_detalle()
        fmrDetalleEgreso.txtidegreso.Text = datalistado.SelectedCells.Item(1).Value
        fmrDetalleEgreso.txtidcliente.Text = datalistado.SelectedCells.Item(2).Value
        fmrDetalleEgreso.txtnombre_cliente.Text = datalistado.SelectedCells.Item(3).Value + " " + datalistado.SelectedCells.Item(4).Value
        fmrDetalleEgreso.txtdni.Text = datalistado.SelectedCells.Item(5).Value
        fmrDetalleEgreso.txtdomicilio.Text = datalistado.SelectedCells.Item(7).Value + ", " + datalistado.SelectedCells.Item(8).Value + " CP: " + datalistado.SelectedCells.Item(9).Value
        fmrDetalleEgreso.cbtipo_ingreso.Text = datalistado.SelectedCells.Item(10).Value
        fmrDetalleEgreso.txtfecha.Text = datalistado.SelectedCells.Item(11).Value
        fmrDetalleEgreso.cbtipo_documento.Text = datalistado.SelectedCells.Item(12).Value
        fmrDetalleEgreso.txtnum_documento.Text = datalistado.SelectedCells.Item(13).Value

        fmrDetalleEgreso.ShowDialog()
    End Sub


    Private Sub datalistado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        cargar_detalle()
    End Sub

    Private Sub btnbuscar_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar_cliente.Click
        fmrElegirCliente.txtflag.Text = "3"
        fmrElegirCliente.ShowDialog()
    End Sub



    Private Sub txtidcliente_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtidcliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Seleccione el cliente, este dato es obligatorio")
        End If
    End Sub



    Private Sub txtnum_documento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtnum_documento.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el número de comprobante, este dato es obligatorio")
        End If
    End Sub


    Private Sub txtnombre_cliente_validating(sender As Object, e As EventArgs) Handles txtnombre_cliente.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese los datos del cliente porfavor, este datos es obligatorio")
        End If
    End Sub

    Private Sub btbcancelar_Click(sender As Object, e As EventArgs) Handles btbcancelar.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtnum_documento_TextChanged(sender As Object, e As EventArgs) Handles txtnum_documento.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtidcliente_TextChanged(sender As Object, e As EventArgs) Handles txtidcliente.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


End Class