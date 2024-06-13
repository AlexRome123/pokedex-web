using dominio;
using negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pokedex_web
{
    public partial class Repeater : System.Web.UI.Page
    {
        public List<Pokemon> Lista { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            Lista = negocio.listarConSP();

            //si lanzo un evento que esta en este mismo formulario que no vuelva a cargar la lista
            //sino tira error
            if (!IsPostBack)
            {
                repRepeticion.DataSource = Lista;
                repRepeticion.DataBind();
            }
        }

        protected void btnEjemplo_Click(object sender, EventArgs e)
        {
            //para extraer el argumento que lleva el evento del boton
            string valor = ((Button)sender).CommandArgument;
        }
    }
}