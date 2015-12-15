@Code
    ViewData("Title") = "Home Page"
    Layout = "../Shared/_WebsiteLayout.vbhtml"
End Code



<div class="intro">
    <div class="intro-body">
        <div class="jumbotron half-opac text-center">
            <h1 style="color: #336799;"><strong>Global Healthcare<br> <span style="padding-left: 360px;color: #488DD0;">Made for YOU...</span> </strong></h1>
            <p class="lead" style="color: #336799">Let us match you with a Doctor today.</p>
            <div class="row">
                <div class="col-xs-6 col-xs-offset-3">
                    <a href="about.html" class="btn btn-lg" style="width: 150px; border: 2px solid #336799;background-color: transparent !important;color: #336799"><strong>Learn more</strong></a>
                    <a href="/userregistration" class="btn btn-lg btn-warning" style="width: 150px;"><strong>Sign up</strong></a>
                </div>
            </div>
        </div>
    </div>
</div>
<div class="col-xs-12 no-padd">
    <div class="jumbotron" style="background-color: #336799;padding-bottom: 100px">
        <div class="col-xs-12">
            <form name="search-physician">
                <div class="form-inline text-center">
                    <div class="col-xs-3">
                        <strong style="color: white;font-weight: bold;font-size: 20px">Find a Physician</strong>
                    </div>
                    <div class="col-xs-3">
                        <input type="text" name="location" placeholder="Specializing in..." class="form-control" style="margin-right: 20px" />
                    </div>
                    <div class="col-xs-3">
                        <input type="text" name="specialization" placeholder="Located in..." class="form-control" style="margin-right: 20px" />
                    </div>
                    <div class="col-xs-3">
                        <button type="submit" class="btn btn-lg" style="background-color: #488DD0;color: white;width: 150px"><strong>Search</strong></button>
                    </div> 
                </div>
            </form>
        </div>
    </div>
</div>

<div class="row step-page">
    <div class="col-xs-12 text-center">
        <h1 style="font-weight: 600; color: black;font-size: 45px">We're here with you every step of the way</h1>
        <div style="background-image: url('../../Content/Images/Website/greenbar.png');height: 200px;background-position:center;background-repeat:no-repeat !important">
            <ul class="nav nav-pills round-pills text-center" role="tablist">
                <li class="active"><a href="#1" role="tab" data-toggle="tab">1</a><span class="step-text">PHYSICIAN SEARCH</span></li>
                <li><a href="#2" role="tab" data-toggle="tab">2</a><span class="step-text">NURSE CONCIERGE</span></li>
                <li><a href="#3" role="tab" data-toggle="tab">3</a><span class="step-text">TELEMED<br>CONSULTATION</span></li>
                <li><a href="#4" role="tab" data-toggle="tab">4</a><span class="step-text">FOLLOW-UP CARE</span></li>
            </ul>
        </div>
        <div class="tab-content">
            <div role="tabpanel" class="tab-pane active" id="1"><img src="~/Content/Images/Website/123_1.png" /></div>
            <div role="tabpanel" class="tab-pane" id="2"><img src="~/Content/Images/Website/123_2.png" /></div>
            <div role="tabpanel" class="tab-pane" id="3"><img src="~/Content/Images/Website/123_3.png" /></div>
            <div role="tabpanel" class="tab-pane" id="4"><img src="~/Content/Images/Website/123_4.png" /></div>
        </div>
    </div>
</div>


<div class="col-xs-12">
    <div id="myCarousel" class="carousel slide" data-ride="carousel" data-interval="3000" data-pause="false">
        <!-- Indicators
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>
            <li data-target="#myCarousel" data-slide-to="3"></li>
        </ol>
         -->
        <!-- Wrapper for slides -->
        <div class="carousel-inner" role="listbox">
            <div class="item active">
                <img src="~/Content/Images/Website/Ad1.jpg" width="100%">
            </div>

            <div class="item">
                <img src="~/Content/Images/Website/Ad2.jpg" width="100%">
            </div>

            <div class="item">
                <img src="~/Content/Images/Website/Ad3.jpg" width="100%">
            </div>

            <div class="item">
                <img src="~/Content/Images/Website/Ad4.jpg" width="100%">
            </div>
        </div>

        <!-- Left and right controls
        <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
         -->
    </div>
</div>

<img src="~/Content/Images/Website/Section4.png" />

<div class="col-xs-12 no-padd" style="background-image: url(../../Content/Images/Website/blueBG.png);background-size: cover;background-position:center;background-repeat: no-repeat">
    <div class="mybody-content text-center" id="registration">
        <h2 class="fwhite">The vision of DOCTOURZ is to make healthcare<br />personal and accessible. We are dedicated to<br /> "making healthcare global" sign up now!</h2>
        <div class="col-xs-12 top-50" style="padding-bottom: 100px">
            <form class="form-inline" role="form">
                <div class="form-group">
                    <select class="form-control" id="type">
                        <option>I am a...</option>
                        <option>I am a patient</option>
                        <option>I am a doctor</option>
                    </select>
                </div>
                <div class="form-group">
                    <input type="email" class="form-control" placeholder="Email" id="email">
                </div>
                <button type="submit" class="btn btn-warning btn-lg">Signup</button>
            </form>
        </div>
    </div>
</div>