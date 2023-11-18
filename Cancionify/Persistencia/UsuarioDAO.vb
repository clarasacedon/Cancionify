Public Class UsuarioDAO
    Public ReadOnly Property Usuarios As Collection

    Public Sub New()
        Me.Usuarios = New Collection
    End Sub

    Public Sub LeerTodosUsuarios(ruta As String)
        Dim u As Usuario
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente(ruta).Leer("SELECT * FROM USUARIOS ORDER BY Email")
        For Each aux In col
            u = New Usuario(aux(1).ToString)
            u.Nombre = aux(2).ToString
            u.Apellidos = aux(3).ToString
            u.FechaNacimiento = aux(4).ToString
            Me.Usuarios.Add(u)
        Next
    End Sub

    Public Sub LeerTodosUsuarios()
        Dim u As Usuario
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM USUARIOS ORDER BY Email")
        For Each aux In col
            u = New Usuario(aux(1).ToString)
            u.Nombre = aux(2).ToString
            u.Apellidos = aux(3).ToString
            u.FechaNacimiento = aux(4).ToString
            Me.Usuarios.Add(u)
        Next
    End Sub

    Public Sub LeerUsuario(ByRef u As Usuario)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM USUARIOS WHERE Email ='" & u.Email & "';")
        For Each aux In col
            u.Nombre = aux(2).ToString
            u.Apellidos = aux(3).ToString
            u.FechaNacimiento = aux(4).ToString
        Next
    End Sub

    Public Function InsertarUsuario(ByVal u As Usuario) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO USUARIOS VALUES ('" & u.Email & "', '" & u.Nombre & "', '" & u.Apellidos & "', '" & u.FechaNacimiento & "');")
    End Function

    Public Function ActualizarUsuario(ByVal u As Usuario) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE USUARIOS SET Nombre='" & u.Nombre & "', Apellidos='" & u.Apellidos & "' , FechaNacimiento='" & u.FechaNacimiento & " ' WHERE Email='" & u.Email & "';")
    End Function

    Public Function BorrarUsuario(ByVal u As Usuario) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM USUARIOS WHERE Email='" & u.Email & "';")
    End Function

    Public Sub consulta4(u As Usuario)
        Dim col As Collection : Dim aux As Collection

        col = AgenteBD.ObtenerAgente.Leer("SELECT Sum(CANCIONES.Duracion) AS SumaDeDuracion, REPRODUCCIONES.Usuario
            FROM ARTISTAS INNER JOIN (ALBUMES INNER JOIN (CANCIONES INNER JOIN REPRODUCCIONES 
            ON CANCIONES.IdCancion = REPRODUCCIONES.Cancion) ON ALBUMES.IdAlbum = CANCIONES.Album) 
            ON ARTISTAS.IdArtista = ALBUMES.Artista
            GROUP BY REPRODUCCIONES.Usuario
            ORDER BY Sum(CANCIONES.Duracion) DESC;")

        For Each aux In col
            Me.Usuarios.Add(aux(1).ToString & " - " & aux(2).ToString)
        Next
    End Sub

End Class
