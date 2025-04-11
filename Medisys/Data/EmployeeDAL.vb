Imports Medisys.Data
Imports Microsoft.Data.SqlClient

Public Class EmployeeDAL

    Public Shared Function GetAllEmployees() As List(Of Employee)
        Dim employees As New List(Of Employee)()
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = $"SELECT * FROM [Employee] where State <> {CInt(State.Deleted)}"
                Dim cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim employee As New Employee()
                    employee.ID = reader("ID")
                    employee.Name = reader("Name")
                    employee.Lastname = reader("LastName")
                    employee.Address = If(IsDBNull(reader("Address")), "", reader("Address"))
                    employee.Sex = reader("Sex")
                    employee.State = reader("State")
                    employee.IDUser = If(IsDBNull(reader("IDUser")), Guid.Empty, reader("IDUser"))
                    employee.IDSpecialty = If(IsDBNull(reader("IDSpecialty")), Guid.Empty, reader("IDSpecialty"))
                    employees.Add(employee)
                End While
            End Using
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
        Return employees
    End Function

    Public Shared Function GetAllEmployeeUser() As List(Of ViewEmployeeUser)
        Dim employeeUsers As New List(Of ViewEmployeeUser)()
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = $"SELECT * FROM [ViewEmployeeUser] where State <> {CInt(State.Deleted)}"
                Dim cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim user As New ViewEmployeeUser()
                    user.ID = reader("ID")
                    user.Username = If(IsDBNull(reader("Username")), "", reader("Username"))
                    user.Address = If(IsDBNull(reader("Address")), "", reader("Address"))
                    user.Name = reader("Name")
                    user.Sex = reader("Sex")
                    user.LastName = reader("LastName")
                    user.State = reader("State")
                    user.Specialty = If(IsDBNull(reader("Specialty")), "", reader("Specialty"))
                    employeeUsers.Add(user)
                End While
            End Using
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
        Return employeeUsers
    End Function

    Public Shared Function AddEmployee(employee As Employee) As Boolean
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = "INSERT INTO [Employee] (Name, LastName, Address, Sex, IDUser, IDSpecialty) VALUES (@Name, @LastName, @Address, @Sex, @IDUser, @IDSpecialty)"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Name", employee.Name)
                cmd.Parameters.AddWithValue("@LastName", employee.LastName)
                cmd.Parameters.AddWithValue("@Address", employee.Address)
                cmd.Parameters.AddWithValue("@Sex", employee.Sex)
                cmd.Parameters.AddWithValue("@IDUser", If(employee.IDUser = Guid.Empty, DBNull.Value, employee.IDUser))
                cmd.Parameters.AddWithValue("@IDSpecialty", If(employee.IDSpecialty = Guid.Empty, DBNull.Value, employee.IDSpecialty))
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function UpdateEmployee(employee As Employee) As Boolean
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = "UPDATE [Employee] SET Name = @Name, LastName = @LastName, Address = @Address, Sex = @Sex, IDUser = @IDUser, IDSpecialty = @IDSpecialty WHERE ID = @ID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", employee.ID)
                cmd.Parameters.AddWithValue("@Name", employee.Name)
                cmd.Parameters.AddWithValue("@LastName", employee.LastName)
                cmd.Parameters.AddWithValue("@Address", employee.Address)
                cmd.Parameters.AddWithValue("@Sex", employee.Sex)
                cmd.Parameters.AddWithValue("@IDUser", employee.IDUser)
                cmd.Parameters.AddWithValue("@IDSpecialty", employee.IDSpecialty)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function DeleteEmployee(employeeID As Guid) As Boolean
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = "UPDATE [Employee] SET State = @State WHERE ID = @ID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@State", State.Deleted)
                cmd.Parameters.AddWithValue("@ID", employeeID)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Return False
        End Try
    End Function


End Class
