Public Class UserController
    Inherits System.Web.Mvc.Controller

    Function Home() As ActionResult
        If Not Request.IsAuthenticated Then
            Return RedirectToAction("Index", "Home")
        End If
        ViewData("Message") = "Your user landing page."

        Return View()
    End Function

    Function Name() As ActionResult
        ViewData("Message") = "Your usern name page."

        Return View()
    End Function

    Function Gender() As ActionResult
        ViewData("Message") = "Your user gender page."

        Return View()
    End Function

    Function Birthdate() As ActionResult
        ViewData("Message") = "Your user birthdate page."

        Return View()
    End Function

    Function Location() As ActionResult
        ViewData("Message") = "Your user location page."

        Return View()
    End Function

    Function Topics() As ActionResult
        ViewData("Message") = "Your user topics page."

        Return View()
    End Function

    Function Survey() As ActionResult
        ViewData("Message") = "Your user survey page."

        Return View()
    End Function

    Function News() As ActionResult
        ViewData("Message") = "Your user news page."

        Return View()
    End Function

    Function Ask() As ActionResult
        ViewData("Message") = "Your user ask doctor page."

        Return View()
    End Function

    Function Todo() As ActionResult
        ViewData("Message") = "Your user Todo page."

        Return View()
    End Function

    Function Search() As ActionResult
        ViewData("Message") = "Your user Search page."

        Return View()
    End Function

    Function Telemed() As ActionResult
        ViewData("Message") = "Your user Telemed page."

        Return View()
    End Function
End Class
