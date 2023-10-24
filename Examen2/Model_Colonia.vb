Imports Npgsql
Public Class Model_Colonia
    Public Shared Function AgregarColonia(idColonia As Integer, nombre As String, cod_post As Integer) As Boolean
        Dim connString As String = Connection.ObtenerCadenaConexion()
        Using conn As NpgsqlConnection = New NpgsqlConnection(connString)
            conn.Open()

            ' Insertar datos en la tabla COLONIA
            Dim sql As String = "INSERT INTO Colonia VALUES (@IdColonia, @Nombre, @Codigo_Postal)"
            Using cmd As NpgsqlCommand = New NpgsqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@IdColonia", idColonia)
                cmd.Parameters.AddWithValue("@Nombre", nombre)
                cmd.Parameters.AddWithValue("@Codigo_Postal", cod_post)
                cmd.ExecuteNonQuery()
            End Using

            ' Empleado agregado correctamente
            Return True
        End Using

        ' Si el código llega aquí, hubo un error al agregar el empleado
        Return False
    End Function

    Public Shared Function ActualizarColonia(idColonia As Integer, nombre As String, cod_post As Integer) As Boolean
        Dim connString As String = Connection.ObtenerCadenaConexion()
        Using conn As NpgsqlConnection = New NpgsqlConnection(connString)
            conn.Open()

            ' Actualizar datos en la tabla COLONIA
            Dim sql As String = "UPDATE Colonia SET nombre = @Nombre, codigo_postal = @Codigo_Postal WHERE id_colonia = @IdColonia"
            Using cmd As NpgsqlCommand = New NpgsqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@Nombre", nombre)
                cmd.Parameters.AddWithValue("@Codigo_Postal", cod_post)
                cmd.Parameters.AddWithValue("@IdColonia", idColonia)
                cmd.ExecuteNonQuery()
            End Using

            ' Empleado agregado correctamente
            Return True
        End Using

        ' Si el código llega aquí, hubo un error al agregar el empleado
        Return False
    End Function

    Public Shared Function EliminarColonia(idColonia As Integer) As Boolean
        Dim connString As String = Connection.ObtenerCadenaConexion()
        Using conn As NpgsqlConnection = New NpgsqlConnection(connString)
            conn.Open()

            ' Eliminar datos en la tabla COLONIA
            Dim sql As String = "DELETE FROM Colonia WHERE id_colonia = @IdColonia"
            Using cmd As NpgsqlCommand = New NpgsqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@IdColonia", idColonia)
                cmd.ExecuteNonQuery()
            End Using

            ' Empleado agregado correctamente
            Return True
        End Using

        ' Si el código llega aquí, hubo un error al agregar el empleado
        Return False
    End Function

    Public Shared Function BuscarColonia(idColonia As Integer) As DataTable
        Dim connString As String = Connection.ObtenerCadenaConexion()
        Dim dt As New DataTable()

        Using conn As NpgsqlConnection = New NpgsqlConnection(connString)
            conn.Open()

            Dim sql As String = "SELECT * FROM COLONIA WHERE id_colonia = @IdColonia"
            Using cmd As NpgsqlCommand = New NpgsqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@IdColonia", idColonia)
                Dim adapter As New NpgsqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt
    End Function
End Class
