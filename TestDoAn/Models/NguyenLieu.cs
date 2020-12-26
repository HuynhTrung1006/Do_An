namespace TestDoAn.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguyenLieu")]
    public partial class NguyenLieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguyenLieu()
        {
            ChiTietPhieuNhaps = new HashSet<ChiTietPhieuNhap>();
            ChiTietSanPhams = new HashSet<ChiTietSanPham>();
        }

        [Key]
        [StringLength(10)]
        [Display(Name ="Mã Nguyên Liệu")]
        public string manl { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Tên Nguyên Liệu")]
        public string tenhh { get; set; }

        [StringLength(30)]
        [Display(Name = "Đơn vị tính")]
        public string dvt { get; set; }

        [StringLength(50)]
        [Display(Name = "Nhà cung cấp")]
        public string nhacungcap { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Hạn Sử Dụng")]
        public DateTime hsd { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Mã loại")]
        public string maloai { get; set; }
        [Display(Name = "Đơn Giá")]
        public double dongia { get; set; }
        [Display(Name = "Số Lượng")]
        public int? soluong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }
    }
}
