namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingRespuesta : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Respuesta (answer,preguntaid,nextquestion) values ('Tomar un curso regular por niveles',1,2)");
            Sql("Insert into Respuesta (answer,preguntaid,nextquestion) values ('Preparar un examen internacional/ Propósito específico',1,2)");
            Sql("Insert into Respuesta (answer,preguntaid,nextquestion) values ('Practicar conversación',1,2)");


            Sql("Insert into Respuesta (answer,preguntaid,nextquestion) values ('Rápido',2,3)");
            Sql("Insert into Respuesta (answer,preguntaid,nextquestion) values ('A ritmo regular',2,3)");


            Sql("Insert into Respuesta (answer,preguntaid,nextquestion) values ('Sí, no necesito ayuda estudio solo',3,null)");
            Sql("Insert into Respuesta (answer,preguntaid,nextquestion) values ('No, necesito apoyo de un profesor',3,null)");

        }
        
        public override void Down()
        {
        }
    }
}
