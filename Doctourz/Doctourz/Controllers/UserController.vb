Imports System.Threading.Tasks
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin.Security
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Public Class UserController
    Inherits System.Web.Mvc.Controller

    Public Property doctorList As New List(Of DoctorList)

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

    Function Telemed() As ActionResult
        Return View()
    End Function

    Function Search() As ActionResult
        Return View()
    End Function

    Function SearchDoctor(ByVal keyword As String) As ActionResult
        ViewBag.Keyword = keyword

        MainSearch(keyword)

        TempData("AllDoctors") = doctorList
        TempData("Keyword") = keyword
        ViewBag.Doctors = doctorList

        Return PartialView("SearchDoctor")
    End Function

    'FILTER DOCTOR BY GENDER
    Function FilterDoctor(type As String, filter As String) As ActionResult
        ViewBag.Keyword = TempData("Keyword")

        doctorList = TempData("AllDoctors")

        If type = "gender" Then
            doctorList = doctorList.Where(Function(x) x.docGender.ToLower = filter.ToLower).ToList()
        ElseIf type = "location" Then
            doctorList = doctorList.Where(Function(x) x.docLocation.ToLower.Contains(filter.ToLower)).ToList()
        ElseIf type = "specialty" Then
            doctorList = doctorList.Where(Function(x) x.docSpecializationId.ToLower = filter.ToLower).ToList()
        End If

        TempData("Keyword") = TempData("Keyword")
        TempData("AllDoctors") = TempData("AllDoctors")

        ViewBag.Doctors = doctorList

        Return PartialView("SearchDoctor")
    End Function

    Function MainSearch(keyword As String)
        Dim db As New ApplicationDbContext

        'GET DOCTOR ROLE
        Dim userRoie = db.Roles.Where(Function(x) x.Name = "Doctor").FirstOrDefault()

        'GET USERS WITH DOCTOR ROLE
        Dim users = db.Users.ToList().Where(Function(x) x.Roles.Any(Function(s) s.RoleId = userRoie.Id And x.UserName.Contains(keyword))).ToList()
        For Each item In users
            'DETAILS
            Dim docDetails = db.AppUsers.Where(Function(x) x.userId = item.Id).FirstOrDefault()
            Dim spec = db.Specializations.Where(Function(x) x.userId = item.Id).FirstOrDefault()
            Dim spDetails As String = "None"
            Dim spId As String = "0"
            If spec IsNot Nothing Then
                Dim spCategory = db.SpecializationCategory.Where(Function(x) x.id = spec.categoryId).FirstOrDefault()
                spDetails = spCategory.name
                spId = spCategory.id
            End If
            doctorList.Add(New DoctorList() With { _
                           .docId = item.Id, _
                           .docName = docDetails.name, _
                           .docSpecializationId = spId, _
                           .docSpecialization = spDetails, _
                           .docLocation = docDetails.location, _
                           .docGender = docDetails.gender})
        Next

        Return doctorList
    End Function

    Public Function Menu() As ActionResult
        Return PartialView("Menu")
    End Function

    Public Function Dma() As ActionResult
        Return PartialView()
    End Function

    Public Function Notifications() As ActionResult
        Return PartialView()
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
    'Public Function SearchDoctor() As ActionResult
    '    Return PartialView("SearchDoctor")
    'End Function



End Class
