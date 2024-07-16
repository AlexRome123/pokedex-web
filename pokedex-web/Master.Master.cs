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
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Trainee user = (Trainee)Session["sessionActiva"];
            imgAvatar.ImageUrl = "https://thumbs.dreamstime.com/b/icono-del-perfil-del-placeholder-del-defecto-90197993.jpg";
            if (!(Page is Login2 || Page is Registro || Page is Default || Page is Error))
            {
                if (Seguridad.SesionActiva(user))
                    Response.Redirect("Login2.aspx", false);
            }
            if (!(Seguridad.SesionActiva(user)))
            {
                lblUsuario.Text = user.Email;
                lblUsuario.ForeColor = System.Drawing.Color.White;
                if (!string.IsNullOrEmpty(user.ImagenPerfil))
                                                                           //fuerza a que refresque la imagen del cache
                    imgAvatar.ImageUrl = "~/Imagenes/"+user.ImagenPerfil + "?v=" + DateTime.Now.Ticks.ToString();
            }
        }
        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Default.aspx");
            
        }
    }
}