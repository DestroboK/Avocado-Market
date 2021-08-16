using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Avocado_Market.Data
{
    public class PaginasSlider
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public byte[] Imagen { get; set; }
        public string UrlImagen { get; set; }
    }
}
