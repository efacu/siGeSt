Public Class fmrInicio

    Private m_ChildFormNumber As Integer

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        fmrCategoria.MdiParent = Me
        fmrCategoria.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        fmrProducto.MdiParent = Me
        fmrProducto.Show()
    End Sub

    Private Sub RegistroDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeVentasToolStripMenuItem.Click
        fmrEgreso.MdiParent = Me
        fmrEgreso.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        fmrCliente.txtflag.Text = "3"
        fmrCliente.txtflag2.Text = "1"
        fmrCliente.MdiParent = Me
        fmrCliente.Show()


    End Sub

    Private Sub ReporteDeProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeProductoToolStripMenuItem.Click
        'fmrReporteProductos.MdiParent = Me
        'fmrReporteProductos.Show()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        fmrBackupBD.MdiParent = Me
        fmrBackupBD.Show()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub

    Private Sub MarcasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        fmrMarca.MdiParent = Me
        fmrMarca.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem1.Click
        fmrUsuario.MdiParent = Me
        fmrUsuario.Show()
    End Sub

    Private Sub PaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaisToolStripMenuItem.Click
        AgregarPais.txtflag.Text = "3"
        AgregarPais.txtflag2.Text = "1"
        AgregarPais.MdiParent = Me
        AgregarPais.Show()
    End Sub

    Private Sub RegistroDeProvinciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeProvinciaToolStripMenuItem.Click
        fmrProvincia.txtflag.Text = "3"
        fmrProvincia.txtflag2.Text = "1"
        fmrProvincia.MdiParent = Me
        fmrProvincia.Show()
    End Sub

    Private Sub RegistroDeCiudadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeCiudadToolStripMenuItem.Click
        fmrCiudad.txtflag.Text = "3"
        fmrCiudad.txtflag2.Text = "1"
        fmrCiudad.MdiParent = Me
        fmrCiudad.Show()
    End Sub



    Private Sub BarraDeEstadoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub BarraDeHerramientasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub









    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub RegistroIngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroIngresosToolStripMenuItem.Click
        fmrIngreso.txtflag.Text = "1"
        fmrIngreso.MdiParent = Me
        fmrIngreso.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        fmrProveedor.txtflag.Text = "1"
        fmrProveedor.MdiParent = Me
        fmrProveedor.Show()

    End Sub

    Private Sub RegistroDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeProductosToolStripMenuItem.Click

        fmrProducto.MdiParent = Me
        fmrProducto.Show()
    End Sub

    Private Sub RegistroDeCategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeCategoriasToolStripMenuItem.Click
        fmrCategoria.MdiParent = Me
        fmrCategoria.Show()
    End Sub

    Private Sub RegistroDeMarcasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeMarcasToolStripMenuItem.Click
        fmrMarca.MdiParent = Me
        fmrMarca.Show()
    End Sub

    Private Sub ListaDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeProductosToolStripMenuItem.Click
        fmrElegirProducto.txtflag.Text = "0"
        fmrElegirProducto.MdiParent = Me
        fmrElegirProducto.Show()
    End Sub
End Class