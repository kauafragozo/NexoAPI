using Microsoft.EntityFrameworkCore;
using NexoApi.Models;

namespace NexoApi.Data
{


    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base(options)
        {
            
        }

        public DbSet<Cliente> Clientes { get; set;}
        public DbSet<ClienteDetalhe> ClientesDetalhes { get; set;}
        public DbSet<Usuario> Usuarios { get; set;}

    }
}