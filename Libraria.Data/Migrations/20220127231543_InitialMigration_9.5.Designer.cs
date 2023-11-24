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
    [Migration("20220127231543_InitialMigration_9.5")]
    partial class InitialMigration_95
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Libraria.Entity.Entities.Inventari", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LiberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("NevojePerFurnuzim")
                        .HasColumnType("bit");

                    b.Property<int?>("SasiaNeMagazine")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("LiberId");

                    b.ToTable("inventari");
                });

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
                            ID = new Guid("f70b4da5-d6b3-4f07-88c1-64425db594d0"),
                            Pershkrimi = "Roman"
                        },
                        new
                        {
                            ID = new Guid("b0184d22-d658-4e59-9e72-5282b98eb826"),
                            Pershkrimi = "Proze"
                        },
                        new
                        {
                            ID = new Guid("b7a0fb4f-5f35-495c-b318-21d580756200"),
                            Pershkrimi = "POezi"
                        },
                        new
                        {
                            ID = new Guid("a4775a0a-0aec-40f2-8168-f74fad1de86c"),
                            Pershkrimi = "Drama"
                        },
                        new
                        {
                            ID = new Guid("97c25aa3-4dcf-4b47-a26a-7cecc24e9b96"),
                            Pershkrimi = "Biografi"
                        },
                        new
                        {
                            ID = new Guid("ad8214cd-455e-41b4-a3d3-39b0e2fc5d90"),
                            Pershkrimi = "Histori"
                        });
                });

            modelBuilder.Entity("Libraria.Entity.Entities.KerkeseMarrjeLibri", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataAprovimit")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataKerkese")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataKthimit")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataMarrjes")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataRefuzimit")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataTerheqjes")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DitelindjaLexuesit")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmerLexuesi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("KerksesaPrind")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("KerkuesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LiberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MbiemerLexuesi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Kerkesat");
                });

            modelBuilder.Entity("Libraria.Entity.Entities.KerkesePrind", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataAprovimit")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataKerkese")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataKthimit")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataMarrjes")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataRefuzimit")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataTerheqjes")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DitelindjaLexuesit")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmerLexuesi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("KerkuesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MbiemerLexuesi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NmrLibrave")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("KerkesatPrind");
                });

            modelBuilder.Entity("Libraria.Entity.Entities.KthimLibri", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataKthimit")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("MarrjeLIbri")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("StatusKthimLibri")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("KthimLibri");
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

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

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

                    b.Property<DateTime?>("DataSkadimitTeKartes")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Datelindja")
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

                    b.Property<string>("NmrId")
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

            modelBuilder.Entity("Libraria.Entity.Entities.MarrjeLibri", b =>
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

                    b.Property<Guid?>("KerkeseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LexuesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LiberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("TipiLeshimit")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AprovuesId");

                    b.HasIndex("LexuesId");

                    b.HasIndex("LiberId");

                    b.ToTable("MarrjeLibri");
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

            modelBuilder.Entity("Libraria.Entity.Entities.StatusKthimLibri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Pershkrimi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StatusKthimLibri");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Pershkrimi = "I rregullt"
                        },
                        new
                        {
                            Id = 2,
                            Pershkrimi = "I demtuar"
                        },
                        new
                        {
                            Id = 3,
                            Pershkrimi = "I vonuar"
                        });
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
                            ID = new Guid("5f99bb83-34d5-41d3-bd7c-38fb1e59efb9"),
                            Pershkrimi = "I Lire"
                        },
                        new
                        {
                            ID = new Guid("e9bdfece-c091-42c9-acbe-32ddcba96790"),
                            Pershkrimi = "I dhene"
                        },
                        new
                        {
                            ID = new Guid("d55d3ff3-f371-468b-a3d5-7da539d42862"),
                            Pershkrimi = "I Demtuar"
                        },
                        new
                        {
                            ID = new Guid("a7e8d29a-4ace-47fd-858c-9e5e639c6717"),
                            Pershkrimi = "I Hequr"
                        },
                        new
                        {
                            ID = new Guid("1b6f6b0f-78af-49d9-9205-ab47e793406b"),
                            Pershkrimi = "I Mbaruar"
                        });
                });

            modelBuilder.Entity("Libraria.Entity.Entities.TipiLeshimLibri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Pershkrimi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipiLeshimLibri");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Pershkrimi = "Leshim prane sportelit"
                        },
                        new
                        {
                            Id = 2,
                            Pershkrimi = "Leshim me kerkese online"
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
                            Id = "5536c480-072a-4bb8-85ce-edce9c3ea14f",
                            ConcurrencyStamp = "292191d0-bdd1-48b9-bf25-cef0e13837e0",
                            Name = "Menaxher",
                            NormalizedName = "Menaxher"
                        },
                        new
                        {
                            Id = "4cdc4c85-f810-4f83-b55d-c7c6b697b351",
                            ConcurrencyStamp = "40bad497-08a6-443d-be07-95fb0b52cde3",
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

            modelBuilder.Entity("Libraria.Entity.Entities.Inventari", b =>
                {
                    b.HasOne("Libraria.Entity.Entities.Liber", "Liber")
                        .WithMany()
                        .HasForeignKey("LiberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Liber");
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

            modelBuilder.Entity("Libraria.Entity.Entities.MarrjeLibri", b =>
                {
                    b.HasOne("Libraria.Entity.Entities.Perdorues", "Aprovues")
                        .WithMany()
                        .HasForeignKey("AprovuesId");

                    b.HasOne("Libraria.Entity.Entities.Lexues", "Lexues")
                        .WithMany()
                        .HasForeignKey("LexuesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Libraria.Entity.Entities.Liber", "Liber")
                        .WithMany()
                        .HasForeignKey("LiberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aprovues");

                    b.Navigation("Lexues");

                    b.Navigation("Liber");
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
