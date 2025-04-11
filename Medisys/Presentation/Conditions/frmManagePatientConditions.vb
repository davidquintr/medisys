Public Class frmManagePatientConditions

    Dim conditions As List(Of Condition)
    Dim patient As Patient

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cboxConditions.SelectedIndex <> -1 Then
            lboxPatientConditions.Items.Add(cboxConditions.SelectedItem.ToString())
            cboxConditions.Items.RemoveAt(cboxConditions.SelectedIndex)
        End If
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click

        Dim resultOnRemove As Boolean = PatientConditionBLL.RemoveAllPatientConditionsByPatient(patient.ID)

        If resultOnRemove = False Then
            MessageBox.Show("Error al eliminar las condiciones anteriores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If

        Dim result As Boolean = True

        For Each item In lboxPatientConditions.Items
            Dim condition As Condition = conditions.FirstOrDefault(Function(c) c.Name = item.ToString())
            If condition IsNot Nothing Then
                Dim patientCondition As New PatientCondition() With {
                    .IDCondition = condition.ID,
                    .IDPatient = patient.ID
                }

                Dim currentResult = PatientConditionBLL.AddPatientCondition(patientCondition)

                If currentResult = False Then
                    result = False
                End If

            End If
        Next

        If result Then
            MessageBox.Show("Se han guardado las condiciones correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Error al guardar las condiciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub frmManagePatientConditions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboxConditions.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Public Sub SetPatientToManage(patient As Patient)

        If patient Is Nothing Then
            Me.Close()
        End If

        FillDefaultData()
        Me.patient = patient

        lblNameLastName.Text = $"{patient.Name} {patient.Lastname}"
        lblIDCard.Text = patient.IdentityCard
        picboxAvatar.BackgroundImage = Image.FromFile(patient.AvatarURI)

        Dim patientConditions = PatientConditionBLL.GetAllPatientConditionByPatient(patient.ID)

        If patientConditions IsNot Nothing Then
            For Each pc In patientConditions
                Dim condition = conditions.FirstOrDefault(Function(c) c.ID = pc.IDCondition)
                If condition IsNot Nothing Then
                    Dim item As New ListViewItem(condition.Name)
                    item.Tag = pc
                    lboxPatientConditions.Items.Add(item.Text)
                End If
            Next
        End If

        Dim availableConditions = conditions.Where(Function(c) Not patientConditions.Any(Function(pc) pc.IDCondition = c.ID)).ToList()
        cboxConditions.Items.Clear()
        cboxConditions.Items.AddRange(availableConditions.Select(Function(s) s.Name).ToArray())

    End Sub

    Private Sub FillDefaultData()
        conditions = ConditionBLL.GetAllConditions()
        cboxConditions.Items.Clear()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If lboxPatientConditions.SelectedIndex = -1 Then
            Return
        End If

        cboxConditions.Items.Add(lboxPatientConditions.SelectedItem.ToString())
        lboxPatientConditions.Items.RemoveAt(lboxPatientConditions.SelectedIndex)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class