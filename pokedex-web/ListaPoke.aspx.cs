using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace pokedex_web
{
    public partial class ListaPoke : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PokemonNegocio negocio = new PokemonNegocio();
                Session.Add("listaPoke", negocio.listarConSP());
                dgvPokemon.DataSource = Session["listaPoke"];
                dgvPokemon.DataBind();
            }

        }

        protected void dgvPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = dgvPokemon.SelectedDataKey.Value.ToString();
            Response.Redirect("DetallePoke.aspx?id=" + id);
        }

        protected void dgvPokemon_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvPokemon.DataSource = Session["listaPoke"];
            dgvPokemon.PageIndex = e.NewPageIndex;
            dgvPokemon.DataBind();
        }

        protected void busqueda_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> lista = (List<Pokemon>)Session["listaPoke"];
            List<Pokemon> listaFiltrada = lista.FindAll(x => x.Nombre.ToUpper().Contains(txtBusqueda.Text.ToUpper()));
            dgvPokemon.DataSource = listaFiltrada;
            dgvPokemon.DataBind();
        }

        protected void cbFiltroAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            txtBusqueda.Enabled = !cbFiltroAvanzado.Checked;
        }

        protected void ddlCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlCriterio.Items.Clear();
            if(ddlCampo.SelectedItem.ToString() == "Número")
            {
                ddlCriterio.Items.Add("Igual a");
                ddlCriterio.Items.Add("Menor a");
                ddlCriterio.Items.Add("Mayor a");
            }
            else
            {
                ddlCriterio.Items.Add("Contiene");
                ddlCriterio.Items.Add("Empieza con");
                ddlCriterio.Items.Add("Termina con");
            }

        }

        protected void btnBuscar2_Click(object sender, EventArgs e)
        {
            try
            {
                PokemonNegocio negocio = new PokemonNegocio();
                dgvPokemon.DataSource = negocio.filtrar(ddlCampo.SelectedItem.ToString(), 
                ddlCriterio.SelectedItem.ToString(), txtFiltro.Text, ddlEstado.SelectedItem.ToString());
                dgvPokemon.DataBind();
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }
        }
    }
}