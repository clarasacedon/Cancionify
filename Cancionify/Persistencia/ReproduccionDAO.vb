Public Class ReproduccionDAO
    Public ReadOnly Property Reproducciones As Collection

    Public Sub New()
        Me.Reproducciones = New Collection
    End Sub

    Public Sub LeerTodasReproducciones()
        Dim u As Reproduccion
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM REPRODUCCIONES ORDER BY IdReproduccion")
        For Each aux In col
            u = New Reproduccion(aux(1).ToString)
            u.Usuario = New Usuario(aux(2).ToString)
            u.Usuario.LeerUsuario()
            u.Cancion = New Cancion(Convert.ToInt32(aux(3).ToString))
            u.Cancion.LeerCancion()
            u.Fecha = aux(4).ToString
            Me.Reproducciones.Add(u)
        Next
    End Sub

    Public Sub LeerReproduccion(ByRef u As Reproduccion)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM REPRODUCCIONES WHERE IdReproduccion=" & u.IdReproduccion & ";")
        For Each aux In col
            u = New Reproduccion(aux(1).ToString)
            u.Usuario = New Usuario(aux(2).ToString)
            u.Usuario.LeerUsuario()
            u.Cancion = New Cancion(Convert.ToInt32(aux(3).ToString))
            u.Cancion.LeerCancion()
            u.Fecha = aux(4).ToString
        Next
    End Sub

    Public Function InsertarReproduccion(ByVal u As Reproduccion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO REPRODUCCIONES (Usuario,Cancion,Fecha) VALUES ('" & u.Usuario.Email & "', " & u.Cancion.IdCancion & ", #" & u.Fecha & "#);")
    End Function

    Public Function ActualizarReproduccion(ByVal u As Reproduccion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE REPRODUCCIONES SET Cancion=" & u.Cancion.IdCancion & " ,Fecha=#" & u.Fecha & "#;")
    End Function

    Public Function BorrarReproduccion(ByVal u As Reproduccion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM REPRODUCCIONES WHERE IdReproduccion =" & u.IdReproduccion & ";")
    End Function

    Public Sub consulta3(r As Reproduccion)
        Dim col As Collection : Dim aux As Collection

        col = AgenteBD.ObtenerAgente.Leer("SELECT ARTISTAS.Nombre, Sum((Int(0 & [CuentaDeFecha]))) As Reproducciones
            From ARTISTAS LEFT Join (Select ARTISTAS.Nombre, Count(Reproducciones.Fecha) As CuentaDeFecha, Min(REPRODUCCIONES.Fecha) As MínDeFecha, Max(REPRODUCCIONES.Fecha) As MáxDeFecha
            From USUARIOS INNER Join ((ARTISTAS INNER Join (ALBUMES INNER Join CANCIONES On ALBUMES.IdAlbum = CANCIONES.Album) ON ARTISTAS.IdArtista = ALBUMES.Artista) INNER Join REPRODUCCIONES On CANCIONES.IdCancion = REPRODUCCIONES.Cancion) ON USUARIOS.Email = REPRODUCCIONES.Usuario
            Where (((REPRODUCCIONES.Usuario) ='" & r.Usuario.Email & "'))
            Group By ARTISTAS.Nombre
            HAVING(((Min(Reproducciones.Fecha)) = # " & r.Fecha & " #)) Or (((Max(REPRODUCCIONES.Fecha))=# " & r.Fecha & " #))
            ) as Consulta7 ON ARTISTAS.Nombre = Consulta7.Nombre
            GROUP BY ARTISTAS.Nombre
            ORDER BY Sum((Int(0 & [CuentaDeFecha]))) DESC;")

        For Each aux In col
            Me.Reproducciones.Add(aux(1).ToString & " - " & aux(2).ToString)
        Next
    End Sub

End Class
