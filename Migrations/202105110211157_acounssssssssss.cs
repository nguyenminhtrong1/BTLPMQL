namespace BTLPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class acounssssssssss : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accounts", "Password", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "Password", c => c.Int(nullable: false));
        }
    }
}
