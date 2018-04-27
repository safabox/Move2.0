namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingFeature : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into feature (name,tooltip) values ('Plataforma E-learning 24/7',null)");
            Sql("Insert into feature (name,tooltip) values ('Move talk 1 hr por semana','Move talk 1 hr por semana')");
            Sql("Insert into feature (name,tooltip) values ('Consultas por chat',null)");
            Sql("Insert into feature (name,tooltip) values ('Test teóricos incluidos',null)");
            Sql("Insert into feature (name,tooltip) values ('Seguimiento personal',null)");
            Sql("Insert into feature (name,tooltip) values ('Evaluaciones de progreso','Evaluaciones de progreso')");
        }
        
        public override void Down()
        {
        }
    }
}
