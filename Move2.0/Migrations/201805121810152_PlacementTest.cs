namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlacementTest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NivelTest",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Numero = c.Int(nullable: false),
                        CantidadRespuestasIncorrectas = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlacementTest",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Mail = c.String(nullable: false),
                        Nivel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PreguntasTest",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pregunta = c.String(nullable: false),
                        CantidadOk = c.Int(nullable: false),
                        CantidadNoOk = c.Int(nullable: false),
                        NivelTestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NivelTest", t => t.NivelTestId, cascadeDelete: true)
                .Index(t => t.NivelTestId);
            
            CreateTable(
                "dbo.RespuestasTest",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Respuesta = c.String(nullable: false),
                        Correcta = c.Boolean(nullable: false),
                        PregunstasTestId = c.Int(nullable: false),
                        PreguntasTest_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PreguntasTest", t => t.PreguntasTest_Id)
                .Index(t => t.PreguntasTest_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RespuestasTest", "PreguntasTest_Id", "dbo.PreguntasTest");
            DropForeignKey("dbo.PreguntasTest", "NivelTestId", "dbo.NivelTest");
            DropIndex("dbo.RespuestasTest", new[] { "PreguntasTest_Id" });
            DropIndex("dbo.PreguntasTest", new[] { "NivelTestId" });
            DropTable("dbo.RespuestasTest");
            DropTable("dbo.PreguntasTest");
            DropTable("dbo.PlacementTest");
            DropTable("dbo.NivelTest");
        }
    }
}
