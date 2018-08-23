namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertMemberShiptypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE  MembershipTypes SET   Name=case when id=1 then 'Pay As You Go' when  id=2 then 'Monthly' when  id=3 then 'Quartely' when  id=4 then 'Annual' end");
        }
        
        public override void Down()
        {
        }
    }
}
