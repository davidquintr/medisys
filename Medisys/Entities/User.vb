Public Class User
    Public Property ID As Guid
    Public Property Username As String
    Public Property Password As String
    Public Property Email As String
    Public Property Role As String ' "admin" or "doctor"
    Public Property State As State '0 - new, 1 - modified, 2 - deleted'
End Class
