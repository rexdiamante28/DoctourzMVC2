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
            Return PartialView("AddTraits")
        End Function

        ' POST: Question/Create
        <HttpPost()>
        Function AddTraits(ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add insert logic here
                'Dim db = New ApplicationDbContext
                'Dim trait = New Traits With {
                '    .trait = collection.GetValue("trait").AttemptedValue,
                '    .description = collection.GetValue("description").AttemptedValue,
                '    .color = collection.GetValue("color").AttemptedValue
                '}
                'db.Traits.Add(trait)
                'db.SaveChanges()

                'Return RedirectToAction("ViewTraits")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Question/Edit/5
        Function Edit(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Question/Edit/5
        <HttpPost()>
        Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here
                ' TODO: Add update logic here
                Return RedirectToAction("Index")
            Catch
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
                'Dim db = New ApplicationDbContext
                'Dim trait = db.Traits.Where(Function(model) model.traitId = id).First
                'db.Traits.Remove(trait)
                'db.SaveChanges()

                Return RedirectToAction("ViewTraits")
            Catch
                Return View()
            End Try
        End Function

        'Function ViewTraits() As ActionResult
        '    Dim db = New ApplicationDbContext
        '    'Dim model = db.Traits

        '    Return View(model)
        'End Function
    End Class
End Namespace