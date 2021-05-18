using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLPMQL.Models
{
    [Table("SanPhams")]
    public class SanPham
    {
        [Key]
        public int IDsp { get; set; }
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int GiaBan { get; set; }
    }
}