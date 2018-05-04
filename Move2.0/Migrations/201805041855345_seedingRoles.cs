namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingRoles : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into AspNetRoles (id,name) values ('0740952d-c966-4d96-872a-172d2640d72a','Administrator')");
            Sql("Insert into AspNetRoles (id,name) values ('150d434c-e500-4db9-9e59-6bf2b7fb7f8a','User')");
             
        }
        
        public override void Down()
        {
        }
    }
}
