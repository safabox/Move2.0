namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setOrderApprovalDateNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Order", "approvalDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Order", "approvalDate", c => c.DateTime(nullable: false));
        }
    }
}
