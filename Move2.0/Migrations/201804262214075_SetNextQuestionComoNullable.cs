namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNextQuestionComoNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Respuesta", "NextQuestion", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Respuesta", "NextQuestion", c => c.Int(nullable: false));
        }
    }
}
