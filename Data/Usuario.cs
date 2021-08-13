using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Avocado_Market.Data
{
    public class Usuario
    {
        public string Email { get; set; }
        public string Password {get; set;}
    }
}