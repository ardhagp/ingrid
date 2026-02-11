Imports System.Media
Imports System.Runtime.Versioning

Namespace Application
    Public Class Access
        ReadOnly varSQL As New LibSQL.Application.Access

        <SupportedOSPlatform("windows")>
        Public Function User(databasename As String, tcode As String, uid As String, typeofaccess As LibSQL.Application.Access.TypeOfAccess, Optional status As stt = Nothing) As Boolean
            Dim varAccessValue As Boolean

            Try
                varAccessValue = CType(varSQL.User(databasename, tcode, uid, typeofaccess), Boolean)

                If Not varAccessValue Then
                    SystemSounds.Exclamation.Play()
                End If

                Return varAccessValue
            Catch ex As Exception
                SystemSounds.Exclamation.Play()
                Return False
            End Try
        End Function
    End Class
End Namespace

Namespace Application
    Public Class Modules
        'ReadOnly _SQL As New LibSQL.Application.Modules

        <SupportedOSPlatform("windows")>
        Public Shared Function IsModuleReady(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, tcode As String) As Boolean
            Dim varIsModuleReady As Boolean

            Try
                varIsModuleReady = CType(LibSQL.Application.Modules.Exist(databasename, dbengine, tcode), Boolean)

                Return varIsModuleReady
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsModuleLocked(databasename As String, dbengine As LibApp.Ingrid.Global.DatabaseEngine, tcode As String) As Boolean
            Dim varIsModuleLocked As Boolean

            Try

                varIsModuleLocked = CType(LibSQL.Application.Modules.Locked(databasename, dbengine, tcode), Boolean)

                Return varIsModuleLocked
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Class

    Public Class Marquee
        Private varCurrentText As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ.,-=\][!@#$%^&*()_+"
        Private varText As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ.,-=\][!@#$%^&*()_+"
        Private varDirection As Direction = Direction.Left
        Private varScrollLength As Integer = 1000000
        Public varMarqueeText As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ.,-=\][!@#$%^&*()_+"
        Public ReadOnly Property MarqueeText As String
            Get
                Return varMarqueeText
            End Get
        End Property
        Public Property ScrollDirection As Direction
            Get
                Return varDirection
            End Get
            Set(value As Direction)
                varDirection = value
            End Set
        End Property
        Private ReadOnly Property CurrentText As String
            Get
                Return varCurrentText
            End Get
        End Property
        Public Property Text As String
            Get
                Return varText
            End Get
            Set(value As String)
                varText = value
                varCurrentText = value
            End Set
        End Property
        Public Property ScrollLength As Integer
            Get
                Return varScrollLength
            End Get
            Set(value As Integer)
                If value < 1 Then value = 1
                varScrollLength = value
            End Set
        End Property
        Public Sub Tick()
            Dim varMoveCharacter As String
            If ScrollLength > Len(varText) Then ScrollLength = Len(varText)
            If ScrollDirection = Direction.Left Then
                varMoveCharacter = Mid$(varCurrentText, 1, 1)
                varCurrentText = Replace(varCurrentText, varMoveCharacter, "", 1, 1)
                varCurrentText &= varMoveCharacter
                varMarqueeText = Mid$(varCurrentText, 1, varScrollLength)
            ElseIf ScrollDirection = Direction.Right Then
                varMoveCharacter = Mid$(varCurrentText, Len(varCurrentText), 1)
                varCurrentText = Mid$(varCurrentText, 1, Len(varCurrentText) - 1)
                varCurrentText = varMoveCharacter & varCurrentText
                varMarqueeText = Mid$(varCurrentText, 1, varScrollLength)
            End If
        End Sub
        Public Enum Direction
            Left
            Right
        End Enum
    End Class
End Namespace
