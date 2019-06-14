using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FewDayStay.Models
{
    public class DBContext : DbContext
    {

        public static DBContext instanca;

        public static DBContext dajInstancu()
        {
            return instanca;
        }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
            instanca = this;
        }


        public DbSet<Iznajmljivanje> Iznajmljivanje { get; set; }
        public DbSet<Lokacija> Lokacija { get; set; }
        public DbSet<Objekat> Objekat { get; set; }
        public DbSet<Osoba> Osoba { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Iznajmljivanje>().ToTable("Iznajmljivanje");
            modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
            modelBuilder.Entity<Kuca>().ToTable("Kuca");
            modelBuilder.Entity<Lokacija>().ToTable("Lokacija");
            modelBuilder.Entity<Objekat>().ToTable("Objekat");
            modelBuilder.Entity<Osoba>().ToTable("Osoba");
            modelBuilder.Entity<Stan>().ToTable("Stan");
            modelBuilder.Entity<Vlasnik>().ToTable("Vlasnik");
        }

    }
}
