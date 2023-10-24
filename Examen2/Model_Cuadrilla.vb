Imports Npgsql
Public Class Model_Cuadrilla
    Public Shared Function AgregarCuadrilla(idCuadrilla As Integer, nombre As String) As Boolean
        Dim connString As String = Connection.ObtenerCadenaConexion()
        Using conn As NpgsqlConnection = New NpgsqlConnection(connString)
            conn.Open()

            ' Insertar datos en la tabla CUADRILLA
            Dim sqlCuadrilla As String = "INSERT INTO CUADRILLA (ID_CUADRILLA, NOMBRE) VALUES (@IdCuadrilla, @Nombre)"
            Using cmdCuadrilla As NpgsqlCommand = New NpgsqlCommand(sqlCuadrilla, conn)
                cmdCuadrilla.Parameters.AddWithValue("@IdCuadrilla", idCuadrilla)
                cmdCuadrilla.Parameters.AddWithValue("@Nombre", nombre)
                cmdCuadrilla.ExecuteNonQuery()
            End Using

            ' Empleado agregado correctamente
            Return True
        End Using

        ' Si el código llega aquí, hubo un error al agregar el empleado
        Return False
    End Function

    Public Shared Function ActualizarCuadrilla(idCuadrilla As Integer, nombre As String) As Boolean
        Dim connString As String = Connection.ObtenerCadenaConexion()
        Using conn As NpgsqlConnection = New NpgsqlConnection(connString)
            conn.Open()

            ' Actualizar datos en la tabla CUADRILLA
            Dim sqlCuadrilla As String = "UPDATE CUADRILLA SET nombre = @Nombre WHERE id_cuadrilla = @IdCuadrilla"
            Using cmdCuadrilla As NpgsqlCommand = New NpgsqlCommand(sqlCuadrilla, conn)
                cmdCuadrilla.Parameters.AddWithValue("@Nombre", nombre)
                cmdCuadrilla.Parameters.AddWithValue("@IdCuadrilla", idCuadrilla)
                cmdCuadrilla.ExecuteNonQuery()
            End Using

            ' Empleado agregado correctamente
            Return True
        End Using

        ' Si el código llega aquí, hubo un error al agregar el empleado
        Return False
    End Function

    Public Shared Function EliminarCuadrilla(idCuadrilla As Integer) As Boolean
        Dim connString As String = Connection.ObtenerCadenaConexion()
        Using conn As NpgsqlConnection = New NpgsqlConnection(connString)
            conn.Open()

            ' Eliminar datos en la tabla CUADRILLA
            Dim sqlCuadrilla As String = "DELETE FROM CUADRILLA WHERE id_cuadrilla = @IdCuadrilla"
            Using cmdCuadrilla As NpgsqlCommand = New NpgsqlCommand(sqlCuadrilla, conn)
                cmdCuadrilla.Parameters.AddWithValue("@IdCuadrilla", idCuadrilla)
                cmdCuadrilla.ExecuteNonQuery()
            End Using

            ' Empleado agregado correctamente
            Return True
        End Using

        ' Si el código llega aquí, hubo un error al agregar el empleado
        Return False
    End Function

    Public Shared Function BuscarCuadrilla(idCuadrilla As Integer) As DataTable
        Dim connString As String = Connection.ObtenerCadenaConexion()
        Dim dt As New DataTable()

        Using conn As NpgsqlConnection = New NpgsqlConnection(connString)
            conn.Open()

            Dim sql As String = "SELECT * FROM CUADRILLA WHERE id_cuadrilla = @IdCuadrilla"
            Using cmd As NpgsqlCommand = New NpgsqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@IdCuadrilla", idCuadrilla)
                Dim adapter As New NpgsqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt
    End Function
End Class
