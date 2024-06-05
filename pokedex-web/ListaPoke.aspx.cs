using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;

namespace pokedex_web
{
    public partial class ListaPoke : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            dgvPokemon.DataSource = negocio.listarConSP();
            dgvPokemon.DataBind();
        }
    }
}