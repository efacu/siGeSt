<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReporteComprobante
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dbSGSv3DataSet = New CapaPresentacion.dbSGSv3DataSet()
        Me.generar_comprovante_ingresoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.generar_comprovante_ingresoTableAdapter = New CapaPresentacion.dbSGSv3DataSetTableAdapters.generar_comprovante_ingresoTableAdapter()
        CType(Me.dbSGSv3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.generar_comprovante_ingresoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtidventa
        '
        Me.txtidventa.Location = New System.Drawing.Point(272, 15)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.Size = New System.Drawing.Size(100, 20)
        Me.txtidventa.TabIndex = 2
        Me.txtidventa.Text = "1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(100, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.generar_comprovante_ingresoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.rptProductos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 65)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(503, 288)
        Me.ReportViewer1.TabIndex = 5
        '
        'dbSGSv3DataSet
        '
        Me.dbSGSv3DataSet.DataSetName = "dbSGSv3DataSet"
        Me.dbSGSv3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'generar_comprovante_ingresoBindingSource
        '
        Me.generar_comprovante_ingresoBindingSource.DataMember = "generar_comprovante_ingreso"
        Me.generar_comprovante_ingresoBindingSource.DataSource = Me.dbSGSv3DataSet
        '
        'generar_comprovante_ingresoTableAdapter
        '
        Me.generar_comprovante_ingresoTableAdapter.ClearBeforeFill = True
        '
        'frmReporteComprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(662, 398)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtidventa)
        Me.Name = "frmReporteComprobante"
        Me.Text = "frmReporteComprobante"
        CType(Me.dbSGSv3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.generar_comprovante_ingresoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtidventa As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents generar_comprovante_ingresoBindingSource As BindingSource
    Friend WithEvents dbSGSv3DataSet As dbSGSv3DataSet
    Friend WithEvents generar_comprovante_ingresoTableAdapter As dbSGSv3DataSetTableAdapters.generar_comprovante_ingresoTableAdapter
End Class
