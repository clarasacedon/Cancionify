Public Class AlbumDAO
    Public ReadOnly Property Album As Collection

    Public Sub New()
        Me.Album = New Collection

    End Sub

    Public Sub LeerTodosAlbum()
        Dim u As Album
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM ALBUMES ORDER BY IdAlbum")
        For Each aux In col
            u = New Album(aux(1).ToString)
            u.Nombre = aux(2).ToString
            u.Fecha = aux(3).ToString
            u.Artista = New Artista(Convert.ToInt32(aux(4).ToString))
            u.Artista.LeerArtista()
            u.Portada = aux(5).ToString
            Me.Album.Add(u)
        Next
    End Sub

    Public Sub LeerAlbum(ByRef u As Album)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM ALBUMES WHERE IdAlbum=" & u.idAlbum & ";")
        For Each aux In col
            u = New Album(aux(1).ToString)
            u.Nombre = aux(2).ToString
            u.Fecha = aux(3).ToString
            u.Artista = New Artista(Convert.ToInt32(aux(4).ToString))
            u.Artista.LeerArtista()
            u.Portada = aux(5).ToString
        Next
    End Sub

    Public Function InsertarAlbum(ByVal u As Album) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO ALBUMES (Nombre,Fecha,Artista,Portada) VALUES ( '" & u.Nombre & "', '" & u.Fecha & "', " & u.Artista.IdArtista & ",'" & u.Portada & "');")
    End Function

    Public Function ActualizarAlbum(ByVal u As Album) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE ALBUMES SET Nombre='" & u.Nombre & "' , Fecha= '" & u.Fecha & "' , Artista=" & u.Artista.IdArtista & ",Portada='" & u.Portada & "' WHERE IdAlbum=" & u.idAlbum & ";")
    End Function

    Public Function BorrarAlbum(ByVal u As Album) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM ALBUMES WHERE IDAlbum=" & u.idAlbum & ";")
    End Function

End Class
