namespace TestDoAn.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietSanPham")]
    public partial class ChiTietSanPham
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string masp { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string manl { get; set; }

        public int? soluong { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string dvt { get; set; }

        public virtual NguyenLieu NguyenLieu { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
