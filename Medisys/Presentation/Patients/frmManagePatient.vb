Imports System.IO

Public Class frmManagePatient

    Dim CurrentAction = ActionType.New
    Private patient As Patient

    Public Sub SetOnEditPatient(patient As Patient)
        CurrentAction = ActionType.Edit
        lblTitle.Text = "Modificar Paciente"
        tboxName.Text = patient.Name
        tboxLastName.Text = patient.Lastname
        tboxPhone.Text = patient.PhoneNumber
        tboxIDCard.Text = patient.IdentityCard
        rtboxAddress.Text = patient.Address
        cboxSex.SelectedItem = patient.Sex
        lblURI.Text = patient.AvatarURI

        If patient.AvatarURI <> "" Then
            picboxAvatar.BackgroundImage = Image.FromFile(patient.AvatarURI)
        End If

        Me.patient = patient

    End Sub

    Public Sub SetOnNewPatient()
        CurrentAction = ActionType.New

        lblTitle.Text = "Agregar Paciente"
        tboxName.Clear()
        tboxLastName.Clear()
        tboxPhone.Clear()
        tboxIDCard.Clear()
        rtboxAddress.Clear()
        cboxSex.SelectedIndex = -1
        lblURI.Text = ""

        picboxAvatar.BackgroundImage = Nothing

        Me.patient = New Patient()

    End Sub

    Private Sub btnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim selectedImagePath As String = openFileDialog.FileName

                Dim targetDirectory As String = Path.Combine(Application.StartupPath, Constants.UPLOADED_IMAGES_DIR)

                If Not Directory.Exists(targetDirectory) Then
                    Directory.CreateDirectory(targetDirectory)
                End If

                Dim uniqueFileName As String = Guid.NewGuid().ToString() + Path.GetExtension(selectedImagePath)
                Dim targetFilePath As String = Path.Combine(targetDirectory, uniqueFileName)

                File.Copy(selectedImagePath, targetFilePath, True)

                picboxAvatar.BackgroundImage = Image.FromFile(targetFilePath)

                lblURI.Text = targetFilePath
            End If
        End Using
    End Sub

    Private Sub frmManagePatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        Try
            Dim patient As New Patient With {
                .ID = Me.patient.ID,
                .Name = tboxName.Text,
                .Lastname = tboxLastName.Text,
                .PhoneNumber = tboxPhone.Text,
                .Address = rtboxAddress.Text,
                .AvatarURI = lblURI.Text,
                .IdentityCard = tboxIDCard.Text,
                .Sex = cboxSex.SelectedItem
            }

            Dim result As Boolean = False

            If CurrentAction = ActionType.New Then
                result = PatientBLL.AddPatient(patient)
            Else
                result = PatientBLL.UpdatePatient(patient)
            End If

            If result Then
                MessageBox.Show("Se ha guardado el paciente correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Error al guardar el paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As ArgumentNullException
            MessageBox.Show(ex.Message, "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Select Case ex.ParamName
                Case "Nombres"
                    tboxName.Focus()
                Case "Apellidos"
                    tboxLastName.Focus()
                Case "Cédula"
                    tboxIDCard.Focus()
                Case "Sexo"
                    cboxSex.Focus()
            End Select

        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Select Case ex.ParamName
                Case "Cédula"
                    tboxIDCard.Focus()
            End Select

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error inesperado: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnManageConditions_Click(sender As Object, e As EventArgs) Handles btnManageConditions.Click
        frmManagePatientConditions.SetPatientToManage(patient)
        frmManagePatientConditions.Show()
    End Sub
End Class