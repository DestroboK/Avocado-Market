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
        Task<List<Categoria>> Get();
        Task<Categoria> Get(int id);
        Task<Categoria> Add(Categoria cate);
        Task<Categoria> Update(Categoria cate);
        Task<Categoria> Delete(int id);
    }
    public class ServicioSlider : IServicioSlider
    {
        private readonly UsuarioContext _context;
        public ServicioSlider(UsuarioContext context)
        {
            _context = context;
        }
        public async Task<List<Categoria>> Get()
        {
            return await _context.Categorias.ToListAsync();
        }

        public async Task<Categoria> Get(int id)
        {
            var CategoriaExacta = await _context.Categorias.FindAsync(id);
            return CategoriaExacta;
        }
        public async Task<Categoria> Add(Categoria cate)
        {
            _context.Categorias.Add(cate);
            await _context.SaveChangesAsync();
            return cate;
        }
        public async Task<Categoria> Delete(int id)
        {
            var cate = await _context.Categorias.FindAsync(id);
            _context.Categorias.Remove(cate);
            await _context.SaveChangesAsync();
            return cate;
        }



        public async Task<Categoria> Update(Categoria cate)
        {
            _context.Update(cate);
            await _context.SaveChangesAsync();
            return cate;
        }
    }
}
