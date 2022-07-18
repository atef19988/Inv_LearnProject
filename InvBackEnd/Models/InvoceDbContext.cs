using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InvBackEnd.Models
{
    public partial class InvoceDbContext : DbContext
    {
        public InvoceDbContext()
        {
        }

        public InvoceDbContext(DbContextOptions<InvoceDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerTb> CustomerTbs { get; set; } = null!;
        public virtual DbSet<InvDescrptionTb> InvDescrptionTbs { get; set; } = null!;
        public virtual DbSet<InvheadTb> InvheadTbs { get; set; } = null!;
        public virtual DbSet<ProductTb> ProductTbs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress2017;Initial Catalog=InvoceDb;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerTb>(entity =>
            {
                entity.ToTable("CustomerTb");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Phone).HasColumnName("phone");
            });

            modelBuilder.Entity<InvDescrptionTb>(entity =>
            {
                entity.ToTable("InvDescrptionTb");

                entity.Property(e => e.PriceSale).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Inv)
                    .WithMany(p => p.InvDescrptionTbs)
                    .HasForeignKey(d => d.InvId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_InvDescrptionTb_InvheadTb");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.InvDescrptionTbs)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_InvDescrptionTb_ProductTb");
            });

            modelBuilder.Entity<InvheadTb>(entity =>
            {
                entity.ToTable("InvheadTb");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ShepingEx).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.InvheadTbs)
                    .HasForeignKey(d => d.CustId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_InvheadTb_CustomerTb");
            });

            modelBuilder.Entity<ProductTb>(entity =>
            {
                entity.ToTable("ProductTb");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BuyPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalePrice).HasColumnType("decimal(18, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
