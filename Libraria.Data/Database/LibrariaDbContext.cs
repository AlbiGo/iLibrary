using Libraria.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Libraria.Data.Database
{
    public class LibrariaDbContext : DbContext//IdentityDbContext<Perdorues>, IDisposable
    {
        public LibrariaDbContext(DbContextOptions<LibrariaDbContext> options)
           : base(options)
        {

        }
      
        public DbSet<Liber> Librat { get; set; }
        public DbSet<StatusLibri> Statuset { get; set; }
        public DbSet<Perdorues> Perdoruesit { get; set; }
        public DbSet<KategoriLibri> Kategorite { get; set; }
        public DbSet<LIber_Perdorues> LIber_Perdorues { get; set; }
        public DbSet<Lexues> Lexuesit { get; set; }
        public DbSet<Inventari> inventari { get; set; }
        public DbSet<KerkeseMarrjeLibri> Kerkesat { get; set; }
        public DbSet<TipiLeshimLibri> TipiLeshimLibri { get; set; }
        public DbSet<KthimLibri> KthimLibri { get; set; }
        public DbSet<StatusKthimLibri> StatusKthimLibri { get; set; }
        public DbSet<MarrjeLibri> MarrjeLibri { get; set; }
        public DbSet<KerkesePrind> KerkesatPrind { get;set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(_appConfig.Connection);
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            _ = modelBuilder.Entity<TipiLeshimLibri>().HasData(
                new Entity.Entities.TipiLeshimLibri
                {
                    Id = 1,
                    Pershkrimi = "Leshim prane sportelit"
                },
                new Entity.Entities.TipiLeshimLibri
                {
                    Id = 2,
                    Pershkrimi = "Leshim me kerkese online"
                }
                );
            modelBuilder.Entity<StatusKthimLibri>().HasData(
              new Entity.Entities.TipiLeshimLibri
              {
                  Id = 1,
                  Pershkrimi = "I rregullt"
              },
              new Entity.Entities.TipiLeshimLibri
              {
                  Id = 2,
                  Pershkrimi = "I demtuar"
              },
               new Entity.Entities.TipiLeshimLibri
               {
                   Id = 3,
                  Pershkrimi = "I vonuar"
              }
              );

            modelBuilder.Entity<IdentityRole>().HasData(
              new IdentityRole
              {
                  Name = "Menaxher",
                  NormalizedName = "Menaxher"
              },
               new IdentityRole()
               {
                   Name = "Punonjese Sporteli",
                   NormalizedName = "Punonjese Sporteli"
               }

             );

            modelBuilder.Entity<StatusLibri>().HasData(
                new StatusLibri
                { Pershkrimi = "I Lire", ID = Guid.NewGuid() },
                new StatusLibri
                { Pershkrimi = "I dhene", ID = Guid.NewGuid() },
                 new StatusLibri
               { Pershkrimi = "I Demtuar", ID = Guid.NewGuid() },
               new StatusLibri
                 { Pershkrimi = "I Hequr", ID = Guid.NewGuid() },
                 new StatusLibri
                 { Pershkrimi = "I Mbaruar", ID = Guid.NewGuid() }
                );
            modelBuilder.Entity<KategoriLibri>().HasData(
                new KategoriLibri
                { ID = Guid.NewGuid(),
                Pershkrimi = "Roman"},
                  new KategoriLibri
                  {
                      ID = Guid.NewGuid(),
                      Pershkrimi = "Proze"
                  }, new KategoriLibri
                  {
                      ID = Guid.NewGuid(),
                      Pershkrimi = "POezi"
                  }, new KategoriLibri
                  {
                      ID = Guid.NewGuid(),
                      Pershkrimi = "Drama"
                  },
                  new KategoriLibri
                  {
                      ID = Guid.NewGuid(),
                      Pershkrimi = "Biografi"
                  },
                    new KategoriLibri
                    {
                        ID = Guid.NewGuid(),
                        Pershkrimi = "Histori"
                    }
                );
        }
    }
}
