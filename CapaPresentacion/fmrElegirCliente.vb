Imports CapaLogica
Imports CapaDatos
Public Class fmrElegirCliente
    Private dt As New DataTable
    Public Sub limpiar()

        txtbuscar.Text = ""

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

    Private Sub fmrElegirCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub


    Private Sub datalistado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If txtflag.Text = "3" Then
            fmrEgreso.txtidcliente.Text = datalistado.SelectedCells.Item(1).Value
            fmrEgreso.txtnombre_cliente.Text = datalistado.SelectedCells.Item(2).Value + " " + datalistado.SelectedCells.Item(3).Value
            Me.Close()
        End If
    End Sub


End Class