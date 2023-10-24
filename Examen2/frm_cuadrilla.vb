Public Class frm_cuadrilla
    Private Sub limpiar()
        txt_id.Text = ""
        txt_nombre.Text = ""
    End Sub

    Private Sub mni_Empleado_Click(sender As Object, e As EventArgs) Handles mni_Empleado.Click
        frm_empleado.Show()
        Me.Close()
    End Sub

    Private Sub mni_Cuadrilla_Click(sender As Object, e As EventArgs) Handles mni_Cuadrilla.Click
        MsgBox("Ya estas en esta página.")
    End Sub

    Private Sub mni_Colonia_Click(sender As Object, e As EventArgs) Handles mni_Colonia.Click
        frm_colonia.Show()
        Me.Close()
    End Sub

    Private Sub mni_Actividad_Click(sender As Object, e As EventArgs) Handles mni_Actividad.Click
        frm_actividades.Show()
        Me.Close()
    End Sub

    Private Sub mni_Consulta_Click(sender As Object, e As EventArgs) Handles mni_Consulta.Click
        frm_consulta.Show()
        Me.Close()
    End Sub

    Private Sub btn_agg_Click(sender As Object, e As EventArgs) Handles btn_agg.Click
        Dim idCuadrilla As Integer = txt_id.Text
        Dim nombre As String = txt_nombre.Text

        If ValidarCampos.Length > 0 Then
            MsgBox(ValidarCampos)
        Else

            If Model_Cuadrilla.AgregarCuadrilla(idCuadrilla, nombre).Equals(True) Then
                MsgBox("Empleado agregado correctamente.")
                limpiar()
            Else
                MsgBox("Pasó algo")
            End If
        End If

    End Sub

    Private Sub btn_actu_Click(sender As Object, e As EventArgs) Handles btn_actu.Click
        Dim idCuadrilla As Integer = txt_id.Text
        Dim nombre As String = txt_nombre.Text

        If ValidarCampos.Length > 0 Then
            MsgBox(ValidarCampos)
        Else
            If Model_Cuadrilla.ActualizarCuadrilla(idCuadrilla, nombre).Equals(True) Then
                MsgBox("Empleado acutualizado correctamente.")
                limpiar()
            Else
                MsgBox("Pasó algo")
            End If
        End If

    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        Dim idCuadrilla As Integer = txt_id.Text
        If Not IsNumeric(txt_id.Text) Then
            MsgBox("El campo ID de Cuadrilla debe ser un número entero válido.")
        Else
            If Model_Cuadrilla.EliminarCuadrilla(idCuadrilla).Equals(True) Then
                MsgBox("Empleado eliminado correctamente.")
                limpiar()
            Else
                MsgBox("Pasó algo")
            End If
        End If

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If Not IsNumeric(txt_id.Text) Then
            MsgBox("El campo ID de Cuadrilla debe ser un número entero válido.")
        Else
            Dim idCuadrilla As Integer = Integer.Parse(txt_id.Text) ' Obtener el ID del TextBox
            ' Llamar a la función BuscarEmpleado para obtener el DataTable
            Dim dt As DataTable = Model_Cuadrilla.BuscarCuadrilla(idCuadrilla)

            ' Verificar si se encontraron datos en el DataTable
            If dt.Rows.Count > 0 Then
                ' Obtener la primera fila del DataTable (suponiendo que solo esperas un resultado)
                Dim row As DataRow = dt.Rows(0)

                ' Asignar valores a los TextBox y ComboBox
                txt_nombre.Text = row("NOMBRE").ToString()
            Else
                MsgBox("Cuadrilla no encontrada.", MsgBoxStyle.Information, "Búsqueda de Cuadrilla")
                limpiar()
            End If
        End If
    End Sub

    Private Function ValidarCampos() As String
        Dim errores As String = ""

        ' Validar txt_user (ID de usuario)
        If Not IsNumeric(txt_id.Text) Then
            errores &= "El campo ID de Cuadrilla debe ser un número entero válido." & vbCrLf
        End If

        ' Validar txt_contra (Contraseña)
        If String.IsNullOrEmpty(txt_nombre.Text.Trim()) Then
            errores &= "El campo Nombre no puede estar vacío." & vbCrLf
        End If

        Return errores
    End Function

    Private Sub mni_Salir_Click(sender As Object, e As EventArgs) Handles mni_Salir.Click
        End
    End Sub
End Class