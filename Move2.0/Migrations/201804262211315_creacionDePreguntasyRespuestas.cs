namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creacionDePreguntasyRespuestas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pregunta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Question = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Respuesta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Answer = c.String(nullable: false),
                        PreguntaId = c.Int(nullable: false),
                        NextQuestion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pregunta", t => t.PreguntaId, cascadeDelete: true)
                .Index(t => t.PreguntaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Respuesta", "PreguntaId", "dbo.Pregunta");
            DropIndex("dbo.Respuesta", new[] { "PreguntaId" });
            DropTable("dbo.Respuesta");
            DropTable("dbo.Pregunta");
        }
    }
}
