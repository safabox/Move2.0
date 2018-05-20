namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlacementTestCorreccion : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RespuestasTest", "PreguntasTest_Id", "dbo.PreguntasTest");
            DropIndex("dbo.RespuestasTest", new[] { "PreguntasTest_Id" });
            RenameColumn(table: "dbo.RespuestasTest", name: "PreguntasTest_Id", newName: "PreguntasTestId");
            AlterColumn("dbo.RespuestasTest", "PreguntasTestId", c => c.Int(nullable: false));
            CreateIndex("dbo.RespuestasTest", "PreguntasTestId");
            AddForeignKey("dbo.RespuestasTest", "PreguntasTestId", "dbo.PreguntasTest", "Id", cascadeDelete: true);
            DropColumn("dbo.RespuestasTest", "PregunstasTestId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RespuestasTest", "PregunstasTestId", c => c.Int(nullable: false));
            DropForeignKey("dbo.RespuestasTest", "PreguntasTestId", "dbo.PreguntasTest");
            DropIndex("dbo.RespuestasTest", new[] { "PreguntasTestId" });
            AlterColumn("dbo.RespuestasTest", "PreguntasTestId", c => c.Int());
            RenameColumn(table: "dbo.RespuestasTest", name: "PreguntasTestId", newName: "PreguntasTest_Id");
            CreateIndex("dbo.RespuestasTest", "PreguntasTest_Id");
            AddForeignKey("dbo.RespuestasTest", "PreguntasTest_Id", "dbo.PreguntasTest", "Id");
        }
    }
}
