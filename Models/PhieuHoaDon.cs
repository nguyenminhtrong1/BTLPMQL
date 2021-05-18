using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLPMQL.Models
{
    [Table("PhieuHoaDons")]
    public class PhieuHoaDon
    {
        [Key]
        public int IDphieu { get; set; }
        public int MaPhieu { get; set; }
        public string TenPhieu { get; set; }
        public string SanPham { get; set; }
    }
}