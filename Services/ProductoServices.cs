using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Avocado_Market.Data;

namespace Avocado_Market.Services
{
    public interface IProductoServices
    {
        Task<List<Producto>> Get();
        Task<Producto> Get(int id);
        Task<Producto> Add(Producto cate);
        Task<Producto> Update(Producto cate);
        Task<Producto> Delete(int id);
        Task<List<Producto>> PorCategoria(string categoria);
    }
    public class ProductoServices : IProductoServices
    {
        private readonly UsuarioContext _context;
        public ProductoServices(UsuarioContext context)
        {
            _context = context;
        }
        public async Task<List<Producto>> Get()
        {
            return await _context.Productos.ToListAsync();
        }

        public async Task<Producto> Get(int id)
        {
            var ProductoExacto = await _context.Productos.FindAsync(id);
            return ProductoExacto;
        }
        public async Task<Producto> Add(Producto cate)
        {
            _context.Productos.Add(cate);
            await _context.SaveChangesAsync();
            return cate;
        }
        public async Task<Producto> Delete(int id)
        {
            var cate = await _context.Productos.FindAsync(id);
            _context.Productos.Remove(cate);
            await _context.SaveChangesAsync();
            return cate;
        }
        public async Task<List<Producto>> PorCategoria(string categoriaa)
        {
            return await _context.Productos.Where(b=> b.Categoria == categoriaa).ToListAsync();
        }


        public async Task<Producto> Update(Producto cate)
        {
            _context.Update(cate);
            await _context.SaveChangesAsync();
            return cate;
        }
    }
}
