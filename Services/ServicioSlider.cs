using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Avocado_Market.Data;

namespace Avocado_Market.Services
{
    public interface IServicioSlider
    {
        Task<List<PaginasSlider>> Get();
        Task<PaginasSlider> Get(int id);
        Task<PaginasSlider> Add(PaginasSlider cate);
        Task<PaginasSlider> Update(PaginasSlider cate);
        Task<PaginasSlider> Delete(int id);
    }
    public class ServicioSlider : IServicioSlider
    {
        private readonly UsuarioContext _context;
        public ServicioSlider(UsuarioContext context)
        {
            _context = context;
        }
        public async Task<List<PaginasSlider>> Get()
        {
            return await _context.PaginasSlider.ToListAsync();
        }

        public async Task<PaginasSlider> Get(int id)
        {
            var PagiSliExacta = await _context.PaginasSlider.FindAsync(id);
            return PagiSliExacta;
        }
        public async Task<PaginasSlider> Add(PaginasSlider cate)
        {
            _context.PaginasSlider.Add(cate);
            await _context.SaveChangesAsync();
            return cate;
        }
        public async Task<PaginasSlider> Delete(int id)
        {
            var cate = await _context.PaginasSlider.FindAsync(id);
            _context.PaginasSlider.Remove(cate);
            await _context.SaveChangesAsync();
            return cate;
        }



        public async Task<PaginasSlider> Update(PaginasSlider cate)
        {
            _context.Update(cate);
            await _context.SaveChangesAsync();
            return cate;
        }
    }
}
