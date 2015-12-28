@Code
    Layout = "~/Views/Shared/_UserLayout.vbhtml"
End Code


<div class="col-xs-12 col-md-6 col-sm-offset-3">
    <div>
        <input type="text" class="form-control" placeholder="Search answers, topics, doctors">
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
                    <input type="text" class="form-control" placeholder="Enter Location" />
                </li>
            </div>


            <li class="list-group-item" onclick="ToggleElement('doctor-specialty')">
                <text class="custom-fblue">Specialty</text>
            </li>
            <div class="row toggle-hide bggray5" id="doctor-specialty">
                <li class="list-group-item ">
                    <label class="normal"><input type="checkbox" name="availability" /> Specialty 1</label>
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="checkbox" name="availability" /> Specialty 2</label>
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="checkbox" name="availability" /> Specialty 3</label>
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="checkbox" name="availability" /> Specialty 4</label>
                </li>
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
                <li class="list-group-item ">
                    <label class="normal"><input type="radio" name="availability" /> Male</label><br />
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="radio" name="availability" /> Female</label><br />
                </li>
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
                <li class="list-group-item ">
                    <label class="normal"><input type="checkbox" name="availability" /> MD</label>
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="checkbox" name="availability" /> MDCM</label>
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="checkbox" name="availability" /> MBBS</label>
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="checkbox" name="availability" /> MBChB</label>
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="checkbox" name="availability" /> DDS</label>
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="checkbox" name="availability" /> DMD</label>
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="checkbox" name="availability" /> DO</label>
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="checkbox" name="availability" /> DPM</label>
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="checkbox" name="availability" /> EdD</label>
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="checkbox" name="availability" /> PhD</label>
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="checkbox" name="availability" /> PharmD</label>
                </li>
                <li class="list-group-item ">
                    <label class="normal"><input type="checkbox" name="availability" /> PsyD</label>
                </li>
            </div>

        </ul>
    </div>

    <div class="col-sm-8 no-padd top-20" style="padding-left:20px;">
        <ul class="list-group point" id="patient-initial-info">
            <li class="list-group-item">
                <div class="row">
                    <div class="col-xs-12">
                        <div class="col-xs-2 no-padd">
                            <img src="~/Content/Images/Website/dummy.jpg" class="col-xs-12 img-circle no-padd"/>
                        </div>
                        <div class="col-xs-10">
                            <text class="bold custom-fblue">Doctor's name</text><br/>
                            <text class="fgray4">Specialization</text><br/>
                            <text class="fgray4">Star ratings</text><br/>
                            <text class="fgray4">Location</text>
                        </div>
                    </div>
                </div>
            </li>
            <li class="list-group-item">
                <div class="row">
                    <div class="col-xs-12">
                        <div class="col-xs-2 no-padd">
                            <img src="~/Content/Images/Website/dummy.jpg" class="col-xs-12 img-circle no-padd" />
                        </div>
                        <div class="col-xs-10">
                            <text class="bold custom-fblue">Doctor's name</text><br />
                            <text class="fgray4">Specialization</text><br />
                            <text class="fgray4">Star ratings</text><br />
                            <text class="fgray4">Location</text>
                        </div>
                    </div>
                </div>
            </li>
            <li class="list-group-item">
                <div class="row">
                    <div class="col-xs-12">
                        <div class="col-xs-2 no-padd">
                            <img src="~/Content/Images/Website/dummy.jpg" class="col-xs-12 img-circle no-padd" />
                        </div>
                        <div class="col-xs-10">
                            <text class="bold custom-fblue">Doctor's name</text><br />
                            <text class="fgray4">Specialization</text><br />
                            <text class="fgray4">Star ratings</text><br />
                            <text class="fgray4">Location</text>
                        </div>
                    </div>
                </div>
            </li>
            <li class="list-group-item">
                <div class="row">
                    <div class="col-xs-12">
                        <div class="col-xs-2 no-padd">
                            <img src="~/Content/Images/Website/dummy.jpg" class="col-xs-12 img-circle no-padd" />
                        </div>
                        <div class="col-xs-10">
                            <text class="bold custom-fblue">Doctor's name</text><br />
                            <text class="fgray4">Specialization</text><br />
                            <text class="fgray4">Star ratings</text><br />
                            <text class="fgray4">Location</text>
                        </div>
                    </div>
                </div>
            </li>
            <li class="list-group-item">
                <div class="row">
                    <div class="col-xs-12">
                        <div class="col-xs-2 no-padd">
                            <img src="~/Content/Images/Website/dummy.jpg" class="col-xs-12 img-circle no-padd" />
                        </div>
                        <div class="col-xs-10">
                            <text class="bold custom-fblue">Doctor's name</text><br />
                            <text class="fgray4">Specialization</text><br />
                            <text class="fgray4">Star ratings</text><br />
                            <text class="fgray4">Location</text>
                        </div>
                    </div>
                </div>
            </li>
        </ul>
    </div>
</div>