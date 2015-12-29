@ModelType IEnumerable(Of Doctourz.Questions)
@Code
    ViewData("Title") = "TakeSurvey"
    Layout = "~/Views/Shared/_UserLayout.vbhtml"
End Code


@Using Html.BeginForm("TakeSurvey", "Question", Nothing, FormMethod.Post, New With {.id="SurveyForm"})
    

@<div class="col-sm-6 col-sm-offset-3 no-padd">
    <div class="col-sm-12 bgwhite">
        <div id="myTabContent" class="tab-content">
            @for Each question In Model
            @<div class="col-xs-12">
                <h4>@question.question<label class="pull-right"></label></h4>
                <hr />
                @If question.isNegative Then
                @<div class="form-group">
                    <label><input id='1_@question.questionId' type="radio" name=@question.questionId value="1 @question.traitId"> Strongly Agree</label><br />
                    <label><input id='2_@question.questionId' type="radio" name=@question.questionId value="2 @question.traitId"> Agree</label><br />
                    <label><input id='3_@question.questionId' type="radio" name=@question.questionId value="3 @question.traitId"> Neither Agree nor Disagree</label><br />
                    <label><input id='4_@question.questionId' type="radio" name=@question.questionId value="4  @question.traitId"> Disagree</label><br />
                    <label><input id='5_@question.questionId' type="radio" name=@question.questionId value="5  @question.traitId"> Strongly Disagree</label><br />
                </div>
                Else
                @<div class="form-group">
                     <label><input id='1_@question.questionId' type="radio" name=@question.questionId value="5 @question.traitId"> Strongly Agree</label><br />
                     <label><input id='2_@question.questionId' type="radio" name=@question.questionId value="4  @question.traitId"> Agree</label><br />
                     <label><input id='3_@question.questionId' type="radio" name=@question.questionId value="3  @question.traitId"> Neither Agree nor Disagree</label><br />
                     <label><input id='4_@question.questionId' type="radio" name=@question.questionId value="2  @question.traitId"> Disagree</label><br />
                     <label><input id='5_@question.questionId' type="radio" name=@question.questionId value="1  @question.traitId"> Strongly Disagree</label><br />
                </div>
                End If
            </div>
            Next
        </div>
        <div class="col-xs-12 bottom-20">
            <button type="submit" class="btn btn-primary pull-right" id="saveSurvey">Save</button>
        </div>
    </div>
</div>

End Using

@Section scripts
<script>
    $('#SurveyForm').submit(function (e) {

        console.log('Submitted!')

        a = e
    })
</script>
End Section