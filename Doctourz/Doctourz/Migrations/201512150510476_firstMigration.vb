Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class firstMigration
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AlterColumn("dbo.AppUsers", "gender", Function(c) c.String())
            AlterColumn("dbo.AppUsers", "civilStatus", Function(c) c.String())
            AlterColumn("dbo.AppUsers", "ethnicity", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            AlterColumn("dbo.AppUsers", "ethnicity", Function(c) c.String(nullable := False))
            AlterColumn("dbo.AppUsers", "civilStatus", Function(c) c.String(nullable := False))
            AlterColumn("dbo.AppUsers", "gender", Function(c) c.String(nullable := False))
        End Sub
    End Class
End Namespace
