namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreacionDeNivelesyCursosRelacion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cursoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        MoodleID = c.Int(nullable: false),
                        NivelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Nivels", t => t.NivelId, cascadeDelete: true)
                .Index(t => t.NivelId);
            
            CreateTable(
                "dbo.Nivels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cursoes", "NivelId", "dbo.Nivels");
            DropIndex("dbo.Cursoes", new[] { "NivelId" });
            DropTable("dbo.Nivels");
            DropTable("dbo.Cursoes");
        }
    }
}
