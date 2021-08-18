using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Avocado_Market.Data
{
    public class Orden
    {
        [Key]
        public int Id { get; set; }
        public string email { get; set; }
        public string Estado { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public double CosteTotal {get; set;}
        public string Comentario { get; set; }

        public List<ItemsPedido> Items { get; set; }


    }
}
