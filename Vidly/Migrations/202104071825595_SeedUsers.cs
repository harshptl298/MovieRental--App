namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8a5c3d7c-a14f-4a23-9677-d626f468c33c', N'admin@vidly.com', 0, N'AD/vDmdpp8B+SUBRvlV2P0Pg2ySTLNhNijVlxcVB4W5fI4rk0yErVzShlq5ONpte4g==', N'b8308207-3234-4a6c-9bae-5f38d52a670b', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ef0b5671-4b44-465f-9d1a-24f6cd929ecd', N'guest@vidl.com', 0, N'AKqixARUTmkmRCDqpH6l8uELx3HYlrVjUHZAcff2BPXWCGGiE62zppqjMLn+J+NM2Q==', N'959943b7-5db6-47cf-bae9-0de9c199e85b', NULL, 0, 0, NULL, 1, 0, N'guest@vidl.com')
                 INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'fceafe06-ea8b-4104-ae26-1696b62be292', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8a5c3d7c-a14f-4a23-9677-d626f468c33c', N'fceafe06-ea8b-4104-ae26-1696b62be292')
               
                 ");
        }
        
        public override void Down()
        {
        }
    }
}
