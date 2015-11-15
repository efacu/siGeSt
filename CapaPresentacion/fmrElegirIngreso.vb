Imports CapaDatos
Imports CapaLogica
Public Class fmrElegirIngreso
    Private dt As New DataTable
    Private Sub frmelegiringresoingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar()

    End Sub
    Public Sub limpiar()
        'btnguardar.Visible = True
        'btneditar.Visible = False
        'txtidproveedor.Text = ""
        'txtnombre_proveedor.Text = ""
        'txtnum_documento.Text = ""
        'txtnum_documento.Text = ""
        'txtidingreso.Text = ""
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
        btnnuevo.Visible = False
        btneliminar.Visible = False

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

    Private Sub datalistado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellClick


        fmrIngreso.txtidingreso.Text = datalistado.SelectedCells.Item(1).Value
            fmrIngreso.txtidproveedor.Text = datalistado.SelectedCells.Item(2).Value
            fmrIngreso.txtnombre_proveedor.Text = datalistado.SelectedCells.Item(3).Value + ", " + datalistado.SelectedCells.Item(4).Value + " " + datalistado.SelectedCells.Item(5).Value
            fmrIngreso.cbtipo_ingreso.Text = datalistado.SelectedCells.Item(11).Value
            fmrIngreso.txtfecha.Text = datalistado.SelectedCells.Item(12).Value


            fmrIngreso.cbtipo_documento.Text = datalistado.SelectedCells.Item(13).Value
        fmrIngreso.txtnum_documento.Text = datalistado.SelectedCells.Item(14).Value
        'txtmonto.Text = datalistado.SelectedCells.Item(11).Value
        'txtobs.Text = datalistado.SelectedCells.Item(12).Value
        If txtflag.Text = "0" Then
            BtnModificar.Visible = False
            btnnuevo.Visible = False
            btneliminar.Visible = False
            cbeliminar.Visible = False
        ElseIf txtflag.Text = "1" Then
            BtnModificar.Visible = True
            btnnuevo.visible = True
            btneliminar.visible = True
            cbeliminar.Visible = True
        End If

    End Sub



    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        fmrIngreso.ShowDialog()
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        fmrIngreso.Show()
        Me.Close()

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click

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
End Class