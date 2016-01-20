
Imports Microsoft.AspNet.SignalR
Imports Doctourz.opentokRTC.Models
Imports System.Collections.Concurrent
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Web

Namespace opentokRTC.Controllers
    <Hubs.HubName("rTCHub")>
    Public Class RTCHub
        Inherits Hub

        Public Shared Users As New ConcurrentDictionary(Of String, User)()
        Public Shared connections As New connections()


        Public Sub Send(ByVal name As String, ByVal message As String, ByVal senderAvatar As String)
            Clients.All.addNewMessageToPage(name, message, senderAvatar)
        End Sub


        Public Function GetConnected(username As String, avatar As String, Remote_Address As String) As User
            Dim user As User
            connections.Add(Context.ConnectionId)
            Dim ot = New oTok(Remote_Address)
            user = New User(username, Context.ConnectionId, ot, avatar)

            Users.TryAdd(Context.ConnectionId, user)
            Clients.Clients(connections.AllExcept(Context.ConnectionId)).getNewOnlineUser(user)
            Clients.Client(Context.ConnectionId).getOnlineUsers(Users)


            Return user
        End Function


        Public Sub BeginCall(toConnectionId As String)

            Dim touser = Users(toConnectionId)
            Dim caller = Users(Context.ConnectionId)
            Dim users__1 As New List(Of User)()

            Clients.Client(toConnectionId).notifybeginCall(touser, caller)


        End Sub

        Public Sub CallRejectedSignal(CallerConnectionId As String)

            Dim self = Users(Context.ConnectionId)

            Clients.Client(CallerConnectionId).notifyCallrejected("Call rejected by : " + self.Name)
        End Sub



        Public Sub EndCall(CallerConnectionId As String)
            Try


                Dim caller As New User()
                Dim self As New User()
                If Users.ContainsKey(Context.ConnectionId) Then
                    self = Users(Context.ConnectionId)
                    caller = Users(CallerConnectionId)

                    Clients.Client(CallerConnectionId).notifyCallend(caller, self)
                End If
            Catch exp As Exception
            End Try
        End Sub


        Private Sub GetDisConnected(ConnectionId As String)
            If Users.ContainsKey(ConnectionId) = True Then
                Dim user As User
                Dim currentuser As User = Users(ConnectionId)

                Users.TryRemove(ConnectionId.ToString(), user)
                connections.Remove(ConnectionId)
                Clients.Clients(connections.AllExcept(ConnectionId)).disconnected(user)
            End If
        End Sub

        Public Sub GetDisConnected()
            GetDisConnected(Context.ConnectionId)
        End Sub

        Public Overrides Function OnDisconnected(stopcalled As Boolean) As Task
            GetDisConnected(Context.ConnectionId)

            Return MyBase.OnDisconnected(stopcalled)
        End Function


    End Class
End Namespace


