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
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                Trainee user = new Trainee();
                TraineeNegocio negocio = new TraineeNegocio();
                EmailService Service = new EmailService();
                user.Email = txtEmail.Text;
                user.Pass = txtContraseña.Text;
                user.Id = negocio.insertarNuevo(user);
                Session.Add("sessionActiva", user);

                Service.armarCorreo(user.Email, "Bienvenido Trainee", "Hola te damos la bienvenida a la app");
                Service.enviarMail();
                Response.Redirect("Default.aspx", false);
            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
            }
        }
    }
}