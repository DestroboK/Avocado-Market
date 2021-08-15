using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Avocado_Market.Data
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }
    }
}
