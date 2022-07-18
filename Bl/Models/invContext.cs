using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Bl.Models
{
    public partial class invContext : DbContext
    {
        public invContext()
        {
        }

        public invContext(DbContextOptions<invContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<InvDescrpoion> InvDescrpoions { get; set; } = null!;
        public virtual DbSet<InvHead> InvHeads { get; set; } = null!;
        public virtual DbSet<Procduct> Procducts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress2017;Initial Catalog=inv;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CustName)
                    .HasMaxLength(350)
                    .HasColumnName("Cust_Name");

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.OpiningBl)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Opining_bl");

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<InvDescrpoion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Inv_Descrpoion");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InvId).HasColumnName("Inv_ID");

                entity.Property(e => e.PriceSale)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Price_Sale");

                entity.Property(e => e.ProId).HasColumnName("Pro_Id");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Inv)
                    .WithMany()
                    .HasForeignKey(d => d.InvId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Inv_Descrpoion_Inv_Head");

                entity.HasOne(d => d.Pro)
                    .WithMany()
                    .HasForeignKey(d => d.ProId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Inv_Descrpoion_Procduct");
            });

            modelBuilder.Entity<InvHead>(entity =>
            {
                entity.ToTable("Inv_Head");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CustId).HasColumnName("Cust_Id");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ShepingEx)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Sheping_Ex");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.InvHeads)
                    .HasForeignKey(d => d.CustId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Inv_Head_Customer");
            });

            modelBuilder.Entity<Procduct>(entity =>
            {
                entity.ToTable("Procduct");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BuyPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Buy_Price");

                entity.Property(e => e.ProName)
                    .HasMaxLength(350)
                    .HasColumnName("Pro_Name");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SalePrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Sale_Price");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
