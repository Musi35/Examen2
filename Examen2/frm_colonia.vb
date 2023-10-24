Public Class frm_colonia
    Private Sub limpiar()
        txt_cod.Text = ""
        txt_id.Text = ""
        txt_nombre.Text = ""
    End Sub

    Private Sub mni_Empleado_Click(sender As Object, e As EventArgs) Handles mni_Empleado.Click
        frm_empleado.Show()
        Me.Close()
    End Sub

    Private Sub mni_Cuadrilla_Click(sender As Object, e As EventArgs) Handles mni_Cuadrilla.Click
        frm_cuadrilla.Show()
        Me.Close()
    End Sub

    Private Sub mni_Colonia_Click(sender As Object, e As EventArgs) Handles mni_Colonia.Click
        MsgBox("Ya estas en esta página.")
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
        Dim id As String = txt_id.Text
        Dim nombre As String = txt_nombre.Text
        Dim cod As Integer = txt_cod.Text

        If ValidarCampos.Length > 0 Then
            MsgBox(ValidarCampos)
        Else
            If Model_Colonia.AgregarColonia(id, nombre, cod).Equals(True) Then
                MsgBox("Colonia agregada correctamente.")
                limpiar()
            Else
                MsgBox("Algo pasó.")
            End If
        End If
    End Sub

    Private Sub btn_actu_Click(sender As Object, e As EventArgs) Handles btn_actu.Click
        Dim id As String = txt_id.Text
        Dim nombre As String = txt_nombre.Text
        Dim cod As Integer = txt_cod.Text

        If ValidarCampos.Length > 0 Then
            MsgBox(ValidarCampos)
        Else
            If Model_Colonia.ActualizarColonia(id, nombre, cod).Equals(True) Then
                MsgBox("Colonia actualizada correctamente.")
                limpiar()
            Else
                MsgBox("Algo pasó.")
            End If
        End If
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        Dim id As String = txt_id.Text

        If Not IsNumeric(txt_id.Text) Then
            MsgBox("El campo ID debe ser un número entero válido.")
        Else
            If Model_Colonia.EliminarColonia(id).Equals(True) Then
                MsgBox("Colonia eliminada correctamente.")
                limpiar()
            Else
                MsgBox("Algo pasó.")
            End If
        End If
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        If Not IsNumeric(txt_id.Text) Then
            MsgBox("El campo ID debe ser un número entero válido.")
        Else
            Dim idColonia As Integer = Integer.Parse(txt_id.Text) ' Obtener el ID del TextBox
            ' Llamar a la función BuscarEmpleado para obtener el DataTable
            Dim dt As DataTable = Model_Colonia.BuscarColonia(idColonia)

            ' Verificar si se encontraron datos en el DataTable
            If dt.Rows.Count > 0 Then
                ' Obtener la primera fila del DataTable (suponiendo que solo esperas un resultado)
                Dim row As DataRow = dt.Rows(0)

                ' Asignar valores a los TextBox y ComboBox
                txt_nombre.Text = row("NOMBRE").ToString()
                txt_cod.Text = row("CODIGO_POSTAL").ToString()

            Else
                MsgBox("Colonia no encontrada.", MsgBoxStyle.Information, "Búsqueda de Colonia")
                limpiar()
            End If
        End If
    End Sub

    Private Function ValidarCampos() As String
        Dim errores As String = ""

        ' Validar txt_id (ID)
        If Not IsNumeric(txt_id.Text) Then
            errores &= "El campo ID debe ser un número entero válido." & vbCrLf
        End If

        ' Validar txt_nombre (Nombre)
        If String.IsNullOrEmpty(txt_nombre.Text.Trim()) Then
            errores &= "El campo Nombre no puede estar vacío." & vbCrLf
        End If

        ' Validar txt_cod (Código)
        If Not IsNumeric(txt_cod.Text) Then
            errores &= "El campo Código debe ser un número entero válido." & vbCrLf
        End If

        Return errores
    End Function

    Private Sub mni_Salir_Click(sender As Object, e As EventArgs) Handles mni_Salir.Click
        End
    End Sub
End Class