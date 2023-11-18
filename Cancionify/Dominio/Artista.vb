Public Class Artista
    Public Property IdArtista As Integer
    Public Property Nombre As String
    Public Property Pais As String
    Public Property Imagen As String
    Public ReadOnly Property ArtistaDAO As ArtistaDAO

    Public Sub New()
        Me.ArtistaDAO = New ArtistaDAO
    End Sub

    Public Sub New(IdArtista As String)
        Me.ArtistaDAO = New ArtistaDAO
        Me.IdArtista = IdArtista
        Me.Nombre = Nombre
        Me.Pais = Pais
        Me.Imagen = Imagen
    End Sub

    Public Sub LeerTodosArtistas()
        Me.ArtistaDAO.LeerTodosArtistas()
    End Sub

    Public Sub LeerArtista()
        Me.ArtistaDAO.LeerArtista(Me)
    End Sub

    Public Function InsertarArtista() As Integer
        Return Me.ArtistaDAO.InsertarArtista(Me)
    End Function

    Public Function ActualizarArtista() As Integer
        Return Me.ArtistaDAO.ActualizarArtista(Me)
    End Function

    Public Function BorrarArtista() As Integer
        Return Me.ArtistaDAO.BorrarArtista(Me)
    End Function

    Public Sub consulta1()
        Me.ArtistaDAO.consulta1(Me)
    End Sub

End Class

