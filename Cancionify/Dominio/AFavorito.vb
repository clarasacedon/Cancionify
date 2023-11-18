Public Class AFavorito
    Public Property Usuario As Usuario
    Public Property Artista As Artista
    Public Property Fecha As Date

    Public ReadOnly Property AFavoritoDAO As AFavoritoDAO

    Public Sub New()
        Me.AFavoritoDAO = New AFavoritoDAO
    End Sub

    Public Sub New(Usuario As Usuario, Artista As Artista)
        Me.AFavoritoDAO = New AFavoritoDAO
        Me.Usuario = Usuario
        Me.Artista = Artista
    End Sub

    Public Sub New(Usuario As Usuario)
        Me.AFavoritoDAO = New AFavoritoDAO
        Me.Usuario = Usuario
    End Sub

    Public Sub LeerTodosAFavorito()
        Me.AFavoritoDAO.LeerTodosAFavorito()
    End Sub

    Public Sub LeerAFavorito()
        Me.AFavoritoDAO.LeerAFavorito(Me)
    End Sub

    Public Function InsertarAFavorito() As Integer
        Return Me.AFavoritoDAO.InsertarAFavorito(Me)
    End Function

    Public Function BorrarAFavoritoEspecifico() As Integer
        Return Me.AFavoritoDAO.BorrarAFavoritoEspecifico(Me)
    End Function

    Public Function BorrarAFavoritoUsuario() As Integer
        Return Me.AFavoritoDAO.BorrarAFavoritoUsuario(Me)
    End Function

    Public Function BorrarAFavorito() As Integer
        Return Me.AFavoritoDAO.BorrarAFavorito(Me)
    End Function

    Public Sub consulta5(r As Reproduccion)
        Me.AFavoritoDAO.consulta5(r, Me)
    End Sub

End Class
