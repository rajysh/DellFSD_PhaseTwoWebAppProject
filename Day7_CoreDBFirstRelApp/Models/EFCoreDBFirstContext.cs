using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Day7_CoreDBFirstRelApp.Models
{
    public partial class EFCoreDBFirstContext : DbContext
    {
        public EFCoreDBFirstContext()
        {
        }

        public EFCoreDBFirstContext(DbContextOptions<EFCoreDBFirstContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<ContactDetail> ContactDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=W102XZP8Y2;Database=EFCoreDBFirst;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("Brand");

                entity.Property(e => e.BrandAddedDate).HasColumnType("datetime");

                entity.Property(e => e.BrandDesc)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContactDetail>(entity =>
            {
                entity.ToTable("ContactDetail");

                entity.Property(e => e.ContactName).IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductAddedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK__Product__BrandId__2C3393D0");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Age).HasColumnName("AGE");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FullName).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.UserName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
