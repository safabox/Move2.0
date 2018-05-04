namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingUserRoles : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES ('0be13e11-a884-4959-9724-804635f5d1b6', '0740952d-c966-4d96-872a-172d2640d72a')");
            Sql("INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES ('187f78e5-54e4-4e33-a5a8-84668ccf8ad0', '0740952d-c966-4d96-872a-172d2640d72a')");
            Sql("INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES ('83e4d8df-accd-4086-86ba-ea892b83b894', '0740952d-c966-4d96-872a-172d2640d72a')");
            Sql("INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES ('dd584c8a-df93-4be8-8100-a80f923844c3', '0740952d-c966-4d96-872a-172d2640d72a')");

        }
        
        public override void Down()
        {
        }
    }
}
