Public Class Registrarse
    Private Sub btnEmpezar_Click(sender As Object, e As EventArgs) Handles btnEmpezar.Click
        Dim UsuarioAux As Usuario = New Usuario
        Dim ArtistaAux As Artista = New Artista

        Try
            If txtEmail.Text IsNot String.Empty And txtNombre.Text IsNot String.Empty And txtApellidos.Text IsNot String.Empty And txtFechaNacimiento.Text IsNot String.Empty Then
                UsuarioAux = New Usuario(txtEmail.Text)
                UsuarioAux.Nombre = txtNombre.Text
                UsuarioAux.Apellidos = txtApellidos.Text
                UsuarioAux.FechaNacimiento = txtFechaNacimiento.Text
                Menu.lblBienvenida.Text = "Hola, " + UsuarioAux.Nombre + "!"
                Menu.lblBienvenida.ForeColor = Color.LightSeaGreen

                If (DateAndTime.Today.Year - txtFechaNacimiento.Value.Year) < 18 Then
                    MessageBox.Show("Tiene que ser mayor de 18 años para el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    If UsuarioAux.InsertarUsuario() <> 1 Then
                        MessageBox.Show("Insert return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        Me.Hide()
                        Datos.txtUsuario.Text = txtEmail.Text
                        Datos.Show()
                    End If
                End If
            Else
                MessageBox.Show("Rellene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Hide()
        Datos.Show()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtEmail.Text = String.Empty
        txtNombre.Text = String.Empty
        txtApellidos.Text = String.Empty
        txtFechaNacimiento.ResetText()
        btnEmpezar.Enabled = True
        btnLimpiar.Enabled = True
        btnAtras.Enabled = True
    End Sub

End Class