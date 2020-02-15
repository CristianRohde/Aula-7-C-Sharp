using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aula7.Models; // temos que ter a referença 

namespace Aula7.Controllers
{
    public class UsuarioController : Controller
    {
        private static UsuarioTeste _usuarios = new UsuarioTeste();
        public IActionResult Index()
        {
           
            return View(_usuarios.listaUsuario);
        }
        public IActionResult AdicionarUsuario() // Metodo Get
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdicionarUsuario(UsuarioModel usuarioModel) // Metodo Post
        {
            _usuarios.CriaUsuario(usuarioModel);
            return View();
        }
    }
}