namespace BTLPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Phieuhaodonss : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhieuHoaDons",
                c => new
                    {
                        IDphieu = c.Int(nullable: false, identity: true),
                        MaPhieu = c.Int(nullable: false),
                        TenPhieu = c.String(),
                        SanPham = c.String(),
                    })
                .PrimaryKey(t => t.IDphieu);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PhieuHoaDons");
        }
    }
}
