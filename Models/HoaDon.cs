using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLPMQL.Models
{
    [Table("DonHangs")]
    public class HoaDon
    {
        [Key]
        public int MaHoaDon { get; set; }
        public string TenSanPham { get; set; }
        public int Gia { get; set; }
        public string name { get; set; }
        public int credit { get; set; }
    }
}