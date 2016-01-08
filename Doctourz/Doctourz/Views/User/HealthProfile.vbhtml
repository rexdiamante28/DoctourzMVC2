@ModelType AppUsers
@Imports Microsoft.AspNet.Identity
<script>
    $(document).ready(function () {
        loadHealthProfile();
    })
</script>

<ul class="nav nav-pills">
    <li class="dropdown pull-right">
        <a class="dropdown-toggle bggray5 pull-right" data-toggle="dropdown" href="#">
            <span class="caret"></span>
        </a>
        <ul class="dropdown-menu">
            <li><a href="#basicinfomation" data-toggle="tab">Basic Information</a></li>
            <li class="divider"></li>
            <li><a href="#conditions" data-toggle="tab">Conditions and Symptoms</a></li>
            <li class="divider"></li>
            <li><a href="#allergies" data-toggle="tab">Allergies</a></li>
            <li class="divider"></li>
            <li><a href="#medicalrecords" data-toggle="tab">Treatments</a></li>
        </ul>
    </li>
</ul>
<div id="myTabContent" class="tab-content">
    <div class="tab-pane fade active in" id="basicinfomation">
        <ul class="list-group top-20">
            <li class="list-group-item">
                <b class="_17 normal">About</b>
            </li>
            <li class="list-group-item">
                <div class="row">
                    <div class="col-xs-12">
                        <b class="normal">Name</b>
                        <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('name_edit')"></i>
                        <b class="pull-right normal bluefont"><span id="UsrName"></span></b>
                    </div>
                </div>

            </li>
            <li class="list-group-item bggray5 no-display" id="name_edit">
                What is your name?
                @Using Html.BeginForm("UpdateName", "User", FormMethod.Post, New With {.role = "form", .id = "UpdateNameForm"})
                    @Html.AntiForgeryToken()
                    @Html.ValidationSummary("", New With {.class = "text-danger"})

                    @Html.TextBoxFor(Function(model) model.firstName, New With {.class = "form-control bottom-10", .id = "fName"})
                    @Html.TextBoxFor(Function(model) model.lastName, New With {.class = "form-control bottom-10", .id = "lName"})
                    @<button class="btn" type="button" onclick="toggleElement('name_edit')">Cancel</button>
                    @<button class="btn btn-primary savename" type="submit" onclick="toggleElement('name_edit')">Save</button>
                End Using

            </li>


            <li class="list-group-item">
                <b class="normal">Gender</b>
                <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('gender_edit')"></i>
                <b class="pull-right normal bluefont"><span id="UsrGender"></span></b>
            </li>
            <li class="list-group-item no-display bggray5" id="gender_edit">
                What gender are you?<br /><br />
                @Using Html.BeginForm("UpdateGender", "User", FormMethod.Post, New With {.role = "form", .id = "UpdateGenderForm"})
                    @Html.AntiForgeryToken()
                    @Html.ValidationSummary("", New With {.class = "text-danger"})
                    @Html.HiddenFor(Function(model) model.gender, New With {.id = "genderType"})

                    @<label class="normal point"><input type="radio" name="gender" id="male" onclick="$('#genderType').val('Male')" /> Male</label>@<br />
                    @<label class="normal point"><input type="radio" name="gender" id="female" onclick="$('#genderType').val('Female')" /> Female</label>@<br />

                    @<button class="btn" type="button" onclick="toggleElement('gender_edit')">Cancel</button>
                    @<button class="btn btn-primary savegender" type="submit" onclick="toggleElement('gender_edit')">Save</button>
                End Using
            </li>


            <li class="list-group-item">
                <div class="row">
                    <div class="col-xs-12">
                        <b class="normal">Location</b>
                        <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('location_edit')"></i>
                        <b class="pull-right normal bluefont"><span id="UsrLocation"></span></b>
                    </div>
                </div>
            </li>
            <li class="list-group-item bggray5 no-display" id="location_edit">
                Where are you located?
                @Using Html.BeginForm("UpdateLocation", "User", FormMethod.Post, New With {.role = "form", .id = "UpdateLocationForm"})
                    @Html.AntiForgeryToken()
                    @Html.ValidationSummary("", New With {.class = "text-danger"})

                    @Html.TextBoxFor(Function(model) model.location, New With {.class = "form-control bottom-10", .id = "location"})

                    @<button class="btn" type="button" onclick="toggleElement('location_edit')">Cancel</button>
                    @<button class="btn btn-primary savelocation" type="submit" onclick="toggleElement('location_edit')">Save</button>
                End Using
            </li>


            <li class="list-group-item">
                <div class="row">
                    <div class="col-xs-12">
                        <b class="normal">Date of Birth</b>
                        <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('birthdate_edit')"></i>
                        <b class="pull-right normal bluefont"><span id="UsrBirthDate"></span></b>
                    </div>
                </div>
            </li>
            <li class="list-group-item bggray5 no-display" id="birthdate_edit">
                What is your birth date?
                @Using Html.BeginForm("UpdateBirthDate", "User", FormMethod.Post, New With {.role = "form", .id = "UpdateBirthForm"})
                    @Html.AntiForgeryToken()
                    @Html.ValidationSummary("", New With {.class = "text-danger"})

                    @Html.TextBoxFor(Function(model) model.birthDate, New With {.class = "form-control bottom-10", .id = "birthDate", .type = "Date"})

                    @<button class="btn" type="button" onclick="toggleElement('birthdate_edit')">Cancel</button>
                    @<button class="btn btn-primary savebirthdate" type="submit" onclick="toggleElement('birthdate_edit')">Save</button>
                End Using
            </li>


            <li class="list-group-item">
                <b class="normal">Ethnicity</b>
                <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('ethnicity_edit')"></i>
                <b class="pull-right normal bluefont"><span id="UsrEthnicity"></span></b>
            </li>
            <li class="list-group-item no-display bggray5" id="ethnicity_edit">
                What is your ethnicity?<br /><br />

                @Code
                    @Using Html.BeginForm("UpdateEthnicity", "User", Nothing, FormMethod.Post, New With {.id = "UpdateEthForm", .role = "form"})
                        @Html.AntiForgeryToken()

                        @Html.HiddenFor(Function(model) model.ethnicityId, New With {.id = "ethType"})

                    End Using


                    Dim db = New ApplicationDbContext

                    Dim ethnicities = db.Ethnicities

                    For Each i In ethnicities
                    @<label class="normal point"><input type="radio" name="ethnicity" onclick="$('#ethType').val(this.value)" id="@i.name" value="@i.ethnicityId" class="pretty-radio"> @i.name</label>@<br />
                    Next

                    @<button class="btn"  onclick="toggleElement('ethnicity_edit')">Cancel</button>
                    @<button class="btn btn-primary saveethnicity" onclick="toggleElement('ethnicity_edit')" type="submit">Save</button>
End Code

            </li>

            <li class="list-group-item">
                <b class="normal">Height</b>
                <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('height_edit')"></i>
                <b class="pull-right normal bluefont"><span id="UsrHeight"></span></b>
            </li>
            <li class="list-group-item bggray5 no-display" id="height_edit">
                <div class="row">
                    <div class="col-xs-12">
                        What is your height?
                        <div class="row">
                            <div class="col-xs-6">
                                <input type="number" id="height1" value="{{basicInfo.height}}" placeholder="meters" class="form-control bottom-10" min="1" max="8">
                            </div>
                            <div class="col-xs-6">
                                <input type="number" id="height2" value="{{basicInfo.height}}" placeholder="inches" class="form-control bottom-10" min="1" max="11">
                            </div>
                        </div>
                        <button class="btn" onclick="toggleElement('height_edit')">Cancel</button>
                        <button class="btn btn-primary saveheight">Save</button>
                    </div>
                </div>

            </li>

            <li class="list-group-item">
                <b class="normal">Weight</b>
                <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('weight_edit')"></i>
                <b class="pull-right normal bluefont"><span id="UsrWeight"></span></b>
            </li>
            <li class="list-group-item bggray5 no-display" id="weight_edit">
                <div class="row">
                    <div class="col-xs-12">
                        What is your weight (Kilogram)?
                        <div class="row">
                            <div class="col-xs-12">
                                <input type="number" id="weight" value="{{basicInfo.weight}}" placeholder="Kilogram" class="form-control bottom-10" min="1" max="200">
                            </div>
                        </div>
                        <button class="btn" onclick="toggleElement('weight_edit')">Cancel</button>
                        <button class="btn btn-primary saveweight">Save</button>
                    </div>
                </div>
            </li>


            <li class="list-group-item">
                <b class="normal">BMI</b>
                <i class="fa fa-pencil-square-o pull-right"></i>
                <b class="pull-right normal bluefont"><span id="UsrBmi"></span></b>
            </li>
        </ul>


        <ul class="list-group">
            <li class="list-group-item">
                <b class="_17 normal">Family History</b>
            </li>
            <li class="list-group-item">
                <small>
                    Conditions that caused a close relative to pass away before the age of 60:
                    <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('edit_history1')"></i>
                </small>
            </li>
            {{#each history1}}
            <li class="list-group-item">
                {{condition}}<label class="normal fgray4">({{relative}})</label>
                <i class="fa fa-remove pull-right" id={{_id}} onclick="ConfirmActionDelete(this.id,FamilyHistory)"></i>
            </li>
            {{/each}}
            <li class="list-group-item bggray5 no-display" id="edit_history1">
                <div class="row">
                    <div class="col-xs-12">
                        <div class="form-group">
                            <label class="normal">Condition or Symptom</label>
                            <input type="text" id="condition1" class="form-control">
                        </div>
                        <div class="form-group">
                            <label class="normal">Who had it?</label>
                            <select class="form-control" id="relative1">
                                <option>Mother</option>
                                <option>Father</option>
                                <option>Sister</option>
                                <option>Brother</option>
                                <option>Grandmother</option>
                                <option>Grandfather</option>
                            </select>
                        </div>
                        <div class="form-group">
                            <label class="normal">How old is he/she?</label>
                            <input type="number" id="age1" min="1" max="200" class="form-control">
                        </div>
                        <div class="form-group">
                            <button class="btn btn-primary savehistory1 pull-right">Save</button>
                        </div>
                    </div>
                </div>
            </li>

            <li class="list-group-item">
                <small>
                    Do your grandparents, parents or siblings have any major medical conditions (life-threatening or otherwise?)
                    <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('edit_history2')"></i>
                </small>
            </li>
            {{#each history2}}
            <li class="list-group-item">
                {{condition}}<label class="normal fgray4">({{relative}})</label>
                <i class="fa fa-remove pull-right" id={{_id}} onclick="ConfirmActionDelete(this.id,FamilyHistory)"></i>
            </li>
            {{/each}}
            <li class="list-group-item bggray5 no-display" id="edit_history2">
                <div class="row">
                    <div class="col-xs-12">
                        <div class="form-group">
                            <label class="normal">Condition or Symptom</label>
                            <input type="text" id="condition2" class="form-control">
                        </div>
                        <div class="form-group">
                            <label class="normal">Who had it?</label>
                            <select class="form-control" id="relative2">
                                <option>Mother</option>
                                <option>Father</option>
                                <option>Sister</option>
                                <option>Brother</option>
                                <option>Grandmother</option>
                                <option>Grandfather</option>
                            </select>
                        </div>
                        <div class="form-group">
                            <label class="normal">How old is he/she?</label>
                            <input type="number" min="1" max="200" id="age2" class="form-control">
                        </div>
                        <div class="form-group">
                            <button class="btn btn-primary savehistory2 pull-right">Save</button>
                        </div>
                    </div>
                </div>
            </li>
        </ul>


        <ul class="list-group">
            <li class="list-group-item">
                <b class="_17 normal">Lifestyle</b>
            </li>
            <li class="list-group-item">
                <div class="row">
                    <div class="col-xs-12">
                        <b class="normal">Dietary Restrictions</b>
                        <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('edit_diet')"></i>
                        <b class="pull-right normal bluefont">{{data.diet}}</b>
                    </div>
                </div>
            </li>
            <li class="list-group-item no-display" id="edit_diet">
                <div class="row">
                    <div class="col-xs-12">
                        <b class="normal">Do you have any dietary restrictions? (Choose all that apply)</b><br />
                        <div class="form-group">
                            <label class="normal point">
                                <input type="checkbox" class="pretty-radio" name="diet" value="Ovo-Vegetarian">
                                Ovo-Vegetarian<br />
                                <small>eat eggs, but not dairy</small>
                            </label><br />
                            <label class="normal point">
                                <input type="checkbox" class="pretty-radio" name="diet" value="Lacto-Vegetarian">
                                Lacto-Vegetarian<br />
                                <small>eat dairy, but not eggs</small>
                            </label><br />
                            <label class="normal point">
                                <input type="checkbox" class="pretty-radio" name="diet" value="Vegetarian">
                                Vegetarian<br />
                                <small>eat both dairy and eggs</small>
                            </label><br />
                            <label class="normal point">
                                <input type="checkbox" class="pretty-radio" name="diet" value="Vegan">
                                Vegan<br />
                                <small>No meat or animal products</small>
                            </label><br />
                            <label class="normal point">
                                <input type="checkbox" class="pretty-radio" name="diet" value="Pescatarian">
                                Pescatarian<br />
                                <small>No meat, except fish</small>
                            </label><br />
                            <label class="normal point">
                                <input type="checkbox" class="pretty-radio" name="diet" value="Gluten-free">
                                Gluten-free<br />
                                <small>No wheat,barley, or rye</small>
                            </label><br />
                            <label class="normal point">
                                <input type="checkbox" class="pretty-radio" name="diet" value="Lactose Intolerant">
                                Lactose Intolerant<br />
                                <small>Lactose-free dairy</small>
                            </label><br />
                        </div>
                        <div class="forn-group">
                            <button class="btn btn-primary savediet pull-right">Save</button>
                        </div>
                    </div>
                </div>
            </li>


            <li class="list-group-item">
                <div class="row">
                    <div class="col-xs-12">
                        <b class="normal">Alcohol</b>
                        <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('edit_alcohol')"></i>
                        <b class="pull-right normal bluefont">{{data.alcohol}}</b>
                    </div>
                </div>
            </li>
            <li class="list-group-item no-display bggray5" id="edit_alcohol">
                <div class="row">
                    <div class="col-xs-12">
                        How would you classify your consumption of alcohol?<br /><br />
                        <label class="normal point"><input type="radio" name="alcohol" value="Social Drinker" class="pretty-radio"> Social Drinker<br /> <small>(0-7 drinks/week)</small></label><br />
                        <label class="normal point"><input type="radio" name="alcohol" class="pretty-radio" value="Moderate Drinker"> Moderate Drinker<br /> <small>(8-14 drinks/week)</small></label><br />
                        <label class="normal point"><input type="radio" name="alcohol" class="pretty-radio" value="Heavy Drinker"> Heavy Drinker<br /> <small>(15+ drinks/week)</small></label><br />
                        <label class="normal point"><input type="radio" name="alcohol" class="pretty-radio" value="Not a Drinker"> Not a Drinker</label><br />

                        <button class="btn btn-primary savealcohol pull-right">Save</button>
                    </div>
                </div>
            </li>


            <li class="list-group-item">
                <b class="normal">Tobacco</b>
                <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('edit_tobacco')"></i>
                <b class="pull-right normal bluefont">{{data.tobacco}}</b>
            </li>
            <li class="list-group-item no-display bggray5" id="edit_tobacco">
                <div class="row">
                    <div class="col-xs-12">
                        Do you smoke or chew tobacco or recently quit?<br /><br />
                        <label class="normal point"><input type="radio" name="tobacco" value="Never smoke or chewed" class="pretty-radio"> Never smoke or chewed</label><br />
                        <label class="normal point"><input type="radio" name="tobacco" class="pretty-radio" value="Yes, 0-2 packs a month"> Yes, 0-2 packs a month</label><br />
                        <label class="normal point"><input type="radio" name="tobacco" class="pretty-radio" value="Yes, 0-2 packs a week"> Yes, 0-2 packs a week</label><br />
                        <label class="normal point"><input type="radio" name="tobacco" class="pretty-radio" value="Yes, 0-2 packs a day"> Yes, 0-2 packs a day</label><br />
                        <label class="normal point"><input type="radio" name="tobacco" class="pretty-radio" value="Yes, more than 2 packs a day"> Yes, more than 2 packs a day</label><br />
                        <label class="normal point"><input type="radio" name="tobacco" class="pretty-radio" value="Yes, chewing tobacco"> Yes, chewing tobacco</label><br />

                        <button class="btn btn-primary savetobacco pull-right">Save</button>
                    </div>
                </div>
            </li>


            <li class="list-group-item">
                <b class="normal">Sexually Active</b>
                <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('edit_sex')"></i>
                <b class="pull-right normal bluefont">{{data.sexual}}</b>
            </li>
            <li class="list-group-item no-display bggray5" id="edit_sex">
                <div class="row">
                    <div class="col-xs-12">
                        Have you ever had sexual intercourse with men, women, or both?<br /><br />
                        <label class="normal point"><input type="radio" name="sex" value="Not Sexually active" class="pretty-radio"> Not Sexually active</label><br />
                        <label class="normal point"><input type="radio" name="sex" class="pretty-radio" value="Men"> Men</label><br />
                        <label class="normal point"><input type="radio" name="sex" class="pretty-radio" value="Women"> Women</label><br />
                        <label class="normal point"><input type="radio" name="sex" class="pretty-radio" value="Both"> Both</label><br />

                        <button class="btn btn-primary savesex pull-right">Save</button>
                    </div>
                </div>
            </li>


            <li class="list-group-item">
                <b class="normal">Recreational Drugs</b>
                <i class="fa fa-pencil-square-o pull-right"></i>
                <b class="pull-right normal bluefont">--</b>
            </li>
        </ul>

        <ul class="list-group">
            <li class="list-group-item">
                <b class="_17 normal">Contact Information</b>
            </li>
            <li class="list-group-item">
                <b class="normal">Mobile Number</b>
                <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('edit_mobile')"></i>
                <b class="pull-right normal bluefont">{{data.mobile}}</b>
            </li>
            <li class="list-group-item no-display bggray5" id="edit_mobile">
                <div class="row">
                    <div class="col-xs-12">
                        What is your mobile number?<br /><br />
                        <input type="text" class="form-control" id="mobile" value={{data.mobile}}>
                        <button class="btn btn-primary pull-right top-20 savemobile">Save</button>
                    </div>
                </div>
            </li>

            <li class="list-group-item">
                <b class="normal">Mailing Address</b>
                <i class="fa fa-pencil-square-o pull-right"></i>
                <b class="pull-right normal bluefont">--</b>
            </li>
        </ul>

        <ul class="list-group">
            <li class="list-group-item">
                <b class="_17 normal">Insurance</b>
            </li>
            <li class="list-group-item">
                <b class="normal">How are you insured?</b>
                <i class="fa fa-pencil-square-o pull-right"></i>
                <b class="pull-right normal bluefont">--</b>
            </li>
        </ul>

    </div>
    <div class="tab-pane fade" id="conditions">
        <ul class="list-group top-20">
            <li class="list-group-item">
                <b class="_17 normal">Medical Conditions</b>
            </li>
            {{#each record}}
            <li class="list-group-item">
                <div class="row">
                    <div class="col-xs-12">
                        <b class="normal" title={{description}}>{{condition}}<br /><small>({{medications}})</small></b>
                        <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('name_edit')"></i>
                        <i class="fa fa-remove pull-right delete" id={{_id}}></i>
                    </div>
                </div>
            </li>
            {{/each}}
        </ul>

        <div class="col-xs-12 no-padd">
            <div class="col-sm-12 no-padd">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        New Medical Condition
                        <i class="fa fa-plus pull-right" onclick="toggleElement('add_condition')"></i>
                    </div>
                    <div class="panel-body no-display" id="add_condition">
                        <form>
                            <div id="errorDiv"></div>
                            <input type="text" class="hidden" id="patientId" value={{sessionId}}>
                            <div class="form-group">
                                <label>Medical Condition</label>
                                <input type="text" class="form-control " id="condition">
                            </div>
                            <div class="form-group">
                                <label>Short Description</label>
                                <textarea class="form-control " id="description"></textarea>
                            </div>
                            <div class="form-group">
                                <label>Medications</label><small style="color:red;">list all medications for this condition sepatated by comma (,)</small>
                                <textarea class="form-control " id="medications"></textarea>
                            </div>
                            <a class="btn btn-default" href="edit">Back</a>
                            <button type="submit" class="btn btn-primary">Save</button>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="tab-pane fade" id="allergies">
        <ul class="list-group top-20">
            <li class="list-group-item">
                <b class="_17 normal">Medical Conditions</b>
            </li>
            {{#each record}}
            <li class="list-group-item">
                <div class="row">
                    <div class="col-xs-12">
                        <b class="normal">{{particular}}<br /><small>({{type}})</small></b>
                        <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('name_edit')"></i>
                        <i class="fa fa-remove pull-right delete" id={{_id}}></i>
                    </div>
                </div>
            </li>
            {{/each}}
        </ul>

        <div class="col-xs-12 no-padd">
            <div class="col-sm-12 no-padd">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        New Allergy details
                        <i class="fa fa-plus pull-right" onclick="toggleElement('add_allergy')"></i>
                    </div>
                    <div class="panel-body no-display" id="add_allergy">
                        <form>
                            <div id="errorDiv"></div>
                            <input type="text" class="hidden" id="patientId" value={{sessionId}}>
                            <div class="form-group">
                                <label>Type</label>
                                <select type="text" class="form-control " id="type">
                                    <option value="food">Food</option>
                                    <option value="drugs">Drugs</option>
                                </select>
                            </div>
                            <div class="form-group">
                                <label>Particular</label>
                                <input class="form-control " id="particular" type="text">
                            </div>
                            <a class="btn btn-default" href="edit">Back</a>
                            <button type="submit" class="btn btn-primary">Save</button>
                        </form>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <div class="tab-pane fade" id="medicalrecords">
        <ul class="list-group top-20">
            <li class="list-group-item">
                <b class="_17 normal">Medical Records</b>
            </li>
            {{#each record}}
            <li class="list-group-item">
                <div class="row">
                    <div class="col-xs-12">
                        <b class="normal" title={{description}}>{{reason}}<br /><small>({{hospital}})<br />[{{formatDate datefrom  }} - {{formatDate dateTo}}]</small></b>
                        <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('name_edit')"></i>
                        <i class="fa fa-remove pull-right delete" id={{_id}}></i>
                    </div>
                </div>
            </li>
            {{/each}}
        </ul>

        <div class="col-xs-12 no-padd">
            <div class="col-sm-12 no-padd">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Add New Medical Record
                        <i class="fa fa-plus pull-right" onclick="toggleElement('add_record')"></i>
                    </div>
                    <div class="panel-body no-display" id="add_record">
                        <form>
                            <div id="errorDiv"></div>
                            <input type="text" class="hidden" id="patientId" value={{sessionId}}>
                            <div class="form-group">
                                <label>From</label>
                                <input type="date" class="form-control " id="dateFrom">
                            </div>
                            <div class="form-group">
                                <label>To</label>
                                <input type="date" class="form-control " id="dateTo">
                            </div>
                            <div class="form-group">
                                <label>Reason/Description</label>
                                <textarea class="form-control " id="reason"></textarea>
                            </div>
                            <div class="form-group">
                                <label>Hospital</label>
                                <input type="text" class="form-control " id="hostipal">
                            </div>
                            <div class="form-group">
                                <a class="btn btn-default" href="edit">Back</a>
                                <button class="btn btn-primary pull-right" type="submit">Save</button>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script>

    $("#UpdateNameForm").submit(function (e) {
        e.preventDefault();

        if ($("#fName").val().trim() == '' ||
            $("#lName").val().trim() == '') {

            alert('Fields Cannot be empty');
            return false
        }

        var name = {
            firstName: $("#fName").val().trim(),
            lastName: $("#lName").val().trim()
        }

        $.ajax({
            url: '/User/UpdateName',
            type: 'POST',
            data: name,
            DataType: 'json',
            success: function (data) {
                loadHealthProfile();
            }
        });
    })

    $("#UpdateGenderForm").submit(function (e) {
        e.preventDefault();

        var user = {
            gender: $("#genderType").val().trim()
        }

        $.ajax({
            url: '/User/UpdateGender',
            type: 'POST',
            data: user,
            DataType: 'json',
            success: function (data) {
                loadHealthProfile();
            }
        });
    })

    $("#UpdateBirthForm").submit(function (e) {
        e.preventDefault();

        var user = {
            birthDate: $("#birthDate").val().trim()
        }

        $.ajax({
            url: '/User/UpdateBirthDate',
            type: 'POST',
            data: user,
            DataType: 'json',
            success: function (data) {
                loadHealthProfile();
            }
        });
    })

    $("#UpdateLocationForm").submit(function (e) {
        e.preventDefault();

        var user = {
            location: $("#location").val().trim()
        }

        $.ajax({
            url: '/User/UpdateLocation',
            type: 'POST',
            data: user,
            DataType: 'json',
            success: function (data) {
                loadHealthProfile();
            }
        });
    })

    $("#UpdateEthForm").submit(function (e) {
        e.preventDefault();

        var user = {
            ethnicity: $("#ethType").val().trim()
        }

        $.ajax({
            url: '/User/UpdateEthnicity',
            type: 'POST',
            data: user,
            DataType: 'json',
            success: function (data) {
                loadHealthProfile();
            }
        });
    })
</script>
