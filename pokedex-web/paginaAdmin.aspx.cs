using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace pokedex_web
{
    public partial class paginaAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario user = (Usuario)Session["usuario"];
            if(!(user!=null && user.TipoUsuario == TipoUsuario.ADMIN))
            {
                Session.Add("error", "no tienes acceso para entrar");
                Response.Redirect("error.aspx", false);
            }
        }
    }
}