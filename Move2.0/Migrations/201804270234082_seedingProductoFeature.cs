namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingProductoFeature : DbMigration
    {
        public override void Up()
        {

            Sql("Insert into productofeature (producto_id,feature_id) values (1,1)");
            Sql("Insert into productofeature (producto_id,feature_id) values (1,3)");
            Sql("Insert into productofeature (producto_id,feature_id) values (2,1)");
            Sql("Insert into productofeature (producto_id,feature_id) values (2,3)");
            Sql("Insert into productofeature (producto_id,feature_id) values (3,1)");
            Sql("Insert into productofeature (producto_id,feature_id) values (3,2)");
            Sql("Insert into productofeature (producto_id,feature_id) values (3,3)");
            Sql("Insert into productofeature (producto_id,feature_id) values (3,4)");
            Sql("Insert into productofeature (producto_id,feature_id) values (3,5)");
            Sql("Insert into productofeature (producto_id,feature_id) values (3,6)");

        }
        
        public override void Down()
        {
        }
    }
}
