using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Avocado_Market.Data;
namespace Avocado_Market.Data
{
    public class UsuarioContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Carrito> Carrito { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Orden> Ordenes { get; set; }
        public DbSet<PaginasSlider> PaginasSlider { get; set; }
        public DbSet<CarritoItems> ItemsCarrito { get; set; }
        
        public DbSet<Producto> Productos { get; set; }
        public UsuarioContext(DbContextOptions<UsuarioContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
