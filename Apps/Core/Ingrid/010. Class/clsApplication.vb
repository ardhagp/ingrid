Imports CMCv
Imports System.Media

Namespace Application
    Public Class Access
        Dim _SQL As New LibSQL.Application.Access

        Public Function User(ByVal TCODE As String, ByVal UID As String, ByVal TypeOfAccess As LibSQL.Application.Access.TypeOfAccess, Optional ByVal Status As stt = Nothing) As Boolean
            Dim _AccessValue As Integer = 0

            Try
                _AccessValue = _SQL.User(TCODE, UID, TypeOfAccess)

                If _AccessValue = 0 Then
                    SystemSounds.Exclamation.Play()
                End If

                Return _AccessValue

            Catch ex As Exception
                SystemSounds.Exclamation.Play()
                Return False
            End Try
        End Function
    End Class
End Namespace

Namespace Application
    Public Class Modules
        Dim _SQL As New LibSQL.Application.Modules

        Public Function IsModuleReady(ByVal TCODE As String) As Boolean
            Dim _IsModuleReady As Integer = 0

            Try
                _IsModuleReady = _SQL.Exist(TCODE)

                Return _IsModuleReady
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Function IsModuleLocked(ByVal TCODE As String) As Boolean
            Dim _IsModuleLocked As Boolean = False

            Try
                _IsModuleLocked = _SQL.Locked(TCODE)

                Return _IsModuleLocked
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Class

    Public Class Marquee
        Private _CurrentText As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ.,-=\][!@#$%^&*()_+"
        Private _text As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ.,-=\][!@#$%^&*()_+"
        Private _Direction As Direction = Direction.Left
        Private _ScrollLength As Integer = 1000000
        Public _MarqueeText As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ.,-=\][!@#$%^&*()_+"
        Public ReadOnly Property MarqueeText As String
            Get
                Return _MarqueeText
            End Get
        End Property
        Public Property ScrollDirection As Direction
            Get
                Return _Direction
            End Get
            Set(ByVal value As Direction)
                _Direction = value
            End Set
        End Property
        Private ReadOnly Property CurrentText As String
            Get
                Return _CurrentText
            End Get
        End Property
        Public Property Text As String
            Get
                Return _text
            End Get
            Set(ByVal value As String)
                _text = value
                _CurrentText = value
            End Set
        End Property
        Public Property ScrollLength As Integer
            Get
                Return _ScrollLength
            End Get
            Set(ByVal value As Integer)
                If value < 1 Then value = 1
                _ScrollLength = value
            End Set
        End Property
        Public Sub Tick()
            If ScrollLength > Len(_text) Then ScrollLength = Len(_text)
            If ScrollDirection = Direction.Left Then
                Dim MoveCharacter As String = Mid$(_CurrentText, 1, 1)
                _CurrentText = Replace(_CurrentText, MoveCharacter, "", 1, 1)
                _CurrentText = _CurrentText & MoveCharacter
                _MarqueeText = Mid$(_CurrentText, 1, _ScrollLength)
            ElseIf ScrollDirection = Direction.Right Then
                Dim MoveCharacter As String = Mid$(_CurrentText, Len(_CurrentText), 1)
                _CurrentText = Mid$(_CurrentText, 1, Len(_CurrentText) - 1)
                _CurrentText = MoveCharacter & _CurrentText
                _MarqueeText = Mid$(_CurrentText, 1, _ScrollLength)
            End If
        End Sub
        Public Enum Direction
            Left
            Right
        End Enum
    End Class
End Namespace
