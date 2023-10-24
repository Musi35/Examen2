Public Class frm_actividades
    Private Sub limpiar()
        txt_fot.Text = ""
        txt_idAct.Text = ""
        txt_idCol.Text = ""
        txt_idCuad.Text = ""
        pcb_foto.Image = Nothing
        rtb_detalle.Text = ""
    End Sub

    Dim strFileName As String
    Private Sub mni_Empleado_Click(sender As Object, e As EventArgs) Handles mni_Empleado.Click
        frm_empleado.Show()
        Me.Close()
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
        MsgBox("Ya estas en esta página.")
    End Sub

    Private Sub mni_Consulta_Click(sender As Object, e As EventArgs) Handles mni_Consulta.Click
        frm_consulta.Show()
        Me.Close()
    End Sub

    Private Sub btn_img_Click(sender As Object, e As EventArgs) Handles btn_img.Click
        Dim OpenFileDialog As New OpenFileDialog()

        ' Configurar el cuadro de diálogo para seleccionar archivos de imagen
        OpenFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
        OpenFileDialog.FilterIndex = 1
        OpenFileDialog.Title = "Seleccionar una imagen"

        ' Mostrar el cuadro de diálogo
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Obtener la ruta del archivo seleccionado
                Dim filePath As String = OpenFileDialog.FileName
                txt_fot.Text = filePath
                ' Mostrar la imagen en el PictureBox
                pcb_foto.Image = Image.FromFile(filePath)
            Catch ex As Exception
                ' Manejar cualquier error que pueda ocurrir al cargar la imagen
                MessageBox.Show("Error al cargar la imagen: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btn_agg_Click(sender As Object, e As EventArgs) Handles btn_agg.Click
        Dim idActividad As Integer = txt_idAct.Text
        Dim idCuadrilla As Integer = txt_idCuad.Text
        Dim foto As String = txt_fot.Text
        Dim idColonia As Integer = txt_idCol.Text
        Dim detalle As String = rtb_detalle.Text

        If ValidarCampos.Length > 0 Then
            MsgBox(ValidarCampos)
        Else
            If Model_Actividades.AgregarActividad(idActividad, idCuadrilla, foto, idColonia, detalle).Equals(True) Then
                MsgBox("Cuadrilla agregada correctamente.")
                limpiar()
            Else
                MsgBox("Algo pasó.")
            End If
        End If
    End Sub

    Private Sub btn_actu_Click(sender As Object, e As EventArgs) Handles btn_actu.Click
        Dim idActividad As Integer = txt_idAct.Text
        Dim idCuadrilla As Integer = txt_idCuad.Text
        Dim foto As String = txt_fot.Text
        Dim idColonia As Integer = txt_idCol.Text
        Dim detalle As String = rtb_detalle.Text

        If ValidarCampos.Length > 0 Then
            MsgBox(ValidarCampos)
        Else
            If Model_Actividades.ActualizarActividad(idActividad, idCuadrilla, foto, idColonia, detalle).Equals(True) Then
                MsgBox("Cuadrilla actualizada correctamente.")
                limpiar()
            Else
                MsgBox("Algo pasó.")
            End If
        End If
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        Dim idActividad As Integer = txt_idAct.Text
        If Not IsNumeric(txt_idAct.Text) Then
            MsgBox("El campo ID de Actividad debe ser un número entero válido.")
        Else
            If Model_Actividades.EliminarActividad(idActividad).Equals(True) Then
                MsgBox("Cuadrilla eliminada correctamente.")
                limpiar()
            Else
                MsgBox("Algo pasó.")
            End If
        End If
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If Not IsNumeric(txt_idAct.Text) Then
            MsgBox("El campo ID de Actividad debe ser un número entero válido.")
        Else
            Dim idActividad As Integer = Integer.Parse(txt_idAct.Text) ' Obtener el ID del TextBox
            ' Llamar a la función BuscarEmpleado para obtener el DataTable
            Dim dt As DataTable = Model_Actividades.BuscarActividad(idActividad)

            ' Verificar si se encontraron datos en el DataTable
            If dt.Rows.Count > 0 Then
                ' Obtener la primera fila del DataTable (suponiendo que solo esperas un resultado)
                Dim row As DataRow = dt.Rows(0)

                ' Asignar valores a los TextBox y ComboBox
                txt_idCuad.Text = row("ID_CUADRILLA").ToString()
                txt_fot.Text = row("FOTO").ToString()
                txt_idCol.Text = row("ID_COLONIA").ToString()
                rtb_detalle.Text = row("DETALLE").ToString()
                Dim imagen As Image = Image.FromFile(txt_fot.Text)
                pcb_foto.Image = imagen
            Else
                MsgBox("Actividad no encontrada.", MsgBoxStyle.Information, "Búsqueda de Actividad")
                limpiar()
            End If
        End If
    End Sub

    Private Function ValidarCampos() As String
        Dim errores As String = ""

        ' Validar txt_idAct (ID de Actividad)
        If Not IsNumeric(txt_idAct.Text) Then
            errores &= "El campo ID de Actividad debe ser un número entero válido." & vbCrLf
        End If

        ' Validar txt_idCuad (ID de Cuaderno)
        If Not IsNumeric(txt_idCuad.Text) Then
            errores &= "El campo ID de Cuaderno debe ser un número entero válido." & vbCrLf
        End If

        ' Validar txt_fot (Foto)
        If String.IsNullOrEmpty(txt_fot.Text.Trim()) Then
            errores &= "El campo Foto no puede estar vacío." & vbCrLf
        End If

        ' Validar txt_idCol (ID de Colonia)
        If Not IsNumeric(txt_idCol.Text) Then
            errores &= "El campo ID de Colonia debe ser un número entero válido." & vbCrLf
        End If

        ' Validar rtb_detalle (Detalle)
        If String.IsNullOrEmpty(rtb_detalle.Text.Trim()) Then
            errores &= "El campo Detalle no puede estar vacío." & vbCrLf
        End If

        Return errores
    End Function

    Private Sub mni_Salir_Click(sender As Object, e As EventArgs) Handles mni_Salir.Click
        End
    End Sub
End Class