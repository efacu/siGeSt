<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmrBackupBD
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
        Me.btnbackup = New System.Windows.Forms.Button()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnbackup
        '
        Me.btnbackup.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnbackup.ForeColor = System.Drawing.Color.White
        Me.btnbackup.Location = New System.Drawing.Point(32, 57)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.Size = New System.Drawing.Size(139, 41)
        Me.btnbackup.TabIndex = 1
        Me.btnbackup.Text = "Backup Base"
        Me.btnbackup.UseVisualStyleBackColor = False
        '
        'btnRestaurar
        '
        Me.btnRestaurar.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnRestaurar.ForeColor = System.Drawing.Color.White
        Me.btnRestaurar.Location = New System.Drawing.Point(238, 57)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(139, 41)
        Me.btnRestaurar.TabIndex = 2
        Me.btnRestaurar.Text = "Restaurar Base"
        Me.btnRestaurar.UseVisualStyleBackColor = False
        '
        'fmrBackupBD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 162)
        Me.Controls.Add(Me.btnRestaurar)
        Me.Controls.Add(Me.btnbackup)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fmrBackupBD"
        Me.Text = "Backup de la Base de Datos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnbackup As Button
    Friend WithEvents btnRestaurar As Button
End Class
