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
        Task Add(Carrito carrito, List<CarritoItems> ItemsAComprar, double lat, double lng, double costetotal, string comentario);
        Task<Orden> Update(Orden cate);
        Task<Orden> Delete(int id);
        Task<List<Orden>> Get(string correo);
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
        public async Task Add(Carrito carrito, List<CarritoItems> ItemsAComprar, double lat, double lng, double costetotal, string comentario)
        {
            Orden ordenNueva = new Orden();
            ordenNueva.email = carrito.Email;
            ordenNueva.Estado = "En proceso";
            ordenNueva.Latitud = lat;
            ordenNueva.Longitud = lng;
            ordenNueva.CosteTotal = costetotal;
            ordenNueva.Comentario = comentario;
            foreach(CarritoItems item in ItemsAComprar)
            {
                ordenNueva.CosteTotal = costetotal;
                ItemsPedido Items = new ItemsPedido();
                Items.Nombre = item.Nombre;
                Items.Orden = ordenNueva;
                Items.OrdenId = ordenNueva.Id;
                Items.UrlImagen = item.UrlImagen;
                Items.Categoria = item.Categoria;
                Items.PrecioUnidad = item.PrecioUnidad;
                Items.Unidades = item.Unidades;
                _context.ItemsOrden.Add(Items);
            }
            _context.Ordenes.Add(ordenNueva);
            await _context.SaveChangesAsync();
        }
        public async Task<Orden> Delete(int id)
        {
            var cate = await _context.Ordenes.FindAsync(id);
            _context.Ordenes.Remove(cate);
            await _context.SaveChangesAsync();
            return cate;
        }







        public async Task<List<Orden>> Get(string correo)
        {
            var Ordenes = _context.Ordenes
                   .Where(b => b.email == correo).ToList();
            return Ordenes;

        }


        public async Task<Orden> Update(Orden cate)
        {
            _context.Update(cate);
            await _context.SaveChangesAsync();
            return cate;
        }
    }
}
