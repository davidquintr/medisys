Imports Medisys.Data
Imports Microsoft.Data.SqlClient

Public Class ConditionDAL
    Public Shared Function GetAllConditions() As List(Of Condition)
        Dim conditions As New List(Of Condition)()
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = $"SELECT * FROM [Condition] where State <> {CInt(State.Deleted)}"
                Dim cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim condition As New Condition()
                    condition.ID = reader("ID")
                    condition.Name = reader("Name")
                    condition.Description = reader("Description")
                    condition.State = reader("State")
                    conditions.Add(condition)
                End While
            End Using
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
        Return conditions
    End Function

    Public Shared Function AddCondition(condition As Condition) As Boolean
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = "INSERT INTO [Condition] (Name, Description, State) VALUES (@Name, @Description, @State)"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Name", condition.Name)
                cmd.Parameters.AddWithValue("@Description", condition.Description)
                cmd.Parameters.AddWithValue("@State", condition.State)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function UpdateCondition(condition As Condition) As Boolean
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = "UPDATE [Condition] SET Name = @Name, Description = @Description, State = @State WHERE ID = @ID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Name", condition.Name)
                cmd.Parameters.AddWithValue("@Description", condition.Description)
                cmd.Parameters.AddWithValue("@State", condition.State)
                cmd.Parameters.AddWithValue("@ID", condition.ID)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function DeleteCondition(conditionID As Guid) As Boolean
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = "UPDATE [Condition] SET State = @State WHERE ID = @ID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@State", State.Deleted)
                cmd.Parameters.AddWithValue("@ID", conditionID)
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
