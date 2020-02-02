namespace DA.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News_Detail
    {
        [Key]
        public int DelID { get; set; }

        public int? CateID { get; set; }

        [StringLength(50)]
        public string vTitel { get; set; }

        [StringLength(250)]
        public string vDesc { get; set; }

        [StringLength(250)]
        public string vImage { get; set; }

        [StringLength(50)]
        public string vAuthor { get; set; }

        [StringLength(1000)]
        public string vContent { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? vCreateDate { get; set; }

        public bool? Active { get; set; }

        public virtual News_Catagories News_Catagories { get; set; }
    }
}
