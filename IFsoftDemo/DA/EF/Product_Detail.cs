namespace DA.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product_Detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product_Detail()
        {
            Product_CartDetail = new HashSet<Product_CartDetail>();
        }

        [Key]
        public int ProDelID { get; set; }

        public int? ProID { get; set; }

        [StringLength(50)]
        public string vCode { get; set; }

        [StringLength(50)]
        public string vName { get; set; }

        [StringLength(250)]
        public string vDesc { get; set; }

        [StringLength(50)]
        public string vContent { get; set; }

        [StringLength(150)]
        public string vImage { get; set; }

        [StringLength(50)]
        public string vQuatily { get; set; }

        [Column(TypeName = "money")]
        public decimal? vPrice { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string iView { get; set; }

        public bool? Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_CartDetail> Product_CartDetail { get; set; }

        public virtual Product_Catagories Product_Catagories { get; set; }
    }
}
