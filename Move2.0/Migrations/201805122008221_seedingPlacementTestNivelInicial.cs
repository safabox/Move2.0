namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class seedingPlacementTestNivelInicial : DbMigration
    {
        public override void Up()
        {
            #region Preguntas Nivel Inicial 
            Sql("SET IdENTITY_INSERT PreguntasTest ON");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (1,1,'1. How old are you?',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (2,1,'2. Do you live in Buenos Aires?',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (3,1,'3. ¿Cuál de las siguientes Preguntas es la Correcta para la Respuesta \"They’re from Italy\"?',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (4,1,'4. Are you Mr Norton’s assistant?',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (5,1,'5. ¿Cuál de las siguientes Preguntas es Correcta para la Respuesta \"I’m a secretary\"?',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (6,1,'6. ¿Cuál de las siguientes Preguntas es Correcta para la Respuesta \"He’s an architect.\"?',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (7,1,'7. I have pilates class ...',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (8,1,'8. My best friend ..... to pubs every night.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (9,1,'9. How ..... does one class cost?',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (10,1,'10. ¿Cuál de las siguientes Preguntas es Correcta para Preguntar de qué nacionalidad es una persona?',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (11,1,'11. ¿Cuál de las siguientes opciones es Correcta?',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (12,1,'12. ¿Cuál de las siguientes opciones es Correcta para ofrecer una bebida?',0,0)");
            Sql("SET IdENTITY_INSERT PreguntasTest OFF");
            #endregion

            #region Respuestas Nivel Inicial
            Sql("SET IdENTITY_INSERT RespuestasTest ON");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (1,1,'I have 31 years old',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (2,1,'I am 31 years old',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (3,1,'No, I''m not old',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (4,1,'I have 31 years',0)");

            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (5,2,'Yes, I live',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (6,2,'Yes, I do',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (7,2,'Yes, I am',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (8,2,'Yes, I does',0)");

            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (9,3,'Where are you from?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (10,3,'Where are they of?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (11,3,'Where is they from?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (12,3,'Where are they from?',1)");

            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (13,4,'No, I aren''t',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (14,4,'No, I don''t',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (15,4,'No, I am not',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (16,4,'No, am not',0)");

            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (17,5,'What are you do?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (18,5,'What you do?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (19,5,'What are you doing?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (20,5,'What do you do?',1)");

            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (21,6,'What his job?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (22,6,'What''s his job?',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (23,6,'What''s he job?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (24,6,'What do he job?',0)");

            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (25,7,'on Tuesdays',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (26,7,'the Tuesdays',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (27,7,'in Tuesdays',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (28,7,'at Tuesdays',0)");

            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (29,8,'gos',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (30,8,'go',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (31,8,'goed',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (32,8,'goes',1)");

            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (33,9,'is',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (34,9,'many',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (35,9,'big',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (36,9,'much',1)");

            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (37,10,'What is your nationality?',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (38,10,'What nationality are you?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (39,10,'What is your country?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (40,10,'',0)");

            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (41,11,'He live in Madrid',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (42,11,'He''s lives in Madrid',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (43,11,'He lives in Madrid',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (44,11,'He is live in Madrid',0)");

            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (45,12,'What you like to drink?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (46,12,'What would you like to drink?',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (47,12,'What would you like drinking?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (48,12,'',0)");

            Sql("DELETE FROM RespuestasTest WHERE Id in (48,40)");
            Sql("SET IdENTITY_INSERT RespuestasTest OFF");
            #endregion
        }

        public override void Down()
        {
        }
    }
}
