Imports System.ComponentModel.Composition
Imports CMCv
Imports ingrid

<Export(GetType(ingrid.mainframe.ICommandFunction))>
<ExportMetadata("MyName", "Extension2")>
Public Class InitCommand
    Implements ingrid.mainframe.ICommandFunction

    Public Function LoadCommand() As frmStandard Implements mainframe.ICommandFunction.LoadCommand
        'Return 
    End Function
End Class
