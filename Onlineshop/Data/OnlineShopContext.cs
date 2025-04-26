using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Onlineshop.Models;

namespace Onlineshop.Data;

public partial class OnlineShopContext : DbContext
{
    public OnlineShopContext()
    {
    }

    public OnlineShopContext(DbContextOptions<OnlineShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Menu> Menus { get; set; }
  

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=.;Database=OnlineShop;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

     

     

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Link).HasMaxLength(50);
            entity.Property(e => e.TitleMenu).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);


    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
