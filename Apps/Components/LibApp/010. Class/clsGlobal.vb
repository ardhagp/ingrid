Namespace Ingrid.Global
    Public Enum TypeOfAccess
        [View]
        [Add]
        [Edit]
        [Delete]
        [Report]
    End Enum

    Public Enum DatabaseEngine
        [MSSQL]
        [MYSQL]
        [PGSQL]
    End Enum

    Public Enum PopupType
        [Alert]
        [Error]
        [Information]
        [WrongInstructionSet]
        [ConfirmationBeforeReset]
        [Confirmation]
        [Delete]
        [Question]
        [NotAuthorized]
        [LimitExceeded]
        [ModuleUnderMaintenance]
        [Logout]
        [NoFileSelected]
        [FileNotFound]
    End Enum

    ''' <summary>
    ''' 
    ''' </summary>
    Public Class Properties
        Property AllParameters As New Dictionary(Of String, Object)
        Property AccountingGroupId As String
        Property AccountingGroupIsNew As Boolean
        Property ConnectionDatabaseEngine As String
        Property ConnectionDatabaseEngineE As Ingrid.Global.DatabaseEngine
        Property ConnectionDatabaseName As String
        Property ConnectionFileStorage As String
        Property ConnectionId As String
        Property ConnectionIsDefault As Boolean
        Property ConnectionIsMasked As Boolean
        Property ConnectionIsNew As Boolean
        Property ConnectionIsPasswordChanged As Boolean
        Property ConnectionName As String
        Property ConnectionServerAddress As String
        Property ConnectionServerPort As Integer
        Property ConnectionPassword As String
        Property ConnectionPasswordOld As String
        Property ConnectionUsername As String
        Property CompanyIsNew As Boolean
        Property CompanyIsCommitSuccess As Boolean
        Property CompanyIsForceRefresh As Boolean
        Property CustomDailyActivityId As String
        Property CustomDailyActivityIsNew As Boolean
        Property CustomDailyActivityAreaId As String
        Property CustomDailyActivityAreaIsNew As Boolean
        Property DepartmentIsNew As Boolean
        Property DepartmentIsForceRefresh As Boolean
        Property DepartmentParameters As New Dictionary(Of String, Object)
        Property EmployeeId As String
        Property EmployeeIsCommitSuccess As Boolean
        Property EmployeeIsForceRefresh As Boolean
        Property EmployeeIsForceChangePhoto As Boolean
        Property EmployeeIsNew As Boolean
        Property EmployeeFirstName As String
        Property EmployeeLastName As String
        Property EmployeeNumber As String
        Property EmployeeGender As String
        Property EmployeeGradeId As String
        Property EmployeeName As String
        Property EmploymentTypeId As String
        Property EmploymentTypeIsForceRefresh As Boolean
        Property EmploymentTypeIsNew As Boolean
        Property EmploymentTypeCode As String
        Property EmploymentTypeName As String
        Property EmploymentTypeDescription As String
        Property EmployeePositionId As String
        Property EmployeePositionIsNew As Boolean
        Property EmployeePositionIsForceRefresh As Boolean
        Property EmployeePositionCode As String
        Property EmployeePositionParent As String
        Property EmployeePositionName As String
        Property EmployeePositionDescription As String
        Property PlantId As String
        Property PlantIsForceRefresh As Boolean
        Property PlantIsNew As Boolean
        Property PlantCode As String
        Property PlantName As String
        Property PlantSearchTerm1 As String
        Property PlantSearchTerm2 As String
        Property PlantDescription As String
        Property PlantAddress As String
        Property PlantPostalCode As String
        Property IsAdministrator As Boolean
        Property IsConnected As Boolean
        Property Username As String
        Property UserId As Long
        Property UserIsNew As Boolean
        Property UserIsCommitSuccess As Boolean
        Property UserIsForceRefresh As Boolean
        Property UserAccessId As String
        Property UserAccessIsChangePasswordForm As Boolean
        Property UserAccessIsNew As Boolean
        Property UserAccessHash As String
        Property UserAccessPassword As String
        Property SystemModuleId As String
        Property SystemModuleIsNew As Boolean
        Property SystemModuleHash As String
        Property SystemTypeOfAccess As TypeOfAccess
        Property Field01 As Object
        Property Field02 As Object
        Property Field03 As Object
        Property Field04 As Object
    End Class
End Namespace

Namespace Ingrid.Accounting
    ''' <summary>
    ''' 
    ''' </summary>
    Public Class Properties
        Property AccountBookId As String
        Property AccountEnabled As Boolean
        Property AccountGroupId As String
        Property AccountName As String
        Property AccountNumber As String

    End Class
End Namespace