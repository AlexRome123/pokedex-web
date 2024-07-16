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
    public partial class Login2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Trainee aprendiz = new Trainee();
            TraineeNegocio negocio = new TraineeNegocio();
            try
            {
                if (Validacion.ValidaTxtVacio(txtContraseña) || Validacion.ValidaTxtVacio(txtEmail))
                {
                    Session.Add("error", "Debes completar ambos campos");
                    //var a generar un thread abort exepcion pero lo capturno en el catch y no hago nada...
                    Response.Redirect("Error.aspx");
                }
                aprendiz.Email = txtEmail.Text;
                aprendiz.Pass = txtContraseña.Text;
                if (negocio.Login(aprendiz))
                {
                    Session.Add("sessionActiva", aprendiz);
                    Response.Redirect("MiPerfil.aspx", false);                   
                }
                else
                {
                    Session.Add("error", "User o pass incorrectos");
                    Response.Redirect("Error.aspx",false);
                }
            }
            catch (System.Threading.ThreadAbortException ex) { }
            catch (Exception ex)
            {
                Session.Add("error",ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }
    }
}