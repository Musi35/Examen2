Imports Npgsql

Public Class Model_Consulta
    Public Shared Function Consulta(idCuadrilla As Integer) As DataSet
        Dim connString As String = Connection.ObtenerCadenaConexion()
        Dim ds As New DataSet()

        Using conn As New NpgsqlConnection(connString)
            Try
                conn.Open()

                Dim query As String = "SELECT EMPLEADO.ID_EMPLEADO, CUADRILLA.NOMBRE AS NOMBRE_CUADRILLA, COUNT(ACTIVIDAD.ID_ACTIVIDAD) AS CANTIDAD_ACTIVIDADES " &
                      "FROM EMPLEADO " &
                      "INNER JOIN EMPLEADO_CUADRILLA ON EMPLEADO.ID_EMPLEADO = EMPLEADO_CUADRILLA.ID_EMPLEADO " &
                      "INNER JOIN CUADRILLA ON EMPLEADO_CUADRILLA.ID_CUADRILLA = CUADRILLA.ID_CUADRILLA " &
                      "LEFT JOIN ACTIVIDAD ON CUADRILLA.ID_CUADRILLA = ACTIVIDAD.ID_CUADRILLA " &
                      "WHERE CUADRILLA.ID_CUADRILLA = @IdCuadrilla " &
                      "GROUP BY EMPLEADO.ID_EMPLEADO, CUADRILLA.NOMBRE"


                Using adapter As New NpgsqlDataAdapter(query, conn)
                    adapter.SelectCommand.Parameters.AddWithValue("@IdCuadrilla", idCuadrilla)
                    adapter.Fill(ds, "Resumen de Cuadrillas")
                End Using

            Catch ex As Exception
                Console.WriteLine("Error: " & ex.Message)
                ' Manejar la excepción según tus necesidades
            Finally
                ' Cerrar la conexión después de su uso
                conn.Close()
            End Try

            ' Verificar si el DataSet está vacío y agregar una tabla vacía si es necesario
            If ds.Tables("Resumen de Cuadrillas") Is Nothing Then
                ds.Tables.Add("Resumen de Cuadrillas")
            End If

            Return ds
        End Using
    End Function
End Class
