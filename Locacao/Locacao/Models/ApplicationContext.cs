using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locacao.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>().HasKey(t => t.Id);
            //modelBuilder.Entity<Usuario>().HasMany(t=>t.res)

            modelBuilder.Entity<Veiculo>().HasKey(t => t.Id);

            

            modelBuilder.Entity<Reserva>().HasKey(t => t.Id);
            modelBuilder.Entity<Reserva>().HasOne(t => t.usuario);
            modelBuilder.Entity<Reserva>().HasOne(t => t.Veiculo);


            modelBuilder.Entity<Pedido>().HasKey(t => t.Id);
            modelBuilder.Entity<Pedido>().HasOne(t => t.Reserva);
            modelBuilder.Entity<Pedido>().HasMany(t => t.Status).WithOne(t=>t.Pedido);

            modelBuilder.Entity<StatusPedido>().HasKey(t => t.Id);
            //modelBuilder.Entity<StatusPedido>().HasMany(t => t.Pedido);//.WithMany(t=>t.);

        }
    }
}
