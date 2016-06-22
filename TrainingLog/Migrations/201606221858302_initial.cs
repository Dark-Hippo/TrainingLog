namespace TrainingLog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exercises",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExerciseTypeId = c.Int(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        LastUpdated = c.DateTime(nullable: false),
                        Log_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExerciseTypes", t => t.ExerciseTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Logs", t => t.Log_Id)
                .Index(t => t.ExerciseTypeId)
                .Index(t => t.Log_Id);
            
            CreateTable(
                "dbo.ExerciseTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DateAdded = c.DateTime(nullable: false),
                        LastUpdated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Reps = c.Int(nullable: false),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateAdded = c.DateTime(nullable: false),
                        LastUpdated = c.DateTime(nullable: false),
                        Exercise_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Exercises", t => t.Exercise_Id)
                .Index(t => t.Exercise_Id);
            
            CreateTable(
                "dbo.LogBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        LastUpdated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        LastUpdated = c.DateTime(nullable: false),
                        LogBook_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LogBooks", t => t.LogBook_Id)
                .Index(t => t.LogBook_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Logs", "LogBook_Id", "dbo.LogBooks");
            DropForeignKey("dbo.Exercises", "Log_Id", "dbo.Logs");
            DropForeignKey("dbo.Sets", "Exercise_Id", "dbo.Exercises");
            DropForeignKey("dbo.Exercises", "ExerciseTypeId", "dbo.ExerciseTypes");
            DropIndex("dbo.Logs", new[] { "LogBook_Id" });
            DropIndex("dbo.Sets", new[] { "Exercise_Id" });
            DropIndex("dbo.Exercises", new[] { "Log_Id" });
            DropIndex("dbo.Exercises", new[] { "ExerciseTypeId" });
            DropTable("dbo.Logs");
            DropTable("dbo.LogBooks");
            DropTable("dbo.Sets");
            DropTable("dbo.ExerciseTypes");
            DropTable("dbo.Exercises");
        }
    }
}
