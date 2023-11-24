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
    [Migration("20220101175055_InitialMigration_4.3")]
    partial class InitialMigration_43
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
                            ID = new Guid("245109b9-5676-4376-a7b2-b764a8655856"),
                            Pershkrimi = "Roman"
                        },
                        new
                        {
                            ID = new Guid("788ed9ab-b180-4232-ba7f-a04866fde64f"),
                            Pershkrimi = "Proze"
                        },
                        new
                        {
                            ID = new Guid("ab543f57-6053-4b23-8393-40b841ae6dcd"),
                            Pershkrimi = "POezi"
                        },
                        new
                        {
                            ID = new Guid("649c6dfd-54ba-4ddc-ac57-1f98574a167f"),
                            Pershkrimi = "Drama"
                        },
                        new
                        {
                            ID = new Guid("f587a6aa-b8ca-4650-852a-a40265b1ff2e"),
                            Pershkrimi = "Biografi"
                        },
                        new
                        {
                            ID = new Guid("dbbae162-83a7-459c-a27d-20702e8bc0bc"),
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

                    b.Property<Guid>("LiberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PerdoruesId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("LiberId");

                    b.HasIndex("PerdoruesId");

                    b.ToTable("LIber_Perdorues");
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

                    b.Property<Guid?>("KategoriID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Kategoria")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Pershkrimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            ID = new Guid("430faf67-6a1a-4db0-b6d1-53b379dba55b"),
                            Pershkrimi = "I Ri"
                        },
                        new
                        {
                            ID = new Guid("6ab92f9c-a18d-46ca-9f5c-4cf95e328ffa"),
                            Pershkrimi = "I dhene"
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
                            Id = "2ce597c4-e0fb-42b2-a207-733d00d0efeb",
                            ConcurrencyStamp = "c3fc3a84-0a61-4805-8631-04fd094a988e",
                            Name = "Menaxher",
                            NormalizedName = "Menaxher"
                        },
                        new
                        {
                            Id = "e1e3015b-8da5-4d0d-ac2f-82388ed8c09b",
                            ConcurrencyStamp = "d84dd19d-6a75-4d90-9e4f-1592bed7b6de",
                            Name = "User",
                            NormalizedName = "User"
                        },
                        new
                        {
                            Id = "92bdc2af-c2f6-41b8-9c6c-49471e6c4699",
                            ConcurrencyStamp = "e9aba5a5-c380-4413-a7c5-98fd9aef296c",
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
                    b.HasOne("Libraria.Entity.Entities.Liber", "Liber")
                        .WithMany()
                        .HasForeignKey("LiberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Libraria.Entity.Entities.Perdorues", "Perdorues")
                        .WithMany()
                        .HasForeignKey("PerdoruesId");

                    b.Navigation("Liber");

                    b.Navigation("Perdorues");
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
