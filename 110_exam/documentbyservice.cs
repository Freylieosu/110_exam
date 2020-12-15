namespace _110_exam
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("110.documentbyservice")]
    public partial class documentbyservice
    {
        public int ID { get; set; }

        public int ClientServiceID { get; set; }

        [Required]
        [StringLength(1000)]
        public string DocumentPath { get; set; }

        public virtual clientservice clientservice { get; set; }
    }
}
