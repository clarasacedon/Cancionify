Imports Microsoft.VisualBasic

Public Class Usuario
    Public Property Email As String
    Public Property Nombre As String
    Public Property Apellidos As String
    Public Property FechaNacimiento As Date
    Public ReadOnly Property UsuarioDAO As UsuarioDAO

    Public Sub New()
        Me.UsuarioDAO = New UsuarioDAO
    End Sub

    Public Sub New(Email As String)
        Me.UsuarioDAO = New UsuarioDAO
        Me.Email = Email
        Me.Nombre = Nombre
        Me.Apellidos = Apellidos
        Me.FechaNacimiento = FechaNacimiento
    End Sub

    Public Sub LeerTodosUsuarios(ruta As String)
        Me.UsuarioDAO.LeerTodosUsuarios(ruta)
    End Sub

    Public Sub LeerTodosUsuarios()
        Me.UsuarioDAO.LeerTodosUsuarios()
    End Sub

    Public Sub LeerUsuario()
        Me.UsuarioDAO.LeerUsuario(Me)
    End Sub

    Public Function InsertarUsuario() As Integer
        Return Me.UsuarioDAO.InsertarUsuario(Me)
    End Function

    Public Function ActualizarUsuario() As Integer
        Return Me.UsuarioDAO.ActualizarUsuario(Me)
    End Function

    Public Function BorrarUsuario() As Integer
        Return Me.UsuarioDAO.BorrarUsuario(Me)
    End Function

    Public Sub consulta4()
        Me.UsuarioDAO.consulta4(Me)
    End Sub

End Class
