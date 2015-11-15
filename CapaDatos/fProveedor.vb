Imports System.Data.SqlClient
Imports CapaLogica
Public Class fproveedor



    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_proveedor")
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


    Public Function insertar(ByVal dts As vproveedor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_proveedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@razon_social", dts.grazon_social)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellido", dts.gapellido)
            cmd.Parameters.AddWithValue("@cuit_cuil", dts.gcuit_cuil)
            cmd.Parameters.AddWithValue("@tipo_proveedor", dts.gtipo_proveedor)
            cmd.Parameters.AddWithValue("@domicilio", dts.gdomicilio)
            cmd.Parameters.AddWithValue("@idciudad", dts.gidciudad)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@email", dts.gemail)
            cmd.Parameters.AddWithValue("@web", dts.gweb)
            cmd.Parameters.AddWithValue("@imagen", dts.gimagen)
            cmd.Parameters.AddWithValue("@fecha_alta", dts.gfecha_alta)
            cmd.Parameters.AddWithValue("@fecha_ultimo_movimiento", dts.gfecha_ultimo_movimiento)
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



    Public Function editar(ByVal dts As vproveedor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_proveedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idproveedor", dts.gidproveedor)
            cmd.Parameters.AddWithValue("@razon_social", dts.grazon_social)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellido", dts.gapellido)
            cmd.Parameters.AddWithValue("@cuit_cuil", dts.gcuit_cuil)
            cmd.Parameters.AddWithValue("@tipo_proveedor", dts.gtipo_proveedor)
            cmd.Parameters.AddWithValue("@domicilio", dts.gdomicilio)
            cmd.Parameters.AddWithValue("@idciudad", dts.gidciudad)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@email", dts.gemail)
            cmd.Parameters.AddWithValue("@web", dts.gweb)
            cmd.Parameters.AddWithValue("@imagen", dts.gimagen)
            cmd.Parameters.AddWithValue("@fecha_alta", dts.gfecha_alta)
            cmd.Parameters.AddWithValue("@fecha_ultimo_movimiento", dts.gfecha_ultimo_movimiento)
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
    Public Function eliminar(ByVal dts As vproveedor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_proveedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idproveedor", SqlDbType.NVarChar, 50).Value = dts.gidproveedor
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
