using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace negocio
{
    public class TraineeNegocio
    {
        public void actualizar(Trainee user)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update USERS set imagenPerfil = @imagenPerfil, nombre = @Nombre, apellido = @Apellido, fechaNacimiento = @fechaNacimiento Where id = @Id");
                datos.setearParametro("@Nombre", user.Nombre);
                datos.setearParametro("@Apellido", user.Apellido);
                datos.setearParametro("@fechaNacimiento", user.FechaNacimiento);
                //si imagen perfil es distinto de nulo entonces masndar user perfil sino mandar nulo casteado a object
                datos.setearParametro("@imagenPerfil", user.ImagenPerfil != null ? user.ImagenPerfil : (object)DBNull.Value);
                datos.setearParametro("@Id", user.Id);
                datos.ejecutarAccion();
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
                datos.setearConsulta("select id, email,pass,admin,nombre,apellido,fechaNacimiento,imagenPerfil from USERS where email=@email and pass=@pass");
                datos.setearParametro("@email",aprendiz.Email);
                datos.setearParametro("@pass", aprendiz.Pass);
                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    aprendiz.Id = (int)datos.Lector["id"];
                    aprendiz.Admin = (bool)datos.Lector["admin"];
                    if (!(datos.Lector["nombre"] is DBNull))
                        aprendiz.Nombre = (string)datos.Lector["nombre"];
                    if (!(datos.Lector["apellido"] is DBNull))
                        aprendiz.Apellido = (string)datos.Lector["apellido"];
                    if (!(datos.Lector["fechaNacimiento"] is DBNull))
                        //como e lector devuelve un objet hay que trasnfomralo en string por que lo requiere el .parse
                        // de objet a string y de string a dateTime
                        aprendiz.FechaNacimiento = DateTime.Parse(datos.Lector["fechaNacimiento"].ToString());
                    if (!(datos.Lector["imagenPerfil"] is DBNull))
                        aprendiz.ImagenPerfil = (string)datos.Lector["imagenPerfil"];
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
