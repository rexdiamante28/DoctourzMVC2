@Code
    ViewData("Title") = "Home Page"
    Layout = "../Shared/_WebsiteLayout.vbhtml"
End Code

<style>
    

.the-Steps h1 {
    text-align: center;
    margin-bottom: 40px;
}

.the-Steps .nav-tabs {
  border-bottom:0; 
}
.the-Steps .nav-tabs > li a,
.the-Steps .nav-tabs > li > p {
    text-align: center;
}

.the-Steps .nav-tabs > li > p {
    color: #336699;
}

.the-Steps .nav-tabs > li > a {
    color: #fff;
    border: none;
    border-radius: 50%;
    text-align: center;
    width: 80px;
    height: 80px;
    font-size: 3em;

    margin-bottom: 20px;
    margin-left: auto;
    margin-right: auto;
}

.the-Steps .nav-tabs > li > a > span {
    text-align: center;
    vertical-align: middle;

}

.the-Steps .nav-tabs > li > a,
.the-Steps .nav-tabs > li.active > a {
    background-color: #31689b;
}

.the-Steps .nav-tabs > li.active > a,
.the-Steps .nav-tabs > li.active > a:hover,
.the-Steps .nav-tabs > li.active > a:focus
.the-Steps .nav-tabs > li > a:hover,
.the-Steps .nav-tabs > li > a:focus {
    background-color: #f7941d;
    color: #fff;
}

.the-Steps .bar {
    border-top : 20px solid #00ff00;
    position: relative;
    z-index: 1;
    top: 50px;
    margin-right: auto;
    margin-left: auto;
    width: 80%;
}

.the-Steps ul.nav {
    position: relative;
    z-index: 9;  
}

.the-Steps .tab-content {
    border-top: none;
}

.the-Steps .tab-content p {
    padding-top: 100px;
    padding-left:100px;
}

.the-Steps .tab-content .tabpanel>img {
    text-align: center;
}

.the-Steps-mobile-view img {
    width: 100%
}
.the-Steps-mobile-view h4 {
    color: #7d98b8;
}

#worldclass-Experience {
  background-image: url('../../Content/Images/Website/New/dw-bg.png'); 
  background-repeat: no-repeat;
  background-position-y:bottom;
}
#worldclass-Experience img.we-img {
  width: 100%;
}

#worldclass-Experience p {
  text-transform: justify;
}
#worldclass-Experience  h2 {
  color: #336699;
  font-weight: bold;
}


#patient-tracking {
  margin-top: 150px
}
 

</style>

<div class="box-layout" >
    <div class="intro">
        <div class="intro-body">
            <div class="hidden-xs hidden-sm hidden-md">
                <div class="jumbotron half-opac text-center">
                    <p style="color: #336799; font-size:80px; font-weight:900; line-height:60%;">Global Healthcare</p>
                    <p style="color: #428BD8; font-size:70px; font-weight:900; text-indent:350px; line-height:60%;">Customized by YOU...</p>
                    <text style="color: #336799; font-weight: bold; font-size: 17px; line-height:400%;">Let us match you with a Doctor today.</text>
                    <div class="row">
                        <div class="col-xs-6 col-xs-offset-3">
                            <a href="#learn" class="btn btn-lg" style="width: 150px; border: 2px solid #336799;background-color: transparent !important;color: #336799"><strong>Learn more</strong></a>
                            <a href="/Account/Register" class="btn btn-lg btn-warning" style="width: 150px; background-color:#F26E23;"><strong>Sign up</strong></a>
                        </div>
                    </div>
                </div>
            </div>

            <div class="hidden-xs hidden-sm hidden-lg">
                <div class="jumbotron half-opac text-center">
                    <p style="color: #336799; font-size:75px; font-weight:900; line-height:60%;">Global Healthcare</p>
                    <p style="color: #428BD8; font-size:65px; font-weight:900; text-indent:300px; line-height:60%;">Customized by YOU...</p>
                    <text style="color: #336799; font-weight: bold; font-size: 17px; line-height:400%;">Let us match you with a Doctor today.</text>
                    <div class="row">
                        <div class="col-xs-6 col-xs-offset-3">
                            <a href="#learn" class="btn btn-lg" style="width: 150px; border: 2px solid #336799;background-color: transparent !important;color: #336799"><strong>Learn more</strong></a>
                            <a href="/Account/Register" class="btn btn-lg btn-warning" style="width: 150px; background-color:#F26E23;"><strong>Sign up</strong></a>
                        </div>
                    </div>
                </div>
            </div>

            <div class="hidden-xs hidden-lg hidden-md">
                <div class="jumbotron half-opac text-center">
                    <p style="color: #336799; font-size:70px; font-weight:900; line-height:60%;">Global Healthcare</p>
                    <p style="color: #428BD8; font-size:50px; font-weight:900; text-indent:250px; line-height:60%;">Customized by YOU...</p>
                    <text style="color: #336799; font-weight: bold; font-size: 17px; line-height:400%;">Let us match you with a Doctor today.</text>
                    <div class="row">
                        <div class="col-xs-6 col-xs-offset-3">
                            <a href="#learn" class="btn btn-lg" style="width: 150px; border: 2px solid #336799;background-color: transparent !important;color: #336799"><strong>Learn more</strong></a>
                            <a href="/Account/Register" class="btn btn-lg btn-warning" style="width: 150px; background-color:#F26E23;"><strong>Sign up</strong></a>
                        </div>
                    </div>
                </div>
            </div>

            <div class="hidden-lg hidden-sm hidden-md">
                <div class="jumbotron half-opac text-center">
                    <p style="color: #336799; font-size:60px; font-weight:900; line-height:90%;">Global Healthcare</p>
                    <p style="color: #428BD8; font-size:40px; font-weight:900; text-indent:50px; line-height:90%;">Customized by YOU...</p>
                    <text style="color: #336799; font-weight: bold; font-size: 17px; line-height:400%;">Let us match you with a Doctor today.</text>
                    <div class="row">
                        <div class="col-xs-6 col-xs-offset-3">
                            <a href="#learn" class="btn btn-lg" style="width: 150px; border: 2px solid #336799;background-color: transparent !important;color: #336799"><strong>Learn more</strong></a>
                            <a href="/Account/Register" class="btn btn-lg btn-warning" style="width: 150px; background-color:#F26E23;"><strong>Sign up</strong></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="col-xs-12 no-padd">
        <div class="hidden-xs">
            <div class="" style="background-color: #336799;padding-bottom: 60px; padding-top:15px;">
                <div class="col-xs-12 col-sm-10 col-sm-offset-1">
                    <form name="search-physician">
                        <div class=" text-center">
                            <div class="col-sm-3 padd-5 ">
                                <strong style="color: white;font-weight: bold;font-size: 20px">Find a Physician</strong>
                            </div>
                            <div class="col-sm-3  ">
                                <input type="text" name="location" placeholder="Specializing in..." class="form-control input-lg" />
                            </div>
                            <div class="col-sm-3 ">
                                <input type="text" name="specialization" placeholder="Located in..." class="form-control input-lg" />
                            </div>
                            <div class="col-sm-3 ">
                                <button type="submit" class="btn btn-lg" style="background-color: #488DD0;color: white;width: 150px"><strong>Search</strong></button>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
        <div class="hidden-md hidden-sm hidden-lg">
            <div class="" style="background-color: #336799;padding-bottom: 60px; height:auto; padding-top:15px;">
                <div class="">
                    <form name="search-physician">
                        <div class=" text-center">
                            <div class="col-sm-3 padd-5 top-20">
                                <strong style="color: white;font-weight: bold;font-size: 20px">Find a Physician</strong>
                            </div>
                            <div class="col-sm-3  top-20">
                                <input type="text" name="location" placeholder="Specializing in..." class="form-control input-lg" />
                            </div>
                            <div class="col-sm-3  top-20">
                                <input type="text" name="specialization" placeholder="Located in..." class="form-control input-lg" />
                            </div>
                            <div class="col-sm-3 top-20">
                                <button type="submit" class="btn btn-lg" style="background-color: #488DD0;color: white;width: 150px"><strong>Search</strong></button>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>

 
    <section class="the-Steps container">
    <div class="col-xs-12 top-30">

    </div>
        <h1>We're here with you every step of the way</h1>
        <div class="container hidden-xs">
            <div class="row">
                <div class=" col-sm-6 col-md-6 col-lg-6 ">
                    <div class="container">

                        <div class="bar"></div>

                        <ul class="nav nav-tabs" role="tablist">
                            <li role="presentation" class="col-sm-3 col-md-3 col-lg-3 active">
                                <a href="#physician" aria-controls="physician" role="tab" data-toggle="tab"><span>1</span></a>
                                <p>PHYSICIAN <br> SEARCH</p>
                            </li>
                            <li role="presentation" class="col-sm-3 col-md-3 col-lg-3 ">
                                <a href="#nurse" aria-controls="nurse" role="tab" data-toggle="tab">2</a>
                                <p>NURSE <br> CONCIERGE</p>
                            </li>
                            <li role="presentation" class="col-sm-3 col-md-3 col-lg-3">
                                <a href="#telemed" aria-controls="telemed" role="tab" data-toggle="tab">3</a>
                                <p>TELEMED <br> CONSULTATION</p>
                            </li>
                            <li role="presentation" class="col-sm-3 col-md-3 col-lg-3">
                                <a href="#followup" aria-controls="followup" role="tab" data-toggle="tab">4</a>
                                <p>FOLLOW-UP <br> CARE</p>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="tab-content">

                    <div role="tabpanel" class="tab-pane active" id="physician">

                        <div class="row">
                            <div class="col-sm-8 col-md-8 col-lg-8">
                                <p>
                                    DOCTOURZ Matching Algorithm (DMA) is a state-of-the-art physician search engine built with a behavioral science algorithm that delivers real-time matching solutions.
                                </p>
                            </div>
                            <div class="col-sm-4 col-md-4 col-lg-4 "><img src="~/Content/Images/Website/123_1.png" alt=""></div>

                        </div>

                    </div>
                    <div role="tabpanel" class="tab-pane" id="nurse">
                        <div class="row">
                            <div class="col-sm-8 col-md-8 col-lg-8">
                                <p>
                                    Our 24/7 medical concierge staff is able and willing to assist yout with you every query you need. Anytime, anywhere at your convinience.
                                </p>
                            </div>
                            <div class="col-sm-4 col-md-4 col-lg-4 "><img src="~/Content/Images/Website/123_2.png" alt=""></div>
                        </div>
                    </div>
                    <div role="tabpanel" class="tab-pane" id="telemed">
                        <div class="row">
                            <div class="col-sm-8 col-md-8 col-lg-8">
                                <p>
                                    Doctourz can facilitate hassle free patient-physician consults at the comfort of your own home.
                                </p>
                            </div>
                            <div class="col-sm-4 col-md-4 col-lg-4 "><img src="~/Content/Images/Website/123_3.png" alt=""></div>
                        </div>
                    </div>
                    <div role="tabpanel" class="tab-pane" id="followup">
                        <div class="row">
                            <div class="col-sm-8 col-md-8 col-lg-8">
                                <p>
                                    With the use of our wearable apps, it will allow trained medical staff to provide the best follow-up patient care.
                                </p>
                            </div>
                            <div class="col-sm-4 col-md-4 col-lg-4 "><img src="~/Content/Images/Website/123_4.png" alt=""></div>
                        </div>
                    </div>
                </div>
            </div><!--tab-content-->

        </div><!-- container hidden-xs -->

        <div class="container show-xs hidden-sm hidden-md hidden-lg">
            <div class="the-Steps-mobile-view row">

                <div class="col-xs-12">
                    <h4>PHYSICIAN SEARCH</h4>
                    <img src="~/Content/Images/Website/123_1.png" alt="">
                    <p>
                        DOCTOURZ Matching Algorithm (DMA) is a state-of-the-art physician search engine built with a behavioral science algorithm that delivers real-time matching solutions.
                    </p>
                </div>

                <div class="col-xs-12">
                    <h4>NURSE CONCIERGE</h4>
                    <img src="~/Content/Images/Website/123_2.png" alt="">
                    <p>
                        Our 24/7 medical concierge staff is able and willing to assist yout with you every query you need. Anytime, anywhere at your convinience.
                    </p>
                </div>

                <div class="col-xs-12">
                    <h4>TELEMED CONSULTATION</h4>
                    <img src="~/Content/Images/Website/123_3.png" alt="">
                    <p>
                        Doctourz can facilitate hassle free patient-physician consults at the comfort of your own home.
                    </p>
                </div>

                <div class="col-xs-12">
                    <h4>FOLLOW-UP CARE</h4>
                    <img src="~/Content/Images/Website/123_4.png" alt="">
                    <p>
                        With the use of our wearable apps, it will allow trained medical staff to provide the best follow-up patient care.
                    </p>
                </div>

            </div>
        </div><!-- container show-xs hidden-sm hidden-md hidden-lg -->
    </section> <!--the-Steps Mobile Device -->



    <div class="col-xs-12 no-padd">
       @*<div id="myCarousel" class="carousel slide" data-ride="carousel" data-interval="3000" data-pause="false">
            <!-- Indicators
            <ol class="carousel-indicators">
                <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                <li data-target="#myCarousel" data-slide-to="1"></li>
                <li data-target="#myCarousel" data-slide-to="2"></li>
                <li data-target="#myCarousel" data-slide-to="3"></li>
            </ol>
             -->
            <!-- Wrapper for slides -->
            <div class="carousel-inner " role="listbox">
                <div class="item active relative">
                    <img src="~/Content/Images/Website/Ad1.jpg"  class="col-xs-12 no-padd">
                    <div class="hidden-sm hidden-xs hidden-md">
                        <div style="position: absolute; right:15%; top:300px; opacity: .8;">
                            <h1 class="bold text-center" style="font-size:130px; color:#46AADC; line-height:80%;">
                                Healthcare<br />
                                For All.<br />
                                Affordable.<br />
                                Accessible.<br />
                            </h1>
                        </div>
                    </div>
                    <div class="hidden-sm hidden-xs  hidden-lg">
                        <div style="position: absolute; right:15%; top:200px; opacity: .8;">
                            <h1 class="bold text-center" style="font-size:100px; font-weight:bolder; color:#46AADC; line-height:80%;">
                                Healthcare<br />
                                For All.<br />
                                Affordable.<br />
                                Accessible.<br />
                            </h1>
                        </div>
                    </div>
                    <div class="hidden-xs hidden-md  hidden-lg">
                        <div style="position: absolute; right:15%; top:100px; opacity: .8;">
                            <h1 class="bold text-center" style="font-size:90px; font-weight:bolder; color:#46AADC; line-height:80%;">
                                Healthcare<br />
                                For All.<br />
                                Affordable.<br />
                                Accessible.<br />
                            </h1>
                        </div>
                    </div>
                    <div class="hidden-sm hidden-md  hidden-lg">
                        <div style="position: absolute; right:15%; top:20px; opacity: .8;">
                            <h1 class="bold text-center" style="font-size:40px; font-weight:bolder; color:#46AADC; line-height:80%;">
                                Healthcare<br />
                                For All.<br />
                                Affordable.<br />
                                Accessible.<br />
                            </h1>
                        </div>
                    </div>
                </div>
                    
                <div class="item relative ">
                    <img src="~/Content/Images/Website/Ad2.jpg" class="col-xs-12 no-padd">
                    <div class="hidden-sm hidden-xs hidden-md">
                        <div style="position: absolute; right:12%; top:30vh; opacity: .8;">
                            <h1 class="bold text-left" style="font-size:130px; color:#CA592D; line-height:80%;">
                                Matching<br />
                                your Medical<br />
                                needs with<br />
                                Top Physicians<br />
                                Globally<br />
                            </h1>
                        </div>
                    </div>
                    <div class="hidden-sm hidden-xs hidden-lg">
                        <div style="position: absolute; right:10%; top:30vh; opacity: .8;">
                            <h1 class="bold text-left" style="font-size:110px; color:#CA592D; line-height:80%;">
                                Matching<br />
                                your Medical<br />
                                needs with<br />
                                Top Physicians<br />
                                Globally<br />
                            </h1>
                        </div>
                    </div>
                    <div class="hidden-xs hidden-md hidden-lg">
                        <div style="position: absolute; right:3%; top:100px; opacity: .8;">
                            <h1 class="bold text-left" style="font-size:90px; color:#CA592D; line-height:80%;">
                                Matching<br />
                                your Medical<br />
                                needs with<br />
                                Top Physicians<br />
                                Globally<br />
                            </h1>
                        </div>
                    </div>
                    <div class="hidden-sm hidden-lg hidden-md">
                        <div style="position: absolute; right:3%; top:20px; opacity: .8;">
                            <h1 class="bold text-left" style="font-size:40px; color:#CA592D; line-height:80%;">
                                Matching<br />
                                your Medical<br />
                                needs with<br />
                                Top Physicians<br />
                                Globally<br />
                            </h1>
                        </div>
                    </div>
                  </div>

                <div class="item relative">
                    <img src="~/Content/Images/Website/Ad3.jpg" class="col-xs-12 no-padd">
                    <div class="hidden-sm hidden-xs hidden-md">
                        <div style="position: absolute; right:2%; top:20vh; opacity: .8;">
                            <h1 class="bold text-left" style="font-size:130px; color:#CA592D; line-height:95%;">
                                Saving Lives<br />
                                Empowering<br />
                                Nations.<br />
                            </h1>
                            <hr />
                            <h4 style="font-size:30px;">
                                The health of the community is important<br /> to us. Donate a telemed session to a child<br /> in need.<br /><br />
                                <button class="btn btn-warning" style="background-color: #F26E23 !important; height:60px; font-size:30px;">DONATE</button>
                            </h4>
                        </div>
                    </div>

                    <div class="hidden-xs hidden-sm hidden-lg">
                        <div style="position: absolute; right:2%; top:100px; opacity: .8;">
                            <h1 class="bold text-left" style="font-size:100px; color:#CA592D; line-height:95%;">
                                Saving Lives<br />
                                Empowering<br />
                                Nations.<br />
                            </h1>
                            <hr />
                            <h4 style="font-size:30px;">
                                The health of the community is important<br /> to us. Donate a telemed session to a child<br /> in need.<br /><br />
                                <button class="btn btn-warning" style="background-color: #F26E23 !important; height:60px; font-size:30px;">DONATE</button>
                            </h4>
                        </div>
                    </div>

                    <div class="hidden-xs hidden-md hidden-lg">
                        <div style="position: absolute; right:2%; top:80px; opacity: .8;">
                            <h1 class="bold text-left" style="font-size:100; color:#CA592D; line-height:95%;">
                                Saving Lives<br />
                                Empowering<br />
                                Nations.<br />
                            </h1>
                            <hr />
                            <h4 style="font-size:30px;">
                                The health of the community is important<br /> to us. Donate a telemed session to a child<br /> in need.<br /><br />
                                <button class="btn btn-warning" style="background-color: #F26E23 !important; height:60px; font-size:30px;">DONATE</button>
                            </h4>
                        </div>
                    </div>

                    <div class="hidden-sm hidden-lg hidden-md">
                        <div style="position: absolute; right:2%; top:px; opacity: .8;">
                            <h1 class="bold text-left" style="font-size:40; color:#CA592D; line-height:95%;">
                                Saving Lives<br />
                                Empowering<br />
                                Nations.<br />
                            </h1>
                            <hr />
                            <h4 style="font-size:20px;">
                                The health of the community is important<br /> to us. Donate a telemed session to a child<br /> in need.<br /><br />
                                <button class="btn btn-warning" style="background-color: #F26E23 !important; height:60px; font-size:30px;">DONATE</button>
                            </h4>
                        </div>
                    </div>
                  </div>
                <div class="item relative ">
                    <img src="~/Content/Images/Website/Ad4.jpg" class="col-xs-12 no-padd">
                    <div class="hidden-sm hidden-xs hidden-md">
                        <div style="position: absolute; right:2%; top:10vh; opacity: .8;">
                            <h1 class="bold text-left" style="font-size:130px; color:#CA592D; line-height: 80%;">
                                Be a part<br />
                                of the<br />
                                Healthcare<br />
                                Revolution<br />
                            </h1>
                            <hr />
                            <h4 style="font-size:30px;">
                                We want the best of the best, our services are<br />catered to maximize your practice<br /> in need.<br /><br />
                                <button class="btn btn-info" style="background-color: #32B7F8 !important;  height:60px; font-size:30px;">LEARN MORE</button>
                            </h4>
                        </div>
                    </div>

                    <div class="hidden-sm hidden-xs hidden-lg">
                        <div style="position: absolute; right:2%; top:100px; opacity: .8;">
                            <h1 class="bold text-left" style="font-size:100px; color:#CA592D; line-height: 80%;">
                                Be a part<br />
                                of the<br />
                                Healthcare<br />
                                Revolution<br />
                            </h1>
                            <hr />
                            <h4 style="font-size:30px;">
                                We want the best of the best, our services are<br />catered to maximize your practice<br /> in need.<br /><br />
                                <button class="btn btn-info" style="background-color: #32B7F8 !important;  height:60px; font-size:30px;">LEARN MORE</button>
                            </h4>
                        </div>
                    </div>

                    <div class="hidden-lg hidden-xs hidden-md">
                        <div style="position: absolute; right:2%; top:50px; opacity: .8;">
                            <h1 class="bold text-left" style="font-size:70px; color:#CA592D; line-height: 80%;">
                                Be a part<br />
                                of the<br />
                                Healthcare<br />
                                Revolution<br />
                            </h1>
                            <hr />
                            <h4 style="font-size:30px;">
                                We want the best of the best, our services are<br />catered to maximize your practice<br /> in need.<br /><br />
                                <button class="btn btn-info" style="background-color: #32B7F8 !important;  height:60px; font-size:30px;">LEARN MORE</button>
                            </h4>
                        </div>
                    </div>

                    <div class="hidden-sm hidden-lg hidden-md">
                        <div style="position: absolute; right:2%; top:5px; opacity: .8;">
                            <h1 class="bold text-left" style="font-size:40px; color:#CA592D; line-height: 80%;">
                                Be a part<br />
                                of the<br />
                                Healthcare<br />
                                Revolution<br />
                            </h1>
                            <hr />
                            <h4 style="font-size:20px;">
                                We want the best of the best, our services are<br />catered to maximize your practice<br /> in need.<br /><br />
                                <button class="btn btn-info" style="background-color: #32B7F8 !important;  height:60px; font-size:30px;">LEARN MORE</button>
                            </h4>
                        </div>
                    </div>
                </div>
            </div>
            <div>

            </div>

            <!-- Left and right controls
            <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>-->
             
        </div>*@


        <div id="myCarousel" class="carousel slide" data-ride="carousel" data-interval="3000" data-pause="false">
            <div class="carousel-inner" role="listbox">
                <div class="item active relative">
                    <img src="~/Content/Images/Website/New/img1.png" class="col-xs-12 no-padd">
                </div>

                <div class="item relative">
                    <img src="~/Content/Images/Website/New/img2.png" class="col-xs-12 no-padd">
                </div>

                <div class="item relative">
                    <img src="~/Content/Images/Website/New/img3.png" class="col-xs-12 no-padd">
                </div>

                <div class="item relative">
                    <img src="~/Content/Images/Website/New/img4.png" class="col-xs-12 no-padd">
                </div>
            </div>
            <div>
            </div>
        </div>
            

    </div>
   <div class="row">
       <section class="container">
           <div id="worldclass-Experience">
               <div class="col-xs-12 top-20">
               </div>
               <h1 class="text-center top-30 custom-fblue">Driving Worldclass Patient Experience</h1>

               <div class="row hidden-xs">
                   <div class="col-sm-4 col-sm-offset-1 col-md-4 col-md-offset-1 col-lg-4 col-lg-offset-1" id="patient-tracking">
                       <img src="~/Content/Images/Website/New/dw-1.png">
                       <h2>Patient tracking</h2>
                       <p>We value our patients' safety and with state of the art GPS technology and devices, we are able to monitor your journey upon arrival at the airport to checking into your accommodation. We provide secure and easy transitions throughout your medical journey.</p>
                   </div>
                   <div class="col-sm-7 col-md-7 col-lg-7">

                       <div class="row">
                           <img src="~/Content/Images/Website/New/dw-2.png">

                           <div class="row">
                               <div class="col-sm-4 col-md-offset-1 col-lg-4 col-lg-offset-1"> <img src="~/Content/Images/Website/New/dw-3.png"></div>
                               <div class="col-sm-6 col-md-6 col-lg-6">

                                   <h2>TeleMed</h2>
                                   <p>Doctourz can facilitate hassle free, patient-physician consults at the comfort of your own home. No more spending hours in a waiting room with our virtual house calls and 24/7 concierge staff. We help you take control of your healthcare.</p>

                                   <h2>Follow-up care</h2>
                                   <p>With the vast array of wearable apps that are going to be available to patients, it will allow our trained medical team to provide the best follow-up patient care in a quick and timely manner.</p>
                               </div>
                           </div>

                           <!-- <h2>TeleMed</h2>
                        <p>Doctourz can facilitate hassle free, patient-physician consults at the comfort of your own home. No more spending hours in a waiting room with our virtual house calls and 24/7 concierge staff. We help you take control of your healthcare.</p>   -->
                       </div>

                   </div>
               </div>

               <div class="show-xs hidden-sm hidden-md hidden-lg">
                   <div class="container">
                       <div class="row">
                           <div class="col-xs-12">

                               <img src="~/Content/Images/Website/New/dw-1.png">
                               <h2>Patient tracking</h2>
                               <p>We value our patients' safety and with state of the art GPS technology and devices, we are able to monitor your journey upon arrival at the airport to checking into your accommodation. We provide secure and easy transitions throughout your medical journey.</p>

                               <img class="we-img" src="~/Content/Images/Website/New/dw-2.png">
                               <h2>TeleMed</h2>
                               <p>Doctourz can facilitate hassle free, patient-physician consults at the comfort of your own home. No more spending hours in a waiting room with our virtual house calls and 24/7 concierge staff. We help you take control of your healthcare.</p>

                               <img class="we-img" src="~/Content/Images/Website/New/dw-3.png">
                               <h2>Follow-up care</h2>
                               <p>With the vast array of wearable apps that are going to be available to patients, it will allow our trained medical team to provide the best follow-up patient care in a quick and timely manner.</p>

                           </div>
                       </div>
                   </div>

               </div>
               



           </div>
       </section><!-- worldclass-Experience -->

       <div class="col-xs-12 no-padd" style="background-image: url(../../Content/Images/Website/blueBG.png);background-size: cover;background-position:center;background-repeat: no-repeat">
           <div class="mybody-content text-center" id="registration">
               <h1 style="font-size:45px;" class="fwhite">The vision of DOCTOURZ is to make healthcare<br />personal and accessible. <br /> Join the Healthcare revolution</h1>
               <div class="col-xs-12 top-50" style="padding-bottom: 100px">
                   <form class="form-inline" role="form">
                       <div class="form-group">
                           <select class="form-control input-lg" id="type">
                               <option>I am a...</option>
                               <option>I am a patient</option>
                               <option>I am a doctor</option>
                           </select>
                       </div>
                       <div class="form-group">
                           <input type="email" class="form-control input-lg" placeholder="Email" id="email">
                       </div>
                       <button type="submit" class="btn btn-warning btn-lg" style="background-color:#F26E23;">Signup</button>
                   </form>
               </div>
           </div>
       </div>
   </div>
</div>