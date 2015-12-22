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
    <input type="button" id="callAcceptButton" value="Accept" /> <input type="button" id="callRejectButton" value="Reject" />
</div>


<div id="bottom-dock" class="bottom-dock-close">
    <div class="bottom-link" id="bottomLink1" onclick="TelemedCoverDecide(this.id)">
        <label>APPOINTMENTS</label>
        <i class="fa fa-expand"></i>
    </div>
    <div class="bottom-link" id="bottomLink2" onclick="TelemedCoverDecide(this.id)">
        <label>PATIENT RECORDS</label>
        <i class="fa fa-expand"></i>
    </div>
    <div class="bottom-link" id="bottomLink3" onclick="TelemedCoverDecide(this.id)">
        <label>NOTES</label>
        <i class="fa fa-expand"></i>
    </div>
    <div class="bottom-link" id="bottomLink4" onclick="TelemedCoverDecide(this.id)">
        <label>CARE TEAM</label>
        <i class="fa fa-expand"></i>
    </div>
    <div class="bottom-link" id="bottomLink5" onclick="TelemedCoverDecide(this.id)">
        <label>DIAGNOSIS</label>
        <i class="fa fa-expand"></i>
    </div>
</div>



<div id="main-frame">
    <div id="video" class="publisherContainer">
        <div id="subscribers" class="subscribersContainer"></div>
        <div id="info" class="info-open">
            <div class="header">
                <text id="l1" class="fwhite _19">INFORMATION</text>
                <i id="l2" class="pull-right fa fa-plus-square fwhite opener" style="display:none;" onclick="ExpandInfo()"></i>
                <i id="l3" class="pull-right fa fa-minus-square fwhite" onclick="CompressInfo()"></i>
            </div>
            <div id="onlineusers">
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
                            <textarea class="form-control transparent" style="height:200px;" placeholder="Write your notes here"></textarea>
                            <button class="btn btn-default pull-right top-10">Save</button>
                        </div>
                    </div>
                </li>
            </ul>
        </div>
        <div id="chat" class="chat-open">
            <div class="header">
                <div id="myCamera" class="publisherContainer"></div>
                <div class="row">
                    <div class="col-xs-12">
                        <text id="r1" class="fwhite _19 pull-right">CHAT</text>
                        <i id="r2" class="pull-left fa fa-plus-square fwhite opener" style="display:none;" onclick="ExpandChat()"></i>
                        <i id="r3" class="pull-left fa fa-minus-square fwhite " onclick="CompressChat()"></i>
                    </div>
                </div>
            </div>
            <div id="messaging-controls" class="messaging-controls">
                <div class="btn-group btn-group-justified">
                    <a href="#" class="btn btn-secondary"><i class="fa fa-list"></i> Contacts</a>
                    <a href="#" class="btn btn-secondary"><i class="fa fa-retweet"></i> Messages</a>
                </div>
            </div>
            <div id="chatbox">
                <ul class="list-group">
                    <li class="list-group-item">sldkfjlsdjfsjlf</li>
                    <li class="list-group-item">sldkfjlsdjfsjlf</li>
                    <li class="list-group-item">sldkfjlsdjfsjlf</li>
                    <li class="list-group-item">sldkfjlsdjfsjlf</li>
                    <li class="list-group-item">sldkfjlsdjfsjlf</li>
                    <li class="list-group-item">sldkfjlsdjfsjlf</li>
                    <li class="list-group-item">sldkfjlsdjfsjlf</li>
                    <li class="list-group-item">sldkfjlsdjfsjlf</li>
                    <li class="list-group-item">sldkfjlsdjfsjlf</li>
                    <li class="list-group-item">sldkfjlsdjfsjlf</li>
                    <li class="list-group-item">sldkfjlsdjfsjlf</li>
                    <li class="list-group-item">sldkfjlsdjfsjlf</li>
                    <li class="list-group-item">sldkfjlsdjfsjlf</li>
                    <li class="list-group-item">sldkfjlsdjfsjlf</li>
                    <li class="list-group-item">sldkfjlsdjfsjlf</li>
                    <li class="list-group-item">sldkfjlsdjfsjlf</li>
                    <li class="list-group-item">sldkfjlsdjfsjlf</li>
                    <li class="list-group-item">sldkfjlsdjfsjlf</li>
                </ul>
            </div>
            <div id="message-box" class="list-group-item">
                <div class="input-group">
                    <input type="text" class="form-control" placeholder="Type your message...">
                    <span class="input-group-btn">
                        <button class="btn btn-secondary" type="button">Send</button>
                    </span>
                </div>
            </div>
        </div>
    </div>
    <div id="controls">
        <div class="row">
            <div class="col-xs-12">
                <img src="~/Content/Images/Website/dummy.jpg" class="pull-left img-circle" />
                <img src="~/Content/Images/Website/dummy.jpg" class="pull-right img-circle" />
                <div id="controls-frame">
                    <i class="fa fa-eye"></i>
                    <i class="fa fa-microphone"></i>
                    <a id="connectLink"><i class="fa fa-video-camera"></i></a>
                    <a id="disconnectLink"><i class="fa fa-stop-circle"></i></a>
                    <i class="fa  fa-arrows-alt"></i>
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

   

    $(function () {

        var rtc = $.connection.rTCHub;
        var selfuser, caller;

        show('connectLink');

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


        $.connection.hub.start().done(function () {

            $(document).ready(function () {
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
