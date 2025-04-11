Imports Medisys.Data
Imports Microsoft.Data.SqlClient

Public Class PatientConditionDAL
    Public Shared Function GetAllPatientConditionsByPatient(patientID As Guid) As List(Of PatientCondition)
        Dim patientConditions As New List(Of PatientCondition)()
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = $"SELECT * FROM [PatientCondition] where IDPatient = @IDPatient"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@IDPatient", patientID)
                conn.Open()

                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim patientCondition As New PatientCondition()

                    patientCondition.ID = reader("ID")
                    patientCondition.IDPatient = reader("IDPatient")
                    patientCondition.IDCondition = reader("IDCondition")
                    patientConditions.Add(patientCondition)
                End While
            End Using
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
        Return patientConditions
    End Function

    Public Shared Function AddPatientCondition(patientCondition As PatientCondition) As Boolean
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = $"INSERT INTO [PatientCondition] (IDPatient, IDCondition) VALUES (@IDPatient, @IDCondition)"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@IDPatient", patientCondition.IDPatient)
                cmd.Parameters.AddWithValue("@IDCondition", patientCondition.IDCondition)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
            Return True
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function RemoveAllPatientConditionsByPatient(patientID As Guid) As Boolean
        Try
            Using conn As SqlConnection = Connection.GetConnection()
                Dim query As String = $"DELETE FROM [PatientCondition] WHERE IDPatient = @IDPatient"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@IDPatient", patientID)
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
