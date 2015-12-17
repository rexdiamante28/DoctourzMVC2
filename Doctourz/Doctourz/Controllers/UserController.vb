Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin.Security

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

    <HttpPost()>
    <ValidateAntiForgeryToken>
    Function Name(obj As FormCollection) As ActionResult
        Dim userId = User.Identity.GetUserId
        Dim db As New ApplicationDbContext
        Dim profileName = db.AppUsers.Where(Function(x) x.userId = userId).FirstOrDefault()
        profileName.name = obj.GetValue("name").AttemptedValue
        db.SaveChanges()
        Return RedirectToAction("Gender", "User")
    End Function

    Function Gender() As ActionResult
        ViewData("Message") = "Your user gender page."

        Return View()
    End Function

    <HttpPost()>
    <ValidateAntiForgeryToken>
    Function Gender(obj As FormCollection) As ActionResult
        Dim userId = User.Identity.GetUserId
        Dim db As New ApplicationDbContext
        Dim profileGender = db.AppUsers.Where(Function(x) x.userId = userId).FirstOrDefault()
        profileGender.gender = "FEMALE"
        db.SaveChanges()
        Return RedirectToAction("Birthdate", "User")
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
