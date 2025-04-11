Public Class frmManageUser

    Private CurrentAction As ActionType = ActionType.New
    Private user = New User()

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Public Sub SetOnNewUser()
        CurrentAction = ActionType.New

        lblTitle.Text = "Agregar Usuario"
        tboxUsername.Clear()
        tboxPassword.Clear()
        tboxEmail.Clear()
        cboxRole.SelectedIndex = 0

        Me.user = New User()
    End Sub

    Public Sub SetOnEditUser(user As User)
        CurrentAction = ActionType.Edit

        lblTitle.Text = "Modificar Usuario"
        tboxUsername.Text = user.Username
        tboxPassword.Text = user.Password
        tboxEmail.Text = user.Email
        cboxRole.SelectedItem = user.Role.ToLower()

        Me.user = user

        If Session.user.ID = user.ID Then
            cboxRole.Enabled = False
        End If

    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Try
            Dim user As New User With {
                .ID = Me.user.ID,
                .Username = tboxUsername.Text,
                .Password = tboxPassword.Text,
                .Email = tboxEmail.Text,
                .Role = cboxRole.SelectedItem.ToString().ToLower()
            }

            Dim result As Boolean = False

            If CurrentAction = ActionType.New Then
                result = UserBLL.AddUser(user)
            ElseIf CurrentAction = ActionType.Edit Then
                result = UserBLL.UpdateUser(user)
            End If

            If result Then
                MessageBox.Show("Se ha guardado el usuario correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Error al guardar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As ArgumentNullException
            MessageBox.Show(ex.Message, "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Select Case ex.ParamName
                Case "Nombre de Usuario"
                    tboxUsername.Focus()
                Case "Contraseña"
                    tboxPassword.Focus()
                Case "Email"
                    tboxEmail.Focus()
                Case "Rol"
                    cboxRole.Focus()
            End Select

        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            If ex.ParamName = "Email" Then
                tboxEmail.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error inesperado: " & ex.Message)
        End Try
    End Sub

    Private Sub frmManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboxRole.SelectedIndex = 0
    End Sub
End Class