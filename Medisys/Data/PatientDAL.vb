Imports Medisys.Data
Imports Microsoft.Data.SqlClient

Public Class PatientDAL

    Public Shared Function GetAllPatients() As List(Of Patient)
        Dim patients As New List(Of Patient)
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = $"SELECT * FROM [Patient] where State <> {CInt(State.Deleted)}"
                Dim cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim patient As New Patient()
                    patient.ID = reader("ID")
                    patient.Name = reader("Name")
                    patient.Lastname = reader("LastName")
                    patient.Address = If(IsDBNull(reader("Address")), "", reader("Address"))
                    patient.Sex = reader("Sex")
                    patient.State = reader("State")
                    patient.PhoneNumber = If(IsDBNull(reader("PhoneNumber")), "", reader("PhoneNumber"))
                    patient.IdentityCard = If(IsDBNull(reader("IdentityCard")), "", reader("IdentityCard"))
                    patient.AvatarURI = If(IsDBNull(reader("AvatarURI")), "", reader("AvatarURI"))
                    patients.Add(patient)
                End While
            End Using
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
        Return patients
    End Function

    Public Shared Function AddPatient(patient As Patient) As Boolean
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = "INSERT INTO [Patient] (Name, LastName, Address, Sex, IdentityCard, PhoneNumber, RegisterDate, AvatarURI) VALUES (@Name, @LastName, @Address, @Sex, @IdentityCard, @PhoneNumber, GETDATE(), @AvatarURI)"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Name", patient.Name)
                cmd.Parameters.AddWithValue("@LastName", patient.Lastname)
                cmd.Parameters.AddWithValue("@Address", patient.Address)
                cmd.Parameters.AddWithValue("@Sex", patient.Sex)
                cmd.Parameters.AddWithValue("@IdentityCard", patient.IdentityCard)
                cmd.Parameters.AddWithValue("@PhoneNumber", patient.PhoneNumber)
                cmd.Parameters.AddWithValue("@AvatarURI", patient.AvatarURI)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function UpdatePatient(patient As Patient) As Boolean
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = "UPDATE [Patient] SET Name = @Name, LastName = @LastName, Address = @Address, Sex = @Sex, IdentityCard = @IdentityCard, PhoneNumber = @PhoneNumber, AvatarURI = @AvatarURI WHERE ID = @ID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Name", patient.Name)
                cmd.Parameters.AddWithValue("@LastName", patient.Lastname)
                cmd.Parameters.AddWithValue("@Address", patient.Address)
                cmd.Parameters.AddWithValue("@Sex", patient.Sex)
                cmd.Parameters.AddWithValue("@IdentityCard", patient.IdentityCard)
                cmd.Parameters.AddWithValue("@PhoneNumber", patient.PhoneNumber)
                cmd.Parameters.AddWithValue("@AvatarURI", patient.AvatarURI)
                cmd.Parameters.AddWithValue("@ID", patient.ID)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function DeletePatient(patientID As Guid) As Boolean
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = "DELETE FROM [Patient] WHERE ID = @ID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", patientID)
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

