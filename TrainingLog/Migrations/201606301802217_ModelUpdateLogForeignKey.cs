namespace TrainingLog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelUpdateLogForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Logs", "LogBook_Id", "dbo.LogBooks");
            DropIndex("dbo.Logs", new[] { "LogBook_Id" });
            RenameColumn(table: "dbo.Logs", name: "LogBook_Id", newName: "LogBookId");
            AlterColumn("dbo.Logs", "LogBookId", c => c.Int(nullable: false));
            CreateIndex("dbo.Logs", "LogBookId");
            AddForeignKey("dbo.Logs", "LogBookId", "dbo.LogBooks", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Logs", "LogBookId", "dbo.LogBooks");
            DropIndex("dbo.Logs", new[] { "LogBookId" });
            AlterColumn("dbo.Logs", "LogBookId", c => c.Int());
            RenameColumn(table: "dbo.Logs", name: "LogBookId", newName: "LogBook_Id");
            CreateIndex("dbo.Logs", "LogBook_Id");
            AddForeignKey("dbo.Logs", "LogBook_Id", "dbo.LogBooks", "Id");
        }
    }
}
