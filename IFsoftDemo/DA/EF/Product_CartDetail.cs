namespace DA.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product_CartDetail
    {
        [Key]
        public int ProCartDelID { get; set; }

        public int? ProDelID { get; set; }

        public int? ProCartID { get; set; }

        [StringLength(50)]
        public string iQuatity { get; set; }

        [Column(TypeName = "money")]
        public decimal? fMoney { get; set; }

        public virtual Product_Carts Product_Carts { get; set; }

        public virtual Product_Detail Product_Detail { get; set; }
    }
}
