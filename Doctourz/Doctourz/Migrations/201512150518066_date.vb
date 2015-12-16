Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class _date
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AlterColumn("dbo.AppUsers", "birthDate", Function(c) c.DateTime())
        End Sub
        
        Public Overrides Sub Down()
            AlterColumn("dbo.AppUsers", "birthDate", Function(c) c.DateTime())
        End Sub
    End Class
End Namespace
