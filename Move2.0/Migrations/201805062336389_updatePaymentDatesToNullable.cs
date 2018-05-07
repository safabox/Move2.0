namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePaymentDatesToNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Payment", "ApprovalDate", c => c.DateTime());
            AlterColumn("dbo.Payment", "LastUpdatedTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Payment", "LastUpdatedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Payment", "ApprovalDate", c => c.DateTime(nullable: false));
        }
    }
}
