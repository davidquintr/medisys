Public Class frmManageCondition

    Dim condition As Condition
    Dim CurrentAction As ActionType = ActionType.New

    Private Sub frmManageCondition_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub SetOnNewCondition()
        CurrentAction = ActionType.New

        lblTitle.Text = "Agregar Condición Médica"
        tboxName.Clear()
        rtboxDescription.Clear()

        Me.condition = New Condition()
    End Sub

    Public Sub SetOnEditCondition(condition As Condition)
        CurrentAction = ActionType.Edit

        lblTitle.Text = "Modificar Condición Médica"
        tboxName.Text = condition.Name
        rtboxDescription.Text = condition.Description

        Me.condition = condition

    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Try
            Dim condition As New Condition With {
                .ID = Me.condition.ID,
                .Name = tboxName.Text,
                .Description = rtboxDescription.Text
            }

            Dim result As Boolean = False

            If CurrentAction = ActionType.New Then
                result = ConditionBLL.AddCondition(condition)
            ElseIf CurrentAction = ActionType.Edit Then
                result = ConditionBLL.UpdateCondition(condition)
            End If

            If result Then
                MessageBox.Show("Se ha guardado la condición médica correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Error al guardar la condición médica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As ArgumentNullException
            MessageBox.Show(ex.Message, "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Select Case ex.ParamName
                Case "Nombre"
                    tboxName.Focus()
                Case "Descripción"
                    rtboxDescription.Focus()
            End Select

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error inesperado: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class