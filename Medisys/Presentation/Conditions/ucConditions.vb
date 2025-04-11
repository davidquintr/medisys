Public Class ucConditions

    Dim conditions = New List(Of Condition)

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmManageCondition.SetOnNewCondition()
        frmManageCondition.Show()
    End Sub

    Public Sub RefreshData()
        conditions = ConditionBLL.GetAllConditions()
        dgvConditions.DataSource = conditions
    End Sub

    Private Sub ucConditions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshData()
    End Sub

    Private Sub dgvConditions_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConditions.CellDoubleClick
        StartModifyActions(e.RowIndex)

    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        StartModifyActions(dgvConditions.CurrentRow.Index)
    End Sub

    Private Sub StartModifyActions(rowIndex As Integer)
        If rowIndex < 0 Then
            Return
        End If

        Dim condition = conditions(rowIndex)

        frmManageCondition.SetOnEditCondition(condition)
        frmManageCondition.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If dgvConditions.CurrentRow Is Nothing OrElse dgvConditions.CurrentRow.Index < 0 Then
            Return
        End If

        Dim confirmResult As DialogResult = MessageBox.Show(
            "¿Estás seguro de que deseas eliminar esta condición médica?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If confirmResult <> DialogResult.Yes Then
            Return
        End If

        Try
            Dim result As Boolean = ConditionBLL.DeleteCondition(conditions(dgvConditions.CurrentRow.Index).ID)

            If result Then
                MessageBox.Show("Se ha eliminado la condición médica correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshData()
            Else
                MessageBox.Show("Error al eliminar la condición médica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
