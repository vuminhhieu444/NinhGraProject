using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GraduateSolution.Models
{
    public partial class foot_ball_sourceContext : DbContext
    {
        public foot_ball_sourceContext()
        {
        }

        public foot_ball_sourceContext(DbContextOptions<foot_ball_sourceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; } = null!;
        public virtual DbSet<Anh> Anhs { get; set; } = null!;
        public virtual DbSet<DanhMuc> DanhMucs { get; set; } = null!;
        public virtual DbSet<DanhMucCon> DanhMucCons { get; set; } = null!;
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; } = null!;
        public virtual DbSet<TinBai> TinBais { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=foot_ball_source;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.Maadmin);

                entity.ToTable("ADMIN");

                entity.Property(e => e.Maadmin)
                    .HasMaxLength(50)
                    .HasColumnName("MAADMIN");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(100)
                    .HasColumnName("GHICHU");

                entity.Property(e => e.Tenadmin)
                    .HasMaxLength(50)
                    .HasColumnName("TENADMIN");
            });

            modelBuilder.Entity<Anh>(entity =>
            {
                entity.HasKey(e => e.Maanh);

                entity.ToTable("anh");

                entity.Property(e => e.Maanh)
                    .HasMaxLength(50)
                    .HasColumnName("MAANH");

                entity.Property(e => e.Hinhanh)
                    .HasMaxLength(50)
                    .HasColumnName("HINHANH");

                entity.Property(e => e.Maadm)
                    .HasMaxLength(50)
                    .HasColumnName("MAADM");

                entity.Property(e => e.Matinbai)
                    .HasMaxLength(50)
                    .HasColumnName("MATINBAI");

                entity.Property(e => e.Noidung).HasColumnName("NOIDUNG");

                entity.Property(e => e.Tenanh)
                    .HasMaxLength(50)
                    .HasColumnName("TENANH");

                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");
            });

            modelBuilder.Entity<DanhMuc>(entity =>
            {
                entity.HasKey(e => e.Madm);

                entity.ToTable("danh_muc");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM");

                entity.Property(e => e.Mota)
                    .HasMaxLength(50)
                    .HasColumnName("MOTA");

                entity.Property(e => e.Tendm)
                    .HasMaxLength(50)
                    .HasColumnName("TENDM");
            });

            modelBuilder.Entity<DanhMucCon>(entity =>
            {
                entity.HasKey(e => e.Madmc);

                entity.ToTable("danh_muc_con");

                entity.Property(e => e.Madmc)
                    .HasMaxLength(50)
                    .HasColumnName("MADMC");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM");

                entity.Property(e => e.Mota)
                    .HasMaxLength(150)
                    .HasColumnName("MOTA");

                entity.Property(e => e.Tendmc)
                    .HasMaxLength(50)
                    .HasColumnName("TENDMC");

                entity.HasOne(d => d.MadmNavigation)
                    .WithMany(p => p.DanhMucCons)
                    .HasForeignKey(d => d.Madm)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_danh_muc_con_danh_muc");
            });

            modelBuilder.Entity<NguoiDung>(entity =>
            {
                entity.HasKey(e => e.Manguoidung)
                    .HasName("PK_Table_1");

                entity.ToTable("nguoi_dung");

                entity.Property(e => e.Manguoidung)
                    .HasMaxLength(50)
                    .HasColumnName("MANGUOIDUNG");

                entity.Property(e => e.Maadmin)
                    .HasMaxLength(50)
                    .HasColumnName("MAADMIN");

                entity.Property(e => e.Noidung).HasColumnName("NOIDUNG");

                entity.Property(e => e.Tennguoidung)
                    .HasMaxLength(50)
                    .HasColumnName("TENNGUOIDUNG");

                entity.Property(e => e.Tieude)
                    .HasMaxLength(50)
                    .HasColumnName("TIEUDE");

                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

                //entity.HasOne(d => d.MaadminNavigation)
                //    .WithMany(p => p.NguoiDungs)
                //    .HasForeignKey(d => d.Maadmin)
                //    .OnDelete(DeleteBehavior.Cascade)
                //    .HasConstraintName("FK_nguoi_dung_ADMIN");
            });

            modelBuilder.Entity<TinBai>(entity =>
            {
                entity.HasKey(e => e.Matinbai);

                entity.ToTable("tin_bai");

                entity.Property(e => e.Matinbai)
                    .HasMaxLength(50)
                    .HasColumnName("MATINBAI");

                entity.Property(e => e.Maadm)
                    .HasMaxLength(50)
                    .HasColumnName("MAADM");

                entity.Property(e => e.Madm)
                    .HasMaxLength(50)
                    .HasColumnName("MADM");

                entity.Property(e => e.Madmc)
                    .HasMaxLength(50)
                    .HasColumnName("MADMC");

                entity.Property(e => e.Noidung).HasColumnName("NOIDUNG");

                entity.Property(e => e.Tentinbai)
                    .HasMaxLength(50)
                    .HasColumnName("TENTINBAI");

                entity.Property(e => e.Thoigiandang)
                    .HasColumnType("datetime")
                    .HasColumnName("THOIGIANDANG");

                entity.Property(e => e.Tieude).HasColumnName("TIEUDE");

                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
