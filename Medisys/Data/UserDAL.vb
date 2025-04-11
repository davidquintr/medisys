Imports Medisys.Data
Imports Microsoft.Data.SqlClient

Public Class UserDAL
    Public Shared Function Authenticate(username As String, password As String) As User
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = $"SELECT * FROM [User] WHERE Username = @username AND Password = @password and State <> {CInt(State.Deleted)}"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)

                conn.Open()

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    Dim user As New User()
                    While reader.Read()
                        user.ID = reader("ID")
                        user.Username = reader("Username")
                        user.Password = reader("Password")
                        user.Email = reader("Email")
                        user.Role = reader("Role")
                        user.State = reader("State")
                    End While
                    Return user
                Else
                    Return Nothing
                End If

            End Using
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function GetAllUsers() As List(Of User)
        Dim users As New List(Of User)()
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = $"SELECT * FROM [User] where State <> {CInt(State.Deleted)}"
                Dim cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim user As New User()
                    user.ID = reader("ID")
                    user.Username = reader("Username")
                    user.Password = reader("Password")
                    user.Email = reader("Email")
                    user.Role = reader("Role")
                    user.State = reader("State")
                    users.Add(user)
                End While
            End Using
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
        Return users
    End Function

    Public Shared Function AddUser(user As User) As Boolean
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = "INSERT INTO [User] (Username, Password, Email, Role) VALUES (@Username, @Password, @Email, @Role)"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", user.Username)
                cmd.Parameters.AddWithValue("@Password", user.Password)
                cmd.Parameters.AddWithValue("@Email", user.Email)
                cmd.Parameters.AddWithValue("@Role", user.Role)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function UpdateUser(user As User) As Boolean
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = "UPDATE [User] SET Username = @Username, Password = @Password, Email = @Email, Role = @Role, State = @State WHERE ID = @ID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", user.ID)
                cmd.Parameters.AddWithValue("@Username", user.Username)
                cmd.Parameters.AddWithValue("@Password", user.Password)
                cmd.Parameters.AddWithValue("@Email", user.Email)
                cmd.Parameters.AddWithValue("@Role", user.Role)
                cmd.Parameters.AddWithValue("@State", State.Modified)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function DeleteUser(userID As Guid) As Boolean
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = "UPDATE [User] SET State = @State WHERE ID = @ID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@State", State.Deleted)
                cmd.Parameters.AddWithValue("@ID", userID)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function GetAllEmployeeUser() As List(Of ViewEmployeeUser)
        Dim employeeUsers As New List(Of ViewEmployeeUser)()
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = $"SELECT * FROM [[ViewEmployeeUser]] where State <> {CInt(State.Deleted)}"
                Dim cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim user As New ViewEmployeeUser()
                    user.ID = reader("ID")
                    user.Username = reader("Username")
                    user.Address = reader("Address")
                    user.Name = reader("Name")
                    user.LastName = reader("LastName")
                    user.State = reader("State")
                    employeeUsers.Add(user)
                End While
            End Using
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
        Return employeeUsers
    End Function

End Class
