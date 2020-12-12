Public Class MyCustomException
    Inherits Exception
    'This Class demos how to make a simple Custom Exception Class
    Public Shadows Message As String = "Your friendly message here"
End Class
