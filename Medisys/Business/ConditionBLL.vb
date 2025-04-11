Public Class ConditionBLL

    Public Shared Function GetAllConditions() As List(Of Condition)
        Return ConditionDAL.GetAllConditions()
    End Function

    Public Shared Function AddCondition(condition As Condition) As Boolean

        If String.IsNullOrEmpty(condition.Name) Then
            Throw New ArgumentNullException("Nombre", "El nombre no puede estar vacío.")
        End If

        If String.IsNullOrEmpty(condition.Description) Then
            Throw New ArgumentNullException("Descripción", "La descripción no puede estar vacía.")
        End If

        Return ConditionDAL.AddCondition(condition)

    End Function

    Public Shared Function UpdateCondition(condition As Condition) As Boolean

        If String.IsNullOrEmpty(condition.Name) Then
            Throw New ArgumentNullException("Nombre", "El nombre no puede estar vacío.")
        End If
        If String.IsNullOrEmpty(condition.Description) Then
            Throw New ArgumentNullException("Descripción", "La descripción no puede estar vacía.")
        End If
        Return ConditionDAL.UpdateCondition(condition)

    End Function

    Public Shared Function DeleteCondition(conditionID As Guid) As Boolean
        Return ConditionDAL.DeleteCondition(conditionID)
    End Function


End Class
