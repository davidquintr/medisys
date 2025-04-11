Imports System.Text.RegularExpressions

Public Class PatientBLL

    Public Shared Function GetAllPatients() As List(Of Patient)
        Return PatientDAL.GetAllPatients()
    End Function

    Public Shared Function DeletePatient(patientID As Guid) As Boolean
        Return PatientDAL.DeletePatient(patientID)
    End Function

    Public Shared Function AddPatient(patient As Patient) As Boolean
        If String.IsNullOrEmpty(patient.Name) Then
            Throw New ArgumentNullException("Nombres", "Los nombres no pueden estar vacíos.")
        End If

        If String.IsNullOrEmpty(patient.Lastname) Then
            Throw New ArgumentNullException("Apellidos", "Los apellidos no pueden estar vacíos.")
        End If

        If String.IsNullOrEmpty(patient.IdentityCard) Then
            Throw New ArgumentNullException("Cédula", "La cédula no puede estar vacía.")
        End If

        If String.IsNullOrEmpty(patient.Sex) Then
            Throw New ArgumentNullException("Sexo", "El sexo no puede estar vacíox|.")
        End If

        Dim cedulaRegex As New Regex("^\d{13}[A-Z]$", RegexOptions.IgnoreCase)
        If Not cedulaRegex.IsMatch(patient.IdentityCard) Then
            Throw New ArgumentException("La cédula no tiene un formato válido.", "Email")
        End If

        Return PatientDAL.AddPatient(patient)
    End Function


    Public Shared Function UpdatePatient(patient As Patient) As Boolean
        If String.IsNullOrEmpty(patient.Name) Then
            Throw New ArgumentNullException("Nombres", "Los nombres no pueden estar vacíos.")
        End If

        If String.IsNullOrEmpty(patient.Lastname) Then
            Throw New ArgumentNullException("Apellidos", "Los apellidos no pueden estar vacíos.")
        End If

        If String.IsNullOrEmpty(patient.IdentityCard) Then
            Throw New ArgumentNullException("Cédula", "La cédula no puede estar vacía.")
        End If

        If String.IsNullOrEmpty(patient.Sex) Then
            Throw New ArgumentNullException("Sexo", "El sexo no puede estar vacío.")
        End If

        Dim cedulaRegex As New Regex("^\d{13}[A-Z]$", RegexOptions.IgnoreCase)
        If Not cedulaRegex.IsMatch(patient.IdentityCard) Then
            Throw New ArgumentException("La cédula no tiene un formato válido.", "Cédula")
        End If

        Return PatientDAL.UpdatePatient(patient)
    End Function

End Class
