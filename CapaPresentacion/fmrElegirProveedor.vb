Imports CapaDatos
Imports CapaLogica
Public Class fmrElegirProveedor
    Private dt As New DataTable
    Public Sub limpiar()

        txtbuscar.Text = ""

    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fProveedor
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


    Sub pasar_datos()
        If txtflag.Text = "1" Then

            'fmrDetalleIngreso1.txtidigreso.Text = datalistado.SelectedCells.Item(1).Value
            fmrDetalleIngreso1.txtidproveedor.Text = datalistado.SelectedCells.Item(1).Value
            fmrDetalleIngreso1.txtnombre_proveedor.Text = datalistado.SelectedCells.Item(2).Value + ", " + datalistado.SelectedCells.Item(3).Value + " " + datalistado.SelectedCells.Item(4).Value
            '' fmrDetalleIngreso.txtdomicilio.Text = datalistado.SelectedCells.Item(10).Value + ", " + datalistado.SelectedCells.Item(9).Value + ". CP:" + datalistado.SelectedCells.Item(8).Value
            'fmrDetalleIngreso.txtcuit.Text = datalistado.SelectedCells.Item(5).Value
            Me.Close()

        ElseIf txtflag.Text = "3" Then

            fmrIngreso.txtidproveedor.Text = datalistado.SelectedCells.Item(1).Value
            fmrIngreso.txtnombre_proveedor.Text = datalistado.SelectedCells.Item(2).Value + ", " + datalistado.SelectedCells.Item(3).Value + " " + datalistado.SelectedCells.Item(4).Value
            'fmrIngreso.txtdomicilio.Text = datalistado.SelectedCells.Item(10).Value + ", " + datalistado.SelectedCells.Item(9).Value + ". CP:" + datalistado.SelectedCells.Item(8).Value
            'fmr.txtcuit.Text = datalistado.SelectedCells.Item(5).Value
            Me.Close()

        End If
    End Sub

    Private Sub datalistado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        pasar_datos()

    End Sub

    Private Sub fmrElegirProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick

    End Sub
End Class