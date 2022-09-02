namespace Hotsite.Models
{
    public class UsuarioService
    {
        public void Inserir(Usuarios usuario)
        {
            using(DatabaseContext bc = new DatabaseContext())
            {
                bc.Usuario.Add(usuario);
                bc.SaveChanges();
            }
        }
        
    }
}