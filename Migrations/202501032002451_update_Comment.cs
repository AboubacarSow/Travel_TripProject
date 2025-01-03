namespace Travel_TripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_Comment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "IsRead", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "IsRead");
        }
    }
}
