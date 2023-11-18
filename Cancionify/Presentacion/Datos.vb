Public Class Datos
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtUsuario.Text = String.Empty
        btnAcceder.Enabled = True
        btnLimpiar.Enabled = True
        btnRegistrarse.Enabled = True
    End Sub

    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        Me.Hide()
        Registrarse.Show()
    End Sub

    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        limpiar()

        Dim ArtistaAux As Artista = New Artista
        Dim UsuarioAux As Usuario = New Usuario
        Dim encontrado As Boolean

        If txtUsuario.Text IsNot String.Empty Then
            Try
                UsuarioAux.LeerTodosUsuarios()
                For Each U As Usuario In UsuarioAux.UsuarioDAO.Usuarios
                    If (txtUsuario.Text = U.Email) Then
                        Menu.lblBienvenida.Text = "Hola, " + U.Nombre + "!"
                        Menu.lblBienvenida.ForeColor = Color.LightSeaGreen
                        encontrado = True
                    End If
                Next
                If encontrado Then
                    Me.Hide()
                    Menu.Show()
                    ArtistaAux.LeerTodosArtistas()
                    For Each P As Artista In ArtistaAux.ArtistaDAO.Artistas
                        Menu.lstArtistas.Items.Add(P.Nombre)
                    Next
                Else
                    MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        Else
            MessageBox.Show("Rellene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub

    Private Sub limpiar()
        Menu.lstAlbumes.Items.Clear()
        Menu.lstArtistas.Items.Clear()
        Menu.lstCanciones.Items.Clear()
        Menu.lstCanciones_Album.Items.Clear()
        Menu.cbArtistaAlbum.Items.Clear()
        Menu.txtTituloAlbum.Text = String.Empty
        Menu.lblDuracionAlbum.Text = String.Empty
        Menu.dtpFechaA.Text = String.Empty
        Menu.lblConfirmacionCancion.Text = String.Empty
    End Sub

End Class