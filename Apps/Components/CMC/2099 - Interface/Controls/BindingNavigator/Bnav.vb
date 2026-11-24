Namespace UI.Control
    ''' <summary>
    ''' This control is a custom BindingNavigator that provides additional features and customization options for navigating through data in a Windows Forms application. It includes properties for showing or hiding the Add New and Delete buttons, allowing developers to control the availability of these actions based on the application's requirements. The control also raises events when a navigation action occurs, enabling developers to handle user interactions effectively.
    ''' </summary>
    Public Class Bnav
        Public Event XOSelected()

        ''' <summary>
        ''' Initializes a new instance of the Bnav class, which is a custom BindingNavigator control. This constructor sets up the control's appearance and behavior, including font and background color, to provide a consistent look and feel for navigating through data in a Windows Forms application.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub New()
            MyBase.New(True)
            InitializeComponent()
            MyBase.Font = Component.Properties.globalFontDgn
            MyBase.BackColor = System.Drawing.Color.FromArgb(11, 28, 45)
        End Sub

        ''' <summary>
        ''' Initializes the navigator by setting up the various ToolStripItems, such as navigation buttons and position indicators, and configuring their visibility based on the control's properties.
        ''' </summary>
        <System.Runtime.Versioning.SupportedOSPlatform("windows")>
        Public Sub InitializeNavigator()
            With Me
                For Each item As System.Windows.Forms.ToolStripItem In Me.Items
                    Select Case item.Name
                        Case "bindingNavigatorMoveFirstItem"
                            .MoveFirstItem = item

                        Case "bindingNavigatorMovePreviousItem"
                            .MovePreviousItem = item

                        Case "bindingNavigatorMoveNextItem"
                            .MoveNextItem = item

                        Case "bindingNavigatorMoveLastItem"
                            .MoveLastItem = item

                        Case "bindingNavigatorPositionItem"
                            .PositionItem = DirectCast(item, System.Windows.Forms.ToolStripTextBox)
                            item.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255)
                            item.BackColor = System.Drawing.Color.FromArgb(11, 28, 45)

                        Case "bindingNavigatorCountItem"
                            .CountItem = DirectCast(item, System.Windows.Forms.ToolStripLabel)
                            item.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255)

                        Case "bindingNavigatorAddNewItem"
                            item.Visible = XOIsShowAddNewButton

                        Case "bindingNavigatorDeleteItem"
                            item.Visible = XOIsShowDeleteButton
                    End Select
                Next
            End With
        End Sub

        ''' <summary>
        ''' Gets or sets a value indicating whether the Add New button is visible on the navigator. This property allows developers to control the availability of the Add New action based on the application's requirements.
        ''' </summary>
        <System.ComponentModel.Category("XO.Format"),
    System.ComponentModel.Description("Indicates whether the Navigator displays the Add New button")>
        Private varIsShowAddNewButton As Boolean
        Public Property XOIsShowAddNewButton() As Boolean
            Get
                Return varIsShowAddNewButton
            End Get
            Set(value As Boolean)
                varIsShowAddNewButton = value
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets a value indicating whether the Delete button is visible on the navigator. This property allows developers to control the availability of the Delete action based on the application's requirements.
        ''' </summary>
        <System.ComponentModel.Category("XO.Format"),
   System.ComponentModel.Description("Indicates whether the Navigator displays the Delete button")>
        Private varIsShowDeleteButton As Boolean
        Public Property XOIsShowDeleteButton() As Boolean
            Get
                Return varIsShowDeleteButton
            End Get
            Set(value As Boolean)
                varIsShowDeleteButton = value
            End Set
        End Property
    End Class
End Namespace