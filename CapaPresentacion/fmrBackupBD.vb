Imports CapaDatos

Public Class fmrBackupBD


    Private Sub btnbackup_Click(sender As Object, e As EventArgs) Handles btnbackup.Click
        Try
            Dim func As New fbackup

            If func.backupbase Then
                MessageBox.Show("Backup Generado Satisfactoriamente", "BAckup BD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Backup No puede ser generado", "BAckup BD", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class