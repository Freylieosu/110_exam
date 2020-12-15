namespace _110_exam
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("110.productphoto")]
    public partial class productphoto
    {
        public int ID { get; set; }

        public int ProductID { get; set; }

        [Required]
        [StringLength(1000)]
        public string PhotoPath { get; set; }

        public virtual product product { get; set; }
    }
}
