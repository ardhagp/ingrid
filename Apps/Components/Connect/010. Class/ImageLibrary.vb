Namespace UI.Resource
    ''' <summary>
    ''' This structure is used to store and provide access to image resources used in the application, such as icons for various UI elements.
    ''' </summary>
    Public Structure ImageLibrary
        ''' <summary>
        ''' The image resource for the edit icon, which can be used in various UI elements to represent editing functionality.
        ''' </summary>
        ''' <returns>The image resource for the edit icon.</returns>
        Shared Property EDIT_ICON As Image = My.Resources.EDIT_icon
    End Structure
End Namespace
