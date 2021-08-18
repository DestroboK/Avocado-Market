using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Avocado_Market.Data
{
    public class CarritoItems
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public double PrecioUnidad { get; set; }
        public string UrlImagen { get; set; }
        public int Unidades { get; set; }
        public int CarritoId { get; set; }
        public Carrito Carrito { get; set; }
    }
}
