namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingNivel : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Nivel (name,description) values ('Inicial','No estudie o necesito recomenzar de cero')");
            Sql("Insert into Nivel (name,description) values ('Elemental','Tengo conocimientos básicos')");
            Sql("Insert into Nivel (name,description) values ('Pre Intermedio','Puedo entender y escribir pero no hablar')");
            Sql("Insert into Nivel (name,description) values ('Intermedio','Puedo hablar muy poco')");
            Sql("Insert into Nivel (name,description) values ('Intermedio Alto','Puedo hablar pero falta fluidez y vocabulario')");
            Sql("Insert into Nivel (name,description) values ('Avanzado','Necesito practicar conversación y mejorar fluidez')");
        }
        
        public override void Down()
        {
        }
    }
}
