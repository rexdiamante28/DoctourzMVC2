Imports System.Threading.Tasks
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin.Security
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System
Imports System.Collections.Generic
Imports System.IO
Public Class UserController
    Inherits System.Web.Mvc.Controller

    Public Property doctorList As New List(Of DoctorList)
    Public Property userDoctor As New List(Of DoctorList)

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

    Function SearchDoctor(ByVal keyword As String, ByVal location As String, ByVal gender As String, ByVal specialty As String, ByVal degree As String) As ActionResult
        ViewBag.Keyword = keyword
        'ViewBag.Location = gender
        ViewBag.Location = location

        MainSearch(keyword)

        If Not location = "" Then
            doctorList = userDoctor.Where(Function(x) x.docLocation.ToLower.Contains(location.ToLower)).ToList()
        End If

        If Not gender = "" Then
            doctorList = userDoctor.Where(Function(x) x.docGender.ToLower = gender.ToLower).ToList()
        End If

        If Not specialty = "" Then
            ViewBag.Specialty = specialty
            For Each sp In specialty
                For Each item In userDoctor
                    If sp = item.docSpecializationId Then
                        Dim existing = doctorList.FirstOrDefault(Function(x) x.docId.Contains(item.docId))
                        If Not existing IsNot Nothing Then
                            doctorList.Add(New DoctorList() With { _
                                                         .docId = item.docId, _
                                                         .docName = item.docName, _
                                                         .docSpecializationId = item.docSpecializationId, _
                                                         .docSpecialization = item.docSpecialization, _
                                                         .docLocation = item.docLocation, _
                                                         .docGender = item.docGender, _
                                                         .docDegree = item.docDegree
                                                     })
                        End If
                    End If
                Next
            Next
        End If

        If Not degree = "" Then
            ViewBag.Degree = degree
            For Each dg In degree
                For Each item In userDoctor
                    If dg = item.docDegree Then
                        Dim existing = doctorList.FirstOrDefault(Function(x) x.docId.Contains(item.docId))
                        If Not existing IsNot Nothing Then
                            doctorList.Add(New DoctorList() With { _
                                                          .docId = item.docId, _
                                                          .docName = item.docName, _
                                                          .docSpecializationId = item.docSpecializationId, _
                                                          .docSpecialization = item.docSpecialization, _
                                                          .docLocation = item.docLocation, _
                                                          .docGender = item.docGender, _
                                                          .docDegree = item.docDegree
                                                      })
                        End If
                    End If
                Next
            Next
        End If

        If location = "" And gender = "" And specialty = "" And degree = "" Then
            doctorList = userDoctor
        End If

        ViewBag.Doctors = doctorList

        Return PartialView(doctorList)
    End Function

    Function MainSearch(keyword As String)
        Dim db As New ApplicationDbContext
        Dim docId As String = ""
        Dim docName As String = ""
        Dim docLocation As String = ""
        Dim docGender As String = ""
        Dim docSpecializationId As String = ""
        Dim docSpecialization As String = ""
        Dim docDegeree As String = ""
        Try
            'GET DOCTOR ROLE
            Dim userRoie = db.Roles.Where(Function(x) x.Name = "Doctor").FirstOrDefault()

            Dim usrs = From users In db.Users _
                        Group Join appUsers In db.AppUsers On users.Id Equals appUsers.userId Into docUsers = Group _
                        From u In docUsers.DefaultIfEmpty()
                        Group Join spec In db.Specializations On users.Id Equals spec.userId Into docSpecs = Group _
                        From s In docSpecs.DefaultIfEmpty() _
                        Group Join specCategory In db.SpecializationCategory On s.categoryId Equals specCategory.id Into category = Group _
                        From c In category.DefaultIfEmpty() _
                        Group Join education In db.Education On users.Id Equals education.userId Into docEduc = Group _
                        From e In docEduc.DefaultIfEmpty() _
                        Group Join degree In db.Degree On e.degreeId Equals degree.id Into eDegree = Group _
                        From d In eDegree.DefaultIfEmpty() _
                        Where users.Roles.Any(Function(x) x.RoleId = userRoie.Id) And u.name.ToLower.Contains(keyword.ToLower) _
                        Select u, s, c, e, d

            For Each item In usrs
                If item.u IsNot Nothing Then
                    docId = item.u.userId
                    docName = item.u.name
                    docLocation = item.u.location
                    docGender = item.u.gender
                End If
                If item.s IsNot Nothing Then
                    docSpecialization = item.s.categoryId
                End If
                If item.e IsNot Nothing Then
                    docDegeree = item.e.degreeId
                End If

                userDoctor.Add(New DoctorList() With { _
                               .docId = docId, _
                               .docName = docName, _
                               .docSpecializationId = docSpecializationId, _
                               .docSpecialization = docSpecialization, _
                               .docLocation = docLocation, _
                               .docGender = docGender, _
                               .docDegree = docDegeree
                           })
            Next
        Catch
        End Try

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

    Public Function HealthProfile() As ActionResult
        Dim db As New ApplicationDbContext
        Dim userId = User.Identity.GetUserId
        Dim history1 = From a In db.History1
                      Where a.userId = userId
                      Select a

        Dim history As New List(Of History1)
        For Each i In history1
            history.Add(New History1() With {.symptom = i.symptom, .whoHadIt = i.whoHadIt, .age = i.age})
        Next

        ViewBag.history1 = history


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

    Function UpdateName(usr As AppUsers) As JsonResult
        usr.userId = User.Identity.GetUserId

        Using db As New ApplicationDbContext
            If usr.userId IsNot Nothing Then
                Dim update = db.AppUsers.Where(Function(x) x.userId = usr.userId).First
                update.firstName = usr.firstName
                update.lastName = usr.lastName
                update.name = usr.firstName + " " + usr.lastName

                db.SaveChanges()
            End If
        End Using

        Return New JsonResult With {
                .Data = New With {.message = "Successfully Updated!"}
            }
    End Function

    Function UpdateGender(usr As AppUsers) As JsonResult
        usr.userId = User.Identity.GetUserId

        Using db As New ApplicationDbContext
            If usr.userId IsNot Nothing Then
                Dim update = db.AppUsers.Where(Function(x) x.userId = usr.userId).First
                update.gender = usr.gender

                db.SaveChanges()
            End If
        End Using

        Return New JsonResult With {
                .Data = New With {.message = "Successfully Updated!"}
            }
    End Function
    Function UpdateLocation(usr As AppUsers) As JsonResult
        usr.userId = User.Identity.GetUserId

        Using db As New ApplicationDbContext
            If usr.userId IsNot Nothing Then
                Dim update = db.AppUsers.Where(Function(x) x.userId = usr.userId).First
                update.location = usr.location

                db.SaveChanges()
            End If
        End Using

        Return New JsonResult With {
                .Data = New With {.message = "Successfully Updated!"}
            }
    End Function
    Function UpdateBirthDate(usr As AppUsers) As JsonResult
        usr.userId = User.Identity.GetUserId

        Using db As New ApplicationDbContext
            If usr.userId IsNot Nothing Then
                Dim update = db.AppUsers.Where(Function(x) x.userId = usr.userId).First
                update.birthDate = usr.birthDate

                db.SaveChanges()
            End If
        End Using

        Return New JsonResult With {
                .Data = New With {.message = "Successfully Updated!"}
            }
    End Function

    Function UpdateEthnicity(usr As AppUsers) As JsonResult
        usr.userId = User.Identity.GetUserId

        Using db As New ApplicationDbContext
            If usr.userId IsNot Nothing Then
                Dim update = db.AppUsers.Where(Function(x) x.userId = usr.userId).First
                update.ethnicityId = usr.ethnicityId

                db.SaveChanges()
            End If
        End Using

        Return New JsonResult With {
                .Data = New With {.message = "Successfully Updated!"}
            }
    End Function

    Function UpdateHeight(usr As AppUsers) As JsonResult
        usr.userId = User.Identity.GetUserId

        Using db As New ApplicationDbContext
            If usr.userId IsNot Nothing Then
                Dim update = db.AppUsers.Where(Function(x) x.userId = usr.userId).First
                update.height = usr.height
                update.bmi = usr.bmi

                db.SaveChanges()
            End If
        End Using

        Return New JsonResult With {
                .Data = New With {.message = "Successfully Updated!"}
            }
    End Function

    Function UpdateWeight(usr As AppUsers) As JsonResult
        usr.userId = User.Identity.GetUserId

        Using db As New ApplicationDbContext
            If usr.userId IsNot Nothing Then
                Dim update = db.AppUsers.Where(Function(x) x.userId = usr.userId).First
                update.weight = usr.weight
                update.bmi = usr.bmi

                db.SaveChanges()
            End If
        End Using

        Return New JsonResult With {
                .Data = New With {.message = "Successfully Updated!"}
            }
    End Function
    Function getAppUser() As JsonResult
        Dim db As New ApplicationDbContext
        Dim usrId = User.Identity.GetUserId
        Dim appUsr = db.AppUsers.Where(Function(x) x.userId = usrId).First

        Return New JsonResult With {
                .Data = appUsr,
                .JsonRequestBehavior = JsonRequestBehavior.AllowGet
            }
    End Function

    Public Function Upload(ByVal file As HttpPostedFileBase, usr As AppUsers) As ActionResult
        Try

            Dim path0 = Server.MapPath("~/Images/")

            If System.IO.Directory.Exists(path0) = False Then
                System.IO.Directory.CreateDirectory(path0)
            End If

            Dim pic As String = System.IO.Path.GetFileName(file.FileName)
            Dim path As String = System.IO.Path.Combine(Server.MapPath("~/Images/"), pic)


            usr.userId = User.Identity.GetUserId

            Using db As New ApplicationDbContext
                If usr.userId IsNot Nothing Then
                    Dim update = db.AppUsers.Where(Function(x) x.userId = usr.userId).First
                    update.avatar = pic

                    db.SaveChanges()
                End If
            End Using

            file.SaveAs(path)
            ViewBag.image = pic
            Response.Redirect("News")
        Catch ex As Exception
            Response.Redirect("News")
        End Try

    End Function

End Class
