namespace DA.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=IFsoftConnection")
        {
        }

        public virtual DbSet<AdminUsers> AdminUsers { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<News_Catagories> News_Catagories { get; set; }
        public virtual DbSet<News_Detail> News_Detail { get; set; }
        public virtual DbSet<Product_CartDetail> Product_CartDetail { get; set; }
        public virtual DbSet<Product_Carts> Product_Carts { get; set; }
        public virtual DbSet<Product_Catagories> Product_Catagories { get; set; }
        public virtual DbSet<Product_Detail> Product_Detail { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminUsers>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<AdminUsers>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Contacts>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Contacts>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Product_CartDetail>()
                .Property(e => e.iQuatity)
                .IsUnicode(false);

            modelBuilder.Entity<Product_CartDetail>()
                .Property(e => e.fMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product_Carts>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Product_Carts>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Product_Carts>()
                .Property(e => e.TotalMoney)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product_Carts>()
                .HasMany(e => e.Product_CartDetail)
                .WithOptional(e => e.Product_Carts)
                .HasForeignKey(e => e.ProCartID);

            modelBuilder.Entity<Product_Detail>()
                .Property(e => e.vCode)
                .IsUnicode(false);

            modelBuilder.Entity<Product_Detail>()
                .Property(e => e.vContent)
                .IsUnicode(false);

            modelBuilder.Entity<Product_Detail>()
                .Property(e => e.vImage)
                .IsUnicode(false);

            modelBuilder.Entity<Product_Detail>()
                .Property(e => e.vQuatily)
                .IsUnicode(false);

            modelBuilder.Entity<Product_Detail>()
                .Property(e => e.vPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product_Detail>()
                .Property(e => e.iView)
                .IsUnicode(false);
        }
    }
}
