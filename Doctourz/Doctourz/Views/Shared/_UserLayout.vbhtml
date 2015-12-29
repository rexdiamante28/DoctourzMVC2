<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/user")

   

</head>
<body class="bggray5">
    <div id="telemedCover" class="hidden" onmouseover="FoldSideBar()">
        <input type="text" value="empty" id="currentBottomBar" class="hidden" />
    </div>
    <div id="wrapper">
        <!-- MENU -->
        @Html.Action("Menu","User")

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
                            <li id="topbar0"><a href="/user/telemed"><i class="fa fa-video-camera "></i><br/>Telemed</a></li>
                            <li id="topbar1"><a href="#"><img src="~/Content/icons/ask-doctor.gif" /><br />Ask Doctor</a></li>
                            <li id="topbar2"><a href="/user/news"><i class="fa fa-newspaper-o "></i><br />News</a></li>
                            <li id="topbar3"><a href="/user/search"><i class="fa fa-search "></i><br />Search</a></li>
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

    <script>


        $('#bottomLink1').click( function (evt) {
            evt.preventDefault();
            evt.stopPropagation();
            
            document.getElementById('bottom-container').innerHTML = '<img src="../Content/Images/User/Untitled.png" class="col-xs-12"/>';
        });

        $('#bottomLink2').click(function (evt) {
            evt.preventDefault();
            evt.stopPropagation();
            
            document.getElementById('bottom-container').innerHTML = '<img src="../Content/Images/User/Untitled2.png" class="col-xs-12"/>';
        });


        $('#bottomLink3').on('click', function (evt) {
            evt.preventDefault();
            evt.stopPropagation();
           
            document.getElementById('bottom-container').innerHTML = '<img src="../Content/Images/User/Untitled3.png" class="col-xs-12"/>';
        });

        $('#bottomLink4').on('click', function (evt) {
            evt.preventDefault();
            evt.stopPropagation();
           

            document.getElementById('bottom-container').innerHTML = '<img src="../Content/Images/User/Untitled4.png" class="col-xs-12"/>';
        });

        $('#bottomLink5').on('click', function (evt) {
            evt.preventDefault();
            evt.stopPropagation();
           
            document.getElementById('bottom-container').innerHTML = '<img src="../Content/Images/User/Untitled5.png" class="col-xs-12"/>';
        });
    </script>
</body>
</html>

