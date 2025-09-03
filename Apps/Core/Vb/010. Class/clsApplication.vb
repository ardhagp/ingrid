Imports System.Media
Imports System.Runtime.Versioning
Imports CMCv
Imports Microsoft.CodeAnalysis.VisualBasic.Syntax

Namespace Application
    Public Class Access
        ReadOnly V_SQL As New LibSQL.Application.Access

        <SupportedOSPlatform("windows")>
        Public Function User(ByVal TCODE As String, ByVal UID As String, ByVal TypeOfAccess As LibSQL.Application.Access.TypeOfAccess, Optional Status As stt = Nothing) As Boolean
            Dim V_AccessValue As Boolean

            Try
                V_AccessValue = CType(V_SQL.User(TCODE, UID, TypeOfAccess), Boolean)

                If Not V_AccessValue Then
                    SystemSounds.Exclamation.Play()
                End If

                Return V_AccessValue
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
        Public Shared Function IsModuleReady(ByVal DBEngine As String, ByVal TCODE As String) As Boolean
            Dim V_IsModuleReady As Boolean

            Try
                V_IsModuleReady = CType(LibSQL.Application.Modules.Exist(DBEngine, TCODE), Boolean)

                Return V_IsModuleReady
            Catch ex As Exception
                Return False
            End Try
        End Function

        <SupportedOSPlatform("windows")>
        Public Shared Function IsModuleLocked(ByVal DBEngine As String, ByVal TCODE As String) As Boolean
            Dim V_IsModuleLocked As Boolean

            Try

                V_IsModuleLocked = CType(LibSQL.Application.Modules.Locked(DBEngine, TCODE), Boolean)

                Return V_IsModuleLocked
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Class

    Public Class Marquee
        Private V_CurrentText As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ.,-=\][!@#$%^&*()_+"
        Private V_Text As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ.,-=\][!@#$%^&*()_+"
        Private V_Direction As Direction = Direction.Left
        Private V_ScrollLength As Integer = 1000000
        Public V_MarqueeText As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ.,-=\][!@#$%^&*()_+"
        Public ReadOnly Property MarqueeText As String
            Get
                Return V_MarqueeText
            End Get
        End Property
        Public Property ScrollDirection As Direction
            Get
                Return V_Direction
            End Get
            Set(ByVal value As Direction)
                V_Direction = value
            End Set
        End Property
        Private ReadOnly Property CurrentText As String
            Get
                Return V_CurrentText
            End Get
        End Property
        Public Property Text As String
            Get
                Return V_Text
            End Get
            Set(ByVal value As String)
                V_Text = value
                V_CurrentText = value
            End Set
        End Property
        Public Property ScrollLength As Integer
            Get
                Return V_ScrollLength
            End Get
            Set(ByVal value As Integer)
                If value < 1 Then value = 1
                V_ScrollLength = value
            End Set
        End Property
        Public Sub Tick()
            If ScrollLength > Len(V_Text) Then ScrollLength = Len(V_Text)
            If ScrollDirection = Direction.Left Then
                Dim MoveCharacter As String = Mid$(V_CurrentText, 1, 1)
                V_CurrentText = Replace(V_CurrentText, MoveCharacter, "", 1, 1)
                V_CurrentText &= MoveCharacter
                V_MarqueeText = Mid$(V_CurrentText, 1, V_ScrollLength)
            ElseIf ScrollDirection = Direction.Right Then
                Dim MoveCharacter As String = Mid$(V_CurrentText, Len(V_CurrentText), 1)
                V_CurrentText = Mid$(V_CurrentText, 1, Len(V_CurrentText) - 1)
                V_CurrentText = MoveCharacter & V_CurrentText
                V_MarqueeText = Mid$(V_CurrentText, 1, V_ScrollLength)
            End If
        End Sub
        Public Enum Direction
            Left
            Right
        End Enum
    End Class
End Namespace
