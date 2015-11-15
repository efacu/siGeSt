Imports CapaDatos
Imports CapaLogica

Public Class fmrProvincia
    Sub vistas1()
        Dim flag = txtflag.Text
        Select Case flag

            Case "1"
                '' habita para nuevo pais
                GroupBox1.Visible = True
                Me.Text = "Agregar Provincia"
                Label7.Text = "Agregar Provincia"
                limpiar()
                GroupBox2.Visible = False
                btnguardar.Visible = True
                btneditar.Visible = False
                Label1.Visible = False
                txtidprovincia.Visible = False

            Case "2"
                ''habilita para la edicion y agregacion
                GroupBox1.Visible = True
                Me.Text = "Editar Provincia"
                Label7.Text = "Provincias"

                GroupBox2.Visible = False
                btneditar.Visible = True
                btnguardar.Visible = False

                Label1.Visible = True
                txtidpais.Visible = True
                txtidpais.Enabled = False
            Case "3"
                PictureBox1.Visible = False
                '' habilita para buscar y seleccionar
                GroupBox1.Visible = False
                Label7.Text = ""
                Me.Text = "Provincias"
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
                Me.Text = "Provincias"
                GroupBox2.Visible = True
                btnnuevo.Enabled = False
                BtnModificar.Enabled = False
                btneliminar.Enabled = False
                cbeliminar.Visible = False
                mostrar()
            Case "10"
                '' full sYstem 
                GroupBox1.Visible = True
                Me.Text = "Agregar Provincias"
                Label7.Text = "Agregar Provincia"

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


    Private Sub btnbuscarpais_Click(sender As Object, e As EventArgs) Handles btnbuscarpais.Click
        AgregarPais.txtflag.Text = "3"
        AgregarPais.txtflag2.Text = "1"
        AgregarPais.ShowDialog()
    End Sub

    Private dt As New DataTable

    'en el evento load del formulario ingresamos el siguiente código
    Private Sub frmpais_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        vistas1()
    End Sub



    'declaramos el procedimiento limpiar que me permitirá limpiar la caja de texto, olcultar el botón editar y visualizar el botón guardar

    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnombre.Text = ""
        txtidpais.Text = ""
        txtidprovincia.Text = ""
        txtnom_pais.Text = ""
    End Sub

    'declaramos el botón mostrar
    Private Sub mostrar()
        Try
            Dim func As New fProvincia
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
        datalistado.Columns(3).Visible = False

    End Sub


    ''validaciones 
    Private Sub txtnombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre de la provincia porfavor, este dato es obligatorio")
        End If
    End Sub
    Private Sub txtnom_pais_Validating(sender As Object, e As EventArgs) Handles txtnom_pais.Validating


        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Seleccione un Pais por favor, este dato es obligatorio")
        End If

    End Sub

    'Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
    '    limpiar()
    '    mostrar()

    'End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtidpais.Text <> "" And txtnom_pais.Text <> "" Then
            Try
                Dim dts As New vProvincia
                Dim func As New fProvincia

                dts.gnombre_provincia = txtnombre.Text
                dts.gidpais = txtidpais.Text



                If func.insertar(dts) Then
                    MessageBox.Show("provincia registrada correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("provincia no fue registrada intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub datalistado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtidprovincia.Text = datalistado.SelectedCells.Item(1).Value
        txtnombre.Text = datalistado.SelectedCells.Item(2).Value
        txtidpais.Text = datalistado.SelectedCells.Item(3).Value
        txtnom_pais.Text = datalistado.SelectedCells.Item(4).Value
        BtnModificar.Enabled = True
        btnnuevo.Enabled = True
        cbeliminar.Visible = True
    End Sub

    Private Sub datalistado_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub btneditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos de la Provincia?", "MOdificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtidpais.Text <> "" And txtidprovincia.Text Then
                Try
                    Dim dts As New vProvincia
                    Dim func As New fProvincia

                    dts.gidprovincia = txtidprovincia.Text
                    dts.gnombre_provincia = txtnombre.Text

                    dts.gidpais = txtidpais.Text


                    If func.editar(dts) Then
                        MessageBox.Show("Provincia MOdificada correctamente", "MOdificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Provincia no fue modifcada intente de nuevo", "MOdificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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



    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar las paiss seleccionadas?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idpais").Value)
                        Dim vdb As New vProvincia
                        Dim func As New fProvincia
                        vdb.gidprovincia = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("provincia no fue eliminada", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            mostrar()
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





    Private Sub datalistado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If txtflag.Text = "3" Then
            fmrCiudad.txtidprovincia.Text = datalistado.SelectedCells.Item(1).Value
            fmrCiudad.txtnom_provincia.Text = datalistado.SelectedCells.Item(2).Value
            Me.Close()
        End If
    End Sub



    Private Sub txtbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub


End Class