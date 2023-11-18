Public Class Menu
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MessageBox.Show("¿Desea abandonar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click
        Me.Hide()
        Datos.txtUsuario.Text = String.Empty
        Datos.Show()
    End Sub

    Private Sub tbcMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbcMenu.SelectedIndexChanged
        Dim AlbumAux As Album = New Album
        Dim ArtistaAux As Artista = New Artista
        Dim CancionAux As Cancion = New Cancion
        Dim UsuarioAux As Usuario = New Usuario
        Dim aux As Integer

        limpiar()

        Try
            AlbumAux.LeerTodosAlbum()
            ArtistaAux.LeerTodosArtistas()
            CancionAux.LeerTodasCanciones()
            UsuarioAux.LeerTodosUsuarios()

            For Each B As Album In AlbumAux.AlbumDAO.Album
                lstMis_albumes.Items.Add(B.Nombre)
            Next

            For Each A As Artista In ArtistaAux.ArtistaDAO.Artistas
                cbMis_artistas.Enabled = False
                lstMis_artistas.Items.Add(A.Nombre)
                aux = A.IdArtista
            Next

            For Each C As Cancion In CancionAux.CancionDAO.Canciones
                lstMis_canciones.Items.Add(C.Nombre)
            Next

            For Each U As Usuario In UsuarioAux.UsuarioDAO.Usuarios
                lstUsuarios.Items.Add(U.Email)
                txtPaisConsulta.Enabled = True
                cbUser.Enabled = True
                dtpInicio.Enabled = True
                dtpFin.Enabled = True
                cbUser.Items.Add(U.Email)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub lstArtistas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstArtistas.SelectedIndexChanged
        Dim ArtistaAux As Artista = New Artista
        Dim AlbumAux As Album = New Album
        Dim AFavoritoAux As AFavorito = New AFavorito
        Dim aux As Integer
        Dim ruta As String
        Dim rutaGeneral As String

        lstAlbumes.Items.Clear()
        lstCanciones.Items.Clear()
        lblFechaAlb.Text = String.Empty
        lblDuracionAlb.Text = String.Empty
        lblTituloAlb.Text = String.Empty
        lblArtistaAlb.Text = String.Empty
        pbAlbum.Image = Nothing
        lblAlbumCan.Text = String.Empty
        lblTituloCan.Text = String.Empty
        lblDuracionCan.Text = String.Empty

        ruta = Application.StartupPath

        Try
            AlbumAux.LeerTodosAlbum()
            ArtistaAux.LeerTodosArtistas()
            AFavoritoAux.LeerTodosAFavorito()

            If lstArtistas.SelectionMode.One Then
                For Each A As Artista In ArtistaAux.ArtistaDAO.Artistas
                    If (lstArtistas.SelectedItem = A.Nombre) Then
                        gbInfoArt.Visible = True
                        lblNombreArt.Text = A.Nombre
                        lblPaisArt.Text = A.Pais
                        rutaGeneral = ruta & "Imagenes\" & A.Imagen
                        pbArtista.ImageLocation = rutaGeneral
                        aux = A.IdArtista
                        lstAlbumes.Items.Clear()
                    End If
                Next
                pcFavoritoArt.Visible = False
                pcNoFavArt.Visible = True
                lblTextoArtista.Text = "Artista NO favorito"
                lblTextoArtista.ForeColor = Color.DarkGreen

                For Each B As AFavorito In AFavoritoAux.AFavoritoDAO.AFavoritos
                    If ((Datos.txtUsuario.Text = B.Usuario.Email) And (aux = B.Artista.IdArtista)) Then
                        pcFavoritoArt.Visible = True
                        pcNoFavArt.Visible = False
                        lblTextoArtista.Text = "Artista favorito"
                        lblTextoArtista.ForeColor = Color.Indigo
                    End If
                Next
                For Each P As Album In AlbumAux.AlbumDAO.Album
                    If (aux = P.Artista.IdArtista) Then
                        lstAlbumes.Items.Add(P.Nombre)
                    End If
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub pcNoFavArt_Click(sender As Object, e As EventArgs) Handles pcNoFavArt.Click
        Dim AFavoritoAux As AFavorito = New AFavorito
        Dim ArtistaAux As Artista = New Artista
        Dim aux As Integer

        Try
            AFavoritoAux.LeerTodosAFavorito()
            ArtistaAux.LeerTodosArtistas()

            AFavoritoAux.Usuario = New Usuario(Datos.txtUsuario.Text)

            For Each C As Artista In ArtistaAux.ArtistaDAO.Artistas
                If (lblNombreArt.Text = C.Nombre) Then
                    aux = C.IdArtista
                End If
            Next

            AFavoritoAux.Artista = New Artista(aux)
            AFavoritoAux.Fecha = DateAndTime.Today
            AFavoritoAux.InsertarAFavorito()
            pcFavoritoArt.Visible = True
            pcNoFavArt.Visible = False
            lblTextoArtista.Text = "Artista favorito"
            lblTextoArtista.ForeColor = Color.Indigo

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub pcFavoritoArt_Click(sender As Object, e As EventArgs) Handles pcFavoritoArt.Click
        Dim AFavoritoAux As AFavorito = New AFavorito
        Dim ArtistaAux As Artista = New Artista
        Dim aux As Integer

        Try
            AFavoritoAux.LeerTodosAFavorito()
            ArtistaAux.LeerTodosArtistas()

            For Each C As Artista In ArtistaAux.ArtistaDAO.Artistas
                If (lblNombreArt.Text = C.Nombre) Then
                    AFavoritoAux.Usuario = New Usuario(Datos.txtUsuario.Text)
                    aux = C.IdArtista
                    AFavoritoAux.LeerAFavorito()
                End If
            Next

            For Each B As AFavorito In AFavoritoAux.AFavoritoDAO.AFavoritos
                If ((Datos.txtUsuario.Text = B.Usuario.Email) And (aux = B.Artista.IdArtista)) Then
                    B.BorrarAFavoritoEspecifico()
                    pcFavoritoArt.Visible = False
                    pcNoFavArt.Visible = True
                    lblTextoArtista.Text = "Artista No favorito"
                    lblTextoArtista.ForeColor = Color.DarkGreen
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub lstAlbumes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAlbumes.SelectedIndexChanged
        Dim CancionesAux As Cancion = New Cancion
        Dim AlbumAux As Album = New Album
        Dim ArtistaAux As Artista = New Artista
        Dim aux As Integer
        Dim aux2 As Integer
        Dim duracion As Integer
        Dim ruta As String
        Dim rutaGeneral As String

        ruta = Application.StartupPath

        Try
            AlbumAux.LeerTodosAlbum()
            CancionesAux.LeerTodasCanciones()

            If lstAlbumes.SelectionMode.One Then
                For Each B As Album In AlbumAux.AlbumDAO.Album
                    If (lstAlbumes.SelectedItem = B.Nombre) Then
                        gbInfoAlbum.Visible = True
                        lblTituloAlb.Text = B.Nombre
                        lblFechaAlb.Text = B.Fecha
                        aux2 = B.Artista.IdArtista
                        rutaGeneral = ruta & "Imagenes\" & B.Portada
                        pbAlbum.ImageLocation = rutaGeneral
                        aux = B.idAlbum
                        lstCanciones.Items.Clear()
                    End If
                Next
                For Each A As Artista In ArtistaAux.ArtistaDAO.Artistas
                    MessageBox.Show(aux2)
                    If (aux2 = A.IdArtista) Then
                        lblArtistaAlb.Text = A.Nombre
                    End If
                Next
                For Each P As Cancion In CancionesAux.CancionDAO.Canciones
                    If (aux = P.Album.idAlbum) Then
                        duracion += P.Duracion
                        lstCanciones.Items.Add(P.Nombre)
                    End If
                Next
                lblDuracionAlb.Text = darFormatoDuracion(duracion)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub lstCanciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCanciones.SelectedIndexChanged
        Dim CancionAux As Cancion = New Cancion
        Dim AlbumAux As Album = New Album
        Dim aux As Integer

        Try
            CancionAux.LeerTodasCanciones()
            AlbumAux.LeerTodosAlbum()

            If lstCanciones.SelectionMode.One Then
                For Each C As Cancion In CancionAux.CancionDAO.Canciones
                    If (lstCanciones.SelectedItem = C.Nombre) Then
                        gbInfoCancion.Visible = True
                        lblTituloCan.Text = C.Nombre
                        lblDuracionCan.Text = darFormatoDuracion(C.Duracion)
                        aux = C.Album.idAlbum
                    End If
                Next
                For Each B As Album In AlbumAux.AlbumDAO.Album
                    If (aux = B.idAlbum) Then
                        lblAlbumCan.Text = B.Nombre
                    End If
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub pbPlayInicio_Click(sender As Object, e As EventArgs)
        'Timer1.Start()

        Dim ReproduccionAux As Reproduccion = New Reproduccion
        Dim CancionAux As Cancion = New Cancion
        Dim aux As Integer

        Try
            ReproduccionAux.LeerTodasReproducciones()
            CancionAux.LeerTodasCanciones()

            ReproduccionAux.Usuario = New Usuario(Datos.txtUsuario.Text)

            For Each C As Cancion In CancionAux.CancionDAO.Canciones
                If (lblTituloCan.Text = C.Nombre) Then
                    aux = C.IdCancion
                End If
            Next

            pbPlayInicio.Visible = False
            pbPauseInicio.Visible = True
            ReproduccionAux.Cancion = New Cancion(aux)
            ReproduccionAux.Fecha = DateAndTime.Today
            ReproduccionAux.InsertarReproduccion()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub pbPauseInicio_Click(sender As Object, e As EventArgs)
        'Timer1.Stop()
        pbPlayInicio.Visible = True
        pbPauseInicio.Visible = False
    End Sub

    Private Sub pbAnteriorInicio_Click(sender As Object, e As EventArgs) Handles pbAnteriorInicio.Click
        lstCanciones.SelectedIndex = lstCanciones.SelectedIndex - 1
    End Sub

    Private Sub pbSiguienteInicio_Click(sender As Object, e As EventArgs) Handles pbSiguienteInicio.Click
        lstCanciones.SelectedIndex = lstCanciones.SelectedIndex + 1
    End Sub

    Private Sub lstMis_albumes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMis_albumes.SelectedIndexChanged
        lstCanciones_Album.Items.Clear()
        cbArtistaAlbum.Items.Clear()
        gbAlbumes.Enabled = True
        txtTituloAlbum.Enabled = False
        cbArtistaAlbum.Enabled = False
        dtpFechaA.Enabled = False
        btnAnadirAlbum.Enabled = False
        btnEliminarAlbum.Enabled = True
        btnPulAnadirAlbum.Enabled = True
        btnAnadirImagenArtista.Enabled = False
        btnImagenAlbum.Enabled = False
        btnPulModifAlbum.Enabled = True
        btnModificarAlbum.Enabled = False

        Dim CancionesAux As Cancion = New Cancion
        Dim AlbumAux As Album = New Album
        Dim ArtistaAux As Artista = New Artista
        Dim duracion As Double
        Dim aux As Integer
        Dim aux2 As Integer
        Dim rutaGeneral As String
        Dim ruta As String

        ruta = Application.StartupPath

        Try
            CancionesAux.LeerTodasCanciones()
            AlbumAux.LeerTodosAlbum()
            ArtistaAux.LeerTodosArtistas()

            If lstMis_albumes.SelectionMode.One Then

                gbAlbumes.Enabled = True
                btnAnadirAlbum.Enabled = False

                For Each B As Album In AlbumAux.AlbumDAO.Album
                    If (lstMis_albumes.SelectedItem = B.Nombre) Then
                        txtTituloAlbum.Text = B.Nombre
                        dtpFechaA.Value = B.Fecha
                        lblIDAl.Text = B.idAlbum

                        rutaGeneral = ruta & "Imagenes\" & B.Portada
                        pbImagen.ImageLocation = rutaGeneral

                        aux = B.idAlbum
                        aux2 = B.Artista.IdArtista
                    End If
                Next

                For Each A As Artista In ArtistaAux.ArtistaDAO.Artistas
                    cbArtistaAlbum.Items.Add(A.Nombre)
                    If (aux2 = A.IdArtista) Then
                        cbArtistaAlbum.Text = A.Nombre
                    End If
                Next

                For Each C As Cancion In CancionesAux.CancionDAO.Canciones
                    If (aux = C.Album.idAlbum) Then
                        lstCanciones_Album.Items.Add(C.Nombre)
                        duracion += C.Duracion
                    End If
                Next

                lblDuracionAlbum.Text = darFormatoDuracion(duracion)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnPulAnadirAlbum_Click(sender As Object, e As EventArgs) Handles btnPulAnadirAlbum.Click
        cbArtistaAlbum.Items.Clear()
        btnLimpiarAlbum.PerformClick()
        pbImagen.Image = Nothing
        odfimagen.FileName = String.Empty

        Dim ArtistaAux As Artista = New Artista

        ArtistaAux.LeerTodosArtistas()

        For Each C As Artista In ArtistaAux.ArtistaDAO.Artistas
            cbArtistaAlbum.Items.Add(C.Nombre)
        Next

        gbAlbumes.Enabled = True
        btnAnadirAlbum.Enabled = True
        btnModificarAlbum.Enabled = False
        btnPulModifAlbum.Enabled = False
        btnEliminarAlbum.Enabled = False
        btnLimpiarAlbum.Enabled = True
        txtTituloAlbum.Enabled = True
        cbArtistaAlbum.Enabled = True
        dtpFechaA.Enabled = True
        btnImagenAlbum.Enabled = True
    End Sub

    Private Sub btnAnadirAlbum_Click(sender As Object, e As EventArgs) Handles btnAnadirAlbum.Click
        Dim AlbumAux As Album = New Album
        Dim ArtistaAux As Artista = New Artista
        Dim aux As Integer
        Dim rutaImagen As String
        rutaImagen = String.Empty

        rutaImagen = odfimagen.SafeFileName.ToString

        If txtTituloAlbum.Text IsNot String.Empty And cbArtistaAlbum.SelectedValue IsNot String.Empty And dtpFechaA.Text IsNot String.Empty And rutaImagen IsNot String.Empty Then
            Try
                AlbumAux.LeerTodosAlbum()

                For Each A As Album In AlbumAux.AlbumDAO.Album
                    aux = A.idAlbum
                Next

                AlbumAux = New Album
                AlbumAux.Nombre = txtTituloAlbum.Text
                AlbumAux.Fecha = dtpFechaA.Value.Date
                AlbumAux.Portada = rutaImagen

                ArtistaAux.LeerTodosArtistas()

                For Each A As Artista In ArtistaAux.ArtistaDAO.Artistas
                    If cbArtistaAlbum.SelectedItem = A.Nombre Then
                        aux = 1
                        AlbumAux.Artista = New Artista(A.IdArtista)
                    End If
                Next

                If aux = 1 Then
                    If AlbumAux.InsertarAlbum() <> 1 Then
                        MessageBox.Show("Insert return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        lblConfirmacionAlbum.Text = "ALBUM AÑADIDO CORRECTAMENTE"
                        lblConfirmacionAlbum.ForeColor = Color.Green
                        lstMis_albumes.Items.Add(AlbumAux.Nombre)
                    End If
                Else
                    MessageBox.Show("No existe el artista especificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        Else
            MessageBox.Show("Por favor, rellene todos los campos obligatorios (*)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnModificarAlbum_Click(sender As Object, e As EventArgs) Handles btnModificarAlbum.Click
        Dim AlbumAux As Album = New Album
        Dim ArtistaAux As Artista = New Artista
        Dim aux As Integer
        Dim rutaImagen As String
        Dim nombreOriginal As String
        Dim indice As Integer
        rutaImagen = String.Empty

        rutaImagen = odfimagen.SafeFileName.ToString

        If txtTituloAlbum.Text IsNot String.Empty And cbArtistaAlbum.SelectedValue IsNot String.Empty And dtpFechaA.Text IsNot String.Empty Then
            Try
                nombreOriginal = lstMis_albumes.SelectedItem

                AlbumAux = New Album(lblIDAl.Text)
                AlbumAux.Nombre = txtTituloAlbum.Text
                AlbumAux.Fecha = dtpFechaA.Value.Date

                ArtistaAux.LeerTodosArtistas()

                For Each A As Artista In ArtistaAux.ArtistaDAO.Artistas
                    If (A.Nombre = cbArtistaAlbum.SelectedItem) Then
                        AlbumAux.Artista = New Artista(A.IdArtista)
                        aux = 1
                    End If
                Next

                If rutaImagen = String.Empty Then
                    MessageBox.Show("Por favor, inserte una imagen", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    AlbumAux.Portada = rutaImagen

                    If aux = 1 Then
                        If AlbumAux.ActualizarAlbum() <> 1 Then
                            MessageBox.Show("Update return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        Else
                            indice = lstMis_albumes.Items.IndexOf(nombreOriginal)
                            lstMis_albumes.Items.Remove(nombreOriginal)
                            lstMis_albumes.Items.Insert(indice, AlbumAux.Nombre)
                            lblConfirmacionAlbum.Text = "ALBUM ACTUALIZADO CORRECTAMENTE"
                            lblConfirmacionAlbum.ForeColor = Color.Green
                        End If
                    Else
                        MessageBox.Show("No existe el album especificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        Else
            MessageBox.Show("Por favor, rellene todos los campos obligatorios (*)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnPulModifAlbum_Click(sender As Object, e As EventArgs) Handles btnPulModifAlbum.Click
        gbAlbumes.Enabled = True
        odfimagen.FileName = String.Empty
        txtTituloAlbum.Enabled = True
        cbArtistaAlbum.Enabled = True
        dtpFechaA.Enabled = True
        btnAnadirAlbum.Enabled = False
        btnModificarAlbum.Enabled = True
        btnEliminarAlbum.Enabled = False
        btnPulAnadirAlbum.Enabled = False
        btnImagenAlbum.Enabled = True
    End Sub

    Private Sub btnEliminarAlbum_Click(sender As Object, e As EventArgs) Handles btnEliminarAlbum.Click
        Dim AlbumAux As Album = New Album
        Dim CancionAux As Cancion = New Cancion
        Dim ReproduccionAux As Reproduccion = New Reproduccion

        gbAlbumes.Enabled = True
        txtTituloAlbum.Enabled = False
        cbArtistaAlbum.Enabled = False
        dtpFechaA.Enabled = False
        btnAnadirImagenArtista.Enabled = False
        btnImagenAlbum.Enabled = False

        If txtTituloAlbum.Text IsNot String.Empty And cbArtistaAlbum.SelectedValue IsNot String.Empty And dtpFechaA.Text IsNot String.Empty Then
            Try
                AlbumAux = New Album(lblIDAl.Text)
                AlbumAux.Nombre = txtTituloAlbum.Text

                CancionAux.LeerTodasCanciones()
                ReproduccionAux.LeerTodasReproducciones()

                If MessageBox.Show("¿Desea eliminar el album '" & AlbumAux.Nombre & "'?", "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    For Each A As Cancion In CancionAux.CancionDAO.Canciones
                        If (A.Album.idAlbum = lblIDAl.Text) Then
                            CancionAux.IdCancion = A.IdCancion
                            For Each B As Reproduccion In ReproduccionAux.ReproduccionDAO.Reproducciones
                                If (B.Cancion.IdCancion = CancionAux.IdCancion) Then
                                    ReproduccionAux.IdReproduccion = B.IdReproduccion
                                    ReproduccionAux.BorrarReproduccion()
                                End If
                            Next
                            CancionAux.BorrarCancion()
                        End If
                    Next

                    If AlbumAux.BorrarAlbum() <> 1 Then
                        MessageBox.Show("Eliminar return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        lblConfirmacionAlbum.Text = "ALBUM ELIMINADO CORRECTAMENTE"
                        lblConfirmacionAlbum.ForeColor = Color.Green
                        lstMis_albumes.Items.Remove(AlbumAux.Nombre)
                        btnLimpiarAlbum.PerformClick()
                    End If

                    For Each A As Album In AlbumAux.AlbumDAO.Album
                        lstMis_albumes.Items.Add(AlbumAux.Nombre)
                    Next
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnLimpiarAlbum_Click() Handles btnLimpiarAlbum.Click
        txtTituloAlbum.Text = String.Empty
        cbArtistaAlbum.SelectedItem = String.Empty
        lblDuracionAlbum.Text = String.Empty
        lblIDAl.Text = String.Empty
        lstMis_albumes.SelectedItem = String.Empty
        pbImagen.Image = Nothing
        dtpFechaA.Value = Date.Now
        lstCanciones_Album.Items.Clear()
        dtpFechaA.Value = Now.ToLongDateString
    End Sub

    Private Sub lstMis_artistas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMis_artistas.SelectedIndexChanged
        lstalbumesArtistas.Items.Clear()
        lstcancionesArtistas.Items.Clear()
        cbMis_artistas.Enabled = True
        txtNombreA.Enabled = False
        txtPaisA.Enabled = False
        btnAnadirArtistas.Enabled = False
        btnModificarArtistas.Enabled = False
        btnEliminarArtistas.Enabled = True
        btnArtistasPul.Enabled = True
        btnModificarArtPul.Enabled = True
        btnAnadirImagenArtista.Enabled = False

        Dim AlbumAux As Album = New Album
        Dim ArtistaAux As Artista = New Artista
        Dim AFavoritoAux As AFavorito = New AFavorito
        Dim aux As Integer
        Dim ruta As String
        Dim rutaGeneral As String

        ruta = Application.StartupPath

        AlbumAux.LeerTodosAlbum()
        ArtistaAux.LeerTodosArtistas()
        AFavoritoAux.LeerTodosAFavorito()

        For Each A As Artista In ArtistaAux.ArtistaDAO.Artistas
            AFavoritoAux.Usuario = New Usuario(Datos.txtUsuario.Text)
            If (lstMis_artistas.SelectedItem = A.Nombre) Then
                cbMis_artistas.Enabled = True
                txtNombreA.Text = A.Nombre
                txtPaisA.Text = A.Pais

                rutaGeneral = ruta & "Imagenes\" & A.Imagen
                pbImagenArtista.ImageLocation = rutaGeneral

                lblIDArtista.Text = A.IdArtista
                aux = A.IdArtista
                AFavoritoAux.LeerAFavorito()
            End If
        Next

        pbFavorito.Visible = False
        pbNoFavorito.Visible = True
        lblFavorito.Text = "Artista NO favorito"
        lblFavorito.ForeColor = Color.DarkRed

        For Each B As AFavorito In AFavoritoAux.AFavoritoDAO.AFavoritos
            If ((Datos.txtUsuario.Text = B.Usuario.Email) And (aux = B.Artista.IdArtista)) Then
                pbFavorito.Visible = True
                pbNoFavorito.Visible = False
                lblFavorito.Text = "Artista favorito"
                lblFavorito.ForeColor = Color.Indigo
            End If
        Next

        For Each B As Album In AlbumAux.AlbumDAO.Album
            If aux = B.Artista.IdArtista Then
                lstalbumesArtistas.Items.Add(B.Nombre)
            End If
        Next
    End Sub

    Private Sub lstalbumesArtistas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstalbumesArtistas.SelectedIndexChanged
        lstcancionesArtistas.Items.Clear()
        Dim CancionAux As Cancion = New Cancion
        Dim AlbumAux As Album = New Album
        Dim aux As Integer

        AlbumAux.LeerTodosAlbum()
        CancionAux.LeerTodasCanciones()

        For Each A As Album In AlbumAux.AlbumDAO.Album
            If (lstalbumesArtistas.SelectedItem = A.Nombre) Then
                aux = A.idAlbum
            End If
        Next

        For Each B As Cancion In CancionAux.CancionDAO.Canciones
            If (aux = B.Album.idAlbum) Then
                lstcancionesArtistas.Items.Add(B.Nombre)
            End If
        Next
    End Sub

    Private Sub pbNoFavorito_Click(sender As Object, e As EventArgs) Handles pbNoFavorito.Click
        Dim AFavoritoAux As AFavorito = New AFavorito
        Dim ArtistaAux As Artista = New Artista
        Dim aux As Integer

        Try
            AFavoritoAux.LeerTodosAFavorito()
            ArtistaAux.LeerTodosArtistas()

            AFavoritoAux.Usuario = New Usuario(Datos.txtUsuario.Text)

            For Each C As Artista In ArtistaAux.ArtistaDAO.Artistas
                If (txtNombreA.Text = C.Nombre) Then
                    aux = C.IdArtista
                End If
            Next

            AFavoritoAux.Artista = New Artista(aux)
            AFavoritoAux.Fecha = DateAndTime.Today
            AFavoritoAux.InsertarAFavorito()
            pbFavorito.Visible = True
            pbNoFavorito.Visible = False
            lblFavorito.Text = "Artista favorito"
            lblFavorito.ForeColor = Color.Indigo

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub pbFavorito_Click(sender As Object, e As EventArgs) Handles pbFavorito.Click
        Dim AFavoritoAux As AFavorito = New AFavorito
        Dim ArtistaAux As Artista = New Artista

        Try
            AFavoritoAux.LeerTodosAFavorito()
            ArtistaAux.LeerTodosArtistas()

            For Each A As Artista In ArtistaAux.ArtistaDAO.Artistas
                If (txtNombreA.Text = A.Nombre) Then
                    AFavoritoAux.Usuario = New Usuario(Datos.txtUsuario.Text)
                    AFavoritoAux.Artista = New Artista(A.IdArtista)
                    AFavoritoAux.LeerAFavorito()
                End If
            Next

            For Each B As AFavorito In AFavoritoAux.AFavoritoDAO.AFavoritos
                If ((Datos.txtUsuario.Text = B.Usuario.Email) And (AFavoritoAux.Artista.IdArtista = B.Artista.IdArtista)) Then
                    B.BorrarAFavoritoEspecifico()
                    pbFavorito.Visible = False
                    pbNoFavorito.Visible = True
                    lblFavorito.Text = "Artista No favorito"
                    lblFavorito.ForeColor = Color.DarkRed
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnEliminarArtistas_Click(sender As Object, e As EventArgs) Handles btnEliminarArtistas.Click
        Dim ArtistaAux As Artista = New Artista
        Dim AlbumAux As Album = New Album
        Dim CancionAux As Cancion = New Cancion
        Dim ReproduccionAux As Reproduccion = New Reproduccion
        Dim AFavoritoAux As AFavorito = New AFavorito
        Dim aux As Integer
        Dim aux2 As Integer
        Dim aux3 As Integer

        cbMis_artistas.Enabled = True
        txtNombreA.Enabled = False
        txtPaisA.Enabled = False
        btnAnadirImagenArtista.Enabled = False

        If txtNombreA.Text IsNot String.Empty And txtPaisA.Text IsNot String.Empty Then
            Try
                ArtistaAux = New Artista(lblIDArtista.Text)

                ArtistaAux.LeerTodosArtistas()
                AlbumAux.LeerTodosAlbum()
                CancionAux.LeerTodasCanciones()
                ReproduccionAux.LeerTodasReproducciones()
                AFavoritoAux.LeerTodosAFavorito()

                ArtistaAux.Nombre = txtNombreA.Text

                If MessageBox.Show("¿Desea eliminar a '" & ArtistaAux.Nombre.ToUpper & "' y todos sus registros relacionados?", "Confirme, por favor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    For Each A As Artista In ArtistaAux.ArtistaDAO.Artistas
                        If (lstMis_artistas.SelectedItem.ToString = A.Nombre) Then
                            AFavoritoAux.Artista = ArtistaAux
                            aux = A.IdArtista
                        End If
                    Next

                    For Each B As Album In AlbumAux.AlbumDAO.Album
                        If (aux = B.Artista.IdArtista) Then
                            AlbumAux.idAlbum = B.idAlbum
                            aux2 = B.idAlbum
                        End If
                    Next

                    For Each C As Cancion In CancionAux.CancionDAO.Canciones
                        If (aux2 = C.Album.idAlbum) Then
                            MessageBox.Show(C.Album.idAlbum)
                            CancionAux.IdCancion = C.IdCancion
                            CancionAux.Album = New Album(aux2)
                            aux3 = C.IdCancion
                        End If
                    Next

                    For Each R As Reproduccion In ReproduccionAux.ReproduccionDAO.Reproducciones
                        If (aux3 = R.Cancion.IdCancion) Then
                            ReproduccionAux.IdReproduccion = R.IdReproduccion
                            ReproduccionAux.Usuario = R.Usuario
                            ReproduccionAux.Cancion = R.Cancion
                            ReproduccionAux.Fecha = R.Fecha
                        End If
                    Next

                    ReproduccionAux.BorrarReproduccion()
                    CancionAux.BorrarCancion()
                    AlbumAux.BorrarAlbum()
                    AFavoritoAux.BorrarAFavorito()

                    If ArtistaAux.BorrarArtista() <> 1 Then
                        MessageBox.Show("Eliminar return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        lblConfirmacionArtista.Text = "ARTISTA ELIMINADO CORRECTAMENTE"
                        lblConfirmacionArtista.ForeColor = Color.Green
                        lstMis_artistas.Items.Remove(ArtistaAux.Nombre)
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnModificarArtistas_Click(sender As Object, e As EventArgs) Handles btnModificarArtistas.Click
        Dim ArtistaAux As Artista = New Artista
        Dim rutaImagen As String
        Dim nombreOriginal As String
        Dim indice As Integer
        rutaImagen = String.Empty

        rutaImagen = odfimagen.SafeFileName.ToString

        If txtNombreA.Text IsNot String.Empty And txtPaisA.Text IsNot String.Empty Then
            Try
                nombreOriginal = lstMis_artistas.SelectedItem

                ArtistaAux = New Artista(lblIDArtista.Text)
                ArtistaAux.Nombre = txtNombreA.Text
                ArtistaAux.Pais = txtPaisA.Text

                If rutaImagen = String.Empty Then
                    MessageBox.Show("Por favor, inserte una imagen", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    ArtistaAux.Imagen = rutaImagen

                    If ArtistaAux.ActualizarArtista() <> 1 Then
                        MessageBox.Show("Update return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        indice = lstMis_artistas.Items.IndexOf(nombreOriginal)
                        lstMis_artistas.Items.Remove(nombreOriginal)
                        lstMis_artistas.Items.Insert(indice, ArtistaAux.Nombre)
                        lblConfirmacionArtista.Text = "DATOS ACTUALIZADOS CORRECTAMENTE"
                        lblConfirmacionArtista.ForeColor = Color.Green
                        btnLimpiarArtista.PerformClick()
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        Else
            MessageBox.Show("Por favor, rellene todos los campos obligatorios (*)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnAnadirArtistas_Click(sender As Object, e As EventArgs) Handles btnAnadirArtistas.Click
        Dim ArtistaAux As Artista = New Artista
        Dim aux As Integer
        Dim rutaImagen As String
        rutaImagen = String.Empty

        cbMis_artistas.Enabled = True
        txtNombreA.Enabled = True
        txtPaisA.Enabled = True
        btnAnadirArtistas.Enabled = True
        btnModificarArtistas.Enabled = False
        btnEliminarArtistas.Enabled = False
        btnArtistasPul.Enabled = True
        btnModificarArtPul.Enabled = False
        btnAnadirImagenArtista.Enabled = True
        btnModificarArtPul.Enabled = False

        rutaImagen = odfimagen.SafeFileName.ToString

        ArtistaAux.LeerTodosArtistas()

        If txtNombreA.Text IsNot String.Empty And txtPaisA.Text IsNot String.Empty And rutaImagen IsNot String.Empty Then
            Try
                For Each A As Artista In ArtistaAux.ArtistaDAO.Artistas
                    aux = A.IdArtista
                Next

                ArtistaAux = New Artista
                ArtistaAux.Nombre = txtNombreA.Text
                ArtistaAux.Pais = txtPaisA.Text
                ArtistaAux.Imagen = rutaImagen

                If ArtistaAux.InsertarArtista() <> 1 Then
                    MessageBox.Show("Insert return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    lblConfirmacionArtista.Text = "ARTISTA AÑADIDO CORRECTAMENTE"
                    lblConfirmacionArtista.ForeColor = Color.Green
                    lstMis_artistas.Items.Add(ArtistaAux.Nombre)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        Else
            MessageBox.Show("Rellene todos los campos obligatorios (*), por favor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        odfimagen.FileName = String.Empty
    End Sub

    Private Sub btnArtistasPul_Click(sender As Object, e As EventArgs) Handles btnArtistasPul.Click
        btnLimpiarArtista.PerformClick()
        odfimagen.FileName = String.Empty
        cbArtistaAlbum.Items.Clear()
        cbMis_artistas.Enabled = True
        txtNombreA.Enabled = True
        txtPaisA.Enabled = True
        btnAnadirArtistas.Enabled = True
        btnModificarArtistas.Enabled = False
        btnEliminarArtistas.Enabled = False
        btnAnadirImagenArtista.Enabled = True
        btnModificarArtPul.Enabled = False
        pbImagenArtista.Image = Nothing
    End Sub

    Private Sub btnModificarArtPul_Click(sender As Object, e As EventArgs) Handles btnModificarArtPul.Click
        cbMis_artistas.Enabled = True
        odfimagen.FileName = String.Empty
        txtNombreA.Enabled = True
        txtPaisA.Enabled = True
        btnAnadirArtistas.Enabled = False
        btnModificarArtistas.Enabled = True
        btnEliminarArtistas.Enabled = False
        btnArtistasPul.Enabled = False
        btnAnadirImagenArtista.Enabled = True
    End Sub

    Private Sub btnLimpiarArtista_Click(sender As Object, e As EventArgs) Handles btnLimpiarArtista.Click
        txtNombreA.Text = String.Empty
        odfimagen.FileName = String.Empty
        txtPaisA.Text = String.Empty
        lblIDArtista.Text = String.Empty
        pbImagenArtista.Image = Nothing
        lstalbumesArtistas.Items.Clear()
        lstcancionesArtistas.Items.Clear()
    End Sub

    Private Sub lstMis_canciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMis_canciones.SelectedIndexChanged
        cbMis_Canciones.Enabled = True
        txtNombreC.Enabled = False
        cbAlbumC.Enabled = False
        txtDuracionC.Enabled = False
        btnAnadirCancion.Enabled = False
        btnCancionPulsa.Enabled = True
        btnModificarArtistas.Enabled = False
        btnPulModifCancion.Enabled = True
        btnEliminarCancion.Enabled = True
        btnModificarCancion.Enabled = False

        Dim CancionAux As Cancion = New Cancion
        Dim AlbumAux As Album = New Album
        Dim ArtistaAux As Artista = New Artista
        Dim aux As Integer

        Try
            CancionAux.LeerTodasCanciones()
            AlbumAux.LeerTodosAlbum()
            ArtistaAux.LeerTodosArtistas()

            If lstMis_canciones.SelectionMode.One Then
                For Each C As Cancion In CancionAux.CancionDAO.Canciones
                    If (lstMis_canciones.SelectedItem = C.Nombre) Then
                        txtNombreC.Text = C.Nombre
                        lblIDCa.Text = C.IdCancion
                        txtDuracionC.Text = C.Duracion
                        aux = C.Album.idAlbum
                    End If
                Next
                For Each B As Album In AlbumAux.AlbumDAO.Album
                    cbAlbumC.Items.Add(B.Nombre)
                    If (aux = B.idAlbum) Then
                        cbAlbumC.Text = B.Nombre
                    End If
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnPulModifCancion_Click(sender As Object, e As EventArgs) Handles btnPulModifCancion.Click
        cbMis_Canciones.Enabled = True
        txtNombreC.Enabled = True
        cbAlbumC.Enabled = True
        txtDuracionC.Enabled = True
        btnAnadirCancion.Enabled = False
        btnModificarCancion.Enabled = True
        btnEliminarCancion.Enabled = False
        btnCancionPulsa.Enabled = False
    End Sub

    Private Sub btnModificarCancion_Click(sender As Object, e As EventArgs) Handles btnModificarCancion.Click
        Dim AlbumAux As Album = New Album
        Dim CancionAux As Cancion
        Dim aux As Integer
        Dim nombreOriginal As String
        Dim indice As Integer

        cbMis_Canciones.Enabled = True
        txtDuracionC.Enabled = False
        txtNombreC.Enabled = False
        cbAlbumC.Enabled = True

        If txtNombreC.Text IsNot String.Empty And cbAlbumC.Text IsNot String.Empty And txtDuracionC.Text IsNot String.Empty Then
            Try
                nombreOriginal = lstMis_canciones.SelectedItem

                CancionAux = New Cancion(lblIDCa.Text)
                CancionAux.Nombre = txtNombreC.Text
                CancionAux.Duracion = txtDuracionC.Text
                AlbumAux.LeerTodosAlbum()

                For Each A As Album In AlbumAux.AlbumDAO.Album
                    If (A.Nombre = cbAlbumC.Text) Then
                        CancionAux.Album = New Album(A.idAlbum)
                        aux = 1
                    End If
                Next

                If aux = 1 Then
                    If CancionAux.ModificarCancion() <> 1 Then
                        MessageBox.Show("Update return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        indice = lstMis_canciones.Items.IndexOf(nombreOriginal)
                        lstMis_canciones.Items.Remove(nombreOriginal)
                        lstMis_canciones.Items.Insert(indice, CancionAux.Nombre)
                        lblConfirmacionCancion.Text = "DATOS ACTUALIZADOS CORRECTAMENTE"
                        lblConfirmacionCancion.ForeColor = Color.Green
                    End If
                Else
                    MessageBox.Show("No existe el album especificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try

        Else
            MessageBox.Show("Rellene todos los campos obligatorios (*), por favor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnEliminarCancion_Click(sender As Object, e As EventArgs) Handles btnEliminarCancion.Click
        Dim CancionAux As Cancion = New Cancion
        Dim ReproduccionAux As Reproduccion = New Reproduccion

        CancionAux.LeerTodasCanciones()

        If txtNombreC.Text IsNot String.Empty And cbAlbumC.Text IsNot String.Empty And txtDuracionC.Text IsNot String.Empty Then
            Try
                CancionAux = New Cancion(lblIDCa.Text)
                CancionAux.Nombre = txtNombreC.Text

                If MessageBox.Show("¿Desea eliminar la cancion '" & CancionAux.Nombre & "'?", "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    ReproduccionAux.LeerTodasReproducciones()

                    For Each A As Reproduccion In ReproduccionAux.ReproduccionDAO.Reproducciones
                        If (CancionAux.IdCancion = A.Cancion.IdCancion) Then
                            ReproduccionAux.IdReproduccion = A.IdReproduccion
                            ReproduccionAux.BorrarReproduccion()
                        End If
                    Next

                    If CancionAux.BorrarCancion() <> 1 Then
                        MessageBox.Show("Delete return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        lblConfirmacionCancion.Text = "CANCION ELIMINADA CORRECTAMENTE"
                        lblConfirmacionCancion.ForeColor = Color.Green
                        lstMis_canciones.Items.Remove(CancionAux.Nombre)
                        btnLimpiarCancion.PerformClick()
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnAnadirCancion_Click(sender As Object, e As EventArgs) Handles btnAnadirCancion.Click
        cbMis_Canciones.Enabled = True
        txtNombreC.Enabled = True
        txtDuracionC.Enabled = True
        cbAlbumC.Enabled = True
        btnAnadirCancion.Enabled = True
        btnModificarCancion.Enabled = False
        btnEliminarArtistas.Enabled = False
        btnCancionPulsa.Enabled = False
        btnPulModifCancion.Enabled = False

        Dim CancionAux As Cancion = New Cancion
        CancionAux.LeerTodasCanciones()

        Dim AlbumAux As Album = New Album
        AlbumAux.LeerTodosAlbum()

        Dim aux As Integer
        Dim aux1 As Integer

        If txtNombreC.Text IsNot String.Empty And cbAlbumC.Text IsNot String.Empty And txtDuracionC.Text IsNot String.Empty Then
            Try
                For Each A As Cancion In CancionAux.CancionDAO.Canciones
                    aux = A.IdCancion
                Next

                CancionAux = New Cancion
                CancionAux.Nombre = txtNombreC.Text
                CancionAux.Duracion = txtDuracionC.Text

                For Each B As Album In AlbumAux.AlbumDAO.Album
                    If cbAlbumC.Text = B.Nombre Then
                        aux1 = 1
                        CancionAux.Album = New Album(B.idAlbum)
                    End If
                Next

                If aux1 = 1 Then
                    If CancionAux.InsertarCancion() <> 1 Then
                        MessageBox.Show("Insert return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        lblConfirmacionCancion.Text = "CANCION AÑADIDA CORRECTAMENTE"
                        lblConfirmacionCancion.ForeColor = Color.Green
                        lstMis_canciones.Items.Add(CancionAux.Nombre)
                    End If
                Else
                    MessageBox.Show("No existe el album especificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        Else
            MessageBox.Show("Rellene todos los campos obligatorios (*), por favor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnLimpiarC_Click() Handles btnLimpiarCancion.Click
        txtNombreC.Text = String.Empty
        cbAlbumC.Text = String.Empty
        txtDuracionC.Text = String.Empty
        lblConfirmacionCancion.Text = String.Empty
        cbAlbumC.Items.Clear()
    End Sub

    Private Sub btnCancionPulsa_Click(sender As Object, e As EventArgs) Handles btnCancionPulsa.Click
        btnLimpiarC_Click()
        cbMis_Canciones.Enabled = True
        txtNombreC.Enabled = True
        cbAlbumC.Enabled = True
        txtDuracionC.Enabled = True
        btnAnadirCancion.Enabled = True
        btnModificarCancion.Enabled = False
        btnEliminarCancion.Enabled = False
        btnPulModifCancion.Enabled = False

        Dim AlbumAux As Album = New Album

        AlbumAux.LeerTodosAlbum()

        For Each A As Album In AlbumAux.AlbumDAO.Album
            cbAlbumC.Items.Add(A.Nombre)
        Next
    End Sub

    Private Sub lstUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsuarios.SelectedIndexChanged
        Dim UsuarioAux As Usuario = New Usuario
        lstHistorial.Items.Clear()

        Try
            UsuarioAux.LeerTodosUsuarios()

            If lstUsuarios.SelectionMode.One Then
                For Each U As Usuario In UsuarioAux.UsuarioDAO.Usuarios
                    If (lstUsuarios.SelectedItem = U.Email) Then
                        gbDatosUsuario.Enabled = True
                        txtEmail.Text = U.Email
                        txtNombre.Text = U.Nombre
                        txtApellidos.Text = U.Apellidos
                        dtpFechaNacimiento.Value = U.FechaNacimiento
                    End If
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnEliminarCuenta_Click(sender As Object, e As EventArgs) Handles btnEliminarUsuario.Click
        Dim UsuarioAux As Usuario
        Dim AFavoritoAux As AFavorito = New AFavorito
        Dim ReproduccionAux As Reproduccion = New Reproduccion

        Try
            If txtEmail.Text IsNot String.Empty Then
                UsuarioAux = New Usuario(txtEmail.Text)
                AFavoritoAux = New AFavorito(New Usuario(txtEmail.Text))

                If MessageBox.Show("¿Desea eliminar la cuenta " & UsuarioAux.Email & "?", "Por favor, confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    AFavoritoAux.LeerTodosAFavorito()

                    For Each A As AFavorito In AFavoritoAux.AFavoritoDAO.AFavoritos
                        If (txtEmail.Text = A.Usuario.Email) Then
                            AFavoritoAux.Usuario = A.Usuario
                            AFavoritoAux.BorrarAFavoritoUsuario()
                        End If
                    Next

                    ReproduccionAux.LeerTodasReproducciones()

                    For Each B As Reproduccion In ReproduccionAux.ReproduccionDAO.Reproducciones
                        If (txtEmail.Text = B.Usuario.Email) Then
                            ReproduccionAux.IdReproduccion = B.IdReproduccion
                            ReproduccionAux.BorrarReproduccion()
                        End If
                    Next

                    If UsuarioAux.BorrarUsuario() <> 1 Then
                        MessageBox.Show("Delete return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        lstUsuarios.Items.Remove(UsuarioAux.Email)
                    End If
                End If
                btnLimpiar.PerformClick()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub btnModificarUsuario_Click(sender As Object, e As EventArgs) Handles btnModificarUsuario.Click
        Dim UsuarioAux As Usuario
        Dim AFavoritoAux As AFavorito

        If txtEmail.Text IsNot String.Empty And txtNombre.Text IsNot String.Empty And txtApellidos.Text IsNot String.Empty And dtpFechaNacimiento.Text IsNot String.Empty Then
            UsuarioAux = New Usuario(txtEmail.Text)
            AFavoritoAux = New AFavorito(New Usuario(txtEmail.Text))
            UsuarioAux.Nombre = txtNombre.Text
            UsuarioAux.Apellidos = txtApellidos.Text
            UsuarioAux.FechaNacimiento = dtpFechaNacimiento.Value
            Try
                If UsuarioAux.ActualizarUsuario() <> 1 Then
                    MessageBox.Show("Update return <> 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    lblConfirmacion.Text = "DATOS ACTUALIZADOS CORRECTAMENTE"
                    lblConfirmacion.ForeColor = Color.Green
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtEmail.Text = String.Empty
        txtNombre.Text = String.Empty
        txtApellidos.Text = String.Empty
        dtpFechaNacimiento.Text = String.Empty
        lblConfirmacion.Text = String.Empty
    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        Dim ReproduccionAux As Reproduccion = New Reproduccion
        Dim CancionAux As Cancion = New Cancion
        Dim aux As Integer

        lstHistorial.Items.Clear()

        ReproduccionAux.LeerTodasReproducciones()
        CancionAux.LeerTodasCanciones()

        For Each A As Reproduccion In ReproduccionAux.ReproduccionDAO.Reproducciones
            If (txtEmail.Text = A.Usuario.Email) Then
                aux = A.Cancion.IdCancion
                For Each B As Cancion In CancionAux.CancionDAO.Canciones
                    If B.IdCancion = aux Then
                        lstHistorial.Items.Add(B.Nombre)
                    End If
                Next
            End If
        Next
    End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    Dim segundos As Integer
    '    Dim minutos As Integer
    '    Dim horas As Integer

    '    segundos += 1

    '    If segundos > 59 Then
    '        minutos += 1
    '        segundos = 0
    '    End If

    '    If minutos > 59 Then
    '        horas += 1
    '        minutos = 0
    '    End If

    '    lblTranscurrido.Text = Format(horas, "00") & ":" & Format(minutos, "00") & ":" & Format(segundos, "00")
    'End Sub

    Function darFormatoDuracion(duracion As Integer)
        Dim horas As Integer = (duracion / 3600)
        Dim minutos As Integer = ((duracion - horas * 3600) / 60)
        Dim segundos As Integer = duracion - (horas * 3600 + minutos * 60)
        If segundos < 0 Then
            segundos = 0
        End If
        Dim cadena As String = Format(horas, "00") & ":" & Format(minutos, "00") & ":" & Format(segundos, "00")
        Return cadena
    End Function

    Private Sub limpiar()
        lstMis_albumes.Items.Clear()
        lstMis_artistas.Items.Clear()
        lstMis_canciones.Items.Clear()
        lstCanciones_Album.Items.Clear()
        lstUsuarios.Items.Clear()
        cbArtistaAlbum.Items.Clear()
        cbUser.Items.Clear()
        dtpFechaNacimiento.ResetText()
        txtTituloAlbum.Text = String.Empty
        dtpFechaA.Text = String.Empty
        lblDuracionAlbum.Text = String.Empty
        txtEmail.Text = String.Empty
        txtNombre.Text = String.Empty
        txtApellidos.Text = String.Empty
    End Sub

    Private Sub btnImagen_Click(sender As Object, e As EventArgs) Handles btnImagenAlbum.Click
        Dim url As String

        odfimagen = New OpenFileDialog()
        odfimagen.Filter = "Imagenes | *.jpg;*.png;"
        odfimagen.Title = "Abriendo imagen"

        If (odfimagen.ShowDialog() = DialogResult.OK) Then
            url = odfimagen.FileName
            pbImagen.Load(url)
        End If
    End Sub

    Private Sub btnAnadirImagen_Click(sender As Object, e As EventArgs) Handles btnAnadirImagenArtista.Click
        Dim url As String

        odfimagen = New OpenFileDialog()
        odfimagen.Filter = "Imagenes | *.jpg;*.png;"
        odfimagen.Title = "Abriendo imagen"

        If (odfimagen.ShowDialog() = DialogResult.OK) Then
            url = odfimagen.FileName
            pbImagenArtista.Load(url)
        End If
    End Sub

    Private Sub pbPlayInicio_Click_1(sender As Object, e As EventArgs) Handles pbPlayInicio.Click
        Dim ReproduccionAux As Reproduccion = New Reproduccion
        Dim CancionAux As Cancion = New Cancion

        If lblTituloCan.Text IsNot String.Empty Then
            Try
                ReproduccionAux = New Reproduccion
                ReproduccionAux.Usuario = New Usuario(Datos.txtUsuario.Text)

                CancionAux.LeerTodasCanciones()

                For Each A As Cancion In CancionAux.CancionDAO.Canciones
                    If lblTituloCan.Text = A.Nombre Then
                        ReproduccionAux.Cancion = New Cancion(A.IdCancion)
                    End If
                Next

                ReproduccionAux.Fecha = Date.Today
                ReproduccionAux.InsertarReproduccion()
                lblConfirmaA.Text = "AÑADIDA SUS REPRODUCCIONES"
                lblConfirmaA.ForeColor = Color.DarkGreen

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub consultas_Click(sender As Object, e As EventArgs) Handles consultas.Click
        Dim usuario As New Usuario

        For Each u As Usuario In usuario.UsuarioDAO.Usuarios
            cbUser.Items.Add(u.Email)
        Next
    End Sub

    Private Sub btnConsulta1_Click(sender As Object, e As EventArgs) Handles btnConsulta1.Click
        Dim artista As New Artista
        artista.Pais = txtPaisConsulta.Text
        artista.consulta1()

        lstResultados.Items.Clear()

        For Each col As String In artista.ArtistaDAO.Artistas
            lstResultados.Items.Add(col)
        Next
    End Sub

    Private Sub lblConsulta2_Click(sender As Object, e As EventArgs) Handles btnConsulta2.Click
        Dim cancion As New Cancion
        cancion.consulta2()

        lstResultados.Items.Clear()

        For Each col As String In cancion.CancionDAO.Canciones
            lstResultados.Items.Add(col)
        Next
    End Sub

    Private Sub btnConsulta3_Click(sender As Object, e As EventArgs) Handles btnConsulta3.Click
        Dim artista As New Artista
        Dim reproduccion As New Reproduccion
        Dim usuario As New Usuario

        lstResultados.Items.Clear()
        cbUser.Enabled = True
        dtpInicio.Enabled = True
        dtpFin.Enabled = True

        If cbUser.Text IsNot String.Empty And dtpInicio IsNot Nothing And dtpFin IsNot Nothing Then
            reproduccion.Usuario = New Usuario(cbUser.Text)
            reproduccion.Fecha = dtpInicio.Text
            reproduccion.Fecha = dtpFin.Text
            reproduccion.consulta3()
        Else
            MessageBox.Show("RELLENE TODOS LOS DATOS")
        End If

        For Each col As String In reproduccion.ReproduccionDAO.Reproducciones
            lstResultados.Items.Add(col)
        Next
    End Sub

    Private Sub btnConsulta4_Click(sender As Object, e As EventArgs) Handles btnConsulta4.Click
        Dim usuario As New Usuario
        usuario.consulta4()

        lstResultados.Items.Clear()

        For Each col As String In usuario.UsuarioDAO.Usuarios
            lstResultados.Items.Add(col)
        Next
    End Sub

    Private Sub btnConsulta5_Click(sender As Object, e As EventArgs) Handles btnConsulta5.Click
        Dim reproduccion As New Reproduccion
        Dim AFavorito As New AFavorito

        lstResultados.Items.Clear()

        AFavorito.consulta5(reproduccion)

        For Each col As String In AFavorito.AFavoritoDAO.AFavoritos
            lstResultados.Items.Add(col)
        Next
    End Sub

End Class