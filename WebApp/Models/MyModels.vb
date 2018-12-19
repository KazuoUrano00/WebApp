
Imports Microsoft.Ajax.Utilities

'member model
Public Class MyModels
    Public Id As Integer
    Public Name As String
    Public Email As String
End Class

'context class
Public Class MyContext

    Public Property DbtestM() As ISet(Of Member)
End Class
