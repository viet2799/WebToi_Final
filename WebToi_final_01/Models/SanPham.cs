namespace WebToi_final_01.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        [StringLength(10)]
        public string MaSP { get; set; }

        [StringLength(100)]
        public string TenSP { get; set; }

        [StringLength(50)]
        public string UrlAnh { get; set; }

        public int? GiaSP { get; set; }

        public string MoTa { get; set; }

        public int? MaDM { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
    }
}
