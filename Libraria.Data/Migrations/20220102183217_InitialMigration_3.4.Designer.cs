﻿// <auto-generated />
using System;
using Libraria.Data.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Libraria.Data.Migrations
{
    [DbContext(typeof(LibrariaDbContext))]
    [Migration("20220102183217_InitialMigration_3.4")]
    partial class InitialMigration_34
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Libraria.Entity.Entities.KategoriLibri", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Pershkrimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Kategorite");

                    b.HasData(
                        new
                        {
                            ID = new Guid("017aca3e-1fce-4a59-b111-5f8c843baf78"),
                            Pershkrimi = "Roman"
                        },
                        new
                        {
                            ID = new Guid("9e1e6acb-f78e-4ab8-885a-a12408a324a7"),
                            Pershkrimi = "Proze"
                        },
                        new
                        {
                            ID = new Guid("9aba367c-7855-42cf-9517-29734a74151f"),
                            Pershkrimi = "POezi"
                        },
                        new
                        {
                            ID = new Guid("80b6b45d-aa29-49b6-bbc7-364fb5412aa3"),
                            Pershkrimi = "Drama"
                        },
                        new
                        {
                            ID = new Guid("b78cd81e-a162-464a-979f-9cb00d4aff13"),
                            Pershkrimi = "Biografi"
                        },
                        new
                        {
                            ID = new Guid("30baaa61-651d-4500-a18f-e39ff5ac66a3"),
                            Pershkrimi = "Histori"
                        });
                });

            modelBuilder.Entity("Libraria.Entity.Entities.LIber_Perdorues", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AfatiKthimit")
                        .HasColumnType("datetime2");

                    b.Property<string>("AprovuesId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid?>("Aprovuesi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataKthimit")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataMarrjes")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LexuesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LiberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("AprovuesId");

                    b.HasIndex("LexuesId");

                    b.HasIndex("LiberId");

                    b.ToTable("LIber_Perdorues");
                });

            modelBuilder.Entity("Libraria.Entity.Entities.Lexues", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataRegj")
                        .HasColumnType("datetime2");

                    b.Property<string>("Emri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FotoProfiliURl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Karta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KarteLeximiURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mbiemri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Statusi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Lexuesit");
                });

            modelBuilder.Entity("Libraria.Entity.Entities.Liber", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Autori")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataPerditesimit")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataRegj")
                        .HasColumnType("datetime2");

                    b.Property<string>("FotoLibbriUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FotoLibri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("KategoriID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Kategoria")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Pershkrimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Sasia")
                        .HasColumnType("int");

                    b.Property<Guid?>("StatusID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Statusi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Titulli")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vendi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("KategoriID");

                    b.HasIndex("StatusID");

                    b.ToTable("Librat");
                });

            modelBuilder.Entity("Libraria.Entity.Entities.Perdorues", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataRegj")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Emri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FotoProfiliURl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Mbiemri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Statusi")
                        .HasColumnType("bit");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Libraria.Entity.Entities.StatusLibri", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Pershkrimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Statuset");

                    b.HasData(
                        new
                        {
                            ID = new Guid("75edb802-c6da-4301-8068-6837b82529b6"),
                            Pershkrimi = "I Ri"
                        },
                        new
                        {
                            ID = new Guid("72169f93-9374-4f9e-9d8e-f6bcafee4601"),
                            Pershkrimi = "I dhene"
                        },
                        new
                        {
                            ID = new Guid("66c0806d-1cbd-4f30-9781-4dc42ede484c"),
                            Pershkrimi = "I Demtuar"
                        },
                        new
                        {
                            ID = new Guid("14826c95-e937-4eb4-bba7-f752a794f1e9"),
                            Pershkrimi = "I Hequr"
                        },
                        new
                        {
                            ID = new Guid("9888d08a-5dec-4724-adb4-9344b2480c4a"),
                            Pershkrimi = "I Mbaruar"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "baec6bea-def0-43e8-84da-37992d510c10",
                            ConcurrencyStamp = "2a0a779a-efda-4d15-9377-3ea6621b22b0",
                            Name = "Menaxher",
                            NormalizedName = "Menaxher"
                        },
                        new
                        {
                            Id = "c94fbb4b-c2c2-4bbb-9e15-8cb931799eb9",
                            ConcurrencyStamp = "4b015ee2-e5a3-4bae-9c69-143aedc6ba58",
                            Name = "Punonjese Sporteli",
                            NormalizedName = "Punonjese Sporteli"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Libraria.Entity.Entities.LIber_Perdorues", b =>
                {
                    b.HasOne("Libraria.Entity.Entities.Perdorues", "Aprovues")
                        .WithMany()
                        .HasForeignKey("AprovuesId");

                    b.HasOne("Libraria.Entity.Entities.Lexues", "Lexues")
                        .WithMany()
                        .HasForeignKey("LexuesId");

                    b.HasOne("Libraria.Entity.Entities.Liber", "Liber")
                        .WithMany()
                        .HasForeignKey("LiberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aprovues");

                    b.Navigation("Lexues");

                    b.Navigation("Liber");
                });

            modelBuilder.Entity("Libraria.Entity.Entities.Liber", b =>
                {
                    b.HasOne("Libraria.Entity.Entities.KategoriLibri", "Kategori")
                        .WithMany()
                        .HasForeignKey("KategoriID");

                    b.HasOne("Libraria.Entity.Entities.StatusLibri", "Status")
                        .WithMany()
                        .HasForeignKey("StatusID");

                    b.Navigation("Kategori");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Libraria.Entity.Entities.Perdorues", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Libraria.Entity.Entities.Perdorues", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Libraria.Entity.Entities.Perdorues", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Libraria.Entity.Entities.Perdorues", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}