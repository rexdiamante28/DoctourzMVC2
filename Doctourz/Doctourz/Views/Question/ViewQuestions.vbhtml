@ModelType IEnumerable(Of Doctourz.Questions)
@Code
    ViewData("Title") = "ViewQuestions"
    Layout = "~/Views/Shared/_UserLayout.vbhtml"
    
    Dim db As New ApplicationDbContext
    Dim trait = db.Traits
End Code

<h2>View Questions</h2>

<p>
    @Html.ActionLink("Add Question", "AddQuestions")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.question)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.isNegative)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.traitId)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.question)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.isNegative)
            </td>
            <td>
                @For Each x In trait
                If item.traitId = x.traitId Then
                    @Html.DisplayFor(Function(modelItem) x.trait)
                End If
                Next
            </td>
            <td>
                @Html.ActionLink("Edit", "EditQuestions", New With {.id = item.questionId})
                <a href="#" id="@item.questionId" class="deleteQuestionBtn">Delete</a>
            </td>
        </tr>
    Next

</table>
@Section scripts
<script>
    $(".deleteQuestionBtn").click(function (event) {
        var traitId = $(event.currentTarget).context.id;
        $.ajax({
            url: '/Question/DeleteQuestion/' + traitId,
            data: { id: traitId },
            type: 'POST',
            dataType: 'html',
            success: function () {
                alert("Successfully Deleted");
                window.location ="/Question/ViewQuestions";
            }
        })
    })
</script>
End Section
