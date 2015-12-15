Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialCreate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.AppUsers",
                Function(c) New With
                    {
                        .userId = c.String(nullable := False, maxLength := 128),
                        .userName = c.String(nullable := False),
                        .email = c.String(nullable := False),
                        .level = c.String(),
                        .firstName = c.String(nullable := False),
                        .lastName = c.String(nullable := False),
                        .name = c.String(),
                        .gender = c.String(nullable := False),
                        .civilStatus = c.String(nullable := False),
                        .birthDate = c.DateTime(nullable := False),
                        .ethnicity = c.String(nullable := False),
                        .height = c.String(),
                        .weight = c.String(),
                        .bmi = c.String(),
                        .diet = c.String(),
                        .alcohol = c.String(),
                        .tobacco = c.String(),
                        .sexual = c.String(),
                        .recreationalDrugs = c.String(),
                        .mobile = c.String(),
                        .telephone = c.String(),
                        .location = c.String(),
                        .address1 = c.String(),
                        .address2 = c.String(),
                        .city = c.String(),
                        .state = c.String(),
                        .country = c.String(),
                        .zip = c.String(),
                        .avatar = c.String(),
                        .isPublic = c.Boolean(nullable := False),
                        .applicationUser_Id = c.String(maxLength := 128)
                    }) _
                .PrimaryKey(Function(t) t.userId) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.applicationUser_Id) _
                .Index(Function(t) t.applicationUser_Id)
            
            CreateTable(
                "dbo.AspNetUsers",
                Function(c) New With
                    {
                        .Id = c.String(nullable := False, maxLength := 128),
                        .Email = c.String(maxLength := 256),
                        .EmailConfirmed = c.Boolean(nullable := False),
                        .PasswordHash = c.String(),
                        .SecurityStamp = c.String(),
                        .PhoneNumber = c.String(),
                        .PhoneNumberConfirmed = c.Boolean(nullable := False),
                        .TwoFactorEnabled = c.Boolean(nullable := False),
                        .LockoutEndDateUtc = c.DateTime(),
                        .LockoutEnabled = c.Boolean(nullable := False),
                        .AccessFailedCount = c.Int(nullable := False),
                        .UserName = c.String(nullable := False, maxLength := 256)
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .Index(Function(t) t.UserName, unique := True, name := "UserNameIndex")
            
            CreateTable(
                "dbo.AspNetUserClaims",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .UserId = c.String(nullable := False, maxLength := 128),
                        .ClaimType = c.String(),
                        .ClaimValue = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.UserId, cascadeDelete := True) _
                .Index(Function(t) t.UserId)
            
            CreateTable(
                "dbo.AspNetUserLogins",
                Function(c) New With
                    {
                        .LoginProvider = c.String(nullable := False, maxLength := 128),
                        .ProviderKey = c.String(nullable := False, maxLength := 128),
                        .UserId = c.String(nullable := False, maxLength := 128)
                    }) _
                .PrimaryKey(Function(t) New With { t.LoginProvider, t.ProviderKey, t.UserId }) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.UserId, cascadeDelete := True) _
                .Index(Function(t) t.UserId)
            
            CreateTable(
                "dbo.AspNetUserRoles",
                Function(c) New With
                    {
                        .UserId = c.String(nullable := False, maxLength := 128),
                        .RoleId = c.String(nullable := False, maxLength := 128)
                    }) _
                .PrimaryKey(Function(t) New With { t.UserId, t.RoleId }) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.UserId, cascadeDelete := True) _
                .ForeignKey("dbo.AspNetRoles", Function(t) t.RoleId, cascadeDelete := True) _
                .Index(Function(t) t.UserId) _
                .Index(Function(t) t.RoleId)
            
            CreateTable(
                "dbo.Clinics",
                Function(c) New With
                    {
                        .clinicId = c.Int(nullable := False, identity := True),
                        .name = c.String(),
                        .address = c.String(),
                        .mobile = c.String(),
                        .landline = c.String(),
                        .country = c.String(),
                        .writeUp = c.String(),
                        .history = c.String(),
                        .AppUsers_userId = c.String(maxLength := 128)
                    }) _
                .PrimaryKey(Function(t) t.clinicId) _
                .ForeignKey("dbo.AppUsers", Function(t) t.AppUsers_userId) _
                .Index(Function(t) t.AppUsers_userId)
            
            CreateTable(
                "dbo.AspNetRoles",
                Function(c) New With
                    {
                        .Id = c.String(nullable := False, maxLength := 128),
                        .Name = c.String(nullable := False, maxLength := 256)
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .Index(Function(t) t.Name, unique := True, name := "RoleNameIndex")
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles")
            DropForeignKey("dbo.Clinics", "AppUsers_userId", "dbo.AppUsers")
            DropForeignKey("dbo.AppUsers", "applicationUser_Id", "dbo.AspNetUsers")
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers")
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers")
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers")
            DropIndex("dbo.AspNetRoles", "RoleNameIndex")
            DropIndex("dbo.Clinics", New String() { "AppUsers_userId" })
            DropIndex("dbo.AspNetUserRoles", New String() { "RoleId" })
            DropIndex("dbo.AspNetUserRoles", New String() { "UserId" })
            DropIndex("dbo.AspNetUserLogins", New String() { "UserId" })
            DropIndex("dbo.AspNetUserClaims", New String() { "UserId" })
            DropIndex("dbo.AspNetUsers", "UserNameIndex")
            DropIndex("dbo.AppUsers", New String() { "applicationUser_Id" })
            DropTable("dbo.AspNetRoles")
            DropTable("dbo.Clinics")
            DropTable("dbo.AspNetUserRoles")
            DropTable("dbo.AspNetUserLogins")
            DropTable("dbo.AspNetUserClaims")
            DropTable("dbo.AspNetUsers")
            DropTable("dbo.AppUsers")
        End Sub
    End Class
End Namespace
