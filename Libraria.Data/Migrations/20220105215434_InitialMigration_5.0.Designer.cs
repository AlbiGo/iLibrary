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
    [Migration("20220105215434_InitialMigration_5.0")]
    partial class InitialMigration_50
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
                            ID = new Guid("d2122ed1-53a0-45a1-8d53-1233d9006625"),
                            Pershkrimi = "Roman"
                        },
                        new
                        {
                            ID = new Guid("0a51a235-a412-4429-9b4b-2695e4e10f88"),
                            Pershkrimi = "Proze"
                        },
                        new
                        {
                            ID = new Guid("508786f6-ff6a-405a-bb5e-c11d6bb6d7e7"),
                            Pershkrimi = "POezi"
                        },
                        new
                        {
                            ID = new Guid("b7b6ae6b-23d0-4eb4-985e-f6093003a40e"),
                            Pershkrimi = "Drama"
                        },
                        new
                        {
                            ID = new Guid("59ea5dfb-8a86-43ab-a999-299210a8fdb8"),
                            Pershkrimi = "Biografi"
                        },
                        new
                        {
                            ID = new Guid("3a8d0a13-bfaf-4f6e-a9d3-283e451a27e7"),
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

                    b.Property<DateTime?>("DataPerditesimit")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataRegj")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("FotoLibbriUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FotoLibri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("KategoriID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Kategoria")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Pershkrimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("StatusID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Statusi")
                        .IsRequired()
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
                            ID = new Guid("ef49fee9-b1b6-4b42-aded-408ae3d2598e"),
                            Pershkrimi = "I Ri"
                        },
                        new
                        {
                            ID = new Guid("0b4010a1-c3b7-4b4c-bcaf-f0a2b8ee461e"),
                            Pershkrimi = "I dhene"
                        },
                        new
                        {
                            ID = new Guid("94222a4b-6e2a-4c43-8165-35427ff93555"),
                            Pershkrimi = "I Demtuar"
                        },
                        new
                        {
                            ID = new Guid("12140ea9-c9a5-4fdf-9b17-02861eb3974a"),
                            Pershkrimi = "I Hequr"
                        },
                        new
                        {
                            ID = new Guid("a7f87518-fc28-4c29-afd0-c6ebfb7767be"),
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
                            Id = "45b2abf8-2fe5-4675-aa24-21fa57137595",
                            ConcurrencyStamp = "4fde201b-f4b5-4b4a-ba82-27279f9df1c4",
                            Name = "Menaxher",
                            NormalizedName = "Menaxher"
                        },
                        new
                        {
                            Id = "05a76f8d-169c-4c86-ae90-d1498f3bd71d",
                            ConcurrencyStamp = "322afe52-2670-4b22-85bd-5ce880fbe80a",
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
