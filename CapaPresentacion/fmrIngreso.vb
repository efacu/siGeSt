Imports CapaDatos
Imports CapaLogica

Public Class fmrIngreso

    Private dt As New DataTable
    Private Sub frmingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar()

    End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtidproveedor.Text = ""
        txtnombre_proveedor.Text = ""
        txtnum_documento.Text = ""
        txtnum_documento.Text = ""
        txtidingreso.Text = ""
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fIngreso
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
        datalistado.Columns(7).Visible = False
        datalistado.Columns(8).Visible = False
        datalistado.Columns(9).Visible = False
        datalistado.Columns(10).Visible = False
        datalistado.Columns(16).Visible = False
        datalistado.Columns(17).Visible = False

    End Sub



    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        '' If Me.ValidateChildren = True And txtidproveedor.Text <> "" And txtnombre_proveedor.Text <> "" And txtnum_documento.Text <> "" Then
        Try
            Dim dts As New vIngreso
            Dim func As New fIngreso

            dts.gidproveedor = txtidproveedor.Text
            dts.gtipo_ingreso = cbtipo_ingreso.Text
            dts.gfecha_ingreso = txtfecha.Text
            dts.gtipo_documento = cbtipo_documento.Text
            dts.gnum_documento = txtnum_documento.Text
            dts.gmonto = txtmonto.Text
            dts.gobservaciones = txtobs.Text
            dts.gestado = "1"



            If func.insertar(dts) Then
                MessageBox.Show("Ingresoregistrado correctamente vamos añadir productos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrar()
                limpiar()
                cargar_detalle()


            Else
                MessageBox.Show("El ingreso no fue registrado intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtidingreso.Text = datalistado.SelectedCells.Item(1).Value
        txtidproveedor.Text = datalistado.SelectedCells.Item(2).Value
        txtnombre_proveedor.Text = datalistado.SelectedCells.Item(3).Value + ", " + datalistado.SelectedCells.Item(4).Value + " " + datalistado.SelectedCells.Item(5).Value
        cbtipo_ingreso.Text = datalistado.SelectedCells.Item(11).Value
        txtfecha.Text = datalistado.SelectedCells.Item(12).Value


        cbtipo_documento.Text = datalistado.SelectedCells.Item(13).Value
        txtnum_documento.Text = datalistado.SelectedCells.Item(14).Value
        'txtmonto.Text = datalistado.SelectedCells.Item(11).Value
        'txtobs.Text = datalistado.SelectedCells.Item(12).Value
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

        result = MessageBox.Show("Realmente desea editar los datos del ingreso?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtidproveedor.Text <> "" And txtnum_documento.Text <> "" And txtidingreso.Text <> "" Then
                Try
                    Dim dts As New vIngreso
                    Dim func As New fIngreso

                    dts.gidingreso = txtidingreso.Text
                    dts.gidproveedor = txtidproveedor.Text
                    dts.gtipo_documento = cbtipo_documento.Text
                    dts.gfecha_ingreso = txtfecha.Text
                    dts.gnum_documento = txtnum_documento.Text
                    dts.gmonto = txtmonto.Text
                    dts.gobservaciones = txtobs.Text
                    dts.gestado = "1"

                    If func.editar(dts) Then
                        MessageBox.Show("ingreso modificado correctamente", "MOdificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Ingreso no fue modifcado intente de nuevo", "MOdificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        fmrDetalleIngreso.txtidigreso.Text = datalistado.SelectedCells.Item(1).Value
        fmrDetalleIngreso.txtidproveedor.Text = datalistado.SelectedCells.Item(2).Value
        fmrDetalleIngreso.txtnombre_proveedor.Text = datalistado.SelectedCells.Item(3).Value + ", " + datalistado.SelectedCells.Item(4).Value + " " + datalistado.SelectedCells.Item(5).Value
        fmrDetalleIngreso.txtcuit.Text = datalistado.SelectedCells.Item(6).Value
        fmrDetalleIngreso.txtdomicilio.Text = datalistado.SelectedCells.Item(8).Value + ", " + datalistado.SelectedCells.Item(9).Value + ". CP:" + datalistado.SelectedCells.Item(10).Value
        fmrDetalleIngreso.cbtipo_ingreso.Text = datalistado.SelectedCells.Item(11).Value
        fmrDetalleIngreso.txtfecha.Text = datalistado.SelectedCells.Item(12).Value
        '' txtnombre_proveedor.Text = datalistado.SelectedCells.Item(3).Value

        fmrDetalleIngreso.cbtipo_documento.Text = datalistado.SelectedCells.Item(13).Value
        fmrDetalleIngreso.txtnum_documento.Text = datalistado.SelectedCells.Item(14).Value




        'fmrDetalleIngreso.txtidigreso.Text = datalistado.SelectedCells.Item(1).Value
        'fmrDetalleIngreso.txtidproveedor.Text = datalistado.SelectedCells.Item(2).Value
        '  fmrDetalleingreso.txttipo_ingreso.Text = datalistado.SelectedCells.Item(3).Value
        'fmrDetalleingreso1.txtfecha.Text = datalistado.SelectedCells.Item(4).Value
        'fmrDetalleingreso1.cbtipo_documento.Text = datalistado.SelectedCells.Item(5).Value
        'fmrDetalleingreso1.txtnum_documento.Text = datalistado.SelectedCells.Item(6).Value

        fmrDetalleIngreso.ShowDialog()
    End Sub


    Private Sub datalistado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        cargar_detalle()
    End Sub

    Private Sub btnbuscar_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar_proveedor.Click
        fmrElegirProveedor.txtflag.Text = "3"
        fmrElegirProveedor.ShowDialog()
    End Sub



    Private Sub txtidproveedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtidproveedor.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Seleccione el proveedor, este dato es obligatorio")
        End If
    End Sub



    Private Sub txtnum_documento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtnum_documento.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el número de comprobante, este dato es obligatorio")
        End If
    End Sub

    Private Sub cbtipo_documento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtipo_documento.SelectedIndexChanged

    End Sub

    Private Sub txtfecha_ValueChanged(sender As Object, e As EventArgs) Handles txtfecha.ValueChanged

    End Sub

    Private Sub txtnombre_proveedor_TextChanged(sender As Object, e As EventArgs) Handles txtnombre_proveedor.TextChanged

    End Sub

    Private Sub btbcancelar_Click(sender As Object, e As EventArgs) Handles btbcancelar.Click

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

    Private Sub txtidproveedor_TextChanged(sender As Object, e As EventArgs) Handles txtidproveedor.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtidventa_TextChanged(sender As Object, e As EventArgs) Handles txtidingreso.TextChanged

    End Sub

    Private Sub cbocampo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocampo.SelectedIndexChanged

    End Sub

    Private Sub inexistente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles inexistente.LinkClicked

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click


    End Sub
End Class