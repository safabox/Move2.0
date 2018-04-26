namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingPregunta : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Pregunta (question) values ('¿Por qué querés estudiar inglés?')");
            Sql("Insert into Pregunta (question) values ('¿A qué velocidad querés aprender?')");
            Sql("Insert into Pregunta (question) values ('¿Sos autodidacta?')");
        }
        
        public override void Down()
        {
        }
    }
}
