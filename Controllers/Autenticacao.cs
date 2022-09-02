using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Hotsite.Models;
using System.Linq;
using System.Collections.Generic;


namespace projetohotsite.Controllers
{
  public class Autenticacao
  {
    public static void CheckLogin(Controller controller)
    {
      if (string.IsNullOrEmpty(controller.HttpContext.Session.GetString("Login")))
      {
        controller.Request.HttpContext.Response.Redirect("/Home/Login");
      }
    }

    public static bool verificaLoginSenha(string login, string senha, Controller controller)
    {
      using (DatabaseContext bc = new DatabaseContext())
      {
       
        IQueryable<Usuarios> UsuarioEncontrado = bc.Usuario.Where(u => u.Login == login && u.Senha == senha);

        List<Usuarios> ListaUsuarios = UsuarioEncontrado.ToList();

        if (ListaUsuarios.Count == 0)
        {
          return false;
        }
        else
        {
          controller.HttpContext.Session.SetString("Login", ListaUsuarios[0].Login);
          return true;
        }
      }
    }

  }
}
