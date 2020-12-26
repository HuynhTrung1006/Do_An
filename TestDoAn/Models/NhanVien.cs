namespace TestDoAn.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
            PhieuNhaps = new HashSet<PhieuNhap>();
        }

        [Key]
        [StringLength(10)]
        [Display(Name ="Mã Nhân Viên")]
        public string manv { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Tên Nhân Viên")]
        public string tennv { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "CMND")]
        public string cmnd { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Số Điện Thoại")]
        public string sdt { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Địa Chỉ")]
        public string diachi { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Mật Khẩu")]
        public string matkhau { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Mã Công Việc")]
        public string macv { get; set; }

        public virtual chucvu chucvu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; }
    }
}
