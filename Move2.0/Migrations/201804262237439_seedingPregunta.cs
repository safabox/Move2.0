namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingPregunta : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Pregunta (question) values ('�Por qu� quer�s estudiar ingl�s?')");
            Sql("Insert into Pregunta (question) values ('�A qu� velocidad quer�s aprender?')");
            Sql("Insert into Pregunta (question) values ('�Sos autodidacta?')");
        }
        
        public override void Down()
        {
        }
    }
}
