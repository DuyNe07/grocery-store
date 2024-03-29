﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace grocery_store.Entities
{
    public partial class GroceryStoreContext : DbContext
    {
        public GroceryStoreContext()
        {
        }

        public GroceryStoreContext(DbContextOptions<GroceryStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CategoryPromotion> CategoryPromotion { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeTimekeeping> EmployeeTimekeeping { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<OrderLine> OrderLine { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<Promotion> Promotion { get; set; }
        public virtual DbSet<ShopOrder> ShopOrder { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<Timekeeping> Timekeeping { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    var connectionString = Environment.GetEnvironmentVariable("GroceryStoreConnectionString");
                    if (string.IsNullOrEmpty(connectionString))
                    {
                        throw new InvalidOperationException("Could not find a connection string named 'GroceryStoreConnectionString'.");
                    }
                    else
                    {
                        optionsBuilder.UseSqlServer(connectionString);
                    }
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<CategoryPromotion>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.PromotionId).HasColumnName("PromotionID");

                entity.HasOne(d => d.Category)
                    .WithMany()
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Category_Promotion");

                entity.HasOne(d => d.Promotion)
                    .WithMany()
                    .HasForeignKey(d => d.PromotionId)
                    .HasConstraintName("FK_Promotion_Category");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_Employee_Job");
            });

            modelBuilder.Entity<EmployeeTimekeeping>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.TimekeepingId).HasColumnName("TimekeepingID");

                entity.HasOne(d => d.Employee)
                    .WithMany()
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Employee_Timekeeping");

                entity.HasOne(d => d.Timekeeping)
                    .WithMany()
                    .HasForeignKey(d => d.TimekeepingId)
                    .HasConstraintName("FK_Timekeeping_Employee");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.JoinDate).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Salary).HasColumnType("money");
            });

            modelBuilder.Entity<OrderLine>(entity =>
            {
                entity.Property(e => e.OrderLineId).HasColumnName("OrderLineID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ShopOrderId).HasColumnName("ShopOrderID");

                entity.HasOne(d => d.ShopOrder)
                    .WithMany(p => p.OrderLine)
                    .HasForeignKey(d => d.ShopOrderId)
                    .HasConstraintName("FK_OrderLine_ProductID");

                entity.HasOne(d => d.ShopOrderNavigation)
                    .WithMany(p => p.OrderLine)
                    .HasForeignKey(d => d.ShopOrderId)
                    .HasConstraintName("FK_OrderLine_ShopOrder");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Qr)
                    .HasColumnName("QR")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.CostPrice).HasColumnType("money");

                entity.Property(e => e.Expiry).HasColumnType("date");

                entity.Property(e => e.MarketPrice).HasColumnType("money");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_Product_Supplier");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Category)
                    .WithMany()
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Category_Product");

                entity.HasOne(d => d.Product)
                    .WithMany()
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Product_Category");
            });

            modelBuilder.Entity<Promotion>(entity =>
            {
                entity.Property(e => e.PromotionId).HasColumnName("PromotionID");

                entity.Property(e => e.EndDay).HasColumnType("datetime");

                entity.Property(e => e.StartDay).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShopOrder>(entity =>
            {
                entity.Property(e => e.ShopOrderId).HasColumnName("ShopOrderID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ShopOrder)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_ShopOrder_Employee");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.ShopOrder)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_ShopOrder_Payment");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Timekeeping>(entity =>
            {
                entity.Property(e => e.TimekeepingId).HasColumnName("TimekeepingID");

                entity.Property(e => e.Checkout).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Salary).HasColumnType("money");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
