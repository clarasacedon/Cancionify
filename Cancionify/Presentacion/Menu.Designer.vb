<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.tbcMenu = New System.Windows.Forms.TabControl()
        Me.tbpInicio = New System.Windows.Forms.TabPage()
        Me.gbInfoCancion = New System.Windows.Forms.GroupBox()
        Me.lblConfirmaA = New System.Windows.Forms.Label()
        Me.pbPlayInicio = New System.Windows.Forms.PictureBox()
        Me.pbPauseInicio = New System.Windows.Forms.PictureBox()
        Me.lblDuracionCan = New System.Windows.Forms.Label()
        Me.pbSiguienteInicio = New System.Windows.Forms.PictureBox()
        Me.pbAnteriorInicio = New System.Windows.Forms.PictureBox()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.lblAlbumCan = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblTituloCan = New System.Windows.Forms.Label()
        Me.gbInfoArt = New System.Windows.Forms.GroupBox()
        Me.lblTextoArtista = New System.Windows.Forms.Label()
        Me.pbArtista = New System.Windows.Forms.PictureBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.pcFavoritoArt = New System.Windows.Forms.PictureBox()
        Me.pcNoFavArt = New System.Windows.Forms.PictureBox()
        Me.lblNombreArt = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblPaisArt = New System.Windows.Forms.Label()
        Me.gbInfoAlbum = New System.Windows.Forms.GroupBox()
        Me.lblArtistaAlb = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pbAlbum = New System.Windows.Forms.PictureBox()
        Me.lblDuracionAlb = New System.Windows.Forms.Label()
        Me.lblTituloAlb = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblFechaAlb = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblBienvenida = New System.Windows.Forms.Label()
        Me.lstCanciones = New System.Windows.Forms.ListBox()
        Me.lstAlbumes = New System.Windows.Forms.ListBox()
        Me.lstArtistas = New System.Windows.Forms.ListBox()
        Me.tbpPlaylists = New System.Windows.Forms.TabPage()
        Me.gbAlbumes = New System.Windows.Forms.GroupBox()
        Me.btnModificarAlbum = New System.Windows.Forms.Button()
        Me.btnImagenAlbum = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCanciones = New System.Windows.Forms.Label()
        Me.lblDuracionAlbum = New System.Windows.Forms.Label()
        Me.lstCanciones_Album = New System.Windows.Forms.ListBox()
        Me.lblIDA = New System.Windows.Forms.Label()
        Me.txtTituloAlbum = New System.Windows.Forms.TextBox()
        Me.dtpFechaA = New System.Windows.Forms.DateTimePicker()
        Me.btnAnadirAlbum = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblIDAl = New System.Windows.Forms.Label()
        Me.lblArtista = New System.Windows.Forms.Label()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.cbArtistaAlbum = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPulAnadirAlbum = New System.Windows.Forms.Button()
        Me.btnLimpiarAlbum = New System.Windows.Forms.Button()
        Me.lblConfirmacionAlbum = New System.Windows.Forms.Label()
        Me.lstMis_albumes = New System.Windows.Forms.ListBox()
        Me.btnEliminarAlbum = New System.Windows.Forms.Button()
        Me.btnPulModifAlbum = New System.Windows.Forms.Button()
        Me.tbpArtistas = New System.Windows.Forms.TabPage()
        Me.btnModificarArtPul = New System.Windows.Forms.Button()
        Me.lblConfirmacionArtista = New System.Windows.Forms.Label()
        Me.btnLimpiarArtista = New System.Windows.Forms.Button()
        Me.btnArtistasPul = New System.Windows.Forms.Button()
        Me.cbMis_artistas = New System.Windows.Forms.GroupBox()
        Me.btnAnadirImagenArtista = New System.Windows.Forms.Button()
        Me.lblIDArtista = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAnadirArtistas = New System.Windows.Forms.Button()
        Me.txtPaisA = New System.Windows.Forms.TextBox()
        Me.txtNombreA = New System.Windows.Forms.TextBox()
        Me.lblFavorito = New System.Windows.Forms.Label()
        Me.btnModificarArtistas = New System.Windows.Forms.Button()
        Me.lstalbumesArtistas = New System.Windows.Forms.ListBox()
        Me.lblAlbumes = New System.Windows.Forms.Label()
        Me.pbNoFavorito = New System.Windows.Forms.PictureBox()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.pbFavorito = New System.Windows.Forms.PictureBox()
        Me.lstcancionesArtistas = New System.Windows.Forms.ListBox()
        Me.lblCancionesArtista = New System.Windows.Forms.Label()
        Me.lblNombreArtista = New System.Windows.Forms.Label()
        Me.pbImagenArtista = New System.Windows.Forms.PictureBox()
        Me.lstMis_artistas = New System.Windows.Forms.ListBox()
        Me.btnEliminarArtistas = New System.Windows.Forms.Button()
        Me.tbpCanciones = New System.Windows.Forms.TabPage()
        Me.lblConfirmacionCancion = New System.Windows.Forms.Label()
        Me.btnCancionPulsa = New System.Windows.Forms.Button()
        Me.btnLimpiarCancion = New System.Windows.Forms.Button()
        Me.cbMis_Canciones = New System.Windows.Forms.GroupBox()
        Me.btnModificarCancion = New System.Windows.Forms.Button()
        Me.cbAlbumC = New System.Windows.Forms.ComboBox()
        Me.lblIDCa = New System.Windows.Forms.Label()
        Me.lblIDC = New System.Windows.Forms.Label()
        Me.lblNombreC = New System.Windows.Forms.Label()
        Me.lblAlbumC = New System.Windows.Forms.Label()
        Me.txtDuracionC = New System.Windows.Forms.TextBox()
        Me.lblDuracionC = New System.Windows.Forms.Label()
        Me.btnAnadirCancion = New System.Windows.Forms.Button()
        Me.txtNombreC = New System.Windows.Forms.TextBox()
        Me.lstMis_canciones = New System.Windows.Forms.ListBox()
        Me.btnEliminarCancion = New System.Windows.Forms.Button()
        Me.btnPulModifCancion = New System.Windows.Forms.Button()
        Me.tbpCuenta = New System.Windows.Forms.TabPage()
        Me.lblHistorial = New System.Windows.Forms.Label()
        Me.lstHistorial = New System.Windows.Forms.ListBox()
        Me.gbDatosUsuario = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lblTituloCuenta = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblConfirmacion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnHistorial = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnEliminarUsuario = New System.Windows.Forms.Button()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.btnModificarUsuario = New System.Windows.Forms.Button()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lstUsuarios = New System.Windows.Forms.ListBox()
        Me.lblUsuariosTotal = New System.Windows.Forms.Label()
        Me.consultas = New System.Windows.Forms.TabPage()
        Me.btnConsulta5 = New System.Windows.Forms.Button()
        Me.btnConsulta4 = New System.Windows.Forms.Button()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.cbUser = New System.Windows.Forms.ComboBox()
        Me.btnConsulta3 = New System.Windows.Forms.Button()
        Me.btnConsulta2 = New System.Windows.Forms.Button()
        Me.lstResultados = New System.Windows.Forms.ListBox()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.txtPaisConsulta = New System.Windows.Forms.TextBox()
        Me.btnConsulta1 = New System.Windows.Forms.Button()
        Me.ImageListPestanas = New System.Windows.Forms.ImageList(Me.components)
        Me.btnCambiar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.odfimagen = New System.Windows.Forms.OpenFileDialog()
        Me.tbcMenu.SuspendLayout()
        Me.tbpInicio.SuspendLayout()
        Me.gbInfoCancion.SuspendLayout()
        CType(Me.pbPlayInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPauseInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSiguienteInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAnteriorInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInfoArt.SuspendLayout()
        CType(Me.pbArtista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcFavoritoArt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcNoFavArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInfoAlbum.SuspendLayout()
        CType(Me.pbAlbum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpPlaylists.SuspendLayout()
        Me.gbAlbumes.SuspendLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpArtistas.SuspendLayout()
        Me.cbMis_artistas.SuspendLayout()
        CType(Me.pbNoFavorito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFavorito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImagenArtista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpCanciones.SuspendLayout()
        Me.cbMis_Canciones.SuspendLayout()
        Me.tbpCuenta.SuspendLayout()
        Me.gbDatosUsuario.SuspendLayout()
        Me.consultas.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcMenu
        '
        Me.tbcMenu.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tbcMenu.Controls.Add(Me.tbpInicio)
        Me.tbcMenu.Controls.Add(Me.tbpPlaylists)
        Me.tbcMenu.Controls.Add(Me.tbpArtistas)
        Me.tbcMenu.Controls.Add(Me.tbpCanciones)
        Me.tbcMenu.Controls.Add(Me.tbpCuenta)
        Me.tbcMenu.Controls.Add(Me.consultas)
        Me.tbcMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbcMenu.HotTrack = True
        Me.tbcMenu.ImageList = Me.ImageListPestanas
        Me.tbcMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tbcMenu.Location = New System.Drawing.Point(12, 12)
        Me.tbcMenu.Multiline = True
        Me.tbcMenu.Name = "tbcMenu"
        Me.tbcMenu.SelectedIndex = 0
        Me.tbcMenu.Size = New System.Drawing.Size(723, 426)
        Me.tbcMenu.TabIndex = 1
        '
        'tbpInicio
        '
        Me.tbpInicio.Controls.Add(Me.gbInfoCancion)
        Me.tbpInicio.Controls.Add(Me.gbInfoArt)
        Me.tbpInicio.Controls.Add(Me.gbInfoAlbum)
        Me.tbpInicio.Controls.Add(Me.lblBienvenida)
        Me.tbpInicio.Controls.Add(Me.lstCanciones)
        Me.tbpInicio.Controls.Add(Me.lstAlbumes)
        Me.tbpInicio.Controls.Add(Me.lstArtistas)
        Me.tbpInicio.ImageIndex = 0
        Me.tbpInicio.Location = New System.Drawing.Point(4, 29)
        Me.tbpInicio.Name = "tbpInicio"
        Me.tbpInicio.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpInicio.Size = New System.Drawing.Size(715, 393)
        Me.tbpInicio.TabIndex = 0
        Me.tbpInicio.Text = "Inicio"
        Me.tbpInicio.UseVisualStyleBackColor = True
        '
        'gbInfoCancion
        '
        Me.gbInfoCancion.Controls.Add(Me.lblConfirmaA)
        Me.gbInfoCancion.Controls.Add(Me.pbPlayInicio)
        Me.gbInfoCancion.Controls.Add(Me.pbPauseInicio)
        Me.gbInfoCancion.Controls.Add(Me.lblDuracionCan)
        Me.gbInfoCancion.Controls.Add(Me.pbSiguienteInicio)
        Me.gbInfoCancion.Controls.Add(Me.pbAnteriorInicio)
        Me.gbInfoCancion.Controls.Add(Me.TrackBar2)
        Me.gbInfoCancion.Controls.Add(Me.lblAlbumCan)
        Me.gbInfoCancion.Controls.Add(Me.Label11)
        Me.gbInfoCancion.Controls.Add(Me.lblTituloCan)
        Me.gbInfoCancion.Location = New System.Drawing.Point(480, 225)
        Me.gbInfoCancion.Name = "gbInfoCancion"
        Me.gbInfoCancion.Size = New System.Drawing.Size(217, 160)
        Me.gbInfoCancion.TabIndex = 29
        Me.gbInfoCancion.TabStop = False
        Me.gbInfoCancion.Text = "INFO CANCION"
        Me.gbInfoCancion.Visible = False
        '
        'lblConfirmaA
        '
        Me.lblConfirmaA.AutoSize = True
        Me.lblConfirmaA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblConfirmaA.Location = New System.Drawing.Point(6, 133)
        Me.lblConfirmaA.Name = "lblConfirmaA"
        Me.lblConfirmaA.Size = New System.Drawing.Size(0, 17)
        Me.lblConfirmaA.TabIndex = 46
        '
        'pbPlayInicio
        '
        Me.pbPlayInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbPlayInicio.Image = CType(resources.GetObject("pbPlayInicio.Image"), System.Drawing.Image)
        Me.pbPlayInicio.Location = New System.Drawing.Point(98, 102)
        Me.pbPlayInicio.Name = "pbPlayInicio"
        Me.pbPlayInicio.Size = New System.Drawing.Size(22, 22)
        Me.pbPlayInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbPlayInicio.TabIndex = 45
        Me.pbPlayInicio.TabStop = False
        '
        'pbPauseInicio
        '
        Me.pbPauseInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbPauseInicio.Image = CType(resources.GetObject("pbPauseInicio.Image"), System.Drawing.Image)
        Me.pbPauseInicio.Location = New System.Drawing.Point(98, 102)
        Me.pbPauseInicio.Name = "pbPauseInicio"
        Me.pbPauseInicio.Size = New System.Drawing.Size(22, 22)
        Me.pbPauseInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbPauseInicio.TabIndex = 44
        Me.pbPauseInicio.TabStop = False
        '
        'lblDuracionCan
        '
        Me.lblDuracionCan.AutoSize = True
        Me.lblDuracionCan.Location = New System.Drawing.Point(166, 102)
        Me.lblDuracionCan.Name = "lblDuracionCan"
        Me.lblDuracionCan.Size = New System.Drawing.Size(39, 17)
        Me.lblDuracionCan.TabIndex = 43
        Me.lblDuracionCan.Text = "Label"
        '
        'pbSiguienteInicio
        '
        Me.pbSiguienteInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbSiguienteInicio.Image = CType(resources.GetObject("pbSiguienteInicio.Image"), System.Drawing.Image)
        Me.pbSiguienteInicio.Location = New System.Drawing.Point(126, 102)
        Me.pbSiguienteInicio.Name = "pbSiguienteInicio"
        Me.pbSiguienteInicio.Size = New System.Drawing.Size(22, 22)
        Me.pbSiguienteInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbSiguienteInicio.TabIndex = 41
        Me.pbSiguienteInicio.TabStop = False
        '
        'pbAnteriorInicio
        '
        Me.pbAnteriorInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAnteriorInicio.Image = CType(resources.GetObject("pbAnteriorInicio.Image"), System.Drawing.Image)
        Me.pbAnteriorInicio.Location = New System.Drawing.Point(70, 102)
        Me.pbAnteriorInicio.Name = "pbAnteriorInicio"
        Me.pbAnteriorInicio.Size = New System.Drawing.Size(22, 22)
        Me.pbAnteriorInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbAnteriorInicio.TabIndex = 39
        Me.pbAnteriorInicio.TabStop = False
        '
        'TrackBar2
        '
        Me.TrackBar2.LargeChange = 3
        Me.TrackBar2.Location = New System.Drawing.Point(0, 85)
        Me.TrackBar2.Maximum = 2
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(217, 45)
        Me.TrackBar2.TabIndex = 2
        Me.TrackBar2.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'lblAlbumCan
        '
        Me.lblAlbumCan.AutoSize = True
        Me.lblAlbumCan.Location = New System.Drawing.Point(6, 38)
        Me.lblAlbumCan.Name = "lblAlbumCan"
        Me.lblAlbumCan.Size = New System.Drawing.Size(39, 17)
        Me.lblAlbumCan.TabIndex = 38
        Me.lblAlbumCan.Text = "Label"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 17)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "ALBUM:"
        '
        'lblTituloCan
        '
        Me.lblTituloCan.AutoSize = True
        Me.lblTituloCan.Location = New System.Drawing.Point(6, 67)
        Me.lblTituloCan.Name = "lblTituloCan"
        Me.lblTituloCan.Size = New System.Drawing.Size(39, 17)
        Me.lblTituloCan.TabIndex = 30
        Me.lblTituloCan.Text = "Label"
        '
        'gbInfoArt
        '
        Me.gbInfoArt.Controls.Add(Me.lblTextoArtista)
        Me.gbInfoArt.Controls.Add(Me.pbArtista)
        Me.gbInfoArt.Controls.Add(Me.Label23)
        Me.gbInfoArt.Controls.Add(Me.pcFavoritoArt)
        Me.gbInfoArt.Controls.Add(Me.pcNoFavArt)
        Me.gbInfoArt.Controls.Add(Me.lblNombreArt)
        Me.gbInfoArt.Controls.Add(Me.Label21)
        Me.gbInfoArt.Controls.Add(Me.lblPaisArt)
        Me.gbInfoArt.Location = New System.Drawing.Point(16, 225)
        Me.gbInfoArt.Name = "gbInfoArt"
        Me.gbInfoArt.Size = New System.Drawing.Size(209, 160)
        Me.gbInfoArt.TabIndex = 28
        Me.gbInfoArt.TabStop = False
        Me.gbInfoArt.Text = "INFO ARTISTA"
        Me.gbInfoArt.Visible = False
        '
        'lblTextoArtista
        '
        Me.lblTextoArtista.AutoSize = True
        Me.lblTextoArtista.Location = New System.Drawing.Point(80, 126)
        Me.lblTextoArtista.Name = "lblTextoArtista"
        Me.lblTextoArtista.Size = New System.Drawing.Size(46, 17)
        Me.lblTextoArtista.TabIndex = 37
        Me.lblTextoArtista.Text = "Label2"
        '
        'pbArtista
        '
        Me.pbArtista.Cursor = System.Windows.Forms.Cursors.No
        Me.pbArtista.Location = New System.Drawing.Point(136, 17)
        Me.pbArtista.Name = "pbArtista"
        Me.pbArtista.Size = New System.Drawing.Size(67, 38)
        Me.pbArtista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbArtista.TabIndex = 36
        Me.pbArtista.TabStop = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 67)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(65, 17)
        Me.Label23.TabIndex = 29
        Me.Label23.Text = "NOMBRE:"
        '
        'pcFavoritoArt
        '
        Me.pcFavoritoArt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcFavoritoArt.Image = CType(resources.GetObject("pcFavoritoArt.Image"), System.Drawing.Image)
        Me.pcFavoritoArt.Location = New System.Drawing.Point(8, 123)
        Me.pcFavoritoArt.Name = "pcFavoritoArt"
        Me.pcFavoritoArt.Size = New System.Drawing.Size(32, 25)
        Me.pcFavoritoArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcFavoritoArt.TabIndex = 33
        Me.pcFavoritoArt.TabStop = False
        '
        'pcNoFavArt
        '
        Me.pcNoFavArt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcNoFavArt.Image = CType(resources.GetObject("pcNoFavArt.Image"), System.Drawing.Image)
        Me.pcNoFavArt.Location = New System.Drawing.Point(8, 123)
        Me.pcNoFavArt.Name = "pcNoFavArt"
        Me.pcNoFavArt.Size = New System.Drawing.Size(32, 25)
        Me.pcNoFavArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcNoFavArt.TabIndex = 34
        Me.pcNoFavArt.TabStop = False
        '
        'lblNombreArt
        '
        Me.lblNombreArt.AutoSize = True
        Me.lblNombreArt.Location = New System.Drawing.Point(80, 67)
        Me.lblNombreArt.Name = "lblNombreArt"
        Me.lblNombreArt.Size = New System.Drawing.Size(39, 17)
        Me.lblNombreArt.TabIndex = 30
        Me.lblNombreArt.Text = "Label"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 92)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(35, 17)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "PAÍS:"
        '
        'lblPaisArt
        '
        Me.lblPaisArt.AutoSize = True
        Me.lblPaisArt.Location = New System.Drawing.Point(80, 92)
        Me.lblPaisArt.Name = "lblPaisArt"
        Me.lblPaisArt.Size = New System.Drawing.Size(39, 17)
        Me.lblPaisArt.TabIndex = 32
        Me.lblPaisArt.Text = "Label"
        '
        'gbInfoAlbum
        '
        Me.gbInfoAlbum.Controls.Add(Me.lblArtistaAlb)
        Me.gbInfoAlbum.Controls.Add(Me.Label10)
        Me.gbInfoAlbum.Controls.Add(Me.pbAlbum)
        Me.gbInfoAlbum.Controls.Add(Me.lblDuracionAlb)
        Me.gbInfoAlbum.Controls.Add(Me.lblTituloAlb)
        Me.gbInfoAlbum.Controls.Add(Me.Label9)
        Me.gbInfoAlbum.Controls.Add(Me.lblFechaAlb)
        Me.gbInfoAlbum.Controls.Add(Me.Label8)
        Me.gbInfoAlbum.Controls.Add(Me.Label7)
        Me.gbInfoAlbum.Location = New System.Drawing.Point(249, 225)
        Me.gbInfoAlbum.Name = "gbInfoAlbum"
        Me.gbInfoAlbum.Size = New System.Drawing.Size(210, 160)
        Me.gbInfoAlbum.TabIndex = 4
        Me.gbInfoAlbum.TabStop = False
        Me.gbInfoAlbum.Text = "INFO ALBUM"
        Me.gbInfoAlbum.Visible = False
        '
        'lblArtistaAlb
        '
        Me.lblArtistaAlb.AutoSize = True
        Me.lblArtistaAlb.Location = New System.Drawing.Point(64, 136)
        Me.lblArtistaAlb.Name = "lblArtistaAlb"
        Me.lblArtistaAlb.Size = New System.Drawing.Size(46, 17)
        Me.lblArtistaAlb.TabIndex = 27
        Me.lblArtistaAlb.Text = "Label5"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "TITULO:"
        '
        'pbAlbum
        '
        Me.pbAlbum.Cursor = System.Windows.Forms.Cursors.No
        Me.pbAlbum.Location = New System.Drawing.Point(141, 11)
        Me.pbAlbum.Name = "pbAlbum"
        Me.pbAlbum.Size = New System.Drawing.Size(63, 44)
        Me.pbAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAlbum.TabIndex = 36
        Me.pbAlbum.TabStop = False
        '
        'lblDuracionAlb
        '
        Me.lblDuracionAlb.AutoSize = True
        Me.lblDuracionAlb.Location = New System.Drawing.Point(82, 73)
        Me.lblDuracionAlb.Name = "lblDuracionAlb"
        Me.lblDuracionAlb.Size = New System.Drawing.Size(46, 17)
        Me.lblDuracionAlb.TabIndex = 26
        Me.lblDuracionAlb.Text = "Label5"
        '
        'lblTituloAlb
        '
        Me.lblTituloAlb.AutoSize = True
        Me.lblTituloAlb.Location = New System.Drawing.Point(59, 114)
        Me.lblTituloAlb.Name = "lblTituloAlb"
        Me.lblTituloAlb.Size = New System.Drawing.Size(46, 17)
        Me.lblTituloAlb.TabIndex = 25
        Me.lblTituloAlb.Text = "Label5"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "ARTISTA:"
        '
        'lblFechaAlb
        '
        Me.lblFechaAlb.AutoSize = True
        Me.lblFechaAlb.Location = New System.Drawing.Point(59, 30)
        Me.lblFechaAlb.Name = "lblFechaAlb"
        Me.lblFechaAlb.Size = New System.Drawing.Size(46, 17)
        Me.lblFechaAlb.TabIndex = 24
        Me.lblFechaAlb.Text = "Label5"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 34)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "DURACIÓN:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(h:min:seg)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "FECHA:"
        '
        'lblBienvenida
        '
        Me.lblBienvenida.AutoSize = True
        Me.lblBienvenida.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBienvenida.Location = New System.Drawing.Point(15, 9)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(88, 32)
        Me.lblBienvenida.TabIndex = 3
        Me.lblBienvenida.Text = "Label2"
        '
        'lstCanciones
        '
        Me.lstCanciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstCanciones.FormattingEnabled = True
        Me.lstCanciones.ItemHeight = 17
        Me.lstCanciones.Location = New System.Drawing.Point(480, 55)
        Me.lstCanciones.Name = "lstCanciones"
        Me.lstCanciones.Size = New System.Drawing.Size(217, 140)
        Me.lstCanciones.TabIndex = 2
        '
        'lstAlbumes
        '
        Me.lstAlbumes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstAlbumes.FormattingEnabled = True
        Me.lstAlbumes.ItemHeight = 17
        Me.lstAlbumes.Location = New System.Drawing.Point(249, 55)
        Me.lstAlbumes.Name = "lstAlbumes"
        Me.lstAlbumes.Size = New System.Drawing.Size(210, 140)
        Me.lstAlbumes.TabIndex = 1
        '
        'lstArtistas
        '
        Me.lstArtistas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstArtistas.FormattingEnabled = True
        Me.lstArtistas.ItemHeight = 17
        Me.lstArtistas.Location = New System.Drawing.Point(15, 55)
        Me.lstArtistas.Name = "lstArtistas"
        Me.lstArtistas.Size = New System.Drawing.Size(210, 140)
        Me.lstArtistas.TabIndex = 0
        '
        'tbpPlaylists
        '
        Me.tbpPlaylists.Controls.Add(Me.gbAlbumes)
        Me.tbpPlaylists.Controls.Add(Me.btnPulAnadirAlbum)
        Me.tbpPlaylists.Controls.Add(Me.btnLimpiarAlbum)
        Me.tbpPlaylists.Controls.Add(Me.lblConfirmacionAlbum)
        Me.tbpPlaylists.Controls.Add(Me.lstMis_albumes)
        Me.tbpPlaylists.Controls.Add(Me.btnEliminarAlbum)
        Me.tbpPlaylists.Controls.Add(Me.btnPulModifAlbum)
        Me.tbpPlaylists.ImageIndex = 1
        Me.tbpPlaylists.Location = New System.Drawing.Point(4, 29)
        Me.tbpPlaylists.Name = "tbpPlaylists"
        Me.tbpPlaylists.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpPlaylists.Size = New System.Drawing.Size(715, 393)
        Me.tbpPlaylists.TabIndex = 2
        Me.tbpPlaylists.Text = "Albumes"
        Me.tbpPlaylists.UseVisualStyleBackColor = True
        '
        'gbAlbumes
        '
        Me.gbAlbumes.Controls.Add(Me.btnModificarAlbum)
        Me.gbAlbumes.Controls.Add(Me.btnImagenAlbum)
        Me.gbAlbumes.Controls.Add(Me.Label1)
        Me.gbAlbumes.Controls.Add(Me.lblCanciones)
        Me.gbAlbumes.Controls.Add(Me.lblDuracionAlbum)
        Me.gbAlbumes.Controls.Add(Me.lstCanciones_Album)
        Me.gbAlbumes.Controls.Add(Me.lblIDA)
        Me.gbAlbumes.Controls.Add(Me.txtTituloAlbum)
        Me.gbAlbumes.Controls.Add(Me.dtpFechaA)
        Me.gbAlbumes.Controls.Add(Me.btnAnadirAlbum)
        Me.gbAlbumes.Controls.Add(Me.lblTitulo)
        Me.gbAlbumes.Controls.Add(Me.lblIDAl)
        Me.gbAlbumes.Controls.Add(Me.lblArtista)
        Me.gbAlbumes.Controls.Add(Me.pbImagen)
        Me.gbAlbumes.Controls.Add(Me.cbArtistaAlbum)
        Me.gbAlbumes.Controls.Add(Me.Label4)
        Me.gbAlbumes.Enabled = False
        Me.gbAlbumes.Location = New System.Drawing.Point(263, 5)
        Me.gbAlbumes.Name = "gbAlbumes"
        Me.gbAlbumes.Size = New System.Drawing.Size(436, 383)
        Me.gbAlbumes.TabIndex = 31
        Me.gbAlbumes.TabStop = False
        '
        'btnModificarAlbum
        '
        Me.btnModificarAlbum.Location = New System.Drawing.Point(16, 323)
        Me.btnModificarAlbum.Name = "btnModificarAlbum"
        Me.btnModificarAlbum.Size = New System.Drawing.Size(192, 54)
        Me.btnModificarAlbum.TabIndex = 32
        Me.btnModificarAlbum.Text = "GUARDAR CAMBIOS"
        Me.btnModificarAlbum.UseVisualStyleBackColor = True
        '
        'btnImagenAlbum
        '
        Me.btnImagenAlbum.Location = New System.Drawing.Point(6, 159)
        Me.btnImagenAlbum.Name = "btnImagenAlbum"
        Me.btnImagenAlbum.Size = New System.Drawing.Size(117, 34)
        Me.btnImagenAlbum.TabIndex = 28
        Me.btnImagenAlbum.Text = "AÑADIR IMAGEN"
        Me.btnImagenAlbum.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(6, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 34)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "DURACIÓN:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(h:min:seg)"
        '
        'lblCanciones
        '
        Me.lblCanciones.AutoSize = True
        Me.lblCanciones.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblCanciones.Location = New System.Drawing.Point(6, 201)
        Me.lblCanciones.Name = "lblCanciones"
        Me.lblCanciones.Size = New System.Drawing.Size(85, 17)
        Me.lblCanciones.TabIndex = 6
        Me.lblCanciones.Text = "CANCIONES:"
        '
        'lblDuracionAlbum
        '
        Me.lblDuracionAlbum.AutoSize = True
        Me.lblDuracionAlbum.Location = New System.Drawing.Point(92, 113)
        Me.lblDuracionAlbum.Name = "lblDuracionAlbum"
        Me.lblDuracionAlbum.Size = New System.Drawing.Size(46, 17)
        Me.lblDuracionAlbum.TabIndex = 18
        Me.lblDuracionAlbum.Text = "Label5"
        '
        'lstCanciones_Album
        '
        Me.lstCanciones_Album.FormattingEnabled = True
        Me.lstCanciones_Album.ItemHeight = 17
        Me.lstCanciones_Album.Location = New System.Drawing.Point(6, 228)
        Me.lstCanciones_Album.Name = "lstCanciones_Album"
        Me.lstCanciones_Album.Size = New System.Drawing.Size(400, 89)
        Me.lstCanciones_Album.TabIndex = 12
        '
        'lblIDA
        '
        Me.lblIDA.AutoSize = True
        Me.lblIDA.Location = New System.Drawing.Point(335, 128)
        Me.lblIDA.Name = "lblIDA"
        Me.lblIDA.Size = New System.Drawing.Size(27, 17)
        Me.lblIDA.TabIndex = 27
        Me.lblIDA.Text = "ID :"
        '
        'txtTituloAlbum
        '
        Me.txtTituloAlbum.Location = New System.Drawing.Point(70, 22)
        Me.txtTituloAlbum.Name = "txtTituloAlbum"
        Me.txtTituloAlbum.Size = New System.Drawing.Size(225, 25)
        Me.txtTituloAlbum.TabIndex = 20
        '
        'dtpFechaA
        '
        Me.dtpFechaA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaA.Location = New System.Drawing.Point(69, 80)
        Me.dtpFechaA.Name = "dtpFechaA"
        Me.dtpFechaA.Size = New System.Drawing.Size(226, 25)
        Me.dtpFechaA.TabIndex = 7
        Me.dtpFechaA.Value = New Date(2021, 4, 19, 0, 0, 0, 0)
        '
        'btnAnadirAlbum
        '
        Me.btnAnadirAlbum.Location = New System.Drawing.Point(214, 323)
        Me.btnAnadirAlbum.Name = "btnAnadirAlbum"
        Me.btnAnadirAlbum.Size = New System.Drawing.Size(192, 54)
        Me.btnAnadirAlbum.TabIndex = 1
        Me.btnAnadirAlbum.Text = "GUARDAR NUEVO ALBUM"
        Me.btnAnadirAlbum.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(6, 25)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(58, 17)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "*TITULO:"
        '
        'lblIDAl
        '
        Me.lblIDAl.AutoSize = True
        Me.lblIDAl.Location = New System.Drawing.Point(365, 128)
        Me.lblIDAl.Name = "lblIDAl"
        Me.lblIDAl.Size = New System.Drawing.Size(46, 17)
        Me.lblIDAl.TabIndex = 25
        Me.lblIDAl.Text = "Label2"
        '
        'lblArtista
        '
        Me.lblArtista.AutoSize = True
        Me.lblArtista.Location = New System.Drawing.Point(6, 54)
        Me.lblArtista.Name = "lblArtista"
        Me.lblArtista.Size = New System.Drawing.Size(62, 17)
        Me.lblArtista.TabIndex = 5
        Me.lblArtista.Text = "*ARTISTA:"
        '
        'pbImagen
        '
        Me.pbImagen.Cursor = System.Windows.Forms.Cursors.No
        Me.pbImagen.Location = New System.Drawing.Point(317, 20)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(113, 105)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagen.TabIndex = 10
        Me.pbImagen.TabStop = False
        '
        'cbArtistaAlbum
        '
        Me.cbArtistaAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbArtistaAlbum.FormattingEnabled = True
        Me.cbArtistaAlbum.Location = New System.Drawing.Point(70, 51)
        Me.cbArtistaAlbum.Name = "cbArtistaAlbum"
        Me.cbArtistaAlbum.Size = New System.Drawing.Size(225, 25)
        Me.cbArtistaAlbum.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(6, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "*FECHA:"
        '
        'btnPulAnadirAlbum
        '
        Me.btnPulAnadirAlbum.Location = New System.Drawing.Point(133, 258)
        Me.btnPulAnadirAlbum.Name = "btnPulAnadirAlbum"
        Me.btnPulAnadirAlbum.Size = New System.Drawing.Size(110, 50)
        Me.btnPulAnadirAlbum.TabIndex = 29
        Me.btnPulAnadirAlbum.Text = "INSERTAR ALBUM"
        Me.btnPulAnadirAlbum.UseVisualStyleBackColor = True
        '
        'btnLimpiarAlbum
        '
        Me.btnLimpiarAlbum.Location = New System.Drawing.Point(13, 316)
        Me.btnLimpiarAlbum.Name = "btnLimpiarAlbum"
        Me.btnLimpiarAlbum.Size = New System.Drawing.Size(114, 39)
        Me.btnLimpiarAlbum.TabIndex = 28
        Me.btnLimpiarAlbum.Text = "LIMPIAR"
        Me.btnLimpiarAlbum.UseVisualStyleBackColor = True
        '
        'lblConfirmacionAlbum
        '
        Me.lblConfirmacionAlbum.AutoSize = True
        Me.lblConfirmacionAlbum.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblConfirmacionAlbum.Location = New System.Drawing.Point(13, 365)
        Me.lblConfirmacionAlbum.Name = "lblConfirmacionAlbum"
        Me.lblConfirmacionAlbum.Size = New System.Drawing.Size(0, 17)
        Me.lblConfirmacionAlbum.TabIndex = 24
        '
        'lstMis_albumes
        '
        Me.lstMis_albumes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstMis_albumes.FormattingEnabled = True
        Me.lstMis_albumes.ItemHeight = 17
        Me.lstMis_albumes.Location = New System.Drawing.Point(13, 14)
        Me.lstMis_albumes.Name = "lstMis_albumes"
        Me.lstMis_albumes.Size = New System.Drawing.Size(230, 225)
        Me.lstMis_albumes.TabIndex = 11
        '
        'btnEliminarAlbum
        '
        Me.btnEliminarAlbum.Location = New System.Drawing.Point(133, 316)
        Me.btnEliminarAlbum.Name = "btnEliminarAlbum"
        Me.btnEliminarAlbum.Size = New System.Drawing.Size(110, 39)
        Me.btnEliminarAlbum.TabIndex = 3
        Me.btnEliminarAlbum.Text = "ELIMINAR"
        Me.btnEliminarAlbum.UseVisualStyleBackColor = True
        '
        'btnPulModifAlbum
        '
        Me.btnPulModifAlbum.Enabled = False
        Me.btnPulModifAlbum.Location = New System.Drawing.Point(13, 258)
        Me.btnPulModifAlbum.Name = "btnPulModifAlbum"
        Me.btnPulModifAlbum.Size = New System.Drawing.Size(114, 50)
        Me.btnPulModifAlbum.TabIndex = 2
        Me.btnPulModifAlbum.Text = "MODIFICAR ALBUM"
        Me.btnPulModifAlbum.UseVisualStyleBackColor = True
        '
        'tbpArtistas
        '
        Me.tbpArtistas.Controls.Add(Me.btnModificarArtPul)
        Me.tbpArtistas.Controls.Add(Me.lblConfirmacionArtista)
        Me.tbpArtistas.Controls.Add(Me.btnLimpiarArtista)
        Me.tbpArtistas.Controls.Add(Me.btnArtistasPul)
        Me.tbpArtistas.Controls.Add(Me.cbMis_artistas)
        Me.tbpArtistas.Controls.Add(Me.lstMis_artistas)
        Me.tbpArtistas.Controls.Add(Me.btnEliminarArtistas)
        Me.tbpArtistas.ImageIndex = 2
        Me.tbpArtistas.Location = New System.Drawing.Point(4, 29)
        Me.tbpArtistas.Name = "tbpArtistas"
        Me.tbpArtistas.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpArtistas.Size = New System.Drawing.Size(715, 393)
        Me.tbpArtistas.TabIndex = 3
        Me.tbpArtistas.Text = "Artistas"
        Me.tbpArtistas.UseVisualStyleBackColor = True
        '
        'btnModificarArtPul
        '
        Me.btnModificarArtPul.Enabled = False
        Me.btnModificarArtPul.Location = New System.Drawing.Point(12, 258)
        Me.btnModificarArtPul.Name = "btnModificarArtPul"
        Me.btnModificarArtPul.Size = New System.Drawing.Size(104, 46)
        Me.btnModificarArtPul.TabIndex = 35
        Me.btnModificarArtPul.Text = "MODIFICAR ARTISTA"
        Me.btnModificarArtPul.UseVisualStyleBackColor = True
        '
        'lblConfirmacionArtista
        '
        Me.lblConfirmacionArtista.AutoSize = True
        Me.lblConfirmacionArtista.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblConfirmacionArtista.Location = New System.Drawing.Point(12, 371)
        Me.lblConfirmacionArtista.Name = "lblConfirmacionArtista"
        Me.lblConfirmacionArtista.Size = New System.Drawing.Size(0, 17)
        Me.lblConfirmacionArtista.TabIndex = 34
        '
        'btnLimpiarArtista
        '
        Me.btnLimpiarArtista.Location = New System.Drawing.Point(10, 343)
        Me.btnLimpiarArtista.Name = "btnLimpiarArtista"
        Me.btnLimpiarArtista.Size = New System.Drawing.Size(216, 25)
        Me.btnLimpiarArtista.TabIndex = 29
        Me.btnLimpiarArtista.Text = "LIMPIAR CAMPOS"
        Me.btnLimpiarArtista.UseVisualStyleBackColor = True
        '
        'btnArtistasPul
        '
        Me.btnArtistasPul.Location = New System.Drawing.Point(122, 258)
        Me.btnArtistasPul.Name = "btnArtistasPul"
        Me.btnArtistasPul.Size = New System.Drawing.Size(104, 46)
        Me.btnArtistasPul.TabIndex = 32
        Me.btnArtistasPul.Text = "AÑADIR ARTISTA"
        Me.btnArtistasPul.UseVisualStyleBackColor = True
        '
        'cbMis_artistas
        '
        Me.cbMis_artistas.Controls.Add(Me.btnAnadirImagenArtista)
        Me.cbMis_artistas.Controls.Add(Me.lblIDArtista)
        Me.cbMis_artistas.Controls.Add(Me.Label2)
        Me.cbMis_artistas.Controls.Add(Me.btnAnadirArtistas)
        Me.cbMis_artistas.Controls.Add(Me.txtPaisA)
        Me.cbMis_artistas.Controls.Add(Me.txtNombreA)
        Me.cbMis_artistas.Controls.Add(Me.lblFavorito)
        Me.cbMis_artistas.Controls.Add(Me.btnModificarArtistas)
        Me.cbMis_artistas.Controls.Add(Me.lstalbumesArtistas)
        Me.cbMis_artistas.Controls.Add(Me.lblAlbumes)
        Me.cbMis_artistas.Controls.Add(Me.pbNoFavorito)
        Me.cbMis_artistas.Controls.Add(Me.lblPais)
        Me.cbMis_artistas.Controls.Add(Me.pbFavorito)
        Me.cbMis_artistas.Controls.Add(Me.lstcancionesArtistas)
        Me.cbMis_artistas.Controls.Add(Me.lblCancionesArtista)
        Me.cbMis_artistas.Controls.Add(Me.lblNombreArtista)
        Me.cbMis_artistas.Controls.Add(Me.pbImagenArtista)
        Me.cbMis_artistas.Location = New System.Drawing.Point(248, 6)
        Me.cbMis_artistas.Name = "cbMis_artistas"
        Me.cbMis_artistas.Size = New System.Drawing.Size(466, 389)
        Me.cbMis_artistas.TabIndex = 28
        Me.cbMis_artistas.TabStop = False
        '
        'btnAnadirImagenArtista
        '
        Me.btnAnadirImagenArtista.Location = New System.Drawing.Point(320, 198)
        Me.btnAnadirImagenArtista.Name = "btnAnadirImagenArtista"
        Me.btnAnadirImagenArtista.Size = New System.Drawing.Size(139, 31)
        Me.btnAnadirImagenArtista.TabIndex = 32
        Me.btnAnadirImagenArtista.Text = "AÑADIR IMAGEN"
        Me.btnAnadirImagenArtista.UseVisualStyleBackColor = True
        '
        'lblIDArtista
        '
        Me.lblIDArtista.AutoSize = True
        Me.lblIDArtista.Location = New System.Drawing.Point(383, 157)
        Me.lblIDArtista.Name = "lblIDArtista"
        Me.lblIDArtista.Size = New System.Drawing.Size(46, 17)
        Me.lblIDArtista.TabIndex = 27
        Me.lblIDArtista.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(356, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "ID:"
        '
        'btnAnadirArtistas
        '
        Me.btnAnadirArtistas.Location = New System.Drawing.Point(241, 322)
        Me.btnAnadirArtistas.Name = "btnAnadirArtistas"
        Me.btnAnadirArtistas.Size = New System.Drawing.Size(183, 54)
        Me.btnAnadirArtistas.TabIndex = 31
        Me.btnAnadirArtistas.Text = "GUARDAR NUEVO ARTISTA"
        Me.btnAnadirArtistas.UseVisualStyleBackColor = True
        '
        'txtPaisA
        '
        Me.txtPaisA.Location = New System.Drawing.Point(80, 45)
        Me.txtPaisA.Name = "txtPaisA"
        Me.txtPaisA.Size = New System.Drawing.Size(234, 25)
        Me.txtPaisA.TabIndex = 24
        '
        'txtNombreA
        '
        Me.txtNombreA.Location = New System.Drawing.Point(80, 17)
        Me.txtNombreA.Name = "txtNombreA"
        Me.txtNombreA.Size = New System.Drawing.Size(234, 25)
        Me.txtNombreA.TabIndex = 23
        '
        'lblFavorito
        '
        Me.lblFavorito.AutoSize = True
        Me.lblFavorito.Location = New System.Drawing.Point(44, 87)
        Me.lblFavorito.Name = "lblFavorito"
        Me.lblFavorito.Size = New System.Drawing.Size(143, 17)
        Me.lblFavorito.TabIndex = 22
        Me.lblFavorito.Text = "(marcar como favorito)"
        '
        'btnModificarArtistas
        '
        Me.btnModificarArtistas.Location = New System.Drawing.Point(44, 322)
        Me.btnModificarArtistas.Name = "btnModificarArtistas"
        Me.btnModificarArtistas.Size = New System.Drawing.Size(183, 54)
        Me.btnModificarArtistas.TabIndex = 5
        Me.btnModificarArtistas.Text = "GUARDAR CAMBIOS"
        Me.btnModificarArtistas.UseVisualStyleBackColor = True
        '
        'lstalbumesArtistas
        '
        Me.lstalbumesArtistas.FormattingEnabled = True
        Me.lstalbumesArtistas.ItemHeight = 17
        Me.lstalbumesArtistas.Location = New System.Drawing.Point(6, 132)
        Me.lstalbumesArtistas.Name = "lstalbumesArtistas"
        Me.lstalbumesArtistas.Size = New System.Drawing.Size(286, 72)
        Me.lstalbumesArtistas.TabIndex = 19
        '
        'lblAlbumes
        '
        Me.lblAlbumes.AutoSize = True
        Me.lblAlbumes.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblAlbumes.Location = New System.Drawing.Point(6, 114)
        Me.lblAlbumes.Name = "lblAlbumes"
        Me.lblAlbumes.Size = New System.Drawing.Size(75, 17)
        Me.lblAlbumes.TabIndex = 18
        Me.lblAlbumes.Text = "ALBUMES:"
        '
        'pbNoFavorito
        '
        Me.pbNoFavorito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbNoFavorito.Image = CType(resources.GetObject("pbNoFavorito.Image"), System.Drawing.Image)
        Me.pbNoFavorito.Location = New System.Drawing.Point(6, 77)
        Me.pbNoFavorito.Name = "pbNoFavorito"
        Me.pbNoFavorito.Size = New System.Drawing.Size(32, 25)
        Me.pbNoFavorito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbNoFavorito.TabIndex = 21
        Me.pbNoFavorito.TabStop = False
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Location = New System.Drawing.Point(4, 48)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(40, 17)
        Me.lblPais.TabIndex = 16
        Me.lblPais.Text = "*PAÍS:"
        '
        'pbFavorito
        '
        Me.pbFavorito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbFavorito.Image = CType(resources.GetObject("pbFavorito.Image"), System.Drawing.Image)
        Me.pbFavorito.Location = New System.Drawing.Point(6, 77)
        Me.pbFavorito.Name = "pbFavorito"
        Me.pbFavorito.Size = New System.Drawing.Size(32, 25)
        Me.pbFavorito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbFavorito.TabIndex = 20
        Me.pbFavorito.TabStop = False
        '
        'lstcancionesArtistas
        '
        Me.lstcancionesArtistas.FormattingEnabled = True
        Me.lstcancionesArtistas.ItemHeight = 17
        Me.lstcancionesArtistas.Location = New System.Drawing.Point(6, 235)
        Me.lstcancionesArtistas.Name = "lstcancionesArtistas"
        Me.lstcancionesArtistas.Size = New System.Drawing.Size(286, 72)
        Me.lstcancionesArtistas.TabIndex = 13
        '
        'lblCancionesArtista
        '
        Me.lblCancionesArtista.AutoSize = True
        Me.lblCancionesArtista.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblCancionesArtista.Location = New System.Drawing.Point(6, 214)
        Me.lblCancionesArtista.Name = "lblCancionesArtista"
        Me.lblCancionesArtista.Size = New System.Drawing.Size(89, 17)
        Me.lblCancionesArtista.TabIndex = 11
        Me.lblCancionesArtista.Text = "CANCIONES:"
        '
        'lblNombreArtista
        '
        Me.lblNombreArtista.AutoSize = True
        Me.lblNombreArtista.Location = New System.Drawing.Point(4, 20)
        Me.lblNombreArtista.Name = "lblNombreArtista"
        Me.lblNombreArtista.Size = New System.Drawing.Size(70, 17)
        Me.lblNombreArtista.TabIndex = 9
        Me.lblNombreArtista.Text = "*NOMBRE:"
        '
        'pbImagenArtista
        '
        Me.pbImagenArtista.Cursor = System.Windows.Forms.Cursors.No
        Me.pbImagenArtista.Location = New System.Drawing.Point(320, 17)
        Me.pbImagenArtista.Name = "pbImagenArtista"
        Me.pbImagenArtista.Size = New System.Drawing.Size(140, 132)
        Me.pbImagenArtista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagenArtista.TabIndex = 7
        Me.pbImagenArtista.TabStop = False
        '
        'lstMis_artistas
        '
        Me.lstMis_artistas.FormattingEnabled = True
        Me.lstMis_artistas.ItemHeight = 17
        Me.lstMis_artistas.Location = New System.Drawing.Point(10, 23)
        Me.lstMis_artistas.Name = "lstMis_artistas"
        Me.lstMis_artistas.Size = New System.Drawing.Size(216, 225)
        Me.lstMis_artistas.TabIndex = 14
        '
        'btnEliminarArtistas
        '
        Me.btnEliminarArtistas.Location = New System.Drawing.Point(10, 310)
        Me.btnEliminarArtistas.Name = "btnEliminarArtistas"
        Me.btnEliminarArtistas.Size = New System.Drawing.Size(216, 27)
        Me.btnEliminarArtistas.TabIndex = 6
        Me.btnEliminarArtistas.Text = "ELIMINAR ARTISTA"
        Me.btnEliminarArtistas.UseVisualStyleBackColor = True
        '
        'tbpCanciones
        '
        Me.tbpCanciones.Controls.Add(Me.lblConfirmacionCancion)
        Me.tbpCanciones.Controls.Add(Me.btnCancionPulsa)
        Me.tbpCanciones.Controls.Add(Me.btnLimpiarCancion)
        Me.tbpCanciones.Controls.Add(Me.cbMis_Canciones)
        Me.tbpCanciones.Controls.Add(Me.lstMis_canciones)
        Me.tbpCanciones.Controls.Add(Me.btnEliminarCancion)
        Me.tbpCanciones.Controls.Add(Me.btnPulModifCancion)
        Me.tbpCanciones.ImageIndex = 3
        Me.tbpCanciones.Location = New System.Drawing.Point(4, 29)
        Me.tbpCanciones.Name = "tbpCanciones"
        Me.tbpCanciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCanciones.Size = New System.Drawing.Size(715, 393)
        Me.tbpCanciones.TabIndex = 4
        Me.tbpCanciones.Text = "Canciones"
        Me.tbpCanciones.UseVisualStyleBackColor = True
        '
        'lblConfirmacionCancion
        '
        Me.lblConfirmacionCancion.AutoSize = True
        Me.lblConfirmacionCancion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblConfirmacionCancion.Location = New System.Drawing.Point(364, 357)
        Me.lblConfirmacionCancion.Name = "lblConfirmacionCancion"
        Me.lblConfirmacionCancion.Size = New System.Drawing.Size(0, 17)
        Me.lblConfirmacionCancion.TabIndex = 41
        '
        'btnCancionPulsa
        '
        Me.btnCancionPulsa.Location = New System.Drawing.Point(495, 258)
        Me.btnCancionPulsa.Name = "btnCancionPulsa"
        Me.btnCancionPulsa.Size = New System.Drawing.Size(208, 33)
        Me.btnCancionPulsa.TabIndex = 40
        Me.btnCancionPulsa.Text = "AÑADIR CANCION"
        Me.btnCancionPulsa.UseVisualStyleBackColor = True
        '
        'btnLimpiarCancion
        '
        Me.btnLimpiarCancion.Location = New System.Drawing.Point(495, 312)
        Me.btnLimpiarCancion.Name = "btnLimpiarCancion"
        Me.btnLimpiarCancion.Size = New System.Drawing.Size(208, 36)
        Me.btnLimpiarCancion.TabIndex = 38
        Me.btnLimpiarCancion.Text = "LIMPIAR CAMPOS"
        Me.btnLimpiarCancion.UseVisualStyleBackColor = True
        '
        'cbMis_Canciones
        '
        Me.cbMis_Canciones.Controls.Add(Me.btnModificarCancion)
        Me.cbMis_Canciones.Controls.Add(Me.cbAlbumC)
        Me.cbMis_Canciones.Controls.Add(Me.lblIDCa)
        Me.cbMis_Canciones.Controls.Add(Me.lblIDC)
        Me.cbMis_Canciones.Controls.Add(Me.lblNombreC)
        Me.cbMis_Canciones.Controls.Add(Me.lblAlbumC)
        Me.cbMis_Canciones.Controls.Add(Me.txtDuracionC)
        Me.cbMis_Canciones.Controls.Add(Me.lblDuracionC)
        Me.cbMis_Canciones.Controls.Add(Me.btnAnadirCancion)
        Me.cbMis_Canciones.Controls.Add(Me.txtNombreC)
        Me.cbMis_Canciones.Enabled = False
        Me.cbMis_Canciones.Location = New System.Drawing.Point(290, 14)
        Me.cbMis_Canciones.Name = "cbMis_Canciones"
        Me.cbMis_Canciones.Size = New System.Drawing.Size(422, 238)
        Me.cbMis_Canciones.TabIndex = 37
        Me.cbMis_Canciones.TabStop = False
        '
        'btnModificarCancion
        '
        Me.btnModificarCancion.Location = New System.Drawing.Point(31, 175)
        Me.btnModificarCancion.Name = "btnModificarCancion"
        Me.btnModificarCancion.Size = New System.Drawing.Size(179, 57)
        Me.btnModificarCancion.TabIndex = 45
        Me.btnModificarCancion.Text = "GUARDAR CAMBIOS"
        Me.btnModificarCancion.UseVisualStyleBackColor = True
        '
        'cbAlbumC
        '
        Me.cbAlbumC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAlbumC.FormattingEnabled = True
        Me.cbAlbumC.Location = New System.Drawing.Point(86, 84)
        Me.cbAlbumC.Name = "cbAlbumC"
        Me.cbAlbumC.Size = New System.Drawing.Size(327, 25)
        Me.cbAlbumC.TabIndex = 44
        '
        'lblIDCa
        '
        Me.lblIDCa.AutoSize = True
        Me.lblIDCa.Location = New System.Drawing.Point(36, 10)
        Me.lblIDCa.Name = "lblIDCa"
        Me.lblIDCa.Size = New System.Drawing.Size(39, 17)
        Me.lblIDCa.TabIndex = 43
        Me.lblIDCa.Text = "Label"
        '
        'lblIDC
        '
        Me.lblIDC.AutoSize = True
        Me.lblIDC.Location = New System.Drawing.Point(6, 10)
        Me.lblIDC.Name = "lblIDC"
        Me.lblIDC.Size = New System.Drawing.Size(27, 17)
        Me.lblIDC.TabIndex = 42
        Me.lblIDC.Text = "ID :"
        '
        'lblNombreC
        '
        Me.lblNombreC.AutoSize = True
        Me.lblNombreC.Location = New System.Drawing.Point(6, 42)
        Me.lblNombreC.Name = "lblNombreC"
        Me.lblNombreC.Size = New System.Drawing.Size(74, 17)
        Me.lblNombreC.TabIndex = 29
        Me.lblNombreC.Text = "*NOMBRE :"
        '
        'lblAlbumC
        '
        Me.lblAlbumC.AutoSize = True
        Me.lblAlbumC.Location = New System.Drawing.Point(6, 87)
        Me.lblAlbumC.Name = "lblAlbumC"
        Me.lblAlbumC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAlbumC.Size = New System.Drawing.Size(62, 17)
        Me.lblAlbumC.TabIndex = 30
        Me.lblAlbumC.Text = "*ALBUM :"
        '
        'txtDuracionC
        '
        Me.txtDuracionC.Location = New System.Drawing.Point(103, 126)
        Me.txtDuracionC.Name = "txtDuracionC"
        Me.txtDuracionC.Size = New System.Drawing.Size(136, 25)
        Me.txtDuracionC.TabIndex = 34
        '
        'lblDuracionC
        '
        Me.lblDuracionC.AutoSize = True
        Me.lblDuracionC.Location = New System.Drawing.Point(6, 126)
        Me.lblDuracionC.Name = "lblDuracionC"
        Me.lblDuracionC.Size = New System.Drawing.Size(91, 34)
        Me.lblDuracionC.TabIndex = 31
        Me.lblDuracionC.Text = "*DURACIÓN :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(en segundos)"
        '
        'btnAnadirCancion
        '
        Me.btnAnadirCancion.Location = New System.Drawing.Point(216, 175)
        Me.btnAnadirCancion.Name = "btnAnadirCancion"
        Me.btnAnadirCancion.Size = New System.Drawing.Size(179, 57)
        Me.btnAnadirCancion.TabIndex = 12
        Me.btnAnadirCancion.Text = "GUARDAR NUEVA CANCION"
        Me.btnAnadirCancion.UseVisualStyleBackColor = True
        '
        'txtNombreC
        '
        Me.txtNombreC.Location = New System.Drawing.Point(86, 39)
        Me.txtNombreC.Name = "txtNombreC"
        Me.txtNombreC.Size = New System.Drawing.Size(327, 25)
        Me.txtNombreC.TabIndex = 32
        '
        'lstMis_canciones
        '
        Me.lstMis_canciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstMis_canciones.FormattingEnabled = True
        Me.lstMis_canciones.ItemHeight = 17
        Me.lstMis_canciones.Location = New System.Drawing.Point(17, 19)
        Me.lstMis_canciones.Name = "lstMis_canciones"
        Me.lstMis_canciones.Size = New System.Drawing.Size(254, 361)
        Me.lstMis_canciones.TabIndex = 22
        '
        'btnEliminarCancion
        '
        Me.btnEliminarCancion.Location = New System.Drawing.Point(290, 312)
        Me.btnEliminarCancion.Name = "btnEliminarCancion"
        Me.btnEliminarCancion.Size = New System.Drawing.Size(193, 36)
        Me.btnEliminarCancion.TabIndex = 14
        Me.btnEliminarCancion.Text = "ELIMINAR CANCION"
        Me.btnEliminarCancion.UseVisualStyleBackColor = True
        '
        'btnPulModifCancion
        '
        Me.btnPulModifCancion.Location = New System.Drawing.Point(290, 258)
        Me.btnPulModifCancion.Name = "btnPulModifCancion"
        Me.btnPulModifCancion.Size = New System.Drawing.Size(193, 36)
        Me.btnPulModifCancion.TabIndex = 13
        Me.btnPulModifCancion.Text = "MODIFICAR CANCION"
        Me.btnPulModifCancion.UseVisualStyleBackColor = True
        '
        'tbpCuenta
        '
        Me.tbpCuenta.Controls.Add(Me.lblHistorial)
        Me.tbpCuenta.Controls.Add(Me.lstHistorial)
        Me.tbpCuenta.Controls.Add(Me.gbDatosUsuario)
        Me.tbpCuenta.Controls.Add(Me.lstUsuarios)
        Me.tbpCuenta.Controls.Add(Me.lblUsuariosTotal)
        Me.tbpCuenta.ImageIndex = 4
        Me.tbpCuenta.Location = New System.Drawing.Point(4, 29)
        Me.tbpCuenta.Name = "tbpCuenta"
        Me.tbpCuenta.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCuenta.Size = New System.Drawing.Size(715, 393)
        Me.tbpCuenta.TabIndex = 5
        Me.tbpCuenta.Text = "Mi cuenta"
        Me.tbpCuenta.UseVisualStyleBackColor = True
        '
        'lblHistorial
        '
        Me.lblHistorial.AutoSize = True
        Me.lblHistorial.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHistorial.Location = New System.Drawing.Point(431, 237)
        Me.lblHistorial.Name = "lblHistorial"
        Me.lblHistorial.Size = New System.Drawing.Size(262, 21)
        Me.lblHistorial.TabIndex = 18
        Me.lblHistorial.Text = "HISTORIAL DE REPRODUCCIONES :"
        '
        'lstHistorial
        '
        Me.lstHistorial.FormattingEnabled = True
        Me.lstHistorial.ItemHeight = 17
        Me.lstHistorial.Location = New System.Drawing.Point(431, 271)
        Me.lstHistorial.Name = "lstHistorial"
        Me.lstHistorial.Size = New System.Drawing.Size(262, 106)
        Me.lstHistorial.TabIndex = 17
        '
        'gbDatosUsuario
        '
        Me.gbDatosUsuario.Controls.Add(Me.btnLimpiar)
        Me.gbDatosUsuario.Controls.Add(Me.lblTituloCuenta)
        Me.gbDatosUsuario.Controls.Add(Me.lblEmail)
        Me.gbDatosUsuario.Controls.Add(Me.txtEmail)
        Me.gbDatosUsuario.Controls.Add(Me.lblConfirmacion)
        Me.gbDatosUsuario.Controls.Add(Me.lblNombre)
        Me.gbDatosUsuario.Controls.Add(Me.btnHistorial)
        Me.gbDatosUsuario.Controls.Add(Me.txtNombre)
        Me.gbDatosUsuario.Controls.Add(Me.btnEliminarUsuario)
        Me.gbDatosUsuario.Controls.Add(Me.lblApellidos)
        Me.gbDatosUsuario.Controls.Add(Me.btnModificarUsuario)
        Me.gbDatosUsuario.Controls.Add(Me.txtApellidos)
        Me.gbDatosUsuario.Controls.Add(Me.lblNacimiento)
        Me.gbDatosUsuario.Controls.Add(Me.dtpFechaNacimiento)
        Me.gbDatosUsuario.Enabled = False
        Me.gbDatosUsuario.Location = New System.Drawing.Point(3, 3)
        Me.gbDatosUsuario.Name = "gbDatosUsuario"
        Me.gbDatosUsuario.Size = New System.Drawing.Size(402, 392)
        Me.gbDatosUsuario.TabIndex = 16
        Me.gbDatosUsuario.TabStop = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(280, 331)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(95, 48)
        Me.btnLimpiar.TabIndex = 13
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'lblTituloCuenta
        '
        Me.lblTituloCuenta.AutoSize = True
        Me.lblTituloCuenta.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTituloCuenta.Location = New System.Drawing.Point(70, 21)
        Me.lblTituloCuenta.Name = "lblTituloCuenta"
        Me.lblTituloCuenta.Size = New System.Drawing.Size(244, 32)
        Me.lblTituloCuenta.TabIndex = 8
        Me.lblTituloCuenta.Text = "DATOS PERSONALES:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEmail.Location = New System.Drawing.Point(6, 68)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(135, 20)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "Correo electrónico:"
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(146, 67)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(240, 25)
        Me.txtEmail.TabIndex = 1
        '
        'lblConfirmacion
        '
        Me.lblConfirmacion.AutoSize = True
        Me.lblConfirmacion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblConfirmacion.Location = New System.Drawing.Point(93, 238)
        Me.lblConfirmacion.Name = "lblConfirmacion"
        Me.lblConfirmacion.Size = New System.Drawing.Size(0, 17)
        Me.lblConfirmacion.TabIndex = 12
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNombre.Location = New System.Drawing.Point(34, 107)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(67, 20)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre:"
        '
        'btnHistorial
        '
        Me.btnHistorial.Location = New System.Drawing.Point(146, 331)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(128, 48)
        Me.btnHistorial.TabIndex = 11
        Me.btnHistorial.Text = "HISTORIAL DE REPRODUCCIONES"
        Me.btnHistorial.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(146, 106)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(240, 25)
        Me.txtNombre.TabIndex = 3
        '
        'btnEliminarUsuario
        '
        Me.btnEliminarUsuario.Location = New System.Drawing.Point(15, 331)
        Me.btnEliminarUsuario.Name = "btnEliminarUsuario"
        Me.btnEliminarUsuario.Size = New System.Drawing.Size(120, 48)
        Me.btnEliminarUsuario.TabIndex = 10
        Me.btnEliminarUsuario.Text = "ELIMINAR MI CUENTA"
        Me.btnEliminarUsuario.UseVisualStyleBackColor = True
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblApellidos.Location = New System.Drawing.Point(34, 153)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(75, 20)
        Me.lblApellidos.TabIndex = 4
        Me.lblApellidos.Text = "Apellidos:"
        '
        'btnModificarUsuario
        '
        Me.btnModificarUsuario.Location = New System.Drawing.Point(15, 275)
        Me.btnModificarUsuario.Name = "btnModificarUsuario"
        Me.btnModificarUsuario.Size = New System.Drawing.Size(360, 40)
        Me.btnModificarUsuario.TabIndex = 9
        Me.btnModificarUsuario.Text = "GUARDAR CAMBIOS"
        Me.btnModificarUsuario.UseVisualStyleBackColor = True
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(146, 152)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(240, 25)
        Me.txtApellidos.TabIndex = 5
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNacimiento.Location = New System.Drawing.Point(6, 195)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(149, 20)
        Me.lblNacimiento.TabIndex = 6
        Me.lblNacimiento.Text = "Fecha de nacimiento:"
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(169, 191)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(84, 25)
        Me.dtpFechaNacimiento.TabIndex = 7
        Me.dtpFechaNacimiento.Value = New Date(2021, 3, 28, 21, 11, 2, 0)
        '
        'lstUsuarios
        '
        Me.lstUsuarios.FormattingEnabled = True
        Me.lstUsuarios.ItemHeight = 17
        Me.lstUsuarios.Location = New System.Drawing.Point(431, 39)
        Me.lstUsuarios.Name = "lstUsuarios"
        Me.lstUsuarios.Size = New System.Drawing.Size(262, 174)
        Me.lstUsuarios.TabIndex = 15
        '
        'lblUsuariosTotal
        '
        Me.lblUsuariosTotal.AutoSize = True
        Me.lblUsuariosTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblUsuariosTotal.Location = New System.Drawing.Point(431, 10)
        Me.lblUsuariosTotal.Name = "lblUsuariosTotal"
        Me.lblUsuariosTotal.Size = New System.Drawing.Size(256, 25)
        Me.lblUsuariosTotal.TabIndex = 14
        Me.lblUsuariosTotal.Text = "USUARIOS DE CANCIONIFY:"
        '
        'consultas
        '
        Me.consultas.Controls.Add(Me.btnConsulta5)
        Me.consultas.Controls.Add(Me.btnConsulta4)
        Me.consultas.Controls.Add(Me.lblHasta)
        Me.consultas.Controls.Add(Me.lblDesde)
        Me.consultas.Controls.Add(Me.dtpFin)
        Me.consultas.Controls.Add(Me.dtpInicio)
        Me.consultas.Controls.Add(Me.cbUser)
        Me.consultas.Controls.Add(Me.btnConsulta3)
        Me.consultas.Controls.Add(Me.btnConsulta2)
        Me.consultas.Controls.Add(Me.lstResultados)
        Me.consultas.Controls.Add(Me.lblPregunta)
        Me.consultas.Controls.Add(Me.txtPaisConsulta)
        Me.consultas.Controls.Add(Me.btnConsulta1)
        Me.consultas.ImageIndex = 5
        Me.consultas.Location = New System.Drawing.Point(4, 29)
        Me.consultas.Name = "consultas"
        Me.consultas.Padding = New System.Windows.Forms.Padding(3)
        Me.consultas.Size = New System.Drawing.Size(715, 393)
        Me.consultas.TabIndex = 6
        Me.consultas.Text = "Consultas"
        Me.consultas.UseVisualStyleBackColor = True
        '
        'btnConsulta5
        '
        Me.btnConsulta5.Location = New System.Drawing.Point(3, 322)
        Me.btnConsulta5.Name = "btnConsulta5"
        Me.btnConsulta5.Size = New System.Drawing.Size(439, 46)
        Me.btnConsulta5.TabIndex = 12
        Me.btnConsulta5.Text = "5. TIEMPO DE REPRODUCCIÓN DE LOS " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ARTISTAS FAVORITOS DE UN USUARIO"
        Me.btnConsulta5.UseVisualStyleBackColor = True
        '
        'btnConsulta4
        '
        Me.btnConsulta4.Location = New System.Drawing.Point(3, 265)
        Me.btnConsulta4.Name = "btnConsulta4"
        Me.btnConsulta4.Size = New System.Drawing.Size(439, 37)
        Me.btnConsulta4.TabIndex = 11
        Me.btnConsulta4.Text = "4. LISTADO DE USUARIO ORDENADO POR TIEMPO DE USO"
        Me.btnConsulta4.UseVisualStyleBackColor = True
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(298, 225)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(53, 17)
        Me.lblHasta.TabIndex = 10
        Me.lblHasta.Text = "HASTA :"
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(146, 225)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(54, 17)
        Me.lblDesde.TabIndex = 9
        Me.lblDesde.Text = "DESDE :"
        '
        'dtpFin
        '
        Me.dtpFin.Enabled = False
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(358, 219)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(84, 25)
        Me.dtpFin.TabIndex = 8
        '
        'dtpInicio
        '
        Me.dtpInicio.Enabled = False
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(206, 219)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(86, 25)
        Me.dtpInicio.TabIndex = 7
        '
        'cbUser
        '
        Me.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUser.Enabled = False
        Me.cbUser.FormattingEnabled = True
        Me.cbUser.Location = New System.Drawing.Point(3, 219)
        Me.cbUser.Name = "cbUser"
        Me.cbUser.Size = New System.Drawing.Size(137, 25)
        Me.cbUser.TabIndex = 6
        '
        'btnConsulta3
        '
        Me.btnConsulta3.Location = New System.Drawing.Point(3, 167)
        Me.btnConsulta3.Name = "btnConsulta3"
        Me.btnConsulta3.Size = New System.Drawing.Size(439, 37)
        Me.btnConsulta3.TabIndex = 5
        Me.btnConsulta3.Text = "3. LISTADO DE ARTISTAS MÁS ESCUCHADO POR USUARIO"
        Me.btnConsulta3.UseVisualStyleBackColor = True
        '
        'btnConsulta2
        '
        Me.btnConsulta2.Location = New System.Drawing.Point(3, 115)
        Me.btnConsulta2.Name = "btnConsulta2"
        Me.btnConsulta2.Size = New System.Drawing.Size(439, 37)
        Me.btnConsulta2.TabIndex = 4
        Me.btnConsulta2.Text = "2. LISTADO DE CANCIONES ORDENADAS POR Nº DE REPRODUCCIONES"
        Me.btnConsulta2.UseVisualStyleBackColor = True
        '
        'lstResultados
        '
        Me.lstResultados.FormattingEnabled = True
        Me.lstResultados.ItemHeight = 17
        Me.lstResultados.Location = New System.Drawing.Point(463, 24)
        Me.lstResultados.Name = "lstResultados"
        Me.lstResultados.Size = New System.Drawing.Size(236, 344)
        Me.lstResultados.TabIndex = 3
        '
        'lblPregunta
        '
        Me.lblPregunta.AutoSize = True
        Me.lblPregunta.Location = New System.Drawing.Point(33, 74)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(178, 17)
        Me.lblPregunta.TabIndex = 2
        Me.lblPregunta.Text = "¿QUIERE FILTRAR POR PAÍS?  "
        '
        'txtPaisConsulta
        '
        Me.txtPaisConsulta.Enabled = False
        Me.txtPaisConsulta.Location = New System.Drawing.Point(217, 71)
        Me.txtPaisConsulta.Name = "txtPaisConsulta"
        Me.txtPaisConsulta.Size = New System.Drawing.Size(134, 25)
        Me.txtPaisConsulta.TabIndex = 1
        '
        'btnConsulta1
        '
        Me.btnConsulta1.Location = New System.Drawing.Point(3, 24)
        Me.btnConsulta1.Name = "btnConsulta1"
        Me.btnConsulta1.Size = New System.Drawing.Size(439, 38)
        Me.btnConsulta1.TabIndex = 0
        Me.btnConsulta1.Text = "1. LISTADO DE ARTISTAS ORDENADOS POR Nº DE REPRODUCCIONES"
        Me.btnConsulta1.UseVisualStyleBackColor = True
        '
        'ImageListPestanas
        '
        Me.ImageListPestanas.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageListPestanas.ImageStream = CType(resources.GetObject("ImageListPestanas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListPestanas.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListPestanas.Images.SetKeyName(0, "icono inicio.ico")
        Me.ImageListPestanas.Images.SetKeyName(1, "album icon.ico")
        Me.ImageListPestanas.Images.SetKeyName(2, "icono artista.ico")
        Me.ImageListPestanas.Images.SetKeyName(3, "icono cancion.ico")
        Me.ImageListPestanas.Images.SetKeyName(4, "user icon.ico")
        Me.ImageListPestanas.Images.SetKeyName(5, "consulta icon.ico")
        '
        'btnCambiar
        '
        Me.btnCambiar.Location = New System.Drawing.Point(572, 444)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.Size = New System.Drawing.Size(159, 28)
        Me.btnCambiar.TabIndex = 2
        Me.btnCambiar.Text = "CAMBIAR DE USUARIO"
        Me.btnCambiar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(16, 444)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(104, 28)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "CERRAR SESIÓN"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 479)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnCambiar)
        Me.Controls.Add(Me.tbcMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.tbcMenu.ResumeLayout(False)
        Me.tbpInicio.ResumeLayout(False)
        Me.tbpInicio.PerformLayout()
        Me.gbInfoCancion.ResumeLayout(False)
        Me.gbInfoCancion.PerformLayout()
        CType(Me.pbPlayInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPauseInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSiguienteInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAnteriorInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInfoArt.ResumeLayout(False)
        Me.gbInfoArt.PerformLayout()
        CType(Me.pbArtista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcFavoritoArt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcNoFavArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInfoAlbum.ResumeLayout(False)
        Me.gbInfoAlbum.PerformLayout()
        CType(Me.pbAlbum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpPlaylists.ResumeLayout(False)
        Me.tbpPlaylists.PerformLayout()
        Me.gbAlbumes.ResumeLayout(False)
        Me.gbAlbumes.PerformLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpArtistas.ResumeLayout(False)
        Me.tbpArtistas.PerformLayout()
        Me.cbMis_artistas.ResumeLayout(False)
        Me.cbMis_artistas.PerformLayout()
        CType(Me.pbNoFavorito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFavorito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImagenArtista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpCanciones.ResumeLayout(False)
        Me.tbpCanciones.PerformLayout()
        Me.cbMis_Canciones.ResumeLayout(False)
        Me.cbMis_Canciones.PerformLayout()
        Me.tbpCuenta.ResumeLayout(False)
        Me.tbpCuenta.PerformLayout()
        Me.gbDatosUsuario.ResumeLayout(False)
        Me.gbDatosUsuario.PerformLayout()
        Me.consultas.ResumeLayout(False)
        Me.consultas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbcMenu As TabControl
    Friend WithEvents tbpInicio As TabPage
    Friend WithEvents lstCanciones As ListBox
    Friend WithEvents lstAlbumes As ListBox
    Friend WithEvents lstArtistas As ListBox
    Friend WithEvents tbpPlaylists As TabPage
    Friend WithEvents tbpArtistas As TabPage
    Friend WithEvents tbpCanciones As TabPage
    Friend WithEvents tbpCuenta As TabPage
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents lblCanciones As Label
    Friend WithEvents lblArtista As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnEliminarAlbum As Button
    Friend WithEvents btnPulModifAlbum As Button
    Friend WithEvents btnAnadirAlbum As Button
    Friend WithEvents btnCambiar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblCancionesArtista As Label
    Friend WithEvents lblNombreArtista As Label
    Friend WithEvents pbImagenArtista As PictureBox
    Friend WithEvents btnEliminarArtistas As Button
    Friend WithEvents btnModificarArtistas As Button
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblUsuariosTotal As Label
    Friend WithEvents lblConfirmacion As Label
    Friend WithEvents btnHistorial As Button
    Friend WithEvents btnEliminarUsuario As Button
    Friend WithEvents btnModificarUsuario As Button
    Friend WithEvents lblTituloCuenta As Label
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents lblNacimiento As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents lblApellidos As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lstMis_albumes As ListBox
    Friend WithEvents lstMis_canciones As ListBox
    Friend WithEvents btnEliminarCancion As Button
    Friend WithEvents btnPulModifCancion As Button
    Friend WithEvents btnAnadirCancion As Button
    Friend WithEvents lstCanciones_Album As ListBox
    Friend WithEvents lstcancionesArtistas As ListBox
    Friend WithEvents lstMis_artistas As ListBox
    Friend WithEvents lstalbumesArtistas As ListBox
    Friend WithEvents lblAlbumes As Label
    Friend WithEvents lblPais As Label
    Friend WithEvents lblDuracionAlbum As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lstUsuarios As ListBox
    Friend WithEvents lblBienvenida As Label
    Friend WithEvents lblFavorito As Label
    Friend WithEvents pbNoFavorito As PictureBox
    Friend WithEvents pbFavorito As PictureBox
    Friend WithEvents gbInfoArt As GroupBox
    Friend WithEvents gbInfoAlbum As GroupBox
    Friend WithEvents lblArtistaAlb As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblDuracionAlb As Label
    Friend WithEvents lblTituloAlb As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblFechaAlb As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents gbInfoCancion As GroupBox
    Friend WithEvents pbAlbum As PictureBox
    Friend WithEvents lblTituloCan As Label
    Friend WithEvents pbArtista As PictureBox
    Friend WithEvents Label23 As Label
    Friend WithEvents pcFavoritoArt As PictureBox
    Friend WithEvents pcNoFavArt As PictureBox
    Friend WithEvents lblNombreArt As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblPaisArt As Label
    Friend WithEvents lblAlbumCan As Label
    Friend WithEvents pbSiguienteInicio As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents Label11 As Label
    Friend WithEvents lblDuracionCan As Label
    Friend WithEvents P As PictureBox
    Friend WithEvents pbAnteriorInicio As PictureBox
    Friend WithEvents txtTituloAlbum As TextBox
    Friend WithEvents cbArtistaAlbum As ComboBox
    Friend WithEvents lblConfirmacionAlbum As Label
    Friend WithEvents txtPaisA As TextBox
    Friend WithEvents txtNombreA As TextBox
    Friend WithEvents lblTextoArtista As Label
    Friend WithEvents lblIDAl As Label
    Friend WithEvents gbDatosUsuario As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnLimpiarCancion As Button
    Friend WithEvents btnCancionPulsa As Button
    Friend WithEvents lblConfirmacionCancion As Label
    Friend WithEvents dtpFechaA As DateTimePicker
    Friend WithEvents lblIDA As Label
    Friend WithEvents btnPulAnadirAlbum As Button
    Friend WithEvents btnLimpiarAlbum As Button
    Friend WithEvents gbAlbumes As GroupBox
    Friend WithEvents btnArtistasPul As Button
    Friend WithEvents cbMis_artistas As GroupBox
    Friend WithEvents lblIDArtista As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAnadirArtistas As Button
    Friend WithEvents lblConfirmacionArtista As Label
    Friend WithEvents btnLimpiarArtista As Button
    Friend WithEvents cbMis_Canciones As GroupBox
    Friend WithEvents lblIDCa As Label
    Friend WithEvents lblIDC As Label
    Friend WithEvents lblNombreC As Label
    Friend WithEvents lblAlbumC As Label
    Friend WithEvents txtDuracionC As TextBox
    Friend WithEvents lblDuracionC As Label
    Friend WithEvents txtNombreC As TextBox
    Friend WithEvents btnModificarArtPul As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblHistorial As Label
    Friend WithEvents lstHistorial As ListBox
    Friend WithEvents btnImagenAlbum As Button
    Friend WithEvents odfimagen As OpenFileDialog
    Friend WithEvents cbAlbumC As ComboBox
    Friend WithEvents btnAnadirImagenArtista As Button
    Friend WithEvents btnModificarAlbum As Button
    Friend WithEvents btnModificarCancion As Button
    Friend WithEvents consultas As TabPage
    Friend WithEvents pbPlayInicio As PictureBox
    Friend WithEvents pbPauseInicio As PictureBox
    Friend WithEvents lblConfirmaA As Label
    Friend WithEvents lstResultados As ListBox
    Friend WithEvents lblPregunta As Label
    Friend WithEvents txtPaisConsulta As TextBox
    Friend WithEvents btnConsulta1 As Button
    Friend WithEvents btnConsulta2 As Button
    Friend WithEvents btnConsulta3 As Button
    Friend WithEvents lblHasta As Label
    Friend WithEvents lblDesde As Label
    Friend WithEvents dtpFin As DateTimePicker
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents cbUser As ComboBox
    Friend WithEvents ImageListPestanas As ImageList
    Friend WithEvents btnConsulta5 As Button
    Friend WithEvents btnConsulta4 As Button
End Class
