Public Class UserController
    Inherits System.Web.Mvc.Controller

    Function Home() As ActionResult
        If Not Request.IsAuthenticated Then
            Return RedirectToAction("Index", "Home")
        End If
        ViewData("Message") = "Your user landing page."

        Return View()
    End Function
End Class
