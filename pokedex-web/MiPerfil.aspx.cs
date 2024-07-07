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
    public partial class MiPerfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Trainee user = (Trainee)Session["sessionActiva"];
                if (!(Seguridad.SesionActiva(user)))
                {
                    txtEmail.Text = user.Email;
                    txtEmail.Enabled = false;
                    txtNombre.Text = user.Nombre;
                    txtApellido.Text = user.Apellido;
                    if (user.ImagenPerfil != null)
                        imgNewPerfil.ImageUrl = "~/Imagenes/" + user.ImagenPerfil; 
                                        // este es el fomrato que espera el txt tipo date
                    txtNacimieto.Text = user.FechaNacimiento.ToString("yyyy-MM-dd");
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                TraineeNegocio negocio = new TraineeNegocio();
                //escribir
                Trainee user = (Trainee)Session["sessionActiva"];
                if (txtImagen.PostedFile.FileName != "")
                {
                    string ruta = Server.MapPath("./Imagenes/");
                    txtImagen.PostedFile.SaveAs(ruta+ "perfil-" + user.Id + ".jpg");
                    user.ImagenPerfil = "perfil-" + user.Id + ".jpg";
                }
                user.Nombre = txtNombre.Text;
                user.Apellido = txtApellido.Text;
                user.FechaNacimiento = DateTime.Parse(txtNacimieto.Text);
                negocio.actualizar(user);

                //leer
                //Image img = (Image)Master.FindControl("imgAvatar");
                //img.ImageUrl = "~/Imagenes/" + user.ImagenPerfil;
                Response.Redirect("Default.aspx");
            }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
            }
        }
    }
}