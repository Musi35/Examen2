Imports Npgsql
Public Class Model_Actividades
    Public Shared Function AgregarActividad(idActividad As Integer, idCuadrilla As Integer, foto As String, idColonia As Integer, detalle As String) As Boolean
        Dim connString As String = Connection.ObtenerCadenaConexion()
        Using conn As NpgsqlConnection = New NpgsqlConnection(connString)
            conn.Open()

            ' Insertar datos en la tabla ACTIVIDAD
            Dim sql As String = "INSERT INTO ACTIVIDAD VALUES (@IdActividad, @IdCuadrilla, @Foto, @IdColonia, @Detalle)"
            Using cmd As New NpgsqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@IdActividad", idActividad)
                cmd.Parameters.AddWithValue("@IdCuadrilla", idCuadrilla)
                cmd.Parameters.AddWithValue("@Foto", foto)
                cmd.Parameters.AddWithValue("@IdColonia", idColonia)
                cmd.Parameters.AddWithValue("@Detalle", detalle)
                cmd.ExecuteNonQuery()
            End Using

            ' Empleado agregado correctamente
            Return True
        End Using

        ' Si el código llega aquí, hubo un error al agregar el empleado
        Return False
    End Function

    Public Shared Function ActualizarActividad(idActividad As Integer, idCuadrilla As Integer, foto As String, idColonia As Integer, detalle As String) As Boolean
        Dim connString As String = Connection.ObtenerCadenaConexion()
        Using conn As NpgsqlConnection = New NpgsqlConnection(connString)
            conn.Open()

            ' Actualizar datos en la tabla ACTIVIDAD
            Dim sql As String = "UPDATE ACTIVIDAD SET id_cuadrilla = @IdCuadrilla, foto = @Foto, id_colonia = @IdColonia, detalle = @Detalle WHERE id_actividad = @IdActividad"
            Using cmd As NpgsqlCommand = New NpgsqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@IdCuadrilla", idCuadrilla)
                cmd.Parameters.AddWithValue("@Foto", foto)
                cmd.Parameters.AddWithValue("@IdColonia", idColonia)
                cmd.Parameters.AddWithValue("@Detalle", detalle)
                cmd.Parameters.AddWithValue("@IdActividad", idActividad)
                cmd.ExecuteNonQuery()
            End Using

            ' Empleado agregado correctamente
            Return True
        End Using

        ' Si el código llega aquí, hubo un error al agregar el empleado
        Return False
    End Function

    Public Shared Function EliminarActividad(idActividad As Integer) As Boolean
        Dim connString As String = Connection.ObtenerCadenaConexion()
        Using conn As NpgsqlConnection = New NpgsqlConnection(connString)
            conn.Open()

            ' Eliminar datos en la tabla Actividad
            Dim sql As String = "DELETE FROM ACTIVIDAD WHERE id_actividad = @IdActividad"
            Using cmd As NpgsqlCommand = New NpgsqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@IdActividad", idActividad)
                cmd.ExecuteNonQuery()
            End Using

            ' Empleado agregado correctamente
            Return True
        End Using

        ' Si el código llega aquí, hubo un error al agregar el empleado
        Return False
    End Function

    Public Shared Function BuscarActividad(idActividad As Integer) As DataTable
        Dim connString As String = Connection.ObtenerCadenaConexion()
        Dim dt As New DataTable()

        Using conn As NpgsqlConnection = New NpgsqlConnection(connString)
            conn.Open()

            Dim sql As String = "SELECT * FROM Actividad WHERE id_actividad = @IdActividad"
            Using cmd As NpgsqlCommand = New NpgsqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@IdActividad", idActividad)
                Dim adapter As New NpgsqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt
    End Function
End Class
