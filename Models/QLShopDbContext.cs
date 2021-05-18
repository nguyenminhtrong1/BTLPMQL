namespace BTLPMQL.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

    public partial class QLShopDbContext : DbContext
    {
        public QLShopDbContext()
            : base("name=QLShopDbContext")
        {
        }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<PhieuHoaDon> PhieuHoaDons { get; set; }
        public virtual DbSet<PhanHoi> PhanHois { get; set; }
        public  virtual DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<BTLPMQL.Models.SanPham> SanPhams { get; set; }
        
    }
}
