Public Class UserBLL

    Public Shared Function Login(username As String, password As String) As User

        If String.IsNullOrEmpty(username) Then
            Throw New ArgumentNullException("Nombre de Usuario", "EL nombre de usuario no puede estar vacío.")
        End If

        If String.IsNullOrEmpty(password) Then
            Throw New ArgumentNullException("Contraseña", "La contraseña no puede estar vacía.")
        End If

        Return UserDAL.Authenticate(username, password)
    End Function

    Public Shared Function GetAllUsers() As List(Of User)
        Return UserDAL.GetAllUsers()
    End Function

    Public Shared Function AddUser(user As User) As Boolean
        If String.IsNullOrEmpty(user.Username) Then
            Throw New ArgumentNullException("Nombre de Usuario", "El nombre de usuario no puede estar vacío.")
        End If

        If String.IsNullOrEmpty(user.Password) Then
            Throw New ArgumentNullException("Contraseña", "La contraseña no puede estar vacía.")
        End If

        If String.IsNullOrEmpty(user.Email) Then
            Throw New ArgumentNullException("Email", "El email no puede estar vacío.")
        End If

        Dim emailRegex As New Text.RegularExpressions.Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        If Not emailRegex.IsMatch(user.Email) Then
            Throw New ArgumentException("El email no tiene un formato válido.", "Email")
        End If

        If String.IsNullOrEmpty(user.Role) Then
            Throw New ArgumentNullException("Rol", "El rol no puede estar vacío.")
        End If

        Return UserDAL.AddUser(user)
    End Function

    Public Shared Function UpdateUser(user As User) As Boolean
        If String.IsNullOrEmpty(user.Username) Then
            Throw New ArgumentNullException("Nombre de Usuario", "El nombre de usuario no puede estar vacío.")
        End If

        If String.IsNullOrEmpty(user.Password) Then
            Throw New ArgumentNullException("Contraseña", "La contraseña no puede estar vacía.")
        End If

        If String.IsNullOrEmpty(user.Email) Then
            Throw New ArgumentNullException("Email", "El email no puede estar vacío.")
        End If

        Dim emailRegex As New Text.RegularExpressions.Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        If Not emailRegex.IsMatch(user.Email) Then
            Throw New ArgumentException("El email no tiene un formato válido.", "Email")
        End If

        If String.IsNullOrEmpty(user.Role) Then
            Throw New ArgumentNullException("Rol", "El rol no puede estar vacío.")
        End If

        Return UserDAL.UpdateUser(user)
    End Function

    Public Shared Function DeleteUser(userID As Guid) As Boolean
        Return UserDAL.DeleteUser(userID)
    End Function

End Class
