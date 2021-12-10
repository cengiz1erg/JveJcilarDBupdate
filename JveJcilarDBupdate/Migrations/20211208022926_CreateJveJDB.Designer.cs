﻿// <auto-generated />
using System;
using JveJcilarDBupdate.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JveJcilarDBupdate.Migrations
{
    [DbContext(typeof(CafeContext))]
    [Migration("20211208022926_CreateJveJDB")]
    partial class CreateJveJDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JveJcilarDBupdate.Models.KafeBilgi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("EklenmeZamani")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("KafeBilgileri");
                });

            modelBuilder.Entity("JveJcilarDBupdate.Models.Kat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime>("EklenmeZamani")
                        .HasColumnType("datetime2");

                    b.Property<int>("KafeBilgiId")
                        .HasColumnType("int");

                    b.Property<string>("Kod")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int>("Sira")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KafeBilgiId");

                    b.ToTable("Katlar");
                });

            modelBuilder.Entity("JveJcilarDBupdate.Models.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Ad")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("EklenmeZamani")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Fotograf")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("JveJcilarDBupdate.Models.Masa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime>("EklenmeZamani")
                        .HasColumnType("datetime2");

                    b.Property<int>("KatId")
                        .HasColumnType("int");

                    b.Property<bool>("MasaDurumu")
                        .HasColumnType("bit");

                    b.Property<int>("Sira")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KatId");

                    b.ToTable("Masalar");
                });

            modelBuilder.Entity("JveJcilarDBupdate.Models.Siparis", b =>
                {
                    b.Property<int>("MasaId")
                        .HasColumnType("int");

                    b.Property<int>("UrunId")
                        .HasColumnType("int");

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<DateTime>("EklenmeZamani")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Fiyat")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("MasaId", "UrunId");

                    b.HasIndex("UrunId");

                    b.ToTable("Siparisler");
                });

            modelBuilder.Entity("JveJcilarDBupdate.Models.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("EklenmeZamani")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Fiyat")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<byte[]>("Fotograf")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("JveJcilarDBupdate.Models.Kat", b =>
                {
                    b.HasOne("JveJcilarDBupdate.Models.KafeBilgi", "kafeBilgi")
                        .WithMany("Katlar")
                        .HasForeignKey("KafeBilgiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("kafeBilgi");
                });

            modelBuilder.Entity("JveJcilarDBupdate.Models.Masa", b =>
                {
                    b.HasOne("JveJcilarDBupdate.Models.Kat", "Kat")
                        .WithMany("Masalar")
                        .HasForeignKey("KatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kat");
                });

            modelBuilder.Entity("JveJcilarDBupdate.Models.Siparis", b =>
                {
                    b.HasOne("JveJcilarDBupdate.Models.Masa", "Masa")
                        .WithMany()
                        .HasForeignKey("MasaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JveJcilarDBupdate.Models.Urun", "Urun")
                        .WithMany()
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Masa");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("JveJcilarDBupdate.Models.Urun", b =>
                {
                    b.HasOne("JveJcilarDBupdate.Models.Kategori", "Kategori")
                        .WithMany("Urunler")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("JveJcilarDBupdate.Models.KafeBilgi", b =>
                {
                    b.Navigation("Katlar");
                });

            modelBuilder.Entity("JveJcilarDBupdate.Models.Kat", b =>
                {
                    b.Navigation("Masalar");
                });

            modelBuilder.Entity("JveJcilarDBupdate.Models.Kategori", b =>
                {
                    b.Navigation("Urunler");
                });
#pragma warning restore 612, 618
        }
    }
}
