namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creacionEntidadesProductoyFeature : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Feature",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Tooltip = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.Double(nullable: false),
                        Price = c.Double(nullable: false),
                        StartingDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Summary = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Producto");
            DropTable("dbo.Feature");
        }
    }
}
