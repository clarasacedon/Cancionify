Public Class Conexion
    Private Sub btnRuta_Click(sender As Object, e As EventArgs) Handles btnRuta.Click
        Dim A As String

        ofdRuta.InitialDirectory = Application.StartupPath

        If ofdRuta.ShowDialog() = DialogResult.OK Then
            txtRuta.Text = ofdRuta.FileName
            btnConectar.Enabled = True
        End If

        A = ofdRuta.InitialDirectory
    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Dim UsuarioAux As Usuario = New Usuario
        Dim ArtistaAux As Artista = New Artista
        Dim AlbumAux As Album = New Album
        Dim CancionAux As Cancion = New Cancion
        Dim ReproduccionAux As Reproduccion = New Reproduccion
        Dim AFavoritoAux As AFavorito = New AFavorito

        Try
            UsuarioAux.LeerTodosUsuarios(txtRuta.Text)
            ArtistaAux.LeerTodosArtistas()
            AlbumAux.LeerTodosAlbum()
            CancionAux.LeerTodasCanciones()
            ReproduccionAux.LeerTodasReproducciones()
            AFavoritoAux.LeerTodosAFavorito()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblConectar.Text = "Error de conexión"
            lblConectar.ForeColor = Color.Red
            Exit Sub
        End Try

        btnRuta.Enabled = False
        btnConectar.Enabled = False

        Me.Hide()
        Datos.Show()
    End Sub

End Class
