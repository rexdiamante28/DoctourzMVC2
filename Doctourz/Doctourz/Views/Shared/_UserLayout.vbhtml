<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/user")
    @Scripts.Render("~/bundles/modernizr")

</head>
<body class="bggray5">
    <div id="telemedCover" class="hidden" onmouseover="FoldSideBar()">
        <input type="text" value="empty" id="currentBottomBar" class="hidden" />
    </div>
    <div id="wrapper">
        <div class="sidebar-child-close" id="sidebar-child" onmouseover="UnfoldSideBar()">
            <div class="col-xs-12 top-10">
                <input type="text" value="empty" readonly class="hidden" id="currentSidebarChild"/>
                <a class="_23 fwhite fhoverred1 point" onclick="CloseCover(),CloseSidebarChild(),FoldSideBar()">
                    <i class="pull-right fa fa-close"></i>
                </a>
            </div>
        </div>
        <div class="" id="transparent-cover" onclick="FoldSideBar(),CloseCover(),CloseSidebarChild()"></div>
        <div class="navbar-default sidebar sidebar-close" id="sidebar" role="navigation" onmouseover="UnfoldSideBar()">
            <div class="sidebar-nav navbar-collapse">
                <div class="name-section">
                    <img src="~/Content/Images/Website/dummy.jpg" class="img-responsive img-circle" style="margin:0 auto; max-width:100px; width: 90%;">
                    <div class="name-section top-10 hidden" id="name-section">
                        <h4 class="text-center">Hi Rex!</h4>
                        <div class="name-section-button text-center">Get help now</div>
                    </div>
                </div>
                <ul class="nav" id="side-menu">
                    <li id="sidelink1" onclick="SidebarChildDecide(this.id)"><img src="~/Content/icons/nofification.gif" />Notifications</li>
                    <li id="sidelink2" onclick="SidebarChildDecide(this.id)" class=""><img src="~/Content/icons/healthprofile.gif" />Health Profile</li>
                    <li id="sidelink3" onclick="SidebarChildDecide(this.id)" class=""><img src="~/Content/icons/dma-white.gif" />DMA</li>
                    <li id="sidelink4" onclick="SidebarChildDecide(this.id)" class=""><img src="~/Content/icons/consults.gif" />Consults</li>
                    <li id="sidelink5" onclick="SidebarChildDecide(this.id)" class=""><img src="~/Content/icons/answers.gif" />Answer</li>
                    <li id="sidelink6" onclick="SidebarChildDecide(this.id)" class=""><img src="~/Content/icons/doctors-matches.gif" />Doctors Matches</li>
                    <li id="sidelink7" onclick="SidebarChildDecide(this.id)" class=""><i class="fa fa-folder-o"></i>Files</li>
                    <li id="sidelink8" onclick="SidebarChildDecide(this.id)" class=""><img src="~/Content/icons/ask-doctor.gif" />Topics</li>
                    <li id="sidelink9" onclick="SidebarChildDecide(this.id)" class=""><img src="~/Content/icons/people-you-care-for.gif" />People You Care For</li>
                    <li id="sidelink10" onclick="SidebarChildDecide(this.id)" class=""><img src="~/Content/icons/invite-friends.gif" />Invire Friends and Family</li>
                    <li id="sidelink11" onclick="SidebarChildDecide(this.id)" class=""><img src="~/Content/icons/help.gif" />Help and Support</li>
                    <li id="sidelink12" onclick="SidebarChildDecide(this.id)" class=""><i class="fa fa-cog"></i>Settings</li>
                    <li id="sidelink13" onclick="SidebarChildDecide(this.id)" class=""><img src="~/Content/icons/sign-out.gif" />Log out</li>
                </ul>
            </div>
            <!-- /.sidebar-collapse -->
        </div>

        <!-- Page Content -->
        <div id="page-wrapper" class="bggray5" onmouseover="FoldSideBar()">
            <nav class="navbar bgwhite no-radius">
                <div class="container-fluid">
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-2">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                        <a class="navbar-brand no-padd" href="#"><img src="~/Content/Images/Website/logo_blue.png" /></a>
                    </div>
                    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-2">
                        <ul class="nav navbar-nav"></ul>
                        <ul class="nav navbar-nav navbar-right">
                            <li id="topbar1"><a href="#"><img src="~/Content/icons/ask-doctor.gif" /><br />Ask Doctor</a></li>
                            <li id="topbar2"><a href="News"><i class="fa fa-newspaper-o "></i><br />News</a></li>
                            <li id="topbar3"><a href="Search"><i class="fa fa-search "></i><br />Search</a></li>
                            <li id="topbar4"><a href="#"><img src="~/Content/icons/dma.gif" /><br />To-Do</a></li>
                        </ul>
                    </div>
                </div>
            </nav>
            @RenderBody()
        </div>
        <!-- /#page-wrapper -->
    </div>
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/user")
    @RenderSection("scripts", required:=False)
</body>
</html>
</html>
