@*<div class="col-xs-12 padd-10 top-10 bggray5" >
        <label>12:00 pm</label>
        <p>Notes details here</p>
    </div>*@
<script></script>

<div id="noteBox" class="padd-10">

</div>
<div class="input-group">
    <textarea type="text" id="noteMessage" style="max-height:53px;" class="form-control" placeholder="Type your note..."></textarea>

    <span class="input-group-btn">
        <button class="btn btn-primary" id="noteSendButton" type="button" style="height:53px;">Send</button>
    </span>
</div>


<script src="~/Scripts/jquery-2.1.4.min.js"></script>
<script src="~/Scripts/moment.min.js"></script>
<script>
    $('#noteMessage').keyup(function (event) {
        if (event.keyCode == 13) {
            var content = this.value;
            var caret = getCaret(this);
            if (event.shiftKey) {
                this.value = content.substring(0, caret - 1) + "\n" + content.substring(caret, content.length);
                event.stopPropagation();
            } else {
                this.value = content.substring(0, caret - 1) + content.substring(caret, content.length);
                $('#noteSendButton').click();

            }
        }
    });

    $("#noteSendButton").click(function (e) {

        var note = {
            message: $('#noteMessage').val(),
            dateSent: new Date()
        }

        $.ajax({
            url: '/User/addNewNote',
            type: 'POST',
            data: note,
            DataType: 'json',
            success: function (data) {
                console.log("Note Added!")
                $("#noteBox").append(
                   '<div class="col-xs-12 padd-10 top-10 bggray5">' +
                      '<label>' + data.user + ' - ' + moment(note.dateSent).calendar() + '</label>' +
                      '<p>' + note.message + '</p>' +
                   '</div>'
                   )
            }
        });

       

        $('#noteMessage').val('').focus();
    });

    $(document).ready(function () {
        $.ajax({
            url: '/User/getNotes',
            type: 'POST',
            DataType: 'json',
            success: function (data) {
                //console.log(data.notes)
                var notes = data.notes;
                
                a = notes
                for (i = 0; i < notes.length; i++) {
                    $("#noteBox").append(
                   '<div class="col-xs-12 padd-10 top-10 bggray5">' +
                      '<label>' + notes[i].ownerName + ' - ' + moment(notes[i].dateSent).calendar() + '</label>' +
                      '<p>' + notes[i].message + '</p>' +
                   '</div>'
                   )
                }
            }
        });
    })
</script>