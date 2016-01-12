@Code
    Layout = "~/Views/Shared/_UserLayout.vbhtml"
    Dim db As New ApplicationDbContext
    Dim spCategory = db.SpecializationCategory
    Dim degrees = db.Degree
End Code


<div class="col-xs-12 col-md-6 col-sm-offset-3">
    <div>
        <input id="SearchText" type="text" class="form-control" placeholder="Search answers, topics, doctors" value=@ViewBag.Keyword>
    </div>

    <div class="col-sm-4 no-padd top-20">
        <ul class="list-group point" id="patient-initial-info">
            <li class="list-group-item">
                <text class="bold">Filter Doctors</text>
            </li>
            <li class="list-group-item" onclick="ToggleElement('availability-option')">
                <text class="custom-fblue">Availability</text>
            </li>
            <div class="row toggle-hide bggray5" id="availability-option">
                <li class="list-group-item ">
                    <label class="normal"><input type="radio" name="availability" /> Today</label><br />
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="radio" name="availability" /> This Week</label><br />
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="radio" name="availability" /> This Month</label><br />
                </li>
            </div>

            <li class="list-group-item" onclick="ToggleElement('doctor-location')">
                <text class="custom-fblue">Near City/ Town</text>
            </li>
            <div class="row toggle-hide bggray5" id="doctor-location">
                <li class="list-group-item ">
                    <input id="FilterLocation" type="text" class="form-control" placeholder="Enter Location" value="@ViewBag.Location" />
                </li>
            </div>


            <li class="list-group-item" onclick="ToggleElement('doctor-specialty')">
                <text class="custom-fblue">Specialty</text>
            </li>
            <div class="row toggle-hide bggray5" id="doctor-specialty">
                @For Each item In spCategory
                    @<a href="#" class="specialty">
                         <li class="list-group-item ">
                             <label class="normal"><input id="category" type="checkbox" name="category" value="@item.id" /> @item.name</label>
                         </li>
                     </a>
                Next
            </div>


            <li class="list-group-item" onclick="ToggleElement('language-spoken')">
                <text class="custom-fblue">Language Spoken</text>
            </li>
            <div class="row toggle-hide bggray5" id="language-spoken">
                <li class="list-group-item ">
                    <label class="normal"><input type="checkbox" name="availability" /> Language 1</label>
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="checkbox" name="availability" /> Language 2</label>
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="checkbox" name="availability" /> Language 3</label>
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="checkbox" name="availability" /> Language 4</label>
                </li>
            </div>

            <li class="list-group-item" onclick="ToggleElement('doctor-gender')">
                <text class="custom-fblue">Gender</text>
            </li>
            <div class="row toggle-hide bggray5" id="doctor-gender">
                <a href="#" class="male">
                    <li class="list-group-item ">
                        @*<label class="normal"><input type="radio" id="male" name="gender" value="male"/> Male</label><br />*@
                        <label class="normal">@Html.RadioButton("gender", "male") Male</label><br />
                    </li>
                </a>
                <a href="#" class="female">
                    <li class="list-group-item ">
                        @*<label class="normal"><input type="radio" id="female" name="gender" value="female"/> Female</label><br />*@
                        <label class="normal">@Html.RadioButton("gender", "female") Female</label><br />
                    </li>
                </a>
            </div>

            <li class="list-group-item" onclick="ToggleElement('doctor-score')">
                <text class="custom-fblue">DocScore</text>
            </li>
            <div class="row toggle-hide bggray5" id="doctor-score">
                <li class="list-group-item ">
                    <label class="normal"><input type="radio" name="availability" /> 1 star or higher</label><br />
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="radio" name="availability" /> 2 star or higher</label><br />
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="radio" name="availability" /> 3 star or higher</label><br />
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="radio" name="availability" /> 4 star or higher</label><br />
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="radio" name="availability" /> 5 star</label><br />
                </li>
            </div>
            
            <li class="list-group-item" onclick="ToggleElement('doctor-experience')">
                <text class="custom-fblue">Years in practice</text>
            </li>
            <div class="row toggle-hide bggray5" id="doctor-experience">
                <li class="list-group-item ">
                    <label class="normal"><input type="radio" name="availability" /> 5+ years</label><br />
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="radio" name="availability" /> 10+ years</label><br />
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="radio" name="availability" /> 15+ years</label><br />
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="radio" name="availability" /> 25+ years</label><br />
                </li>
            </div>


            <li class="list-group-item" onclick="ToggleElement('doctor-degree')">
                <text class="custom-fblue">Degrees</text>
            </li>
            <div class="row toggle-hide bggray5" id="doctor-degree">
                @For Each item In degrees
                    @<a href="#" class="degree">
                        <li class="list-group-item ">
                            <label class="normal"><input type="checkbox" name="degree" value="@item.id" /> @item.name</label>
                        </li>
                    </a>
                Next
                
                @*<a href="#" class="degree">
                    <li class="list-group-item ">
                        <label class="normal"><input type="checkbox" name="degree" value="MDCM" /> MDCM</label>
                    </li>
                </a>
                <a href="#" class="degree">
                    <li class="list-group-item ">
                        <label class="normal"><input type="checkbox" name="degree" value="MBBS" /> MBBS</label>
                    </li>
                </a>
                <a href="#" class="degree">
                    <li class="list-group-item ">
                        <label class="normal"><input type="checkbox" name="degree" value="MBChB" /> MBChB</label>
                    </li>
                </a>
                <a href="#" class="degree">
                    <li class="list-group-item ">
                        <label class="normal"><input type="checkbox" name="degree" value="DDS" /> DDS</label>
                    </li>
                </a>
                <a href="#" class="degree">
                    <li class="list-group-item ">
                        <label class="normal"><input type="checkbox" name="degree" value="DMD" /> DMD</label>
                    </li>
                </a>
                <a href="#" class="degree">
                    <li class="list-group-item ">
                        <label class="normal"><input type="checkbox" name="degree" value="DO" /> DO</label>
                    </li>
                </a>
                <a href="#" class="degree">
                    <li class="list-group-item ">
                        <label class="normal"><input type="checkbox" name="degree" value="DPM" /> DPM</label>
                    </li>
                </a>
                <a href="#" class="degree">
                    <li class="list-group-item ">
                        <label class="normal"><input type="checkbox" name="degree" value="EdD" /> EdD</label>
                    </li>
                </a>
                <a href="#" class="degree">
                    <li class="list-group-item ">
                        <label class="normal"><input type="checkbox" name="degree" value="PhD" /> PhD</label>
                    </li>
                </a>
                <a href="#" class="degree">
                    <li class="list-group-item ">
                        <label class="normal"><input type="checkbox" name="degree" value="PharmD" /> PharmD</label>
                    </li>
                </a>
                <a href="#" class="degree">
                    <li class="list-group-item ">
                        <label class="normal"><input type="checkbox" name="degree" value="PsyD" /> PsyD</label>
                    </li>
                </a>*@
            </div>
        </ul>
    </div>

    <div class="col-sm-8 no-padd top-20" style="padding-left:20px;">
        <ul class="list-group point" id="patient-initial-info">
            @For Each doc In ViewBag.Doctors

                    @<li class="list-group-item">
                        <div class="row">
                            <div class="col-xs-12">
                                <div class="col-xs-2 no-padd">
                                    <img src="~/Content/Images/Website/dummy.jpg" class="col-xs-12 img-circle no-padd" />
                                </div>
                                <div class="col-xs-10">
                                    <text class="bold custom-fblue">@doc.docName</text><br />
                                    <text class="fgray4">@doc.docSpecialization</text><br />
                                    <text class="fgray4">Star ratings</text><br />
                                    <text class="fgray4">@doc.docLocation</text><br />
                                </div>
                            </div>
                        </div>
                    </li>
            Next
        </ul>
    </div>
</div>

@Section scripts
    <script>
        //SEARCH DOCTOR
        $('#SearchText').keypress(function (e) {
            var code = (e.keyCode ? e.keyCode : e.which);
            if (code == 13) {
                search()
            }
        });

        function search() {
            //KEYWORD
            var keyword = document.getElementById('SearchText');

            //GENDER
            var gender = $('input[name=gender]:checked').val();
            if (gender == undefined) {
                gender = ""
            }

            //LOCATION
            var location = document.getElementById('FilterLocation').value;

            //SPECIALTY
            var specialty = [];
            $.each($("input[name='category']:checked"), function () {
                specialty.push($(this).val());
            });

            //DEGREE
            var degree = [];
            $.each($("input[name='degree']:checked"), function () {
                degree.push($(this).val());
            });

            var url = "/User/SearchDoctor?keyword=" + keyword.value + "&location=" + location + "&specialty=" + specialty + "&gender=" + gender + "&degree=" + degree;
            window.location.href = url;
        }

        //FILTER DOCTOR BY GENDER -- MALE
        $(".male").click(function (event) {
            search()
            //var type = "gender";
            //var filter = "male";
            //var keyword = document.getElementById('SearchText');
            //var url = "/User/FilterDoctor?keyword=" + keyword.value + "&type=" + type + "&filter=" + filter;
            //window.location.href = url;
        })

        //FILTER DOCTOR BY GENDER -- FEMALE 
        $(".female").click(function (event) {
            //var type = "gender";
            //var filter = "female";
            //var keyword = document.getElementById('SearchText');
            //var url = "/User/FilterDoctor?keyword=" + keyword.value + "&type=" + type + "&filter=" + filter;
            //window.location.href = url;
            search()
        })

        //FILTER DOCTOR BY LOCATION
        $('#FilterLocation').keypress(function (e) {
            var code = (e.keyCode ? e.keyCode : e.which);
            if (code == 13) {
                //filter()
                search()
            }
        });

        //function filter() {
        //    var type = "location";
        //    var filter = document.getElementById('FilterLocation').value;
        //    var keyword = document.getElementById('SearchText');
        //    var url = "/User/FilterDoctor?keyword=" + keyword.value + "&type=" + type + "&filter=" + filter;
        //    window.location.href = url;
        //}

        //FILTER DOCTOR BY SPECIALTY
        $(".specialty").click(function (event) {
            //var type = "specialty";

            //var category = [];
            //$.each($("input[name='category']:checked"), function () {
            //    category.push($(this).val());
            //});

            //var keyword = document.getElementById('SearchText');
            //var url = "/User/FilterDoctor?keyword=" + keyword.value + "&type=" + type + "&filter=" + category;
            //window.location.href = url;
            search()
        })

        //FILTER DOCTOR BY DEGREES
        $(".degree").click(function (event) {
            //var type = "degree";

            //var degree = [];
            //$.each($("input[name='degree']:checked"), function () {
            //    degree.push($(this).val());
            //});

            //var keyword = document.getElementById('SearchText');
            //var url = "/User/FilterDoctor?keyword=" + keyword.value + "&type=" + type + "&filter=" + degree;
            //window.location.href = url;
            search()
        })
    </script>
End Section