Imports CapaDatos
Imports CapaLogica

Public Class fmrElegirCiudad

    Private dt As New DataTable
    Private Sub mostrar()
        Try
            Dim func As New fCiudad
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
        datalistado.Columns(4).Visible = False
        datalistado.Columns(6).Visible = False
    End Sub



    Private Sub txtbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub



    Private Sub datalistado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        'banderas para elejir la ciudad a un
        '''''''''provedor >>>>>1
        '''''''''usuario   >>>>2
        '''''''''cliente    >>>3
        ''''''''' editar   >>>>4


        If txtflag.Text = "1" Then
            fmrProveedor.txtidciudad.Text = datalistado.SelectedCells.Item(1).Value
            fmrProveedor.txtnombre_ciudad.Text = datalistado.SelectedCells.Item(3).Value + ", " + datalistado.SelectedCells.Item(5).Value + ". CP: " + datalistado.SelectedCells.Item(2).Value
        ElseIf txtflag.Text = "2"
            fmrUsuario.txtidciudad.Text = datalistado.SelectedCells.Item(1).Value
            fmrUsuario.txtnombre_ciudad.Text = datalistado.SelectedCells.Item(3).Value + ", " + datalistado.SelectedCells.Item(5).Value + ". CP: " + datalistado.SelectedCells.Item(2).Value
        ElseIf txtflag.Text = "3"
            fmrCliente.txtidciudad.Text = datalistado.SelectedCells.Item(1).Value
            fmrCliente.txtnombre_ciudad.Text = datalistado.SelectedCells.Item(3).Value + ", " + datalistado.SelectedCells.Item(5).Value + ". CP: " + datalistado.SelectedCells.Item(2).Value
        ElseIf txtflag.Text = "4"




        End If
        Me.Close()

    End Sub

    Private Sub fmrElegirCiudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub


End Class