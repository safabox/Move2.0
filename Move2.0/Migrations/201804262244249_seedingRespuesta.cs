namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingRespuesta : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Respuesta (answer,preguntaid,nextquestion) values ('Tomar un curso regular por niveles',1,2)");
            Sql("Insert into Respuesta (answer,preguntaid,nextquestion) values ('Preparar un examen internacional/ Prop�sito espec�fico',1,2)");
            Sql("Insert into Respuesta (answer,preguntaid,nextquestion) values ('Practicar conversaci�n',1,2)");


            Sql("Insert into Respuesta (answer,preguntaid,nextquestion) values ('R�pido',2,3)");
            Sql("Insert into Respuesta (answer,preguntaid,nextquestion) values ('A ritmo regular',2,3)");


            Sql("Insert into Respuesta (answer,preguntaid,nextquestion) values ('S�, no necesito ayuda estudio solo',3,null)");
            Sql("Insert into Respuesta (answer,preguntaid,nextquestion) values ('No, necesito apoyo de un profesor',3,null)");

        }
        
        public override void Down()
        {
        }
    }
}
