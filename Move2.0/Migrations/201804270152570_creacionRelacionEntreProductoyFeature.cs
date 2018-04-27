namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creacionRelacionEntreProductoyFeature : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductoFeature",
                c => new
                    {
                        Producto_Id = c.Int(nullable: false),
                        Feature_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Producto_Id, t.Feature_Id })
                .ForeignKey("dbo.Producto", t => t.Producto_Id, cascadeDelete: true)
                .ForeignKey("dbo.Feature", t => t.Feature_Id, cascadeDelete: true)
                .Index(t => t.Producto_Id)
                .Index(t => t.Feature_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductoFeature", "Feature_Id", "dbo.Feature");
            DropForeignKey("dbo.ProductoFeature", "Producto_Id", "dbo.Producto");
            DropIndex("dbo.ProductoFeature", new[] { "Feature_Id" });
            DropIndex("dbo.ProductoFeature", new[] { "Producto_Id" });
            DropTable("dbo.ProductoFeature");
        }
    }
}
