Public Class EmployeeBLL
    Friend Shared Function GetAllEmployeeUser() As List(Of ViewEmployeeUser)
        Return EmployeeDAL.GetAllEmployeeUser()
    End Function

    Friend Shared Function GetAllEmployees() As List(Of Employee)
        Return EmployeeDAL.GetAllEmployees()
    End Function

    Public Shared Function AddEmployee(employee As Employee) As Boolean
        If String.IsNullOrEmpty(employee.Name) Then
            Throw New ArgumentNullException("Nombres", "El nombre no puede estar vacío.")
        End If

        If String.IsNullOrEmpty(employee.LastName) Then
            Throw New ArgumentNullException("Apellidos", "La contraseña no puede estar vacía.")
        End If

        If String.IsNullOrEmpty(employee.Sex) Then
            Throw New ArgumentNullException("Sexo", "El sexo no puede estar vacío.")
        End If

        Return EmployeeDAL.AddEmployee(employee)
    End Function

    Public Shared Function UpdateEmployee(employee As Employee) As Boolean
        If String.IsNullOrEmpty(employee.Name) Then
            Throw New ArgumentNullException("Nombres", "El nombre no puede estar vacío.")
        End If

        If String.IsNullOrEmpty(employee.LastName) Then
            Throw New ArgumentNullException("Apellidos", "La contraseña no puede estar vacía.")
        End If

        If String.IsNullOrEmpty(employee.Sex) Then
            Throw New ArgumentNullException("Sexo", "El sexo no puede estar vacío.")
        End If

        Return EmployeeDAL.UpdateEmployee(employee)
    End Function

    Public Shared Function DeleteEmployee(employeeID As Guid) As Boolean
        Return EmployeeDAL.DeleteEmployee(employeeID)
    End Function

End Class
