using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avocado_Market.Data;

namespace Avocado_Market.Services
{
    public interface IUsuarioService
    {
        List<Usuario> Get();
        Task<bool> EsAdmin(Usuario usuario);
        Task DarAdmin(string usuario);
        Task QuitarAdmin(string usuario);

    }
    public class UsuarioService : IUsuarioService
    {
        private readonly UserManager<Usuario> userManager;

        public UsuarioService(UserManager<Usuario> userManager)
        {
            this.userManager = userManager;
        }

        public List<Usuario> Get()
        {
         
            var users = userManager.Users.ToList();
            
            return users;
        }

        public async Task<bool> EsAdmin(Usuario usuario)
        {
            Usuario usu = usuario;
            bool Admin = await userManager.IsInRoleAsync(usu, "Administrador");
            return Admin;
        }
        public async Task DarAdmin(string usuario)
        {
            Usuario usu = await userManager.FindByIdAsync(usuario);
            await userManager.AddToRoleAsync(usu, "Administrador");
        }

        public async Task QuitarAdmin(string usuario)
        {
            Usuario usu = await userManager.FindByIdAsync(usuario);
            await userManager.RemoveFromRoleAsync(usu, "Administrador");
        }

    }
}

