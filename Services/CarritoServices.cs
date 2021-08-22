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
        Task<Carrito> Get(string correo);
        Task<List<CarritoItems>> GetItems(int id);
        Task<Carrito> Add(Carrito cate);
        Task AgregarItem (Producto producto, Carrito carrito);
        Task<Carrito> Update(Carrito cate);
        Task<Carrito> Delete(int id);
        Task<CarritoItems> Deleteee(int id, string nombre);
        Task Delete(List<CarritoItems> Items);
    }
    public class CarritoServices : ICarritoServices
    {
        private readonly UsuarioContext _context;
        public CarritoServices(UsuarioContext context)
        {
            _context = context;
        }
        public async Task<Carrito> Get(string correo)
        {
             Carrito CarritoExacto = _context.Carrito
                    .Where(b => b.Email == correo)
                    .FirstOrDefault();

            if (CarritoExacto == null)
                {
                    Carrito Nuevo = new Carrito();
                    Nuevo.Email = correo;
                    _context.Carrito.Add(Nuevo);
                    await _context.SaveChangesAsync();
                    return Nuevo;
                }
            return CarritoExacto;

        }

        public async Task AgregarItem(Producto producto, Carrito carrito)
        {
            CarritoItems item = new CarritoItems();
            item.Nombre = producto.Nombre;
            item.PrecioUnidad = producto.PrecioUnidad;
            item.Categoria = producto.Categoria;
            item.UrlImagen = producto.UrlImagen;
            item.CarritoId = carrito.Id;
            _context.ItemsCarrito.Add(item);
            await _context.SaveChangesAsync();
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

      public async Task<CarritoItems> Deleteee(int id, string nombre)
        {
            var produc =  _context.Productos.Where(b=> b.Nombre == nombre ).FirstOrDefault();
            produc.UnidadesDisponibles++;
             _context.Productos.Update(produc);
            var cate = await _context.ItemsCarrito.FindAsync(id);
            _context.ItemsCarrito.Remove(cate);
            await _context.SaveChangesAsync();
            return cate;
        }

        public async Task Delete(List<CarritoItems> Items)
        {
            foreach (CarritoItems item in Items){
                var cate = await _context.ItemsCarrito.FindAsync(item.Id);
                _context.ItemsCarrito.Remove(cate);
                            await _context.SaveChangesAsync();
            }
        }


        public async Task<Carrito> Update(Carrito cate)
        {
            _context.Update(cate);
            await _context.SaveChangesAsync();
            return cate;
        }



        public async Task<List<CarritoItems>> GetItems(int id)
        {
            List<CarritoItems> items = _context.ItemsCarrito.Where(b => b.CarritoId == id).ToList();
            return items;
        }
    }
}
