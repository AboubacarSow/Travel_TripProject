﻿namespace Travel_TripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateContact : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "IsRead", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "IsRead");
        }
    }
}
