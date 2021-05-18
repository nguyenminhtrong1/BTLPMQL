using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLPMQL.Models
{
    [Table("PhanHois")]
    public class PhanHoi
    {
        [Key]
        public int IDkhachhang { get; set; }
        public string HoaDonPhanHoi { get; set; }
        public string ChiTiet { get; set; }
    }
}