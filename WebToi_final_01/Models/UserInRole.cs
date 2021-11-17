namespace WebToi_final_01.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserInRole")]
    public partial class UserInRole
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDRole { get; set; }
    }
}
