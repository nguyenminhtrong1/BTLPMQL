namespace BTLPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class phanhoisssss : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhanHois",
                c => new
                    {
                        IDkhachhang = c.Int(nullable: false, identity: true),
                        TenKhachHang = c.String(),
                        Ykien = c.String(),
                    })
                .PrimaryKey(t => t.IDkhachhang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PhanHois");
        }
    }
}
