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
    [Migration("20220102181430_InitialMigration_3.1")]
    partial class InitialMigration_31
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
                            ID = new Guid("1a221828-8b04-40cf-a340-33657fbc33d2"),
                            Pershkrimi = "Roman"
                        },
                        new
                        {
                            ID = new Guid("2cd6e80d-47ed-4283-bc01-ad6c0c26b5ce"),
                            Pershkrimi = "Proze"
                        },
                        new
                        {
                            ID = new Guid("b52da0c1-e025-4d65-9c7b-4b4927f73339"),
                            Pershkrimi = "POezi"
                        },
                        new
                        {
                            ID = new Guid("82c60c47-22b6-40a1-b32b-7a466111c785"),
                            Pershkrimi = "Drama"
                        },
                        new
                        {
                            ID = new Guid("6f0df75c-ea14-468f-a34c-d11f27b7c79f"),
                            Pershkrimi = "Biografi"
                        },
                        new
                        {
                            ID = new Guid("c207db34-410c-47fc-86a6-cfe473e2caea"),
                            Pershkrimi = "Histori"
                        });
                });

            modelBuilder.Entity("Libraria.Entity.Entities.LIber_Perdorues", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
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
                            ID = new Guid("dbc73709-ee78-4836-9d6b-abd13e9aa51a"),
                            Pershkrimi = "I Ri"
                        },
                        new
                        {
                            ID = new Guid("3aa5581d-c694-4043-87ce-96f404bbd697"),
                            Pershkrimi = "I dhene"
                        },
                        new
                        {
                            ID = new Guid("db581937-ce22-41ef-a9b2-180addece8d1"),
                            Pershkrimi = "I Demtuar"
                        },
                        new
                        {
                            ID = new Guid("ae315071-1c5d-4d9b-8a8a-844f5e64efb0"),
                            Pershkrimi = "I Hequr"
                        },
                        new
                        {
                            ID = new Guid("aef88522-91fc-48db-b6f0-330803432c26"),
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
                            Id = "ea4c6f4f-fdd6-41c1-9cea-5d8b34f11e6f",
                            ConcurrencyStamp = "0de5e5b1-c3af-42c3-b834-35909bfc41ab",
                            Name = "Menaxher",
                            NormalizedName = "Menaxher"
                        },
                        new
                        {
                            Id = "c76cd5b5-b300-41e0-ba94-bb791e5e76e0",
                            ConcurrencyStamp = "cd121704-58af-44a4-b85f-88031907a0e7",
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
                    b.HasOne("Libraria.Entity.Entities.Lexues", "Lexues")
                        .WithMany()
                        .HasForeignKey("LexuesId");

                    b.HasOne("Libraria.Entity.Entities.Liber", "Liber")
                        .WithMany()
                        .HasForeignKey("LiberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
