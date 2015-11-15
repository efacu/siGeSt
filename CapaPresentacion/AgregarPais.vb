Imports CapaDatos
Imports CapaLogica


Public Class AgregarPais
    Private Sub AgregarPais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vistas1()


    End Sub


    Sub vistas1()
        Dim flag = txtflag.Text
        Select Case flag

            Case "1"
                '' habita para nuevo pais
                GroupBox1.Visible = True
                Me.Text = "Agregar Paises"
                Label7.Text = "Agregar Pais"
                limpiar()
                GroupBox2.Visible = False
                btnguardar.Visible = True
                btneditar.Visible = False
                Label1.Visible = False
                txtidpais.Visible = False
            Case "2"
                ''habilita para la edicion y agregacion
                GroupBox1.Visible = True
                Me.Text = "Editar Pais"
                Label7.Text = "Editar Pais"

                GroupBox2.Visible = False
                btneditar.Visible = True
                btnguardar.Visible = False

                Label1.Visible = True
                txtidpais.Visible = True
                txtidpais.Enabled = False
            Case "3"
                '' habilita para buscar y seleccionar
                GroupBox1.Visible = False
                Label7.Text = ""
                Me.Text = "Paises"
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
                Me.Text = "Paises"
                GroupBox2.Visible = True
                btnnuevo.Enabled = False
                BtnModificar.Enabled = False
                btneliminar.Enabled = False
                cbeliminar.Visible = False
                mostrar()
            Case "10"
                '' full sYstem 
                GroupBox1.Visible = True
                Me.Text = "Agregar Paises"
                Label7.Text = "Agregar Pais"

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








    Private dt As New DataTable




    'declaramos el procedimiento limpiar que me permitirá limpiar la caja de texto, olcultar el botón editar y visualizar el botón guardar

    Public Sub limpiar()
        'btnguardar.Visible = True
        'btneditar.Visible = False
        txtnombre.Text = ""
        txtidpais.Text = ""

    End Sub

    'declaramos el botón mostrar
    Private Sub mostrar()
        Try
            Dim func As New fpais
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
    End Sub



    Private Sub txtnombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el nombre de la pais porfavor, este datos es obligatorio")
        End If
    End Sub


    '' CAMBIO FLAG 

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" Then
            Try
                Dim dts As New vpais
                Dim func As New fpais

                dts.gnombre_pais = txtnombre.Text



                If func.insertar(dts) Then
                    MessageBox.Show("pais registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()

                Else
                    MessageBox.Show("pais no fue registrado intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtidpais.Text = datalistado.SelectedCells.Item(1).Value
        txtnombre.Text = datalistado.SelectedCells.Item(2).Value
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

        result = MessageBox.Show("Realmente desea editar los datos de la Pais?", "MOdificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtidpais.Text <> "" Then
                Try
                    Dim dts As New vPais
                    Dim func As New fPais

                    dts.gidpais = txtidpais.Text
                    dts.gnombre_pais = txtnombre.Text


                    If func.editar(dts) Then
                        MessageBox.Show("Pais MOdificada correctamente", "MOdificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()

                        limpiar()
                    Else
                        MessageBox.Show("Pais no fue modifcada intente de nuevo", "MOdificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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


    'cambio comportamiento botones
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

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar las paiss seleccionadas?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("idpais").Value)
                        Dim vdb As New vpais
                        Dim func As New fpais
                        vdb.gidpais = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("pais no fue eliminada", "Eliminando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            fmrProvincia.txtflag.Text = "1"
            fmrProvincia.txtidpais.Text = datalistado.SelectedCells.Item(1).Value
            fmrProvincia.txtnom_pais.Text = datalistado.SelectedCells.Item(2).Value
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar.TextChanged
        buscar()
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


End Class