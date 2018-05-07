namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatesPaymentDatesInformation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Payment", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Payment", "ApprovalDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Payment", "LastUpdatedTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Payment", "MercadoPagoId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Payment", "MercadoPagoId");
            DropColumn("dbo.Payment", "LastUpdatedTime");
            DropColumn("dbo.Payment", "ApprovalDate");
            DropColumn("dbo.Payment", "DateCreated");
        }
    }
}
