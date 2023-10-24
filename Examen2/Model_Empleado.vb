Imports Npgsql
Public Class Model_Empleado
    Public Shared Function AgregarEmpleado(idEmpleado As Integer, nombre As String, paterno As String, materno As String, telefono As String, puesto As String, idCuadrilla As Integer, contra As String) As Boolean
        Dim connString As String = Connection.ObtenerCadenaConexion()
        Using conn As NpgsqlConnection = New NpgsqlConnection(connString)
            conn.Open()

            ' Insertar datos en la tabla EMPLEADO
            Dim sqlEmpleado As String = "INSERT INTO EMPLEADO VALUES (@IdEmpleado, @Nombre, @Paterno, @Materno, @Telefono, @Puesto, @IdCuadrilla)"
            Using cmdEmpleado As NpgsqlCommand = New NpgsqlCommand(sqlEmpleado, conn)
                cmdEmpleado.Parameters.AddWithValue("@IdEmpleado", idEmpleado)
                cmdEmpleado.Parameters.AddWithValue("@Nombre", nombre)
                cmdEmpleado.Parameters.AddWithValue("@Paterno", paterno)
                cmdEmpleado.Parameters.AddWithValue("@Materno", materno)
                cmdEmpleado.Parameters.AddWithValue("@Telefono", telefono)
                cmdEmpleado.Parameters.AddWithValue("@Puesto", puesto)
                cmdEmpleado.Parameters.AddWithValue("@IdCuadrilla", idCuadrilla)
                cmdEmpleado.ExecuteNonQuery()
            End Using

            ' Insertar datos en la tabla EMPLEADO_CUADRILLA
            Dim sqlEmpleadoCuadrilla As String = "INSERT INTO EMPLEADO_CUADRILLA VALUES (@IdEmpleado, @IdCuadrilla)"
            Using cmdEmpleadoCuadrilla As NpgsqlCommand = New NpgsqlCommand(sqlEmpleadoCuadrilla, conn)
                cmdEmpleadoCuadrilla.Parameters.AddWithValue("@IdEmpleado", idEmpleado)
                cmdEmpleadoCuadrilla.Parameters.AddWithValue("@IdCuadrilla", idCuadrilla)
                cmdEmpleadoCuadrilla.ExecuteNonQuery()
            End Using

            ' Insertar datos en la tabla USUARIO
            Dim sqlUsuario As String = "INSERT INTO USUARIO VALUES (@IdEmpleado, @Password)"
            Using cmdUsuario As NpgsqlCommand = New NpgsqlCommand(sqlUsuario, conn)
                cmdUsuario.Parameters.AddWithValue("@IdEmpleado", idEmpleado)
                cmdUsuario.Parameters.AddWithValue("@Password", contra)
                cmdUsuario.ExecuteNonQuery()
            End Using

            ' Empleado registrado correctamente
            Return True
        End Using

        ' Si el código llega aquí, hubo un error al registrar el empleado
        Return False
    End Function

    Public Shared Function ActualizarEmpleado(idEmpleado As Integer, nombre As String, paterno As String, materno As String, telefono As String, puesto As String, idCuadrilla As Integer, contra As String) As Boolean
        Dim connString As String = Connection.ObtenerCadenaConexion()
        Using conn As NpgsqlConnection = New NpgsqlConnection(connString)
            conn.Open()

            ' Actualizar datos en la tabla EMPLEADO_CUADRILLA
            Dim sqlEmpleadoCuadrilla As String = "UPDATE EMPLEADO_CUADRILLA SET id_cuadrilla = @IdCuadrilla WHERE id_empleado = @IdEmpleado"
            Using cmdEmpleadoCuadrilla As NpgsqlCommand = New NpgsqlCommand(sqlEmpleadoCuadrilla, conn)
                cmdEmpleadoCuadrilla.Parameters.AddWithValue("@IdCuadrilla", idCuadrilla)
                cmdEmpleadoCuadrilla.Parameters.AddWithValue("@IdEmpleado", idEmpleado)
                cmdEmpleadoCuadrilla.ExecuteNonQuery()
            End Using

            ' Actualizar datos en la tabla USUARIO
            Dim sqlUsuario As String = "UPDATE USUARIO SET password = @Password WHERE id_empleado = @IdEmpleado"
            Using cmdUsuario As NpgsqlCommand = New NpgsqlCommand(sqlUsuario, conn)
                cmdUsuario.Parameters.AddWithValue("@Password", contra)
                cmdUsuario.Parameters.AddWithValue("@IdEmpleado", idEmpleado)
                cmdUsuario.ExecuteNonQuery()
            End Using

            ' Actualizar datos en la tabla EMPLEADO
            Dim sqlEmpleado As String = "UPDATE EMPLEADO SET nombre = @Nombre, paterno = @Paterno, Materno = @Materno, telefono = @Telefono, puesto = @Puesto, id_cuadrilla = @IdCuadrilla WHERE id_empleado = @IdEmpleado"
            Using cmdEmpleado As NpgsqlCommand = New NpgsqlCommand(sqlEmpleado, conn)
                cmdEmpleado.Parameters.AddWithValue("@Nombre", nombre)
                cmdEmpleado.Parameters.AddWithValue("@Paterno", paterno)
                cmdEmpleado.Parameters.AddWithValue("@Materno", materno)
                cmdEmpleado.Parameters.AddWithValue("@Telefono", telefono)
                cmdEmpleado.Parameters.AddWithValue("@Puesto", puesto)
                cmdEmpleado.Parameters.AddWithValue("@IdCuadrilla", idCuadrilla)
                cmdEmpleado.Parameters.AddWithValue("@IdEmpleado", idEmpleado)
                cmdEmpleado.ExecuteNonQuery()
            End Using

            ' Empleado registrado correctamente
            Return True
        End Using

        ' Si el código llega aquí, hubo un error al registrar el empleado
        Return False
    End Function

    Public Shared Function EliminarEmpleado(idEmpleado As Integer) As Boolean
        Dim connString As String = Connection.ObtenerCadenaConexion()

        Using conn As NpgsqlConnection = New NpgsqlConnection(connString)
            conn.Open()

            ' Eliminar datos en la tabla EMPLEADO_CUADRILLA
            Dim sqlEmpleadoCuadrilla As String = "DELETE FROM EMPLEADO_CUADRILLA WHERE id_empleado = @IdEmpleado"
            Using cmdEmpleadoCuadrilla As NpgsqlCommand = New NpgsqlCommand(sqlEmpleadoCuadrilla, conn)
                cmdEmpleadoCuadrilla.Parameters.AddWithValue("@IdEmpleado", idEmpleado)
                cmdEmpleadoCuadrilla.ExecuteNonQuery()
            End Using

            ' Eliminar datos en la tabla USUARIO
            Dim sqlUsuario As String = "DELETE FROM USUARIO WHERE id_empleado = @IdEmpleado"
            Using cmdUsuario As NpgsqlCommand = New NpgsqlCommand(sqlUsuario, conn)
                cmdUsuario.Parameters.AddWithValue("@IdEmpleado", idEmpleado)
                cmdUsuario.ExecuteNonQuery()
            End Using

            ' Eliminar datos en la tabla EMPLEADO
            Dim sqlEmpleado As String = "DELETE FROM EMPLEADO WHERE id_empleado = @IdEmpleado"
            Using cmdEmpleado As NpgsqlCommand = New NpgsqlCommand(sqlEmpleado, conn)
                cmdEmpleado.Parameters.AddWithValue("@IdEmpleado", idEmpleado)
                cmdEmpleado.ExecuteNonQuery()
            End Using

            ' Empleado eliminado correctamente
            Return True
        End Using

        ' Si el código llega aquí, hubo un error al eliminar el empleado
        Return False
    End Function

    Public Shared Function BuscarEmpleado(idEmpleado As Integer) As DataTable
        Dim connString As String = Connection.ObtenerCadenaConexion()
        Dim dt As New DataTable()

        Using conn As NpgsqlConnection = New NpgsqlConnection(connString)
            conn.Open()

            Dim sql As String = "SELECT * FROM EMPLEADO WHERE ID_EMPLEADO = @IdEmpleado"
            Using cmd As NpgsqlCommand = New NpgsqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado)
                Dim adapter As New NpgsqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Shared Function ContraEmpleado(idEmpleado As Integer) As String
        Dim connString As String = Connection.ObtenerCadenaConexion()
        Dim contraseña As String = String.Empty

        Using conn As NpgsqlConnection = New NpgsqlConnection(connString)
            conn.Open()
            Dim sql As String = "SELECT Password FROM USUARIO WHERE ID_EMPLEADO = @IdEmpleado"

            Using cmd As NpgsqlCommand = New NpgsqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado)

                ' Ejecutar la consulta y obtener el resultado
                Dim resultado As Object = cmd.ExecuteScalar()

                ' Verificar si se encontró la contraseña
                If resultado IsNot Nothing AndAlso Not DBNull.Value.Equals(resultado) Then
                    contraseña = resultado.ToString()
                End If
            End Using
        End Using

        Return contraseña
    End Function
End Class
