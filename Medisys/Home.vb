Public Class Home
    Dim ucUsers = New ucUsers()
    Dim ucSpecialties = New ucEmployees()
    Dim currentTab As String

    Private Sub Home_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        UpdateInfo()

        Select Case currentTab
            Case "Users"
                ucUsers.RefreshData()
            Case "Specialties"
                ucSpecialties.RefreshData()
        End Select
    End Sub

    Private Sub UpdateInfo()
        txtRole.Text = Session.user.Role
        txtUsername.Text = Session.user.Username
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        HandleTabChange("Users")
    End Sub

    Private Sub HandleTabChange(tab As String)
        mainPanel.Controls.Clear()

        Select Case tab
            Case "Users"
                mainPanel.Controls.Add(ucUsers)
            Case "Specialties"
                mainPanel.Controls.Add(ucSpecialties)
            Case "Settings"
            Case "Reports"
            Case Else
        End Select

        currentTab = tab
        mainPanel.Controls(0).Dock = DockStyle.Fill
    End Sub

    Private Sub btnSpecialties_Click(sender As Object, e As EventArgs) Handles btnSpecialties.Click
        HandleTabChange("Specialties")
    End Sub

    Private Sub Home_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click

    End Sub
End Class