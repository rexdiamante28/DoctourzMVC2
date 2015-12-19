@ModelType IEnumerable(Of Doctourz.Traits)
@Code
    ViewData("Title") = "ViewTraits"
    Layout = "~/Views/Shared/_UserLayout.vbhtml"
End Code

<h2>ViewTraits</h2>

<p>
    @Html.ActionLink("Add Traits", "AddTraits")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.trait)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.color)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.trait)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.description)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.color)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.traitId})
                <a href="#" id="@item.traitId" class="deleteTraitBtn">Delete</a>
            </td>
        </tr>
    Next

</table>
@Section scripts
<script>
    $(".deleteTraitBtn").click(function (event) {
        var traitId = $(event.currentTarget).context.id;
        $.ajax({
            url: '/Question/DeleteTrait/' + traitId,
            data: { id: traitId },
            type: 'POST',
            dataType: 'html',
            success: function () {
                alert("Successfully Deleted");
                window.location ="/Question/ViewTraits";
            }
        })
    })
</script>
End Section
