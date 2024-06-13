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
    public partial class DetallePoke : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            try
            {
                //si el pokemon es nuevo
                if (!IsPostBack)
                {
                    ElementoNegocio negocio = new ElementoNegocio();
                    List<Elemento> lista = negocio.listar();

                    dpDebilidad.DataSource = lista;
                    dpDebilidad.DataValueField = "Id";
                    dpDebilidad.DataTextField = "Descripcion";
                    dpDebilidad.DataBind();
                    dpTipo.DataSource = lista;
                    dpTipo.DataValueField = "Id";
                    dpTipo.DataTextField = "Descripcion";
                    dpTipo.DataBind();
                }
                //si el pokemon es modificado
                if (Request.QueryString["id"] !=null && !IsPostBack)
                {
                    string id = Request.QueryString["id"];
                    PokemonNegocio negocio = new PokemonNegocio();
                    //List<Pokemon> lista = negocio.listar(Request.QueryString["id"]);
                    //Pokemon seleccionado = lista[0];
                    Pokemon seleccionado = negocio.listar(id)[0];

                    txtId.Text = id;
                    //se hace todo texto plano por que es lo que lee el navegador
                    txtNumero.Text = seleccionado.Numero.ToString();
                    txtNombre.Text = seleccionado.Nombre;
                    txtDescripcion.Text = seleccionado.Descripcion;
                    txtUrlImagen.Text = seleccionado.UrlImagen;
                    dpDebilidad.SelectedValue = seleccionado.Debilidad.Id.ToString();
                    dpTipo.SelectedValue = seleccionado.Tipo.Id.ToString();
                    UrlImagen_TextChanged(sender, e);

                }


            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Pokemon nuevo = new Pokemon();
                PokemonNegocio negocio = new PokemonNegocio();

                nuevo.Numero = int.Parse(txtNumero.Text);
                nuevo.Nombre = txtNombre.Text;
                nuevo.Descripcion = txtDescripcion.Text;
                nuevo.UrlImagen = txtUrlImagen.Text;
                nuevo.Debilidad = new Elemento();
                nuevo.Debilidad.Id = int.Parse(dpDebilidad.SelectedValue);
                nuevo.Tipo = new Elemento();
                nuevo.Tipo.Id = int.Parse(dpTipo.SelectedValue);

                if (Request.QueryString["id"] != null)
                {
                    nuevo.Id = int.Parse(Request.QueryString["id"]);
                    negocio.modificarConSp(nuevo);
                }
                else
                    negocio.agregarConSp(nuevo);
                Response.Redirect("ListaPoke.aspx", false);
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }
        }

        protected void UrlImagen_TextChanged(object sender, EventArgs e)
        {
            ImagePoke.ImageUrl = txtUrlImagen.Text;
        }
    }
}