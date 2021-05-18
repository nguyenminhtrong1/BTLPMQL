using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLPMQL.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        public int IDKH { get; set; }
        public string TenKH { get; set; }
        public int SoDIenThoai { get; set; }
        public string DiaChi { get; set; }
    }
}