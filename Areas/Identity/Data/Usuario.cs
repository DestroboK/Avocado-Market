using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace Avocado_Market.Data
{
    public class Usuario : IdentityUser
    {
        public DateTime FechaNac {get; set;}
    }
}