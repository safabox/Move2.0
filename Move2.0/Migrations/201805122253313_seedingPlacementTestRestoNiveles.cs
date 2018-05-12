namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingPlacementTestRestoNiveles : DbMigration
    {
        public override void Up()
        {
            #region Preguntas Nivel Elemental 
            Sql("SET IdENTITY_INSERT PreguntasTest ON");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (13,2,'13. I haven''t got ..... ',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (14,2,'14. ..... orange juice in the glass.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (15,2,'15. He goes to work.....',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (16,2,'16. Which sentence is correct?',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (17,2,'17. We haven''t got ..... mineral water.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (18,2,'18.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (19,2,'19.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (20,2,'20. Mark ..... fly to London tomorrow.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (21,2,'21. Jenny lives ..... France.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (22,2,'22. John is the manager, you need to speak to .....',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (23,2,'23. I wanted a purple bike but they only had .....',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (24,2,'24. He ..... breakfast yesterday.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (25,2,'25.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (26,2,'26.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (27,2,'27. I have to go to the bank ..... some money.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (28,2,'28. The room was empty. There ..... there.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (29,2,'29. Which of the following options means \"in any place\"? I''ve lost my keys. I can''t find them .....',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (30,2,'30. We can''t get there by 3:00 pm. There is ..... time.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (31,2,'31. He arrived ..... Heathrow airport on FrIday',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (32,2,'32. ..... is it from Barcelona to MadrId?',0,0)");
            Sql("SET IdENTITY_INSERT PreguntasTest OFF");
            #endregion

            #region Respuestas Nivel Elemental 
            Sql("SET IdENTITY_INSERT RespuestasTest ON");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (49,13,'A. no money.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (50,13,'B. lot of money.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (51,13,'C. any money.',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (52,13,'D. some money.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (53,14,'A. There isn''t no',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (54,14,'B. There is any',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (55,14,'C. There isn''t any',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (56,14,'D. There aren''t no',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (57,15,'A. by taxi.',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (58,15,'B. on taxi.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (59,15,'C. with taxi.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (60,15,'D. in taxi.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (61,16,'A. He wakes up at 9:00 always',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (62,16,'B. He wakes up at always 9:00',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (63,16,'C. He always wakes up at 9:00',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (64,16,'D. He wakes always up at 9:00',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (65,17,'A. a lot',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (66,17,'B. little',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (67,17,'C. too',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (68,17,'D. much',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (69,18,'A. Where playing Manchester United?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (70,18,'B. Where is playing Manchester United?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (71,18,'C. Where is Manchester United playing?',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (72,18,'D. Where playing is Manchester United?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (73,19,'A. What''s like the weather?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (74,19,'B. How''s the weather like?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (75,19,'C. What''s the weather like?',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (76,19,'D. How the weather is?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (77,20,'A. going to',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (78,20,'B. goes to',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (79,20,'C. is going to',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (80,20,'D. go to',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (81,21,'A. at',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (82,21,'B. in',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (83,21,'C. on',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (84,21,'D. in the',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (85,22,'A. it.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (86,22,'B. him.',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (87,22,'C. her.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (88,22,'D. you.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (89,23,'A. a one green.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (90,23,'B. one green.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (91,23,'C. a green one.',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (92,23,'D. a green.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (93,24,'A. hadn''t',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (94,24,'B. no had',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (95,24,'C. dIdn''t have got',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (96,24,'D. dIdn''t have',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (97,25,'A. Give the Joan money.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (98,25,'B. Give the money to Joan.',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (99,25,'C. Give to Joan the money.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (100,25,'D. Give the money at Joan.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (101,26,'A. Mary usually drives carefully.',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (102,26,'B. Mary carefully drives usually.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (103,26,'C. Mary carefully usually drives.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (104,26,'D. Mary usually carefully drives.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (105,27,'A. for getting',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (106,27,'B. to get',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (107,27,'C. to getting',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (108,27,'D. for to get',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (109,28,'A. wasn''t nobody',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (110,28,'B. was anybody',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (111,28,'C. was nobody',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (112,28,'D. was somebody',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (114,29,'A. anywhere.',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (115,29,'B. nowhere.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (116,29,'C. nothing.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (117,29,'D. somewhere.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (118,30,'A. few',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (119,30,'B. too little',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (120,30,'C. a few',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (121,30,'D. too few',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (122,31,'A. in',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (123,31,'B. at',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (124,31,'C. on',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (125,31,'D. by',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (126,32,'A. How far',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (127,32,'B. How long',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (128,32,'C. How much',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (129,32,'D. How many',0)");
            Sql("SET IdENTITY_INSERT RespuestasTest OFF");
            #endregion

            #region Preguntas Nivel Pre-Intermedio 
            Sql("SET IdENTITY_INSERT PreguntasTest ON");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (33,3,'33. I haven''t had lunch with my mother ..... more than a year.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (34,3,'34. There ..... spectators at the match.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (35,3,'35. The kitchen can''t be dirty he .....',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (36,3,'36. I''m looking forward …. from you.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (37,3,'37. Don''t start .....',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (38,3,'38. He works at the theatre, ..... ?',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (39,3,'39. Simon ..... in MadrId since 1982.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (40,3,'40.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (41,3,'41. Mr. Brown hasn''t arrived .....',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (42,3,'42. Which of the following options is correct to illustrate an improbable situation? If I won the lottery, I ..... a house in the country.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (43,3,'43. Peter is ..... Jane to do it at the moment.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (44,3,'44. Have you sent that e-mail to Mr. Smyth?',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (45,3,'45. \".....have you been waiting ? ',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (46,3,'46. They weren''t surprised and nor ..... I.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (47,3,'47. This is the cat ..... I saw.',0,0)");
            Sql("SET IdENTITY_INSERT PreguntasTest OFF");
            #endregion

            #region Respuestas Nivel Pre-Intermedio 
            Sql("SET IdENTITY_INSERT RespuestasTest ON");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (131,33,'A. since',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (132,33,'B. -----',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (133,33,'C. for',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (134,33,'D. during',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (136,34,'A. were no',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (137,34,'B. weren''t no',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (138,34,'C. were any',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (139,34,'D. were not',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (140,35,'A. is just clean it.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (141,35,'B. have just cleaned it.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (142,35,'C. just clean it.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (143,35,'D. has just cleaned it.',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (144,36,'A. to hear',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (145,36,'B. hearing',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (146,36,'C. hear',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (147,36,'D. to hearing',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (148,37,'A. to shouting!',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (149,37,'B. shouting!',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (150,37,'C. shout!',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (151,37,'D. to shout',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (152,38,'A. doesn''t he?',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (153,38,'B. does he?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (154,38,'C. isn''t he?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (155,38,'D. didn''t he?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (156,39,'A. lives',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (157,39,'B. is living',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (158,39,'C. does live',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (159,39,'D. has lived',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (160,40,'A. I told her what she closed the window.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (161,40,'B. I told her to close the window.',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (162,40,'C. I told she close the window.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (163,40,'D. I told her that she close the window.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (164,41,'A. already',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (165,41,'B. still',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (166,41,'C. now',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (167,41,'D. yet',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (168,42,'A. would buy',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (169,42,'B. have bought',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (170,42,'C. will buy',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (171,42,'D. would have bought',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (172,43,'A. telling',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (173,43,'B. saying',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (174,43,'C. saying to',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (175,43,'D. telling to',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (176,44,'A. still',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (177,44,'B. already',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (178,44,'C. yet',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (179,44,'D. now',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (180,45,'A. How long',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (181,45,'B. What time',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (182,45,'C. How far',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (183,45,'D. When',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (184,46,'A. weren''t',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (185,46,'B. wasn''t',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (186,46,'C. were',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (187,46,'D. was',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (188,47,'A. whom',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (189,47,'B. -----',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (190,47,'C. what',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (191,47,'D. who',0)");
            Sql("SET IdENTITY_INSERT RespuestasTest OFF");
            #endregion

            #region Preguntas Nivel Intermedio 
            Sql("SET IdENTITY_INSERT PreguntasTest ON");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (48,4,'48. Which of the following options is correct to indicate that an action happened before another action in the past? I invited Mary out for a meal, but unfortunately she ...... dinner.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (49,4,'49. You can meet me ..... you like.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (50,4,'50. I ..... working at night nowadays.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (51,4,'51. I have to catch the 5:00 am train tomorrow, so I ..... go to bed late.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (52,4,'52. She ..... go to the dentist''s yesterday.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (53,4,'53. That''s the ..... of my worries, it''ll never happen.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (54,4,'54. I wouldn''t mind ..... tonight.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (55,4,'55. The man ..... in the corner is my boss.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (56,4,'56. \"Those cases look heavy\"  \".....carry one for you ? \"  \"That''s very nice of you\"', 0, 0) ");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (57,4,'57. Don''t forget ..... those letters.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (58,4,'58. Where have you put my keys? I clearly remember .... them on the table last night.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (59,4,'59. You look tired. You ..... go to bed.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (60,4,'60. Which of the following options is correct to express that you recall an action happening in the past? That was a great match. I''ll never forget ..... Rivaldo score that goal.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (61,4,'61. I thought you .....',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (62,4,'62. Which of the following options is correct to express regret about the past? They ..... last night, but I''m not sure.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (63,4,'63. He wrote the programme ..... , he dIdn''t need  anybody''s help.',0,0)");
            Sql("SET IdENTITY_INSERT PreguntasTest OFF");
            #endregion

            #region Respuestas Nivel Intermedio
            Sql("SET IdENTITY_INSERT RespuestasTest ON");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (192,48,'A. has already had',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (193,48,'B. had already had',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (194,48,'C. have already had',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (195,48,'D. already had',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (196,49,'A. whenever',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (197,49,'B. soon',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (198,49,'C. always',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (199,49,'D. whatever',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (200,50,'A. used to',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (201,50,'B. used',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (202,50,'C. am used to',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (203,50,'D. would',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (204,51,'A. needn''t',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (205,51,'B. haven''t',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (206,51,'C. have to',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (207,51,'D. shouldn''t',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (208,52,'A. must',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (209,52,'B. had to',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (210,52,'C. ought to',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (211,52,'D. should have',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (212,53,'A. fewer',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (213,53,'B. less',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (214,53,'C. last',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (215,53,'D. least',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (216,54,'A. to go out',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (217,54,'B. go out',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (218,54,'C. going out',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (219,54,'D. to going out',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (220,55,'A. whose',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (221,55,'B. sitting',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (222,55,'C. is sitting',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (223,55,'D. sits',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (224,56,'A. Will I',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (225,56,'B. Do I have',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (226,56,'C. Shall I',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (227,56,'D. Do it',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (228,57,'A. to post',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (229,57,'B. posting',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (230,57,'C. to posting',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (231,57,'D. post',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (232,58,'A. to leave',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (233,58,'B. left',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (234,58,'C. did leave',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (235,58,'D. leaving',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (236,59,'A. need',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (237,59,'B. have',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (238,59,'C. should have',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (239,59,'D. should',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (240,60,'A. see',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (241,60,'B. to see',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (242,60,'C. seeing',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (243,60,'D. to seeing',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (244,61,'A. will come to the party.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (245,61,'B. were coming to the party.',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (246,61,'C. come to the party.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (247,61,'D. have come to the party.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (248,62,'A. must have come',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (249,62,'B. can´t have come',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (250,62,'C. should have come',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (251,62,'D. may have come',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (252,63,'A. by his own',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (253,63,'B. on his own',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (254,63,'C. on himself',0)");
            Sql("SET IdENTITY_INSERT RespuestasTest OFF");
            #endregion


            #region Preguntas Nivel Intermedio Alto 
            Sql("SET IdENTITY_INSERT PreguntasTest ON");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (64,5,'64. We ..... better hurry up or we''ll be late.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (65,5,'65. She worked hard yesterday and ..... finish all the reports.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (66,5,'66. Which of the options is correct to illustrate speculation?',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (67,5,'67. ',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (68,5,'68. I couldn''t mend the PC myself, so I ..... at a shop.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (69,5,'69. I wish I ..... a car, I''m tired of catching the bus.',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (70,5,'70. ',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (71,5,'71. He ran so fast ..... being followed by a ghost.',0,0)");
            Sql("SET IdENTITY_INSERT PreguntasTest OFF");
            #endregion

            #region Respuestas Nivel Intermedio Alto 
            Sql("SET IdENTITY_INSERT RespuestasTest ON");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (255,64,'A. would',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (256,64,'B. should',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (257,64,'C. had',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (258,64,'D. ought',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (259,65,'A. was able to',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (260,65,'B. can',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (261,65,'C. could',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (262,65,'D. would be',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (263,66,'A. am',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (264,66,'B. would be',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (265,66,'C. were',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (266,67,'A. Ask her when will be ready the food.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (267,67,'B. Ask her when will be the food ready.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (268,67,'C. Ask her when the food will be ready.',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (269,68,'A. had it mended',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (270,68,'B. had it mend',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (271,68,'C. dId it mend',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (272,68,'D. had mended',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (273,69,'A. have',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (274,69,'B. would have',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (275,69,'C. had',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (276,69,'D. had had',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (277,70,'A. That''s a brown, fashionable leather coat.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (278,70,'B. That''s a brown leather coat fashionable.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (279,70,'C. That''s a fashionable leather brown coat.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (280,70,'D. That''s a fashionable brown leather coat.',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (281,71,'A. as',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (282,71,'B. as if he were',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (283,71,'C. like',0)");
            Sql("SET IdENTITY_INSERT RespuestasTest OFF");
            #endregion

            #region Preguntas Nivel Avanzado 
            Sql("SET IdENTITY_INSERT PreguntasTest ON");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (72,6,'72. ..... but I realised what he had done. ',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (73,6,'73. If you''d come to the theatre last night, you ..... the  play. ',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (74,6,'74. Which of the following options is correct to illustrate the Idea of disappointment? He .... have thanked you. ',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (75,6,'75. Which of the following options is correct to express a deduction from the past? They laughed a lot last night. The film ..... very funny. ',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (76,6,'76. ..... thinking that he would win the lottery. ',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (77,6,'77. If only I had had the courage to do this ..... ',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (78,6,'78. Let''s go to the theatre, ..... ',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (79,6,'79. Which of the following options is correct to illustrate that an action will happen before a specific time in the future?',0,0)");
            Sql("insert into PreguntasTest (Id,NivelTestId,Pregunta,CantidadOk,CantidadNoOk) values (80,6,'80. \"We''ll never be able to do it\" saId the man to nobody .....', 0, 0)");
            Sql("SET IdENTITY_INSERT PreguntasTest OFF");
            #endregion

            #region Respuestas Nivel Avanzado 
            Sql("SET IdENTITY_INSERT RespuestasTest ON");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (284,72,'A. Little dId he know',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (285,72,'B. Little known',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (286,72,'C. Little he knew',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (287,73,'A. would enjoy',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (288,73,'B. had enjoyed',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (289,73,'C. would have enjoyed',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (290,73,'D. will enjoy',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (291,74,'A. must',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (292,74,'B. may',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (293,74,'C. would',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (294,74,'D. should',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (295,75,'A. should have been',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (296,75,'B. must have been',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (297,75,'C. might have been',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (298,75,'D. may have been',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (299,76,'A. There was no use in',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (300,76,'B. It was no point in',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (301,76,'C. It was no use in',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (302,77,'A. years back.',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (303,77,'B. for years.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (304,77,'C. since years.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (305,77,'D. in years.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (306,78,'A. don''t we?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (307,78,'B. let us?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (308,78,'C. shall we?',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (309,78,'D. will we?',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (310,79,'A. will have',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (311,79,'B. will have had',1)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (312,79,'C. are having',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (313,79,'D. will had had',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (314,80,'A. especially.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (315,80,'B. specially.',0)");
            Sql("insert into RespuestasTest (Id,PreguntasTestId,Respuesta,Correcta) values (316,80,'C. in particular.',1)");
            Sql("SET IdENTITY_INSERT RespuestasTest OFF");
            #endregion
        }

        public override void Down()
        {
        }
    }
}
