Public Class CancionDAO

    Public ReadOnly Property Canciones As Collection

    Public Sub New()
        Me.Canciones = New Collection
    End Sub

    Public Sub LeerTodasCanciones()
        Dim u As Cancion
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM CANCIONES ORDER BY IdCancion")
        For Each aux In col
            u = New Cancion(aux(1).ToString)
            u.Nombre = aux(2).ToString
            u.Album = New Album(Convert.ToInt32(aux(3).ToString))
            u.Album.LeerAlbum()
            u.Duracion = aux(4).ToString
            Me.Canciones.Add(u)
        Next
    End Sub

    Public Sub LeerCancion(ByRef u As Cancion)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM CANCIONES WHERE IdCancion=" & u.IdCancion & ";")
        For Each aux In col
            u = New Cancion(aux(1).ToString)
            u.Nombre = aux(2).ToString
            u.Album = New Album(Convert.ToInt32(aux(3).ToString))
            u.Album.LeerAlbum()
            u.Duracion = aux(4).ToString
        Next
    End Sub

    Public Function InsertarCancion(ByVal u As Cancion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO CANCIONES (Nombre,Album,Duracion) VALUES ( '" & u.Nombre & "', " & u.Album.idAlbum & ", " & u.Duracion & ");")
    End Function

    Public Function ActualizarCancion(ByVal u As Cancion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE CANCIONES SET Nombre='" & u.Nombre & "', Album=" & u.Album.idAlbum & ", Duracion=" & u.Duracion & " WHERE IdCancion=" & u.IdCancion & " ;")
    End Function

    Public Function BorrarCancion(ByVal u As Cancion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM CANCIONES WHERE IdCancion=" & u.IdCancion & ";")
    End Function

    Public Sub consulta2(cancion As Cancion)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT Int(0 & [CuentaDeIdReproduccion]) AS Reproducciones, CANCIONES.Nombre
            FROM CANCIONES LEFT JOIN (SELECT CANCIONES.Nombre, Count(REPRODUCCIONES.IdReproduccion) AS CuentaDeIdReproduccion
            FROM CANCIONES INNER JOIN REPRODUCCIONES ON CANCIONES.IdCancion = REPRODUCCIONES.Cancion
            GROUP BY CANCIONES.Nombre) as Consulta3 ON CANCIONES.Nombre = Consulta3.Nombre
            GROUP BY Int(0 & [CuentaDeIdReproduccion]), CANCIONES.Nombre
            ORDER BY Int(0 & [CuentaDeIdReproduccion]) DESC;")
        For Each aux In col
            Me.Canciones.Add(aux(2).ToString & " - " & aux(1).ToString)
        Next
    End Sub

End Class
