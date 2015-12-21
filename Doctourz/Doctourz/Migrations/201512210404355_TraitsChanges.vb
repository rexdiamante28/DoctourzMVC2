Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class TraitsChanges
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.Questions", "traits_traitId", "dbo.Traits")
            DropForeignKey("dbo.Ratings", "applicationUser_Id", "dbo.AspNetUsers")
            DropIndex("dbo.Questions", New String() { "traits_traitId" })
            DropIndex("dbo.Ratings", New String() { "applicationUser_Id" })
            CreateTable(
                "dbo.Affiliations",
                Function(c) New With
                    {
                        .affiliationId = c.Int(nullable := False, identity := True),
                        .name = c.String(),
                        .description = c.String(),
                        .userId = c.String(maxLength := 128)
                    }) _
                .PrimaryKey(Function(t) t.affiliationId) _
                .ForeignKey("dbo.AppUsers", Function(t) t.userId) _
                .Index(Function(t) t.userId)
            
            CreateTable(
                "dbo.Educations",
                Function(c) New With
                    {
                        .educationId = c.Int(nullable := False, identity := True),
                        .schoolName = c.String(),
                        .NewProperty = c.DateTime(nullable := False),
                        .degree = c.String(),
                        .userId = c.String(maxLength := 128)
                    }) _
                .PrimaryKey(Function(t) t.educationId) _
                .ForeignKey("dbo.AppUsers", Function(t) t.userId) _
                .Index(Function(t) t.userId)
            
            CreateTable(
                "dbo.Procedures",
                Function(c) New With
                    {
                        .proceduresId = c.Int(nullable := False, identity := True),
                        .name = c.String(),
                        .description = c.String(),
                        .userId = c.String(maxLength := 128)
                    }) _
                .PrimaryKey(Function(t) t.proceduresId) _
                .ForeignKey("dbo.AppUsers", Function(t) t.userId) _
                .Index(Function(t) t.userId)
            
            CreateTable(
                "dbo.Specializations",
                Function(c) New With
                    {
                        .NewProperty = c.Int(nullable := False, identity := True),
                        .name = c.String(),
                        .description = c.String(),
                        .userId = c.String(maxLength := 128)
                    }) _
                .PrimaryKey(Function(t) t.NewProperty) _
                .ForeignKey("dbo.AppUsers", Function(t) t.userId) _
                .Index(Function(t) t.userId)
            
            CreateTable(
                "dbo.SubSpecializations",
                Function(c) New With
                    {
                        .subSpecId = c.Int(nullable := False, identity := True),
                        .name = c.String(),
                        .description = c.String(),
                        .specializationId = c.Int(nullable := False),
                        .Specialization_NewProperty = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.subSpecId) _
                .ForeignKey("dbo.Specializations", Function(t) t.Specialization_NewProperty) _
                .Index(Function(t) t.Specialization_NewProperty)
            
            CreateTable(
                "dbo.Trainings",
                Function(c) New With
                    {
                        .training = c.Int(nullable := False, identity := True),
                        .name = c.String(),
                        .dateAttended = c.DateTime(nullable := False),
                        .userId = c.String(maxLength := 128)
                    }) _
                .PrimaryKey(Function(t) t.training) _
                .ForeignKey("dbo.AppUsers", Function(t) t.userId) _
                .Index(Function(t) t.userId)
            
            DropTable("dbo.Questions")
            DropTable("dbo.Traits")
            DropTable("dbo.Ratings")
        End Sub
        
        Public Overrides Sub Down()
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
                .PrimaryKey(Function(t) t.ratingsId)
            
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
                "dbo.Questions",
                Function(c) New With
                    {
                        .questionId = c.Int(nullable := False, identity := True),
                        .question = c.String(),
                        .isNegative = c.Boolean(nullable := False),
                        .traitId = c.String(),
                        .traits_traitId = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.questionId)
            
            DropForeignKey("dbo.Trainings", "userId", "dbo.AppUsers")
            DropForeignKey("dbo.SubSpecializations", "Specialization_NewProperty", "dbo.Specializations")
            DropForeignKey("dbo.Specializations", "userId", "dbo.AppUsers")
            DropForeignKey("dbo.Procedures", "userId", "dbo.AppUsers")
            DropForeignKey("dbo.Educations", "userId", "dbo.AppUsers")
            DropForeignKey("dbo.Affiliations", "userId", "dbo.AppUsers")
            DropIndex("dbo.Trainings", New String() { "userId" })
            DropIndex("dbo.SubSpecializations", New String() { "Specialization_NewProperty" })
            DropIndex("dbo.Specializations", New String() { "userId" })
            DropIndex("dbo.Procedures", New String() { "userId" })
            DropIndex("dbo.Educations", New String() { "userId" })
            DropIndex("dbo.Affiliations", New String() { "userId" })
            DropTable("dbo.Trainings")
            DropTable("dbo.SubSpecializations")
            DropTable("dbo.Specializations")
            DropTable("dbo.Procedures")
            DropTable("dbo.Educations")
            DropTable("dbo.Affiliations")
            CreateIndex("dbo.Ratings", "applicationUser_Id")
            CreateIndex("dbo.Questions", "traits_traitId")
            AddForeignKey("dbo.Ratings", "applicationUser_Id", "dbo.AspNetUsers", "Id")
            AddForeignKey("dbo.Questions", "traits_traitId", "dbo.Traits", "traitId")
        End Sub
    End Class
End Namespace
