Imports System.Web.Mvc

Namespace Controllers
    Public Class QuestionController
        Inherits Controller

        'COMMENT
        ' GET: Question
        Function Main() As ActionResult
            Return View()
        End Function

        ' GET: Question/Details/5
        Function Details(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' GET: Question/Create
        Function AddTraits() As ActionResult
            Dim db As New ApplicationDbContext
            ViewData("TraitId") = New SelectList(db.Traits, "traitId", "trait")
            Return PartialView("AddTraits")
        End Function

        ' POST: Question/Create
        <HttpPost()>
        Function AddTraits(ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add insert logic here
                Dim db = New ApplicationDbContext
                Dim trait = New Traits With {
                    .trait = collection.GetValue("trait").AttemptedValue,
                    .description = collection.GetValue("description").AttemptedValue
                }
                db.Traits.Add(trait)
                db.SaveChanges()

                Return RedirectToAction("ViewTraits")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Question/Edit/5
        Function EditTraits(ByVal id As Integer) As ActionResult
            Dim db = New ApplicationDbContext
            Dim trait = db.Traits.Where(Function(model) model.traitId = id).First

            Return View(trait)
        End Function

        ' POST: Question/Edit/5
        <HttpPost()>
        Function EditTraits(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here
                Dim db = New ApplicationDbContext
                Dim trait = db.Traits.Where(Function(model) model.traitId = id).First

                trait.trait = collection.GetValue("trait").AttemptedValue
                trait.description = collection.GetValue("description").AttemptedValue

                db.Entry(trait).State = Entity.EntityState.Modified
                db.SaveChanges()



                Return RedirectToAction("ViewTraits")
            Catch ex As Exception
                MsgBox(ex.Message)
                Return View()
            End Try
        End Function

        ' GET: Question/Delete/5
        Function DeleteTrait(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Question/Delete/5
        <HttpPost()>
        Function DeleteTrait(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here
                Dim db = New ApplicationDbContext
                Dim trait = db.Traits.Where(Function(model) model.traitId = id).First
                db.Traits.Remove(trait)
                db.SaveChanges()

                Return RedirectToAction("ViewTraits")
            Catch
                Return View()
            End Try
        End Function

        Function ViewTraits() As ActionResult
            Dim db = New ApplicationDbContext
            Dim model = db.Traits

            Return View(model)
        End Function

        Function TakeSurvey() As ActionResult
            Dim db = New ApplicationDbContext
            Dim traits = db.Traits
            Return View(traits)
        End Function

        ' VIEW QUESTIONS
        Function ViewQuestions() As ActionResult
            Dim db = New ApplicationDbContext
            Dim model = db.Questions

            Return View(model)
        End Function

        ' GET: Question/Create
        Function AddQuestions() As ActionResult
            Return PartialView("AddQuestions")
        End Function

        ' POST: Question/Create
        <HttpPost()>
        Function AddQuestions(ByVal collection As FormCollection) As ActionResult
            Dim isNegative As Boolean = False
            If collection.GetValue("isNegative").AttemptedValue.Contains("true") Then
                isNegative = True
            End If

            Try
                ' TODO: Add insert logic here
                Dim db = New ApplicationDbContext
                Dim q = New Questions With {
                    .question = collection.GetValue("question").AttemptedValue,
                    .isNegative = isNegative,
                    .traitId = collection.GetValue("traitId").AttemptedValue
                }
                db.Questions.Add(q)
                db.SaveChanges()

                Return RedirectToAction("ViewQuestions")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Question/Edit/5
        Function EditQuestions(ByVal id As Integer) As ActionResult
            Dim db = New ApplicationDbContext
            Dim q = db.Questions.Where(Function(model) model.questionId = id).First

            Return View(q)
        End Function

        ' POST: Question/Edit/5
        <HttpPost()>
        Function EditQuestions(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Dim isNegative As Boolean = False
            If collection.GetValue("isNegative").AttemptedValue.Contains("true") Then
                isNegative = True
            End If

            'Try
            ' TODO: Add update logic here
            Dim db = New ApplicationDbContext
            Dim q = db.Questions.Where(Function(model) model.questionId = id).First

            q.question = collection.GetValue("question").AttemptedValue
            q.isNegative = isNegative
            q.traitId = collection.GetValue("traitId").AttemptedValue

            db.Entry(q).State = Entity.EntityState.Modified
            db.SaveChanges()

            Return RedirectToAction("ViewQuestions")
            'Catch ex As Exception
            '    'MsgBox(ex.Message)
            '    Return View()
            'End Try
        End Function

        ' GET: Question/Delete/5
        Function DeleteQuestion(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Question/Delete/5
        <HttpPost()>
        Function DeleteQuestion(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here
                Dim db = New ApplicationDbContext
                Dim q = db.Questions.Where(Function(model) model.questionId = id).First
                db.Questions.Remove(q)
                db.SaveChanges()

                Return RedirectToAction("ViewQuestions")
            Catch
                Return View()
            End Try
        End Function
    End Class
End Namespace