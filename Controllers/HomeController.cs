using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hotsite.Models;
using Microsoft.AspNetCore.Http;
using projetohotsite.Controllers;

namespace Biblioteca.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string login, string senha)
        {
            if(Autenticacao.verificaLoginSenha(login, senha, this))
            {
                return RedirectToAction("Index");
            }
            else
            {   
                ViewData["Erro"] = "Senha e/ou email invalidos";
                return View();
            }
        }

        [HttpPost]

        public IActionResult CadastrarInteresse(Interesse cad)
        {
            try{
                DatabaseService dbs = new DatabaseService();
                dbs.CadastraInteresse(cad);
                return View("Index");
            }
            catch(Exception){
                _logger.LogError("ERRO AO ENVIAR CADASTRA DE INTERESSE");
                return View("ERRO", cad);
            }
        }
    }
}
