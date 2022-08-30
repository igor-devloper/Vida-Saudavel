using System.Collections.Generic;
using System.Linq;
using System.Collections.Specialized;
using Hotsite.Models;
using projetohotsite.Models;

namespace Hotsite.Models
{
    public class UsuarioService
    {
        public List<Usuarios> Listar()
        {
            using(DatabaseContext bc = new DatabaseContext())
            {
                return bc.Usuario.ToList();
            }
        }

        public Usuarios Listar(int id)
        {
            using(DatabaseContext bc = new DatabaseContext())
            {
                return bc.Usuario.Find(id);
            }
        }

        public void Inserir(Usuarios usuario)
        {
            using(DatabaseContext bc = new DatabaseContext())
            {
                bc.Usuario.Add(usuario);
                bc.SaveChanges();
            }
        }

        public void Editar(Usuarios usuario)
        {
            using(DatabaseContext bc = new DatabaseContext())
            {
                Usuarios usuarios = bc.Usuario.Find(usuario.Id);

                usuarios.Nome = usuario.Nome;
                usuarios.Login = usuario.Login;
                if(usuarios.Senha != usuario.Senha)
                {
                    
                   usuarios.Senha = Criptografia.TextoCriptografado(usuarios.Senha);
                }
                else
                {
                    usuarios.Senha = usuario.Senha;
                }
                usuarios.Tipo = usuario.Tipo;

                bc.SaveChanges();
            }
        }

        public void Excluir(int id)
        {
            using(DatabaseContext bc = new DatabaseContext())
            {
                bc.Usuario.Remove(bc.Usuario.Find(id));
                bc.SaveChanges();
            }
        }
    }
}