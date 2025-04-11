Public Class ucEmployee

    Dim employeeUsers = New List(Of ViewEmployeeUser)
    Dim employees = New List(Of Employee)

    Public Sub RefreshData()
        employees = EmployeeBLL.GetAllEmployees()
        employeeUsers = EmployeeBLL.GetAllEmployeeUser()
        dgvEmployees.DataSource = employeeUsers
    End Sub

    Private Sub ucEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshData()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmManageEmployee.SetOnNewEmployee()
        frmManageEmployee.Show()
    End Sub

    Private Sub dgvEmployees_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployees.CellDoubleClick
        StartModifyActions(e.RowIndex)
    End Sub

    Private Sub StartModifyActions(rowIndex As Integer)

        If rowIndex < 0 Then
            Return
        End If

        Dim employee = employees(rowIndex)

        frmManageEmployee.SetOnEditEmployee(employee)
        frmManageEmployee.Show()

    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        StartModifyActions(dgvEmployees.CurrentRow.Index)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvEmployees.CurrentRow Is Nothing OrElse dgvEmployees.CurrentRow.Index < 0 Then
            Return
        End If

        Dim confirmResult As DialogResult = MessageBox.Show(
            "¿Estás seguro de que deseas eliminar este empleado?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If confirmResult <> DialogResult.Yes Then
            Return
        End If

        Try
            Dim result As Boolean = EmployeeBLL.DeleteEmployee(employeeUsers(dgvEmployees.CurrentRow.Index).ID)

            If result Then
                MessageBox.Show("Se ha eliminado el usuario correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshData()
            Else
                MessageBox.Show("Error al eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
