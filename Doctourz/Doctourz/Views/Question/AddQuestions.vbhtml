@ModelType Doctourz.Questions
@Code
    ViewData("Title") = "AddQuestions"
    Layout = "~/Views/Shared/_UserLayout.vbhtml"
End Code
<div class="row">
    <h2>Add Questions</h2>

    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-horizontal">
            <h4>Questions</h4>
            <hr />
            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

            <div class="form-group">
                @Html.LabelFor(Function(model) model.question, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.question, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.question, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.isNegative, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.isNegative, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.isNegative, "", New With {.class = "text-danger"})
                </div>
            </div>

             <div class="form-group">
                 @Html.LabelFor(Function(model) model.traitId, htmlAttributes:=New With {.class = "control-label col-md-2"})
                 <div class="col-md-10">
                     @Html.EditorFor(Function(model) model.traitId, New With {.htmlAttributes = New With {.class = "form-control"}})
                     @Html.ValidationMessageFor(Function(model) model.traitId, "", New With {.class = "text-danger"})
                 </div>
             </div>

             <div class="form-group">
                 <div class="col-md-10">
                    @Html.DropDownList("TraitId", String.Empty)
                 </div>
             </div>

            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <input type="submit" value="Create" class="btn btn-default" />
                </div>
            </div>
        </div>
    End Using

    <div>
        @Html.ActionLink("Back to List", "ViewQuestions")
    </div>
</div>