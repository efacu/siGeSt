Imports CapaLogica
Imports CapaDatos
Public Class fmrLogin
    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        Try
            Dim dts As New vusuario
            Dim func As New fusuario

            dts.glogin = txtlogin.Text
            dts.gpassword = txtpassword.Text

            If func.validar_usuario(dts) = True Then
                fmrInicio.Show()
                Me.Hide()
            Else
                MsgBox("Ingrese nuevamente sus datos correctos", MsgBoxStyle.Information, "Accesos denegado al sistema")
                txtpassword.Clear()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblhora.Text = TimeOfDay
    End Sub

    Private Sub fmrLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblhora.Text = TimeOfDay
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
