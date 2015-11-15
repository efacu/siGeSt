Imports CapaLogica
Imports CapaDatos
Public Class fmrElegirProducto
    Private dt As New DataTable

    Private Sub frmproducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar()
    End Sub


    Public Sub limpiar()
        txtbuscar.Text = ""

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
        datalistado.Columns(4).Visible = False
    End Sub
    Private Sub txtbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub datalistado_CellDoubleclic(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        '' si es 
        ''''''''1 a ingreso
        ''''''''2 a egreso
        ''''''''0 no hace nada es el de inicio

        If txtflag.Text = "1" Then
            fmrDetalleIngreso.txtcodigo_barra.Text = datalistado.SelectedCells.Item(2).Value
            fmrDetalleIngreso.txtidproducto.Text = datalistado.SelectedCells.Item(1).Value
            fmrDetalleIngreso.txtnombre_producto.Text = datalistado.SelectedCells.Item(5).Value + " " + datalistado.SelectedCells.Item(6).Value

            Me.Close()
        ElseIf txtflag.Text = "2"
            fmrDetalleEgreso.txtcodigo_barra.Text = datalistado.SelectedCells.Item(2).Value
            fmrDetalleEgreso.txtidproducto.Text = datalistado.SelectedCells.Item(1).Value
            fmrDetalleEgreso.txtnombre_producto.Text = datalistado.SelectedCells.Item(5).Value + " " + datalistado.SelectedCells.Item(6).Value
            fmrDetalleEgreso.txtstock.Value = datalistado.SelectedCells.Item(7).Value

        End If
        Me.Close()

    End Sub

    Private Sub DataGridView1_DataError(ByVal sender As Object,
ByVal e As DataGridViewDataErrorEventArgs) _
Handles datalistado.DataError

        MessageBox.Show("Error happened " _
            & e.Context.ToString())

        If (e.Context = DataGridViewDataErrorContexts.Commit) _
            Then
            MessageBox.Show("Commit error")
        End If
        If (e.Context = DataGridViewDataErrorContexts _
            .CurrentCellChange) Then
            MessageBox.Show("Cell change")
        End If
        If (e.Context = DataGridViewDataErrorContexts.Parsing) _
            Then
            MessageBox.Show("parsing error")
        End If
        If (e.Context =
            DataGridViewDataErrorContexts.LeaveControl) Then
            MessageBox.Show("leave control error")
        End If

        If (TypeOf (e.Exception) Is ConstraintException) Then
            Dim view As DataGridView = CType(sender, DataGridView)
            view.Rows(e.RowIndex).ErrorText = "an error"
            view.Rows(e.RowIndex).Cells(e.ColumnIndex) _
                .ErrorText = "an error"

            e.ThrowException = False
        End If
    End Sub


End Class