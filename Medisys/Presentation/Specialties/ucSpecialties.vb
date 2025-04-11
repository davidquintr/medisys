Public Class ucEmployees

    Dim specialties = New List(Of Specialty)

    Public Sub RefreshData()
        specialties = SpecialtyBLL.GetAllSpecialties()
        dgvSpecialties.DataSource = specialties
    End Sub

    Private Sub ucSpecialties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmManageSpecialty.SetOnNewUser()
        frmManageSpecialty.Show()
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If dgvSpecialties.CurrentRow IsNot Nothing Then
            StartModifyActions(dgvSpecialties.CurrentRow.Index)
        End If
    End Sub

    Private Sub StartModifyActions(rowIndex As Integer)
        If rowIndex < 0 Then
            Return
        End If
        Dim specialty As New Specialty With {
            .ID = specialties(rowIndex).ID,
            .Name = specialties(rowIndex).Name
        }
        frmManageSpecialty.SetOnEditSpecialty(specialty)
        frmManageSpecialty.Show()
    End Sub

    Private Sub dgvSpecialties_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSpecialties.CellDoubleClick
        StartModifyActions(e.RowIndex)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If dgvSpecialties.CurrentRow Is Nothing OrElse dgvSpecialties.CurrentRow.Index < 0 Then
            Return
        End If

        Dim confirmResult As DialogResult = MessageBox.Show(
            "¿Estás seguro de que deseas eliminar esta especialidad?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If confirmResult <> DialogResult.Yes Then
            Return
        End If

        Try
            Dim result As Boolean = SpecialtyBLL.DeleteSpecialty(specialties(dgvSpecialties.CurrentRow.Index).ID)

            If result Then
                MessageBox.Show("Se ha eliminado la especialidad correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshData()
            Else
                MessageBox.Show("Error al eliminar la especialidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshData()
    End Sub
End Class
