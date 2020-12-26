namespace TestDoAn.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuNhap")]
    public partial class ChiTietPhieuNhap
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string manl { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string mapn { get; set; }

        public int? soluongnhap { get; set; }

        public virtual NguyenLieu NguyenLieu { get; set; }

        public virtual PhieuNhap PhieuNhap { get; set; }
    }
}
