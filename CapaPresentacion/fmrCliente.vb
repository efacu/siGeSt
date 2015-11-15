
Imports CapaDatos
Imports CapaLogica
Public Class fmrCliente
    Private dt As New DataTable
    Private estado As String = "1"
    Sub vistas1()
        Dim flag = txtflag.Text
        Select Case flag

            Case "1"
                '' habita para nuevo pais
                GroupBox1.Visible = True
                Me.Text = "Agendar Cliente"
                Label7.Text = "Agendar Cliente"
                limpiar()
                GroupBox2.Visible = False
                btnguardar.Visible = True
                btneditar.Visible = False
                Label1.Visible = False
                txtidciudad.Visible = False
                PictureBox1.Visible = True
            Case "2"
                ''habilita para la edicion y agregacion
                GroupBox1.Visible = True
                Me.Text = "Editar Cliente"
                Label7.Text = "Clientes"

                GroupBox2.Visible = False
                btneditar.Visible = True
                btnguardar.Visible = False
                PictureBox1.Visible = True
                Label1.Visible = True
                txtidciudad.Enabled = False
                txtnombre_ciudad.Enabled = False
            Case "3"
                PictureBox1.Visible = False
                '' habilita para buscar y seleccionar
                GroupBox1.Visible = False
                Label7.Text = ""
                Me.Text = "Clientes"
                GroupBox2.Visible = True
                btnnuevo.Enabled = False
                BtnModificar.Enabled = False
                btneliminar.Enabled = False
                cbeliminar.Visible = False
                mostrar()
            Case "4"
                '' habilita para buscar y seleccionar
                GroupBox1.Visible = False
                Label7.Text = ""
                Me.Text = "Clientes"
                GroupBox2.Visible = True
                btnnuevo.Enabled = False
                BtnModificar.Enabled = False
                btneliminar.Enabled = False
                cbeliminar.Visible = False
                mostrar()
            Case "10"
                '' full sYstem 
                GroupBox1.Visible = True
                Me.Text = "Agregar clientes"
                Label7.Text = "Agregar Clientes"

                GroupBox2.Visible = True

        End Select
    End Sub

    Sub vista2()
        Dim flag = txtflag2.Text
        Select Case flag

            Case "1"
                limpiar()
            Case "2"
                txtflag.Text = "3"
                vistas1()
        End Select

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        txtflag.Text = "2"
        vistas1()

    End Sub


    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        txtflag.Text = "1"
        vistas1()

    End Sub

    Private Sub btbcancelar_Click(sender As Object, e As EventArgs) Handles btbcancelar.Click
        txtflag.Text = "3"
        vistas1()
    End Sub

    Private Sub inexistente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles inexistente.LinkClicked
        txtflag.Text = "1"
        vistas1()
    End Sub

    Private Sub cbeliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("Eliminar").Visible = True
            btneliminar.Enabled = True
            BtnModificar.Enabled = False
            btnnuevo.Enabled = False
        Else
            datalistado.Columns.Item("Eliminar").Visible = False
            btneliminar.Enabled = False
            BtnModificar.Enabled = True
            btnnuevo.Enabled = True
        End If
    End Sub

    Private Sub cbestado_CheckedChanged(sender As Object, e As EventArgs) Handles cbestado.CheckedChanged
        If cbestado.CheckState = CheckState.Checked Then
            cbestado.Text = "Activo"
            estado = "1"
        Else
            cbestado.Text = "Inactivo"
            estado = "0"
        End If
    End Sub



    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnombre.Text = ""
        txtapellidos.Text = ""
        txtdireccion.Text = ""
        txttelefono.Text = ""
        txtdni.Text = ""
        txtidcliente.Text = ""
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fCliente
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
        datalistado.Columns(7).Visible = False
        ''datalistado.Columns(16).Visible = False
    End Sub

    Private Sub fmrCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vistas1()
        mostrar()
    End Sub






    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellidos.Text <> "" And txtdireccion.Text <> "" And txtdni.Text <> "" And txtidciudad.Text <> "" Then
            Try
                Dim dts As New vCliente
                Dim func As New fCliente

                dts.gnombres = txtnombre.Text
                dts.gapellidos = txtapellidos.Text
                dts.gdni = txtdni.Text
                dts.gtipo_cliente = cbotipo_cliente.Text
                dts.gidciudad = txtidciudad.Text
                dts.gdomicilio = txtdireccion.Text
                dts.gtelefono = txttelefono.Text
                dts.gemail = Textemail.Text
                dts.gweb = txtweb.Text
                'imagen

                ''  dts.gestado = txtestado.Text


                Dim ms As New IO.MemoryStream()

                If Not PictureBox1.Image Is Nothing Then
                    PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                Else
                    PictureBox1.Image = My.Resources.usuario_registrado
                    PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                End If
                dts.gimagen = ms.GetBuffer


                dts.gfecha_alta = txtfecha_alta.Text
                dts.gfecha_ultimo_movimiento = txtfecha_ultimo_movimiento.Text
                dts.gestado = estado


                If func.insertar(dts) Then
                    MessageBox.Show("cliente registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("cliente no fue registrado intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
                txtflag.Text = "3"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar los clientes seleccionados?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idcliente").Value)
                        Dim vdb As New vCliente
                        Dim func As New fCliente
                        vdb.gidcliente = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("Cliente no fue eliminado", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtidcliente.Text = datalistado.SelectedCells.Item(1).Value
        txtnombre.Text = datalistado.SelectedCells.Item(2).Value
        txtapellidos.Text = datalistado.SelectedCells.Item(3).Value
        txtdni.Text = datalistado.SelectedCells.Item(4).Value
        cbotipo_cliente.Text = datalistado.SelectedCells.Item(5).Value
        txtdireccion.Text = datalistado.SelectedCells.Item(9).Value
        txtnombre_ciudad.Text = datalistado.SelectedCells.Item(8).Value
        txtidciudad.Text = datalistado.SelectedCells.Item(6).Value
        txttelefono.Text = datalistado.SelectedCells.Item(10).Value
        Textemail.Text = datalistado.SelectedCells.Item(11).Value
        txtweb.Text = datalistado.SelectedCells.Item(12).Value
        '' PictureBox1.Image = datalistado.SelectedCells.Item(13).Value

        PictureBox1.BackgroundImage = Nothing
        Dim b() As Byte = datalistado.SelectedCells.Item(13).Value
        Dim ms As New IO.MemoryStream(b)

        PictureBox1.Image = Image.FromStream(ms)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        ''estado item 16
        Dim est As String = datalistado.SelectedCells.Item(16).Value
        If est = "1" Then
            cbestado.CheckState = CheckState.Checked

        Else
            cbestado.CheckState = CheckState.Unchecked

        End If

        txtfecha_alta.Text = datalistado.SelectedCells.Item(14).Value
        txtfecha_alta.Text = datalistado.SelectedCells.Item(15).Value

        BtnModificar.Enabled = True
        btnnuevo.Enabled = True
        cbeliminar.Visible = True
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub btneditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos del cliente?", "MOdificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellidos.Text <> "" And txtdireccion.Text <> "" And txttelefono.Text <> "" And txtdni.Text <> "" And txtidcliente.Text <> "" Then
                Try
                    Dim dts As New vCliente
                    Dim func As New fCliente

                    dts.gidcliente = txtidcliente.Text
                    dts.gnombres = txtnombre.Text
                    dts.gapellidos = txtapellidos.Text
                    dts.gdni = txtdni.Text
                    dts.gtipo_cliente = cbotipo_cliente.Text
                    dts.gidciudad = txtidciudad.Text
                    dts.gdomicilio = txtdireccion.Text
                    dts.gtelefono = txttelefono.Text
                    dts.gemail = Textemail.Text
                    dts.gweb = txtweb.Text
                    Dim ms As New IO.MemoryStream()

                    If Not PictureBox1.Image Is Nothing Then
                        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                    Else
                        PictureBox1.Image = My.Resources.usuario_registrado
                        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                    End If
                    dts.gimagen = ms.GetBuffer


                    dts.gfecha_alta = txtfecha_alta.Text
                    dts.gfecha_ultimo_movimiento = txtfecha_ultimo_movimiento.Text
                    dts.gestado = estado


                    If func.editar(dts) Then
                        MessageBox.Show("cliente modificado correctamente", "modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("cliente no fue modifcado intente de nuevo", "MOdificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If
                    txtflag.Text = "3"
                    vistas1()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falta ingresar algunos datos", "MOdificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub




    Private Sub datalistado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If txtflag.Text = "1" Then
            fmrEgreso.txtidcliente.Text = datalistado.SelectedCells.Item(1).Value
            fmrEgreso.txtnombre_cliente.Text = datalistado.SelectedCells.Item(2).Value
            Me.Close()
        End If
    End Sub

    Private Sub btncargar_Click(sender As Object, e As EventArgs) Handles btncargar.Click
        If dlg.ShowDialog() = DialogResult.OK Then
            PictureBox1.BackgroundImage = Nothing
            PictureBox1.Image = New Bitmap(dlg.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If

    End Sub

    Private Sub btnbuscar_cliente_Click(sender As Object, e As EventArgs) Handles btnbuscar_cliente.Click
        fmrElegirCiudad.txtflag.Text = "3"
        fmrElegirCiudad.ShowDialog()
    End Sub

    Private Sub txtemail_validating(sender As Object, e As EventArgs) Handles Textemail.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el numero de telefono del cliente por favor, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtnombre_validating(sender As Object, e As EventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese nombre del cliente porf avor, este dato es obligatorio")
        End If
    End Sub

    Private Sub txttelefono_validating(sender As Object, e As EventArgs) Handles txttelefono.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el telefono del cliente porf avor, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtdni_validating(sender As Object, e As EventArgs) Handles txtdni.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el DNI del cliente porf avor, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtnombre_ciudad_validating(sender As Object, e As EventArgs) Handles txtnombre_ciudad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese nombre del cliente porf avor, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtdireccion_validating(sender As Object, e As EventArgs) Handles txtdireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese la direccion del cliente porf avor, este dato es obligatorio")
        End If
    End Sub

    Private Sub txtapellidos_validating(sender As Object, e As EventArgs) Handles txtapellidos.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese apellido del cliente porf avor, este dato es obligatorio")
        End If
    End Sub


    Private Sub txtdni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdni.KeyPress
        'validamos que se ingresen solo numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txttelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class