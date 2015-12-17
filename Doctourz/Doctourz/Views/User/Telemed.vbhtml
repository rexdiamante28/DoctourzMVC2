@Code
    Layout = "../Shared/_UserLayout.vbhtml"
End Code

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
    <div id="video">
        <div id="info" class="info-open">
            <div class="header">
                <text id="l1" class="fwhite _19">INFORMATION</text>
                <i id="l2" class="pull-right fa fa-plus-square fwhite opener" style="display:none;" onclick="ExpandInfo()"></i>
                <i id="l3" class="pull-right fa fa-minus-square fwhite" onclick="CompressInfo()"></i>
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
                    <i class="fa fa-video-camera"></i>
                    <i class="fa fa-stop-circle"></i>
                    <i class="fa  fa-arrows-alt"></i>
                </div>
                
            </div>
        </div>
    </div>
</div>