Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class RegisterChanges
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Questions",
                Function(c) New With
                    {
                        .questionId = c.Int(nullable:=False, identity:=True),
                        .question = c.String(),
                        .isNegative = c.Boolean(nullable:=False),
                        .traitId = c.String(),
                        .traits_traitId = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.questionId) _
                .ForeignKey("dbo.Traits", Function(t) t.traits_traitId) _
            .Index(Function(t) t.traits_traitId)
            
            CreateTable(
                "dbo.Traits",
                Function(c) New With
                    {
                        .traitId = c.Int(nullable := False, identity := True),
                        .trait = c.String(),
                        .description = c.String(),
                        .color = c.String()
                    }) _
                .PrimaryKey(Function(t) t.traitId)
            
            CreateTable(
                "dbo.Ratings",
                Function(c) New With
                    {
                        .ratingsId = c.Int(nullable := False, identity := True),
                        .score = c.Int(nullable := False),
                        .traitId = c.Int(nullable := False),
                        .NewProperty = c.String(),
                        .applicationUser_Id = c.String(maxLength := 128)
                    }) _
                .PrimaryKey(Function(t) t.ratingsId) _
                .ForeignKey("dbo.AspNetUsers", Function(t) t.applicationUser_Id) _
                .Index(Function(t) t.applicationUser_Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Ratings", "applicationUser_Id", "dbo.AspNetUsers")
            DropForeignKey("dbo.Questions", "traits_traitId", "dbo.Traits")
            DropIndex("dbo.Ratings", New String() { "applicationUser_Id" })
            DropIndex("dbo.Questions", New String() { "traits_traitId" })
            DropTable("dbo.Ratings")
            DropTable("dbo.Traits")
            DropTable("dbo.Questions")
        End Sub
    End Class
End Namespace
