Imports CapaLogica
Imports System.Data.SqlClient

Public Class fDetalle_Lote




    Inherits conexion
        Dim cmd As New SqlCommand

        Public Function mostrar() As DataTable
            Try
                conectado()
            cmd = New SqlCommand("mostrar_detalle_lote")
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


    Public Function insertar(ByVal dts As vDetalle_Lote) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_detalle_lote")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@idlote", dts.gidlote)
            cmd.Parameters.AddWithValue("@idproducto", dts.gidproducto)
            cmd.Parameters.AddWithValue("@deposito_stockactual", dts.gdeposito_stockactual)
            cmd.Parameters.AddWithValue("@observacion", dts.gobservacion)



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



    Public Function editar(ByVal dts As vDetalle_Lote) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_detalle_lote")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@iddetalle_lote", dts.giddetalle_lote)
            cmd.Parameters.AddWithValue("@idproducto", dts.gidproducto)
            cmd.Parameters.AddWithValue("@idlote", dts.gidlote)
            cmd.Parameters.AddWithValue("@deposito_stockactual", dts.gdeposito_stockactual)
            cmd.Parameters.AddWithValue("@observacion", dts.gobservacion)


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
    Public Function eliminar(ByVal dts As vDetalle_Lote) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_detalle_lote")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@iddetalle_lote", SqlDbType.NVarChar, 50).Value = dts.giddetalle_lote
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


    Public Function aumentar_stock(ByVal dts As vDetalle_Lote) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("aumentar_stock")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idproducto", dts.gidproducto)
            cmd.Parameters.AddWithValue("@observacion", dts.gobservacion)
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
