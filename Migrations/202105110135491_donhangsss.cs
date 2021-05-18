namespace BTLPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class donhangsss : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DonHangs",
                c => new
                    {
                        MaDonHang = c.Int(nullable: false, identity: true),
                        TenSanPham = c.String(),
                        Gia = c.Int(nullable: false),
                        ThoiGianMuaHang = c.Int(nullable: false),
                        TongThanhToan = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaDonHang);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        IDKH = c.Int(nullable: false, identity: true),
                        TenKH = c.String(),
                        SoDIenThoai = c.Int(nullable: false),
                        DiaChi = c.String(),
                    })
                .PrimaryKey(t => t.IDKH);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KhachHangs");
            DropTable("dbo.DonHangs");
        }
    }
}
