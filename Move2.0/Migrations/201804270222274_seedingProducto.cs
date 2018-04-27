namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingProducto : DbMigration
    {
        public override void Up()
        {
            Sql(String.Format("Insert into producto (name,description,price,startingDate,enddate) values ('Move Core','Move Core',{1},'{0}','1900-01-01')", DateTime.Now.ToString("yyyy-MM-dd"), 2280.00));
            Sql(String.Format("Insert into producto (name,description,price,startingDate,enddate) values ('Move Groups','Move Groups',{1},'{0}','1900-01-01')", DateTime.Now.ToString("yyyy-MM-dd"), 2280.00));
            Sql(String.Format("Insert into producto (name,description,price,startingDate,enddate) values ('Move Individual','Move Individual',{1},'{0}','1900-01-01')", DateTime.Now.ToString("yyyy-MM-dd"), 2280.00));

        }

        public override void Down()
        {
        }
    }
}
