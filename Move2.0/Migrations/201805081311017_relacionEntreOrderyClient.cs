namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relacionEntreOrderyClient : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Payment", "OrderId", "dbo.Order");
            DropForeignKey("dbo.Payment", "ClientId", "dbo.Client");
            DropIndex("dbo.Payment", new[] { "OrderId" });
            DropIndex("dbo.Payment", new[] { "ClientId" });
            RenameColumn(table: "dbo.Payment", name: "ClientId", newName: "Client_Id");
            AddColumn("dbo.Order", "PaymentId", c => c.Int(nullable: false));
            AddColumn("dbo.Order", "ClientId", c => c.Int(nullable: false));
            AlterColumn("dbo.Payment", "Client_Id", c => c.Int());
            CreateIndex("dbo.Order", "PaymentId");
            CreateIndex("dbo.Order", "ClientId");
            CreateIndex("dbo.Payment", "Client_Id");
            AddForeignKey("dbo.Order", "ClientId", "dbo.Client", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Order", "PaymentId", "dbo.Payment", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Payment", "Client_Id", "dbo.Client", "Id");
            DropColumn("dbo.Payment", "OrderId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Payment", "OrderId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Payment", "Client_Id", "dbo.Client");
            DropForeignKey("dbo.Order", "PaymentId", "dbo.Payment");
            DropForeignKey("dbo.Order", "ClientId", "dbo.Client");
            DropIndex("dbo.Payment", new[] { "Client_Id" });
            DropIndex("dbo.Order", new[] { "ClientId" });
            DropIndex("dbo.Order", new[] { "PaymentId" });
            AlterColumn("dbo.Payment", "Client_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Order", "ClientId");
            DropColumn("dbo.Order", "PaymentId");
            RenameColumn(table: "dbo.Payment", name: "Client_Id", newName: "ClientId");
            CreateIndex("dbo.Payment", "ClientId");
            CreateIndex("dbo.Payment", "OrderId");
            AddForeignKey("dbo.Payment", "ClientId", "dbo.Client", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Payment", "OrderId", "dbo.Order", "Id", cascadeDelete: true);
        }
    }
}
