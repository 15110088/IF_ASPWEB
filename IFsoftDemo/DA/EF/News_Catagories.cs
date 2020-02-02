namespace DA.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News_Catagories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public News_Catagories()
        {
            News_Detail = new HashSet<News_Detail>();
        }

        [Key]
        public int CateID { get; set; }

        [StringLength(50)]
        public string vName { get; set; }

        [StringLength(50)]
        public string vOrder { get; set; }

        public bool? Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<News_Detail> News_Detail { get; set; }
    }
}
