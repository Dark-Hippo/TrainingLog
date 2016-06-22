namespace TrainingLog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class logbooknullabledates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.LogBooks", "StartDate", c => c.DateTime());
            AlterColumn("dbo.LogBooks", "EndDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.LogBooks", "EndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.LogBooks", "StartDate", c => c.DateTime(nullable: false));
        }
    }
}
