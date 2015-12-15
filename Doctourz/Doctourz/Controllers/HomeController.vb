Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function

    Function SignUp() As ActionResult
        ViewData("Message") = "Your registration page."

        Return View()
    End Function

    Function Login() As ActionResult
        ViewData("Message") = "Your Login page."

        Return View()
    End Function
End Class
