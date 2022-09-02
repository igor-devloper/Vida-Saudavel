using Hotsite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projetohotsite.Controllers;


namespace Biblioteca.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(Usuarios user)
        {
            Autenticacao.CheckLogin(this);
            new UsuarioService().Inserir(user);
            return Redirect("/Home/Index");
        }


        public IActionResult Permissao()
        {
            Autenticacao.CheckLogin(this);        
            return View();
        }
        
        
        public IActionResult Sair()
        {
            HttpContext.Session.Clear();  
            return RedirectToAction("Login","Home");
        }

    }


}