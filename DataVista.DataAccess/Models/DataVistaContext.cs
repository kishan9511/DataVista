using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataVista.DataAccess.Models;

public partial class DataVistaContext : DbContext
{
    public DataVistaContext()
    {
    }

    public DataVistaContext(DbContextOptions<DataVistaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AppInfo> AppInfos { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<CityZipCode> CityZipCodes { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }

    public virtual DbSet<LoginActivity> LoginActivities { get; set; }

    public virtual DbSet<Registration> Registrations { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SmtpConfig> SmtpConfigs { get; set; }

    public virtual DbSet<State> States { get; set; }

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AppInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AppInfo__3214EC0737CF47A0");

            entity.ToTable("AppInfo");

            entity.Property(e => e.Favicon)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LoginBackgroundImage)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Logo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithMany(p => p.AppInfos)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__AppInfo__UserId__5BE2A6F2");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__City__3214EC075FB3DDCB");

            entity.ToTable("City");

            entity.Property(e => e.ImgIcon).HasMaxLength(300);
            entity.Property(e => e.Name).HasMaxLength(300);

            entity.HasOne(d => d.State).WithMany(p => p.Cities)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK__City__StateId__534D60F1");
        });

        modelBuilder.Entity<CityZipCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CityZipC__3214EC07F6A1A00B");

            entity.ToTable("CityZipCode");

            entity.Property(e => e.Name).HasMaxLength(300);

            entity.HasOne(d => d.City).WithMany(p => p.CityZipCodes)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK__CityZipCo__CityI__5629CD9C");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Country__3214EC07D62F19A5");

            entity.ToTable("Country");

            entity.Property(e => e.CountryCode).HasMaxLength(100);
            entity.Property(e => e.ImgIcon).HasMaxLength(300);
            entity.Property(e => e.Name).HasMaxLength(300);
        });

        modelBuilder.Entity<EmailTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EmailTem__3214EC07668B4862");

            entity.ToTable("EmailTemplate");

            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Subject).HasMaxLength(200);

            entity.HasOne(d => d.User).WithMany(p => p.EmailTemplates)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__EmailTemp__UserI__5EBF139D");
        });

        modelBuilder.Entity<LoginActivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LoginAct__3214EC0753F94534");

            entity.ToTable("LoginActivity");

            entity.Property(e => e.EventDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.User).WithMany(p => p.LoginActivities)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__LoginActi__UserI__59063A47");
        });

        modelBuilder.Entity<Registration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Registra__3214EC073E316B33");

            entity.ToTable("Registration");

            entity.Property(e => e.AddedData).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(300);

            entity.HasOne(d => d.Role).WithMany(p => p.Registrations)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__Registrat__RoleI__4BAC3F29");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Role__3214EC078FC61B2F");

            entity.ToTable("Role");

            entity.Property(e => e.ImageIcon).HasMaxLength(300);
            entity.Property(e => e.Name).HasMaxLength(300);
        });

        modelBuilder.Entity<SmtpConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SmtpConf__3214EC07362C7C7C");

            entity.ToTable("SmtpConfig");

            entity.Property(e => e.EnableSsl).HasColumnName("EnableSSL");
            entity.Property(e => e.Host).HasMaxLength(300);
            entity.Property(e => e.UserName).HasMaxLength(300);

            entity.HasOne(d => d.User).WithMany(p => p.SmtpConfigs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__SmtpConfi__UserI__619B8048");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__State__3214EC07AD079630");

            entity.ToTable("State");

            entity.Property(e => e.ImgIcon).HasMaxLength(300);
            entity.Property(e => e.Name).HasMaxLength(300);

            entity.HasOne(d => d.Country).WithMany(p => p.States)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK__State__CountryId__5070F446");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
