namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4a7645ad-41c4-49c1-b98b-840bfa857d4a', N'admin@vidly.com', 0, N'AD7FCaX7VuEqhC6ovVUDAmHt0ujlJ/6xT3hL7p5GeVg8I/1pM9u50MjpX7hjtRaiFA==', N'157db487-d490-4ff4-a519-366f71eb08f6', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f123157c-5f79-47ac-b46e-1918f9412017', N'guest@guest.com', 0, N'AH6Y6iRBW8yrzBxFoo+Dp4dkByZ/FFrGNVmOIMbTEwtAJH4kjebdjnn681CGimiFDQ==', N'3c492935-1ed5-4900-a521-98d6d7b8be36', NULL, 0, 0, NULL, 1, 0, N'guest@guest.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'460f310d-2a94-47f7-80b8-5c746d0130ba', N'CanManageMovies')
  
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4a7645ad-41c4-49c1-b98b-840bfa857d4a', N'460f310d-2a94-47f7-80b8-5c746d0130ba')


                   ");
        }
        
        public override void Down()
        {
        }
    }
}
