Public Class ArtistaDAO

    Public ReadOnly Property Artistas As Collection

    Public Sub New()
        Me.Artistas = New Collection
    End Sub

    Public Sub LeerTodosArtistas()
        Dim a As Artista
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM ARTISTAS ORDER BY IdArtista")
        For Each aux In col
            a = New Artista(aux(1).ToString)
            a.Nombre = aux(2).ToString
            a.Pais = aux(3).ToString
            a.Imagen = aux(4).ToString
            Me.Artistas.Add(a)
        Next
    End Sub

    Public Sub LeerArtista(ByRef a As Artista)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM ARTISTAS WHERE IdArtista=" & a.IdArtista & ";")
        For Each aux In col
            a = New Artista(aux(1).ToString)
            a.Nombre = aux(2).ToString
            a.Pais = aux(3).ToString
            a.Imagen = aux(4).ToString
        Next
    End Sub

    Public Function InsertarArtista(ByVal a As Artista) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO ARTISTAS (Nombre,Pais,Imagen) VALUES ('" & a.Nombre & "', '" & a.Pais & "', '" & a.Imagen & "');")
    End Function

    Public Function ActualizarArtista(ByVal a As Artista) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE ARTISTAS SET Nombre='" & a.Nombre & "', Pais='" & a.Pais & "', Imagen='" & a.Imagen & "' WHERE IdArtista=" & a.IdArtista & " ;")
    End Function

    Public Function BorrarArtista(ByVal a As Artista) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM ARTISTAS WHERE Nombre='" & a.Nombre & "';")
    End Function

    Public Sub consulta1(a As Artista)
        Dim col As Collection : Dim aux As Collection
        If a.Pais = "" Then
            col = AgenteBD.ObtenerAgente.Leer("SELECT ARTISTAS.Nombre, Int(0 & [CuentaDeIdReproduccion]) AS Reproducciones
            FROM ARTISTAS LEFT JOIN (SELECT ARTISTAS.Nombre, Count(REPRODUCCIONES.IdReproduccion) AS CuentaDeIdReproduccion
            FROM (ARTISTAS INNER JOIN (ALBUMES INNER JOIN CANCIONES ON ALBUMES.IdAlbum = CANCIONES.Album) ON ARTISTAS.IdArtista = ALBUMES.Artista) INNER JOIN REPRODUCCIONES ON CANCIONES.IdCancion = REPRODUCCIONES.Cancion
            GROUP BY ARTISTAS.Nombre
            ) as Consulta1 ON ARTISTAS.Nombre = Consulta1.Nombre
            ORDER BY Int(0 & [CuentaDeIdReproduccion]) DESC;")
        Else
            col = AgenteBD.ObtenerAgente.Leer("SELECT ARTISTAS.Nombre, Int(0 & [CuentaDeIdReproduccion]) AS Reproducciones
            FROM ARTISTAS LEFT JOIN (SELECT ARTISTAS.Nombre, Count(REPRODUCCIONES.IdReproduccion) AS CuentaDeIdReproduccion
            FROM (ARTISTAS INNER JOIN (ALBUMES INNER JOIN CANCIONES ON ALBUMES.IdAlbum = CANCIONES.Album) ON ARTISTAS.IdArtista = ALBUMES.Artista) INNER JOIN REPRODUCCIONES ON CANCIONES.IdCancion = REPRODUCCIONES.Cancion
            WHERE (((ARTISTAS.Pais)='" & a.Pais & "'))
            GROUP BY ARTISTAS.Nombre
            ) as Consulta1 ON ARTISTAS.Nombre = Consulta1.Nombre
            WHERE (((ARTISTAS.Pais)='" & a.Pais & "'))
            ORDER BY Int(0 & [CuentaDeIdReproduccion]) DESC;")
        End If
        For Each aux In col
            Me.Artistas.Add(aux(1).ToString & " - " & aux(2).ToString)
        Next
    End Sub

End Class
