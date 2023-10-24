Public Class frm_main
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