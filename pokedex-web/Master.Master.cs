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
            if (!(Page is Login2 || Page is Registro || Page is Default))
            {
                if (Seguridad.SesionActiva(Session["sessionActiva"]))
                    Response.Redirect("Login2.aspx", false);
            }
        }
    }
}