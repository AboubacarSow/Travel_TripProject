﻿namespace Travel_TripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateComment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "WhenCommented", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "WhenCommented");
        }
    }
}
