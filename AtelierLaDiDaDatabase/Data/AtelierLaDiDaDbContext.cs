﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AtelierLaDiDaDatabase.Models;

#nullable disable

namespace AtelierLaDiDaDatabase.Data
{
    public partial class AtelierLaDiDaDbContext : DbContext
    {
        public AtelierLaDiDaDbContext()
        {
        }

        public AtelierLaDiDaDbContext(DbContextOptions<AtelierLaDiDaDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ayesha> Ayesha { get; set; }
        public virtual DbSet<EschaLogy> EschaLogy { get; set; }
        public virtual DbSet<Firis> Firis { get; set; }
        public virtual DbSet<Lulua> Lulua { get; set; }
        public virtual DbSet<LydieSuelle> LydieSuelle { get; set; }
        public virtual DbSet<Rorona> Rorona { get; set; }
        public virtual DbSet<Ryza> Ryza { get; set; }
        public virtual DbSet<Sophie> Sophie { get; set; }
        public virtual DbSet<Totori> Totori { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string defaultPath = @"Data Source=D:\Rockefeller\Projects_Test\AtelierLaDiDa\AtelierLaDiDaDatabase\DataBases\atelierLaDiDa.db";
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite(Parameters.DBPath == "" ? defaultPath : Parameters.DBPath);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ayesha>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.Property(e => e.Attribute1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute5).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Japanese).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Name).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type5).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type6).HasColumnType("VARCHAR (255)");
            });

            modelBuilder.Entity<EschaLogy>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.Property(e => e.Attribute1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute5).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Japanese).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Name).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type5).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type6).HasColumnType("VARCHAR (255)");
            });

            modelBuilder.Entity<Firis>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.Property(e => e.Attribute1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute5).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Japanese).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Name).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type5).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type6).HasColumnType("VARCHAR (255)");
            });

            modelBuilder.Entity<Lulua>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.Property(e => e.Attribute1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute5).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Japanese).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Name).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type5).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type6).HasColumnType("VARCHAR (255)");
            });

            modelBuilder.Entity<LydieSuelle>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.Property(e => e.Attribute1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute5).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Japanese).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Name).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type5).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type6).HasColumnType("VARCHAR (255)");
            });

            modelBuilder.Entity<Rorona>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.Property(e => e.Attribute1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute5).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Japanese).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Name).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type5).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type6).HasColumnType("VARCHAR (255)");
            });

            modelBuilder.Entity<Ryza>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.Property(e => e.Attribute1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute5).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Japanese).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Name).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type5).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type6).HasColumnType("VARCHAR (255)");
            });

            modelBuilder.Entity<Sophie>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.Property(e => e.Attribute1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute5).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Japanese).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Name).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type5).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type6).HasColumnType("VARCHAR (255)");
            });

            modelBuilder.Entity<Totori>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.Property(e => e.No).HasColumnType("REAL (255)");

                entity.Property(e => e.Attribute1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Attribute5).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Japanese).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Name).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Source4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type1).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type2).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type3).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type4).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type5).HasColumnType("VARCHAR (255)");

                entity.Property(e => e.Type6).HasColumnType("VARCHAR (255)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}