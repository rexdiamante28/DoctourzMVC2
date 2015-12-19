﻿Imports System.Security.Claims
Imports System.Threading.Tasks
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.AspNet.Identity.Owin
Imports System.Data.Entity

' You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
Public Class ApplicationUser
    Inherits IdentityUser
    Public Async Function GenerateUserIdentityAsync(manager As UserManager(Of ApplicationUser)) As Task(Of ClaimsIdentity)
        ' Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
        Dim userIdentity = Await manager.CreateIdentityAsync(Me, DefaultAuthenticationTypes.ApplicationCookie)
        ' Add custom user claims here
        Return userIdentity
    End Function
End Class

Public Class ApplicationDbContext
    Inherits IdentityDbContext(Of ApplicationUser)
    Public Sub New()
        MyBase.New("DefaultConnection", throwIfV1Schema:=False)
    End Sub

    Public Shared Function Create() As ApplicationDbContext
        Return New ApplicationDbContext()
    End Function

    Private _AppUsers As DbSet(Of AppUsers)
    Public Property AppUsers() As DbSet(Of AppUsers)
        Get
            Return _AppUsers
        End Get
        Set(ByVal value As DbSet(Of AppUsers))
            _AppUsers = value
        End Set
    End Property

    Private _Questions As DbSet(Of Questions)
    Public Property Questions() As DbSet(Of Questions)
        Get
            Return _Questions
        End Get
        Set(ByVal value As DbSet(Of Questions))
            _Questions = value
        End Set
    End Property

    Private _Ratings As DbSet(Of Ratings)
    Public Property Ratings() As DbSet(Of Ratings)
        Get
            Return _Ratings
        End Get
        Set(ByVal value As DbSet(Of Ratings))
            _Ratings = value
        End Set
    End Property

    Private _Traits As DbSet(Of Traits)
    Public Property Traits() As DbSet(Of Traits)
        Get
            Return _Traits
        End Get
        Set(ByVal value As DbSet(Of Traits))
            _Traits = value
        End Set
    End Property


End Class
