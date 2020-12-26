namespace TestDoAn.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            ChiTietSanPhams = new HashSet<ChiTietSanPham>();
        }

        [Key]
        [StringLength(10)]
        [Display(Name ="Mã Sản Phẩm")]
        public string masp { get; set; }

        [StringLength(30)]
        [Display(Name = "Tên Sản Phẩm")]
        public string tensp { get; set; }
        [Display(Name = "Giá Sản Phẩm")]
        public double dongia { get; set; }

        [StringLength(10)]
        [Display(Name = "Đơn vị tính")]
        public string dvt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }
    }
}
