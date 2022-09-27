using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPageMarketFruit
{
    public class DBContext : DbContext
    {
        public DbSet<Usuarios> Usuario { get; set; } = default!;
        public DbSet<UsuariosRegistrados> UsuarioRegistrado { get; set; } = default!;
        public DbSet<UsuariosTiendas> UsuarioTienda { get; set; } = default!;
        public DbSet<Pedidos> Pedido { get; set; } = default!;
        public DbSet<Domicilios> Domicilio { get; set; } = default!;
        public DbSet<Compras> Compra { get; set; } = default!;
        public DbSet<Catalogo> Catalogos { get; set; } = default!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MarketData");
            }
        }
    }
}