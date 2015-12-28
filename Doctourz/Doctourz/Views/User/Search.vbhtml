@Code
    Layout = "~/Views/Shared/_UserLayout.vbhtml"
End Code

<div class="col-xs-12 col-md-6 col-sm-offset-3">
    <div>
        <input id="SearchText" type="text" class="form-control" placeholder="Search answers, topics, doctors">
        @*<ul>
            @For Each item In ViewBag.Users
                @<li>
                        @item.Name
                </li>
            Next
        </ul>*@
    </div>
    <div class="top-30 bgwhite no-padd col-xs-12 radius-5">
        <div class="col-xs-6">
            <h4 class="fgray3  top-20"><i class="fa fa-stethoscope" style="font-size:30px;"></i> Conditions</h4>
        </div>
        <div class="col-xs-6 no-padd">
            <img src="~/Content/Images/User/search/searchimg1.png" class="col-xs-12 no-padd" />
        </div>
    </div>

    <div class="top-10 bgwhite no-padd col-xs-12 radius-5">
        <div class="col-xs-6">
            <h4 class="fgray3  top-20"><i class="fa fa-list-ol" style="font-size:30px;"></i> Symptoms</h4>
        </div>
        <div class="col-xs-6 no-padd">
            <img src="~/Content/Images/User/search/searchimg2.png" class="col-xs-12 no-padd" />
        </div>
    </div>

    <div class="top-10 bgwhite no-padd col-xs-12 radius-5">
        <div class="col-xs-6">
            <h4 class="fgray3  top-20"><i class="fa fa-user-md" style="font-size:30px;"></i> Doctors</h4>
        </div>
        <div class="col-xs-6 no-padd">
            <img src="~/Content/Images/User/search/searchimg3.png" class="col-xs-12 no-padd" />
        </div>
    </div>

    <div class="top-10 bgwhite no-padd col-xs-12 radius-5">
        <div class="col-xs-6">
            <h4 class="fgray3  top-20"><i class="fa fa-medkit" style="font-size:30px;"></i> Medications</h4>
        </div>
        <div class="col-xs-6 no-padd">
            <img src="~/Content/Images/User/search/searchimg4.png" class="col-xs-12 no-padd" />
        </div>
    </div>

    <div class="top-10 bgwhite no-padd col-xs-12 radius-5">
        <div class="col-xs-6">
            <h4 class="fgray3  top-20"><i class="fa fa-rotate-right" style="font-size:30px;"></i> Procedures</h4>
        </div>
        <div class="col-xs-6 no-padd">
            <img src="~/Content/Images/User/search/searchimg5.png" class="col-xs-12 no-padd" />
        </div>
    </div>

    <div class="top-10 bgwhite no-padd col-xs-12 radius-5">
        <div class="col-xs-6">
            <h4 class="fgray3  top-20"><i class="fa fa-mobile" style="font-size:30px;"></i> Health Apps</h4>
        </div>
        <div class="col-xs-6 no-padd">
            <img src="~/Content/Images/User/search/searchimg6.png" class="col-xs-12 no-padd" />
        </div>
    </div>


</div>

<script>
    document.getElementById('topbar3').setAttribute("class","bggray5");
</script>
@Section scripts
    <script>
        $('#SearchText').keypress(function (e) {
            var code = (e.keyCode ? e.keyCode : e.which);
            if (code == 13) {
                search()
            }
        });


        function search() {
            var client = document.getElementById('SearchText').value;
            var textbox = document.getElementById('SearchText');
            var edittext = ", is not available!";
            var result = client + edittext;

            if (textbox.value == 'Search...') {
                alert('Please enter a Client Name to search for ');
                textbox.focus();
            }
            else {
                alert(result);
            };
        }
    </script>
End Section