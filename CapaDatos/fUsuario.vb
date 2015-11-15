Imports System.Data.SqlClient
Imports CapaLogica


Public Class fUsuario
    Inherits conexion
    Dim cmd As New SqlCommand


    Public Function validar_usuario(ByVal dts As vusuario)
        Try
            conectado()
            cmd = New SqlCommand("validar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@login", dts.glogin)
            cmd.Parameters.AddWithValue("@password", dts.gpassword)


            Dim dr As SqlDataReader

            dr = cmd.ExecuteReader

            If dr.HasRows = True Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try


    End Function
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function insertar(ByVal dts As vUsuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@nombre", dts.gnombres)
            cmd.Parameters.AddWithValue("@apellido", dts.gapellidos)
            cmd.Parameters.AddWithValue("@dni", dts.gdni)
            cmd.Parameters.AddWithValue("@fecha_nac", dts.gfecha_nac)
            cmd.Parameters.AddWithValue("@sexo", dts.gsexo)
            cmd.Parameters.AddWithValue("@domicilio", dts.gdireccion)
            cmd.Parameters.AddWithValue("@idciudad", dts.gidciudad)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@email", dts.gemail)
            cmd.Parameters.AddWithValue("@imagen", dts.gimagen)
            cmd.Parameters.AddWithValue("@login", dts.glogin)
            cmd.Parameters.AddWithValue("@password", dts.gpassword)
            cmd.Parameters.AddWithValue("@fecha_alta", dts.gfecha_alta)
            cmd.Parameters.AddWithValue("@estado", dts.gestado)
            ' TODO: agregar a la bds campo imagen
            '' cmd.Parameters.AddWithValue("@imagen", dts.gimagen)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function editar(ByVal dts As vUsuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idusuario", dts.gidusuario)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombres)
            cmd.Parameters.AddWithValue("@apellido", dts.gapellidos)
            cmd.Parameters.AddWithValue("@dni", dts.gdni)
            cmd.Parameters.AddWithValue("@fecha_nac", dts.gfecha_nac)
            cmd.Parameters.AddWithValue("@sexo", dts.gsexo)
            cmd.Parameters.AddWithValue("@domicilio", dts.gdireccion)
            cmd.Parameters.AddWithValue("@idciudad", dts.gidciudad)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@email", dts.gemail)
            cmd.Parameters.AddWithValue("@imagen", dts.gimagen)
            cmd.Parameters.AddWithValue("@login", dts.glogin)
            cmd.Parameters.AddWithValue("@password", dts.gpassword)
            cmd.Parameters.AddWithValue("@fecha_alta", dts.gfecha_alta)
            cmd.Parameters.AddWithValue("@estado", dts.gestado)
            ' TODO: agregar a la bds campo imagen
            ''falta agregar a la bds
            '' cmd.Parameters.AddWithValue("@imagen", dts.gimagen)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function eliminar(ByVal dts As vUsuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@idusuario", SqlDbType.NVarChar, 50).Value = dts.gidusuario
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function
End Class

