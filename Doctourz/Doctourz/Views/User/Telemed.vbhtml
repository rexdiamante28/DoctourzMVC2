@Imports Microsoft.AspNet.Identity
@Code
    Layout = "../Shared/_UserLayout.vbhtml"

    Dim db = New ApplicationDbContext
    Dim appUser As String = User.Identity.GetUserName
    Dim name = db.AppUsers.Where(Function(model) model.userName = appUser).First().name

    ViewData("Name") = name
End Code
 <input id="txtName" type="hidden" value="@ViewData("Name")" />
   

<div id="acceptCallBox">
    <div id="acceptCallLabel"></div>
    <div class="text-center top-30">
        <input type="button" id="callAcceptButton" class="btn btn-success btn-sm" value="Accept" /> <input type="button" id="callRejectButton" class="btn btn-danger btn-sm" value="Reject" />
    </div>
</div>


<div id="bottom-dock" class="bottom-dock-close">
    <div class="bottom-link" id="bottomLink1"  onclick="TelemedCoverDecide(this.id); loadPageBottom('appointment')">
        <label>APPOINTMENTS</label>
    </div>
    <div class="bottom-link" id="bottomLink2"  onclick="TelemedCoverDecide(this.id); loadPageBottom('PatientRecords')">
        <label>PATIENT RECORDS</label>
    </div>
    <div class="bottom-link" id="bottomLink3" onclick="TelemedCoverDecide(this.id); loadPageBottom('Notes')">
        <label>NOTES</label>
    </div>
    <div class="bottom-link" id="bottomLink4"  onclick="TelemedCoverDecide(this.id); loadPageBottom('CareTeam')">
        <label>CARE TEAM</label>
    </div>
    <div class="bottom-link" id="bottomLink5" onclick="TelemedCoverDecide(this.id); loadPageBottom('Diagnosis')">
        <label>DIAGNOSIS</label>
    </div>
    <div class="col-xs-12 " id="bottom-container">
    </div>
</div>



<div id="main-frame">
    <div id="video" class="publisherContainer">
        <div id="subscribers" class="subscribersContainer"></div>
        <div id="info" class="info-open">
            <div class="header">
                <text id="l1" class="fwhite _13 pull-right">INFO &nbsp;<i class="fa fa-file-text-o"></i></text>
                <i id="l2" class="pull-right fa fa-file-text-o fwhite opener" style="display:none;" onclick="ExpandInfo()"></i>
                <i id="l3" class="pull-left fa fa-minus fwhite" style="font-size:10px;margin-top:10px;" onclick="CompressInfo()"></i>
            </div>
            
            <ul class="list-group" id="patient-initial-info">
                <li class="list-group-item">
                    <text class="bold">PATIENT: </text><text>Patient Name</text>
                </li>
                <li class="list-group-item">
                    <text class="bold">VITALS: </text><text>Vitals Here</text>
                </li>
                <li class="list-group-item">
                    <text class="bold">AGE: </text><text>20 Years old</text>
                </li>
                <li class="list-group-item">
                    <text class="bold">SEX: </text><text>Male</text>
                </li>
                <li class="list-group-item">
                    <text class="bold">BP: </text><text>100/70</text>
                </li>
                <li class="list-group-item">
                    <div class="row">
                        <div class="col-xs-12">
                            <text class="bold">NOTES:</text><br />
                            <textarea class="form-control " style="height:200px;" placeholder="Write your notes here"></textarea>
                            <button class="btn btn-default pull-right top-10">Save</button>
                        </div>
                    </div>
                </li>
            </ul>
        </div>

        <div id="myCamera" class="publisherContainer"></div>

        <div id="chat" class="chat-open">
            <div class="header">
                <div class="row">
                    <div class="col-xs-12">
                        <text id="r1" class="fwhite _13" style="margin-bottom:3px;"><i class="fa fa-comments"></i> CHAT</text>
                        <i id="r2" class="pull-left fa fa-comments fwhite opener" style="display:none;" onclick="ExpandChat()"></i>
                        <i id="r3" class="pull-right fa fa-minus fwhite" style="font-size:10px;margin-top:10px;" onclick="CompressChat()"></i>
                    </div>
                </div>
            </div>
            <div id="messaging-controls" class="messaging-controls">
            </div>
            <div id="chatbox" class="padd-10">
                    <div class="col-xs-12 bgwhite padd-10 top-10">
                        <img src="~/Content/Images/Website/dummy.jpg"  class="img-circle" style="width:30px;"/>
                        <text class="custom-fblue">Carmella Dela Cruz</text>
                        <p class="fgray3">Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci vel</p>
                    </div>
                    <div class="col-xs-12 bgwhite padd-50 top-10">
                    </div>
                    <div class="col-xs-12 bgwhite padd-50 top-10">
                    </div>
                    <div class="col-xs-12 bgwhite padd-50 top-10">
                    </div>
            </div>
            <div id="message-box" class="list-group-item">
                <div class="input-group">
                    <textarea type="text" class="form-control" placeholder="Type your message..."></textarea>
                    <span class="input-group-btn">
                        <button class="btn btn-primary" type="button" style="height:53px;">Send</button>
                    </span>
                </div>
            </div>
        </div>
    </div>
    <div id="controls">
        <div class="row">
            <div class="col-xs-12">
                <div id="onlineusers" class="pull-right">
                    <i class="fa fa-users"></i>
                </div>
                <div id="controls-frame" class="text-center">
                    <i class="fa fa-volume-down" style="margin-right:0px;" title="Adjust volume"></i>
                    <input type="number" onchange="TestAlert(this.value)" class="slider" value="" style="width:50px;margin-top:0px;" data-slider-min="0" data-slider-max="100" data-slider-step="1" data-slider-value="70" data-slider-orientation="horizontal" data-slider-selection="after" data-slider-tooltip="show">
                    <i class="fa fa-phone"></i>
                    <a id="videoControl" onclick="HideElement(this.id), ShowElement('videoControlSlashed')" title="Disable video" ><i class="fa fa-video-camera"></i></a>
                    <a id="videoControlSlashed" class="no-display" onclick="HideElement(this.id), ShowElement('videoControl')" title="Enable video"><i class="fa fa-eye-slash"></i></a>
                    <a id="audioControl" onclick="HideElement(this.id), ShowElement('audioControlSlashed')"><i class="fa fa-microphone" title="Disable audio"></i></a>
                    <a id="audioControlSlashed" onclick="HideElement(this.id), ShowElement('audioControl')" class="no-display" title="Enable audio"><i class="fa fa-microphone-slash"></i></a>
                </div>
            </div>
        </div>
    </div>
</div>

<audio id="rigning" style="display :none" loop>
    <source src="~/media/ringing .mp3" type="audio/mpeg">
</audio>

@Section scripts
<script src="http://static.opentok.com/webrtc/v2.2/js/opentok.min.js" type="text/javascript" charset="utf-8"></script>
<script src="@Url.Content("~/Scripts/opentok2.2.js")" type="text/javascript" charset="utf-8"></script>
<script src="~/Scripts/jquery.signalR-2.2.0.min.js"></script>
<script src="~/signalr/hubs"></script>

<script>


    function countSubscriber() {
        var a = $('.callSubscriber');
        var b = parseInt(a.length);
        if(b==1){
            a.style.width = "100%";
            a.style.height = "40vh";
        }
    }

    CompressInfo();
    CompressChat();

    document.getElementById('topbar0').setAttribute("class", "bggray5");

    $(function () {

        var rtc = $.connection.rTCHub;
        var selfuser, caller;

       // show('connectLink');

        function show(id) {
            document.getElementById(id).style.display = 'inline-block';
        }

        function hide(id) {
            document.getElementById(id).style.display = 'none';
        }

        rtc.client.getOnlineUsers = function (users) {

            $.each(users, function (key, user) {
                if (user.Name != $('#txtName').val()) {
                    OnlineUsers.addButton(user);
                }
                else
                    selfuser = user;
            });
        }
        rtc.client.getNewOnlineUser = function (user) {

            OnlineUsers.addButton(user);


        };
        rtc.client.disconnected = function (user) {
            OnlineUsers.removeButton(user);

        }


        rtc.client.notifybeginCall = function (touser, caller_user) {

            acceptCallBox.show();
            acceptCallBox.message('Incoming call from ' + caller_user.Name);
            caller = caller_user;
            ringing.play();






        }

       


        rtc.client.notifyCallend = function (self, caller) {

            if (acceptCallBox.IsVisible()) {

                acceptCallBox.hide();
                ringing.mute();

            }
            else {

                btn = document.getElementById("btn_" + caller.ConnectionId);

                if (btn) {
                    endCall(btn, "Call " + caller.Name);
                    Opentok.disconnect();
                    Opentok.connect(self.Opentok);

                }


            }

        }

        rtc.client.notifyCallrejected = function (message, calleruser) {
            alert(message);
            var btn = document.getElementById("btn_" + calleruser.ConnectionId);
            if (btn.value == "End Call")
                endCall(btn, "Call " + calleruser.Name);
            ringing.mute();
        }

        document.getElementById('callAcceptButton').onclick = function () {

            _btn = document.getElementById('btn_' + caller.ConnectionId);
            beginCall(_btn);
            Opentok.disconnect();
            Opentok.connect(caller.Opentok);
            ringing.mute();
            acceptCallBox.hide();





        }
        document.getElementById('callRejectButton').onclick = function () {
            acceptCallBox.hide();
            ringing.mute();

            rtc.server.callRejectedSignal(caller.ConnectionId);
        }


      

        $('#videoControl').click(function () {
            publisher.publishVideo(false);
        });

        $('#videoControlSlashed').click(function () {
            publisher.publishVideo(true);
        });

        $('#audioControl').click(function () {
            publisher.publishAudio(false);
        });

        $('#audioControlSlashed').click(function () {
            publisher.publishAudio(true);
        });

        $.connection.hub.start().done(function () {

            $(document).ready(function () {

                $('.slider').slider();

                var name = document.getElementById("txtName").value;
                rtc.server.getConnected(name, 'http://localhost:13624').done(function (user) {
                    Opentok.connect(user.Opentok);

                });
            });
            $('#disconnectLink').click(function () {
                rtc.server.getDisConnected().done(function () {
                    Opentok.disconnect();
                    OnlineUsers.removeAllButtons();
                });
            });

            

        });

    });
</script>





End Section
