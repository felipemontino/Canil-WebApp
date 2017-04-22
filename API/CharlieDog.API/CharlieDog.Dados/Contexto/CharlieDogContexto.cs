using CharlieDog.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;

namespace CharlieDog.Dados.Contexto
{
    public class CharlieDogContexto : DbContext
    {
        public CharlieDogContexto(DbContextOptions options) :
             base(options)
        {

        }

        public DbSet<Cachorro> Cachorros { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Raca> Racas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Model Configuration Cachorro

            modelBuilder.Entity<Cachorro>().HasKey(c => c.Id);

            modelBuilder.Entity<Cachorro>().Property(c => c.Nome)
                                           .IsRequired()
                                           .HasMaxLength(250);

            modelBuilder.Entity<Cachorro>().Property(c => c.Idade)
                                           .IsRequired();

            modelBuilder.Entity<Cachorro>().Property(c => c.Preco)
                                           .IsRequired();

            #endregion

            #region Model Configuration Cliente

            modelBuilder.Entity<Cliente>().HasKey(c => c.Id);

            modelBuilder.Entity<Cliente>().Property(c => c.Nome)
                                          .IsRequired()
                                          .HasMaxLength(250);

            modelBuilder.Entity<Cliente>().Property(c => c.CPF)
                                          .IsRequired()
                                          .HasMaxLength(50);

            #endregion

            #region Model Configuration Compra

            modelBuilder.Entity<Compra>().HasKey(c => c.Id);

            modelBuilder.Entity<Compra>().Property(c => c.EnderecoEntrega)
                                         .HasMaxLength(1000);

            modelBuilder.Entity<Compra>().Property(c => c.Data)
                                         .HasDefaultValue(DateTime.Now);

            #endregion

            #region Model Configuration Raca

            modelBuilder.Entity<Raca>().HasKey(r => r.Id);

            modelBuilder.Entity<Raca>().Property(r => r.Nome)
                                       .IsRequired()
                                       .HasMaxLength(250);

            modelBuilder.Entity<Raca>().Property(r => r.Nome)
                                       .IsRequired();

            #endregion

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("CharlieDog");
        }
    }
}
