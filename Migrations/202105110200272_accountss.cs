namespace BTLPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class accountss : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        Password = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "dbo.SanPhams",
                c => new
                    {
                        IDsp = c.Int(nullable: false, identity: true),
                        MaSanPham = c.Int(nullable: false),
                        TenSanPham = c.String(),
                        GiaBan = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDsp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SanPhams");
            DropTable("dbo.Accounts");
        }
    }
}
