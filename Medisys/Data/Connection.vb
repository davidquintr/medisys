Imports Microsoft.Data.SqlClient

Namespace Data
    Public Class Connection
        Private Shared connectionString As String = "Data Source=localhost;Initial Catalog=Medisys;Integrated Security=True;Encrypt=False"

        Public Shared Function GetConnection() As SqlConnection
            Try
                Return New SqlConnection(connectionString)
            Catch ex As Exception
                Throw New Exception("Database connection error: " & ex.Message)
            End Try
        End Function
    End Class
End Namespace
