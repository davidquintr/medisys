Imports System.Runtime.CompilerServices

Public Class Form1

    Private Sub AuthenticationActions()
        Try
            Dim username = tboxUsername.Text
            Dim password = tboxPassword.Text

            Dim user = UserBLL.Login(username, password)

            If user IsNot Nothing Then
                MessageBox.Show($"Has sido autenticado como {user.Username}", "Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Session.user = user

                Me.Visible = False
                Home.Show()

                Return
            End If

            Throw New Exception("No se pudo autenticar, verifique sus datos.")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        AuthenticationActions()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub tboxPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tboxPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            AuthenticationActions()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
