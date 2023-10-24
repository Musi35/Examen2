Imports Npgsql
Public Class frm_login
    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        If ValidarCampos.Length > 0 Then
            MsgBox(ValidarCampos)
        Else
            Dim IdEmpleado As Integer = txt_user.Text
            Dim password As String = txt_contra.Text
            Dim connString As String = Connection.ObtenerCadenaConexion()
            Dim sql As String = "SELECT * FROM usuario WHERE id_empleado = @IdEmpleado AND password = @Password"

            Using conn As NpgsqlConnection = New NpgsqlConnection(connString)
                conn.Open()

                Using cmd As NpgsqlCommand = New NpgsqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@IdEmpleado", IdEmpleado)
                    cmd.Parameters.AddWithValue("@Password", password)

                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            frm_main.Show()
                            Me.Hide()
                        Else
                            MsgBox("ID o contraseña incorrectos.")
                            limpiar()
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub btn_ver_Click(sender As Object, e As EventArgs) Handles btn_ver.Click
        If txt_contra.UseSystemPasswordChar.Equals(False) Then
            txt_contra.UseSystemPasswordChar = True
        Else txt_contra.UseSystemPasswordChar = False
        End If
        txt_contra.Focus()
    End Sub

    Private Function ValidarCampos() As String
        Dim errores As String = ""

        ' Validar txt_user (ID de usuario)
        If Not IsNumeric(txt_user.Text) Then
            errores &= "El campo ID de Usuario debe ser un número entero válido." & vbCrLf
        End If

        ' Validar txt_contra (Contraseña)
        If String.IsNullOrEmpty(txt_contra.Text.Trim()) Then
            errores &= "El campo Contraseña no puede estar vacío." & vbCrLf
        End If

        Return errores
    End Function

    Public Sub limpiar()
        txt_user.Text = ""
        txt_contra.Text = ""
    End Sub
End Class