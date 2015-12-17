
$(function () {
    $(window).bind("load resize", function () {
        topOffset = 50;
        width = (this.window.innerWidth > 0) ? this.window.innerWidth : this.screen.width;
        if (width < 768) {
            $('div.navbar-collapse').addClass('collapse');
            topOffset = 100; // 2-row-menu
        } else {
            $('div.navbar-collapse').removeClass('collapse');
        }

        height = ((this.window.innerHeight > 0) ? this.window.innerHeight : this.screen.height) - 1;
        height = height - topOffset;
        if (height < 1) height = 1;
        if (height > topOffset) {
            $("#page-wrapper").css("min-height", (height) + "px");
        }
    });

    var url = window.location;
    var element = $('ul.nav a').filter(function () {
        return this.href == url || url.href.indexOf(this.href) == 0;
    }).addClass('active').parent().parent().addClass('in').parent();
    if (element.is('li')) {
        element.addClass('active');
    }
});

FoldSideBar = function foldSideBar() {
    document.getElementById('page-wrapper').setAttribute("class", "page-wrapper-close");
    document.getElementById('sidebar').setAttribute("class", "navbar-default sidebar sidebar-close");
    document.getElementById('name-section').setAttribute("class", "name-section top-20 hidden");
}

UnfoldSideBar = function unfoldSideBar() {
    document.getElementById('page-wrapper').setAttribute("class", "page-wrapper-open");
    document.getElementById('sidebar').setAttribute("class", "navbar-default sidebar sidebar-open");
    document.getElementById('name-section').setAttribute("class", "name-section top-20");
}

OpenCover = function openCover() {
    document.getElementById('transparent-cover').setAttribute("class", "transparent-cover-open");
}

CloseCover = function closeCover() {
    document.getElementById('transparent-cover').setAttribute("class", "transparent-cover-close");
}

OpenSidebarChild = function openSidebarChild() {
    document.getElementById('sidebar-child').setAttribute("class", "sidebar-child-open");
}

CloseSidebarChild = function closeSidebarChild() {
    var openSideBar = document.getElementById('currentSidebarChild')
    var oldVal = openSideBar.value;
    if(oldVal!="empty"){
        document.getElementById(oldVal).setAttribute("class", "");
    }

    document.getElementById('sidebar-child').setAttribute("class", "sidebar-child-close");
}

SidebarChildDecide = function sidebarChildDecide(id) {
    var openSideBar = document.getElementById('currentSidebarChild')
    var oldVal = openSideBar.value;
    var newVal = id;

    if(oldVal!="empty"){
        document.getElementById(oldVal).setAttribute("class", "");
        document.getElementById(id).setAttribute("class","bggreen5");
    }
    else {
        document.getElementById(id).setAttribute("class", "bggreen5");
    }

    //if the sidebar child is close, open it together with cover
    //if the sidebar is open and the corresponding link is clicked, close it together with cover
    //if the sidebar is open and a different link is clicked, siebar child must remain open together with cover

    document.getElementById('currentSidebarChild').value = id;

    var sidebarChild = document.getElementById('sidebar-child');
    var sidebarChildClass = sidebarChild.getAttribute("class");
    
    if(sidebarChildClass=="sidebar-child-close"){
        OpenSidebarChild();
        OpenCover();
    }
    else if (sidebarChildClass == "sidebar-child-open"&& oldVal == newVal) {
        CloseSidebarChild();
        CloseCover();
    }
    else if (sidebarChildClass == "sidebar-child-open" && oldVal != newVal) {
    }
}

// telemed user interface functions
ExpandInfo = function expandInfo(){
    document.getElementById('info').setAttribute("class", "info-open");

    document.getElementById('l1').style.display = "";
    document.getElementById('l2').style.display = "none";
    document.getElementById('l3').style.display = "";
    document.getElementById('patient-initial-info').style.display = "";
}
ExpandChat = function expandChat() {
    document.getElementById('chat').setAttribute("class", "chat-open");

    document.getElementById('r1').style.display = "";
    document.getElementById('r2').style.display = "none";
    document.getElementById('r3').style.display = "";
    document.getElementById('messaging-controls').style.display = "";
    document.getElementById('chatbox').style.display = "";
    document.getElementById('message-box').style.display = "";
}

CompressInfo = function compressInfo() {
    document.getElementById('info').setAttribute("class", "info-close");

    document.getElementById('l1').style.display = "none";
    document.getElementById('l2').style.display = "";
    document.getElementById('l3').style.display = "none";
    document.getElementById('patient-initial-info').style.display = "none";

}
CompressChat = function compressChat() {
    document.getElementById('chat').setAttribute("class", "chat-close");

    document.getElementById('r1').style.display = "none";
    document.getElementById('r2').style.display = "";
    document.getElementById('r3').style.display = "none";
    document.getElementById('messaging-controls').style.display = "none";
    document.getElementById('chatbox').style.display = "none";
    document.getElementById('message-box').style.display = "none";
}


TelemedCoverDecide = function telemedCoverDecide(id) {

    var openBottomBar = document.getElementById('currentBottomBar')
    var oldVal = openBottomBar.value;
    var newVal = id;

    if (oldVal != "empty") {
        document.getElementById(oldVal).setAttribute("class", "bottom-link");
        document.getElementById(id).setAttribute("class", "bottom-link-active");
    }
    else {
        document.getElementById(id).setAttribute("class", "bottom-link-active");
    }

    //if the sidebar child is close, open it together with cover
    //if the sidebar is open and the corresponding link is clicked, close it together with cover
    //if the sidebar is open and a different link is clicked, siebar child must remain open together with cover

    document.getElementById('currentBottomBar').value = id;

    var telemedCover = document.getElementById('telemedCover');
    var telemedCoverClass = telemedCover.getAttribute("class");
    var bottomDock = document.getElementById('bottom-dock');



    if (telemedCoverClass == "hidden") {
        telemedCover.setAttribute("class", "");
        bottomDock.setAttribute("class", "bottom-dock-open");
    }
    else if (telemedCoverClass == "" && oldVal == newVal) {
        telemedCover.setAttribute("class", "hidden");
        document.getElementById(id).setAttribute("class", "bottom-link");
        bottomDock.setAttribute("class", "bottom-dock-close");
    }
    else if (telemedCoverClass == "" && oldVal != newVal) {
    }

}



// telemed user interface functions
