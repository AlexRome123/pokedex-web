using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pokedex_web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            UsuarioNegocio negocio = new UsuarioNegocio();
            try
            {
                user.nombre = txtUsuario.Text;
                user.Pass = txtPassword.Text;
                if (negocio.Logear(user))
                {
                    Session.Add("usuario", user);
                    Response.Redirect("MenuLoginEjemplo.aspx");
                }
                else
                {
                    Session.Add("error", "user o pass incorrecto");
                    //EL false es para que no aparezca un error comun en .net llamada ThreadAbort
                    Response.Redirect("Error.aspx",false);
                }
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }
        }
    }
}