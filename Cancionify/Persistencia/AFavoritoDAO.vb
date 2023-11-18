Public Class AFavoritoDAO
    Public ReadOnly Property AFavoritos As Collection

    Public Sub New()
        Me.AFavoritos = New Collection
    End Sub

    Public Sub LeerTodosAFavorito()
        Dim u As AFavorito
        Dim usuario As Usuario
        Dim artista As Artista
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM ARTISTAS_FAVORITOS ORDER BY Usuario")

        For Each aux In col
            usuario = New Usuario(aux(1).ToString)
            usuario.LeerUsuario()
            artista = New Artista(Convert.ToInt32(aux(2).ToString))
            artista.LeerArtista()
            u = New AFavorito(usuario, artista)
            u.Fecha = aux(3).ToString
            Me.AFavoritos.Add(u)
        Next
    End Sub

    Public Sub LeerAFavorito(ByRef u As AFavorito)
        Dim col As Collection : Dim aux As Collection
        Dim usuario As Usuario
        Dim artista As Artista
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM ARTISTAS_FAVORITOS WHERE Usuario='" & u.Usuario.Email & "';")
        For Each aux In col
            usuario = New Usuario(aux(1).ToString)
            usuario.LeerUsuario()
            artista = New Artista(Convert.ToInt32(aux(2).ToString))
            artista.LeerArtista()
            u = New AFavorito(usuario, artista)
            u.Fecha = aux(3).ToString
            u.Fecha = aux(3).ToString
        Next
    End Sub

    Public Function InsertarAFavorito(ByVal u As AFavorito) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO ARTISTAS_FAVORITOS VALUES ('" & u.Usuario.Email & "', " & u.Artista.IdArtista & ", #" & u.Fecha & "#);")
    End Function

    Public Function BorrarAFavoritoEspecifico(ByVal u As AFavorito) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM ARTISTAS_FAVORITOS WHERE Usuario='" & u.Usuario.Email & "' AND Artista=" & u.Artista.IdArtista & ";")
    End Function

    Public Function BorrarAFavorito(ByVal u As AFavorito) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM ARTISTAS_FAVORITOS WHERE Artista=" & u.Artista.IdArtista & ";")
    End Function

    Public Function BorrarAFavoritoUsuario(ByVal u As AFavorito) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM ARTISTAS_FAVORITOS WHERE Usuario='" & u.Usuario.Email & "';")
    End Function

    Public Sub consulta5(r As Reproduccion, a As AFavorito)
        Dim col As Collection : Dim aux As Collection

        'col = AgenteBD.ObtenerAgente.Leer("SELECT Sum(CANCIONES.Duracion) AS SumaDeDuracion, ARTISTAS.Nombre
        '     FROM ((ARTISTAS INNER JOIN ARTISTAS_FAVORITOS ON ARTISTAS.IdArtista = ARTISTAS_FAVORITOS.Artista) 
        '     INNER JOIN (ALBUMES INNER JOIN CANCIONES ON ALBUMES.IdAlbum = CANCIONES.Album) 
        '     ON ARTISTAS.IdArtista = ALBUMES.Artista) INNER JOIN REPRODUCCIONES 
        '     ON CANCIONES.IdCancion = REPRODUCCIONES.Cancion
        '     WHERE (((REPRODUCCIONES.Usuario)='" & r.Usuario.Email & "') 
        '     AND ((ARTISTAS_FAVORITOS.Usuario)='" & a.Usuario.Email & "'))
        '     GROUP BY ARTISTAS.Nombre;")

        'For Each aux In col
        '    Me.AFavoritos.Add(aux(1).ToString & " - " & aux(2).ToString)
        'Next
    End Sub

End Class
