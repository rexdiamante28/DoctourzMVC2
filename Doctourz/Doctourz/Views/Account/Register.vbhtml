﻿@Modeltype RegisterViewModel
@Code
    Layout = "../Shared/_BlankLayout.vbhtml"
End Code

<div class="col-xs-12  bggray5 full-height">
    <div class="col-sm-8 col-sm-offset-2">
        <div class="row padd-20 bgwhite">
            <img src="~/Content/Images/Website/logo_blue.png" style="width:250px;" />
            <div class="pull-right text-center top-20">
                <a class="right-10">@Html.ActionLink("About", "About", "Home")</a>
                <a class="right-10">@Html.ActionLink("Signup", "Register", "Account")</a>
                <a class="right-10">@Html.ActionLink("Login", "Login", "Account")</a>
            </div>
        </div>
    </div>
    <div class="col-xs-12 col-sm-8 col-sm-offset-2 top-10 ">
        <div class="row padd-20 bgwhite">
            <div class="col-md-6">
                <h3 class="bold custom-fblue">When would you like help?</h3>
                <div class="col-sm-10 col-sm-offset-1 top-20">
                    @Using Html.BeginForm("Register", "Account", FormMethod.Post)
                        @Html.AntiForgeryToken()
                        @Html.ValidationSummary("", New With {.class = "text-danger"})
                        @<div id="errorDiv">
                        </div>
                        @<b class="pull-right fgray3 normal">* All fields required</b>
                        @<div class="form-group">
                            @Html.TextBoxFor(Function(model) model.firstName, New With {.class = "form-control", .placeholder = "First Name"})
                        </div>
                        @<div class="form-group">
                            @Html.TextBoxFor(Function(model) model.lastName, New With {.class = "form-control", .placeholder = "Last Name"})
                        </div>
                        @<div class="form-group">
                            @Html.TextBoxFor(Function(model) model.Email, New With {.class = "form-control", .placeholder = "Email"})
                        </div>
                        @<div class="form-group">
                            @Html.TextBoxFor(Function(model) model.userName, New With {.class = "form-control", .placeholder = "Username"})
                        </div>
                        @<b class="pull-right fgray3 normal">(minimum of 8 characters)</b>
                        @<div class="form-group">
                            @Html.PasswordFor(Function(model) model.Password, New With {.class = "form-control", .placeholder = "Password"})
                        </div>
                        @<div class="form-group">
                            @Html.PasswordFor(Function(model) model.ConfirmPassword, New With {.class = "form-control", .placeholder = "Confirm Password"})
                        </div>
                        @<div class="form-group">
                            As a Patient:<input type="radio" name="Role" value="Patient" checked="checked" />
                        </div>
                        @<div class="form-group">
                            As a Doctor :<input type="radio" name="Role" value="Doctor" />
                        </div>
                        @<div class="form-group">
                            <label class="point"><input type="checkbox" id="agree" name="terms"> I agree to <a>Terms and Conditions</a></label>
                        </div>
                        @<div class="form-group">
                            <button type="submit" class="btn btn-primary btn-block">Register</button>
                        </div>
                    End Using
                </div>
            </div>
            <div class="col-md-6">
                <b class="pull-right fgray3 normal">Already have an account? <a href="">@Html.ActionLink("Click here to log in", "Login", "Account")</a></b>
                <div class="col-xs-12 top-100">
                    <h3 class="bold fgray2">Why do I have to sign up for an account?</h3>
                    <p>You get patient-to-physician matching. To get the best match possible, we need to know certain things about you. Signing up for an account allows us to know more about you.</p>

                </div>
            </div>
        </div>
    </div>
</div>


@section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
