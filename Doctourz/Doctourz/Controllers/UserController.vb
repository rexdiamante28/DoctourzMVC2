Public Class UserController
    Inherits System.Web.Mvc.Controller

    Function Home() As ActionResult
        ViewData("Message") = "Your user landing page."

        Return View()
    End Function

    Function Telemed() As ActionResult
        ViewData("Message") = "Your user Telemed page."

        Return View()
    End Function
End Class
