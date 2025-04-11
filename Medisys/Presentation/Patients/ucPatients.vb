Public Class ucPatients

    Dim patients = New List(Of Patient)

    Public Sub RefreshData()
        patients = PatientBLL.GetAllPatients()
        dgvPatients.DataSource = patients
    End Sub

    Private Sub ucPatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshData()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmManagePatient.SetOnNewPatient()
        frmManagePatient.Show()
    End Sub

    Private Sub StartModifyActions(rowIndex As Integer)
        If rowIndex < 0 Then
            Return
        End If

        Dim patient = patients(rowIndex)

        frmManagePatient.SetOnEditPatient(patient)
        frmManagePatient.Show()
    End Sub

    Private Sub dgvPatients_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPatients.CellDoubleClick
        StartModifyActions(e.RowIndex)
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        StartModifyActions(dgvPatients.CurrentRow.Index)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If dgvPatients.CurrentRow Is Nothing OrElse dgvPatients.CurrentRow.Index < 0 Then
            Return
        End If

        Dim confirmResult As DialogResult = MessageBox.Show(
            "¿Estás seguro de que deseas eliminar este paciente?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If confirmResult <> DialogResult.Yes Then
            Return
        End If

        Try
            Dim result As Boolean = PatientBLL.DeletePatient(patients(dgvPatients.CurrentRow.Index).ID)

            If result Then
                MessageBox.Show("Se ha eliminado el paciente correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshData()
            Else
                MessageBox.Show("Error al eliminar el paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
