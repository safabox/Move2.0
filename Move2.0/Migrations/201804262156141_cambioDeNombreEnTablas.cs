namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambioDeNombreEnTablas : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Cursoes", newName: "Curso");
            RenameTable(name: "dbo.Nivels", newName: "Nivel");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Nivel", newName: "Nivels");
            RenameTable(name: "dbo.Curso", newName: "Cursoes");
        }
    }
}
