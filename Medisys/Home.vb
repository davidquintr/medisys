Public Class Home
    Enum Tabs
        Users
        Specialties
        Employees
        Patients
        Conditions
    End Enum

    Dim ucUsers = New ucUsers()
    Dim ucSpecialties = New ucEmployees()
    Dim ucEmployees = New ucEmployee()
    Dim ucPatients = New ucPatients()
    Dim ucConditions = New ucConditions()
    Dim currentTab As Tabs

    Private Sub Home_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        UpdateInfo()

        Select Case currentTab
            Case Tabs.Users
                ucUsers.RefreshData()
            Case Tabs.Specialties
                ucSpecialties.RefreshData()
            Case Tabs.Employees
                ucEmployees.RefreshData()
            Case Tabs.Patients
                ucPatients.RefreshData()
            Case Tabs.Conditions
                ucConditions.RefreshData()
        End Select
    End Sub

    Private Sub UpdateInfo()
        txtRole.Text = Session.user.Role
        txtUsername.Text = Session.user.Username
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        HandleTabChange(Tabs.Users)
    End Sub

    Private Sub HandleTabChange(tab As Tabs)
        mainPanel.Controls.Clear()

        Select Case tab
            Case Tabs.Users
                mainPanel.Controls.Add(ucUsers)
            Case Tabs.Specialties
                mainPanel.Controls.Add(ucSpecialties)
            Case Tabs.Employees
                mainPanel.Controls.Add(ucEmployees)
            Case Tabs.Patients
                mainPanel.Controls.Add(ucPatients)
            Case Tabs.Conditions
                mainPanel.Controls.Add(ucConditions)
            Case Else
        End Select

        currentTab = tab
        mainPanel.Controls(0).Dock = DockStyle.Fill
    End Sub

    Private Sub btnSpecialties_Click(sender As Object, e As EventArgs) Handles btnSpecialties.Click
        HandleTabChange(Tabs.Specialties)
    End Sub

    Private Sub Home_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        HandleTabChange(Tabs.Employees)
    End Sub

    Private Sub btnPatients_Click(sender As Object, e As EventArgs) Handles btnPatients.Click
        HandleTabChange(Tabs.Patients)
    End Sub

    Private Sub btnConditions_Click(sender As Object, e As EventArgs) Handles btnConditions.Click
        HandleTabChange(Tabs.Conditions)
    End Sub
End Class