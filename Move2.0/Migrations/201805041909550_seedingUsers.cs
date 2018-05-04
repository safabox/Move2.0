namespace Move2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingUsers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DNI], [Name], [LastName], [BirthDay]) VALUES (N'0be13e11-a884-4959-9724-804635f5d1b6', N'vabrigo@balanguagegroup.com', 0, N'AI10vGOgUsL+j7DAgQMvBuUW/X8Eb+MnqBM0hmE5eXGweK6XkTbQMIju6REaibwmvA==', N'd29aa37b-27c7-4a70-807a-53a4f93bce3f', NULL, 0, 0, NULL, 1, 0, N'vabrigo@balanguagegroup.com', 12345679, N'Virginia', N'Abrigo', N'2000-01-01 00:00:00')");
            Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DNI], [Name], [LastName], [BirthDay]) VALUES (N'187f78e5-54e4-4e33-a5a8-84668ccf8ad0', N'db@balanguagegroup.com', 0, N'ADvZt+apxsZwLjGrHU3+RSRXNBsgRrVpc26o5kWQYD2NnkcNGz8B3mKb31arNXH+JQ==', N'cfcdea69-e537-443c-b471-b4dd88d065aa', NULL, 0, 0, NULL, 1, 0, N'db@balanguagegroup.com', 12345689, N'Diego', N'Burset', N'2000-01-01 00:00:00')");
            Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DNI], [Name], [LastName], [BirthDay]) VALUES (N'83e4d8df-accd-4086-86ba-ea892b83b894', N'p.burset@balanguagegroup.com', 0, N'AAZlLAOnPzJDcCD/F0A16lMnaht5GaGoRTyfkV52YAmuGUwelLNoP+PuuVT4h3a34A==', N'45eef6a6-a836-457a-b57f-bddaea6f83ee', NULL, 0, 0, NULL, 1, 0, N'p.burset@balanguagegroup.com', 12345678, N'Pilar', N'Burset', N'2000-01-01 00:00:00')");
            Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DNI], [Name], [LastName], [BirthDay]) VALUES (N'dd584c8a-df93-4be8-8100-a80f923844c3', N'mrepetto@balanguagegroup.com', 0, N'AHkK1arfCAyxZID/5zZ73xF3M1qMNRtPkQ3pdhGE32iahreSw48kt6eFDiJ6u1Vg5A==', N'76080f54-d53b-4eb6-b186-0dbaff4c3557', NULL, 0, 0, NULL, 1, 0, N'mrepetto@balanguagegroup.com', 12378912, N'Marcela', N'Repetto', N'2000-01-01 00:00:00')");

        }

        public override void Down()
        {
        }
    }
}
