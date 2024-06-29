using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public static class Seguridad
    {
        public static bool SesionActiva(object user)
        {
            //si es distinto de nulo transformar en trainee sino es nulo
            Trainee aprendiz = user != null ? (Trainee)user : null;
            if (!(aprendiz != null && aprendiz.Id != 0))
                return true;
            return false;
        }
        public static bool esAdmin(object user)
        {
            if (user == null)
                return false;
            return  ((Trainee)user).Admin;
        }

    }
}
