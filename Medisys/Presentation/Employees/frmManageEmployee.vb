Public Class frmManageEmployee

    Dim users As List(Of User)
    Dim usersWithoutEmployee As List(Of User)
    Dim specialties As List(Of Specialty)

    Private CurrentAction As ActionType = ActionType.New
    Dim employee As Employee

    Public Sub SetOnEditEmployee(employee As Employee)
        FillDefaultData()

        CurrentAction = ActionType.Edit
        lblTitle.Text = "Modificar Empleado"

        Me.employee = employee
        tboxName.Text = employee.Name
        tboxLastName.Text = employee.LastName
        rtboxAddress.Text = employee.Address
        cboxSex.SelectedIndex = cboxSex.Items.IndexOf(employee.Sex)

        Dim specialtyName As String = specialties.Find(Function(s) s.ID = employee.IDSpecialty).Name

        cboxSpecialty.SelectedIndex = cboxSpecialty.Items.IndexOf(specialtyName)

        If employee.IDUser <> Guid.Empty Then
            Dim currentUser As User = users.Find(Function(u) u.ID = employee.IDUser)
            cboxUser.Items.Add(currentUser.Username)
            cboxUser.SelectedIndex = cboxUser.Items.Count - 1
        End If

    End Sub

    Public Sub SetOnNewEmployee()
        FillDefaultData()
        CurrentAction = ActionType.New

        lblTitle.Text = "Agregar Empleado"
        Me.employee = New Employee()
        tboxName.Clear()
        tboxLastName.Clear()
        rtboxAddress.Clear()
        cboxSex.SelectedIndex = -1
        cboxUser.SelectedIndex = -1

    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Try

            Dim employee As New Employee With {
                .ID = Me.employee.ID,
                .Name = tboxName.Text,
                .LastName = tboxLastName.Text,
                .Address = rtboxAddress.Text,
                .Sex = cboxSex.SelectedItem.ToString(),
                .IDSpecialty = specialties(cboxSpecialty.SelectedIndex).ID
            }

            If (cboxUser.SelectedIndex = (cboxUser.Items.Count - 1)) Then
                employee.IDUser = Me.employee.IDUser
            Else
                employee.IDUser = usersWithoutEmployee(cboxUser.SelectedIndex).ID
            End If

            Dim result As Boolean = False

            If CurrentAction = ActionType.New Then
                result = EmployeeBLL.AddEmployee(employee)
            Else
                result = EmployeeBLL.UpdateEmployee(employee)
            End If

            If result Then
                MessageBox.Show("Se ha guardado el empleado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Error al guardar el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As ArgumentNullException
            MessageBox.Show(ex.Message, "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Select Case ex.ParamName
                Case "Nombres"
                    tboxName.Focus()
                Case "Apellidos"
                    tboxLastName.Focus()
                Case "Sexo"
                    cboxSex.Focus()
            End Select

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error inesperado: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmManageEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FillDefaultData()
        cboxSpecialty.Items.Clear()
        cboxUser.Items.Clear()

        usersWithoutEmployee = UserBLL.GetAllUsersWithoutEmployee()
        users = UserBLL.GetAllUsers()
        specialties = SpecialtyBLL.GetAllSpecialties()

        cboxSpecialty.Items.AddRange(specialties.Select(Function(s) s.Name).ToArray())
        cboxUser.Items.AddRange(usersWithoutEmployee.Select(Function(u) u.Username).ToArray())
    End Sub

End Class