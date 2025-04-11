Public Class PatientConditionBLL
    Public Shared Function GetAllPatientConditionByPatient(patientID As Guid) As List(Of PatientCondition)
        Return PatientConditionDAL.GetAllPatientConditionsByPatient(patientID)
    End Function

    Public Shared Function AddPatientCondition(patientCondition As PatientCondition) As Boolean
        Return PatientConditionDAL.AddPatientCondition(patientCondition)
    End Function

    Public Shared Function RemoveAllPatientConditionsByPatient(patientID As Guid) As Boolean
        Return PatientConditionDAL.RemoveAllPatientConditionsByPatient(patientID)
    End Function

End Class
