Public Class Cancion
    Public Property IdCancion As Integer
    Public Property Nombre As String
    Public Property Album As Album
    Public Property Duracion As Integer

    Public ReadOnly Property CancionDAO As CancionDAO

    Public Sub New()
        Me.CancionDAO = New CancionDAO
    End Sub

    Public Sub New(idCancion As Integer)
        Me.CancionDAO = New CancionDAO
        Me.IdCancion = idCancion
        Me.Nombre = Nombre
        Me.Album = Album
        Me.Duracion = Duracion
    End Sub

    Public Sub LeerTodasCanciones()
        Me.CancionDAO.LeerTodasCanciones()
    End Sub

    Public Sub LeerCancion()
        Me.CancionDAO.LeerCancion(Me)
    End Sub

    Public Function InsertarCancion() As Integer
        Return Me.CancionDAO.InsertarCancion(Me)
    End Function

    Public Function ModificarCancion() As Integer
        Return Me.CancionDAO.ActualizarCancion(Me)
    End Function

    Public Function BorrarCancion() As Integer
        Return Me.CancionDAO.BorrarCancion(Me)
    End Function

    Public Sub consulta2()
        Me.CancionDAO.consulta2(Me)
    End Sub

End Class

