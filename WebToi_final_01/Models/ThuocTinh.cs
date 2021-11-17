namespace WebToi_final_01.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThuocTinh")]
    public partial class ThuocTinh
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDTT { get; set; }

        [StringLength(150)]
        public string TenTT { get; set; }
    }
}
