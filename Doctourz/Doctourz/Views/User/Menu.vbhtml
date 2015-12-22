@Imports Microsoft.AspNet.Identity
@Code
    If (Request.IsAuthenticated) Then
        Dim userId = User.Identity.GetUserId
        Dim db = New ApplicationDbContext
        Dim appUser = db.AppUsers.Where(Function(x) x.userId = userId).First()
        ViewBag.appUserName = appUser.name
        ViewBag.appUserEmail = appUser.email
    End If
End Code

<div class="sidebar-child-close" id="sidebar-child" onmouseover="UnfoldSideBar()">
    <div class="col-xs-12 top-10">
        <input type="text" value="empty" readonly class="hidden" id="currentSidebarChild" />
        <a class="_23 fwhite fhoverred1 point" onclick="CloseCover(),CloseSidebarChild(),FoldSideBar()">
            <i class="pull-right fa fa-close"></i>
        </a>
        <div class="sidebar-body">

        </div>
    </div>
</div>
<div class="" id="transparent-cover" onclick="FoldSideBar(),CloseCover(),CloseSidebarChild()"></div>
<div class="navbar-default sidebar sidebar-close" id="sidebar" role="navigation" onmouseover="UnfoldSideBar()">
    <div class="sidebar-nav navbar-collapse">
        <div class="name-section">
            <img src="~/Content/Images/Website/dummy.jpg" class="img-responsive img-circle" style="margin:0 auto; max-width:100px; width: 90%;">
            <div class="name-section top-10 hidden" id="name-section">
                <h4 class="text-center">@ViewBag.appUserName.ToString</h4>
                <div class="name-section-button text-center">Get help now</div>
            </div>
        </div>
        <ul class="nav" id="side-menu">
            <li id="sidelink1" onclick="SidebarChildDecide(this.id)" ><img src="~/Content/icons/nofification.gif" />Notifications</li>
            <li id="sidelink2" onclick="SidebarChildDecide(this.id)" ><img src="~/Content/icons/healthprofile.gif" />Health Profile</li>
            <li id="sidelink3" data-url='@Url.Action("Dma","User")' onclick="SidebarChildDecide(this.id)" class="side-menu-link"><img src="~/Content/icons/dma-white.gif" />DMA</li>
            <li id="sidelink4" onclick="SidebarChildDecide(this.id)" ><img src="~/Content/icons/consults.gif" />Consults</li>
            <li id="sidelink5" onclick="SidebarChildDecide(this.id)" ><img src="~/Content/icons/answers.gif" />Answer</li>
            <li id="sidelink6" onclick="SidebarChildDecide(this.id)" ><img src="~/Content/icons/doctors-matches.gif" />Doctors Matches</li>
            <li id="sidelink7" onclick="SidebarChildDecide(this.id)" ><i class="fa fa-folder-o"></i>Files</li>
            <li id="sidelink8" onclick="SidebarChildDecide(this.id)" ><img src="~/Content/icons/ask-doctor.gif" />Topics</li>
            <li id="sidelink9" onclick="SidebarChildDecide(this.id)" ><img src="~/Content/icons/people-you-care-for.gif" />People You Care For</li>
            <li id="sidelink10" onclick="SidebarChildDecide(this.id)" ><img src="~/Content/icons/invite-friends.gif" />Invire Friends and Family</li>
            <li id="sidelink11" onclick="SidebarChildDecide(this.id)" ><img src="~/Content/icons/help.gif" />Help and Support</li>
            <a href="/Question/Main" style="text-decoration:none;color:white"><li id="sidelink12"><i class="fa fa-cog"></i>Settings</li></a>
            @If Request.IsAuthenticated Then
                @Using Html.BeginForm("LogOff", "Account", FormMethod.Post, New With {.id = "logoutForm"})
                    @Html.AntiForgeryToken
                    @<a href="javascript:document.getElementById('logoutForm').submit()" style="text-decoration:none;color:white"><li id="sidelink13" class=""><img src="~/Content/icons/sign-out.gif" />Log out</li></a>
                End Using
            End If

        </ul>
    </div>
    <!-- /.sidebar-collapse -->
</div>