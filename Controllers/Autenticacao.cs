using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Hotsite.Models;
using System.Linq;
using System.Collections.Generic;
using projetohotsite.Models;

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
        verificaAdminExiste();

        senha = Criptografia.TextoCriptografado(senha);

        IQueryable<Usuarios> UsuarioEncontrado = bc.Usuario.Where(u => u.Login == login && u.Senha == senha);

        List<Usuarios> ListaUsuarios = UsuarioEncontrado.ToList();

        if (ListaUsuarios.Count == 0)
        {
          return false;
        }
        else
        {
          controller.HttpContext.Session.SetString("Login", ListaUsuarios[0].Login);
          controller.HttpContext.Session.SetInt32("Tipo", ListaUsuarios[0].Tipo);
          return true;
        }
      }
    }

    public static void verificaUsuarioAdmin(Controller controller)
    {
      if (!(controller.HttpContext.Session.GetInt32("Tipo") == Usuarios.ADMIN))
      {
        controller.Request.HttpContext.Response.Redirect("/Usuario/Permissao");
      }
    }

    public static void verificaAdminExiste()
    {
      using (DatabaseContext bc = new DatabaseContext())
      {

        IQueryable<Usuarios> userAdmin = bc.Usuario.Where(u => u.Login == "admin");

        if (userAdmin.ToList().Count == 0)
        {
          Usuarios novoAdm = new Usuarios();
          novoAdm.Nome = "Administrador";
          novoAdm.Login = "admin";
          novoAdm.Senha = Criptografia.TextoCriptografado("123");
          novoAdm.Tipo = Usuarios.ADMIN;

          bc.Usuario.Add(novoAdm);
          bc.SaveChanges();
        }
      }
    }

  }
}
