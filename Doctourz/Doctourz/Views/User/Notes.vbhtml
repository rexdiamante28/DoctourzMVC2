@ModelType Notes
<div class="col-xs-12 padd-10 top-10 bggray5" >
    <label>12:00 pm</label>
    <p>Notes details here</p>
</div>
<div class="col-xs-12 padd-10  top-10 bggray5" >
    <label>12:00 pm</label>
    <p>Notes details here</p>
</div>
<div class="col-xs-12 padd-10 top-10 bggray5" >
    <label>12:00 pm</label>
    <p>Notes details here</p>
</div>
<div class="col-xs-12 padd-10 top-10 bggray5" >
    <label>12:00 pm</label>
    <p>Notes details here</p>
</div>

@Using Html.BeginForm("newNote", "User", FormMethod.Post, New With {.role = "form", .id = "newNoteForm"})
    @Html.AntiForgeryToken()
    @Html.ValidationSummary("", New With {.class = "text-danger"})
    
    @<div id="noteBox" class="padd-10" style="min-height:60vh;">

    </div>
    @<div id="notes-box" class="list-group-item">
        <div class="input-group">
            @Html.TextAreaFor(Function(model) model.message , New With {.placeholder="Type your note...", .id="noteMessage", .class="form-control"})
            @*<textarea type="text" id="noteMessage" style="max-height:53px;" class="form-control" placeholder="Type your note..."></textarea>*@
            <span class="input-group-btn">
                <button class="btn btn-primary" id="noteSendButton" type="submit" style="height:53px;">Send</button>
            </span>
        </div>
    </div>
End Using

 <script>
     $("#newNoteForm").submit(function (e) {
         e.preventDefault();

         var note = {
             message: $('# noteMessage').val()
         }

         $.ajax({
             url: '/User/addNewNote',
             type: 'POST',
             data: hs,
             DataType: 'json',
             success: function () {
                 console.log("Note Added!")
             }
         })
     });
 </script>
