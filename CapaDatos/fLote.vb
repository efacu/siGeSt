Imports CapaLogica
Imports System.Data.SqlClient
Public Class fLote


    Inherits conexion
        Dim cmd As New SqlCommand

        Public Function mostrar() As DataTable
            Try
                conectado()
            cmd = New SqlCommand("mostrar_lote")
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


    Public Function insertar(ByVal dts As vLote) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_lote")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@fecha_vencimiento", dts.gfecha_vencimiento)
            cmd.Parameters.AddWithValue("@activo", dts.gactivo)

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



    Public Function editar(ByVal dts As vLote) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_lote")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idlote", dts.gidlote)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@fecha_vencimiento", dts.gfecha_vencimiento)
            cmd.Parameters.AddWithValue("@activo", dts.gactivo)

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
    Public Function eliminar(ByVal dts As vLote) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_lote")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idlote", SqlDbType.NVarChar, 50).Value = dts.gidlote
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
    End Class
