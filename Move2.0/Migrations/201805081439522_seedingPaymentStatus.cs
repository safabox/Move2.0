namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingPaymentStatus : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT PaymentStatus ON");
            Sql("INSERT INTO PaymentStatus (ID,STATUS,DESCRIPTION) VALUES (1,'APPROVED','Pago aprobado')");
            Sql("INSERT INTO PaymentStatus (ID,STATUS,DESCRIPTION) VALUES (2,'PENDING','Pago pendiente')");
            Sql("INSERT INTO PaymentStatus (ID,STATUS,DESCRIPTION) VALUES (3,'REJECTED','Pago rechazado')");
            Sql("SET IDENTITY_INSERT PaymentStatus OFF");
        }
        
        public override void Down()
        {
        }
    }
}
