using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{//va afuera de la clase Usuario    
    public enum TipoUsuario
    {
        NORMAL = 1,
        ADMIN = 2,
    }
    public class Usuario
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string Pass { get; set; }
        public TipoUsuario TipoUsuario { get; set; }

        public bool esAdmin(TipoUsuario tipo)
        {
            if (tipo == TipoUsuario.ADMIN)
                return true;
            else
                return false;
        }
        
        
        //if (Session["usuario"]!=null && ((dominio.Usuario) Session["usuario"]).TipoUsuario == dominio.TipoUsuario.ADMIN )
    }
}
