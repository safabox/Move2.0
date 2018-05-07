namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addClientFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Client", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Client", "LastName", c => c.String(nullable: false));
            AddColumn("dbo.Client", "DNI", c => c.Int(nullable: false));
            AddColumn("dbo.Client", "ApplicationUserId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Client", "ApplicationUserId");
            DropColumn("dbo.Client", "DNI");
            DropColumn("dbo.Client", "LastName");
            DropColumn("dbo.Client", "Name");
        }
    }
}
