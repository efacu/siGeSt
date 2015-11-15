Imports CapaLogica
Imports System.Data.SqlClient
Public Class fEgreso
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_egreso")
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


    Public Function insertar(ByVal dts As vegreso) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_egreso")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@idcliente", dts.gidcliente)
            cmd.Parameters.AddWithValue("@tipo_egreso", dts.gtipo_egreso)
            cmd.Parameters.AddWithValue("@fecha_egreso", dts.gfecha_egreso)
            cmd.Parameters.AddWithValue("@tipo_documento", dts.gtipo_documento)
            cmd.Parameters.AddWithValue("@num_documento", dts.gnum_documento)
            cmd.Parameters.AddWithValue("@monto", dts.gmonto)
            cmd.Parameters.AddWithValue("@observaciones", dts.gobservaciones)
            cmd.Parameters.AddWithValue("@estado", dts.gestado)
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



    Public Function editar(ByVal dts As vEgreso) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_egreso")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idegreso", dts.gidegreso)
            cmd.Parameters.AddWithValue("@idcliente", dts.gidcliente)
            cmd.Parameters.AddWithValue("@tipo_egreso", dts.gtipo_egreso)
            cmd.Parameters.AddWithValue("@fecha_egreso", dts.gfecha_egreso)
            cmd.Parameters.AddWithValue("@tipo_documento", dts.gtipo_documento)
            cmd.Parameters.AddWithValue("@num_documento", dts.gnum_documento)

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
    Public Function eliminar(ByVal dts As vEgreso) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_egreso")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idegreso", SqlDbType.NVarChar, 50).Value = dts.gidegreso
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try
    End Function


    Public Function insertarMontoEgreso(ByVal dts As vEgreso) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_monto_egreso")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idegreso", dts.gidegreso)
            cmd.Parameters.AddWithValue("@monto", dts.gmonto)


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
