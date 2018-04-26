namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingCurso : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Curso (name,description,MoodleId,nivelid) values ('Business English - Level A1 - Module A','Inicial - A',9,1)");
            Sql("Insert into Curso (name,description,MoodleId,nivelid) values ('Business English - Level A2 - Module A','Elemental - A',18,2)");
            Sql("Insert into Curso (name,description,MoodleId,nivelid) values ('Business English - Level B1 - Module A','Pre Intermedio - A',28,3)");
            Sql("Insert into Curso (name,description,MoodleId,nivelid) values ('Business English - Level B2 - Module A','Intermedio - A',72,4)");
            Sql("Insert into Curso (name,description,MoodleId,nivelid) values ('Business English - Level C1 - Module A','Intermedio Alto - A',30,5)");
            Sql("Insert into Curso (name,description,MoodleId,NivelId) values ('Business English - Level C2 - Module A','Avanzado - A',77,6)");
        }
        
        public override void Down()
        {
        }
    }
}
