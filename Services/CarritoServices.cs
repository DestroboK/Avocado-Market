using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Avocado_Market.Data;

namespace Avocado_Market.Services
{
    public interface ICarritoServices
    {
        Task<List<Carrito>> Get();
        Task<Carrito> Get(int id);
        Task<Carrito> Add(Carrito cate);
        Task<Carrito> Update(Carrito cate);
        Task<Carrito> Delete(int id);
    }
    public class CarritoServices : ICarritoServices
    {
        private readonly UsuarioContext _context;
        public CarritoServices(UsuarioContext context)
        {
            _context = context;
        }
        public async Task<List<Carrito>> Get()
        {
            return await _context.Carrito.ToListAsync();
        }

        public async Task<Carrito> Get(int id)
        {
            var CarritoExacta = await _context.Carrito.FindAsync(id);
            return CarritoExacta;
        }
        public async Task<Carrito> Add(Carrito cate)
        {
            _context.Carrito.Add(cate);
            await _context.SaveChangesAsync();
            return cate;
        }
        public async Task<Carrito> Delete(int id)
        {
            var cate = await _context.Carrito.FindAsync(id);
            _context.Carrito.Remove(cate);
            await _context.SaveChangesAsync();
            return cate;
        }



        public async Task<Carrito> Update(Carrito cate)
        {
            _context.Update(cate);
            await _context.SaveChangesAsync();
            return cate;
        }
    }
}
