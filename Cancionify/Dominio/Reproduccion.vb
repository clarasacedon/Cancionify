Public Class Reproduccion
    Public Property IdReproduccion As Integer
    Public Property Usuario As Usuario
    Public Property Cancion As Cancion
    Public Property Fecha As Date

    Public ReadOnly Property ReproduccionDAO As ReproduccionDAO

    Public Sub New()
        Me.ReproduccionDAO = New ReproduccionDAO
    End Sub

    Public Sub New(idReproduccion As String)
        Me.ReproduccionDAO = New ReproduccionDAO
        Me.IdReproduccion = idReproduccion
        Me.Usuario = Usuario
        Me.Cancion = Cancion
        Me.Fecha = Fecha
    End Sub

    Public Sub LeerTodasReproducciones()
        Me.ReproduccionDAO.LeerTodasReproducciones()
    End Sub

    Public Sub LeerReproduccion()
        Me.ReproduccionDAO.LeerReproduccion(Me)
    End Sub

    Public Function InsertarReproduccion() As Integer
        Return Me.ReproduccionDAO.InsertarReproduccion(Me)
    End Function

    Public Function ModificarReproduccion() As Integer
        Return Me.ReproduccionDAO.ActualizarReproduccion(Me)
    End Function

    Public Function BorrarReproduccion() As Integer
        Return Me.ReproduccionDAO.BorrarReproduccion(Me)
    End Function

    Public Sub consulta3()
        Me.ReproduccionDAO.consulta3(Me)
    End Sub

End Class

