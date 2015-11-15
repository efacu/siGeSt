
Imports System.Data.SqlClient
Imports CapaLogica
Public Class fCiudad
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_ciudad")
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


    Public Function insertar(ByVal dts As vCiudad) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_ciudad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@codigo_postal", dts.gcodigo_postal)
            cmd.Parameters.AddWithValue("@nombre_ciudad", dts.gnombre_ciudad)
            cmd.Parameters.AddWithValue("@provincias_id", dts.gidprovincias)

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



    Public Function editar(ByVal dts As vCiudad) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_ciudad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@idciudad", dts.gidciudad)
            cmd.Parameters.AddWithValue("@codigo_postal", dts.gcodigo_postal)
            cmd.Parameters.AddWithValue("@nombre_ciudad", dts.gnombre_ciudad)
            cmd.Parameters.AddWithValue("@provincias_id", dts.gidprovincias)

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
    Public Function eliminar(ByVal dts As vCiudad) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_ciudad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@idciudad", SqlDbType.NVarChar, 50).Value = dts.gidciudad
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
