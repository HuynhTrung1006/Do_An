namespace TestDoAn.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Display(Name ="Số Lượng")]
        public int? soluong { get; set; }
        [Display(Name = "Đơn Giá")]
        public double? dongia { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name ="Mã Hóa Đơn")]
        public int mahd { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        [Display(Name ="Mã Sản Phẩm")]
        public string masp { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
