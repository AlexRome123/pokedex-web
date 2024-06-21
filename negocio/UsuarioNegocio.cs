using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class UsuarioNegocio
    {
        public bool Logear (Usuario usuario)
        {
			AccesoDatos datos = new AccesoDatos ();
			try
			{
				datos.setearConsulta("select Id,TipoUser from USUARIOS where Usuario = @nombre and Pass = @pass");
				datos.setearParametro("@nombre", usuario.nombre);
				datos.setearParametro("@pass", usuario.Pass);
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					usuario.Id = (int)datos.Lector["Id"];
					usuario.TipoUsuario = (TipoUsuario)datos.Lector["TipoUser"];
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				datos.cerrarConexion();
			}
        }
    }
}
