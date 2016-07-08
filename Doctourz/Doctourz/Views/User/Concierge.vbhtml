@Imports Microsoft.AspNet.Identity
@Code
    Layout = "~/Views/Shared/_UserLayoutXmpp.vbhtml"
    
    Dim db = New ApplicationDbContext
    Dim appUser As String = User.Identity.GetUserName
    Dim username = db.AppUsers.Where(Function(model) model.userName = appUser).First().userName

    ViewData("Username") = username
End Code

<input id="txtUsername" type="hidden" value="@ViewData("Username")" />

<div class="col-xs-12 col-md-6 col-sm-offset-3">
  <div class="bgwhite padd-10">
      <div id="chatMessages">

      </div>
      <div id="chatComposer">
          <textarea id="message" class="form-control" placeholder="Type your message here"></textarea>
          <small>CTRL+Enter = new Line, Enter = Send</small>
      </div>
  </div>
</div>



@Section scripts
   <script>

       var nodaXmpp = 'mj@nicolo';
       var connection = null;

       function htmlEncode(value) {
           var encodedValue = $('<div />').text(value).html();
           return encodedValue;
       }

       function getCaret(el) {
           if (el.selectionStart) {
               return el.selectionStart;
           } else if (document.selection) {
               el.focus();
               var r = document.selection.createRange();
               if (r == null) {
                   return 0;
               }
               var re = el.createTextRange(), rc = re.duplicate();
               re.moveToBookmark(r.getBookmark());
               rc.setEndPoint('EndToStart', re);
               return rc.text.length;
           }
           return 0;
       }

       $('#message').keyup(function (event) {
           if (event.keyCode == 13) {
               var content = this.value;
               var caret = getCaret(this);
               if (event.shiftKey) {
                   this.value = content.substring(0, caret - 1) + "\n" + content.substring(caret, content.length);
                   event.stopPropagation();

               } else {
                   this.value = content.substring(0, caret - 1) + content.substring(caret, content.length);
                   var message = $('#message').val();

                   sendMessage(message,nodaXmpp);

                   $('#message').val('');
               }
           }
           else {
               sendChatState('composing');
           }
       });

       $(document).ready(function () {

           var usernameAndPassword = $('#txtUsername').val();
           
           login(usernameAndPassword+'@@nicolo', usernameAndPassword);
       })

       

       function login(jid, password) {
           connection = new Strophe.Connection('http://localhost:7070/http-bind/');

           connection.connect(jid, password, function (status, message) {
               console.log("Status: " + status + " , Message :" + message);
               if (status === 5) {
                   console.log('Connected');
                   on_connected();
               }
               else if (status === 1) {
                   console.log('Connecting');
               }
           })

           return true;
       }

       function sendChatState(state,receiver){
           message = $msg({
               to: nodaXmpp,
               "type": "chat"
           })
               .c(state, { xmlns: "http://jabber.org/protocol/chatstates" });

           connection.send(message);
       }


       function updatePresence(status_message) {
           var presence = $pres();
           presence.c('status').t(status_message);
           connection.send(presence);

           return true;
       }


       function sendMessages(text_message) {
           if (text_message.length > 0) {
               var contact_jid = this.items[index].jid;
               var timestamp = new Date().getTime();
               var to_jid = Strophe.getBareJidFromJid(contact_jid);
               var message = $msg({ from: bare_jid, to: to_jid, type: 'chat', id: timestamp }).c('body').t(text_message).up().c('active', { 'xmlns': 'http://jabber.org/protocol/chatstates' });
               var forwarded = $msg({ to: bare_jid, type: 'chat', id: timestamp }).c('forwarded', { xmlns: 'urn:xmpp:forward:0' }).c('delay', { xmns: 'urn:xmpp:delay', stamp: timestamp }).up().cnode(message.tree());
               connection.send(message);
               connection.send(forwarded);
           }
       }

       function sendMessage(message, to) {
           if (message.length > 0) {
               var timestamp = new Date().getTime();
               var myid = connection.jid;
               var message = $msg({ from: myid, to: to, type: 'chat', id: timestamp }).c('body').t(message).up().c('active', { 'xmlns': 'http://jabber.org/protocol/chatstates' });
               var forwarded = $msg({ to: myid, type: 'chat', id: timestamp }).c('forwarded', { xmlns: 'urn:xmpp:forward:0' }).c('delay', { xmns: 'urn:xmpp:delay', stamp: timestamp }).up().cnode(message.tree());

               connection.send(message);
               connection.send(forwarded);
           }
       }

       on_message = function (message) {
           if ($(message).find('composing').length > 0) {
               $('#typing').remove();
               scrolldown();
           }
           if ($(message).find('active').length > 0) {
               $('#typing').remove();
               scrolldown();
           }
           if ($(message).find('body').length > 0) {
               if ($(message).find('forwarded').length > 0) {
                   var body = $(message).find('body');
                   var message = "<div class='row'><div class='chatItemSent pull-right'>" + body.text() + " </div></div>";

                   $('#chatMessages').append(message);
                   scrolldown();
               }
               else {
                   var body = $(message).find('body');
                   var message = "<div class='row'><div class='chatItemReceived'>" + body.text() + " </div></div>";

                   $('#chatMessages').append(message);
                   scrolldown();
               }
               
           } else
           {
               if ($(message).find('composing').length > 0) {
                   var messageText = "<div class='row' id='typing'><div>" + nodaXmpp + " is typing ... </div></div>";

                   $('#chatMessages').append(messageText);
                   scrolldown();
                 
               }
           }

           return true;
       }

       function scrolldown() {
           $("#chatMessages").animate({ scrollTop: $("#chatMessages")[0].scrollHeight }, 500);
       }

       on_connected = function () {
           updatePresence('Online');

           connection.addHandler(on_message, null, "message", null, null, null);
           connection.addHandler(on_presence, null, "presence");

           return true;

       }

       on_presence = function (presence) {
           console.log(presence);

           return true;
       }


   </script>
End Section