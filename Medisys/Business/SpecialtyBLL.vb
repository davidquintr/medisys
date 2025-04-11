Public Class SpecialtyBLL

    Public Shared Function GetAllSpecialties() As List(Of Specialty)
        Return SpecialtyDAL.GetAllSpecialties()
    End Function

    Public Shared Function AddSpecialty(specialty As Specialty) As Boolean
        If String.IsNullOrEmpty(specialty.Name) Then
            Throw New ArgumentNullException("Nombre", "El nombre no puede estar vacío.")
        End If
        Return SpecialtyDAL.AddSpecialty(specialty)
    End Function

    Public Shared Function UpdateSpecialty(specialty As Specialty) As Boolean
        If String.IsNullOrEmpty(specialty.Name) Then
            Throw New ArgumentNullException("Nombre", "El nombre no puede estar vacío.")
        End If
        Return SpecialtyDAL.UpdateSpecialty(specialty)
    End Function

    Public Shared Function DeleteSpecialty(specialtyID As Guid) As Boolean
        Return SpecialtyDAL.DeleteSpecialty(specialtyID)
    End Function

End Class
