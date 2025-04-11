Public Class frmManageSpecialty

    Private CurrentAction As ActionType = ActionType.New
    Private specialty = New Specialty()

    Private Sub frmManageSpecialty_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub SetOnEditSpecialty(specialty As Specialty)
        CurrentAction = ActionType.Edit
        lblTitle.Text = "Modificar Especialidad"
        tboxName.Text = specialty.Name
        Me.specialty = specialty
    End Sub

    Public Sub SetOnNewUser()
        CurrentAction = ActionType.New

        lblTitle.Text = "Agregar Especialidad"
        tboxName.Clear()
        Me.specialty = New Specialty()
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Try
            Dim specialty As New Specialty With {
                .ID = Me.specialty.ID,
                .Name = tboxName.Text
            }

            Dim result As Boolean = False

            If CurrentAction = ActionType.New Then
                result = SpecialtyBLL.AddSpecialty(specialty)
            Else
                result = SpecialtyBLL.UpdateSpecialty(specialty)
            End If

            If result Then
                MessageBox.Show("Se ha guardado la especialidad correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Error al guardar la especialidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As ArgumentNullException
            MessageBox.Show(ex.Message, "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Select Case ex.ParamName
                Case "Nombre"
                    tboxName.Focus()
            End Select

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error inesperado: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class