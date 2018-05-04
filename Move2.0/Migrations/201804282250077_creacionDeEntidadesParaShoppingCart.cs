namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creacionDeEntidadesParaShoppingCart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShoppingCart",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationUserId = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationUserId = c.String(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        approvalDate = c.DateTime(nullable: false),
                        OrderStatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrderStatus", t => t.OrderStatusId, cascadeDelete: true)
                .Index(t => t.OrderStatusId);
            
            CreateTable(
                "dbo.OrderItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Double(nullable: false),
                        Description = c.String(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Order_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Order", t => t.Order_Id)
                .Index(t => t.Order_Id);
            
            CreateTable(
                "dbo.OrderStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        PaymentStatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Client", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Order", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.PaymentStatus", t => t.PaymentStatusId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.ClientId)
                .Index(t => t.PaymentStatusId);
            
            CreateTable(
                "dbo.PaymentStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShoppingCartProducto",
                c => new
                    {
                        ShoppingCart_Id = c.Int(nullable: false),
                        Producto_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ShoppingCart_Id, t.Producto_Id })
                .ForeignKey("dbo.ShoppingCart", t => t.ShoppingCart_Id, cascadeDelete: true)
                .ForeignKey("dbo.Producto", t => t.Producto_Id, cascadeDelete: true)
                .Index(t => t.ShoppingCart_Id)
                .Index(t => t.Producto_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payment", "PaymentStatusId", "dbo.PaymentStatus");
            DropForeignKey("dbo.Payment", "OrderId", "dbo.Order");
            DropForeignKey("dbo.Payment", "ClientId", "dbo.Client");
            DropForeignKey("dbo.Order", "OrderStatusId", "dbo.OrderStatus");
            DropForeignKey("dbo.OrderItem", "Order_Id", "dbo.Order");
            DropForeignKey("dbo.ShoppingCartProducto", "Producto_Id", "dbo.Producto");
            DropForeignKey("dbo.ShoppingCartProducto", "ShoppingCart_Id", "dbo.ShoppingCart");
            DropIndex("dbo.ShoppingCartProducto", new[] { "Producto_Id" });
            DropIndex("dbo.ShoppingCartProducto", new[] { "ShoppingCart_Id" });
            DropIndex("dbo.Payment", new[] { "PaymentStatusId" });
            DropIndex("dbo.Payment", new[] { "ClientId" });
            DropIndex("dbo.Payment", new[] { "OrderId" });
            DropIndex("dbo.OrderItem", new[] { "Order_Id" });
            DropIndex("dbo.Order", new[] { "OrderStatusId" });
            DropTable("dbo.ShoppingCartProducto");
            DropTable("dbo.PaymentStatus");
            DropTable("dbo.Payment");
            DropTable("dbo.OrderStatus");
            DropTable("dbo.OrderItem");
            DropTable("dbo.Order");
            DropTable("dbo.ShoppingCart");
            DropTable("dbo.Client");
        }
    }
}
