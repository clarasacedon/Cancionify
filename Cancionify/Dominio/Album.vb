Public Class Album
    Public Property idAlbum As Integer
    Public Property Nombre As String
    Public Property Fecha As Date
    Public Property Artista As Artista

    Public Property Portada As String
    Public ReadOnly Property AlbumDAO As AlbumDAO

    Public Sub New()
        Me.AlbumDAO = New AlbumDAO
    End Sub

    Public Sub New(idAlbum As Integer)
        Me.AlbumDAO = New AlbumDAO
        Me.idAlbum = idAlbum
        Me.Nombre = Nombre
        Me.Fecha = Fecha
        Me.Artista = Artista
        Me.Portada = Portada
    End Sub

    Public Sub LeerTodosAlbum()
        Me.AlbumDAO.LeerTodosAlbum()
    End Sub

    Public Sub LeerAlbum()
        Me.AlbumDAO.LeerAlbum(Me)
    End Sub

    Public Function InsertarAlbum() As Integer
        Return Me.AlbumDAO.InsertarAlbum(Me)
    End Function

    Public Function ActualizarAlbum() As Integer
        Return Me.AlbumDAO.ActualizarAlbum(Me)
    End Function

    Public Function BorrarAlbum() As Integer
        Return Me.AlbumDAO.BorrarAlbum(Me)
    End Function

End Class

