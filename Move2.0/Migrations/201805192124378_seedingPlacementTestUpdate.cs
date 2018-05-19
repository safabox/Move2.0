namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingPlacementTestUpdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE PreguntasTest SET Pregunta = '18. Seleccione la correcta...' WHERE Id = 18");
            Sql("UPDATE PreguntasTest SET Pregunta = '19. Seleccione la correcta...' WHERE Id = 19");
            Sql("UPDATE PreguntasTest SET Pregunta = '25. Seleccione la correcta...' WHERE Id = 25");
            Sql("UPDATE PreguntasTest SET Pregunta = '26. Seleccione la correcta...' WHERE Id = 26");
            Sql("UPDATE PreguntasTest SET Pregunta = '40. Seleccione la correcta...' WHERE Id = 40");
            Sql("UPDATE PreguntasTest SET Pregunta = '67. Seleccione la correcta...' WHERE Id = 67");
            Sql("UPDATE PreguntasTest SET Pregunta = '70. Seleccione la correcta...' WHERE Id = 70");
            Sql("UPDATE RespuestasTest SET Correcta = 1 WHERE Id = 65");
            Sql("UPDATE RespuestasTest SET Correcta = 0 WHERE Id = 284");
        }
        
        public override void Down()
        {
        }
    }
}
