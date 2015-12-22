Imports System.Threading.Tasks
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin.Security
Imports System.Linq
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

        If Not String.IsNullOrEmpty(obj.GetValue("name").AttemptedValue) Then
            Dim profileName = db.AppUsers.Where(Function(x) x.userId = userId).FirstOrDefault()
            profileName.name = obj.GetValue("name").AttemptedValue
            db.SaveChanges()
        End If

        Return RedirectToAction("Gender", "User")
    End Function

    Function Gender() As ActionResult
        ViewData("Message") = "Your user gender page."

        Return View()
    End Function

    <HttpPost()>
    <ValidateAntiForgeryToken>
    Function Gender(obj As FormCollection) As ActionResult
        Dim profileGender As String = ""
        Dim userId = User.Identity.GetUserId
        Dim db As New ApplicationDbContext

        If String.IsNullOrEmpty(obj("male")) And String.IsNullOrEmpty(obj("female")) Then
            ViewBag.Error = "Please select a gender"
        Else
            If Not String.IsNullOrEmpty(obj("male")) Then
                profileGender = obj("male")
            End If
            If Not String.IsNullOrEmpty(obj("female")) Then
                profileGender = obj("female")
            End If
            Dim updateProfile = db.AppUsers.Where(Function(x) x.userId = userId).FirstOrDefault()
            updateProfile.gender = profileGender.ToString
            db.SaveChanges()
            Return RedirectToAction("Birthdate", "User")
        End If

        Return View()
    End Function

    Function Birthdate() As ActionResult
        ViewData("Message") = "Your user birthdate page."

        Return View()
    End Function

    <HttpPost()>
    <ValidateAntiForgeryToken>
    Function Birthdate(obj As FormCollection) As ActionResult
        Dim profileBirthDate As DateTime
        Dim userId = User.Identity.GetUserId
        Dim db As New ApplicationDbContext

        If Not String.IsNullOrEmpty(obj("birthdate")) Then
            profileBirthDate = DateTime.Parse(obj("birthdate"))
            Dim updateProfile = db.AppUsers.Where(Function(x) x.userId = userId).FirstOrDefault()
            updateProfile.birthDate = profileBirthDate.ToString
            db.SaveChanges()
        End If

        Return RedirectToAction("Location", "User")
    End Function

    Function Location() As ActionResult
        ViewData("Message") = "Your user location page."

        Return View()
    End Function

    <HttpPost()>
    <ValidateAntiForgeryToken>
    Function Location(obj As FormCollection) As ActionResult
        Dim profileLocation As String
        Dim userId = User.Identity.GetUserId
        Dim db As New ApplicationDbContext

        If Not String.IsNullOrEmpty(obj("location")) Then
            profileLocation = obj("location")
            Dim updateProfile = db.AppUsers.Where(Function(x) x.userId = userId).FirstOrDefault()
            updateProfile.location = profileLocation
            db.SaveChanges()
        End If

        Return RedirectToAction("Topics", "User")
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


        Return View()
    End Function

    Public Function Menu() As ActionResult
        Return PartialView("Menu")
    End Function

    Public Function Dma() As ActionResult
        Return PartialView("Dma")
    End Function

    Public Function appointment() As ActionResult
        Return PartialView("appointment")
    End Function

    Public Function CareTeam() As ActionResult
        Return PartialView("CareTeam")
    End Function

    Public Function PatientRecords() As ActionResult
        Return PartialView("PatientRecords")
    End Function

    Public Function Notes() As ActionResult
        Return PartialView("Notes")
    End Function

    Public Function Diagnosis() As ActionResult
        Return PartialView("Diagnosis")
    End Function
End Class
