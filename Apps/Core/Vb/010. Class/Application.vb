Namespace Application
    ''' <summary>
    ''' This class provides methods for managing user access and permissions within the application. It interacts with the underlying database to verify user credentials and access rights.
    ''' </summary>
    Public Class Access
        ReadOnly varAccess As New LibSQL.CMDapp.Access

        ''' <summary>
        ''' This function checks if a user has access to the application based on the provided data properties and user parameters. It returns a boolean value indicating whether the user is granted access or not.
        ''' </summary>
        ''' <param name="varDataProperties">The data properties of the user.</param>
        ''' <param name="status">Optional status parameter.</param>
        ''' <returns>Boolean value indicating whether the user has access.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Function User(varDataProperties As LibApp.Ingrid.Global.Properties, Optional status As CMCv.UI.Control.Stt = Nothing) As Boolean
            Dim varAccessValue As Boolean

            Try
                varAccessValue = varAccess.User(varDataProperties, varDataProperties.AllParameters)
                Return varAccessValue
            Catch ex As Exception
                System.Media.SystemSounds.Exclamation.Play()
                Return False
            End Try
        End Function
    End Class
End Namespace

Namespace Application
    ''' <summary>
    ''' This class provides methods for managing application modules, including checking if a module is ready or locked. It interacts with the underlying database to verify the status of modules based on the provided data properties and user parameters.
    ''' </summary>
    Public Class Modules
        ''' <summary>
        ''' This function checks if a module is ready based on the provided data properties. It returns a boolean value indicating whether the module is ready or not.
        ''' </summary>
        ''' <param name="dataproperties">The data properties of the module.</param>
        ''' <returns>Boolean value indicating whether the module is ready.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function IsModuleReady(dataproperties As LibApp.Ingrid.Global.Properties) As Boolean
            Dim varIsModuleReady As Boolean

            Try
                varIsModuleReady = LibSQL.CMDapp.Modules.Exist(dataproperties, dataproperties.AllParameters)

                Return varIsModuleReady
            Catch ex As Exception
                Return False
            End Try
        End Function

        ''' <summary>
        ''' This function checks if a module is locked based on the provided data properties. It returns a boolean value indicating whether the module is locked or not.
        ''' </summary>
        ''' <param name="dataproperties">The data properties of the module.</param>
        ''' <returns>Boolean value indicating whether the module is locked.</returns>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Shared Function IsModuleLocked(dataproperties As LibApp.Ingrid.Global.Properties) As Boolean
            Dim varIsModuleLocked As Boolean

            Try
                varIsModuleLocked = LibSQL.CMDapp.Modules.Locked(dataproperties, dataproperties.AllParameters)
                Return varIsModuleLocked
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Class

    ''' <summary>
    ''' This class provides functionality for creating a scrolling marquee effect with text. It allows you to set the text, scroll direction, and scroll length, and provides a method to update the marquee text on each tick.
    ''' </summary>
    Public Class Marquee
        Private varCurrentText As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ.,-=\][!@#$%^&*()_+"
        Private varText As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ.,-=\][!@#$%^&*()_+"
        Private varDirection As Direction = Direction.Left
        Private varScrollLength As Integer = 1000000
        Public varMarqueeText As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ.,-=\][!@#$%^&*()_+"

        ''' <summary>
        ''' Gets the current marquee text that is being displayed. This property returns the text that is currently visible in the marquee, which may be a subset of the full text based on the scroll length and direction.
        ''' </summary>
        ''' <returns>The current marquee text.</returns>
        Public ReadOnly Property MarqueeText As String
            Get
                Return varMarqueeText
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the direction in which the marquee text scrolls. The direction can be set to either left or right, determining how the text moves across the display area.
        ''' </summary>
        ''' <returns>The current scroll direction.</returns>
        Public Property ScrollDirection As Direction
            Get
                Return varDirection
            End Get
            Set(value As Direction)
                varDirection = value
            End Set
        End Property

        ''' <summary>
        ''' Gets the current text that is being scrolled in the marquee. This property returns the full text that is being used for the scrolling effect, which may be longer than the visible portion of the marquee.
        ''' </summary>
        ''' <returns>The current text being scrolled.</returns>
        Private ReadOnly Property CurrentText As String
            Get
                Return varCurrentText
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the full text that is used for the marquee scrolling effect. This property allows you to specify the text that will be scrolled, and it also updates the current text to match the new value when set.
        ''' </summary>
        ''' <returns>The full text used for the marquee scrolling effect.</returns>
        Public Property Text As String
            Get
                Return varText
            End Get
            Set(value As String)
                varText = value
                varCurrentText = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the length of the visible portion of the marquee text. This property determines how many characters of the full text are displayed at any given time, allowing you to control the width of the marquee effect.
        ''' </summary>
        ''' <returns>The length of the visible portion of the marquee text.</returns>
        Public Property ScrollLength As Integer
            Get
                Return varScrollLength
            End Get
            Set(value As Integer)
                If value < 1 Then value = 1
                varScrollLength = value
            End Set
        End Property

        ''' <summary>
        ''' Updates the marquee text by moving characters in the specified scroll direction. This method should be called on each tick of a timer or update loop to create the scrolling effect. It modifies the current text and updates the visible marquee text accordingly.
        ''' </summary>
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

        ''' <summary>
        ''' Defines the possible directions for scrolling the marquee text. The Direction enumeration includes two values: Left and Right, which determine the direction in which the text moves across the display area.
        ''' </summary>
        Public Enum Direction
            Left
            Right
        End Enum
    End Class
End Namespace
