Imports Medisys.Data
Imports Microsoft.Data.SqlClient

Public Class SpecialtyDAL

    Public Shared Function GetAllSpecialties() As List(Of Specialty)
        Dim specialties As New List(Of Specialty)()
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = $"SELECT * FROM [Specialty] where State <> {CInt(State.Deleted)}"
                Dim cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim specialty As New Specialty()
                    specialty.ID = reader("ID")
                    specialty.Name = reader("Name")
                    specialty.State = reader("State")
                    specialties.Add(specialty)
                End While
            End Using
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
        Return specialties
    End Function

    Public Shared Function AddSpecialty(specialty As Specialty) As Boolean
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = "INSERT INTO [Specialty] (Name) VALUES (@Name)"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Name", specialty.Name)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function UpdateSpecialty(specialty As Specialty) As Boolean
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = $"UPDATE [Specialty] SET Name = @Name, State = {CInt(State.Modified)} WHERE ID = @ID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Name", specialty.Name)
                cmd.Parameters.AddWithValue("@ID", specialty.ID)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function DeleteSpecialty(specialtyID As Guid) As Boolean
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = "UPDATE [Specialty] SET State = @State WHERE ID = @ID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", specialtyID)
                cmd.Parameters.AddWithValue("@State", State.Deleted)
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
