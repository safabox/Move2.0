namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingOrderStatus : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT ORDERSTATUS ON");
            Sql("INSERT INTO ORDERSTATUS (ID,STATUS,DESCRIPTION) VALUES (1,'SUBMIT','Orden presentada')");
            Sql("INSERT INTO ORDERSTATUS (ID,STATUS,DESCRIPTION) VALUES (2,'PENDING','Orden pendiente')");
            Sql("INSERT INTO ORDERSTATUS (ID,STATUS,DESCRIPTION) VALUES (3,'APPROVED','Orden aprobada')");
            Sql("INSERT INTO ORDERSTATUS (ID,STATUS,DESCRIPTION) VALUES (4,'REJECTED','Orden rechazada')");
            Sql("INSERT INTO ORDERSTATUS (ID,STATUS,DESCRIPTION) VALUES (5,'CANCEL','Orden cancelada')");
            Sql("SET IDENTITY_INSERT ORDERSTATUS OFF");
        }
        
        public override void Down()
        {
        }
    }
}
