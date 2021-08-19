using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Avocado_Market.Services
{
    public interface IUsuarioService
    {
        List<IdentityUser> Get();
        Task<bool> EsAdmin(IdentityUser usuario);
        Task DarAdmin(string usuario);
        Task QuitarAdmin(string usuario);

    }
    public class UsuarioService : IUsuarioService
    {
        private readonly UserManager<IdentityUser> userManager;

        public UsuarioService(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }

        public List<IdentityUser> Get()
        {
         
            var users = userManager.Users.ToList();
            
            return users;
        }

        public async Task<bool> EsAdmin(IdentityUser usuario)
        {
            IdentityUser usu = usuario;
            bool Admin = await userManager.IsInRoleAsync(usu, "Administrador");
            return Admin;
        }
        public async Task DarAdmin(string usuario)
        {
            IdentityUser usu = await userManager.FindByIdAsync(usuario);
            await userManager.AddToRoleAsync(usu, "Administrador");
        }

        public async Task QuitarAdmin(string usuario)
        {
            IdentityUser usu = await userManager.FindByIdAsync(usuario);
            await userManager.RemoveFromRoleAsync(usu, "Administrador");
        }

    }
}

