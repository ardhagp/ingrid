Namespace Ingrid.Global
    ''' <summary>
    ''' Type of access to the application. This enum is used to determine the type of access a user has to the application, such as view, add, edit, delete, or report.
    ''' </summary>
    Public Enum TypeOfAccess
        [View]
        [Add]
        [Edit]
        [Delete]
        [Report]
    End Enum

    ''' <summary>
    ''' Type of database engine used in the application. This enum is used to determine the type of database engine to be used for connecting to the database, such as Microsoft SQL Server, MySQL, or PostgreSQL.
    ''' </summary>
    Public Enum DatabaseEngine
        [MSSQL]
        [MYSQL]
        [PGSQL]
    End Enum

    ''' <summary>
    ''' Type of storage used in the application. This enum is used to determine the type of storage to be used for storing files, such as BackBlaze B2, Cloudinary, or Database.
    ''' </summary>
    Public Enum StorageType
        [BackBlazeB2]
    End Enum

    ''' <summary>
    ''' Type of popup message to be displayed in the application. This enum is used to determine the type of message box to show to the user, such as an alert, error, information, confirmation, etc.
    ''' </summary>
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
    ''' Properties class is used to store various properties related to the application, such as parameters, user information, and other settings.
    ''' </summary>
    Public Class Properties
        Property AllParameters As New Dictionary(Of String, Object)
        Property UserParameters As New Dictionary(Of String, Object)
        Property DatasetCopy As New System.Data.DataSet
        Property AccountBookId As Long
        Property AccountBookIsNew As Boolean
        Property AccountBookIsEnabled As Boolean
        Property AccountBookIsForceRefresh As Boolean
        Property AccountBookNumber As Integer
        Property AccountBookName As String
        Property AccountGroupId As String
        Property AccountGroupIsNew As Boolean
        Property ConnectionClientId As Long
        Property ConnectionClientCode As String
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
        Property EmployeeId As Long
        Property EmployeeIsCommitSuccess As Boolean
        Property EmployeeIsForceRefresh As Boolean
        Property EmployeeIsForceChangePhoto As Boolean
        Property EmployeeIsHavePhoto As Boolean
        Property EmployeeIsNewPhoto As Boolean
        Property EmployeeIsNew As Boolean
        Property EmployeeIsPhotoRemoved As Boolean
        Property EmployeeFirstName As String
        Property EmployeeLastName As String
        Property EmployeeNumber As String
        Property EmployeeGender As String
        Property EmployeeGradeId As String
        Property EmployeeName As String
        Property EmployeePositionId As String
        Property EmployeePositionIsNew As Boolean
        Property EmployeePhoto As System.Drawing.Image
        Property EmploymentTypeId As String
        Property EmploymentTypeIsForceRefresh As Boolean
        Property EmploymentTypeIsNew As Boolean
        Property EmploymentTypeCode As String
        Property EmploymentTypeName As String
        Property EmploymentTypeDescription As String
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
        Property UserAccessIsPasswordChanged As Boolean
        Property UserAccessHash As String
        Property UserAccessPassword As String
        Property SystemSettingsId As Long
        Property SystemModuleId As String
        Property SystemModuleIsNew As Boolean
        Property SystemModuleHash As String
        Property SystemTypeOfAccess As TypeOfAccess
        Property SystemStorageType As StorageType
    End Class
End Namespace