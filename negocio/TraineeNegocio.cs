using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class TraineeNegocio
    {
        public int insertarNuevo(Trainee nuevo)
        { 
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearProcedimiento("InsertarNuevo");
                datos.setearParametro("@Email",nuevo.Email);
                datos.setearParametro("@Pass",nuevo.Pass);
                return datos.ejecutarAccionScalar();
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
        public bool Login(Trainee aprendiz)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select id, email,pass,admin from USERS where email=@email and pass=@pass");
                datos.setearParametro("@email",aprendiz.Email);
                datos.setearParametro("@pass", aprendiz.Pass);
                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    aprendiz.Id = (int)datos.Lector["id"];
                    aprendiz.Admin = (bool)datos.Lector["admin"];
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
