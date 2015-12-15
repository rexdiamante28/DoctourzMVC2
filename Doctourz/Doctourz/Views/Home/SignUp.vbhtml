@Code
    Layout = "../Shared/_BlankLayout.vbhtml"
End Code

<div class="col-xs-12  bggray5 full-height">
    <div class="col-sm-8 col-sm-offset-2">
        <div class="row padd-20 bgwhite">
            <img src="~/Content/Images/Website/logo_blue.png" style="width:250px;" />
            <div class="pull-right text-center top-20">
                <a class="right-10">@Html.ActionLink("About", "About", "Home")</a>
                <a class="right-10">@Html.ActionLink("Signup", "SignUp", "Home")</a>
                <a class="right-10">@Html.ActionLink("Login", "Login", "Home")</a>
            </div>
        </div>
    </div>
    <div class="col-xs-12 col-sm-8 col-sm-offset-2 top-10 ">
        <div class="row padd-20 bgwhite">
            <div class="col-md-6">
                <h3 class="bold custom-fblue">When would you like help?</h3>
                <div class="col-sm-10 col-sm-offset-1 top-20">
                    <form>
                        <div id="errorDiv">
                        </div>
                        <b class="pull-right fgray3 normal">* All fields required</b>
                        <div class="form-group">
                            <input type="text" class="form-control" id="name" placeholder="Full Name">
                        </div>
                        <div class="form-group">
                            <input type="text" class="form-control" id="username" placeholder="Username">
                        </div>
                        <b class="pull-right fgray3 normal">(minimum of 8 characters)</b><br />
                        <div class="form-group">
                            <input type="password" class="form-control" id="password1" placeholder="Password">
                        </div>
                        <div class="form-group">
                            <input type="password" class="form-control" id="password2" placeholder="Confirm Password">
                        </div>
                        <div class="form-group">
                            <label class="point"><input type="checkbox" id="agree"> I agree to <a>Terms and Conditions</a></label>
                        </div>
                        <div class="form-group">
                            <button type="submit" class="btn btn-primary btn-block">Register</button>
                        </div>
                    </form>
                </div>
            </div>
            <div class="col-md-6">
                <b class="pull-right fgray3 normal">Already have an account? <a href="">@Html.ActionLink("Click here to log in", "Login", "Home")</a></b>
                <div class="col-xs-12 top-100">
                    <h3 class="bold fgray2">Why do I have to sign up for an account?</h3>
                    <p>You get patient-to-physician matching. To get the best match possible, we need to know certain things about you. Signing up for an account allows us to know more about you.</p>

                </div>
            </div>
        </div>
    </div>
</div>

