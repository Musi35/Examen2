Public Class frm_consulta
    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim idCuadrilla As Integer = txt_id.Text
        If Not IsNumeric(txt_id.Text) Then
            MsgBox("El campo de ID debe de ser un número entero.")
        Else
            Dim ds As DataSet = Model_Consulta.Consulta(idCuadrilla)

            dgv_tabla.DataSource = ds.Tables("Resumen de Cuadrillas")
            dgv_tabla.AutoResizeColumns()
            dgv_tabla.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            dgv_tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            If ds.Tables("Resumen de Cuadrillas").Rows.Count = 0 Then
                MessageBox.Show("No se encontraron resultados para la cuadrilla especificada.", "Información")
            End If
        End If
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
        frm_colonia.Show()
        Me.Close()
    End Sub

    Private Sub mni_Actividad_Click(sender As Object, e As EventArgs) Handles mni_Actividad.Click
        frm_actividades.Show()
        Me.Close()
    End Sub

    Private Sub mni_Consultas_Click(sender As Object, e As EventArgs) Handles mni_Consultas.Click
        frm_consulta.Show()
        Me.Close()
    End Sub

    Private Sub mni_Salir_Click(sender As Object, e As EventArgs) Handles mni_Salir.Click
        End
    End Sub
End Class