using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace _110_exam
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Connection110")
        {
        }

        public virtual DbSet<client> clients { get; set; }
        public virtual DbSet<clientservice> clientservices { get; set; }
        public virtual DbSet<documentbyservice> documentbyservices { get; set; }
        public virtual DbSet<gender> genders { get; set; }
        public virtual DbSet<manufacturer> manufacturers { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<productphoto> productphotoes { get; set; }
        public virtual DbSet<productsale> productsales { get; set; }
        public virtual DbSet<service> services { get; set; }
        public virtual DbSet<servicephoto> servicephotoes { get; set; }
        public virtual DbSet<tag> tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<client>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.Patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.RegistrationDate)
                .HasPrecision(6);

            modelBuilder.Entity<client>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.GenderCode)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.PhotoPath)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .HasMany(e => e.clientservices)
                .WithRequired(e => e.client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<client>()
                .HasMany(e => e.tags)
                .WithMany(e => e.clients)
                .Map(m => m.ToTable("tagofclient", "110").MapLeftKey("ClientID").MapRightKey("TagID"));

            modelBuilder.Entity<clientservice>()
                .Property(e => e.StartTime)
                .HasPrecision(6);

            modelBuilder.Entity<clientservice>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<clientservice>()
                .HasMany(e => e.documentbyservices)
                .WithRequired(e => e.clientservice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<documentbyservice>()
                .Property(e => e.DocumentPath)
                .IsUnicode(false);

            modelBuilder.Entity<gender>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<gender>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<gender>()
                .HasMany(e => e.clients)
                .WithRequired(e => e.gender)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<manufacturer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.MainImagePath)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .HasMany(e => e.productphotoes)
                .WithRequired(e => e.product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<product>()
                .HasMany(e => e.productsales)
                .WithRequired(e => e.product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<product>()
                .HasMany(e => e.product1)
                .WithMany(e => e.products)
                .Map(m => m.ToTable("attachedproduct", "110").MapLeftKey("MainProductID").MapRightKey("AttachedProductID"));

            modelBuilder.Entity<productphoto>()
                .Property(e => e.PhotoPath)
                .IsUnicode(false);

            modelBuilder.Entity<productsale>()
                .Property(e => e.SaleDate)
                .HasPrecision(6);

            modelBuilder.Entity<service>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<service>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<service>()
                .Property(e => e.MainImagePath)
                .IsUnicode(false);

            modelBuilder.Entity<service>()
                .HasMany(e => e.clientservices)
                .WithRequired(e => e.service)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<service>()
                .HasMany(e => e.servicephotoes)
                .WithRequired(e => e.service)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<servicephoto>()
                .Property(e => e.PhotoPath)
                .IsUnicode(false);

            modelBuilder.Entity<tag>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<tag>()
                .Property(e => e.Color)
                .IsUnicode(false);
        }
    }
}
