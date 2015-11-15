<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmrProveedor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dlg = New System.Windows.Forms.OpenFileDialog()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbestado = New System.Windows.Forms.CheckBox()
        Me.Textemail = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbotipo_proveedor = New System.Windows.Forms.ComboBox()
        Me.btnlimpiar = New System.Windows.Forms.PictureBox()
        Me.btncargar = New System.Windows.Forms.PictureBox()
        Me.txtfecha_ultimo_movimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtfecha_alta = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnbuscar_ciudad = New System.Windows.Forms.Button()
        Me.txtnombre_ciudad = New System.Windows.Forms.TextBox()
        Me.txtidciudad = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtweb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcuit_cuil = New System.Windows.Forms.TextBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btbcancelar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtapellidos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtrazon_social = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidproveedor = New System.Windows.Forms.TextBox()
        Me.txtflag2 = New System.Windows.Forms.TextBox()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dlg
        '
        Me.dlg.FileName = "OpenFileDialog1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label7.Location = New System.Drawing.Point(133, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(269, 29)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Registro Proveedores"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cbestado)
        Me.GroupBox1.Controls.Add(Me.Textemail)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cbotipo_proveedor)
        Me.GroupBox1.Controls.Add(Me.btnlimpiar)
        Me.GroupBox1.Controls.Add(Me.btncargar)
        Me.GroupBox1.Controls.Add(Me.txtfecha_ultimo_movimiento)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtfecha_alta)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btnbuscar_ciudad)
        Me.GroupBox1.Controls.Add(Me.txtnombre_ciudad)
        Me.GroupBox1.Controls.Add(Me.txtidciudad)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtweb)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtcuit_cuil)
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.btbcancelar)
        Me.GroupBox1.Controls.Add(Me.btneditar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtdireccion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txttelefono)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtapellidos)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtrazon_social)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidproveedor)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 500)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(26, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 13)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Razon Social:"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(145, 77)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(221, 20)
        Me.txtnombre.TabIndex = 36
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 437)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Estado:"
        '
        'cbestado
        '
        Me.cbestado.AutoSize = True
        Me.cbestado.Checked = True
        Me.cbestado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbestado.Location = New System.Drawing.Point(145, 436)
        Me.cbestado.Name = "cbestado"
        Me.cbestado.Size = New System.Drawing.Size(62, 17)
        Me.cbestado.TabIndex = 34
        Me.cbestado.Text = "Activo"
        Me.cbestado.UseVisualStyleBackColor = True
        '
        'Textemail
        '
        Me.Textemail.Location = New System.Drawing.Point(145, 292)
        Me.Textemail.Name = "Textemail"
        Me.Textemail.Size = New System.Drawing.Size(221, 20)
        Me.Textemail.TabIndex = 33
        Me.Textemail.Text = "- -"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(26, 158)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Tipo de Proveedor:"
        '
        'cbotipo_proveedor
        '
        Me.cbotipo_proveedor.FormattingEnabled = True
        Me.cbotipo_proveedor.Items.AddRange(New Object() {"Actual", "Potencial"})
        Me.cbotipo_proveedor.Location = New System.Drawing.Point(145, 155)
        Me.cbotipo_proveedor.Name = "cbotipo_proveedor"
        Me.cbotipo_proveedor.Size = New System.Drawing.Size(221, 21)
        Me.cbotipo_proveedor.TabIndex = 4
        Me.cbotipo_proveedor.Text = "Actual"
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlimpiar.Image = Global.CapaPresentacion.My.Resources.Resources.eliminar_img_prod
        Me.btnlimpiar.Location = New System.Drawing.Point(305, 348)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(61, 37)
        Me.btnlimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnlimpiar.TabIndex = 30
        Me.btnlimpiar.TabStop = False
        '
        'btncargar
        '
        Me.btncargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncargar.Image = Global.CapaPresentacion.My.Resources.Resources.agregar_img_prod
        Me.btncargar.Location = New System.Drawing.Point(199, 344)
        Me.btncargar.Name = "btncargar"
        Me.btncargar.Size = New System.Drawing.Size(64, 41)
        Me.btncargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btncargar.TabIndex = 29
        Me.btncargar.TabStop = False
        '
        'txtfecha_ultimo_movimiento
        '
        Me.txtfecha_ultimo_movimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha_ultimo_movimiento.Location = New System.Drawing.Point(268, 400)
        Me.txtfecha_ultimo_movimiento.Name = "txtfecha_ultimo_movimiento"
        Me.txtfecha_ultimo_movimiento.Size = New System.Drawing.Size(102, 20)
        Me.txtfecha_ultimo_movimiento.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(188, 405)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Ultimo Mov:"
        '
        'txtfecha_alta
        '
        Me.txtfecha_alta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha_alta.Location = New System.Drawing.Point(61, 400)
        Me.txtfecha_alta.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.txtfecha_alta.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txtfecha_alta.Name = "txtfecha_alta"
        Me.txtfecha_alta.Size = New System.Drawing.Size(103, 20)
        Me.txtfecha_alta.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 406)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Alta"
        '
        'btnbuscar_ciudad
        '
        Me.btnbuscar_ciudad.BackColor = System.Drawing.Color.DarkCyan
        Me.btnbuscar_ciudad.ForeColor = System.Drawing.Color.White
        Me.btnbuscar_ciudad.Location = New System.Drawing.Point(343, 180)
        Me.btnbuscar_ciudad.Name = "btnbuscar_ciudad"
        Me.btnbuscar_ciudad.Size = New System.Drawing.Size(40, 25)
        Me.btnbuscar_ciudad.TabIndex = 5
        Me.btnbuscar_ciudad.Text = "..."
        Me.btnbuscar_ciudad.UseVisualStyleBackColor = False
        '
        'txtnombre_ciudad
        '
        Me.txtnombre_ciudad.Enabled = False
        Me.txtnombre_ciudad.Location = New System.Drawing.Point(199, 182)
        Me.txtnombre_ciudad.Name = "txtnombre_ciudad"
        Me.txtnombre_ciudad.Size = New System.Drawing.Size(138, 20)
        Me.txtnombre_ciudad.TabIndex = 21
        '
        'txtidciudad
        '
        Me.txtidciudad.Enabled = False
        Me.txtidciudad.Location = New System.Drawing.Point(145, 182)
        Me.txtidciudad.Name = "txtidciudad"
        Me.txtidciudad.Size = New System.Drawing.Size(48, 20)
        Me.txtidciudad.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 321)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Web:"
        '
        'txtweb
        '
        Me.txtweb.Location = New System.Drawing.Point(145, 318)
        Me.txtweb.MaxLength = 100
        Me.txtweb.Name = "txtweb"
        Me.txtweb.Size = New System.Drawing.Size(221, 20)
        Me.txtweb.TabIndex = 9
        Me.txtweb.Text = "- -"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 295)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Email:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Ciudad:"
        '
        'txtcuit_cuil
        '
        Me.txtcuit_cuil.Location = New System.Drawing.Point(145, 129)
        Me.txtcuit_cuil.MaxLength = 11
        Me.txtcuit_cuil.Name = "txtcuit_cuil"
        Me.txtcuit_cuil.Size = New System.Drawing.Size(221, 20)
        Me.txtcuit_cuil.TabIndex = 3
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Location = New System.Drawing.Point(159, 466)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(97, 25)
        Me.btnguardar.TabIndex = 7
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btbcancelar
        '
        Me.btbcancelar.BackColor = System.Drawing.Color.DarkCyan
        Me.btbcancelar.ForeColor = System.Drawing.Color.White
        Me.btbcancelar.Location = New System.Drawing.Point(262, 466)
        Me.btbcancelar.Name = "btbcancelar"
        Me.btbcancelar.Size = New System.Drawing.Size(104, 25)
        Me.btbcancelar.TabIndex = 14
        Me.btbcancelar.Text = "Cancelar"
        Me.btbcancelar.UseVisualStyleBackColor = False
        '
        'btneditar
        '
        Me.btneditar.BackColor = System.Drawing.Color.DarkCyan
        Me.btneditar.ForeColor = System.Drawing.Color.White
        Me.btneditar.Location = New System.Drawing.Point(159, 466)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(97, 25)
        Me.btneditar.TabIndex = 13
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Dirección:"
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(145, 208)
        Me.txtdireccion.MaxLength = 25
        Me.txtdireccion.Multiline = True
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdireccion.Size = New System.Drawing.Size(221, 52)
        Me.txtdireccion.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Telefóno:"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(145, 266)
        Me.txttelefono.MaxLength = 20
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(221, 20)
        Me.txttelefono.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CUIT:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Apellidos:"
        '
        'txtapellidos
        '
        Me.txtapellidos.Location = New System.Drawing.Point(145, 103)
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.Size = New System.Drawing.Size(221, 20)
        Me.txtapellidos.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombres:"
        '
        'txtrazon_social
        '
        Me.txtrazon_social.Location = New System.Drawing.Point(145, 51)
        Me.txtrazon_social.Name = "txtrazon_social"
        Me.txtrazon_social.Size = New System.Drawing.Size(221, 20)
        Me.txtrazon_social.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "idproveedor:"
        '
        'txtidproveedor
        '
        Me.txtidproveedor.Enabled = False
        Me.txtidproveedor.Location = New System.Drawing.Point(145, 26)
        Me.txtidproveedor.Name = "txtidproveedor"
        Me.txtidproveedor.Size = New System.Drawing.Size(221, 20)
        Me.txtidproveedor.TabIndex = 0
        '
        'txtflag2
        '
        Me.txtflag2.Location = New System.Drawing.Point(364, 25)
        Me.txtflag2.Name = "txtflag2"
        Me.txtflag2.Size = New System.Drawing.Size(54, 20)
        Me.txtflag2.TabIndex = 28
        Me.txtflag2.Text = "0"
        Me.txtflag2.Visible = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.DarkCyan
        Me.BtnModificar.ForeColor = System.Drawing.Color.White
        Me.BtnModificar.Location = New System.Drawing.Point(178, 526)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(104, 25)
        Me.BtnModificar.TabIndex = 17
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(178, 25)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(268, 20)
        Me.txtbuscar.TabIndex = 2
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.DarkCyan
        Me.btnnuevo.ForeColor = System.Drawing.Color.White
        Me.btnnuevo.Location = New System.Drawing.Point(342, 526)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(104, 25)
        Me.btnnuevo.TabIndex = 12
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(6, 78)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(442, 414)
        Me.datalistado.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnModificar)
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
        Me.GroupBox2.Controls.Add(Me.btneliminar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.cbocampo)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Controls.Add(Me.btnnuevo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.CadetBlue
        Me.GroupBox2.Location = New System.Drawing.Point(424, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(467, 560)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de contactos"
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Location = New System.Drawing.Point(13, 60)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(70, 17)
        Me.cbeliminar.TabIndex = 16
        Me.cbeliminar.Text = "Eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.DarkCyan
        Me.btneliminar.ForeColor = System.Drawing.Color.White
        Me.btneliminar.Location = New System.Drawing.Point(13, 526)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(104, 25)
        Me.btneliminar.TabIndex = 15
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(192, 213)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(93, 13)
        Me.inexistente.TabIndex = 3
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos inexistes"
        '
        'cbocampo
        '
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"nombre", "apellidos", "dni", "telefono"})
        Me.cbocampo.Location = New System.Drawing.Point(13, 25)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(152, 21)
        Me.cbocampo.TabIndex = 1
        Me.cbocampo.Text = "nombre"
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(295, 25)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(54, 20)
        Me.txtflag.TabIndex = 23
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.CapaPresentacion.My.Resources.Resources.usuario
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'fmrProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 599)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtflag2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtflag)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fmrProveedor"
        Me.Text = "fmrProveedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dlg As OpenFileDialog
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbestado As CheckBox
    Friend WithEvents Textemail As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cbotipo_proveedor As ComboBox
    Friend WithEvents btnlimpiar As PictureBox
    Friend WithEvents btncargar As PictureBox
    Friend WithEvents txtfecha_ultimo_movimiento As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents txtfecha_alta As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents btnbuscar_ciudad As Button
    Friend WithEvents txtnombre_ciudad As TextBox
    Friend WithEvents txtidciudad As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtweb As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtcuit_cuil As TextBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents btbcancelar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtapellidos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtrazon_social As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtidproveedor As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtflag2 As TextBox
    Friend WithEvents BtnModificar As Button
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents btnnuevo As Button
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbeliminar As CheckBox
    Friend WithEvents btneliminar As Button
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents cbocampo As ComboBox
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents txtflag As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtnombre As TextBox
End Class
