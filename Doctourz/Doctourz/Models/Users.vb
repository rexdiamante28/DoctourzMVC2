
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace opentokRTC.Models
    Public Class User
        Public Property ConnectionId() As String
            Get
                Return m_ConnectionId
            End Get
            Set(value As String)
                m_ConnectionId = Value
            End Set
        End Property
        Private m_ConnectionId As String
        Public Property Name() As String
            Get
                Return m_Name
            End Get
            Set(value As String)
                m_Name = Value
            End Set
        End Property
        Private m_Name As String
        Public Property Opentok() As openTok
            Get
                Return m_Opentok
            End Get
            Set(value As openTok)
                m_Opentok = Value
            End Set
        End Property
        Private m_Opentok As openTok
        Public Sub New()
            Me.Name = ""
        End Sub
        Public Sub New(name As String, connectionId As String, opentok As openTok)
            Me.Name = name

            Me.ConnectionId = connectionId

            Me.Opentok = opentok
        End Sub
    End Class

End Namespace
