using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace W2BK6M_WindowsFormsApp.Models;

public partial class CustomerContext : DbContext
{
    public CustomerContext()
    {
    }

    public CustomerContext(DbContextOptions<CustomerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=budapesticorvinus.database.windows.net;Initial Catalog=Soft_eng_database;Persist Security Info=True;User ID=hallgato;Password=Password123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.Property(e => e.CustomerId).ValueGeneratedNever();
            entity.Property(e => e.Address).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(60);
            entity.Property(e => e.Email).HasMaxLength(60);
            entity.Property(e => e.Name).HasMaxLength(60);
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.ToTable("Item");

            entity.Property(e => e.ItemId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(60);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.ToTable("Order");

            entity.Property(e => e.OrderId).ValueGeneratedNever();
            entity.Property(e => e.CustomerIdFk).HasColumnName("CustomerId_FK");
            entity.Property(e => e.ItemIdFk).HasColumnName("ItemId_FK");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");

            entity.HasOne(d => d.CustomerIdFkNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerIdFk)
                .HasConstraintName("FK_Order_ToCustomer");

            entity.HasOne(d => d.ItemIdFkNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.ItemIdFk)
                .HasConstraintName("FK_Order_ToItem");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
