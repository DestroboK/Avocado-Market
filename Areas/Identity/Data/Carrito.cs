using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Avocado_Market.Data
{
    public class Carrito
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public List<Producto> Productos { get; set; }
    }
}
