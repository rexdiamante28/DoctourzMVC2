Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Public Class Notes
    Private _notesId As Integer
    <Key>
   <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property notesId() As Integer
        Get
            Return _notesId
        End Get
        Set(ByVal value As Integer)
            _notesId = value
        End Set
    End Property

    Private _ownerName As String
    Public Property ownerName() As String
        Get
            Return _ownerName
        End Get
        Set(ByVal value As String)
            _ownerName = value
        End Set
    End Property

    Private _message As String
    Public Property message() As String
        Get
            Return _message
        End Get
        Set(ByVal value As String)
            _message = value
        End Set
    End Property

    <DataType(DataType.DateTime)>
    Private _dateSent As DateTime
    Public Property dateSent() As DateTime
        Get
            Return _dateSent
        End Get
        Set(ByVal value As DateTime)
            _dateSent = value
        End Set
    End Property



End Class
