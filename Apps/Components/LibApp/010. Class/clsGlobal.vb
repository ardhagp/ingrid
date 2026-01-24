Namespace Ingrid.Global
    Public Enum DatabaseEngine
        [MSSQL]
        [MYSQL]
    End Enum

    ''' <summary>
    ''' 
    ''' </summary>
    Public Class Properties
        Property ConnectionName As String
        Property DatabaseEngine As String
        Property DatabaseEngineE As Ingrid.Global.DatabaseEngine
        Property DatabaseName As String
        Property EmployeeID As String
        Property EmployeeNumber As String
        Property EmployeePosition As String
        Property FileStorage As String
        Property FirstName As String
        Property Gender As String
        Property Hash As String
        Property IsAdministrator As Boolean
        Property IsConnected As Boolean
        Property IsChangePasswordForm As Boolean
        Property IsDefault As Boolean
        Property IsMasked As Boolean
        Property IsNew As Boolean
        Property IsPasswordChanged As Boolean
        Property LastName As String
        Property Password As String
        Property PasswordOld As String
        Property RowID As Object
        Property ServerAddress As String
        Property ServerPort As Integer
        Property Username As String
        Property UserID As String
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
        Property AccountBookID As String
        Property AccountEnabled As Boolean
        Property AccountGroupID As String
        Property AccountName As String
        Property AccountNumber As String

    End Class
End Namespace