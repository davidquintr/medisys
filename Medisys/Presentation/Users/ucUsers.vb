Public Class ucUsers

    Dim users As List(Of User)

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmManageUser.SetOnNewUser()
        frmManageUser.Show()
    End Sub

    Public Sub RefreshData()
        users = UserBLL.GetAllUsers()
        dgvUsers.DataSource = users
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshData()
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If dgvUsers.CurrentRow IsNot Nothing Then
            StartModifyActions(dgvUsers.CurrentRow.Index)
        End If
    End Sub

    Private Sub StartModifyActions(rowIndex As Integer)
        If rowIndex < 0 Then
            Return
        End If

        Dim user = users(rowIndex)

        frmManageUser.SetOnEditUser(user)
        frmManageUser.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If dgvUsers.CurrentRow Is Nothing OrElse dgvUsers.CurrentRow.Index < 0 Then
            Return
        End If

        Dim confirmResult As DialogResult = MessageBox.Show(
            "¿Estás seguro de que deseas eliminar este usuario?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If confirmResult <> DialogResult.Yes Then
            Return
        End If

        Try
            Dim result As Boolean = UserBLL.DeleteUser(users(dgvUsers.CurrentRow.Index).ID)

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

    Private Sub ucUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Private Sub dgvUsers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUsers.SelectionChanged

        If dgvUsers.CurrentRow Is Nothing OrElse dgvUsers.CurrentRow.Index < 0 Then
            Return
        End If

        If Session.user.ID = users(dgvUsers.CurrentRow.Index).ID Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
        End If

    End Sub

    Private Sub dgvUsers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellDoubleClick
        StartModifyActions(e.RowIndex)
    End Sub
End Class
