namespace BTLPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateeeeeee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DonHangs",
                c => new
                    {
                        MaHoaDon = c.Int(nullable: false, identity: true),
                        TenSanPham = c.String(),
                        Gia = c.Int(nullable: false),
                        name = c.String(),
                        credit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaHoaDon);
            
            AddColumn("dbo.PhanHois", "HoaDonPhanHoi", c => c.String());
            AddColumn("dbo.PhanHois", "ChiTiet", c => c.String());
            DropColumn("dbo.PhanHois", "TenKhachHang");
            DropColumn("dbo.PhanHois", "Ykien");
            DropTable("dbo.DonHangs");
        }
        
        public override void Down()
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
            
            AddColumn("dbo.PhanHois", "Ykien", c => c.String());
            AddColumn("dbo.PhanHois", "TenKhachHang", c => c.String());
            DropColumn("dbo.PhanHois", "ChiTiet");
            DropColumn("dbo.PhanHois", "HoaDonPhanHoi");
            DropTable("dbo.DonHangs");
        }
    }
}
