using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Avocado_Market.Data;

namespace Avocado_Market.Services
{
    public interface IOrdenServices
    {
        Task<List<Orden>> Get();
        Task<Orden> Get(int id);
        Task<Orden> Add(Orden cate);
        Task<Orden> Update(Orden cate);
        Task<Orden> Delete(int id);
    }
    public class OrdenServices : IOrdenServices
    {
        private readonly UsuarioContext _context;
        public OrdenServices(UsuarioContext context)
        {
            _context = context;
        }
        public async Task<List<Orden>> Get()
        {
            return await _context.Ordenes.ToListAsync();
        }

        public async Task<Orden> Get(int id)
        {
            var OrdenExacta = await _context.Ordenes.FindAsync(id);
            return OrdenExacta;
        }
        public async Task<Orden> Add(Orden cate)
        {
            _context.Ordenes.Add(cate);
            await _context.SaveChangesAsync();
            return cate;
        }
        public async Task<Orden> Delete(int id)
        {
            var cate = await _context.Ordenes.FindAsync(id);
            _context.Ordenes.Remove(cate);
            await _context.SaveChangesAsync();
            return cate;
        }



        public async Task<Orden> Update(Orden cate)
        {
            _context.Update(cate);
            await _context.SaveChangesAsync();
            return cate;
        }
    }
}
