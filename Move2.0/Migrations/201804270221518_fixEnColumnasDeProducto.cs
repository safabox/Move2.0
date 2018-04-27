namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixEnColumnasDeProducto : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Producto", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Producto", "Summary", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Producto", "Summary", c => c.String(nullable: false));
            AlterColumn("dbo.Producto", "Description", c => c.Double(nullable: false));
        }
    }
}
