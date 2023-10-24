Imports Npgsql
Public Class frm_empleado
    Private Sub limpiar()
        txt_contra.Text = ""
        txt_idCuad.Text = ""
        txt_idEmp.Text = ""
        txt_materno.Text = ""
        txt_nombre.Text = ""
        txt_paterno.Text = ""
        txt_telefono.Text = ""
        cbo_puesto.SelectedIndex = -1
    End Sub
    Private Sub mni_Empleado_Click(sender As Object, e As EventArgs) Handles mni_Empleado.Click
        MsgBox("Ya estas en esta página.")
    End Sub

    Private Sub mni_Cuadrilla_Click(sender As Object, e As EventArgs) Handles mni_Cuadrilla.Click
        frm_cuadrilla.Show()
        Me.Close()
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
        Dim idempleado As Integer = txt_idEmp.Text
        Dim nombre As String = txt_nombre.Text
        Dim paterno As String = txt_paterno.Text
        Dim materno As String = txt_materno.Text
        Dim telefono As String = txt_telefono.Text
        Dim puesto As String = cbo_puesto.SelectedItem.ToString()
        Dim idcuadrilla As Integer = txt_idCuad.Text
        Dim contra As String = txt_contra.Text

        If (ValidarCampos.Length > 0) Then
            MsgBox(ValidarCampos)
        Else
            If Model_Empleado.AgregarEmpleado(idempleado, nombre, paterno, materno, telefono, puesto, idcuadrilla, contra).Equals(True) Then
                MsgBox("Empleado agregado correctamente.")
                limpiar()
            Else
                MsgBox("Pasó algo.")
            End If
        End If
    End Sub

    Private Sub btn_actu_Click(sender As Object, e As EventArgs) Handles btn_actu.Click
        Dim idEmpleado As Integer = txt_idEmp.Text
        Dim nombre As String = txt_nombre.Text
        Dim paterno As String = txt_paterno.Text
        Dim materno As String = txt_materno.Text
        Dim telefono As String = txt_telefono.Text
        Dim puesto As String = cbo_puesto.SelectedItem.ToString()
        Dim idCuadrilla As Integer = txt_idCuad.Text
        Dim contra As String = txt_contra.Text

        If (ValidarCampos.Length > 0) Then
            MsgBox(ValidarCampos)
        Else
            If Model_Empleado.ActualizarEmpleado(idEmpleado, nombre, paterno, materno, telefono, puesto, idCuadrilla, contra).Equals(True) Then
                MsgBox("Empleado actualizado correctamente.")
                limpiar()
            Else
                MsgBox("Pasó algo.")
            End If
        End If


    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        Dim idEmpleado As Integer = txt_idEmp.Text

        If Not IsNumeric(txt_idEmp.Text) Then
            MsgBox("El campo ID de Empleado debe ser un número entero válido.")
        Else
            If Model_Empleado.EliminarEmpleado(idEmpleado).Equals(True) Then
                MsgBox("Empleado eliminado correctamente.")
                limpiar()
            Else
                MsgBox("Pasó algo.")
            End If
        End If
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If Not IsNumeric(txt_idEmp.Text) Then
            MsgBox("El campo ID de Empleado debe ser un número entero válido.")
        Else
            Dim idEmpleado As Integer = Integer.Parse(txt_idEmp.Text) ' Obtener el ID del TextBox
            ' Llamar a la función BuscarEmpleado para obtener el DataTable
            Dim dt As DataTable = Model_Empleado.BuscarEmpleado(idEmpleado)

            ' Verificar si se encontraron datos en el DataTable
            If dt.Rows.Count > 0 Then
                ' Obtener la primera fila del DataTable (suponiendo que solo esperas un resultado)
                Dim row As DataRow = dt.Rows(0)

                ' Asignar valores a los TextBox y ComboBox
                txt_nombre.Text = row("NOMBRE").ToString()
                txt_paterno.Text = row("PATERNO").ToString()
                txt_materno.Text = row("MATERNO").ToString()
                txt_telefono.Text = row("TELEFONO").ToString()

                ' Establecer el valor del ComboBox según el puesto del empleado
                Dim puesto As String = row("PUESTO").ToString()
                Select Case puesto
                    Case "Jefe de Cuadrilla"
                        cbo_puesto.SelectedIndex = 0
                    Case "Gerente"
                        cbo_puesto.SelectedIndex = 1
                    Case "Empleado"
                        cbo_puesto.SelectedIndex = 2
                End Select

                txt_idCuad.Text = row("ID_CUADRILLA").ToString()
                limpiar()
            Else
                MsgBox("Empleado no encontrado.", MsgBoxStyle.Information, "Búsqueda de Empleado")
            End If

            If String.IsNullOrEmpty(Model_Empleado.ContraEmpleado(idEmpleado)) Then
            Else
                txt_contra.Text = Model_Empleado.ContraEmpleado(idEmpleado)
            End If
        End If
    End Sub

    Private Function ValidarCampos() As String
        Dim errores As String = ""

        ' Validar txt_idEmp
        If Not IsNumeric(txt_idEmp.Text) Then
            errores &= "El campo ID de Empleado debe ser un número entero válido." & vbCrLf
        End If

        ' Validar txt_nombre
        If String.IsNullOrEmpty(txt_nombre.Text.Trim()) Then
            errores &= "El campo Nombre no puede estar vacío." & vbCrLf
        End If

        ' Validar txt_paterno
        If String.IsNullOrEmpty(txt_paterno.Text.Trim()) Then
            errores &= "El campo Apellido Paterno no puede estar vacío." & vbCrLf
        End If

        ' Validar txt_materno
        If String.IsNullOrEmpty(txt_materno.Text.Trim()) Then
            errores &= "El campo Apellido Materno no puede estar vacío." & vbCrLf
        End If

        ' Validar txt_telefono
        If String.IsNullOrEmpty(txt_telefono.Text.Trim()) Then
            errores &= "El campo Teléfono no puede estar vacío." & vbCrLf
        End If

        ' Validar cbo_puesto
        If cbo_puesto.SelectedIndex = -1 Then
            errores &= "Debes seleccionar un puesto." & vbCrLf
        End If

        ' Validar txt_idCuad
        If Not IsNumeric(txt_idCuad.Text) Then
            errores &= "El campo ID de Cuaderno debe ser un número entero válido." & vbCrLf
        End If

        ' Validar txt_contra
        If String.IsNullOrEmpty(txt_contra.Text.Trim()) Then
            errores &= "El campo Contraseña no puede estar vacío." & vbCrLf
        End If
        Return errores
    End Function

    Private Sub mni_Salir_Click(sender As Object, e As EventArgs) Handles mni_Salir.Click
        End
    End Sub
End Class